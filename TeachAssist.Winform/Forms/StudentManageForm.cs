using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TeachAssist.BLL;
using TeachAssist.Models;

namespace TeachAssist.Winform.Forms
{
    public partial class StudentManageForm : BaseForm
    {

        StudentService service = new();

        List<Student> students = new();

        public List<Student> Students
        {
            get => students;
            private set
            {
                students = value;
                this.dvStudents.DataSource = students;
                this.cbState.SelectedIndex = 0;
            }
        }

        public StudentManageForm()
        {
            InitializeComponent();

            InitComboBox();
            InitDataGrid();
            InitInputForm();
        }

        void InitComboBox()
        {
            cbState.Items.AddRange(new[] { "所有", "1", "2" });
            cbState.SelectedIndex = 0;
        }

        void InitDataGrid()
        {
            this.dvStudents.AllowUserToAddRows = false;
            this.dvStudents.AllowUserToDeleteRows = false;
            this.dvStudents.AllowUserToOrderColumns = true;
            foreach (DataGridViewColumn column in dvStudents.Columns)
            {
                dvStudents.Columns[column.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            this.dvStudents.EditMode = DataGridViewEditMode.EditProgrammatically;

            this.Students = service.GetAllStudent().OrderBy(s => s.Name).ToList();
        }

        void InitInputForm()
        {
            foreach (Control c in this.panelBottom.Controls)
            {
                var cc = c as TextBox;
                if (cc != null)
                {
                    cc.Clear();
                }
            }
            tbId.ReadOnly = false;
            tbName.ReadOnly = false;
            this.panelBottom.Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            InitInputForm();
            tbState.Text = "1";
            btSave.Text = "保存新增";
            this.panelBottom.Visible = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            InitInputForm();
            if (dvStudents.SelectedRows.Count != 1)
            {
                MessageBox.Show("请您先选中一行，然后再进行操作");
            }
            else
            {
                var cells = dvStudents.SelectedRows[0].Cells;
                tbId.Text = cells[0].Value.ToString();
                tbName.Text = Convert.ToString(cells[1].Value);
                tbHc.Text = Convert.ToString(cells[2].Value);
                tbTel.Text = Convert.ToString(cells[3].Value);
                tbState.Text = Convert.ToString(cells[4].Value);
                txtPron.Text = Convert.ToString(cells[5].Value);

                tbId.ReadOnly = true;
                tbName.ReadOnly = true;

                btSave.Text = "保存更新";

                this.panelBottom.Visible = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // 首先需要验证
            try
            {
                if (btSave.Text == "保存新增")
                {
                    var s = new Student()
                    {
                        Id = tbId.Text,
                        Name = tbName.Text,
                        Homecity = tbHc.Text,
                        Telephone = tbTel.Text,
                        State = int.Parse(tbState.Text),
                        Duyin = txtPron.Text,
                    };
                    service.SaveAdd(s);
                    MessageBox.Show("添加成功");

                    this.Students = service.GetAllStudent();
                    InitInputForm();

                    for (int i = 0; i < this.dvStudents.Rows.Count; i++)
                    {
                        var row = this.dvStudents.Rows[i];
                        if (row.Cells[0].Value.ToString() == s.Id)
                        {
                            this.dvStudents.CurrentCell = this.dvStudents.Rows[i].Cells[0];
                        }
                    }
                }
                else if (btSave.Text == "保存更新")
                {
                    var previousIndex = this.dvStudents.CurrentRow.Index;

                    service.SaveUpdate(new Student()
                    {
                        Id = tbId.Text,
                        Name = tbName.Text,
                        Homecity = tbHc.Text,
                        Telephone = tbTel.Text,
                        Duyin = txtPron.Text,
                        State = int.Parse(tbState.Text)
                    });
                    MessageBox.Show("更新成功");

                    Students = service.GetAllStudent();
                    InitInputForm();

                    this.dvStudents.CurrentCell = this.dvStudents.Rows[previousIndex].Cells[1];
                    this.dvStudents.Rows[previousIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败，原因是: {ex.Message}");
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dvStudents.SelectedRows.Count != 1)
            {
                MessageBox.Show("请您先选中一行，然后再进行操作");
            }
            else
            {
                if (MessageBox.Show("是不是要删除？", "删除提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    service.Delete(this.dvStudents.CurrentCell.Value.ToString());
                    this.Students = service.GetAllStudent();
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var condition = tbSearch.Text;
            this.Students = service.SearchStudent(condition);
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.cbState.SelectedItem.ToString();

            if (item == "所有")
            {
                this.dvStudents.DataSource = Students;
            }
            else
            {
                this.dvStudents.DataSource
                    = Students
                    .Where(s => s.State == int.Parse(item))
                    .ToList();
            }
        }
    }
}
