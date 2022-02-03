using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SCADA
{
    public class TagsContext:DbContext
    {
        public DbSet<TagVrednost> tagVrednosts { get; set; }
    }
}