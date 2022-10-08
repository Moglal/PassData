using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassData.Controllers
{
    public class HomeController : Controller
    {
       // [NonAction]
       [ActionName("Index")]
        [HttpGet]
        public ActionResult asd()
        {
            ViewBag.name = "Passing Data ";
            Session["user"] = "M.Glal";
            ViewData["vd"] = "viewDatattttt";
            return View();
        }

        //[HttpGet]
        //[HttpPost]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}