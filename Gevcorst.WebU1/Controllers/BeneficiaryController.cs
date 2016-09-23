using Gevcorst.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gevcorst.Domain.Tools;
using Gevcorst.Domain.Entities;
using Gevcorst.Domain.Concrete;
using System.Data.Entity.Infrastructure;
using Gevcorst.WebU1.Models;
namespace Gevcorst.WebU1.Controllers
{
    public class BeneficiaryController : Controller
    {
        private IBeneficiaryRepository repository;
        public int pagesize = 10;
        private EFDbContext context = new EFDbContext();
        public BeneficiaryController(IBeneficiaryRepository beneficiaryRepository)
        {
            this.repository = beneficiaryRepository;
        }
        public ViewResult Beneficiary_list(int page =1)
        {
            return View(repository.Beneficiaries.OrderBy(b=>b.ID)
                .Skip((page-1)*pagesize).Take(pagesize));
        }
       
        public ActionResult AddBeneficiary()
        {
            
            
            return View();
        }
        
        
        [HttpPost]
        
        public ActionResult AddBeneficiary(Beneficiary b, HttpPostedFileBase  upload)
        {
            
      
                if (ModelState.IsValid)
                {
                    if (upload != null && upload.ContentLength > 0)
                    {
                        b.ImageData = FileProcess.PrepImageForUpload(upload.InputStream);
                        b.ImageMimeType = upload.ContentType;
                        b.FileName = upload.FileName;
                       
                    }
                    
                    context.Beneficiaries.Add(b);
                    context.SaveChanges();
                      
                   

                    
                  
                
            }
            
           
            return View();
        }
        
        
    }
}