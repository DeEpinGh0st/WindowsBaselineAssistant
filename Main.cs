using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using Sunny.UI;
using WHC.OrderWater.Commons;
using System.IO;
using System.Reflection;

namespace WindowsBaselineAssistant
{
    public partial class Main : UIForm
    {
        public Main()
        {
            InitializeComponent();
        }
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        XmlNodeList xmlNodeList;
        XmlDocument xmlDocument;
        XmlElement xmlElement;
        XmlNode xmlNode;

        private XmlDocument ReadXml(string xmlpath) {
            if (!File.Exists(xmlpath)) { 
                return null;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlpath);
            return xmlDocument;
        }

        private string GetResultByMark(string mark) {
            /*// 要执行的命令
            string command = "type config.cfg | findstr ";
            // 创建一个新的进程启动信息
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = "/c " + command + mark,
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
                // 获取命令输出
                string output = process.StandardOutput.ReadToEnd().Split("=")[1];
                // 等待进程执行完成
                process.WaitForExit();

                // 打印输出结果
                return output;
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.Message);
                return null;
            }
            finally
            {
                // 关闭进程
                process.Close();
                process.Dispose();
            }*/
            return "";
            //TODO
        }

        private void AboutLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DeEpinGh0st/WindowsBaselineAssistant");
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            /*string xmlPath = @"D:\Projects\C#\WindowsBaselineAssistant\bin\Debug\item.xml";
            XmlHelper xmlHelper = new XmlHelper(xmlPath);
            DataSet dataSet =  xmlHelper.GetData("items");
            DataColumnCollection dataColumnCollection = dataSet.Tables[0].Columns;
*//*            dataColumnCollection.Remove("registry");
            dataColumnCollection.Remove("regitem");*//*
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                int index = BaselineList.Rows.Add();
                foreach (DataColumn dataColumn in dataColumnCollection)
                {
                    //MessageBox.Show(dataRow[dataColumn].ToString());
                    BaselineList.Rows[index].Cells[dataColumn.Ordinal].Value = dataRow[dataColumn].ToString();
                    string reality = RegistryHelper.GetValue("SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp", "PortNumber");
                    BaselineList.Rows[index].Cells[dataColumn.Ordinal+1].Value = reality;
                    if (dataRow[""])
                    {
                        BaselineList.Rows[index].Cells[dataColumn.Ordinal + 2].Value = "符合";
                    }
                    BaselineList.Rows[index].Cells[dataColumn.Ordinal + 2].Value = "不符合";
                }
            }*/
            xmlDocument = ReadXml(currentDirectory+  @"\item.xml");
            if (xmlDocument == null)
            {
                UIMessageBox.ShowError("未找到配置文件");
                return;
            }
            BaselineList.Rows.Clear();
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
                string reality;
                switch (queryType)
                {
                    case "secedit":
                        reality = GetResultByMark(xmlNode["mark"].InnerText);
                        BaselineList.Rows[index].Cells[5].Value = reality;
                        break;
                    case "registry":
                        BaselineList.Rows[index].Cells[2].Value = xmlNode["registry"].InnerText;
                        BaselineList.Rows[index].Cells[3].Value = xmlNode["regitem"].InnerText;
                        reality = RegistryHelper.GetValue(Registry.LocalMachine, xmlNode["registry"].InnerText, xmlNode["regitem"].InnerText);
                        BaselineList.Rows[index].Cells[5].Value = reality;
                        break;
                    default:
                        break;
                }
                /*if (reality == xmlNode["standard"].InnerText)
                {
                    BaselineList.Rows[index].Cells[6].Value = "符合";
                }
                BaselineList.Rows[index].Cells[6].Value = "不符合";*/
            }
            
        }
    }
}
