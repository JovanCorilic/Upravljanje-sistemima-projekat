﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alarm_display.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alarm", Namespace="http://schemas.datacontract.org/2004/07/SCADA")]
    [System.SerializableAttribute()]
    public partial class Alarm : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string granicna_vrednostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ime_velicineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prioritetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipField;
        
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
        public string granicna_vrednost {
            get {
                return this.granicna_vrednostField;
            }
            set {
                if ((object.ReferenceEquals(this.granicna_vrednostField, value) != true)) {
                    this.granicna_vrednostField = value;
                    this.RaisePropertyChanged("granicna_vrednost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ime_velicine {
            get {
                return this.ime_velicineField;
            }
            set {
                if ((object.ReferenceEquals(this.ime_velicineField, value) != true)) {
                    this.ime_velicineField = value;
                    this.RaisePropertyChanged("ime_velicine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prioritet {
            get {
                return this.prioritetField;
            }
            set {
                if ((object.ReferenceEquals(this.prioritetField, value) != true)) {
                    this.prioritetField = value;
                    this.RaisePropertyChanged("prioritet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tip {
            get {
                return this.tipField;
            }
            set {
                if ((object.ReferenceEquals(this.tipField, value) != true)) {
                    this.tipField = value;
                    this.RaisePropertyChanged("tip");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TagVrednost", Namespace="http://schemas.datacontract.org/2004/07/SCADA")]
    [System.SerializableAttribute()]
    public partial class TagVrednost : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tag_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double vrednostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime vreme_kreacijeField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        public double vrednost {
            get {
                return this.vrednostField;
            }
            set {
                if ((this.vrednostField.Equals(value) != true)) {
                    this.vrednostField = value;
                    this.RaisePropertyChanged("vrednost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime vreme_kreacije {
            get {
                return this.vreme_kreacijeField;
            }
            set {
                if ((this.vreme_kreacijeField.Equals(value) != true)) {
                    this.vreme_kreacijeField = value;
                    this.RaisePropertyChanged("vreme_kreacije");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AlarmInformacija", Namespace="http://schemas.datacontract.org/2004/07/SCADA")]
    [System.SerializableAttribute()]
    public partial class AlarmInformacija : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ime_velicineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime vreme_aktivacijeField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ime_velicine {
            get {
                return this.ime_velicineField;
            }
            set {
                if ((object.ReferenceEquals(this.ime_velicineField, value) != true)) {
                    this.ime_velicineField = value;
                    this.RaisePropertyChanged("ime_velicine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tip {
            get {
                return this.tipField;
            }
            set {
                if ((object.ReferenceEquals(this.tipField, value) != true)) {
                    this.tipField = value;
                    this.RaisePropertyChanged("tip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime vreme_aktivacije {
            get {
                return this.vreme_aktivacijeField;
            }
            set {
                if ((this.vreme_aktivacijeField.Equals(value) != true)) {
                    this.vreme_aktivacijeField = value;
                    this.RaisePropertyChanged("vreme_aktivacije");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IDatabaseManagerAlarm")]
    public interface IDatabaseManagerAlarm {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManagerAlarm/SendNotification", ReplyAction="http://tempuri.org/IDatabaseManagerAlarm/SendNotificationResponse")]
        void SendNotification(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManagerAlarm/SendNotification", ReplyAction="http://tempuri.org/IDatabaseManagerAlarm/SendNotificationResponse")]
        System.Threading.Tasks.Task SendNotificationAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManagerAlarm/pravljenjeAlarmInformacije", ReplyAction="http://tempuri.org/IDatabaseManagerAlarm/pravljenjeAlarmInformacijeResponse")]
        Alarm_display.ServiceReference.AlarmInformacija pravljenjeAlarmInformacije(Alarm_display.ServiceReference.Alarm alarm, Alarm_display.ServiceReference.TagVrednost tagVrednost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManagerAlarm/pravljenjeAlarmInformacije", ReplyAction="http://tempuri.org/IDatabaseManagerAlarm/pravljenjeAlarmInformacijeResponse")]
        System.Threading.Tasks.Task<Alarm_display.ServiceReference.AlarmInformacija> pravljenjeAlarmInformacijeAsync(Alarm_display.ServiceReference.Alarm alarm, Alarm_display.ServiceReference.TagVrednost tagVrednost);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDatabaseManagerAlarmChannel : Alarm_display.ServiceReference.IDatabaseManagerAlarm, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DatabaseManagerAlarmClient : System.ServiceModel.ClientBase<Alarm_display.ServiceReference.IDatabaseManagerAlarm>, Alarm_display.ServiceReference.IDatabaseManagerAlarm {
        
        public DatabaseManagerAlarmClient() {
        }
        
        public DatabaseManagerAlarmClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DatabaseManagerAlarmClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseManagerAlarmClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseManagerAlarmClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendNotification(string message) {
            base.Channel.SendNotification(message);
        }
        
        public System.Threading.Tasks.Task SendNotificationAsync(string message) {
            return base.Channel.SendNotificationAsync(message);
        }
        
        public Alarm_display.ServiceReference.AlarmInformacija pravljenjeAlarmInformacije(Alarm_display.ServiceReference.Alarm alarm, Alarm_display.ServiceReference.TagVrednost tagVrednost) {
            return base.Channel.pravljenjeAlarmInformacije(alarm, tagVrednost);
        }
        
        public System.Threading.Tasks.Task<Alarm_display.ServiceReference.AlarmInformacija> pravljenjeAlarmInformacijeAsync(Alarm_display.ServiceReference.Alarm alarm, Alarm_display.ServiceReference.TagVrednost tagVrednost) {
            return base.Channel.pravljenjeAlarmInformacijeAsync(alarm, tagVrednost);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IAlarmDisplay", CallbackContract=typeof(Alarm_display.ServiceReference.IAlarmDisplayCallback))]
    public interface IAlarmDisplay {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/DoWork", ReplyAction="http://tempuri.org/IAlarmDisplay/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/DoWork", ReplyAction="http://tempuri.org/IAlarmDisplay/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/AlarmDisplayInitialization", ReplyAction="http://tempuri.org/IAlarmDisplay/AlarmDisplayInitializationResponse")]
        void AlarmDisplayInitialization();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/AlarmDisplayInitialization", ReplyAction="http://tempuri.org/IAlarmDisplay/AlarmDisplayInitializationResponse")]
        System.Threading.Tasks.Task AlarmDisplayInitializationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlarmDisplayCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAlarmDisplay/OnNotificationSent")]
        void OnNotificationSent(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlarmDisplayChannel : Alarm_display.ServiceReference.IAlarmDisplay, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlarmDisplayClient : System.ServiceModel.DuplexClientBase<Alarm_display.ServiceReference.IAlarmDisplay>, Alarm_display.ServiceReference.IAlarmDisplay {
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public void AlarmDisplayInitialization() {
            base.Channel.AlarmDisplayInitialization();
        }
        
        public System.Threading.Tasks.Task AlarmDisplayInitializationAsync() {
            return base.Channel.AlarmDisplayInitializationAsync();
        }
    }
}
