using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
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
        [ValidateAntiForgeryToken]        
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
        [HttpGet]
        public ActionResult DelMovie()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult DelMovie(Movie model)
        {
            /*if (!model.IsValid())
            {
                return RedirectToAction("DelMovie");
            }*/
            try
            {
                DbContext.Movies.Attach(model);                
                DbContext.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                DbContext.SaveChanges();
            }
            catch {
                return Json(new { status = "fail", message = "Movie not found" });
            }
            return Json(new { status = "success" });
        }
        
    }
}