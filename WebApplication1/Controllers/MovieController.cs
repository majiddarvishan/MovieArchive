using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MovieController : BaseController
    {
        // GET: Movie
        public ActionResult Index()
        {
            ViewBag.Movies = DbContext.Movies.ToList();
            
            return View();
        }
        [HttpGet]
        public ActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMovie(Movie model)
        {
            if (!model.IsValid())
            {
                return RedirectToAction("AddMovie");
            }
            DbContext.Movies.Add(model);
            DbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}