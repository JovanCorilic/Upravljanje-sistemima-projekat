using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestiranjeNotifikacije
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INotificationService" in both code and config file together.
    [ServiceContract]
    public interface INotificationService
    {
        [OperationContract]
        void DoWork();
    }
    [ServiceContract]
    public interface IPublisher
    {
        [OperationContract]
        void SendNotification(string message);
    }
    public interface INotificationServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnNotificationSent(string message);
    }
    [ServiceContract(CallbackContract = typeof(INotificationServiceCallBack))]
    public interface ISubscriber
    {
        [OperationContract]
        void SubscriberInitialization();
        //S obzirom na to da Publisher i Subscriber imaju odvojene servisne ugovore, potrebno je 
        //definisati metodu unutar koje će biti otvoren Callback kanal ka Subscriber klijentu 
    }
}
