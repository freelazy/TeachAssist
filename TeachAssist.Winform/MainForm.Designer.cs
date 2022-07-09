
namespace TeachAssist.Winform
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuBox = new TeachAssist.Winform.Controls.MyMenuPanel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(820, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusLabel1.Text = " 👊 ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(20, 4, 0, 3);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(82, 20);
            this.toolStripStatusLabel3.Text = "南方IT学院";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.menuBox);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 5, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(820, 517);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // menuBox
            // 
            this.menuBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBox.Gap = 5;
            this.menuBox.Location = new System.Drawing.Point(0, 10);
            this.menuBox.MenuItemHeight = 30;
            this.menuBox.MinimumSize = new System.Drawing.Size(80, 30);
            this.menuBox.Name = "menuBox";
            this.menuBox.Padding = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.menuBox.Size = new System.Drawing.Size(145, 507);
            this.menuBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(820, 543);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "教学辅助系统";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private Controls.MyMenuPanel menuBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}
