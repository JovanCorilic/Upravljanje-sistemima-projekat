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
            bool ulogovan = false;
            while (true)
            {
                Console.WriteLine("Unesite opciju ( 0 za izlaz)\n1.Registracija\n2.Login");
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
                    else
                        ulogovan = true;
                }
                while (ulogovan) {
                    Console.WriteLine("Unesite opciju ( 0 za izlaz)\n1.Logout\n2.Pravljenje taga\n3.Brisanje taga\n4.Prikaz vrednosti izlaznih tagova");
                    int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    if (broj1 == 1)
                    {
                        proxy.Logout(token);
                        ulogovan = false;
                    }
                    else if (broj1 == 2)
                    {
                        PravljenjeTagova(proxy, token);
                    }
                    else if (broj1 == 3)
                    {
                        Console.WriteLine("Unesite naziv taga:");
                        string temp = Console.ReadLine();
                        if (proxy.brisanjeTaga(temp, token))
                            Console.WriteLine("Uspesno obrisan tag!");
                        else
                            Console.WriteLine("Neuspesno obrisan tag");
                    }
                    else if(broj1 == 4)
                    {
                        Console.WriteLine(proxy.prikazVrednostiIzlaznihTagova(token));
                    }
                }
            }
        }

        static void PravljenjeTagova(ServiceReference.UserProcessingClient proxy,string token)
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
                    ServiceReference.AI ai = new ServiceReference.AI();
                    Console.WriteLine("Unesite tag name:");
                    ai.tag_name=Console.ReadLine();
                    Console.WriteLine("Unesite description:");
                    ai.description = Console.ReadLine();
                    Console.WriteLine("Unesite driver:");
                    ai.driver = Console.ReadLine();
                    Console.WriteLine("Unesite I/O addresu:");
                    ai.IO_address = Console.ReadLine();
                    Console.WriteLine("Unesite scan time:");
                    ai.scan_time = Console.ReadLine();
                    ai.alarms = "";
                    Console.WriteLine("On/Off scan:");
                    if (String.Equals(Console.ReadLine(), "on"))
                    {
                        ai.onoff_scan = true;
                    }else if (String.Equals(Console.ReadLine(), "off"))
                    {
                        ai.onoff_scan = false;
                    }
                    Console.WriteLine("Unesite low limit:");
                    ai.low_limit = Console.ReadLine();
                    Console.WriteLine("Unesite high limit:");
                    ai.high_limit = Console.ReadLine();
                    Console.WriteLine("Unesite units:");
                    ai.units = Console.ReadLine();
                    if (proxy.pravljenjeTaga(ai, broj1, token))
                        Console.WriteLine("Uspesno napravljen AI tag.");
                    else
                        Console.WriteLine("Operacija ne moze da se izvrsi!");
                }
                else if (broj1 == 2)
                {
                    ServiceReference.AO ao = new ServiceReference.AO();
                    Console.WriteLine("Unesite tag name:");
                    ao.tag_name = Console.ReadLine();
                    Console.WriteLine("Unesite description:");
                    ao.description = Console.ReadLine();
                    
                    Console.WriteLine("Unesite I/O addresu:");
                    ao.IO_address = Console.ReadLine();
                    ao.inital_value = "";
                    
                    Console.WriteLine("Unesite low limit:");
                    ao.low_limit = Console.ReadLine();
                    Console.WriteLine("Unesite high limit:");
                    ao.high_limit = Console.ReadLine();
                    Console.WriteLine("Unesite units:");
                    ao.units = Console.ReadLine();
                    if(proxy.pravljenjeTaga(ao, broj1, token))
                            Console.WriteLine("Uspesno napravljen AO tag.");
                    else
                        Console.WriteLine("Operacija ne moze da se izvrsi!");
                }
                else if (broj1 == 3)
                {
                    ServiceReference.DI di = new ServiceReference.DI();
                    Console.WriteLine("Unesite tag name:");
                    di.tag_name = Console.ReadLine();
                    Console.WriteLine("Unesite description:");
                    di.description = Console.ReadLine();
                    Console.WriteLine("Unesite driver:");
                    di.driver = Console.ReadLine();
                    Console.WriteLine("Unesite I/O addresu:");
                    di.IO_address = Console.ReadLine();
                    Console.WriteLine("Unesite scan time:");
                    di.scan_time = Console.ReadLine();
                    
                    Console.WriteLine("On/Off scan:");
                    if (String.Equals(Console.ReadLine(), "on"))
                    {
                        di.onoff_scan = true;
                    }
                    else if (String.Equals(Console.ReadLine(), "off"))
                    {
                        di.onoff_scan = false;
                    }
                    if (proxy.pravljenjeTaga(di, broj1, token))
                        Console.WriteLine("Uspesno napravljen DI tag.");
                    else
                        Console.WriteLine("Operacija ne moze da se izvrsi!");
                }
                else if (broj1 == 4)
                {
                    ServiceReference.DO dO = new ServiceReference.DO();
                    Console.WriteLine("Unesite tag name:");
                    dO.tag_name = Console.ReadLine();
                    Console.WriteLine("Unesite description:");
                    dO.description = Console.ReadLine();
                    
                    Console.WriteLine("Unesite I/O addresu:");
                    dO.IO_address = Console.ReadLine();
                    if (proxy.pravljenjeTaga(dO, broj1, token))
                        Console.WriteLine("Uspesno napravljen DO tag.");
                    else
                        Console.WriteLine("Operacija ne moze da se izvrsi!");
                }
            }
        }
    }
}
