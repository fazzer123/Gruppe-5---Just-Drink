using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.UserServiceRef;
using Gui.FavoritServiceRef;
using Gui.Models;
using System.Text.RegularExpressions;

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
        [HttpPost]
        public ActionResult Index(UserModel email)
        {
            return View();
        }

        public ActionResult AutomaticRedirect()
        {
            return RedirectToAction("Index", "Home");
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
            if (string.IsNullOrEmpty(user.UserName))
            {
                ModelState.AddModelError("Name", "Indtast username");
            }
            if (!string.IsNullOrEmpty(user.Email))
            {
                string emailRegex = @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$";
                Regex re = new Regex(emailRegex);
                if (!re.IsMatch(user.Email))
                {
                    ModelState.AddModelError("Email", "Indtast venligst korrekt email");
                }
            }
            else
            {
                ModelState.AddModelError("Email", "Indtast venligst email");
            }
            if (!string.IsNullOrEmpty(user.Phone))
            {
                string phoneRegex = "^([0-9]{8})$";
                Regex pe = new Regex(phoneRegex);
                if (!pe.IsMatch(user.Phone))
                {
                    ModelState.AddModelError("Phone", "Indtast venligst korrekt telefon nr");
                }
            }
            else
            {
                ModelState.AddModelError("Phone", "Indtast telefon nr");
            }
                if (ModelState.IsValid)
                {

                    client.CreateUser(user);
                    return RedirectToAction("Index");
                }
                return View();
        }
    }
