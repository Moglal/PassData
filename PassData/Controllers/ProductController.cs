using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassData.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        // not private
        // not static
        // no overload
        public ActionResult Index()
        {
            customersController obj = new customersController();
            ViewBag.data = obj.customerss;
            return View();
        }
        
        [HttpGet]
        [ActionName("sum")]
        public ActionResult sum_get()
        {
            ViewBag.n1 = 0;
            ViewBag.n2 = 0;
            ViewBag.n3 = 0;
            Session["res"] = 0;
            return View();
        }

        [HttpPost]
        [ActionName("sum")]
        //public ActionResult sum_post(double n1, double n2, double n3)
        //{
        //    ViewBag.n1 = n1;
        //    ViewBag.n2 = n2;
        //    ViewBag.n3 = n3;
        //    Session["res"] = n1 + n2 + n3;

        //    return View();
        //}
        public ActionResult sum_post(FormCollection req)
        {
            ViewBag.n1 = double.Parse(req["n1"]);
            ViewBag.n2 = double.Parse(req["n2"]);
            ViewBag.n3 = double.Parse(req["n3"]);
            Session["res"] = (ViewBag.n1 + ViewBag.n2 + ViewBag.n3);
           // req["ress"] = Session["res"] +" LE";

            return View();
        }
    }
}