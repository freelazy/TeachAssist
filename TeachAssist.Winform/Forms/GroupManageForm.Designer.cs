
namespace TeachAssist.Winform.Forms
{
    partial class GroupManageForm
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
            this.components = new System.ComponentModel.Container();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.todoBox = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox = new System.Windows.Forms.FlowLayoutPanel();
            this.btNew = new System.Windows.Forms.Button();
            this.groupContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupDelItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btnBox = new System.Windows.Forms.Panel();
            this.groupbox1.SuspendLayout();
            this.groupContext.SuspendLayout();
            this.btnBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox1.Controls.Add(this.todoBox);
            this.groupbox1.Location = new System.Drawing.Point(17, 528);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(962, 210);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "还没有分配组的学生";
            // 
            // todoBox
            // 
            this.todoBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.todoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoBox.Location = new System.Drawing.Point(3, 26);
            this.todoBox.Name = "todoBox";
            this.todoBox.Size = new System.Drawing.Size(956, 181);
            this.todoBox.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Location = new System.Drawing.Point(20, 16);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(783, 449);
            this.groupBox.TabIndex = 1;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(-2, 52);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(159, 47);
            this.btNew.TabIndex = 4;
            this.btNew.Text = "添加新组";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // groupContext
            // 
            this.groupContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.groupContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupDelItemMenu});
            this.groupContext.Name = "groupContext";
            this.groupContext.Size = new System.Drawing.Size(117, 34);
            // 
            // groupDelItemMenu
            // 
            this.groupDelItemMenu.Name = "groupDelItemMenu";
            this.groupDelItemMenu.Size = new System.Drawing.Size(116, 30);
            this.groupDelItemMenu.Text = "删除";
            this.groupDelItemMenu.Click += new System.EventHandler(this.groupDelItemMenu_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(74, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(83, 47);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btReset
            // 
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Location = new System.Drawing.Point(0, 0);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(68, 47);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "重置";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btnBox
            // 
            this.btnBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBox.Controls.Add(this.btReset);
            this.btnBox.Controls.Add(this.btSave);
            this.btnBox.Controls.Add(this.btNew);
            this.btnBox.Location = new System.Drawing.Point(827, 16);
            this.btnBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(165, 104);
            this.btnBox.TabIndex = 7;
            // 
            // GroupManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 754);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupbox1);
            this.Name = "GroupManageForm";
            this.Text = "分组管理";
            this.groupbox1.ResumeLayout(false);
            this.groupContext.ResumeLayout(false);
            this.btnBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.FlowLayoutPanel groupBox;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.FlowLayoutPanel todoBox;
        private System.Windows.Forms.ContextMenuStrip groupContext;
        private System.Windows.Forms.ToolStripMenuItem groupDelItemMenu;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Panel btnBox;
    }
}