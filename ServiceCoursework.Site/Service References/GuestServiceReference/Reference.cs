﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceCoursework.Site.GuestServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Guests", Namespace="http://schemas.datacontract.org/2004/07/ServiceCoursework.Services")]
    [System.SerializableAttribute()]
    public partial class Guests : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool WillAttendField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool WillAttend {
            get {
                return this.WillAttendField;
            }
            set {
                if ((this.WillAttendField.Equals(value) != true)) {
                    this.WillAttendField = value;
                    this.RaisePropertyChanged("WillAttend");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GuestServiceReference.IGuestService")]
    public interface IGuestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/GetData", ReplyAction="http://tempuri.org/IGuestService/GetDataResponse")]
        string GetData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/GetData", ReplyAction="http://tempuri.org/IGuestService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/Echo", ReplyAction="http://tempuri.org/IGuestService/EchoResponse")]
        string Echo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/Echo", ReplyAction="http://tempuri.org/IGuestService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/CreateGuest", ReplyAction="http://tempuri.org/IGuestService/CreateGuestResponse")]
        ServiceCoursework.Site.GuestServiceReference.Guests CreateGuest(string name, string email, string phone, bool willAttend, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/CreateGuest", ReplyAction="http://tempuri.org/IGuestService/CreateGuestResponse")]
        System.Threading.Tasks.Task<ServiceCoursework.Site.GuestServiceReference.Guests> CreateGuestAsync(string name, string email, string phone, bool willAttend, string comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/AddGuestByJson", ReplyAction="http://tempuri.org/IGuestService/AddGuestByJsonResponse")]
        string AddGuestByJson(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/AddGuestByJson", ReplyAction="http://tempuri.org/IGuestService/AddGuestByJsonResponse")]
        System.Threading.Tasks.Task<string> AddGuestByJsonAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/AddGuest", ReplyAction="http://tempuri.org/IGuestService/AddGuestResponse")]
        string AddGuest(ServiceCoursework.Site.GuestServiceReference.Guests value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/AddGuest", ReplyAction="http://tempuri.org/IGuestService/AddGuestResponse")]
        System.Threading.Tasks.Task<string> AddGuestAsync(ServiceCoursework.Site.GuestServiceReference.Guests value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/GetAll", ReplyAction="http://tempuri.org/IGuestService/GetAllResponse")]
        ServiceCoursework.Site.GuestServiceReference.Guests[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/GetAll", ReplyAction="http://tempuri.org/IGuestService/GetAllResponse")]
        System.Threading.Tasks.Task<ServiceCoursework.Site.GuestServiceReference.Guests[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/GetAllInJson", ReplyAction="http://tempuri.org/IGuestService/GetAllInJsonResponse")]
        string GetAllInJson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuestService/GetAllInJson", ReplyAction="http://tempuri.org/IGuestService/GetAllInJsonResponse")]
        System.Threading.Tasks.Task<string> GetAllInJsonAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGuestServiceChannel : ServiceCoursework.Site.GuestServiceReference.IGuestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GuestServiceClient : System.ServiceModel.ClientBase<ServiceCoursework.Site.GuestServiceReference.IGuestService>, ServiceCoursework.Site.GuestServiceReference.IGuestService {
        
        public GuestServiceClient() {
        }
        
        public GuestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GuestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(string value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(string value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string Echo() {
            return base.Channel.Echo();
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync() {
            return base.Channel.EchoAsync();
        }
        
        public ServiceCoursework.Site.GuestServiceReference.Guests CreateGuest(string name, string email, string phone, bool willAttend, string comment) {
            return base.Channel.CreateGuest(name, email, phone, willAttend, comment);
        }
        
        public System.Threading.Tasks.Task<ServiceCoursework.Site.GuestServiceReference.Guests> CreateGuestAsync(string name, string email, string phone, bool willAttend, string comment) {
            return base.Channel.CreateGuestAsync(name, email, phone, willAttend, comment);
        }
        
        public string AddGuestByJson(string value) {
            return base.Channel.AddGuestByJson(value);
        }
        
        public System.Threading.Tasks.Task<string> AddGuestByJsonAsync(string value) {
            return base.Channel.AddGuestByJsonAsync(value);
        }
        
        public string AddGuest(ServiceCoursework.Site.GuestServiceReference.Guests value) {
            return base.Channel.AddGuest(value);
        }
        
        public System.Threading.Tasks.Task<string> AddGuestAsync(ServiceCoursework.Site.GuestServiceReference.Guests value) {
            return base.Channel.AddGuestAsync(value);
        }
        
        public ServiceCoursework.Site.GuestServiceReference.Guests[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ServiceCoursework.Site.GuestServiceReference.Guests[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public string GetAllInJson() {
            return base.Channel.GetAllInJson();
        }
        
        public System.Threading.Tasks.Task<string> GetAllInJsonAsync() {
            return base.Channel.GetAllInJsonAsync();
        }
    }
}
