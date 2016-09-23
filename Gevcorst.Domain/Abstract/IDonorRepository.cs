using Gevcorst.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gevcorst.Domain.Abstract
{
    public interface IDonorRepository
    {
        IEnumerable<Donor> Donors { get; }
    }
}
