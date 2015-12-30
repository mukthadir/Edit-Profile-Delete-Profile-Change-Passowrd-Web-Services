using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApplicationTest
{
    public class UserInformation
    {
        String name;
        String phoneNumber;
        String emailID;
        String address;
        String SSN;
        String emergencyContactName;
        String emergencyContactPhoneNumber;
        String emergencyContactEmailID;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string SSN1
        {
            get { return SSN; }
            set { SSN = value; }
        }

        public string EmergencyContactName
        {
            get { return emergencyContactName; }
            set { emergencyContactName = value; }
        }

        public string EmergencyContactPhoneNumber
        {
            get { return emergencyContactPhoneNumber; }
            set { emergencyContactPhoneNumber = value; }
        }

        public string EmergencyContactEmailID
        {
            get { return emergencyContactEmailID; }
            set { emergencyContactEmailID = value; }
        }
    }
}