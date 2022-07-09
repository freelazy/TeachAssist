
namespace TeachAssist.Winform.Forms
{
    partial class TestForm
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("上课点名");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("课堂提问");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("面试管理");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("菜单管理");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("参数管理");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("系统设置", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label111 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.FullRowSelect = true;
            this.treeView1.ItemHeight = 40;
            this.treeView1.Location = new System.Drawing.Point(322, 15);
            this.treeView1.Name = "treeView1";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Node0";
            treeNode7.Text = "上课点名";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "Node1";
            treeNode8.Text = "课堂提问";
            treeNode9.ImageIndex = 3;
            treeNode9.Name = "Node2";
            treeNode9.Text = "面试管理";
            treeNode10.Name = "Node4";
            treeNode10.Text = "菜单管理";
            treeNode11.Name = "Node5";
            treeNode11.Text = "参数管理";
            treeNode12.Name = "Node3";
            treeNode12.Text = "系统设置";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode12});
            this.treeView1.ShowLines = false;
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(278, 374);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label111);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "点我看看";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(8, 102);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(266, 24);
            this.label111.TabIndex = 1;
            this.label111.Text = "任务未开始，请点击上面的按钮.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始任务";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}