using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XMLConfiguration
{
    /// <summary>
    /// 用于访问系统配置文件的静态工具类
    /// </summary>
    public class XMLConfigurationTool
    {
        //配置文件对象
        private static XmlDocument xmlConfig;
        //配置文件保存地址
        private static string configFileString;
        //配置文件根节点名称
        private static string rootName = "ApplicationConfig";

        /// <summary>
        /// 私有的构造方法
        /// </summary>
        static XMLConfigurationTool()
        {
            //获取配置文件的保存地址
            configFileString = GetApplicationPath() + "\\Config.xml";

            //读取配置文件到内存中
            xmlConfig = new XmlDocument();

            //定义配置文件的文件流
            System.IO.Stream stream;

            //若配置文件读取失败，则创建配置文件
            try
            {
                stream = new System.IO.FileStream(configFileString, System.IO.FileMode.Open);
                xmlConfig.Load(stream);
            }
            catch (Exception)
            {
                xmlConfig.LoadXml("<?xml version=\"1.0\" encoding=\"gb2312\"?><" + rootName + "></" + rootName + ">");
                xmlConfig.Save(configFileString);
            }
        }

        /// <summary>
        /// 获取应用程序所在目录
        /// </summary>
        /// <returns></returns>
        public static string GetApplicationPath()
        {
            string path = System.Environment.CurrentDirectory;
            return path;
        }

        /// <summary>
        /// 设置或添加配置项，若配置项不存在则自动添加，否则更改配置项的值
        /// </summary>
        /// <param name="configItemName">配置项名称</param>
        /// <param name="configItemValue">配置项的值</param>
        /// <returns></returns>
        public static bool SetConfigItem(string configItemName, string configItemValue)
        {
            try
            {
                //定义配置文件根节点的引用
                XmlElement rootElement = (XmlElement)xmlConfig.SelectSingleNode("/" + rootName);

                //定义配置项节点的引用
                XmlElement newChildNode = null;

                //查找名为configItemName的节点
                newChildNode = (XmlElement)xmlConfig.SelectSingleNode("/" + rootName + "/" + configItemName);

                //若该配置项已经存在，改变该配置项的值，否则创建该配置项
                if (newChildNode != null)
                {
                    newChildNode.InnerText = Security.Encode(configItemValue);
                }
                else
                {
                    //创建新节点
                    newChildNode = xmlConfig.CreateElement(configItemName);
                    newChildNode.InnerText = Security.Encode(configItemValue);

                    //将新节点添加到配置文件中
                    rootElement.AppendChild(newChildNode);
                }
                xmlConfig.Save(configFileString);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// 读取配置项的值，若配置项不存在则返回为null
        /// </summary>
        /// <param name="configItemName">配置项的名称</param>
        /// <returns></returns>
        public static string GetConfigItem(string configItemName, string defaultValue)
        {
            //定义配置项节点的引用
            XmlElement newChildNode = null;

            //查找名为configItemName的节点
            newChildNode = (XmlElement)xmlConfig.SelectSingleNode("/" + rootName + "/" + configItemName);

            //若配置项存在，返回配置项的值，否则返回null
            if (null != newChildNode)
            {
                return Security.Decode(newChildNode.InnerText);
            }
            else
            {
                return defaultValue;
            }
        }
    }
}
