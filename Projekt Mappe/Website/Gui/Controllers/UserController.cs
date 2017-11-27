using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.UserServiceRef;
using Gui.WalletServiceRef;

namespace Gui.Controllers
{
    public class UserController : Controller
    {
        UserServiceClient UserClient = new UserServiceClient();
        WalletServiceClient WalletClient = new WalletServiceClient();
        // GET: User
        public ActionResult Index()
        {
            return View(UserClient.GetUser(1));
        }

        public ActionResult WalletDetails(int id)
        {
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
