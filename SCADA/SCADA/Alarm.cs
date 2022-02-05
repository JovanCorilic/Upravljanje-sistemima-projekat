using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SCADA
{
    [DataContract]
    public class Alarm
    {
        [DataMember]
        public string tip { get; set; }
        [DataMember]
        public string prioritet { get; set; }
        [DataMember]
        public string granicna_vrednost { get; set; }
        [DataMember]
        public string ime_velicine { get; set; }

    }
}