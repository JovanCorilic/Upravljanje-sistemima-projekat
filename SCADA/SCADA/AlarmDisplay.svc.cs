using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlarmDisplay" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlarmDisplay.svc or AlarmDisplay.svc.cs at the Solution Explorer and start debugging.
    
    public class AlarmDisplay : IAlarmDisplay,IDatabaseManagerAlarm
    {
        static INotificationAlarmCallBack proxy = null;
        delegate void NotificationDelegate(string message);
        static event NotificationDelegate notificationSent = null;
        public void AlarmDisplayInitialization()
        {
            proxy = OperationContext.Current.GetCallbackChannel<INotificationAlarmCallBack>();
            notificationSent += proxy.OnNotificationSent;
        }

        public void DoWork()
        {
        }

        public void SendNotification(string message)
        {
            if (notificationSent != null)
                notificationSent(message);
        }

        public AlarmInformacija pravljenjeAlarmInformacije(Alarm alarm, TagVrednost tagVrednost)
        {
            using (var db = new AlarmsContext())
            {
                
                AlarmInformacija alarmInformacija = new AlarmInformacija();
                if (String.Equals(alarm.tip, "low"))
                {
                    if (double.Parse(alarm.granicna_vrednost) > tagVrednost.vrednost)
                    {
                        alarmInformacija.tip = alarm.tip;
                        alarmInformacija.vreme_aktivacije = DateTime.Now;
                        alarmInformacija.ime_velicine = alarm.ime_velicine;
                        alarmInformacija.prioritet = alarm.prioritet;
                        db.alarmInformacijas.Add(alarmInformacija);
                        db.SaveChanges();
                        return alarmInformacija;
                    }
                }
                else if (String.Equals(alarm.tip, "high"))
                {
                    if (double.Parse(alarm.granicna_vrednost) < tagVrednost.vrednost)
                    {
                        alarmInformacija.tip = alarm.tip;
                        alarmInformacija.vreme_aktivacije = DateTime.Now;
                        alarmInformacija.ime_velicine = alarm.ime_velicine;
                        db.alarmInformacijas.Add(alarmInformacija);
                        db.SaveChanges();
                        return alarmInformacija;
                    }
                }
                return null;

                
                
            }
        }
    }
}
