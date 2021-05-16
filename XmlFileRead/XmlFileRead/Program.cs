using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlFileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            try
            {
                var text = File.ReadAllText(@"C:\Users\z0040mvt\Documents\Visual Studio 2017\Projects\XmlFileRead\XmlFileRead\2020_08_05.auditlog");
                doc = new XmlDocument();
                var rootElement = doc.CreateElement("auditLog");
                rootElement.InnerXml = text;
                doc.AppendChild(rootElement);

                int lastNodeIndex = doc.FirstChild.ChildNodes.Count - 2;
                var lastNode = doc.FirstChild.ChildNodes[lastNodeIndex].InnerXml;
            }
            catch (Exception ex)
            {

            }
            Console.Read();
        }
    }
}
