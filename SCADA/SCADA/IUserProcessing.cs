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
        bool pravljenjeTaga(object temp, int brojTag,string token);
        [OperationContract]
        bool brisanjeTaga(string id, string token);
        [OperationContract]
        bool Registration(string username, string password);
        [OperationContract]
        string Login(string username, string password);
        [OperationContract]
        bool Logout(string token);
        [OperationContract]
        void prenosTipa(AI aI, AO aO, DI dI, DO dO);
    }

    

}
