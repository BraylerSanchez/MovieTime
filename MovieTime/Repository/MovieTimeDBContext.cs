using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieTime.Models;

namespace MovieTime.Repository
{
    public class MovieTimeDBContext : DbContext
    {
        public MovieTimeDBContext(): base("name=MovieTimeDBConnectionString")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }


}