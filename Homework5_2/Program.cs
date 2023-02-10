

using System;
using System.Xml;


namespace Homework5_2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var document = new XmlDocument();
            document.Load("TelephoneBook.xml");

            // Показ вмісту XML.
            Console.WriteLine(document.InnerText);

            Console.WriteLine(new string('-', 20));

            // Показ коду XML документа.
            Console.WriteLine(document.InnerXml);

            // Delay.
            Console.ReadKey();
        }
    }
}
