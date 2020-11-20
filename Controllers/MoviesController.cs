using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoDemand_VD_.Models;

namespace VideoDemand_VD_.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);

            //return Content("Hello Coder");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        
        

    }
}