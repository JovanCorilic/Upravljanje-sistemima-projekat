﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseManager.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AI", Namespace="http://schemas.datacontract.org/2004/07/SCADA")]
    [System.SerializableAttribute()]
    public partial class AI : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IO_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string alarmsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string driverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string high_limitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string low_limitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool onoff_scanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string scan_timeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tag_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string unitsField;
        
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
        public string IO_address {
            get {
                return this.IO_addressField;
            }
            set {
                if ((object.ReferenceEquals(this.IO_addressField, value) != true)) {
                    this.IO_addressField = value;
                    this.RaisePropertyChanged("IO_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string alarms {
            get {
                return this.alarmsField;
            }
            set {
                if ((object.ReferenceEquals(this.alarmsField, value) != true)) {
                    this.alarmsField = value;
                    this.RaisePropertyChanged("alarms");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driver {
            get {
                return this.driverField;
            }
            set {
                if ((object.ReferenceEquals(this.driverField, value) != true)) {
                    this.driverField = value;
                    this.RaisePropertyChanged("driver");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string high_limit {
            get {
                return this.high_limitField;
            }
            set {
                if ((object.ReferenceEquals(this.high_limitField, value) != true)) {
                    this.high_limitField = value;
                    this.RaisePropertyChanged("high_limit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string low_limit {
            get {
                return this.low_limitField;
            }
            set {
                if ((object.ReferenceEquals(this.low_limitField, value) != true)) {
                    this.low_limitField = value;
                    this.RaisePropertyChanged("low_limit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool onoff_scan {
            get {
                return this.onoff_scanField;
            }
            set {
                if ((this.onoff_scanField.Equals(value) != true)) {
                    this.onoff_scanField = value;
                    this.RaisePropertyChanged("onoff_scan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string scan_time {
            get {
                return this.scan_timeField;
            }
            set {
                if ((object.ReferenceEquals(this.scan_timeField, value) != true)) {
                    this.scan_timeField = value;
                    this.RaisePropertyChanged("scan_time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tag_name {
            get {
                return this.tag_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.tag_nameField, value) != true)) {
                    this.tag_nameField = value;
                    this.RaisePropertyChanged("tag_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string units {
            get {
                return this.unitsField;
            }
            set {
                if ((object.ReferenceEquals(this.unitsField, value) != true)) {
                    this.unitsField = value;
                    this.RaisePropertyChanged("units");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AO", Namespace="http://schemas.datacontract.org/2004/07/SCADA")]
    [System.SerializableAttribute()]
    public partial class AO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IO_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string high_limitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string inital_valueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string low_limitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tag_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string unitsField;
        
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
        public string IO_address {
            get {
                return this.IO_addressField;
            }
            set {
                if ((object.ReferenceEquals(this.IO_addressField, value) != true)) {
                    this.IO_addressField = value;
                    this.RaisePropertyChanged("IO_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string high_limit {
            get {
                return this.high_limitField;
            }
            set {
                if ((object.ReferenceEquals(this.high_limitField, value) != true)) {
                    this.high_limitField = value;
                    this.RaisePropertyChanged("high_limit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string inital_value {
            get {
                return this.inital_valueField;
            }
            set {
                if ((object.ReferenceEquals(this.inital_valueField, value) != true)) {
                    this.inital_valueField = value;
                    this.RaisePropertyChanged("inital_value");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string low_limit {
            get {
                return this.low_limitField;
            }
            set {
                if ((object.ReferenceEquals(this.low_limitField, value) != true)) {
                    this.low_limitField = value;
                    this.RaisePropertyChanged("low_limit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tag_name {
            get {
                return this.tag_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.tag_nameField, value) != true)) {
                    this.tag_nameField = value;
                    this.RaisePropertyChanged("tag_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string units {
            get {
                return this.unitsField;
            }
            set {
                if ((object.ReferenceEquals(this.unitsField, value) != true)) {
                    this.unitsField = value;
                    this.RaisePropertyChanged("units");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DI", Namespace="http://schemas.datacontract.org/2004/07/SCADA")]
    [System.SerializableAttribute()]
    public partial class DI : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IO_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string driverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool onoff_scanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string scan_timeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tag_nameField;
        
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
        public string IO_address {
            get {
                return this.IO_addressField;
            }
            set {
                if ((object.ReferenceEquals(this.IO_addressField, value) != true)) {
                    this.IO_addressField = value;
                    this.RaisePropertyChanged("IO_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string driver {
            get {
                return this.driverField;
            }
            set {
                if ((object.ReferenceEquals(this.driverField, value) != true)) {
                    this.driverField = value;
                    this.RaisePropertyChanged("driver");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool onoff_scan {
            get {
                return this.onoff_scanField;
            }
            set {
                if ((this.onoff_scanField.Equals(value) != true)) {
                    this.onoff_scanField = value;
                    this.RaisePropertyChanged("onoff_scan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string scan_time {
            get {
                return this.scan_timeField;
            }
            set {
                if ((object.ReferenceEquals(this.scan_timeField, value) != true)) {
                    this.scan_timeField = value;
                    this.RaisePropertyChanged("scan_time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tag_name {
            get {
                return this.tag_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.tag_nameField, value) != true)) {
                    this.tag_nameField = value;
                    this.RaisePropertyChanged("tag_name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DO", Namespace="http://schemas.datacontract.org/2004/07/SCADA")]
    [System.SerializableAttribute()]
    public partial class DO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IO_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string inital_valueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tag_nameField;
        
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
        public string IO_address {
            get {
                return this.IO_addressField;
            }
            set {
                if ((object.ReferenceEquals(this.IO_addressField, value) != true)) {
                    this.IO_addressField = value;
                    this.RaisePropertyChanged("IO_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string inital_value {
            get {
                return this.inital_valueField;
            }
            set {
                if ((object.ReferenceEquals(this.inital_valueField, value) != true)) {
                    this.inital_valueField = value;
                    this.RaisePropertyChanged("inital_value");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tag_name {
            get {
                return this.tag_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.tag_nameField, value) != true)) {
                    this.tag_nameField = value;
                    this.RaisePropertyChanged("tag_name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IUserProcessing")]
    public interface IUserProcessing {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/DoWork", ReplyAction="http://tempuri.org/IUserProcessing/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/DoWork", ReplyAction="http://tempuri.org/IUserProcessing/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/ukljucivanjeIsklucivanjeScan", ReplyAction="http://tempuri.org/IUserProcessing/ukljucivanjeIsklucivanjeScanResponse")]
        string ukljucivanjeIsklucivanjeScan(string tag_name, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/ukljucivanjeIsklucivanjeScan", ReplyAction="http://tempuri.org/IUserProcessing/ukljucivanjeIsklucivanjeScanResponse")]
        System.Threading.Tasks.Task<string> ukljucivanjeIsklucivanjeScanAsync(string tag_name, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/prikazVrednostiIzlaznihTagova", ReplyAction="http://tempuri.org/IUserProcessing/prikazVrednostiIzlaznihTagovaResponse")]
        string prikazVrednostiIzlaznihTagova(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/prikazVrednostiIzlaznihTagova", ReplyAction="http://tempuri.org/IUserProcessing/prikazVrednostiIzlaznihTagovaResponse")]
        System.Threading.Tasks.Task<string> prikazVrednostiIzlaznihTagovaAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/pravljenjeTaga", ReplyAction="http://tempuri.org/IUserProcessing/pravljenjeTagaResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DatabaseManager.ServiceReference.AI))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DatabaseManager.ServiceReference.AO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DatabaseManager.ServiceReference.DI))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DatabaseManager.ServiceReference.DO))]
        bool pravljenjeTaga(object temp, int brojTag, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/pravljenjeTaga", ReplyAction="http://tempuri.org/IUserProcessing/pravljenjeTagaResponse")]
        System.Threading.Tasks.Task<bool> pravljenjeTagaAsync(object temp, int brojTag, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/brisanjeTaga", ReplyAction="http://tempuri.org/IUserProcessing/brisanjeTagaResponse")]
        bool brisanjeTaga(string id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/brisanjeTaga", ReplyAction="http://tempuri.org/IUserProcessing/brisanjeTagaResponse")]
        System.Threading.Tasks.Task<bool> brisanjeTagaAsync(string id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/Registration", ReplyAction="http://tempuri.org/IUserProcessing/RegistrationResponse")]
        bool Registration(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/Registration", ReplyAction="http://tempuri.org/IUserProcessing/RegistrationResponse")]
        System.Threading.Tasks.Task<bool> RegistrationAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/Login", ReplyAction="http://tempuri.org/IUserProcessing/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/Login", ReplyAction="http://tempuri.org/IUserProcessing/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/Logout", ReplyAction="http://tempuri.org/IUserProcessing/LogoutResponse")]
        bool Logout(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/Logout", ReplyAction="http://tempuri.org/IUserProcessing/LogoutResponse")]
        System.Threading.Tasks.Task<bool> LogoutAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/prenosTipa", ReplyAction="http://tempuri.org/IUserProcessing/prenosTipaResponse")]
        void prenosTipa(DatabaseManager.ServiceReference.AI aI, DatabaseManager.ServiceReference.AO aO, DatabaseManager.ServiceReference.DI dI, DatabaseManager.ServiceReference.DO dO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProcessing/prenosTipa", ReplyAction="http://tempuri.org/IUserProcessing/prenosTipaResponse")]
        System.Threading.Tasks.Task prenosTipaAsync(DatabaseManager.ServiceReference.AI aI, DatabaseManager.ServiceReference.AO aO, DatabaseManager.ServiceReference.DI dI, DatabaseManager.ServiceReference.DO dO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserProcessingChannel : DatabaseManager.ServiceReference.IUserProcessing, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserProcessingClient : System.ServiceModel.ClientBase<DatabaseManager.ServiceReference.IUserProcessing>, DatabaseManager.ServiceReference.IUserProcessing {
        
        public UserProcessingClient() {
        }
        
        public UserProcessingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserProcessingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserProcessingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserProcessingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string ukljucivanjeIsklucivanjeScan(string tag_name, string token) {
            return base.Channel.ukljucivanjeIsklucivanjeScan(tag_name, token);
        }
        
        public System.Threading.Tasks.Task<string> ukljucivanjeIsklucivanjeScanAsync(string tag_name, string token) {
            return base.Channel.ukljucivanjeIsklucivanjeScanAsync(tag_name, token);
        }
        
        public string prikazVrednostiIzlaznihTagova(string token) {
            return base.Channel.prikazVrednostiIzlaznihTagova(token);
        }
        
        public System.Threading.Tasks.Task<string> prikazVrednostiIzlaznihTagovaAsync(string token) {
            return base.Channel.prikazVrednostiIzlaznihTagovaAsync(token);
        }
        
        public bool pravljenjeTaga(object temp, int brojTag, string token) {
            return base.Channel.pravljenjeTaga(temp, brojTag, token);
        }
        
        public System.Threading.Tasks.Task<bool> pravljenjeTagaAsync(object temp, int brojTag, string token) {
            return base.Channel.pravljenjeTagaAsync(temp, brojTag, token);
        }
        
        public bool brisanjeTaga(string id, string token) {
            return base.Channel.brisanjeTaga(id, token);
        }
        
        public System.Threading.Tasks.Task<bool> brisanjeTagaAsync(string id, string token) {
            return base.Channel.brisanjeTagaAsync(id, token);
        }
        
        public bool Registration(string username, string password) {
            return base.Channel.Registration(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegistrationAsync(string username, string password) {
            return base.Channel.RegistrationAsync(username, password);
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public bool Logout(string token) {
            return base.Channel.Logout(token);
        }
        
        public System.Threading.Tasks.Task<bool> LogoutAsync(string token) {
            return base.Channel.LogoutAsync(token);
        }
        
        public void prenosTipa(DatabaseManager.ServiceReference.AI aI, DatabaseManager.ServiceReference.AO aO, DatabaseManager.ServiceReference.DI dI, DatabaseManager.ServiceReference.DO dO) {
            base.Channel.prenosTipa(aI, aO, dI, dO);
        }
        
        public System.Threading.Tasks.Task prenosTipaAsync(DatabaseManager.ServiceReference.AI aI, DatabaseManager.ServiceReference.AO aO, DatabaseManager.ServiceReference.DI dI, DatabaseManager.ServiceReference.DO dO) {
            return base.Channel.prenosTipaAsync(aI, aO, dI, dO);
        }
    }
}
