using OddToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OddToFood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Welcome To ASP.NET MVC";
            var model = new RestaurantReview()
                {
                    Name="Boston Pizza",
                    Rating=9
                };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Location = "Edmonton, Alberta";
            return View();
        }
    }
}
