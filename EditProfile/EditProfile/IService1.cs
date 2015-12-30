using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace EditProfile
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        
        [OperationContract]
        string saveData(Dictionary<String, String> userInfo, string fileName);

        [OperationContract]
        string modifyUserDetails(Dictionary<String, String> userLatestInfo, string fileName);

        [OperationContract]
        string deleteUser(string username);

        [OperationContract]
        String displayUserDetails(string userName);

        [OperationContract]
        Boolean forgotPassowrd(Dictionary<String, String> userCredentials, string fileName);

        [OperationContract]
        string saveData1(Dictionary<String, String> userInfo, string fileName);

        [OperationContract]
        List<String> PeopleTravellingToSameDestination(string destination, string filename);
    }
}