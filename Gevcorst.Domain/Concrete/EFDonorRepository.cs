using Gevcorst.Domain.Abstract;
using Gevcorst.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevcorst.Domain.Concrete
{
   public class EFDonorRepository:IDonorRepository
    {
        private EFDbContext context = new EFDbContext();
       public IEnumerable<Donor> Donors
        {
            get { return context.Donors; }
        }

    }
}
