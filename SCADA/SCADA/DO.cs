using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SCADA
{
    [DataContract]
    public class DO
    {
        [DataMember]
        public string tag_name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string IO_address { get; set; }
        [DataMember]
        public string inital_value { get; set; }
    }
}