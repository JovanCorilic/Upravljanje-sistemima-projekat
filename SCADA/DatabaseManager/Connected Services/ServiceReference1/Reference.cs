﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseManager.ServiceReference1 {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDatabseManager")]
    public interface IDatabseManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabseManager/SendNotification", ReplyAction="http://tempuri.org/IDatabseManager/SendNotificationResponse")]
        void SendNotification(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabseManager/SendNotification", ReplyAction="http://tempuri.org/IDatabseManager/SendNotificationResponse")]
        System.Threading.Tasks.Task SendNotificationAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabseManager/davanjeVrednosti", ReplyAction="http://tempuri.org/IDatabseManager/davanjeVrednostiResponse")]
        string davanjeVrednosti(string IO, string tag_name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabseManager/davanjeVrednosti", ReplyAction="http://tempuri.org/IDatabseManager/davanjeVrednostiResponse")]
        System.Threading.Tasks.Task<string> davanjeVrednostiAsync(string IO, string tag_name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDatabseManagerChannel : DatabaseManager.ServiceReference1.IDatabseManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DatabseManagerClient : System.ServiceModel.ClientBase<DatabaseManager.ServiceReference1.IDatabseManager>, DatabaseManager.ServiceReference1.IDatabseManager {
        
        public DatabseManagerClient() {
        }
        
        public DatabseManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DatabseManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabseManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabseManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendNotification(string message) {
            base.Channel.SendNotification(message);
        }
        
        public System.Threading.Tasks.Task SendNotificationAsync(string message) {
            return base.Channel.SendNotificationAsync(message);
        }
        
        public string davanjeVrednosti(string IO, string tag_name) {
            return base.Channel.davanjeVrednosti(IO, tag_name);
        }
        
        public System.Threading.Tasks.Task<string> davanjeVrednostiAsync(string IO, string tag_name) {
            return base.Channel.davanjeVrednostiAsync(IO, tag_name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITagProcessing", CallbackContract=typeof(DatabaseManager.ServiceReference1.ITagProcessingCallback))]
    public interface ITagProcessing {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagProcessing/DoWork", ReplyAction="http://tempuri.org/ITagProcessing/DoWorkResponse")]
        void DoWork(DatabaseManager.ServiceReference1.AI aI, DatabaseManager.ServiceReference1.DI dI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagProcessing/DoWork", ReplyAction="http://tempuri.org/ITagProcessing/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync(DatabaseManager.ServiceReference1.AI aI, DatabaseManager.ServiceReference1.DI dI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagProcessing/TagProccesingInitalization", ReplyAction="http://tempuri.org/ITagProcessing/TagProccesingInitalizationResponse")]
        void TagProccesingInitalization();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITagProcessing/TagProccesingInitalization", ReplyAction="http://tempuri.org/ITagProcessing/TagProccesingInitalizationResponse")]
        System.Threading.Tasks.Task TagProccesingInitalizationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITagProcessingCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITagProcessing/OnNotificationSent")]
        void OnNotificationSent(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITagProcessingChannel : DatabaseManager.ServiceReference1.ITagProcessing, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TagProcessingClient : System.ServiceModel.DuplexClientBase<DatabaseManager.ServiceReference1.ITagProcessing>, DatabaseManager.ServiceReference1.ITagProcessing {
        
        public TagProcessingClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public TagProcessingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public TagProcessingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TagProcessingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TagProcessingClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void DoWork(DatabaseManager.ServiceReference1.AI aI, DatabaseManager.ServiceReference1.DI dI) {
            base.Channel.DoWork(aI, dI);
        }
        
        public System.Threading.Tasks.Task DoWorkAsync(DatabaseManager.ServiceReference1.AI aI, DatabaseManager.ServiceReference1.DI dI) {
            return base.Channel.DoWorkAsync(aI, dI);
        }
        
        public void TagProccesingInitalization() {
            base.Channel.TagProccesingInitalization();
        }
        
        public System.Threading.Tasks.Task TagProccesingInitalizationAsync() {
            return base.Channel.TagProccesingInitalizationAsync();
        }
    }
}
