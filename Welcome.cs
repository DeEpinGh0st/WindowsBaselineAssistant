using Sunny.UI;
using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsBaselineAssistant
{
    public partial class Welcome : UIForm
    {
        private Thread th;
        public Welcome()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 启动主界面
        /// </summary>
        [STAThread]
        private static void StartMainForm()
        {
            Main main = new Main();
            Application.Run(main);
        }

        private void WelcomeBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(StartMainForm));
            th.Start();
            this.Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
