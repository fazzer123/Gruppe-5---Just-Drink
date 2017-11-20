using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.OrderServiceRef;
using Gui.OrderLineServiceRef;
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
            dynamic BCVM = new ExpandoObject();
            BCVM.Order = client.GetOrder(id);
            BCVM.OrderLines = client.GetOrder(id).OrderLines;
            return View(BCVM);
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
            return View();
        }

        // POST: Order/Edit/5
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

        // GET: Order/Delete/5
        public ActionResult Delete(int OrderLineId, int id)
        {
                olClient.DeleteOrderLineByID(OrderLineId);
            dynamic BCVM = new ExpandoObject();
            BCVM.Order = client.GetOrder(id);
            BCVM.OrderLines = client.GetOrder(id).OrderLines;
            return View("Details", BCVM);
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
    }
}
