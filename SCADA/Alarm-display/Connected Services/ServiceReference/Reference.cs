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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IDatabaseManagerAlarm")]
    public interface IDatabaseManagerAlarm {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManagerAlarm/SendNotification", ReplyAction="http://tempuri.org/IDatabaseManagerAlarm/SendNotificationResponse")]
        void SendNotification(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManagerAlarm/SendNotification", ReplyAction="http://tempuri.org/IDatabaseManagerAlarm/SendNotificationResponse")]
        System.Threading.Tasks.Task SendNotificationAsync(string message);
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
