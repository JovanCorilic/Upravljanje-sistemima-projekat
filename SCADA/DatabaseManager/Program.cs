using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DatabaseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string token = "";
            ServiceReference.UserProcessingClient proxy = new ServiceReference.UserProcessingClient();
            
            while (true)
            {
                Console.WriteLine("Unesite opciju ( 0 za izlaz)\n1.Registracija\n2.Login\n3.Logout");
                int broj = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (broj == 0)
                    break;

                else if ( broj == 1)
                {
                    Console.WriteLine("Username:");
                    string username=Console.ReadLine();
                    Console.WriteLine("Password:");
                    string password = Console.ReadLine();
                    if (proxy.Registration(username, password))
                        Console.WriteLine("Uspesno registrovan!");
                    else
                        Console.WriteLine("Neuspesno!");
                }
                else if (broj == 2)
                {
                    Console.WriteLine("Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Password:");
                    string password = Console.ReadLine();
                    token = proxy.Login(username, password);
                    if (String.Equals(token, "Login failed"))
                        Console.WriteLine(token);
                }
                else if (broj == 3)
                {
                    proxy.Logout(token);
                }
                else if(broj == 4)
                {
                    PravljenjeTagova(proxy);
                }
            }
        }

        static void PravljenjeTagova(ServiceReference.UserProcessingClient proxy)
        {
            while (true)
            {
                Console.WriteLine("Unesite opciju ( 0 za izlaz)\n1.AI tag\n2.AO tag\n3.DI tag\n4.DO tag");
                int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (broj1 == 0)
                {
                    break;
                }
                else if (broj1 == 1)
                {
                    ServiceReference.AI aI = new ServiceReference.AI();
                    

                }
            }
        }
    }
}
