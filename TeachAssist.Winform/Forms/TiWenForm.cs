using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TeachAssist.BLL;
using TeachAssist.Utils;
using TeachAssist.Winform.Global;

namespace TeachAssist.Winform.Forms
{
    public partial class TiWenForm : BaseForm
    {
        TiwenService service = new();
        Random random = new();
        DataTable students = new();
        DataTable groups = null;
        List<string> pickIds = new();
        bool isGroupMode = false;

        // 构造器

        public TiWenForm()
        {
            InitializeComponent();

            LoadStudents();
            InitGridViews();

            RefreshPickList();
        }

        // 核心方法

        void LoadStudents()
        {
            students = service.GetAllStudent();
            dvStudents.DataSource = students;
        }

        void LoadGroups()
        {
            groups = service.GetAllGroup();
            dvGroups.DataSource = groups;
        }

        void InitGridViews()
        {
            dvStudents.Columns[0].Visible = false;
            dvStudents.Columns[1].HeaderText = "名";
            dvStudents.Columns[2].HeaderText = "组";
            dvStudents.Columns[3].HeaderText = "次";
            dvStudents.Columns[4].HeaderText = "分";
            dvStudents.RowHeadersWidth = 20;
            //dvStudents.RowTemplate.Height = 20;
            //dvStudents.ColumnHeadersHeight = 20;
            dvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvStudents.BackgroundColor = Color.White;
            dvStudents.BorderStyle = BorderStyle.FixedSingle;
            dvStudents.AllowUserToAddRows = false;
            dvStudents.AllowUserToDeleteRows = false;
            dvStudents.AllowUserToResizeRows = false;
            dvStudents.AllowUserToResizeColumns = false;
            dvStudents.EditMode = DataGridViewEditMode.EditProgrammatically;

            dvGroups.Visible = false;
            dvGroups.RowHeadersWidth = 20;
            //dvGroups.RowTemplate.Height = 20;
            //dvGroups.ColumnHeadersHeight = 20;
            dvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvGroups.BackgroundColor = Color.White;
            dvGroups.BorderStyle = BorderStyle.FixedSingle;
            dvGroups.AllowUserToAddRows = false;
            dvGroups.AllowUserToDeleteRows = false;
            dvGroups.AllowUserToResizeRows = false;
            dvGroups.AllowUserToResizeColumns = false;
            dvGroups.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        void FilterGridViews()
        {
            if (isGroupMode)
            {
                try
                {
                    var dv = groups.AsDataView();
                    dv.RowFilter = this.tbFilter.Text;
                    dvGroups.DataSource = dv.ToTable();
                    dvGroups.Refresh();
                }
                catch
                {
                    dvGroups.DataSource = groups;
                    dvGroups.Refresh();
                }
            }
            else
            {
                try
                {
                    var dv = students.AsDataView();
                    dv.RowFilter = this.tbFilter.Text;
                    dvStudents.DataSource = dv.ToTable();
                    dvStudents.Refresh();
                }
                catch
                {
                    dvStudents.DataSource = students;
                    dvStudents.Refresh();
                }
            }
        }

        void RefreshPickList()
        {
            this.fpList.Controls.Clear();
            foreach (var id in pickIds)
            {
                var student = GetStudentById(id);
                var label = new Label
                {
                    Text = student["name"].ToString(),
                    Tag = student["id"],
                    Padding = new Padding(5, 5, 5, 5),
                    Margin = new Padding(0, 0, 5, 5),
                    AutoSize = true,
                    ForeColor = Color.Black
                };
                label.MouseClick += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        RefreshPickView(id);
                    }
                    else
                    {
                        this.pickIds.Remove(id);
                        RefreshPickList();
                    }
                };
                this.fpList.Controls.Add(label);
            }

            RefreshPickView(this.pickIds.LastOrDefault());
        }

        void RefreshPickView(string id)
        {
            if (id == null)
            {
                this.lbName.Text = "--";
                this.lbName.Tag = null;
                this.lbInfo.Text = "没有描述";
                this.pbAvatar.Image = null;
            }
            else
            {
                var student = GetStudentById(id);

                this.lbName.Text = student["name"].ToString();
                this.lbName.Tag = id; // 可以让控件携带一点数据。相当于一个变量
                this.lbInfo.Text = $"分数: {student["fs"]}\n次数: {student["cs"]}";

                var avatar = $"{SysParams.AvatarDir}\\{id}.jpg";
                var img = File.Exists(avatar) ? new Bitmap(avatar) : Properties.Resources.NoAvatar;
                this.pbAvatar.Image = img;
                this.pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }

            foreach (Label c in this.fpList.Controls)
            {
                c.ForeColor = c.Tag as string == id ? Color.Red : Color.Black;
            }
        }

        void FocusInPickList(string id)
        {
            this.dvStudents.CurrentCell =
                this.dvStudents.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value.ToString() == id)
                    .FirstOrDefault()
                    ?.Cells[1];
        }

        void ManualPick()
        {
            if (isGroupMode)
            {
                if (this.dvGroups.SelectedRows.Count != 1)
                {
                    MessageBox.Show("请先选中其中一个组");
                }
                else
                {
                    object id = this.dvGroups.SelectedRows[0].Cells[0].Value;
                    PickGroup((int)id);
                }
            }
            else
            {
                if (this.dvStudents.SelectedRows.Count < 1)
                {
                    MessageBox.Show("请先选中再点名");
                }
                else
                {
                    var toAddList = this.dvStudents.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(r => r.Cells[0].Value.ToString())
                        .Except(pickIds);

                    this.pickIds = this.pickIds.Concat(toAddList).ToList();
                    RefreshPickList();
                }
            }
        }

        void RandomPick()
        {
            if (isGroupMode)
            {
                var rows = this.dvGroups.SelectedRows.Count < 1
                    ? this.dvGroups.Rows.Cast<DataGridViewRow>()
                    : this.dvGroups.SelectedRows.Cast<DataGridViewRow>();

                var id = rows
                    .Select(r => r.Cells[0].Value.ToString())
                    .OrderBy(_ => random.Next(100))
                    .FirstOrDefault();

                if (id != null)
                {
                    PickGroup(int.Parse(id));
                }
            }
            else
            {
                var rows = this.dvStudents.SelectedRows.Count < 1
                    ? this.dvStudents.Rows.Cast<DataGridViewRow>()
                    : this.dvStudents.SelectedRows.Cast<DataGridViewRow>();

                var id = rows
                    .Select(r => r.Cells[0].Value.ToString())
                    .Except(pickIds)
                    .OrderBy(_ => random.Next(100))
                    .FirstOrDefault();

                if (id != null)
                {
                    this.pickIds.Add(id);
                    RefreshPickList();
                }
            }
        }

        void PickGroup(int gno)
        {
            this.pickIds = this.students.Select($"gno = {gno}")
                .Cast<DataRow>()
                .Select(r => r[0].ToString())
                .ToList();
            RefreshPickList();
        }

        void DoScores()
        {
            if (isGroupMode)
            {
                if (this.pickIds.Count != 0)
                {
                    var frm = new TiWenFormPrompt(this.pickIds.Select(id => GetStudentById(id)).ToArray());
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadGroups();
                        this.pickIds.Clear();
                        RefreshPickList();
                    }
                }
            }
            else
            {
                if (this.lbName.Tag == null)
                    return;

                var id = this.lbName.Tag as string;
                var frm = new TiWenFormPrompt(GetStudentById(id));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                    this.pickIds.Remove(id);
                    RefreshPickList();
                    FocusInPickList(id);
                }
            }
        }

        // 辅助方法

        DataRow GetStudentById(string id)
        {
            return students.Select($"id = '{id}'")[0];
        }

        void FocusPrevOrNext(bool prev = false)
        {
            if (this.pickIds.Count == 0)
                return;

            string focusId = this.pickIds[0];
            if (this.lbName.Tag is string id)
            {
                var index = this.pickIds.IndexOf(id);
                if (prev)
                {
                    focusId = this.pickIds[index == 0 ? 0 : index - 1];
                }
                else
                {
                    var len = this.pickIds.Count;
                    focusId = this.pickIds[index == len - 1 ? len - 1 : index + 1];
                }
            }
            RefreshPickView(focusId);
        }

        // 事件绑定

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.ActiveControl.Name != "tbFilter")
            {
                switch (keyData)
                {
                    case Keys.Left:
                        FocusPrevOrNext(true);
                        return true;
                    case Keys.Right:
                        FocusPrevOrNext();
                        return true;
                    case Keys.Space:
                        if (this.lbName.Tag != null)
                        {
                            var student = GetStudentById(this.lbName.Tag as string);
                            CommonUtils.Speak($"{student["name"].ToString()}, 请回答");
                        }
                        return true;
                    case Keys.D:
                        DoScores();
                        return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tbFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterGridViews();
            }
        }

        private void btManual_Click(object sender, EventArgs e)
        {
            ManualPick();
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            RandomPick();
        }

        private void pbClearList_Click(object sender, EventArgs e)
        {
            this.pickIds.Clear();
            RefreshPickList();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            DoScores();
        }

        private void btMode_Click(object sender, EventArgs e)
        {
            isGroupMode = !isGroupMode;

            if (isGroupMode)
            {
                LoadGroups();
                btMode.Text = "组模式";
            }
            else
            {
                LoadStudents();
                btMode.Text = "默认模式";
            }

            dvGroups.Visible = isGroupMode;
            dvStudents.Visible = !isGroupMode;
        }
    }
}
