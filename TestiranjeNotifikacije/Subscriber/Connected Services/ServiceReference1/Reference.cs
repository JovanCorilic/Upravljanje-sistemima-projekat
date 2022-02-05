﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Subscriber.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPublisher")]
    public interface IPublisher {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublisher/SendNotification", ReplyAction="http://tempuri.org/IPublisher/SendNotificationResponse")]
        void SendNotification(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublisher/SendNotification", ReplyAction="http://tempuri.org/IPublisher/SendNotificationResponse")]
        System.Threading.Tasks.Task SendNotificationAsync(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublisherChannel : Subscriber.ServiceReference1.IPublisher, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublisherClient : System.ServiceModel.ClientBase<Subscriber.ServiceReference1.IPublisher>, Subscriber.ServiceReference1.IPublisher {
        
        public PublisherClient() {
        }
        
        public PublisherClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PublisherClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISubscriber", CallbackContract=typeof(Subscriber.ServiceReference1.ISubscriberCallback))]
    public interface ISubscriber {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriber/SubscriberInitialization", ReplyAction="http://tempuri.org/ISubscriber/SubscriberInitializationResponse")]
        void SubscriberInitialization();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriber/SubscriberInitialization", ReplyAction="http://tempuri.org/ISubscriber/SubscriberInitializationResponse")]
        System.Threading.Tasks.Task SubscriberInitializationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubscriberCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISubscriber/OnNotificationSent")]
        void OnNotificationSent(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISubscriberChannel : Subscriber.ServiceReference1.ISubscriber, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubscriberClient : System.ServiceModel.DuplexClientBase<Subscriber.ServiceReference1.ISubscriber>, Subscriber.ServiceReference1.ISubscriber {
        
        public SubscriberClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public SubscriberClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public SubscriberClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SubscriberClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SubscriberClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SubscriberInitialization() {
            base.Channel.SubscriberInitialization();
        }
        
        public System.Threading.Tasks.Task SubscriberInitializationAsync() {
            return base.Channel.SubscriberInitializationAsync();
        }
    }
}
