﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.OrderServiceRef;
using Gui.OrderLineServiceRef;
using Gui.WalletServiceRef;
using Gui.UserServiceRef;
using Gui.CustomerServiceRef;
using System.Dynamic;

namespace Gui.Controllers
{
    public class OrderController : Controller
    {
        OrderServiceClient client = new OrderServiceClient();
        OrderLineServiceClient olClient = new OrderLineServiceClient();
        WalletServiceClient walletClient = new WalletServiceClient();

        // GET: Order
        public ActionResult Index()
        {
            return View(client.GetAllOrders());
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View(doBCVM(id));
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
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

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View(olClient.GetOrderLine(id));
        }

        [HttpPost]
        public ActionResult EditAmount(int id, int orderID, string text)
        {
            decimal price = client.GetOrder(orderID).TotalPrice - olClient.GetOrderLine(id).TotalPrice;
            client.UpdatePrice(client.GetOrder(orderID), price);

            int amount = Convert.ToInt32(text);
            OrderLineServiceRef.OrderLine orderline = olClient.GetOrderLine(id);
            orderline.TotalPrice = amount * orderline.Drink.Price;
            orderline.Amount = amount;
            olClient.EditOrderLine(orderline);

            price = client.GetOrder(orderID).TotalPrice + olClient.GetOrderLine(id).TotalPrice;
            client.UpdatePrice(client.GetOrder(orderID), price);

            return RedirectToAction("Details", new {id = orderID});
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, OrderLineServiceRef.OrderLine orderline, string text)
        {
            try
            {
                int amount = orderline.Amount + Convert.ToInt32(text);
                orderline = olClient.GetOrderLine(id);
                orderline.TotalPrice = amount * orderline.Drink.Price;
                orderline.Amount = amount;
                olClient.EditOrderLine(orderline);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Order/Delete/5
        public ActionResult DeleteOrder(int ID)
        {
            client.DeleteOrderByID(ID);
            return RedirectToAction("Index");
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult DeleteOrder(int ID, FormCollection collection)
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

        // GET: Order/Delete/5
        public ActionResult Delete(int OrderLineId, int id)
        {
            decimal newprice = client.GetOrder(id).TotalPrice;
            newprice = newprice - olClient.GetOrderLine(OrderLineId).TotalPrice;
            client.UpdatePrice(client.GetOrder(id), newprice);

            olClient.DeleteOrderLineByID(OrderLineId);
            return View("Details", doBCVM(id));
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int OrderLineId, FormCollection collection)
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

        public dynamic doBCVM(int id)
        {
            dynamic BCVM = new ExpandoObject();
            BCVM.Order = client.GetOrder(id);
            BCVM.OrderLines = client.GetOrder(id).OrderLines;
            return BCVM;
        }

        public ActionResult CompleteOrder(int id)
        {
            Order order = client.GetOrder(id);
            order.Status = "Complete";
            decimal hej = walletClient.GetWallet(1).Balance - order.TotalPrice;
            walletClient.UpdateBalanceByUserId(hej, 1);
            client.CompleteOrder(order);

            return RedirectToAction("Index");
        }

        public ActionResult CreateOrder(int cusID)
        {
            DateTime date = DateTime.Now;

            Order order = new Order
            {
                TotalPrice = 0,
                Discount = 0,
                Date = date,
                Status = "Incomplete",
                User = client.GetUser(1),
                Customer = client.GetCustomer(cusID)
            };

            client.CreateOrder(order);
            return RedirectToAction("Index");
        }
    }
}