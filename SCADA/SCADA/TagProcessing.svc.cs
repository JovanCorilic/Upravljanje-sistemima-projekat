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
        
        static INotificationServiceCallBack proxy = null;
        delegate void NotificationDelegate(string message);
        static event NotificationDelegate notificationSent = null;
        //event NotificationDelegate notificationReceived;

        public void DoWork(AI aI, DI dI)
        {

        }

       

        public void TagProccesingInitalization()
        {
            proxy = OperationContext.Current.GetCallbackChannel<INotificationServiceCallBack>();
            notificationSent += proxy.OnNotificationSent;
        }

        
        public void SendNotification(string message)
        {
            if (notificationSent != null)
                notificationSent(message);

        }

        public string davanjeVrednosti(string IO, string tag_name)
        {
            using (var db = new TagsContext())
            {
                try
                {
                    TagVrednost tagVrednost = new TagVrednost();
                    tagVrednost.tag_name = tag_name;
                    tagVrednost.vrednost = Simulation_Driver.SimulationDriver.ReturnValue(IO);
                    tagVrednost.vreme_kreacije = DateTime.Now;
                    db.tagVrednosts.Add(tagVrednost);
                    db.SaveChanges();
                    return tagVrednost.vrednost.ToString();

                    
                }
                catch (Exception e)
                {
                    return "Error";
                }
            }
            
        }
    }
}
