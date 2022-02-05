using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.PublisherClient proxy =new ServiceReference1.PublisherClient();
            while (true)
            {
                proxy.SendNotification("New message");
                Console.WriteLine("Izvrseno");
                Thread.Sleep(3000);
            }

        }

    }
}
