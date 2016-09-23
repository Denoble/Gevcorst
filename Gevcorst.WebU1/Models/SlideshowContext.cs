using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Gevcorst.Domain.Tools;
namespace Gevcorst.WebU1.Models
{
    public class SlideshowContext:DbContext{
        
        public SlideshowContext()
            : base("GevcorstNC")
        {

        }
    
        public DbSet<Gallery> Gallery { get; set; }
    }
}