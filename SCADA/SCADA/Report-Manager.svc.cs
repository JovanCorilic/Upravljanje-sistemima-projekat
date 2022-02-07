using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Report_Manager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Report-Manager.svc or Report-Manager.svc.cs at the Solution Explorer and start debugging.
    public class Report_Manager : IReport_Manager
    {
        private static List<TagVrednost> tagVrednosts = new List<TagVrednost>();
        private static List<AlarmInformacija> alarmInformacijas = new List<AlarmInformacija>();
        private static Dictionary<string, User> authenticatedUsers = new Dictionary<string, User>();
        private static Dictionary<string, AI> aIs = new Dictionary<string, AI>();
        
        private static Dictionary<string, DI> dIs = new Dictionary<string, DI>();
        
        public void DoWork()
        {
        }

        public List<TagVrednost> sveVrednostiSaOdredjenimIdentifikatorom(string tag_name)
        {
            List<TagVrednost> lista = new List<TagVrednost>();
            ucitavanjeVrednostiTaga();
            foreach(var temp in tagVrednosts)
            {
                if (String.Equals(temp.tag_name, tag_name))
                {
                    lista.Add(temp);
                }
            }
            return lista;
        }

        public List<TagVrednost> poslednjaVrednostDItaga()
        {
            List<TagVrednost> lista = new List<TagVrednost>();
            ucitavanjeVrednostiTaga();
            ucitavanjeXML();
            foreach (var key in dIs.Keys)
            {
                List<TagVrednost> listaVrednosti = new List<TagVrednost>();
                foreach (var temp in tagVrednosts)
                {
                    if (String.Equals(temp.tag_name, key))
                    {
                        listaVrednosti.Add(temp);
                    }
                }
                var tagVrednost = listaVrednosti.OrderBy(m => m.vreme_kreacije > DateTime.Now
                                                                    ? m.vreme_kreacije - DateTime.Now
                                                                    : DateTime.Now - m.vreme_kreacije)
                                            .Take(1);
                lista.Add(tagVrednost.First());
            }
            return lista;
        }

        public List<TagVrednost> poslednjaVrednostAItaga()
        {
            List<TagVrednost> lista = new List<TagVrednost>();
            ucitavanjeVrednostiTaga();
            ucitavanjeXML();
            foreach(var key in aIs.Keys)
            {
                List<TagVrednost> listaVrednosti = new List<TagVrednost>();
                foreach(var temp in tagVrednosts)
                {
                    if (String.Equals(temp.tag_name, key))
                    {
                        listaVrednosti.Add(temp);
                    }
                }
                var tagVrednost = listaVrednosti.OrderBy(m => m.vreme_kreacije > DateTime.Now
                                                                    ? m.vreme_kreacije - DateTime.Now
                                                                    : DateTime.Now - m.vreme_kreacije)
                                            .Take(1);
                lista.Add(tagVrednost.First());
            }
            return lista;
        }

        private void ucitavanjeXML()
        {

            if (File.Exists("C:/Users/Kssbc/Documents/GitHub/Upravljanje-sistemima-projekat/SCADA/DatabaseManager/bin/Debug/scadaConfig.xml"))
            {
                aIs = new Dictionary<string, AI>();
               
                dIs = new Dictionary<string, DI>();
                
                XElement xmlData = XElement.Load("C:/Users/Kssbc/Documents/GitHub/Upravljanje-sistemima-projekat/SCADA/DatabaseManager/bin/Debug/scadaConfig.xml");
                XElement lista = (XElement)xmlData.FirstNode;
                XElement listaAI = (XElement)lista.FirstNode;
                while (listaAI != null)
                {
                    AI aI = new AI();
                    var attribute = listaAI.FirstAttribute;
                    aI.description = attribute.Value;
                    attribute = attribute.NextAttribute;
                    aI.driver = attribute.Value;
                    attribute = attribute.NextAttribute;
                    aI.IO_address = attribute.Value;
                    attribute = attribute.NextAttribute;
                    aI.scan_time = attribute.Value;
                    attribute = attribute.NextAttribute;
                    aI.alarms = attribute.Value;
                    attribute = attribute.NextAttribute;
                    aI.onoff_scan = bool.Parse(attribute.Value);
                    attribute = attribute.NextAttribute;
                    aI.low_limit = attribute.Value;
                    attribute = attribute.NextAttribute;
                    aI.high_limit = attribute.Value;
                    attribute = attribute.NextAttribute;
                    aI.units = attribute.Value;
                    aI.tag_name = listaAI.FirstNode.ToString();
                    aIs.Add(aI.tag_name, aI);
                    listaAI = (XElement)listaAI.NextNode;
                }

                lista = (XElement)lista.NextNode;
                
                lista = (XElement)lista.NextNode;
                XElement listaDI = (XElement)lista.FirstNode;
                while (listaDI != null)
                {
                    DI di = new DI();
                    var attribute = listaDI.FirstAttribute;
                    di.description = attribute.Value;
                    attribute = attribute.NextAttribute;
                    di.driver = attribute.Value;
                    attribute = attribute.NextAttribute;
                    di.IO_address = attribute.Value;
                    attribute = attribute.NextAttribute;
                    di.scan_time = attribute.Value;
                    attribute = attribute.NextAttribute;

                    di.onoff_scan = bool.Parse(attribute.Value);

                    di.tag_name = listaDI.FirstNode.ToString();
                    dIs.Add(di.tag_name, di);
                    listaDI = (XElement)listaDI.NextNode;
                }
                
                
            }
        }


        public List<TagVrednost> sveVrednostiTagovaUOdredjenomVremenu(DateTime pocetak, DateTime kraj)
        {
            List<TagVrednost> lista = new List<TagVrednost>();
            ucitavanjeVrednostiTaga();
            foreach(var temp in tagVrednosts)
            {
                if(pocetak<temp.vreme_kreacije && kraj > temp.vreme_kreacije)
                {
                    lista.Add(temp);
                }
            }
            return lista;
        }

        public List<AlarmInformacija> sviAlarmiOdredjenogPrioriteta(string prioritet)
        {
            List<AlarmInformacija> lista = new List<AlarmInformacija>();
            ucitavanjeAlarma();
            foreach(var temp in alarmInformacijas)
            {
                if (String.Equals(temp.prioritet, prioritet))
                {
                    lista.Add(temp);
                }
            }
            return lista;
        }

        public List<AlarmInformacija> sviAlarmiOdredjenVremPeriod(DateTime pocetak, DateTime kraj)
        {
            List<AlarmInformacija> lista = new List<AlarmInformacija>();
            ucitavanjeAlarma();
            foreach(var temp in alarmInformacijas)
            {
                if (pocetak < temp.vreme_aktivacije && kraj > temp.vreme_aktivacije)
                    lista.Add(temp);
            }
            return lista;
        }

        private void ucitavanjeVrednostiTaga()
        {
            tagVrednosts = new List<TagVrednost>();
            using (var db = new TagsContext())
            {
                foreach (var tag in db.tagVrednosts)
                    tagVrednosts.Add(tag);
            }
        }

        private void ucitavanjeAlarma()
        {
            alarmInformacijas = new List<AlarmInformacija>();
            using(var db = new AlarmsContext())
            {
                foreach (var temp in db.alarmInformacijas)
                    alarmInformacijas.Add(temp);
            }
        }

        public string Login(string username, string password)
        {
            using (var db = new UsersContext())
            {
                foreach (var user in db.Users)
                {
                    if (username == user.Username &&
                   ValidateEncryptedData(password, user.EncryptedPassword))
                    {
                        string token = GenerateToken(username);
                        authenticatedUsers.Add(token, user);
                        
                        return token;
                    }
                }
            }
            return "Login failed";

        }

        private static bool ValidateEncryptedData(string valueToValidate, string valueFromDatabase)
        {
            string[] arrValues = valueFromDatabase.Split(':');
            string encryptedDbValue = arrValues[0];
            string salt = arrValues[1];
            byte[] saltedValue = Encoding.UTF8.GetBytes(salt + valueToValidate);
            using (var sha = new SHA256Managed())
            {
                byte[] hash = sha.ComputeHash(saltedValue);
                string enteredValueToValidate = Convert.ToBase64String(hash);
                return encryptedDbValue.Equals(enteredValueToValidate);
            }
        }

        private bool IsUserAuthenticated(string token)
        {
            return authenticatedUsers.ContainsKey(token);
        }


        private string GenerateToken(string username)
        {
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            byte[] randVal = new byte[32];
            crypto.GetBytes(randVal);
            string randStr = Convert.ToBase64String(randVal);
            return username + randStr;
        }


    }
}
