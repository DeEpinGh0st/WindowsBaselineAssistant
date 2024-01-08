using Sunny.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Xml;

namespace WindowsBaselineAssistant
{
    internal class Util
    {
        private static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public static string CurrentDirectory { get => currentDirectory; set => currentDirectory = value; }

        /// <summary>
        /// 读xml文件
        /// </summary>
        /// <param name="xmlpath">xml文件路径</param>
        /// <returns>XmlDocument实例</returns>
        public static XmlDocument ReadXml(string xmlpath)
        {
            if (!File.Exists(xmlpath))
            {
                return null;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlpath);
            return xmlDocument;
        }

        /// <summary>
        /// 根据secedit中的key获取所属节和值
        /// </summary>
        /// <param name="mark">key</param>
        /// <returns>节,值</returns>
        public static (string, string) GetResultByMark(string mark)
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

        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        /// <returns>IP地址</returns>
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

        /// <summary>
        /// 获取系统版本信息
        /// </summary>
        /// <returns>系统版本信息</returns>
        public static string GetOSVersion()
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

        /// <summary>
        /// 判断XmlNode是否包含某一个键
        /// </summary>
        /// <param name="parentNode">xmlnode对象</param>
        /// <param name="elementName">包含的键</param>
        /// <returns>true: 包含 false：不包含</returns>
        public static bool ContainsElement(XmlNode parentNode, string elementName)
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
        /// <returns>执行状态码</returns>
        public static int ExecutExternalProgram(string command, bool isnowindow, ProcessWindowStyle processWindowStyle = ProcessWindowStyle.Normal)
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
                WorkingDirectory = Util.CurrentDirectory
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
    }
}
