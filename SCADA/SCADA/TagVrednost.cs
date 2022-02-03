using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCADA
{
    public class TagVrednost
    {
        [Key]
        public string tag_name { get; set; }
        public double vrednost { get; set; }

        public TagVrednost()
        {
        }
    }
}