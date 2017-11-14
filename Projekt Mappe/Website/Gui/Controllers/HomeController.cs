using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gui.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FindBar()
        {
            ViewBag.Message = "Your Find Bar Page";

            return View();
        }

        public ActionResult shoppage()
        {
            ViewBag.Message = "Shop page";

            return View();
        }
    }
}