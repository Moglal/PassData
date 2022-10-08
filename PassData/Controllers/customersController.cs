using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassData.Models;

namespace PassData.Controllers
{
    public class customersController : Controller
    {
        // GET: customers
        public List<Customers> customerss;
        public ActionResult showAll()
        {
            customerss = new List<Customers>();
            customerss.Add(new Customers() { name = "Glal 1",phone="01126326565",age=25,address="Assiut",_gender=Customers.gender.male});
            customerss.Add(new Customers() { name = " Ali 1", phone = "01126326565", age = 25, address = "Assiut", _gender = Customers.gender.male });
            customerss.Add(new Customers() { name = "Yosra 1", phone = "0102454649", age = 22, address = "Cairo", _gender = Customers.gender.female });
            customerss.Add(new Customers() { name = "Menna 1", phone = "012498798415", age = 33, address = "Qena", _gender = Customers.gender.female });
            customerss.Add(new Customers() { name = "Ramy 1", phone = "0159865498461", age = 19, address = "Asswan", _gender = Customers.gender.male });

            ViewBag.customerss = customerss;
            return View();
        }
        public ActionResult edit(string name)
        {
            return View();
        }
        public ActionResult delete(string name)
        {
            return View();
        }
    }
}