using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.Report_ManagerClient proxy = new ServiceReference.Report_ManagerClient();
            
            while (true)
            {
                Console.WriteLine("Unesite opciju( 0 za izlaz):\n1.Svi alarmi koji su se desili u određenom vremenskom periodu\n" +
                "2.Svi alarmi određenog prioriteta\n3.Sve vrednosti tagova koje su dospele na servis u određenom vremenskom periodu\n" +
                "4.Poslednja vrednost svih AI tagova\n5.Poslednja vrednost svih DI tagova\n" +
                "6.Sve vrednosti taga sa određenim identifikatorom");
                int broj = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (broj == 0)
                    break;
                else if (broj == 1)
                {
                    Console.WriteLine("Unesite pocetni datum (primer: 20.12.2021 11:00:00)");
                    string pocetni = Console.ReadLine();
                    CultureInfo culture = new CultureInfo("sr-RS");
                    DateTime temp1 = DateTime.Parse(pocetni, culture);

                    Console.WriteLine("Unesite kranji datum (primer: 20.12.2021 11:00:00)");
                    string krajni = Console.ReadLine();
                    DateTime temp2 = DateTime.Parse(krajni, culture);
                    var lista = proxy.sviAlarmiOdredjenVremPeriod(temp1, temp2);
                    foreach (var temp in lista)
                        Console.WriteLine("Tip " + temp.tip + " ime velicine " + temp.ime_velicine + " prioritet " + temp.prioritet + " vreme aktivacije " + temp.vreme_aktivacije.ToString());
                    while (true)
                    {
                        Console.WriteLine("Sortiranje podataka po:\n1.Prioritet\n2.Vreme\n0.Natrag");
                        int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        if (broj1 == 0)
                            break;
                        else if (broj1 == 1)
                        {
                            var listaSordt = lista.OrderBy(m => int.Parse(m.prioritet));
                            foreach (var temp in listaSordt)
                            {
                                Console.WriteLine("Tip " + temp.tip + " ime velicine " + temp.ime_velicine + " prioritet " + temp.prioritet + " vreme aktivacije " + temp.vreme_aktivacije.ToString());
                            }
                        }
                        else if (broj1 == 2)
                        {
                            var listaSort = lista.OrderBy(m => m.vreme_aktivacije);
                            foreach (var temp in listaSort)
                            {
                                Console.WriteLine("Tip " + temp.tip + " ime velicine " + temp.ime_velicine + " prioritet " + temp.prioritet + " vreme aktivacije " + temp.vreme_aktivacije.ToString());
                            }
                        }
                    }
                }
                else if (broj == 2)
                {
                    Console.WriteLine("Unesite prioritet alarma:");
                    string prioritet = Console.ReadLine();
                    var lista = proxy.sviAlarmiOdredjenogPrioriteta(prioritet);
                    foreach (var temp in lista)
                    {
                        Console.WriteLine("Tip " + temp.tip + " ime velicine " + temp.ime_velicine + " prioritet " + temp.prioritet + " vreme aktivacije " + temp.vreme_aktivacije.ToString());
                    }
                    while (true)
                    {
                        Console.WriteLine("Sortiranje podataka po:\n1.Vreme\n0.Natrag");
                        int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        if (broj1 == 0)
                            break;
                        else if (broj1 == 1)
                        {
                            var listaSort = lista.OrderBy(m => m.vreme_aktivacije);
                            foreach(var temp in listaSort)
                            {
                                Console.WriteLine("Tip " + temp.tip + " ime velicine " + temp.ime_velicine + " prioritet " + temp.prioritet + " vreme aktivacije " + temp.vreme_aktivacije.ToString());
                            }
                        }
                    }
                }
                else if (broj == 3)
                {
                    Console.WriteLine("Unesite pocetni datum (primer: 20.12.2021 11:00:00)");
                    string pocetni = Console.ReadLine();
                    CultureInfo culture = new CultureInfo("sr-RS");
                    DateTime temp1 = DateTime.Parse(pocetni, culture);

                    Console.WriteLine("Unesite kranji datum (primer: 20.12.2021 11:00:00)");
                    string krajni = Console.ReadLine();
                    DateTime temp2 = DateTime.Parse(krajni, culture);
                    var lista = proxy.sveVrednostiTagovaUOdredjenomVremenu(temp1, temp2);
                    foreach (var temp in lista)
                        Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                    while (true)
                    {
                        Console.WriteLine("Sortiranje podataka po:\n1.Vreme\n0.Natrag");
                        int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        if (broj1 == 0)
                            break;
                        else if (broj1 == 1)
                        {
                            var listaSordt = lista.OrderBy(m => m.vreme_kreacije);
                            foreach (var temp in listaSordt)
                            {
                                Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                            }
                        }
                        
                    }
                }
                else if(broj == 4)
                {
                    var lista = proxy.poslednjaVrednostAItaga();
                    foreach(var temp in lista)
                    {
                        Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                    }
                    while (true)
                    {
                        Console.WriteLine("Sortiranje podataka po:\n1.Vreme\n0.Natrag");
                        int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        if (broj1 == 0)
                            break;
                        else if (broj1 == 1)
                        {
                            var listaSordt = lista.OrderBy(m => m.vreme_kreacije);
                            foreach (var temp in listaSordt)
                            {
                                Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                            }
                        }

                    }
                }
                else if(broj == 5)
                {
                    var lista = proxy.poslednjaVrednostDItaga();
                    foreach (var temp in lista)
                    {
                        Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                    }
                    while (true)
                    {
                        Console.WriteLine("Sortiranje podataka po:\n1.Vreme\n0.Natrag");
                        int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        if (broj1 == 0)
                            break;
                        else if (broj1 == 1)
                        {
                            var listaSordt = lista.OrderBy(m => m.vreme_kreacije);
                            foreach (var temp in listaSordt)
                            {
                                Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                            }
                        }

                    }
                }
                else if(broj == 6)
                {
                    Console.WriteLine("Unesite naziv identifikatora taga:");
                    string naziv = Console.ReadLine();
                    var lista = proxy.sveVrednostiSaOdredjenimIdentifikatorom(naziv);
                    foreach (var temp in lista)
                    {
                        Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                    }
                    while (true)
                    {
                        Console.WriteLine("Sortiranje podataka po:\n1.Vrednost\n0.Natrag");
                        int broj1 = (int)Char.GetNumericValue(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        if (broj1 == 0)
                            break;
                        else if (broj1 == 1)
                        {
                            var listaSordt = lista.OrderBy(m => m.vrednost);
                            foreach (var temp in listaSordt)
                            {
                                Console.WriteLine("Tag name " + temp.tag_name + ", vrednost " + temp.vrednost.ToString() + " ,vreme kreacije " + temp.vreme_kreacije.ToString());
                            }
                        }

                    }
                }
            }
        }
    }
}
