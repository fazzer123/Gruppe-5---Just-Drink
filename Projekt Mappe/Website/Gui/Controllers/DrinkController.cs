using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gui.DrinkServiceRef;
using Gui.OrderLineServiceRef;
using Gui.OrderServiceRef;
using Gui.WalletServiceRef;
using Gui.FavoritServiceRef;
using System.Dynamic;

namespace Gui.Controllers
{
    public class DrinkController : Controller
    {
        private DrinkServiceClient client = new DrinkServiceClient();
        private OrderLineServiceClient lc = new OrderLineServiceClient();
        private OrderServiceClient orderClient = new OrderServiceClient();
        private OrderController oCtr = new OrderController();
        private WalletServiceClient walletClient = new WalletServiceClient();

        // GET: Drink
        public ActionResult Index()
        {
            return View(client.getAllDrinks());
        }

        public ActionResult AlchoholIndex()
        {
            return View(client.GetAllAlchohols());
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
        public ActionResult Create(Gui.OrderLineServiceRef.OrderLine orderline, int drinkId, int cusID)
        {
            if (orderClient.GetOrderByStatus("Incomplete") != null)
            {
                if (orderClient.GetOrderByStatus("Incomplete").Customer.ID == cusID)
                {
                    orderline.Drink = lc.GetDrink(drinkId);
                    orderline.TotalPrice = orderline.Drink.Price * orderline.Amount;
                    lc.CreateOrderLine(orderline, orderClient.GetOrderByStatus("Incomplete").ID);

                    
                    decimal hej = orderline.Drink.Price * orderline.Amount;
                    hej = orderClient.GetOrderByStatus("Incomplete").TotalPrice + hej;
                    orderClient.UpdatePrice(orderClient.GetOrderByStatus("Incomplete"), hej);
                    return RedirectToAction("Details", "Customer", new { id = cusID });
                }
                else if (orderClient.GetOrderByStatus("Incomplete").Customer.ID != cusID)
                {
                    orderClient.DeleteOrderByID(orderClient.GetOrderByStatus("Incomplete").ID);
                    oCtr.CreateOrder(cusID);
                    return Create(orderline, drinkId, cusID);
                }
            }
            else
            {
                oCtr.CreateOrder(cusID);
                return Create(orderline, drinkId, cusID);
            }

            return RedirectToAction("Details", "Customer", new { id = cusID });
        }
        public ActionResult CreateHelflask()
        {
            return View();
        }

        // POST: Drink/Create
        [HttpPost]
        public ActionResult CreateHelflask(Gui.OrderLineServiceRef.OrderLine orderline, int drinkId, int cusID)
        {
            if (orderClient.GetOrderByStatus("Incomplete") != null)
            {
                if (orderClient.GetOrderByStatus("Incomplete").Customer.ID == cusID)
                {
                    orderline.Drink = lc.GetHelflask(drinkId);
                    orderline.TotalPrice = orderline.Drink.Price * orderline.Amount;
                    lc.CreateOrderLineHelflask(orderline, orderClient.GetOrderByStatus("Incomplete").ID);


                    decimal hej = orderline.Drink.Price * orderline.Amount;
                    hej = orderClient.GetOrderByStatus("Incomplete").TotalPrice + hej;
                    orderClient.UpdatePrice(orderClient.GetOrderByStatus("Incomplete"), hej);
                    return RedirectToAction("Details", "Customer", new { id = cusID });
                }
                else if (orderClient.GetOrderByStatus("Incomplete").Customer.ID != cusID)
                {
                    orderClient.DeleteOrderByID(orderClient.GetOrderByStatus("Incomplete").ID);
                    oCtr.CreateOrder(cusID);
                    return CreateHelflask(orderline, drinkId, cusID);
                }
            }
            else
            {
                oCtr.CreateOrder(cusID);
                return Create(orderline, drinkId, cusID);
            }

            return RedirectToAction("Details", "Customer", new { id = cusID });
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

        public IEnumerable<Gui.DrinkServiceRef.Drink> search(string text)
        {
            return client.SearchDrinks(text);
        }

        public ActionResult AddFavorit(int drinkID)
        {
            FavoritesServiceClient fClient = new FavoritesServiceClient();
            fClient.addDrink(1, drinkID);
            return RedirectToAction("Details", new { drinkId = drinkID });
        }
    }
}
