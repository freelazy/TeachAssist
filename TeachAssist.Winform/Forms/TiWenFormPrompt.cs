using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeachAssist.BLL;

namespace TeachAssist.Winform.Forms
{
    public partial class TiWenFormPrompt : BaseForm
    {
        int idx = 0;

        public TiWenFormPrompt(params DataRow[] students)
        {
            InitializeComponent();

            InitForm();
            InitScoreList(students);
        }

        void InitForm()
        {
            this.Text = "打分窗口";
            this.ShowInTaskbar = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void InitScoreList(DataRow[] students)
        {
            foreach (var s in students)
            {
                var rg = CreateRadioGroup(s);
                this.mainBox.Controls.Add(rg);
            }

            // 修正窗口高度，让其能够自适应
            this.Height = 105 + (students.Length - 1) * 28;
        }

        Panel CreateRadioGroup(DataRow student)
        {
            var container = new Panel
            {
                Tag = student["id"],
                AutoSize = true,
                TabIndex = idx++
            };
            container.Controls.AddRange(new Control[]
            {
                new Label { Text = student["name"].ToString(), AutoSize = true, Left = 10 },
                new RadioButton { Text = "0", AutoSize = true, Left = 70 },
                new RadioButton { Text = "1", AutoSize = true, Left = 110, Checked = true },
                new RadioButton { Text = "2", AutoSize = true, Left = 150 }
            });
            return container;
        }

        void UpdateScores()
        {
            var scores = GetScores();
            // var ss = string.Join("\n", scores.Select(c => $"{c.id} : {c.score}"));

            var bll = new TiwenService();
            bll.UpdateStores(scores);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        IEnumerable<(string id, int score)> GetScores()
        {
            return this.mainBox.Controls.Cast<Panel>()
                .Select(p =>
                {
                    string id = p.Tag as string;

                    string score = p.Controls
                        .OfType<RadioButton>()
                        .Where(r => r.Checked)
                        .First()
                        .Text;

                    return (id, int.Parse(score));
                });
        }

        // 事件

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    if (MessageBox.Show("是否真的要保存分数?", "保存分数", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        UpdateScores();
                    }
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateScores();
        }
    }
}
