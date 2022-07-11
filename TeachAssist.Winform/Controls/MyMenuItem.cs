using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TeachAssist.Winform.Controls
{
    public partial class MyMenuItem : UserControl
    {
        private bool isActive;

        [Browsable(true)]
        [Category("我的菜单")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text { get; set; }

        [Category("我的菜单")]
        public Image Image { get; set; }

        [Category("我的菜单")]
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
                this.BorderStyle = isActive ? BorderStyle.FixedSingle : BorderStyle.None;
            }
        }

        public event EventHandler MenuPick;
        public event EventHandler MenuResetPick;

        public MyMenuItem()
        {
            InitializeComponent();
        }

        private void MyMenuItem_Load(object sender, EventArgs e)
        {
            this.Height = 30;

            label1.Text = Text;
            pictureBox1.Image = Image;
            label1.Click += (s, e) => MenuPick.Invoke(this, e);
            pictureBox1.Click += (s, e) => MenuPick.Invoke(this, e);
            label1.DoubleClick += (s, e) => MenuResetPick.Invoke(this, e);
            pictureBox1.DoubleClick += (s, e) => MenuResetPick.Invoke(this, e);
        }
    }
}
