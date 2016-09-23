using Gevcorst.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevcorst.Domain.Abstract
{
   public interface IBeneficiaryRepository
    {
        IEnumerable<Beneficiary>Beneficiaries{get;}
         void SaveBeneficiary(Beneficiary beneficiary);
         Beneficiary DeleteProduct(int BeneficiaryID);
       void AddBeneficiary(Beneficiary bf);
    }
}
