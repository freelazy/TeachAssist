using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using TeachAssist.Winform.Controls;
using TeachAssist.Winform.Global;
using TeachAssist.Winform.Properties;

namespace TeachAssist.Winform
{
    public partial class MainForm : BaseForm
    {
        List<(int no, string name, string form, string img)> menus = new()
        {
            (1, "上课点名", "DianMingForm", "Notify"),
            (2, "课堂提问", "TiWenForm", "Meeting"),
            (3, "学生管理", "StudentManageForm", "Students"),
            (4, "分组管理", "GroupManageForm", "Group"),
            (5, "模拟考试", "KaoShiForm", "Exam"),
            (9, "系统设置", "ConfigForm", "Setup"),
            (6, "笔试面试", "TestYouForm", "Money"),
            (8, "测试页面", "TestForm", "Test")
        };

        Dictionary<string, Form> cachedForms = new();
        ResourceManager rm = new("TeachAssist.Winform.Properties.Icons", typeof(Icons).Assembly);

        public MainForm()
        {
            InitializeComponent();

            // 先加载系统参数
            try
            {
                SysParams.LoadParams();
            }
            catch (Exception ex)
            {
                var reason = ex is DbException ? $"加载数据库出错, {ex.Message}" : ex.Message;
                MessageBox.Show($"初始化失败:\n\n{reason}");
                Application.Exit();
            }

            // 初始化菜单
            InitMenus();
            LoadMenuForm(this.menus.Find(m => m.no == SysParams.DefaultMenuIndex));

            // 可以关闭左侧栏
            this.toolStripStatusLabel1.Click += DoToggleSideMenu;

            // 获取资源文件:
            // var image1 = Properties.Resources.NoAvatar;
            // var image2 = new ResourceManager("TeachAssist.Winform.Properties.Icons", typeof(Icons).Assembly).GetObject("NoAvatar") as Bitmap;
        }

        void InitMenus()
        {
            foreach (var menu in menus.OrderBy(m => m.no))
            {
                var item = new MyMenuItem
                {
                    Text = menu.name,
                    Image = menu.img == null ? null : rm.GetObject(menu.img) as Bitmap,
                };
                item.MenuPick += (s, e) => LoadMenuForm(menu);
                item.MenuResetPick += (s, e) => ReloadMenuForm(menu);
                this.menuBox.Controls.Add(item);
            }
        }

        void LoadMenuForm((int no, string name, string frm, string img) menu)
        {
            Form form;
            if (cachedForms.ContainsKey(menu.name))
            {
                form = cachedForms[menu.name];
            }
            else
            {
                form = Assembly.GetExecutingAssembly().CreateInstance($"TeachAssist.Winform.Forms.{menu.frm}") as Form;
                cachedForms[menu.name] = form;
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(form);

            foreach (MyMenuItem item in this.menuBox.Controls)
            {
                item.IsActive = menu.name == item.Text;
            }
        }

        void ReloadMenuForm((int no, string name, string form, string img) menu)
        {
            if (cachedForms.ContainsKey(menu.name))
            {
                cachedForms[menu.name].Dispose();
                cachedForms.Remove(menu.name);
            }
            LoadMenuForm(menu);
        }

        private void DoToggleSideMenu(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1Collapsed = !this.splitContainer1.Panel1Collapsed;
            this.toolStripStatusLabel1.Text = this.splitContainer1.Panel1Collapsed ? " 🤙 " : " 👊 ";
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本功能，尚未开发，请等待 :)");
        }
    }
}
