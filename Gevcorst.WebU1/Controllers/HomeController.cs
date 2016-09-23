using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Gevcorst.Domain.Tools;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using Gevcorst.WebU1.Models;

namespace Gevcorst.WebU1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
           
          /*
            SlideshowContext context = new SlideshowContext();
            var getAllImages = from dr in context.Gallery select dr;
            if (getAllImages != null)

            {
                Gallery[] mypix = getAllImages.ToArray();
           
               
                return View(getAllImages);
            }
            
         
           
           
                
            else*/
                return View();
        }
        
        [HttpGet]
        public ActionResult AddImage()
        {
            return View();
        }
         [HttpPost]
        public ActionResult AddImage(HttpPostedFileBase imagePath)
        {
           
            return RedirectToAction("Index","Home");
        }
         public ActionResult AddPerson()
         {
             return View();
         }
         [HttpPost]
         public ActionResult AddPerson(Person person, HttpPostedFileBase upload)
         {
            return RedirectToAction("AddPerson","Home");
         }
    }
}