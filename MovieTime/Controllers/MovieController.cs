using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieTime.Models;
using System.Drawing;

namespace MovieTime.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            List<Gender> gender = new List<Gender>
            {
                new Gender { GenderID = 1, Name = "Terror" },
                new Gender { GenderID = 2, Name = "Suspenso" }
            };

            byte[] bytes = { 130, 200, 234, 23 };


            List<Photo> photo = new List<Photo>
            {
                new Photo { Id = 1, Picture = bytes, Description = "Photo1" },
                new Photo { Id = 2, Picture = bytes, Description = "Photo1" }
            };         

            List<Movie> movie = new List<Movie>
            {
                new Movie
                {
                    MovieId = 1,
                    NumberAvailable = 10,
                    NumberInStock = 10,
                    Price = 150,                    
                    Title = "Test1",
                    Description = "Dirigida por Joseph Ruben, el filme cuenta los años de la Primera Guerra Mundial a través del punto de vista de una enfermera estadounidense en las provincias de Anatolia del Este",
                    ReleaseDate = DateTime.Now,
                    Duration = DateTime.Now.AddMinutes(15),
                    RankingIDMB = 5,
                    Country = "Red. Dom.",
                    Category = "PG13",
                    Gender = gender,
                    Photos = photo
                    
                },
                new Movie
                {
                    MovieId = 1,
                    NumberAvailable = 10,
                    NumberInStock = 10,
                    Price = 150,
                    Title = "Test1",
                    Description = "Dirigida por Joseph Ruben, el filme cuenta los años de la Primera Guerra Mundial a través del punto de vista de una enfermera estadounidense en las provincias de Anatolia del Este",
                    ReleaseDate = DateTime.Now,
                    Duration = DateTime.Now.AddMinutes(15),
                    RankingIDMB = 5,
                    Country = "Red. Dom.",
                    Category = "PG13",
                    Gender = gender,
                    Photos = photo

                },

                new Movie
                {
                    MovieId = 1,
                    NumberAvailable = 10,
                    NumberInStock = 10,
                    Price = 150,
                    Title = "Test1",
                    Description = "Dirigida por Joseph Ruben, el filme cuenta los años de la Primera Guerra Mundial a través del punto de vista de una enfermera estadounidense en las provincias de Anatolia del Este",
                    ReleaseDate = DateTime.Now,
                    Duration = DateTime.Now.AddMinutes(15),
                    RankingIDMB = 5,
                    Country = "Red. Dom.",
                    Category = "PG13",
                    Gender = gender,
                    Photos = photo
                },
            };        
            
            ViewBag.Pagination = (int)Math.Ceiling((double)movie.Count() / 10);

            return View(movie.ToList());
        }
    }
}