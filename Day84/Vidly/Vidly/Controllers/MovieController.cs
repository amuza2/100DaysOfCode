using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private List<Movie> GetMovie()
        {
            var movies = new List<Movie>()
            {
                new Movie() { Name = "Shrek" },
                new Movie() { Name = "Wall-e" }
            };
            return movies;
        }
        public ActionResult Random()
        {
            return View();
        }

        [Route("Movies")]
        public ActionResult Movies()
        {
            var movie = GetMovie();
            var viewModel = new MoviesViewModel()
            {
                Movies = movie,
            };
            return View(viewModel);
        }
    }
}