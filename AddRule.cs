using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WHC.OrderWater.Commons;
using System.IO;

namespace WindowsBaselineAssistant
{
    public partial class AddRule : UIForm
    {
        public AddRule()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //获取通用字段
                string type = TypeComboBox.SelectedText;
                if (!Util.AreTextBoxesFilled(this,type))
                {
                    UIMessageBox.ShowError("缺少必填项");
                    return;
                }
                string xmlFilePath = Util.CurrentDirectory + @"\\item.xml";
                //数据字典
                Dictionary<string, string> itemData = new Dictionary<string, string>
                {
                    { "name", NameTextBox.Text.Trim() },
                    { "description", DescTextBox.Text.Trim() },
                    { "type", TypeComboBox.SelectedText }
                };
                switch (type)
                {
                    case "registry":
                        itemData.Add("registry", ItemTextBox.Text.Trim());
                        itemData.Add("regitem", FieldTextBox.Text.Trim());
                        break;
                    default:
                        itemData.Add("mark", ItemTextBox.Text.Trim());
                        break;
                }
                itemData.Add("standard", StandardTextBox.Text.Trim());
                itemData.Add("assessment", AssessmentComboBox.SelectedText);
                if (type.Equals("registry"))
                {
                    itemData.Add("valuetype", ValuetypeComboBox.SelectedText);
                }
                string mark = MarkComboBox.SelectedText;
                if (!mark.Equals("normal"))
                {
                    itemData.Add(mark, "1");
                }
                // 检查XML文件是否存在
                if (File.Exists(xmlFilePath))
                {
                    // 如果XML文件存在，则加载该文件并添加item元素数据
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(xmlFilePath);

                    XmlElement itemsElement = xmlDoc.DocumentElement;
                    if (itemsElement.Name != "items")
                    {
                        UIMessageBox.ShowError("根元素不是items，无法添加数据。");
                        return;
                    }

                    Util.AddItem(xmlDoc, itemsElement, itemData);
                    xmlDoc.Save(xmlFilePath);
                    UIMessageBox.ShowSuccess("添加成功");
                }
                else
                {
                    // 如果XML文件不存在，则创建一个新的XML文件并添加item元素数据
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlElement itemsElement = xmlDoc.CreateElement("items");
                    xmlDoc.AppendChild(itemsElement);
                    Util.AddItem(xmlDoc, itemsElement, itemData);
                    xmlDoc.Save(xmlFilePath);
                    UIMessageBox.ShowSuccess("规则库文件已生成并保存为item.xml");
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.Message);
            }
        }
        

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBox.SelectedIndex.Equals(1))
            {
                FieldTextBox.Enabled = false;
                ValuetypeComboBox.Enabled = false;
                return;
            }
            FieldTextBox.Enabled = true;
            ValuetypeComboBox.Enabled = true;
        }

        private void AddRule_Load(object sender, EventArgs e)
        {
            TypeComboBox.SelectedIndex = 0;
            AssessmentComboBox.SelectedIndex = 1;
            ValuetypeComboBox.SelectedIndex = 2;
            MarkComboBox.SelectedIndex = 0;
        }
    }
}
