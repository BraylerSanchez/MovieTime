using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieTime.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        [StringLength(20)]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public DateTime Duration { get; set; }

        [Required]
        public List<Gender> Gender { get; set; }

        [Required]
        public string Description { get; set; }

        public double RankingIDMB { get; set; }
        public string Directors { get; set; }
        public string Writers { get; set; }

        [Required]
        public List<byte[]> Photos { get; set; }
        
        public List<string> Videos { get; set; }

        [Required]
        public int NumberInStock { get; set; }

        [Required]
        public int NumberAvailable { get; set; }

        public double? Price { get; set; }
    }
}