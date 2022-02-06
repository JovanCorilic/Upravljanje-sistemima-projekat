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

        public override string ToString()
        {
            return "Tip " + tip + " , prioritet " + prioritet + " , granicna vrednost " + granicna_vrednost;
        }

        public Alarm(string tip, string prioritet, string granicna_vrednost, string ime_velicine)
        {
            this.tip = tip;
            this.prioritet = prioritet;
            this.granicna_vrednost = granicna_vrednost;
            this.ime_velicine = ime_velicine;
        }

        public Alarm()
        {
        }
    }
}