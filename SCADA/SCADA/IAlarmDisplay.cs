using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCADA
{
    public interface INotificationAlarmCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnNotificationSent(string message);
    }
    [ServiceContract(CallbackContract = typeof(INotificationAlarmCallBack))]
    public interface IAlarmDisplay
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        void AlarmDisplayInitialization();
    }
    [ServiceContract]
    public interface IDatabaseManagerAlarm
    {
        [OperationContract]
        void SendNotification(string message);
        [OperationContract]
        AlarmInformacija pravljenjeAlarmInformacije(Alarm alarm, TagVrednost tagVrednost);
    }
}
