using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gevcorst.WebU1.Models
{
    public class Person
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        [Required, StringLength(50), Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required, StringLength(50), Display(Name = "Last name")]
        public string LastName { get; set; }
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}