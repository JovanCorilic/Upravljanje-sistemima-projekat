using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Report_Manager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Report-Manager.svc or Report-Manager.svc.cs at the Solution Explorer and start debugging.
    public class Report_Manager : IReport_Manager
    {
        private static List<TagVrednost> tagVrednosts = new List<TagVrednost>();
        private static List<AlarmInformacija> alarmInformacijas = new List<AlarmInformacija>();
        private static Dictionary<string, User> authenticatedUsers = new Dictionary<string, User>();
        public void DoWork()
        {
        }

        public List<TagVrednost> poslednjaVrednostAItaga()
        {

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
