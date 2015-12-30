using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ForgotPassword
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Boolean forgotPassowrd(Dictionary<String, String> userCredentials, string fileName);

        [OperationContract]
        string saveData(Dictionary<String, String> userInfo, string fileName);
    }
}
