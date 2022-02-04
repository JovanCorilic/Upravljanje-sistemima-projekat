using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Trending
{
    class Program
    {
        public class ServiceCallBack:ServiceReference.INotificationServiceCallBack
        static void Main(string[] args)
        {
            InstanceContext ic = new InstanceContext(new ServiceCallBack());
            ServiceReference.TagProcessingClient proxy = new ServiceReference.TagProcessingClient(ic);
            proxy.TagProccesingInitalization();
            Console.ReadKey();
        }
    }
}
