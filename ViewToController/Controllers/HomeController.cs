using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult homepage(string text1, bool check1, string list1)
        {
            var t1 = Request.Form["text1"];
            var l1 = Request.Form["list1"];
            var c1 = Request.Form.GetValues("check1")[0];

            return View();
        }
    }
}