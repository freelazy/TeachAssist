
namespace TeachAssist.Winform.Forms
{
    partial class TiWenForm
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
            this.dvStudents = new System.Windows.Forms.DataGridView();
            this.dvGroups = new System.Windows.Forms.DataGridView();
            this.btMode = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbClearList = new System.Windows.Forms.PictureBox();
            this.fpList = new System.Windows.Forms.FlowLayoutPanel();
            this.btManual = new System.Windows.Forms.Button();
            this.btRandom = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClearList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvStudents
            // 
            this.dvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvStudents.Location = new System.Drawing.Point(12, 12);
            this.dvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dvStudents.Name = "dvStudents";
            this.dvStudents.RowHeadersWidth = 62;
            this.dvStudents.RowTemplate.Height = 32;
            this.dvStudents.Size = new System.Drawing.Size(321, 682);
            this.dvStudents.TabIndex = 0;
            // 
            // dvGroups
            // 
            this.dvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvGroups.Location = new System.Drawing.Point(12, 12);
            this.dvGroups.Margin = new System.Windows.Forms.Padding(2);
            this.dvGroups.Name = "dvGroups";
            this.dvGroups.RowHeadersWidth = 62;
            this.dvGroups.RowTemplate.Height = 32;
            this.dvGroups.Size = new System.Drawing.Size(321, 682);
            this.dvGroups.TabIndex = 1;
            // 
            // btMode
            // 
            this.btMode.Location = new System.Drawing.Point(0, 47);
            this.btMode.Margin = new System.Windows.Forms.Padding(2);
            this.btMode.Name = "btMode";
            this.btMode.Size = new System.Drawing.Size(177, 41);
            this.btMode.TabIndex = 1;
            this.btMode.Text = "个人模式";
            this.btMode.UseVisualStyleBackColor = true;
            this.btMode.Click += new System.EventHandler(this.btMode_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(0, 0);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(148, 30);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFilter_KeyUp);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.pbAvatar.Location = new System.Drawing.Point(372, 53);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(174, 188);
            this.pbAvatar.TabIndex = 3;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pbClearList);
            this.groupBox1.Controls.Add(this.fpList);
            this.groupBox1.Location = new System.Drawing.Point(375, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(576, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "候选人";
            // 
            // pbClearList
            // 
            this.pbClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClearList.Image = global::TeachAssist.Winform.Properties.Resources.Snipaste_2021_09_14_09_47_48;
            this.pbClearList.Location = new System.Drawing.Point(-420, 2);
            this.pbClearList.Margin = new System.Windows.Forms.Padding(2);
            this.pbClearList.Name = "pbClearList";
            this.pbClearList.Size = new System.Drawing.Size(18, 18);
            this.pbClearList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClearList.TabIndex = 0;
            this.pbClearList.TabStop = false;
            this.pbClearList.Click += new System.EventHandler(this.pbClearList_Click);
            // 
            // fpList
            // 
            this.fpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpList.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fpList.Location = new System.Drawing.Point(2, 25);
            this.fpList.Margin = new System.Windows.Forms.Padding(2);
            this.fpList.Name = "fpList";
            this.fpList.Padding = new System.Windows.Forms.Padding(5);
            this.fpList.Size = new System.Drawing.Size(572, 161);
            this.fpList.TabIndex = 0;
            // 
            // btManual
            // 
            this.btManual.Location = new System.Drawing.Point(2, 2);
            this.btManual.Margin = new System.Windows.Forms.Padding(2);
            this.btManual.Name = "btManual";
            this.btManual.Size = new System.Drawing.Size(100, 100);
            this.btManual.TabIndex = 0;
            this.btManual.Text = "选中";
            this.btManual.UseVisualStyleBackColor = true;
            this.btManual.Click += new System.EventHandler(this.btManual_Click);
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(127, 2);
            this.btRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(100, 100);
            this.btRandom.TabIndex = 5;
            this.btRandom.Text = "随机";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(567, 43);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 94);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "--";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btMode);
            this.panel1.Controls.Add(this.tbFilter);
            this.panel1.Location = new System.Drawing.Point(375, 584);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 90);
            this.panel1.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(153, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(24, 30);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "✓";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(581, 182);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(110, 31);
            this.lbInfo.TabIndex = 9;
            this.lbInfo.Text = "没有描述";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btManual);
            this.panel2.Controls.Add(this.btRandom);
            this.panel2.Location = new System.Drawing.Point(724, 582);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 118);
            this.panel2.TabIndex = 10;
            // 
            // TiWenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dvGroups);
            this.Controls.Add(this.dvStudents);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbAvatar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TiWenForm";
            this.Text = "默认模式";
            ((System.ComponentModel.ISupportInitialize)(this.dvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClearList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvStudents;
        private System.Windows.Forms.Button btMode;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btManual;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpList;
        private System.Windows.Forms.PictureBox pbClearList;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.DataGridView dvGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFilter;
    }
}