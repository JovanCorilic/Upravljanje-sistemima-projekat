﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SCADA
{
    [DataContract]
    public class AO
    {
        [DataMember]
        public string tag_name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string IO_address { get; set; }
        [DataMember]
        public string inital_value { get; set; }
        [DataMember]
        public string low_limit { get; set; }
        [DataMember]
        public string high_limit { get; set; }
        [DataMember]
        public string units { get; set; }
        public override string ToString()
        {
            return "tag name: " + tag_name + ", description: " + description + ", I/O address: " + IO_address + ", initial value: "+inital_value+
                ", low limit: " + low_limit + ", high limit: " + high_limit + ", units: " + units;
        }
    }
}