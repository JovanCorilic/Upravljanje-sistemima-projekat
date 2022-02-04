using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITagProcessing" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(INotificationServiceCallBack))]
    public interface ITagProcessing
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        string PrikazVrednostiUlaznihTagova();
        [OperationContract]
        void TagProccesingInitalization();

    }
    public interface INotificationServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnNotificationSent(object tag, int brojTaga);
    }
    [ServiceContract]
    public interface IDatabseManager
    {
        [OperationContract]
        void SendNotification(object tag, int brojTaga);
    }
}
