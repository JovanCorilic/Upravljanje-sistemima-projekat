﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCADA
{
    public class DO
    {
        public string tag_name { get; set; }
        public string description { get; set; }
        public string IO_address { get; set; }
        public string inital_value { get; set; }
    }
}