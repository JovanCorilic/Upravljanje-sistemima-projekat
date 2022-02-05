using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SCADA
{
    public class AlarmsContext: DbContext
    {
        public DbSet<AlarmInformacija>alarmInformacijas { get; set; }
    }
}