﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.DrinkServiceRef;
using Gui.OrderLineServiceRef;

namespace Gui.Controllers
{
    public class DrinkController : Controller
    {
        private DrinkServiceClient client = new DrinkServiceClient();
        private OrderLineServiceClient lc = new OrderLineServiceClient();

        // GET: Drink
        public ActionResult Index()
        {
            return View(client.getAllDrinks());
        }

        // GET: Drink/Details/5
        public ActionResult Details(int id)
        {
            return View(id);
        }

        // GET: Drink/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drink/Create
        [HttpPost]
        public ActionResult Create(OrderLine orderline, int drinkId)
        {
            try
            {
                orderline.Drink = lc.GetDrink(drinkId);
                orderline.TotalPrice = orderline.Drink.Price * orderline.Amount; 
                lc.CreateOrderLine(orderline, 1);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Drink/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Drink/Edit/5
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

        // GET: Drink/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Drink/Delete/5
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
