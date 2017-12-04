using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.UserServiceRef;


namespace Gui.Controllers
{
    public class RegisterController : Controller
    {
        UserServiceClient client = new UserServiceClient();
    
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register/Create

            [HttpPost]
            public ActionResult Create(User user)
            {
                client.CreateUser(user);
            return RedirectToAction("Index", "Home");
            }
        }


    }
