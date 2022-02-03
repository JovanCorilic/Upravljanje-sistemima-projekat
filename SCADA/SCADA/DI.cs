using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SCADA
{
    [DataContract]
    public class DI
    {
        [DataMember]
        public string tag_name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string driver { get; set; }
        [DataMember]
        public string IO_address {get;set;}
        [DataMember]
        public string scan_time { get; set; }
        [DataMember]
        public bool onoff_scan { get; set; }
        public override string ToString()
        {
            return "tag name: " + tag_name + ", description: " + description + ", driver: " + driver + ", I/O address: " + IO_address + ", \nscan time: " + scan_time  +
                ", on/off scan: " + onoff_scan.ToString() ;
        }
    }
}