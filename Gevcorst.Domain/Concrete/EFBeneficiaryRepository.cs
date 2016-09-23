using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gevcorst.Domain.Abstract;
using Gevcorst.Domain.Entities;
namespace Gevcorst.Domain.Concrete
{
   public class EFBeneficiaryRepository:IBeneficiaryRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Beneficiary> Beneficiaries
        {
            get { return context.Beneficiaries; }
        }
        public void AddBeneficiary(Beneficiary bf)
        {
            if (bf != null)
            {
                context.Beneficiaries.Add(bf);
                context.SaveChanges();
            }
        }
       public void SaveBeneficiary(Beneficiary beneficiary)
        {
           /* if (beneficiary.ID == 0)
            {
                context.Beneficiaries.Add(beneficiary);
            }
            else
            {
                Beneficiary dbEntry = context.Beneficiaries.Find(beneficiary.ID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = beneficiary.FirstName;
                    dbEntry.LastName = beneficiary.LastName;
                    dbEntry.UserName = beneficiary.UserName;
                    dbEntry.Password =PasswordHash.HashPassword( beneficiary.Password);
                    dbEntry.ConfirmPassword = PasswordHash.HashPassword(beneficiary.ConfirmPassword);
                    dbEntry.Category = beneficiary.Category;
                    dbEntry.Country = beneficiary.Country;
                    dbEntry.State = beneficiary.State;
                    dbEntry.StreeAddress = beneficiary.StreeAddress;
                    dbEntry.PostCode = beneficiary.PostCode;
                    dbEntry.Sex = beneficiary.Sex;
                    dbEntry.DOB = beneficiary.DOB;
                    dbEntry.Challenge = beneficiary.Challenge;
                    dbEntry.AboutYourSelf = beneficiary.AboutYourSelf;
                    dbEntry.Email = beneficiary.Email;
                    dbEntry.MobileNumber = beneficiary.MobileNumber;
                    dbEntry.FileName = beneficiary.FileName;
                    dbEntry.ImageData = beneficiary.ImageData;
                    dbEntry.ImageMimeType = beneficiary.ImageMimeType;

                }
            }
            context.SaveChanges();*/
        }
        public Beneficiary DeleteProduct(int beneficiaryID)
        {
            Beneficiary ben = context.Beneficiaries.Find(beneficiaryID);
            if (ben != null)
            {
                context.Beneficiaries.Remove(ben);
                context.SaveChanges();
            }
            return ben;
        }
    }
}
