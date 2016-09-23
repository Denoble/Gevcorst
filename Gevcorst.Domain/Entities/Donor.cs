using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Gevcorst.Domain.Entities
{
    [Serializable]
   public class Donor
    {
        [ScaffoldColumn(false)]
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string UserName { get; set; }
        [Required, StringLength(128)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string Category { get; set; }
        [Required, StringLength(50)]
        public string Country { get; set; }
        [Required, StringLength(50)]
        public string State { get; set; }
        [Required, StringLength(50)]
        public string StreeAddress { get; set; }
        [Required, StringLength(50)]
        public string PostCode { get; set; }
        [Required, StringLength(50)]
        public string Sex { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required, StringLength(50)]
        public string Profession { get; set; }
        [Required, StringLength(250), DataType(DataType.MultilineText)]
        public string AboutYourSelf { get; set; }
        [Required, StringLength(250), DataType(DataType.MultilineText)]
        public string Motivation { get; set; }
        [Required, StringLength(50)]
        public string Term { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string MobileNumber { get; set; }
        [Required]
        public Byte[] Pix { get; set; }
    }
}
