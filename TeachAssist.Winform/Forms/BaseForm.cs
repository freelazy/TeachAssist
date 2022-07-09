using System.Windows.Forms;

namespace TeachAssist.Winform
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true);         // 双缓冲
        }
    }
}
