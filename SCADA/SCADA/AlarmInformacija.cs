﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCADA
{
    public class AlarmInformacija
    {
        [Key]
        public int Id { get; set; }
        public string tip { get; set; }
        public DateTime vreme_aktivacije { get; set; }
        public string ime_velicine { get; set; }
    }
}