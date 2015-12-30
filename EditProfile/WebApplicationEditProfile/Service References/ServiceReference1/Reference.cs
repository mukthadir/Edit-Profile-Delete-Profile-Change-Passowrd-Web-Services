﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationEditProfile.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveData", ReplyAction="http://tempuri.org/IService1/saveDataResponse")]
        string saveData(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveData", ReplyAction="http://tempuri.org/IService1/saveDataResponse")]
        System.Threading.Tasks.Task<string> saveDataAsync(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/modifyUserDetails", ReplyAction="http://tempuri.org/IService1/modifyUserDetailsResponse")]
        string modifyUserDetails(System.Collections.Generic.Dictionary<string, string> userLatestInfo, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/modifyUserDetails", ReplyAction="http://tempuri.org/IService1/modifyUserDetailsResponse")]
        System.Threading.Tasks.Task<string> modifyUserDetailsAsync(System.Collections.Generic.Dictionary<string, string> userLatestInfo, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteUser", ReplyAction="http://tempuri.org/IService1/deleteUserResponse")]
        string deleteUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteUser", ReplyAction="http://tempuri.org/IService1/deleteUserResponse")]
        System.Threading.Tasks.Task<string> deleteUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/displayUserDetails", ReplyAction="http://tempuri.org/IService1/displayUserDetailsResponse")]
        string displayUserDetails(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/displayUserDetails", ReplyAction="http://tempuri.org/IService1/displayUserDetailsResponse")]
        System.Threading.Tasks.Task<string> displayUserDetailsAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/forgotPassowrd", ReplyAction="http://tempuri.org/IService1/forgotPassowrdResponse")]
        bool forgotPassowrd(System.Collections.Generic.Dictionary<string, string> userCredentials, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/forgotPassowrd", ReplyAction="http://tempuri.org/IService1/forgotPassowrdResponse")]
        System.Threading.Tasks.Task<bool> forgotPassowrdAsync(System.Collections.Generic.Dictionary<string, string> userCredentials, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveData1", ReplyAction="http://tempuri.org/IService1/saveData1Response")]
        string saveData1(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveData1", ReplyAction="http://tempuri.org/IService1/saveData1Response")]
        System.Threading.Tasks.Task<string> saveData1Async(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PeopleTravellingToSameDestination", ReplyAction="http://tempuri.org/IService1/PeopleTravellingToSameDestinationResponse")]
        string[] PeopleTravellingToSameDestination(string destination, string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PeopleTravellingToSameDestination", ReplyAction="http://tempuri.org/IService1/PeopleTravellingToSameDestinationResponse")]
        System.Threading.Tasks.Task<string[]> PeopleTravellingToSameDestinationAsync(string destination, string filename);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplicationEditProfile.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplicationEditProfile.ServiceReference1.IService1>, WebApplicationEditProfile.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string saveData(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName) {
            return base.Channel.saveData(userInfo, fileName);
        }
        
        public System.Threading.Tasks.Task<string> saveDataAsync(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName) {
            return base.Channel.saveDataAsync(userInfo, fileName);
        }
        
        public string modifyUserDetails(System.Collections.Generic.Dictionary<string, string> userLatestInfo, string fileName) {
            return base.Channel.modifyUserDetails(userLatestInfo, fileName);
        }
        
        public System.Threading.Tasks.Task<string> modifyUserDetailsAsync(System.Collections.Generic.Dictionary<string, string> userLatestInfo, string fileName) {
            return base.Channel.modifyUserDetailsAsync(userLatestInfo, fileName);
        }
        
        public string deleteUser(string username) {
            return base.Channel.deleteUser(username);
        }
        
        public System.Threading.Tasks.Task<string> deleteUserAsync(string username) {
            return base.Channel.deleteUserAsync(username);
        }
        
        public string displayUserDetails(string userName) {
            return base.Channel.displayUserDetails(userName);
        }
        
        public System.Threading.Tasks.Task<string> displayUserDetailsAsync(string userName) {
            return base.Channel.displayUserDetailsAsync(userName);
        }
        
        public bool forgotPassowrd(System.Collections.Generic.Dictionary<string, string> userCredentials, string fileName) {
            return base.Channel.forgotPassowrd(userCredentials, fileName);
        }
        
        public System.Threading.Tasks.Task<bool> forgotPassowrdAsync(System.Collections.Generic.Dictionary<string, string> userCredentials, string fileName) {
            return base.Channel.forgotPassowrdAsync(userCredentials, fileName);
        }
        
        public string saveData1(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName) {
            return base.Channel.saveData1(userInfo, fileName);
        }
        
        public System.Threading.Tasks.Task<string> saveData1Async(System.Collections.Generic.Dictionary<string, string> userInfo, string fileName) {
            return base.Channel.saveData1Async(userInfo, fileName);
        }
        
        public string[] PeopleTravellingToSameDestination(string destination, string filename) {
            return base.Channel.PeopleTravellingToSameDestination(destination, filename);
        }
        
        public System.Threading.Tasks.Task<string[]> PeopleTravellingToSameDestinationAsync(string destination, string filename) {
            return base.Channel.PeopleTravellingToSameDestinationAsync(destination, filename);
        }
    }
}
