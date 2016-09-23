using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevcorst.Domain.Tools
{
    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        /*[Required,StringLength(100)]
        public string ContentDescription { get; set; }*/
       
      
        
    }
}
