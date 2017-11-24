using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.OrderServiceRef;
using Gui.OrderLineServiceRef;
using Gui.UserServiceRef;
using Gui.CustomerServiceRef;
using System.Dynamic;

namespace Gui.Controllers
{
    public class OrderController : Controller
    {
        OrderServiceClient client = new OrderServiceClient();
        OrderLineServiceClient olClient = new OrderLineServiceClient();

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

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, OrderLineServiceRef.OrderLine orderline)
        {
            try
            {
                int amount = orderline.Amount;
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