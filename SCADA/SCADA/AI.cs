using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SCADA
{
    [DataContract]
    public class AI
    {
        [DataMember]
        public string tag_name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string driver { get; set; }
        [DataMember]
        public string IO_address { get; set; }
        [DataMember]
        public string scan_time { get; set; }
        [DataMember]
        public string alarms { get; set; }
        [DataMember]
        public bool onoff_scan { get; set; }
        [DataMember]
        public string low_limit { get; set; }
        [DataMember]
        public string high_limit { get; set; }
        [DataMember]
        public string units { get; set; }

        public override string ToString()
        {
            return "tag name: " + tag_name + ", description: " + description + ", driver: " + driver + ", I/O address: " + IO_address + ", \nscan time: " + scan_time + ", alarms: " + alarms +
                ", on/off scan: " + onoff_scan.ToString() + ", low limit: " + low_limit + ", high limit: " + high_limit + ", units: " + units;
        }
    }
}