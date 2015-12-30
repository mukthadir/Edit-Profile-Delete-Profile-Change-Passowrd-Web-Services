using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;

namespace EditProfile
{
    public class userProfile
    {
        public static void saveData(object obj, string fileName)
        {
            XmlSerializer ser = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(fileName);
            ser.Serialize(writer, obj);
            writer.Close();
        }
    }
}