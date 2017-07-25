using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role  { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}