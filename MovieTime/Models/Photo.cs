using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required]
        public byte[] Picture { get; set; }

        public string Description { get; set; }
    }
}