using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITagProcessing" in both code and config file together.
    public interface INotificationServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnNotificationSent(string message);
    }
    [ServiceContract(CallbackContract = typeof(INotificationServiceCallBack))]
    public interface ITagProcessing
    {
        [OperationContract]
        void DoWork(AI aI,DI dI);
        
        [OperationContract]
        void TagProccesingInitalization();

    }
    

    [ServiceContract]
    public interface IDatabseManager
    {
        [OperationContract]
        void SendNotification(string message);
        [OperationContract]
        TagVrednost davanjeVrednosti(string IO,string tag_name);
    }
}
