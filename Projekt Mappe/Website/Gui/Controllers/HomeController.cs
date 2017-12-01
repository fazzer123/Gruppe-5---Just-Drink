using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.CustomerServiceRef;
using Gui.ServiceSecurityRef;
using Gui.AuthServiceRef;
using System.Net;

namespace Gui.Controllers
{
    public class HomeController : Controller
    {
        CustomerServiceClient client = new CustomerServiceClient();

        //ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
       
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

            return View(client.GetAllCustomers());
        }

        public ActionResult shoppage()
        {
            ViewBag.Message = "Shop page";

            return View();
        }
        

        public ActionResult Register()
        {
            ViewBag.Message = "Register page";
            return View();
        }
    }
}