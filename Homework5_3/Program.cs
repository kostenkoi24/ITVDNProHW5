using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Homework5_3
{
    class Program
    {
        static void Main(string[] args)
        {

            var document = new XmlDocument();
            document.Load("TelephoneBook.xml");

            XmlNodeList xmlNodeList = document.GetElementsByTagName("TelephoneNumber");
            foreach (XmlNode node in xmlNodeList)
            {
                Console.WriteLine(node.InnerText);
            }

                    


            // Delay.
            Console.ReadKey();
        }
    }
}
