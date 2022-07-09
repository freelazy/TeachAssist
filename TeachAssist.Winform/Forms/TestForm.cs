using System;
using System.Threading;
using System.Windows.Forms;

namespace TeachAssist.Winform.Forms
{
    public partial class TestForm : BaseForm
    {
        public TestForm()
        {
            InitializeComponent();

            //button1.Click += (s, e) =>
            //{
            //    label111.Text = "任务进行中...";
            //    Thread.Sleep(10000);
            //    label111.Text = "任务已完成!";
            //};

            //button1.Click += (s, e) =>
            //{

            //    label111.Text = "任务进行中...";
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(10000);
            //        label111.Text = "任务已完成!";
            //    });
            //};

            //button1.Click += (s, e) =>
            //{
            //    var bgw = new BackgroundWorker();
            //    bgw.DoWork += (s, e) =>
            //    {
            //        label111.Text = "任务进行中...";
            //        Thread.Sleep(10000);
            //    };
            //    bgw.RunWorkerCompleted += (s, e) =>
            //    {
            //        label111.Text = "任务已完成!";
            //    };
            //    bgw.RunWorkerAsync();
            //};

            button1.Click += (s, e) =>
            {
                var timer = new System.Threading.Timer((o) =>
                {
                    label111.Text += "+";
                    Thread.Sleep(1000);
                }, null, 5000, 2000);
            };

            //var timer = new System.Windows.Forms.Timer();
            //timer.Interval = 3000;
            //timer.Tick += (s, e) =>
            //{
            //    label111.Text += "+";
            //    Thread.Sleep(2000);
            //};
            //button1.Click += (s, e) =>
            //{
            //    timer.Start();
            //};

            //button1.Click += (s, e) =>
            //{
            //    Action aaa = () =>
            //    {
            //        label111.Text = "任务进行中...";
            //        Thread.Sleep(2000);
            //    };
            //    //aaa.Invoke(); // 同步的
            //    aaa.BeginInvoke((o) =>
            //    {
            //        label111.Text = "任务已完成!";
            //    }, null);
            //};

            var imageList = new ImageList();
            imageList.Images.AddRange(new[]
            {
                Properties.Icons.Answer,
                Properties.Icons.Quiz,
                Properties.Icons.Fly,
                Properties.Icons.Money
            });
            treeView1.ImageList = imageList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还没有实现");
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我能响应");
        }
    }
}
