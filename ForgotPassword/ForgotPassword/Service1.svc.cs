using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using System.Collections;
using System.Xml.Serialization;

namespace ForgotPassword
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private const string FILE_BASE_PATH = "C:\\Users\\Mukthadir\\Desktop";

        public Boolean forgotPassowrd(Dictionary<String, String> userCredentials, string fileName)
        { 
            Boolean returnValue = false;
            if (File.Exists(FILE_BASE_PATH + String.Format("\\{0}.xml", fileName)))
            {
                if (userCredentials.Count < 4) {
                    return false;
                }

                Dictionary<string, string> userInfo = new Dictionary<string, string>();

                StreamReader streamReader = new StreamReader(FILE_BASE_PATH + String.Format("\\{0}.xml", fileName));
                String output = streamReader.ReadToEnd();
                streamReader.Close();

                XElement rootElement = XElement.Parse(output);
                foreach (var element in rootElement.Elements())
                {
                    userInfo.Add(element.Name.LocalName, element.Value);
                }

                foreach (var key in userCredentials.Keys)
                {
                    if (!userInfo[key].Equals(userCredentials[key]))
                    {
                        returnValue = false;
                        return returnValue;
                    }
                }
                returnValue = true;
            }
            else
            {
                returnValue = false;
            }
            return returnValue;
        }

        public string saveData(Dictionary<String, String> userInfo, string fileName)
        {
            String returnValue;
            XElement element = new XElement("UserDetails", userInfo.Select(kv => new XElement(kv.Key, kv.Value)));
            StreamWriter streamWriter = new StreamWriter(FILE_BASE_PATH + String.Format("\\{0}.xml", fileName));
            streamWriter.WriteLine(element);
            streamWriter.Close();
            returnValue = "Updated Password Succesfully. Please login with the new Password.";
            
            return returnValue;
        }
    }
}
