using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieTime.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Second Last Name")]
        public string SecondLastName { get; set; }

        [Required]
        public string IdType{ get; set; }

        [Required]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Birthday")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string  City { get; set; }

        [Required]
        public string Sector { get; set; }

        [Required]
        public string Address{ get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string CivilStatus { get; set; }

        [Required]
        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        [Required]
        public string CellPhone { get; set; }

        [Required]
        public string Email { get; set; }

        public Membership Membership { get; set; }
        public List<Movie> Movies { get; set; }
    }
}