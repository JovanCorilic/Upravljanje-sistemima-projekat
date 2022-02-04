using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TagProcessing" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TagProcessing.svc or TagProcessing.svc.cs at the Solution Explorer and start debugging.
    public class TagProcessing : ITagProcessing,IDatabseManager
    {
        private static Dictionary<string, DI> dIs = new Dictionary<string, DI>();
        private static Dictionary<string, AI> aIs = new Dictionary<string, AI>();
        static INotificationServiceCallBack proxy = null;
        delegate void NotificationDelegate(object tag, int brojTaga);
        static event NotificationDelegate notificationSent = null;
        event NotificationDelegate notificationReceived = null;
        public void DoWork()
        {
        }

        public string PrikazVrednostiUlaznihTagova()
        {
            ucitavanjeXML();
            return "";

        }

        public void TagProccesingInitalization()
        {
            proxy = OperationContext.Current.GetCallbackChannel<INotificationServiceCallBack>();
            notificationReceived += proxy.OnNotificationSent;
        }

        private void ucitavanjeXML()
        {
            if (File.Exists("scadaConfig.xml"))
            {
                aIs = new Dictionary<string, AI>();
                
                dIs = new Dictionary<string, DI>();
                
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
                } while (listaAI != null);

                lista = (XElement)lista.NextNode;
                
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
                } while (listaDI != null);
                
            }
        }

        public void SendNotification(object tag, int brojTaga)
        {
            if (notificationSent != null)
                notificationSent(tag, brojTaga);
        }
    }
}
