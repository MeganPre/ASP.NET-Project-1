using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLD521_Fa2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your location page.";

            return View();
        }

        public ActionResult Favorites()
        {
            ViewBag.Message = "Your favorites page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        

        public ActionResult News()
        {
            ViewBag.Message = "Your news page.";

            return Redirect("https://screenrant.com/comics/");
        }

        
    }
}