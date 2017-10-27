using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Description { get; set; }
        [Display(Name = "Created at")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Updated at")]
        public DateTime UpdatedDate { get; set; }
    }
}