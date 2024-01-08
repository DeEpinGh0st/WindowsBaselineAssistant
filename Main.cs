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
using System.Management;
using System.Runtime.InteropServices;

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
        static string fortifyFile = currentDirectory + "fortify.cfg";
        string secInfoCmd = "secedit /export /cfg config.cfg";
        string fortifyCmd = "secedit /configure /db fortify.sdb /cfg fortify.cfg";
        string openRegCmd = "regjump.exe {0} /accepteula";
        private XmlDocument ReadXml(string xmlpath)
        {
            if (!File.Exists(xmlpath))
            {
                return null;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlpath);
            return xmlDocument;
        }

        private (string, string) GetResultByMark(string mark)
        {
            IniFile ini = new IniFile(currentDirectory + "\\config.cfg");
            string[] sections = ini.Sections;
            foreach (var section in sections)
            {
                string value = ini.ReadString(section, mark, "");
                if (value != string.Empty)
                {
                    return (section, value);
                    //break;
                }
            }
            return ("", "");
        }
        public static string GetIPAddress()
        {
            string st = "";
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    //st=mo["IpAddress"].ToString();
                    System.Array ar;
                    ar = (System.Array)(mo.Properties["IpAddress"].Value);
                    st = ar.GetValue(0).ToString();
                    break;
                }
            }
            return st;
        }

        private static string GetOSVersion()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption, Version, CSDVersion FROM Win32_OperatingSystem");
                foreach (ManagementObject os in searcher.Get())
                {
                    string caption = os["Caption"].ToString();
                    string version = os["Version"].ToString();
                    string csdVersion = os["CSDVersion"] != null ? os["CSDVersion"].ToString() : string.Empty;
                    //string buildNumber = os["BuildNumber"].ToString();
                    // 组合详细版本信息
                    string systemInfo = $"{caption}{version}{csdVersion}";

                    return systemInfo;
                }
            }
            catch (Exception)
            {
                return "获取系统信息失败";
            }
            return "无法获取系统详细版本信息";
        }

        private void SetPassStyle(int index)
        {
            BaselineList.Rows[index].Cells[6].Style.ForeColor = Color.Green;
            BaselineList.Rows[index].Cells[7].ReadOnly = true;
            BaselineList.Rows[index].Cells[7].Style.BackColor = Color.LightGray;
        }

        static bool ContainsElement(XmlNode parentNode, string elementName)
        {
            // 使用 SelectSingleNode 来查找指定名称的子节点
            XmlNode elementNode = parentNode.SelectSingleNode(elementName);

            // 判断是否找到了该节点
            return elementNode != null;
        }
        /// <summary>
        /// 执行外部程序
        /// </summary>
        /// <param name="command">参数</param>
        /// <param name="isnowindow">是否在新窗口中启动</param>
        /// <param name="processWindowStyle">窗口状态.默认:Normal</param>
        /// <returns></returns>
        private int ExecutExternalProgram(string command, bool isnowindow, ProcessWindowStyle processWindowStyle = ProcessWindowStyle.Normal)
        {
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
            Process.Start("https://saferoad.cc/");
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            try
            {
                xmlDocument = ReadXml(currentDirectory + @"\item.xml");
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
                if (!ExecutExternalProgram(secInfoCmd, true, ProcessWindowStyle.Hidden).Equals(0))
                {
                    UIMessageBox.ShowError("secedit信息生成失败");
                    return;
                }
                BaselineList.Rows.Clear();
                int totalCount, passCount = 0;
                double rate, ratePercent = 0;
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
                    string reality = string.Empty, section = string.Empty, warning = string.Empty;
                    //string warning = string.Empty;
                    string standard = xmlNode["standard"].InnerText;
                    switch (queryType)
                    {
                        case "secedit":
                            BaselineList.Rows[index].Cells[2].Value = "-";
                            BaselineList.Rows[index].Cells[3].Value = "-";
                            string mark = xmlNode["mark"].InnerText;
                            (section, reality) = GetResultByMark(mark);
                            BaselineList.Rows[index].Cells[2].Value = section;
                            BaselineList.Rows[index].Cells[3].Value = mark;
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
                    if (ContainsElement(xmlNode, "warning"))
                    {
                        BaselineList.Rows[index].Cells[6].Value = "手动加固";
                        BaselineList.Rows[index].Cells[7].ReadOnly = true;
                        BaselineList.Rows[index].Cells[7].Style.BackColor = Color.Orange;
                        BaselineList.Rows[index].Cells[7].ToolTipText = "该项不支持自动加固";
                        passCount++;
                        continue;
                    }
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
                                SetPassStyle(index);
                                BaselineList.Rows[index].Cells[6].Value = "符合";
                                passCount++;
                            }
                            break;
                        case "equals":
                        case "enum":
                            if (reality.Equals(standard))
                            {
                                SetPassStyle(index);
                                BaselineList.Rows[index].Cells[6].Value = "符合";
                                passCount++;
                            }
                            break;
                        case "greaternumber":

                            if (reality.ToInt() >= standard.ToInt())
                            {
                                SetPassStyle(index);
                                BaselineList.Rows[index].Cells[6].Value = "符合";
                                passCount++;
                            }
                            break;
                        case "lessnumber":
                            if (reality.ToInt() <= standard.ToInt())
                            {
                                SetPassStyle(index);
                                BaselineList.Rows[index].Cells[6].Value = "符合";
                                passCount++;
                            }
                            break;
                        case "array":
                            if (reality.Equals(standard))
                            {
                                SetPassStyle(index);
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
                rate = Convert.ToDouble(passCount) / Convert.ToDouble(totalCount);
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
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.Message);
            }
        }

        private void OpenSubKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = BaselineList.SelectedCells[0].RowIndex;
            string cellValue = BaselineList[2, selectedRowIndex].Value.ToString();
            if (!cellValue.Contains("HKEY"))
            {
                UIMessageBox.ShowError("该项不支持打开");
                return;
            }
            if (!ExecutExternalProgram(string.Format(openRegCmd, cellValue), true).Equals(0))
            {
                UIMessageBox.ShowError("打开注册表项失败");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OSLabel.Text = GetOSVersion();
            IPLabel.Text = GetIPAddress();
            OSNameLabel.Text = Environment.MachineName;
        }

        private void FortifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fortifyCount = 0;
                if (File.Exists(fortifyFile))
                {
                    File.Delete(fortifyFile);
                }
                IniFile iniFile = new IniFile(fortifyFile);
                iniFile.Write("Version", "signature", "$CHICAGO$");
                foreach (DataGridViewRow dataGridViewRow in BaselineList.Rows)
                {
                    if (dataGridViewRow.Cells["FortifyColumn"].Value == null || !(bool)dataGridViewRow.Cells["FortifyColumn"].Value)
                    {
                        continue;
                    }
                    string fortifyItem, fortifyField, fortifyValue = string.Empty;
                    fortifyItem = dataGridViewRow.Cells["ItemColumn"].Value.ToString();
                    fortifyField = dataGridViewRow.Cells["FieldColumn"].Value.ToString();
                    fortifyValue = dataGridViewRow.Cells["StandardColumn"].Value.ToString();
                    if (fortifyItem.Contains("HKEY"))
                    {
                        RegistryHelper.SaveValue(fortifyItem, fortifyField, fortifyValue);
                        fortifyCount++;
                        continue;
                    }
                    //secedit加固
                    iniFile.Write(fortifyItem, fortifyField, fortifyValue);
                    iniFile.UpdateFile();
                    //TODO
                    fortifyCount++;
                }
                int code = ExecutExternalProgram(fortifyCmd, true, ProcessWindowStyle.Hidden);
                if (code != 0)
                {
                    UIMessageBox.ShowWarning(string.Format("已完成{0}项加固操作,secedit加固出现错误.请检查%windir%\\security\\logs\\scesrv.log", fortifyCount.ToString()));
                    return;
                }
                checkAllCheckBox.Checked = false;
                UIMessageBox.ShowSuccess(string.Format("已完成{0}项加固操作,请再次进行检测", fortifyCount.ToString()));
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.Message);
            }
        }

        private void checkAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!checkAllCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in BaselineList.Rows)
                    {
                        DataGridViewCell checkBoxCell = row.Cells["FortifyColumn"];
                        /*if (!checkBoxCell.ReadOnly)
                        {
                            checkBoxCell.Value = true;
                        }*/
                        checkBoxCell.Value = false;
                    }
                    return;
                }
                // 遍历 DataGridView 的所有行，并将 "CheckBoxColumn" 列的复选框设置为选中状态
                foreach (DataGridViewRow row in BaselineList.Rows)
                {
                    DataGridViewCell checkBoxCell = row.Cells["FortifyColumn"];
                    if (!checkBoxCell.ReadOnly)
                    {
                        checkBoxCell.Value = true;
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.Message);
            }

        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            UIMessageBox.ShowInfo("施工中......");
        }
    }
}
