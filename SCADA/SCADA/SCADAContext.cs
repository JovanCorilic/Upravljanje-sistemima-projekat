using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SCADA
{
    public class SCADAContext:DbContext
    {
        public DbSet<AI> AIs { get; set; }
        public DbSet<AO> AOs { get; set; }
        public DbSet<DI> DIs { get; set; }
        public DbSet<DO> DOs { get; set; }

    }
}