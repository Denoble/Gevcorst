using Gevcorst.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevcorst.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        public EFDbContext() : base("GevcorstNC") { }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        
    }
}
