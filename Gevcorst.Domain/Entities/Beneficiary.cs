using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Web.Mvc;



namespace Gevcorst.Domain.Entities
{
   public class Beneficiary
    {
        
            [ScaffoldColumn(false)]

            [HiddenInput(DisplayValue = false)]
            public int ID { get; set; }
            [Required, StringLength(50), Display(Name = "First name")]
            public string FirstName { get; set; }
            [Required, StringLength(50), Display(Name = "Last name")]
            public string LastName { get; set; }
            [Required, StringLength(50), Display(Name = "User name")]
            public string UserName { get; set; }
            [DataType(DataType.Password)]
            [Required, StringLength(64), MinLength(8)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
     
            [System.ComponentModel.DataAnnotations.Compare("Password"), Display(Name="Confirm password")]
            public string ConfirmPassword { get; set; }
          
            [Required, StringLength(50)]
            public string Category { get; set; }
            [Required, StringLength(50)]
            public string Country { get; set; }
            [Required, StringLength(50), Display(Name = "City/State")]
            public string State { get; set; }
            [Required, StringLength(50), Display(Name = "Steet Address")]
            public string StreeAddress { get; set; }
            [Required, StringLength(50), Display(Name = "Post code")]
            public string PostCode { get; set; }
            [Required, StringLength(50)]
            public string Sex { get; set; }
            [Display(Name = "Birth Date")]
            [Required, DataType(DataType.Date)]
            public DateTime DOB { get; set; }

            [Required, StringLength(250), DataType(DataType.MultilineText), Display(Name = "Tell us about yourself")]

            public string AboutYourSelf { get; set; }
            [Required, StringLength(250), DataType(DataType.MultilineText), Display(Name = "Tell us about your challenge")]
            public string Challenge { get; set; }

            [Required, StringLength(50),DataType(DataType.EmailAddress)]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
            public string Email { get; set; }
            [Required, StringLength(50),Display(Name="Mobile number")]
            public string MobileNumber { get; set; }
          
            public string FileName { get; set; }
           public byte[] ImageData { get; set; }
           public string ImageMimeType { get; set; }
            
           
        
    }
}
