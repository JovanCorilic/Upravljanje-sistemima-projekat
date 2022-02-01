using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserProcessing" in both code and config file together.
    [ServiceContract]
    public interface IUserProcessing
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        void pravljenjeTaga(AI aI,string token);
        [OperationContract]
        bool Registration(string username, string password);
        [OperationContract]
        string Login(string username, string password);
        [OperationContract]
        bool Logout(string token);
    }

    

}
