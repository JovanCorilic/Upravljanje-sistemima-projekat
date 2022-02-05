using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestiranjeNotifikacije
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NotificationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NotificationService.svc or NotificationService.svc.cs at the Solution Explorer and start debugging.
    public class NotificationService : INotificationService, IPublisher, ISubscriber
    {
        static INotificationServiceCallBack proxy = null;
        
        static event NotificationDelegate notificationReceived;

        delegate void NotificationDelegate(string message);
        static event NotificationDelegate notificationSent = null;
        public void SendNotification(string message)
        {
            notificationReceived?.Invoke(message);
        }
        public void SubscriberInitialization()
        {
            proxy = OperationContext.Current.GetCallbackChannel
           <INotificationServiceCallBack>();
            notificationReceived += proxy.OnNotificationSent;
            
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
