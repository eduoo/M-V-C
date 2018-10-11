using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            //ViewData["text1"] = "Mustafa Irk";
            //ViewData["check1"] = true;

            //ViewBag.text1 = "Mustafa Irk";
            //ViewBag.check1 = true;

            TempData["text1"] = "Mustafa Irk";
            TempData["check1"] = true;

            return View();
        }

        public ActionResult about()
        {
            ViewBag.text1 = "Mustafa Irk";
            ViewBag.check1 = true;
            ViewBag.list1 =
                new SelectListItem[] {
                    new SelectListItem(){Text="Mustafa"},
                    new SelectListItem(){Text="Irk"}
                };

            TempData["t1"] = ViewBag.text1;
            TempData["c1"] = ViewBag.check1;

            return View();
        }

        public ActionResult contact()
        {
            ViewBag.text1 = TempData["t1"];
            ViewBag.check1 = TempData["c1"];

            return View();
        }

        public ActionResult blog()
        {
            ViewBag.text1 = TempData["t1"];
            ViewBag.check1 = TempData["c1"];

            return View();
        }
    }
}