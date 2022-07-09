
namespace TeachAssist.Winform.Forms
{
    partial class StudentManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbHc = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dvStudents = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.cbState);
            this.panelTop.Controls.Add(this.btSearch);
            this.panelTop.Controls.Add(this.tbSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1006, 47);
            this.panelTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btDel);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(598, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 37);
            this.panel1.TabIndex = 6;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(0, 0);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(112, 34);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(139, 0);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(112, 34);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "编辑";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(278, 0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(112, 34);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbState
            // 
            this.cbState.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(12, 8);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(127, 29);
            this.cbState.TabIndex = 2;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(324, 6);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(88, 34);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearch.Location = new System.Drawing.Point(158, 8);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(150, 28);
            this.tbSearch.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btSave);
            this.panelBottom.Controls.Add(this.tbState);
            this.panelBottom.Controls.Add(this.tbHc);
            this.panelBottom.Controls.Add(this.tbTel);
            this.panelBottom.Controls.Add(this.tbName);
            this.panelBottom.Controls.Add(this.tbId);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 497);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1006, 143);
            this.panelBottom.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(756, 85);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 34);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(573, 30);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(127, 30);
            this.tbState.TabIndex = 5;
            // 
            // tbHc
            // 
            this.tbHc.Location = new System.Drawing.Point(342, 79);
            this.tbHc.Name = "tbHc";
            this.tbHc.Size = new System.Drawing.Size(150, 30);
            this.tbHc.TabIndex = 4;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(342, 30);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(150, 30);
            this.tbTel.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(142, 30);
            this.tbName.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(131, 30);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(142, 30);
            this.tbId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "籍贯";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dvStudents);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 47);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1006, 450);
            this.panelMain.TabIndex = 2;
            // 
            // dvStudents
            // 
            this.dvStudents.AllowUserToAddRows = false;
            this.dvStudents.AllowUserToDeleteRows = false;
            this.dvStudents.AllowUserToOrderColumns = true;
            this.dvStudents.AllowUserToResizeRows = false;
            this.dvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvStudents.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStudents.Location = new System.Drawing.Point(0, 0);
            this.dvStudents.MultiSelect = false;
            this.dvStudents.Name = "dvStudents";
            this.dvStudents.RowHeadersWidth = 62;
            this.dvStudents.RowTemplate.Height = 32;
            this.dvStudents.Size = new System.Drawing.Size(1006, 450);
            this.dvStudents.TabIndex = 0;
            // 
            // StudentManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 640);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "StudentManageForm";
            this.Text = "StudentManage";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dvStudents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbHc;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel1;
    }
}