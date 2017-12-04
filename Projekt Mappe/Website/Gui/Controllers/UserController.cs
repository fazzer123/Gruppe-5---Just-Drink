using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.UserServiceRef;
using Gui.WalletServiceRef;
using Gui.AuthServiceRef;
using Gui.ServiceSecurityRef;
using System.Net;

namespace Gui.Controllers
{
    public class UserController : Controller
    {
        UserServiceClient UserClient = new UserServiceClient();
        WalletServiceClient WalletClient = new WalletServiceClient();

        // GET: User
        public ActionResult Index()
        {
            int id = 0;
            ServicePointManager.ServerCertificateValidationCallback = (obj, certificate, chain, errors) => true;
            AuthServiceClient authClient = new AuthServiceClient();
            var isLoggedIn = authClient.Login("tg", "goddav");
            if (isLoggedIn)
            {
                SecurityServiceClient client = new SecurityServiceClient("WSHttpBinding_ISecurityService");
                client.ClientCredentials.UserName.UserName = "tg";
                client.ClientCredentials.UserName.Password = "goddav";
                var data = client.GetData(1337);
                id = 1;
            }
            return View(UserClient.GetUser(id));
        }

        public ActionResult WalletDetails(int id)
        {
            if(WalletClient.GetWallet(id) == null)
            {
                Wallet w = new Wallet
                {
                    User = WalletClient.GetUserById(id),
                    Balance = 0,
                    MinBalance = 0,
                    MaxBalance = 0,
                    LockTime = DateTime.Now
            };
                WalletClient.CreateWallet(w);
            }
            return View(WalletClient.GetWallet(id));
        }
        [HttpPost]
        public ActionResult EditBalance(int id, string text)
        {
            decimal balance = WalletClient.GetWallet(id).Balance;
            balance = balance + decimal.Parse(text);
            WalletClient.UpdateBalanceByUserId(balance, id);
            return RedirectToAction("WalletDetails", new {id});
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
