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
            ServiceReference1.DatabseManagerClient proxyClient = new ServiceReference1.DatabseManagerClient();
            
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
                    Console.WriteLine("Unesite opciju ( 0 za izlaz)\n1.Logout\n2.Pravljenje taga\n3.Brisanje taga\n4.Prikaz vrednosti izlaznih tagova\n" +
                        "5.Isklucivanje scan kod ulaznog taga\n6.Promena vrednosti izlaznog taga");
                    int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    if (broj1 == 1)
                    {
                        proxy.Logout(token);
                        ulogovan = false;
                        proxy.sacuvajXML().Save("scadaConfig.xml");
                    }
                    else if (broj1 == 2)
                    {
                        PravljenjeTagova(proxy, token, proxyClient);
                    }
                    else if (broj1 == 3)
                    {
                        Console.WriteLine("Unesite naziv taga:");
                        string temp = Console.ReadLine();
                        if (proxy.brisanjeTaga(temp, token))
                        {
                            Console.WriteLine("Uspesno obrisan tag!");
                            proxy.sacuvajXML().Save("scadaConfig.xml");
                        }
                        else
                            Console.WriteLine("Neuspesno obrisan tag");
                    }
                    else if(broj1 == 4)
                    {
                        Console.WriteLine(proxy.prikazVrednostiIzlaznihTagova(token));
                    }
                    else if(broj1 == 5)
                    {
                        Console.WriteLine("Unesite naziv taga:");
                        string naziv = Console.ReadLine();
                        Console.WriteLine(proxy.ukljucivanjeIsklucivanjeScan(naziv,token));
                        string IO = proxy.dajIOAdresu(naziv, token);
                        if (!String.Equals(IO,""))
                        {
                            string vrednost = proxyClient.davanjeVrednosti(IO, naziv);
                            proxyClient.SendNotification("Naziv taga " + naziv + " vrednost: " + vrednost);
                        }

                        proxy.sacuvajXML().Save("scadaConfig.xml");
                    }
                    else if (broj1 == 6)
                    {
                        Console.WriteLine("Unesite naziv taga:");
                        string naziv = Console.ReadLine();
                        Console.WriteLine(proxy.upisivanjeVrednostiIzlaznogTaga(naziv, token));
                    }
                }
            }
        }

        static void PravljenjeTagova(ServiceReference.UserProcessingClient proxy,string token, ServiceReference1.DatabseManagerClient proxyClent)
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
                    object temp = ai;
                    if (proxy.pravljenjeTaga(ai, null, null,null, broj1, token))
                    {
                        Console.WriteLine("Uspesno napravljen AI tag.");
                        string vrednost = proxyClent.davanjeVrednosti(ai.IO_address,ai.tag_name);
                        if(ai.onoff_scan)
                            proxyClent.SendNotification("Analog input naziv "+ai.tag_name+" vrednost: "+vrednost);
                    }
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
                    if(proxy.pravljenjeTaga(null,ao,null,null, broj1, token))
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
                    if (proxy.pravljenjeTaga(null,null,di,null, broj1, token))
                    {
                        string vrednost = proxyClent.davanjeVrednosti(di.IO_address,di.tag_name);
                        if(di.onoff_scan)
                            proxyClent.SendNotification("Digital input naziv " + di.tag_name + " vrednost: " + vrednost);
                        Console.WriteLine("Uspesno napravljen DI tag.");
                    }
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
                    if (proxy.pravljenjeTaga(null,null,null,dO, broj1, token))
                        Console.WriteLine("Uspesno napravljen DO tag.");
                    else
                        Console.WriteLine("Operacija ne moze da se izvrsi!");
                }
                proxy.sacuvajXML().Save("scadaConfig.xml");
            }
        }
    }
}
