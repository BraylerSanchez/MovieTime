using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class Video
    {
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        public string Description { get; set; }
    }
}