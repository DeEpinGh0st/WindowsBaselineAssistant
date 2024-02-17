using System;
using System.Windows.Forms;

namespace WindowsBaselineAssistant
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]//1.[STAThread]Attributes语法，修饰Main方法。表示应用程序的默认线程模型是单线程单元
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());//2.开启窗口的消息循坏，初始化并启动Main窗口
        }
    }
}
