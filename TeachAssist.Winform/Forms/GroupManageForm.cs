using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeachAssist.BLL;

namespace TeachAssist.Winform.Forms
{
    public partial class GroupManageForm : BaseForm
    {
        DataTable groups = null;
        DataTable students = null;
        StudentService studentService = new();

        public GroupManageForm()
        {
            InitializeComponent();

            InitData();
            LoadToPanels();
        }

        void InitData()
        {
            var ds = studentService.GetStudentsAndGroups();
            groups = ds.Tables["gp"];
            students = ds.Tables["st"];
        }

        void LoadToPanels()
        {
            var studentLabels = students.Rows.Cast<DataRow>()
                .Select(r => CreateStudentControl(r)).ToList();

            var groupPanels = groups.Rows.Cast<DataRow>()
                .Select(r => CreateGroupControl(r)).ToList();

            foreach (var student in studentLabels)
            {
                var gno = (student.Tag as DataRow)["gno"];
                if (!Convert.IsDBNull(gno) && (int)gno <= groupPanels.Count)
                {
                    var group = groupPanels[((int)gno) - 1];
                    group.Controls.Add(student);
                    if ((group.Tag as DataRow)["stuid"].ToString() == (student.Tag as DataRow)["id"].ToString())
                    {
                        group.Controls.SetChildIndex(student, 0);
                    }
                }
                else
                {
                    todoBox.Controls.Add(student);
                }
            }
        }

        Label CreateStudentControl(DataRow studentRow)
        {
            var studentLabel = new Label
            {
                Text = studentRow["name"].ToString(),
                Margin = new Padding(5, 5, 5, 5),
                Padding = new Padding(5, 2, 5, 2),
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = studentRow
            };
            studentLabel.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {
                    studentLabel.Parent.Controls.SetChildIndex(studentLabel, 0);
                }
                else
                {
                    studentLabel.DoDragDrop(studentLabel, DragDropEffects.Move);
                }
            };
            return studentLabel;
        }

        Panel CreateGroupControl(DataRow groupRow = null)
        {
            var groupPanel = new MyFlowLayoutPanel
            {
                BackColor = Color.White,
                MinimumSize = new Size(180, 40),
                MaximumSize = new Size(200, 250),
                Padding = new Padding(9, 6, 3, 6),
                Margin = new Padding(5, 5, 5, 5),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ContextMenuStrip = groupContext,
                Tag = groupRow
            };
            groupPanel.AllowDrop = true;
            groupPanel.DragOver += (s, e) => e.Effect = DragDropEffects.Move;
            groupPanel.DragDrop += DoDrop;

            groupBox.Controls.Add(groupPanel);
            RefreshGroupNumbers();

            return groupPanel;
        }

        void RefreshGroupNumbers()
        {
            var gs = this.groupBox.Controls.Cast<MyFlowLayoutPanel>().ToArray();
            for (int i = 0; i < gs.Length; i++)
            {
                var g = gs[i];
                g.Text = $"{i + 1}";
                g.Invalidate(); // 强制控件重绘
            }
        }

        void RemoveGroupControl(MyFlowLayoutPanel groupPanel)
        {
            foreach (var c in groupPanel.Controls.Cast<Control>().ToArray())
            {
                todoBox.Controls.Add(c);
            }
            groupPanel.Parent.Controls.Remove(groupPanel);

            RefreshGroupNumbers();
        }

        void DoDrop(object sender, DragEventArgs e)
        {
            var target = sender as FlowLayoutPanel;
            var source = e.Data.GetData(e.Data.GetFormats()[0]);

            if (source is Label)
            {
                target.Controls.Add(source as Label);
            }
        }

        void DoSave()
        {
            var groups = this.groupBox.Controls
                .OfType<MyFlowLayoutPanel>()
                .Select((g, i) =>
                {
                    var id = i + 1;
                    var leader = (g.Controls[0].Tag as DataRow)["id"].ToString();
                    var members = g.Controls.Cast<Label>().Select(s => (s.Tag as DataRow)["id"].ToString()).ToList();
                    return (id, leader, members);
                })
                .ToList();
            studentService.SaveGroups(groups);
        }

        // 事件

        private void btNew_Click(object sender, EventArgs e)
        {
            CreateGroupControl();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (this.groupBox.Controls.Cast<MyFlowLayoutPanel>().Any(g => g.Controls.Count == 0))
            {
                MessageBox.Show("保存前请确保没有空组存在！");
                return;
            }
            if (MessageBox.Show("保存后将完全丢失原先的分组信息，是否继续？", "保存提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DoSave();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("点击确定将会丢失所有修改，是否继续？", "重置提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.todoBox.Controls.Clear();
                this.groupBox.Controls.Clear();

                InitData();
                LoadToPanels();
            }
        }

        private void groupDelItemMenu_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var source = (item.Owner as ContextMenuStrip).SourceControl;

            RemoveGroupControl(source as MyFlowLayoutPanel);
        }
    }

    class MyFlowLayoutPanel : FlowLayoutPanel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using var brush = new SolidBrush(Color.Gray);
            e.Graphics.DrawString(Text, new Font("monospace", 9), brush, new Point(0, 0));
        }
    }
}
