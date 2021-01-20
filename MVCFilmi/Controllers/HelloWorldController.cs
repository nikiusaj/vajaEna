using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilmi.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pozdravljen(string name="Niki",int num=1) {
            ViewBag.Message = "Pozdravljen," + name;
            ViewBag.Num = num;
            return View();
        }

        public string Poz() {
            return "Poz Svjt";
        }
    }
}