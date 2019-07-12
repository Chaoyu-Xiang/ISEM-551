using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace ISEM551Project1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ISEM551()
        {
            ViewBag.Message = "Our Team Member";

            return View();
        }


        public ActionResult DisplayData()
        {
            ViewBag.Message = "Data";

            var data = RestaurantList.GetRestaurantDate();

            return View(data);
        }
    }
}