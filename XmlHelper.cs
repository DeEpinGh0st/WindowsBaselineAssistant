using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;
using System.Data;

namespace WHC.OrderWater.Commons
{
     /// <summary>
    /// XML操作类
    /// </summary>
    public class XmlHelper
    {
        #region 变量
        protected string strXmlFile;
        protected XmlDocument objXmlDoc = new XmlDocument();
        #endregion

        #region Constructors
        public XmlHelper(string XmlFile)
        {
            try
            {
                objXmlDoc.Load(XmlFile);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            strXmlFile = XmlFile;
        }
        #endregion

        #region StaticMethod
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="path"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool Serialize(string path, object obj)
        {
            try
            {
                using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    IFormatter format = new BinaryFormatter();

                    format.Serialize(stream, obj);
                    stream.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="path"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool XmlSerialize(string path, object obj, Type type)
        {
            try
            {
                if (!File.Exists(path))
                {
                    FileInfo fi = new FileInfo(path);
                    if (!fi.Directory.Exists)
                    {
                        Directory.CreateDirectory(fi.Directory.FullName);
                    }

                    //File.Create(path);
                }

                using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer format = new XmlSerializer(type);

                    format.Serialize(stream, obj);
                    stream.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static object Deserialize(string path)
        {
            try
            {
                using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    stream.Seek(0, SeekOrigin.Begin);
                    object obj = formatter.Deserialize(stream);
                    stream.Close();
                    return obj;
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static object XmlDeserialize(string path, Type type)
        {
            try
            {
                using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer formatter = new XmlSerializer(type);
                    stream.Seek(0, SeekOrigin.Begin);
                    object obj = formatter.Deserialize(stream);
                    stream.Close();
                    return obj;
                }
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region PublicMethod
        /// <summary>
        /// 读取节点内容
        /// </summary>
        /// <param name="XmlPathNode"></param>
        /// <param name="Attrib"></param>
        /// <returns></returns>
        public string Read(string XmlPathNode, string Attrib)
        {
            string value = "";
            try
            {
                XmlNode xn = objXmlDoc.SelectSingleNode(XmlPathNode);
                value = (Attrib.Equals("") ? xn.InnerText : xn.Attributes[Attrib].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return value;
        }

        /// <summary>
        /// 获取节点下的DataSet
        /// </summary>
        /// <param name="XmlPathNode"></param>
        /// <returns></returns>
        public DataSet GetData(string XmlPathNode)
        {
            DataSet ds = new DataSet();
            StringReader read = new StringReader(objXmlDoc.SelectSingleNode(XmlPathNode).OuterXml);
            ds.ReadXml(read);
            return ds;
        }

        /// <summary>
        /// 替换某节点的内容
        /// </summary>
        /// <param name="XmlPathNode"></param>
        /// <param name="Content"></param>
        public void Replace(string XmlPathNode, string Content)
        {
            objXmlDoc.SelectSingleNode(XmlPathNode).InnerText = Content;
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="Node"></param>
        public void Delete(string Node)
        {
            string mainNode = Node.Substring(0, Node.LastIndexOf("/"));
            objXmlDoc.SelectSingleNode(mainNode).RemoveChild(objXmlDoc.SelectSingleNode(Node));
        }

        /// <summary>
        /// 插入一节点和此节点的一子节点
        /// </summary>
        /// <param name="MainNode"></param>
        /// <param name="ChildNode"></param>
        /// <param name="Element"></param>
        /// <param name="Content"></param>
        public void InsertNode(string MainNode, string ChildNode, string Element, string Content)
        {
            XmlNode objRootNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objChildNode = objXmlDoc.CreateElement(ChildNode);
            objRootNode.AppendChild(objChildNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objChildNode.AppendChild(objElement);
        }

        /// <summary>
        /// 插入一个节点带一个属性 
        /// </summary>
        /// <param name="MainNode"></param>
        /// <param name="Element"></param>
        /// <param name="Attrib"></param>
        /// <param name="AttribContent"></param>
        /// <param name="Content"></param>
        public void InsertElement(string MainNode, string Element, string Attrib, string AttribContent, string Content)
        {
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.SetAttribute(Attrib, AttribContent);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
        }

        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="MainNode"></param>
        /// <param name="Element"></param>
        /// <param name="Content"></param>
        public void InsertElement(string MainNode, string Element, string Content)
        {
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
        }

        /// <summary>
        /// 保存XML
        /// </summary>
        public void Save()
        {
            try
            {
                objXmlDoc.Save(strXmlFile);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            objXmlDoc = null;
        }
        #endregion
    }
}
