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
        public int Id { get; set; }
        public string tag_name { get; set; }
        public double vrednost { get; set; }
        public DateTime vreme_kreacije { get; set; }

        public TagVrednost()
        {
        }

        public override string ToString()
        {
            return "Tag name " + tag_name + ", vrednost " + vrednost.ToString()+" ,vreme kreacije "+vreme_kreacije.ToString() ;
        }
    }
}