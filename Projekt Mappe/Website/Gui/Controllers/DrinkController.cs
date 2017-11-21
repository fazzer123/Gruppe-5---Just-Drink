using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.DrinkServiceRef;
using Gui.OrderLineServiceRef;
using Gui.OrderServiceRef;
using System.Dynamic;

namespace Gui.Controllers
{
    public class DrinkController : Controller
    {
        private DrinkServiceClient client = new DrinkServiceClient();
        private OrderLineServiceClient lc = new OrderLineServiceClient();
        private OrderServiceClient orderClient = new OrderServiceClient();
        OrderController oCtr = new OrderController();

        // GET: Drink
        public ActionResult Index()
        {
            return View(client.getAllDrinks());
        }

        // GET: Drink/Details/5
        public ActionResult Details(int drinkId)
        {

            return View(client.GetDrink(drinkId));
        }

        // GET: Drink/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drink/Create
        [HttpPost]
        public ActionResult Create(Gui.OrderLineServiceRef.OrderLine orderline, int drinkId)
        {
            try
            {
                orderline.Drink = lc.GetDrink(drinkId);
                orderline.TotalPrice = orderline.Drink.Price * orderline.Amount; 
                lc.CreateOrderLine(orderline, orderClient.GetOrderByStatus("Incomplete").ID);
                return RedirectToAction("Index");
            }
            catch
            {
                oCtr.CreateOrder();
                return Create(orderline, drinkId);
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

        public dynamic doBCVM(int id)
        {
            dynamic BCVM = new ExpandoObject();
            BCVM.Drink = client.GetDrink(id);
            BCVM.Ingredients = client.GetDrink(id).Ingredients;
            return BCVM;
        }
    }
}
