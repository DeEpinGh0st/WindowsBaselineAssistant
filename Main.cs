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
            xmlDocument = ReadXml(@"D:\Projects\C#\WindowsBaselineAssistant\bin\Debug\item.xml");
            if (xmlDocument != null)
            {
                BaselineList.Rows.Clear();
                xmlElement = xmlDocument.DocumentElement;
                xmlNodeList =  xmlElement.ChildNodes;
                foreach (XmlNode xmlNode in xmlNodeList)
                {
                    int index = BaselineList.Rows.Add();
                    /*string name = xmlNode["name"].InnerText;*/
                    BaselineList.Rows[index].Cells[0].Value = xmlNode["name"].InnerText;
                    BaselineList.Rows[index].Cells[1].Value = xmlNode["description"].InnerText;
                    BaselineList.Rows[index].Cells[2].Value = xmlNode["registry"].InnerText;
                    BaselineList.Rows[index].Cells[3].Value = xmlNode["regitem"].InnerText;
                    BaselineList.Rows[index].Cells[4].Value = xmlNode["standard"].InnerText;
                    //检测实际值
                    string reality = RegistryHelper.GetValue(Registry.LocalMachine, xmlNode["registry"].InnerText, xmlNode["regitem"].InnerText);
                    BaselineList.Rows[index].Cells[5].Value = reality;
                    if (reality == xmlNode["standard"].InnerText)
                    {
                        BaselineList.Rows[index].Cells[6].Value = "符合";
                    }
                    BaselineList.Rows[index].Cells[6].Value = "不符合";
                }
            }
        }
    }
}
