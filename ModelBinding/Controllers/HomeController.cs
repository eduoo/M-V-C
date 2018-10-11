using ModelBinding.Models;
using ModelBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            People people = new People();
            people.Name = "Mustafa";
            people.LastName = "Irk";
            people.Age = 30;

            Address adres = new Address();
            adres.AddressDefination = "Test address";
            adres.City = "İstanbul";

            homepageViewModel mode = new homepageViewModel();
            mode.PeopleObject = people;
            mode.AddressObject = adres;

            return View(mode);
        }

        [HttpPost]
        public ActionResult homepage(homepageViewModel p)
        {
            return View(p);
        }
    }
}