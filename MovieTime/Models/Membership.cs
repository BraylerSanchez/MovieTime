using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string Name { get; set; }
        public string SignUpFee { get; set; }
        public string DurationInMonths { get; set; }
        public string DiscountRate { get; set; }
    }
}