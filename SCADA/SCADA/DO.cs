using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCADA
{
    public class DO
    {
        [Key]
        public string tag_name { get; set; }
        public string description { get; set; }
        public string IO_adress { get; set; }
        public string initial_value { get; set; }
    }
}