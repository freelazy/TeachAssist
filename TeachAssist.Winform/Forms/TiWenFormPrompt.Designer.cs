
namespace TeachAssist.Winform.Forms
{
    partial class TiWenFormPrompt
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
            this.btOk = new System.Windows.Forms.Button();
            this.mainBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.Location = new System.Drawing.Point(344, 22);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(81, 34);
            this.btOk.TabIndex = 9;
            this.btOk.Text = "确定";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainBox
            // 
            this.mainBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainBox.Location = new System.Drawing.Point(12, 22);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(309, 253);
            this.mainBox.TabIndex = 2;
            // 
            // TiWenFormPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 298);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.btOk);
            this.Name = "TiWenFormPrompt";
            this.Text = "TiWenFormPrompt";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.FlowLayoutPanel mainBox;
    }
}