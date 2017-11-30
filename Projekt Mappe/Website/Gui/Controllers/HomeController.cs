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
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            AuthServiceClient authClient = new AuthServiceClient();
            var isLoggedIn = authClient.Login("SuperStudent", "1234");
            if (isLoggedIn)
            {
                SecurityServiceClient client = new SecurityServiceClient("WSHttpBinding_ISecurityService");
                client.ClientCredentials.UserName.UserName = "SuperStudent";
                client.ClientCredentials.UserName.Password = "1234";
                var data = client.GetData(1337);
            }
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
    }
}