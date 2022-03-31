using System;
using System.IO;
using System.Xml.Linq;

namespace XMLparser
{
    public class Class1
    {
        public static void Something()
        {
            try
            {
                XDocument xDocument = System.Xml.Linq.XDocument.Load("roles.xml");
                Console.WriteLine(xDocument);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
