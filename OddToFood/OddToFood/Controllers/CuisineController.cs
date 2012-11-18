using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OddToFood.Infraestructure;

namespace OddToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        
        [HttpGet]
         
        public ActionResult Search(string name="*")
        {
            //throw  new Exception("Oops la regaste");

            name = Server.HtmlEncode(name);
            return Content(name);

            /*if (name == "*")
            {
                return Json(new {cuisineName = name}, JsonRequestBehavior.AllowGet);
                //return File(Server.MapPath("~/Content/Site.css"), "text/css");
                //return RedirectToRoute("Cuisine", new {name = "german"});
                //return RedirectToAction("Search", "Cuisine", new {name = "french"});
            }*/

            
            //return Content("You have reach the Cusiene Controller");
        }

    }
}
