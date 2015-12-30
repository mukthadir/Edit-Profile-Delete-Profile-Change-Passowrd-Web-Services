using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInformation userData = new UserInformation();


            userData.Name = "rajan";
            userData.PhoneNumber = "12345";





            ServiceReference1.Service1Client myy = new ServiceReference1.Service1Client();




            myy.setName("rajan");

            Dictionary<String, String> output = myy.editProfile();

            //XElement rootElement = XElement.Parse("<root><key>value</key></root>");
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //foreach (var el in rootElement.Elements())
            //{
            //    dict.Add(el.Name.LocalName, el.Value);
            //}




            foreach (var entry in output)
            {
                Console.WriteLine("[{0} {1}]", entry.Key, entry.Value);
            }
        }
    }
}
