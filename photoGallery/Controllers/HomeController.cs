using PatternProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatternProject.Controllers
{
    public class HomeController : Controller
    {
        //private GalleryContext db = new GalleryContext();

        public ActionResult Index()
        {
            return View(Enumerable.Empty<Album>());
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}