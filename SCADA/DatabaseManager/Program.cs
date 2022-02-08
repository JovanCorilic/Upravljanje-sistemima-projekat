﻿using System;
using System.Collections.Generic;
using System.IO;
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
            ServiceReference2.DatabaseManagerAlarmClient proxyAlarm = new ServiceReference2.DatabaseManagerAlarmClient();
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
                    Console.WriteLine("Unesite opciju\n1.Logout\n2.Pravljenje taga\n3.Brisanje taga\n4.Prikaz vrednosti izlaznih tagova\n" +
                        "5.Isklucivanje/Ukljucivanje scan kod ulaznog taga\n6.Promena vrednosti izlaznog taga\n7.Pravljenje alarma" +
                        "\n8.Brisanje alarma\n9.Pokreni skeniranje ulaznih alarma");
                    int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    if (broj1 == 1)
                    {
                        proxy.sacuvajXML(token).Save("scadaConfig.xml");
                        proxy.Logout(token);
                        ulogovan = false;
                        
                    }
                    else if (broj1 == 2)
                    {
                        PravljenjeTagova(proxy, token, proxyClient,proxyAlarm);
                    }
                    else if (broj1 == 3)
                    {
                        Console.WriteLine("Unesite naziv taga:");
                        string temp = Console.ReadLine();
                        if (proxy.brisanjeTaga(temp, token))
                        {
                            Console.WriteLine("Uspesno obrisan tag!");
                            proxy.sacuvajXML(token).Save("scadaConfig.xml");
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
                        string nesto = proxy.ukljucivanjeIsklucivanjeScan(naziv,token);
                        Console.WriteLine(nesto);
                        string IO = proxy.dajIOAdresu(naziv, token);
                        if (!String.Equals(IO,""))
                        {
                            var vrednost = proxyClient.davanjeVrednosti(IO, naziv);
                            if (String.Equals(nesto, "Skeniranje ukljuceno"))
                                proxyClient.SendNotification("Tag name " + vrednost.tag_name + ", vrednost " + vrednost.vrednost.ToString() + " ,vreme kreacije " + vrednost.vreme_kreacije.ToString());
                            ServiceReference2.Alarm temp1 = new ServiceReference2.Alarm();
                            
                            ServiceReference2.TagVrednost tagVrednost = new ServiceReference2.TagVrednost();
                            tagVrednost.Id = vrednost.Id;
                            tagVrednost.tag_name = vrednost.tag_name;
                            tagVrednost.vrednost = vrednost.vrednost;
                            tagVrednost.vreme_kreacije = vrednost.vreme_kreacije;
                            if (proxy.daLiJeAnalogni(vrednost.tag_name,token))
                            {
                                var lista = proxy.DajAlarmeOdredjenogTaga(vrednost.tag_name,token);
                                foreach(var temp in lista)
                                {
                                    temp1 = new ServiceReference2.Alarm();
                                    temp1.tip = temp.tip;
                                    temp1.prioritet = temp.prioritet;
                                    temp1.granicna_vrednost = temp.granicna_vrednost;
                                    temp1.ime_velicine = temp.ime_velicine;
                                    var alarmInformacija = proxyAlarm.pravljenjeAlarmInformacije(temp1, tagVrednost);
                                    using (StreamWriter sw = File.AppendText("alarmsLog.txt"))
                                    {
                                        sw.WriteLine("Tip " + alarmInformacija.tip + " ime velicine " + alarmInformacija.ime_velicine + " prioritet " + alarmInformacija.prioritet + " vreme aktivacije " + alarmInformacija.vreme_aktivacije.ToString());
                                    }
                                    for(int i = 0;i<int.Parse(temp.prioritet);i++)
                                        proxyAlarm.SendNotification("Tip " + alarmInformacija.tip + " ime velicine " + alarmInformacija.ime_velicine + " prioritet " + alarmInformacija.prioritet + " vreme aktivacije " + alarmInformacija.vreme_aktivacije.ToString());

                                }
                            }

                        }

                        proxy.sacuvajXML(token).Save("scadaConfig.xml");
                    }
                    else if (broj1 == 6)
                    {
                        Console.WriteLine("Unesite naziv taga:");
                        string naziv = Console.ReadLine();
                        Console.WriteLine(proxy.upisivanjeVrednostiIzlaznogTaga(naziv, token));
                    }
                    else if(broj1 == 7)
                    {
                        PravljenjeAlarma(proxy, token);
                    }
                    else if(broj1 == 8)
                    {
                        Console.WriteLine("Unesite naziv analognog ulaza:");
                        string naziv = Console.ReadLine();
                        var lista = proxy.DajAlarmeOdredjenogTaga(naziv, token);
                        int br = 0;
                        Console.WriteLine("Unesite broj koji zelite da obrisete:");
                        foreach(ServiceReference.Alarm alarm in lista)
                        {
                            br++;
                            Console.WriteLine(br.ToString() + " : " + "Tip " + alarm.tip + " , prioritet " + alarm.prioritet + " , granicna vrednost " + alarm.granicna_vrednost);
                        }
                        int temp = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                        proxy.brisanjeAlarma(temp, token);
                        proxy.sacuvajAlarme(token).Save("alarmConfig.xml");
                    }
                    else if (broj1 == 9)
                    {
                        var listaAI = proxy.dajSveAITagove(token);
                        foreach (var temp2 in listaAI)
                        {
                            var vrednost = proxyClient.davanjeVrednosti(temp2.IO_address, temp2.tag_name);
                            if (temp2.onoff_scan)
                                proxyClient.SendNotification("Tag name " + vrednost.tag_name + ", vrednost " + vrednost.vrednost.ToString() + " ,vreme kreacije " + vrednost.vreme_kreacije.ToString());
                            ServiceReference2.Alarm temp1 = new ServiceReference2.Alarm();

                            ServiceReference2.TagVrednost tagVrednost = new ServiceReference2.TagVrednost();
                            tagVrednost.Id = vrednost.Id;
                            tagVrednost.tag_name = vrednost.tag_name;
                            tagVrednost.vrednost = vrednost.vrednost;
                            tagVrednost.vreme_kreacije = vrednost.vreme_kreacije;
                            
                            var lista = proxy.DajAlarmeOdredjenogTaga(vrednost.tag_name, token);
                            foreach (var temp in lista)
                            {
                                temp1 = new ServiceReference2.Alarm();
                                temp1.tip = temp.tip;
                                temp1.prioritet = temp.prioritet;
                                temp1.granicna_vrednost = temp.granicna_vrednost;
                                temp1.ime_velicine = temp.ime_velicine;
                                var alarmInformacija = proxyAlarm.pravljenjeAlarmInformacije(temp1, tagVrednost);
                                using (StreamWriter sw = File.AppendText("alarmsLog.txt"))
                                {
                                    sw.WriteLine("Tip " + alarmInformacija.tip + " ime velicine " + alarmInformacija.ime_velicine + " prioritet " + alarmInformacija.prioritet + " vreme aktivacije " + alarmInformacija.vreme_aktivacije.ToString());
                                }
                                for (int i = 0; i < int.Parse(temp.prioritet); i++)
                                    proxyAlarm.SendNotification("Tip " + alarmInformacija.tip + " ime velicine " + alarmInformacija.ime_velicine + " prioritet " + alarmInformacija.prioritet + " vreme aktivacije " + alarmInformacija.vreme_aktivacije.ToString());

                            }
                            
                        }
                        var listaDI = proxy.dajSveDITagove(token);
                        foreach(var temp in listaDI)
                        {
                            var vrednost = proxyClient.davanjeVrednosti(temp.IO_address, temp.tag_name);
                            if (temp.onoff_scan)
                                proxyClient.SendNotification("Tag name " + vrednost.tag_name + ", vrednost " + vrednost.vrednost.ToString() + " ,vreme kreacije " + vrednost.vreme_kreacije.ToString());
                        }
                    }
                }
            }
        }
        static void PravljenjeAlarma(ServiceReference.UserProcessingClient proxy,string token)
        {
            ServiceReference.Alarm alarm = new ServiceReference.Alarm();
            Console.WriteLine("Unesite tip (high,low):");
            alarm.tip = Console.ReadLine();
            Console.WriteLine("Unesite prioritet (1-3):");
            alarm.prioritet = Console.ReadLine();
            Console.WriteLine("Unesite granicnu vrednost:");
            alarm.granicna_vrednost = Console.ReadLine();
            Console.WriteLine("Unesite ime ulaznog taga tj. ime velicine:");
            alarm.ime_velicine = Console.ReadLine();
            proxy.PravljenjeAlarma(alarm, token);
            proxy.sacuvajAlarme(token).Save("alarmConfig.xml");
        }

        static void PravljenjeTagova(ServiceReference.UserProcessingClient proxy,string token, ServiceReference1.DatabseManagerClient proxyClent, ServiceReference2.DatabaseManagerAlarmClient proxyAlarm)
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
                    Console.WriteLine("Unesite I/O addresu ( S , C , R ):");
                    ai.IO_address = Console.ReadLine();
                    Console.WriteLine("Unesite scan time:");
                    ai.scan_time = Console.ReadLine();
                    ai.alarms = "";
                    Console.WriteLine("On/Off scan (mora biti on ili off kao unos) :");
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
                        var vrednost = proxyClent.davanjeVrednosti(ai.IO_address,ai.tag_name);
                        if(ai.onoff_scan)
                            proxyClent.SendNotification("Analog input "+ "Tag name " + vrednost.tag_name + ", vrednost " + vrednost.vrednost.ToString() + " ,vreme kreacije " + vrednost.vreme_kreacije.ToString());
                        
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
                    
                    Console.WriteLine("Unesite I/O addresu ( S , C , R ):");
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
                    Console.WriteLine("Unesite I/O addresu ( S , C , R ):");
                    di.IO_address = Console.ReadLine();
                    Console.WriteLine("Unesite scan time:");
                    di.scan_time = Console.ReadLine();
                    
                    Console.WriteLine("On/Off scan (mora biti on ili off kao unos) :");
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
                        var vrednost = proxyClent.davanjeVrednosti(di.IO_address,di.tag_name);
                        if(di.onoff_scan)
                            proxyClent.SendNotification("Digital input "+ "Tag name " + vrednost.tag_name + ", vrednost " + vrednost.vrednost.ToString() + " ,vreme kreacije " + vrednost.vreme_kreacije.ToString());
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
                    
                    Console.WriteLine("Unesite I/O addresu ( S , C , R ):");
                    dO.IO_address = Console.ReadLine();
                    if (proxy.pravljenjeTaga(null,null,null,dO, broj1, token))
                        Console.WriteLine("Uspesno napravljen DO tag.");
                    else
                        Console.WriteLine("Operacija ne moze da se izvrsi!");
                }
                proxy.sacuvajXML(token).Save("scadaConfig.xml");
            }
        }
    }
}
