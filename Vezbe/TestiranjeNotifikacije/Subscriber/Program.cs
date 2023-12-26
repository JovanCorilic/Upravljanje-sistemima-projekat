using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber
{
    public class SubscriberCallback : ServiceReference1.ISubscriberCallback
    {
        public void OnNotificationSent(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext ic = new InstanceContext(new SubscriberCallback());
            ServiceReference1.SubscriberClient proxy =
            new ServiceReference1.SubscriberClient(ic);
            proxy.SubscriberInitialization();
            Console.ReadKey();//Čekaju se poruke sa servisa do zatvaranja klijenta
        }

    }
}
