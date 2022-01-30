using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "";
            ServiceReference.AuthenticationClient authProxy = new ServiceReference.AuthenticationClient();
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
                    if (authProxy.Registration(username, password))
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
                    token = authProxy.Login(username, password);
                    if (String.Equals(token, "Login failed"))
                        Console.WriteLine(token);
                }
                else if (broj == 3)
                {
                    authProxy.Logout(token);
                }
            }
        }
    }
}
