using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HomePractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult AboutUs()
        {

            return View();
        }
        public ActionResult Gallery()
        {

            return View();
        }
        public ActionResult ContactUs()
        {

            return View();
        }

    }
}
