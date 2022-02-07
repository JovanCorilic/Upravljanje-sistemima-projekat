using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SCADA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReport_Manager" in both code and config file together.
    [ServiceContract]
    public interface IReport_Manager
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        List<TagVrednost> poslednjaVrednostAItaga();
        [OperationContract]
        List<TagVrednost> sveVrednostiTagovaUOdredjenomVremenu(DateTime pocetak, DateTime kraj);
        [OperationContract]
        List<AlarmInformacija> sviAlarmiOdredjenVremPeriod(DateTime pocetak, DateTime kraj);
        [OperationContract]
        List<AlarmInformacija> sviAlarmiOdredjenogPrioriteta(string prioritet);
        [OperationContract]
        string Login(string username, string password);
    }
}
