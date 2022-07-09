
namespace TeachAssist.Winform.Forms
{
    partial class DianMingForm
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
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.stname = new System.Windows.Forms.Label();
            this.refreshBt = new System.Windows.Forms.PictureBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btCurr = new System.Windows.Forms.Button();
            this.btAuto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mingdan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // avatarBox
            // 
            this.avatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarBox.Location = new System.Drawing.Point(39, 62);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(190, 197);
            this.avatarBox.TabIndex = 2;
            this.avatarBox.TabStop = false;
            // 
            // stname
            // 
            this.stname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stname.Font = new System.Drawing.Font("宋体", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stname.ForeColor = System.Drawing.Color.Red;
            this.stname.Location = new System.Drawing.Point(229, 77);
            this.stname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stname.Name = "stname";
            this.stname.Padding = new System.Windows.Forms.Padding(5);
            this.stname.Size = new System.Drawing.Size(507, 134);
            this.stname.TabIndex = 3;
            this.stname.Text = "Ready?";
            this.stname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshBt
            // 
            this.refreshBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBt.Image = global::TeachAssist.Winform.Properties.Resources.Refresh;
            this.refreshBt.Location = new System.Drawing.Point(710, 2);
            this.refreshBt.Margin = new System.Windows.Forms.Padding(2);
            this.refreshBt.Name = "refreshBt";
            this.refreshBt.Size = new System.Drawing.Size(14, 16);
            this.refreshBt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBt.TabIndex = 19;
            this.refreshBt.TabStop = false;
            this.refreshBt.Click += new System.EventHandler(this.refreshBt_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(235, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(100, 35);
            this.btNext.TabIndex = 20;
            this.btNext.Text = "点  名";
            this.btNext.UseVisualStyleBackColor = true;
            // 
            // btCurr
            // 
            this.btCurr.Location = new System.Drawing.Point(119, 3);
            this.btCurr.Name = "btCurr";
            this.btCurr.Size = new System.Drawing.Size(100, 35);
            this.btCurr.TabIndex = 21;
            this.btCurr.Text = "呼  叫";
            this.btCurr.UseVisualStyleBackColor = true;
            // 
            // btAuto
            // 
            this.btAuto.BackColor = System.Drawing.SystemColors.ControlText;
            this.btAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAuto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAuto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btAuto.Location = new System.Drawing.Point(5, 3);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(100, 35);
            this.btAuto.TabIndex = 22;
            this.btAuto.Text = "自动模式";
            this.btAuto.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btAuto);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Controls.Add(this.btCurr);
            this.panel1.Location = new System.Drawing.Point(401, 474);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 43);
            this.panel1.TabIndex = 23;
            // 
            // mingdan
            // 
            this.mingdan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mingdan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mingdan.Location = new System.Drawing.Point(0, 0);
            this.mingdan.Margin = new System.Windows.Forms.Padding(0);
            this.mingdan.Name = "mingdan";
            this.mingdan.Padding = new System.Windows.Forms.Padding(2);
            this.mingdan.Size = new System.Drawing.Size(727, 204);
            this.mingdan.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.refreshBt);
            this.panel2.Controls.Add(this.mingdan);
            this.panel2.Location = new System.Drawing.Point(12, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 204);
            this.panel2.TabIndex = 25;
            // 
            // DianMingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.stname);
            this.Name = "DianMingForm";
            this.Text = "点名";
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Label stname;
        private System.Windows.Forms.PictureBox refreshBt;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btCurr;
        private System.Windows.Forms.Button btAuto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel mingdan;
        private System.Windows.Forms.Panel panel2;
    }
}