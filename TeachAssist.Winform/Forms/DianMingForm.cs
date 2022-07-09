using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TeachAssist.BLL;
using TeachAssist.Models;
using TeachAssist.Utils;
using TeachAssist.Winform.Global;

namespace TeachAssist.Winform.Forms
{
    public partial class DianMingForm : BaseForm
    {
        StudentService service = new();
        List<Button> studentButtons = new();

        Timer timer;
        int current = 0;
        bool isAutoRolling = false;

        Color defColor = Color.White;
        Color doneColor = Color.LightYellow;
        Color absentColor = Color.LightGreen;
        Color lockColor = SystemColors.ControlLight;

        public DianMingForm()
        {
            InitializeComponent();
            InitStudentButtons();
            BindButtonEvents();

            this.ParentChanged += (s, e) =>
            {
                isAutoRolling = false;
            };
        }

        #region // 绘制页面

        void InitStudentButtons()
        {
            // 加载
            var ss = service.GetAllStudent();

            // 排序
            var ssOrdered =
                Shuffer(ss.Where(s => s.State == 1).ToList())
                .Concat(ss.Where(s => s.State != 1))
                .ToList();

            // 转换
            studentButtons = ssOrdered.Select(s => CreateStudentButton(s)).ToList();

            // 渲染
            RenderStudents();
        }

        void RenderStudents()
        {
            current = 0;

            // Display
            this.stname.Text = "Ready?";
            this.avatarBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.avatarBox.BackColor = defColor;
            this.avatarBox.Image = Properties.Resources.NoAvatar; ;

            // Button Box
            this.mingdan.Controls.Clear();
            foreach (Button button in studentButtons)
            {
                this.mingdan.Controls.Add(button);
            }
        }

        Button CreateStudentButton(Student student)
        {
            var button = new Button()
            {
                Text = student.Name,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(5, 5, 5, 2),
                BackColor = student.State == 1 ? defColor : lockColor,
                Tag = student
            };
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = button.BackColor;

            button.MouseDown += (s, e) =>
            {
                isAutoRolling = false;
                if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {
                    isAutoRolling = false;
                    CallCurrent();
                }
                else if (e.Button == MouseButtons.Left)
                {
                    MarkAsCurrent(s as Button);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    MarkAsAbsent(s as Button);
                }
            };
            return button;
        }

        #endregion

        #region // 点名逻辑

        /// <summary>
        /// 点名当前选中的人
        /// </summary>
        void CallCurrent(Button button = null)
        {
            if (button == null)
            {
                button = studentButtons[current];
            }
            MarkAsCurrent(button);
            if (button.BackColor != doneColor)
            {
                button.BackColor = doneColor;
            }
            CommonUtils.Speak(button.Text);
        }

        /// <summary>
        /// 点名当前选中的人，如果当前已点，则点名下一个
        /// </summary>
        void CallNext()
        {
            if (studentButtons[current].BackColor == defColor)
            {
                CallCurrent();
            }
            else
            {
                if (CheckFinished())
                {
                    AfterRollCall();
                    return;
                }
                for (int i = current + 1; i < current + studentButtons.Count; i++)
                {
                    var next = studentButtons[i % studentButtons.Count];
                    if (next.BackColor == defColor)
                    {
                        CallCurrent(next);
                        break;
                    }
                }
            }
        }

        void MarkAsCurrent(Button button)
        {
            current = studentButtons.IndexOf(button);

            button.Focus();
            studentButtons.ForEach(bt =>
            {
                if (bt.FlatStyle == FlatStyle.Standard)
                {
                    bt.FlatStyle = FlatStyle.Flat;
                }
            });
            button.FlatStyle = FlatStyle.Standard;

            var student = button.Tag as Student;
            var avatar = $"{SysParams.AvatarDir}\\{student.Id}.jpg";
            this.avatarBox.Image = File.Exists(avatar) ? new Bitmap(avatar) : Properties.Resources.NoAvatar;
            this.stname.Text = student.Name;
        }

        void MarkAsAbsent(Button button)
        {
            if (button.BackColor == absentColor)
            {
                var student = button.Tag as Student;
                button.BackColor = student.State == 1 ? doneColor : lockColor;
            }
            else
            {
                button.BackColor = absentColor;
            }
            MarkAsCurrent(button);
        }

        /// <summary>
        /// 点名完成后要做的事情
        /// </summary>
        /// <param name="autoRoll">如果为 true，则代表自动点名结束。不同处理</param>
        void AfterRollCall(bool autoRoll = false)
        {
            if (autoRoll)
            {
                var url = "http://10.10.11.201:8028/sim/";
                try
                {
                    System.Diagnostics.Process.Start(url);
                }
                catch
                {
                    MessageBox.Show($"点名完毕。\n\n打开 {url} 失败，请手动尝试");
                }
            }
            else
            {
                MessageBox.Show("已经全部点完");
            }
        }

        bool CheckFinished()
        {
            return studentButtons.Where(l => l.BackColor == defColor).Count() == 0;
        }

        #endregion

        #region // 自动点名

        void AutoRoll()
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = SysParams.AutoRollInterval;
                timer.Tick += (s, e) =>
                {
                    if (isAutoRolling == false || CheckFinished())
                    {
                        StopAutoRoll();
                    }
                    else
                    {
                        CallNext();
                    }
                };
            }

            if (timer.Enabled)
            {
                StopAutoRoll();
            }
            else
            {
                timer.Start();
                isAutoRolling = true;
                btAuto.Text = "点名中...";
                btAuto.BackColor = Color.OrangeRed;
            }
        }

        void StopAutoRoll()
        {
            timer.Stop();
            btAuto.Text = "自动模式";
            btAuto.BackColor = Color.Black;
            isAutoRolling = false;

            if (CheckFinished())
            {
                AfterRollCall(true);
            }
        }

        #endregion

        #region // 事件

        void BindButtonEvents()
        {
            this.btNext.Click += (s, e) =>
            {
                isAutoRolling = false;
                CallNext();
            };
            this.btCurr.Click += (s, e) =>
            {
                isAutoRolling = false;
                CallCurrent();
            };
            this.btAuto.Click += (s, e) => AutoRoll();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    isAutoRolling = false;
                    CallNext();
                    return true;
                case Keys.Space:
                    if (isAutoRolling)
                    {
                        isAutoRolling = false;
                    }
                    else
                    {
                        isAutoRolling = false;
                        CallCurrent();
                    }
                    return true;
                case Keys.Enter | Keys.Control:
                    AutoRoll();
                    return true;
                case Keys.Back:
                    return true;
                case Keys.Escape:
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            InitStudentButtons();
        }

        #endregion

        #region // 辅助方法

        List<Student> Shuffer(List<Student> students)
        {
            var r = new Random();
            return students.OrderBy(item => r.Next()).ToList();
        }

        #endregion

        #region // 旧的、通过文件加载学生名单的方式。现在不需要了
        string studentListFile = @"e:\aaa.txt";

        void InitFileShow()
        {
            //this.buttonFileinfo.Text = studentListFile;
            //var tip = new ToolTip();
            //tip.SetToolTip(this.buttonFileinfo, studentListFile);
        }

        List<string> GetNamesFromFile(string file)
        {
            return File.ReadAllLines(file).ToList();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad", studentListFile);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"e:\";
            dialog.Filter = "文本文档|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                studentListFile = dialog.FileName;
                InitStudentButtons();
                InitFileShow();
            }
        }
        #endregion

    }
}
