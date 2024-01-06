using System;
using System.Diagnostics;
using System.Xml;
using Microsoft.Win32;
using Sunny.UI;
using WHC.OrderWater.Commons;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsBaselineAssistant
{
    public partial class Main : UIForm
    {
        public Main()
        {
            InitializeComponent();
        }
        static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        XmlNodeList xmlNodeList;
        XmlDocument xmlDocument;
        XmlElement xmlElement;
        static string secInfoFile = currentDirectory + "config.cfg";
        string secInfoCmd = "secedit /export /cfg config.cfg";
        string openRegCmd = "regjump.exe {0} /accepteula";
        private XmlDocument ReadXml(string xmlpath) {
            if (!File.Exists(xmlpath)) { 
                return null;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlpath);
            return xmlDocument;
        }

        private string GetResultByMark(string mark) {
            
            IniFile ini = new IniFile(currentDirectory + "\\config.cfg");
            string[] sections = ini.Sections;
            string name = string.Empty;
            foreach (var section in sections)
            {
                name = ini.ReadString(section, mark, "");
                if (name != string.Empty)
                {
                    break;
                }
            }
            return name;
        }

        /// <summary>
        /// 执行外部程序
        /// </summary>
        /// <param name="command">参数</param>
        /// <param name="isnowindow">是否在新窗口中启动</param>
        /// <param name="processWindowStyle">窗口状态.默认:Normal</param>
        /// <returns></returns>
        private int ExecutExternalProgram(string command,bool isnowindow,ProcessWindowStyle processWindowStyle = ProcessWindowStyle.Normal) {
                //要执行的命令
                //string command = "secedit /export /cfg config.cfg";
                // 创建一个新的进程启动信息
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = isnowindow,
                    WindowStyle = processWindowStyle,
                    Arguments = "/c " + command,
                    WorkingDirectory = currentDirectory
                };
                // 创建进程对象
                Process process = new Process
                {
                    StartInfo = processStartInfo
                };
                try
                {
                    // 启动进程
                    process.Start();
                //Thread.Sleep(500);
                process.WaitForExit();
                //Thread.Sleep(1000);
                // 获取返回值
                int exitCode = process.ExitCode;
                    return exitCode;
            }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError(ex.Message);
                    return -1;
                }
            finally
            {
                // 关闭进程
                process.Close();
                process.Dispose();
            }
        }


        private void AboutLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DeEpinGh0st/WindowsBaselineAssistant");
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            xmlDocument = ReadXml(currentDirectory+  @"\item.xml");
            if (xmlDocument == null)
            {
                UIMessageBox.ShowError("未找到配置文件");
                return;
            }
            if (File.Exists(secInfoFile))
            {
                File.Delete(secInfoFile);
            }
            //int code = GenerateSecInfo();
            if (!ExecutExternalProgram(secInfoCmd,true,ProcessWindowStyle.Hidden).Equals(0))
            {
                UIMessageBox.ShowError("secedit信息生成失败");
                return;
            }
            BaselineList.Rows.Clear();
            int totalCount, passCount = 0;
            double rate,ratePercent = 0;
            xmlElement = xmlDocument.DocumentElement;
            xmlNodeList = xmlElement.ChildNodes;
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                int index = BaselineList.Rows.Add();
                /*string name = xmlNode["name"].InnerText;*/
                BaselineList.Rows[index].Cells[0].Value = xmlNode["name"].InnerText;
                BaselineList.Rows[index].Cells[1].Value = xmlNode["description"].InnerText;
                BaselineList.Rows[index].Cells[4].Value = xmlNode["standard"].InnerText;
                string queryType = xmlNode["type"].InnerText;
                string reality = string.Empty;
                string standard = xmlNode["standard"].InnerText;
                switch (queryType)
                {
                    case "secedit":
                        BaselineList.Rows[index].Cells[2].Value = "-";
                        BaselineList.Rows[index].Cells[3].Value = "-";
                        reality = GetResultByMark(xmlNode["mark"].InnerText);
                        BaselineList.Rows[index].Cells[5].Value = reality;
                        break;
                    case "registry":
                        BaselineList.Rows[index].Cells[2].Value = xmlNode["registry"].InnerText;
                        BaselineList.Rows[index].Cells[3].Value = xmlNode["regitem"].InnerText;
                        reality = RegistryHelper.GetValue(xmlNode["registry"].InnerText, xmlNode["regitem"].InnerText);
                        BaselineList.Rows[index].Cells[5].Value = reality;
                        break;
                    default:
                        break;
                }
                string dataType = xmlNode["dtype"].InnerText;
                BaselineList.Rows[index].Cells[6].Value = "不符合";
                if (reality.Equals("未设置"))
                {
                    continue;
                }
                switch (dataType)
                {
                    case "fixed"://注：固定值为不符合
                        if (!reality.Equals(standard))
                        {
                            BaselineList.Rows[index].Cells[6].Style.ForeColor = Color.Green;
                            BaselineList.Rows[index].Cells[6].Value = "符合";
                            passCount++;
                        }
                        break;
                    case "equals":
                    case "enum":
                        if (reality.Equals(standard))
                        {
                            BaselineList.Rows[index].Cells[6].Style.ForeColor = Color.Green;
                            BaselineList.Rows[index].Cells[6].Value = "符合";
                            passCount++;
                        }
                        break;
                    case "greaternumber":
                        
                        if (reality.ToInt() >= standard.ToInt())
                        {
                            BaselineList.Rows[index].Cells[6].Style.ForeColor = Color.Green;
                            BaselineList.Rows[index].Cells[6].Value = "符合";
                            passCount++;
                        }
                        break;
                    case "lessnumber":
                        if (reality.ToInt() <= standard.ToInt())
                        {
                            BaselineList.Rows[index].Cells[6].Style.ForeColor = Color.Green;
                            BaselineList.Rows[index].Cells[6].Value = "符合";
                            passCount++;
                        }
                        break;
                    case "array":
                        if (reality.Equals(standard))
                        {
                            BaselineList.Rows[index].Cells[6].Style.ForeColor = Color.Green;
                            BaselineList.Rows[index].Cells[6].Value = "符合";
                            passCount++;
                        }
                        break;
                    default:
                        BaselineList.Rows[index].Cells[6].Value = "未定义的类型";
                        break;
                }
            }
            //统计数据
            totalCount = xmlNodeList.Count;
            totalCountLabel.Text = totalCount.ToString();
            passCountLabel.Text = passCount.ToString();
            failCountLabel.Text = (totalCount - passCount).ToString();
            rate = Convert.ToDouble(passCount)/ Convert.ToDouble(totalCount);
            ratePercent = Math.Round(rate, 2) * 100;
            if (ratePercent < 50)
            {
                rateLabel.ForeColor = Color.Red;
            }
            else if (ratePercent >= 50 && ratePercent < 80)
            {
                rateLabel.ForeColor = Color.Orange;
            }
            else
            {
                rateLabel.ForeColor = Color.Green;
            }
            rateLabel.Text = ratePercent + "%";

        }

        private void OpenSubKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = BaselineList.SelectedCells[0].RowIndex;
            string cellValue = BaselineList[2, selectedRowIndex].Value.ToString();
            if (!ExecutExternalProgram(string.Format(openRegCmd,cellValue),true).Equals(0))
            {
                UIMessageBox.ShowError("打开注册表项失败");
            }
        }
    }
}
