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
using System.Web;

namespace EditProfile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Service1 : IService1 
    {
        // constant path where all the files will be saved
        string FILE_BASE_PATH = Path.Combine(HttpRuntime.AppDomainAppPath, "App_Data", "Users");

        // This method saves the given values in a text file at the server
        public string saveData(Dictionary<String, String> userInfo, string fileName)
        {
            String returnValue;
            // checking if the dictionary is empty or not
            if (userInfo.Count == 0)
            {
                returnValue = "Nothing to modify.";
            }
            else
            {
                // converting the dictionary into an xml
                XElement element = new XElement("UserDetails", userInfo.Select(kv => new XElement(kv.Key, kv.Value)));
                //saving the file using streamWriter
                StreamWriter streamWriter = new StreamWriter(FILE_BASE_PATH + String.Format("\\{0}.txt", fileName));
                streamWriter.WriteLine(element);
                streamWriter.Close();
                returnValue = "Saved user details succesfully";
            }
            return returnValue;
        }

        // This method modifies the details of the user
        public string modifyUserDetails(Dictionary<String, String> userLatestInfo, string fileName)
        {
            String returnValue;
            // modifies only if the account is already present in the server
            if (File.Exists(FILE_BASE_PATH + String.Format("\\{0}.txt", fileName)))
            {
                if (userLatestInfo.Count == 0)
                {
                    returnValue = "Nothing to modify.";
                }
                else
                {
                    Dictionary<string, string> oldInfo = new Dictionary<string, string>();

                    StreamReader streamReader = new StreamReader(FILE_BASE_PATH + String.Format("\\{0}.txt", fileName));
                    String output = streamReader.ReadToEnd();
                    streamReader.Close();

                    // parsing the xml file obtained from the text file and adding into a dictionary
                    XElement rootElement = XElement.Parse(output);
                    foreach (var element in rootElement.Elements())
                    {
                        oldInfo.Add(element.Name.LocalName, element.Value);
                    }

                    // modifying all the user supplied new values
                    foreach (var key in userLatestInfo.Keys)
                    {
                        oldInfo[key] = userLatestInfo[key];
                    }

                    // saving the new values
                    saveData(oldInfo, fileName);

                    returnValue = "User Profile modified successfully";
                }
            }
            else
            {
                returnValue = String.Format("User {0} does not exists.", fileName);
            }
            return returnValue;
        }

        // this method deletes the user account from the server
        public string deleteUser(string username)
        { 
            String returnValue;
            // deletes only if already present
            if (File.Exists(FILE_BASE_PATH + String.Format("\\{0}.txt", username)))
            {
                File.Delete(FILE_BASE_PATH + String.Format("\\{0}.txt", username));
                returnValue = "User Profile deleted successfully";
            }
            else
            {
                returnValue = String.Format("User {0} does not exists.", username);
            }
            return returnValue;
        }

        // This method displays all the saved details of the user
        public String displayUserDetails(string userName)
        {
            String returnValue;
            if (File.Exists(FILE_BASE_PATH + String.Format("\\{0}.txt", userName)))
            {
                Dictionary<string, string> userInfo = new Dictionary<string, string>();

                StreamReader streamReader = new StreamReader(FILE_BASE_PATH + String.Format("\\{0}.txt", userName));
                returnValue = streamReader.ReadToEnd();
                streamReader.Close();
            }
            else
            {
                returnValue = String.Format("User {0} does not exists.", userName);
            }
            return returnValue;
        }

        // This method helps the user to change his password in case he forgets it
        public Boolean forgotPassowrd(Dictionary<String, String> userCredentials, string fileName)
        {
            Boolean returnValue = false;
            if (File.Exists(FILE_BASE_PATH + String.Format("\\{0}.txt", fileName)))
            {
                if (userCredentials.Count < 4)
                {
                    return false;
                }

                Dictionary<string, string> userInfo = new Dictionary<string, string>();

                StreamReader streamReader = new StreamReader(FILE_BASE_PATH + String.Format("\\{0}.txt", fileName));
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

        // this is a helper method which helps in saving the user information
        public string saveData1(Dictionary<String, String> userInfo, string fileName)
        {
            String returnValue;
            XElement element = new XElement("UserDetails", userInfo.Select(kv => new XElement(kv.Key, kv.Value)));
            StreamWriter streamWriter = new StreamWriter(FILE_BASE_PATH + String.Format("\\{0}.txt", fileName));
            streamWriter.WriteLine(element);
            streamWriter.Close();
            returnValue = "Updated Password Succesfully. Please login with the new Password.";

            return returnValue;
        }

        // this method returns all those users that are travelling to the same destination as current user
        public List<String> PeopleTravellingToSameDestination(string destination, string filename)
        {
            if (File.Exists(FILE_BASE_PATH + String.Format("\\{0}.txt", filename)))
            {
                Dictionary<String, String> userInfo = new Dictionary<string, string>();
                List<String> userWithSameDestination = new List<String>();
                userInfo.Add("Destination", destination);
                // first, we add the destination to the current user details
                modifyUserDetails(userInfo, filename);

                // we search for all the users present in the system
                var foundFiles = Directory.GetFiles(@FILE_BASE_PATH, "*.txt");

                // we then find how many of them are travelling to the same destination
                foreach (var file in foundFiles)
                {
                    var info = readData(file);

                    if (info.ContainsKey("Destination"))
                    {
                        if (info["Destination"].Equals(destination))
                        {
                            userWithSameDestination.Add(info["Name"]);
                        }
                    }
                }
                return userWithSameDestination;
            }
            else
            {
                List<String> noUser = new List<String>();
                noUser.Add("This user is not using this service");
                return noUser;
            }
        }

        // this is a helper method which helps in reading the file obtained from the server and adds the values
        // to a dictionary
        public Dictionary<string, string> readData(string fileName)
        {
            Dictionary<string, string> oldInfo = new Dictionary<string, string>();

            StreamReader streamReader = new StreamReader(fileName);
            String output = streamReader.ReadToEnd();
            streamReader.Close();

            XElement rootElement = XElement.Parse(output);
            foreach (var element in rootElement.Elements())
            {
                oldInfo.Add(element.Name.LocalName, element.Value);
            }

            return oldInfo;
        }
    }
}
