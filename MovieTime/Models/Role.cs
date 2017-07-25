using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}