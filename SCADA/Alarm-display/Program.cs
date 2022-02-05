using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Alarm_display
{
    class Program
    {
        public class AlarmDisplayCallBack : ServiceReference.IAlarmDisplayCallback
        {
            public void OnNotificationSent(string message)
            {
                Console.WriteLine(message);
            }
        }
        static void Main(string[] args)
        {
            InstanceContext ic = new InstanceContext(new AlarmDisplayCallBack());
            ServiceReference.AlarmDisplayClient proxy = new ServiceReference.AlarmDisplayClient(ic);
            proxy.AlarmDisplayInitialization();
            Console.ReadKey();
        }
    }
}
