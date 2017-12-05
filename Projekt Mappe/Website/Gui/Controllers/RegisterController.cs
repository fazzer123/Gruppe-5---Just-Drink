using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.UserServiceRef;
using Gui.FavoritServiceRef;


namespace Gui.Controllers
{
    public class RegisterController : Controller
    {
        UserServiceClient client = new UserServiceClient();
        FavoritesServiceClient faClient = new FavoritesServiceClient();
    
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
            public ActionResult Create(Gui.UserServiceRef.User user)
            {
            client.CreateUser(user);
            return RedirectToAction("Index", "Home");
            }
        }


    }
