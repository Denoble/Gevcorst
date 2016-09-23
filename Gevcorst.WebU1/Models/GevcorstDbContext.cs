using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gevcorst.WebU1.Models
{
    public class GevcorstDbContext:DbContext
    {
        public DbSet<Person> persons { get; set; }
    }
}