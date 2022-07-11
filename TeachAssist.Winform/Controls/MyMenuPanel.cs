using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TeachAssist.Winform.Controls
{
    class MyMenuPanel : Panel
    {
        public MyMenuPanel()
        {
            this.MinimumSize = new Size(60, 30);
        }

        [Browsable(true)]
        [Category("我的菜单")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Gap { get; set; } = 5;

        [Browsable(true)]
        [Category("我的菜单")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int MenuItemHeight { get; set; } = 30;

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            var controls = this.Controls;
            for (int i = 0; i < controls.Count; i++)
            {
                var c = controls[i] as Control;
                c.Width = this.Width;
                c.Height = MenuItemHeight;
                c.Left = 0;
                c.Top = i * (MenuItemHeight + Gap);
            }
            this.Height = controls.Count * MenuItemHeight + (controls.Count - 1) * Gap;
        }
    }
}
