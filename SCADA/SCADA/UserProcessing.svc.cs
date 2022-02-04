using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Simulation_Driver;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserProcessing" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserProcessing.svc or UserProcessing.svc.cs at the Solution Explorer and start debugging.
    public class UserProcessing : IUserProcessing
    {
        private static Dictionary<string, User> authenticatedUsers = new Dictionary<string, User>();
        private static Dictionary<string, AI> aIs = new Dictionary<string, AI>();
        private static Dictionary<string, AO> aOs = new Dictionary<string, AO>();
        private static Dictionary<string, DI> dIs = new Dictionary<string, DI>();
        private static Dictionary<string, DO> dOs = new Dictionary<string, DO>();

        public void DoWork()
        {
            
            
        }
        public string ukljucivanjeIsklucivanjeScan(string tag_name, string token)
        {
            if (IsUserAuthenticated(token))
            {
                if (aIs.ContainsKey(tag_name))
                {
                    if (aIs[tag_name].onoff_scan)
                    {
                        aIs[tag_name].onoff_scan = false;
                        return "Skeniranje iskljuceno";
                    }
                    else
                    {
                        aIs[tag_name].onoff_scan = true;
                        return "Skeniranje ukljuceno";
                    }
                }
                else if (dIs.ContainsKey(tag_name))
                {
                    if (dIs[tag_name].onoff_scan)
                    {
                        dIs[tag_name].onoff_scan = false;
                        return "Skeniranje iskljuceno";
                    }
                    else
                    {
                        dIs[tag_name].onoff_scan = true;
                        return "Skeniranje ukljuceno";
                    }
                }
                else
                    return "Tag sa tim nazivom ne postoji";
            }
            else
                return "Losa verifikacija";
        }
        public string prikazVrednostiIzlaznihTagova(string token)
        {
            if (IsUserAuthenticated(token))
            {
                string temp1 = "Vrednosti analog output taga:\n";
                string temp2 = "Vrednosti digital output taga:\n";
                using(var db = new TagsContext())
                {
                    foreach(TagVrednost tagVrednost in db.tagVrednosts)
                    {
                        if (aOs.ContainsKey(tagVrednost.tag_name))
                        {
                            temp1 += tagVrednost.ToString() + "\n";
                        }
                        else if (dOs.ContainsKey(tagVrednost.tag_name))
                        {
                            temp2 += tagVrednost.ToString() + "\n";
                        }
                    }
                }
                return temp1+temp2;
            }else
                return "";
        }

        public bool brisanjeTaga(string id,string token)
        {
            if (IsUserAuthenticated(token))
            {
                if (aIs.ContainsKey(id))
                {
                    aIs.Remove(id);
                }
                else if (aOs.ContainsKey(id))
                {
                    aOs.Remove(id);
                }
                else if (dIs.ContainsKey(id))
                {
                    dIs.Remove(id);
                }
                else if (dOs.ContainsKey(id))
                {
                    dOs.Remove(id);
                }
                else
                    return false;
                using (var db = new TagsContext())
                {
                    try
                    {
                        db.tagVrednosts.Remove(db.tagVrednosts.Find(id));
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }
                return true;
            }
            else
                return false;
        }

        public bool pravljenjeTaga(object temp, int brojTag, string token)
        {
            if (IsUserAuthenticated(token))
            {
                string tagName = "";
                string IO = "";
                if (brojTag == 1)
                {
                    AI aI = (AI)temp;
                    if (!aIs.ContainsKey(aI.tag_name))
                    {
                        tagName = aI.tag_name;
                        IO = aI.IO_address;
                        aIs.Add(aI.tag_name, aI);
                    }
                    else
                        return false;
                }
                else if (brojTag == 2)
                {
                    AO aO = (AO)temp;
                    if (!aOs.ContainsKey(aO.tag_name))
                    {
                        tagName = aO.tag_name;
                        IO = aO.IO_address;
                        aOs.Add(aO.tag_name, aO);
                    }
                    else
                        return false;
                }
                else if (brojTag == 3)
                {
                    DI dI = (DI)temp;
                    if (!dIs.ContainsKey(dI.tag_name))
                    {
                        tagName = dI.tag_name;
                        IO = dI.IO_address;
                        dIs.Add(dI.tag_name, dI);
                    }
                    else
                        return false;
                }
                else if (brojTag == 4)
                {
                    DO dO = (DO)temp;
                    if (!dOs.ContainsKey(dO.tag_name))
                    {
                        tagName = dO.tag_name;
                        IO = dO.IO_address;
                        dOs.Add(dO.tag_name, dO);
                    }
                    else
                        return false;
                }
                using(var db = new TagsContext())
                {
                    try
                    {
                        TagVrednost tagVrednost = new TagVrednost();
                        tagVrednost.tag_name = tagName;
                        tagVrednost.vrednost = SimulationDriver.ReturnValue(IO);
                        if (aOs.ContainsKey(tagVrednost.tag_name))
                            aOs[tagVrednost.tag_name].inital_value = tagVrednost.vrednost.ToString();
                        else if (dOs.ContainsKey(tagVrednost.tag_name))
                            dOs[tagVrednost.tag_name].inital_value = tagVrednost.vrednost.ToString();
                        db.tagVrednosts.Add(tagVrednost);
                        db.SaveChanges();
                    }catch(Exception e) {
                        return false;
                    }
                        
                }
                    
                return true;
            }
            else
                return false;
            
        }

        private void sacuvajXML()
        {
            XElement xElement = new XElement("SCADA konfiguracija");
            
            XElement ai = new XElement("AI");
            foreach(AI i in aIs.Values)
            {
                ai.Add(new XElement("tag_name", i.tag_name, new XAttribute("description", i.description), new XAttribute("driver", i.driver), new XAttribute("IO_address", i.IO_address),
                    new XAttribute("scan_time", i.scan_time), new XAttribute("alarms", i.alarms), new XAttribute("onoff_scan", i.onoff_scan), new XAttribute("low_limit", i.low_limit),
                    new XAttribute("high_limit", i.high_limit), new XAttribute("units", i.units)));
            }
            xElement.Add(ai);
            XElement ao = new XElement("AO");
            foreach(AO i in aOs.Values)
            {
                ao.Add(new XElement("tag_name", i.tag_name, new XAttribute("description", i.description), new XAttribute("IO_address", i.IO_address),
                    new XAttribute("inital_value", i.inital_value), new XAttribute("low_limit", i.low_limit),
                    new XAttribute("high_limit", i.high_limit), new XAttribute("units", i.units)));
            }
            xElement.Add(ao);
            XElement di = new XElement("DI");
            foreach(DI i in dIs.Values)
            {
                di.Add(new XElement("tag_name", i.tag_name, new XAttribute("description", i.description), new XAttribute("driver", i.driver), new XAttribute("IO_address", i.IO_address),
                    new XAttribute("scan_time", i.scan_time), new XAttribute("onoff_scan", i.onoff_scan)));
            }
            xElement.Add(di);
            XElement dO = new XElement("DO");
            foreach(DO i in dOs.Values)
            {
                dO.Add(new XElement("tag_name", i.tag_name, new XAttribute("description", i.description), new XAttribute("IO_address", i.IO_address),
                    new XAttribute("inital_value", i.inital_value)));
            }
            
            xElement.Add(dO);
            xElement.Save("scadaConfig.xml");

        }

        private void ucitavanjeXML()
        {
            if (File.Exists("scadaConfig.xml"))
            {
                aIs = new Dictionary<string, AI>();
                aOs = new Dictionary<string, AO>();
                dIs = new Dictionary<string, DI>();
                dOs = new Dictionary<string, DO>();
                XElement xmlData = XElement.Load("scadaConfig.xml");
                XElement lista = (XElement)xmlData.FirstNode;
                XElement listaAI = (XElement)lista.FirstNode;
                do
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
                } while (listaAI!=null);

                lista = (XElement)lista.NextNode;
                XElement listaAO = (XElement)lista.FirstNode;
                do
                {
                    AO ao = new AO();
                    var attribute = listaAO.FirstAttribute;
                    ao.description = attribute.Value;
                    attribute = attribute.NextAttribute;
                    
                    
                    ao.IO_address = attribute.Value;
                    
                    
                    attribute = attribute.NextAttribute;
                    ao.inital_value = attribute.Value;
                    attribute = attribute.NextAttribute;
                    
                    
                    ao.low_limit = attribute.Value;
                    attribute = attribute.NextAttribute;
                    ao.high_limit = attribute.Value;
                    attribute = attribute.NextAttribute;
                    ao.units = attribute.Value;
                    ao.tag_name = listaAO.FirstNode.ToString();
                    aOs.Add(ao.tag_name, ao);
                    listaAO = (XElement)listaAO.NextNode;
                } while (listaAO!=null);
                lista = (XElement)lista.NextNode;
                XElement listaDI = (XElement)lista.FirstNode;
                do
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
                } while (listaDI!=null);
                lista = (XElement)lista.NextNode;
                XElement listaDO = (XElement)lista.FirstNode;
                do
                {
                    DO ao = new DO();
                    var attribute = listaDO.FirstAttribute;
                    ao.description = attribute.Value;
                    attribute = attribute.NextAttribute;
                    ao.IO_address = attribute.Value;
                    attribute = attribute.NextAttribute;
                    ao.inital_value = attribute.Value;
                    
                    ao.tag_name = listaDO.FirstNode.ToString();
                    dOs.Add(ao.tag_name, ao);
                    listaDO = (XElement)listaDO.NextNode;
                } while (listaDO!=null);
            }
        }

        

        public string Login(string username, string password)
        {
            using(var db = new UsersContext())
 {
                foreach (var user in db.Users)
                {
                    if (username == user.Username &&
                   ValidateEncryptedData(password, user.EncryptedPassword))
                    {
                        string token = GenerateToken(username);
                        authenticatedUsers.Add(token, user);
                        ucitavanjeXML();
                        return token;
                    }
                }
            }
            return "Login failed";

        }

        private string GenerateToken(string username)
        {
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            byte[] randVal = new byte[32];
            crypto.GetBytes(randVal);
            string randStr = Convert.ToBase64String(randVal);
            return username + randStr;
        }


        public bool Logout(string token)
        {
            sacuvajXML();
            return authenticatedUsers.Remove(token);
        }

        public bool Registration(string username, string password)
        {
            string encryptedPassword = EncryptData(password);
            User user = new User(username, encryptedPassword);
            using (var db = new UsersContext())
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }

        private static string EncryptData(string valueToEncrypt)
        {
            string GenerateSalt()
            {
                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                byte[] salt = new byte[32];
                crypto.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
            string EncryptValue(string strValue)
            {
                string saltValue = GenerateSalt();
                byte[] saltedPassword = Encoding.UTF8.GetBytes(saltValue + strValue);
                using (SHA256Managed sha = new SHA256Managed())
                {
                    byte[] hash = sha.ComputeHash(saltedPassword);
                    return $"{Convert.ToBase64String(hash)}:{saltValue}";
                }
            }
            return EncryptValue(valueToEncrypt);
        }

        private static bool ValidateEncryptedData(string valueToValidate,string valueFromDatabase)
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

        public void prenosTipa(AI aI, AO aO, DI dI, DO dO)
        {
            throw new NotImplementedException();
        }
    }
}
