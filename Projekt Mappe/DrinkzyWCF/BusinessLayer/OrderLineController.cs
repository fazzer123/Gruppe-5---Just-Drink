using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class OrderLineController
    {
        OrderLineDB olDb;
        DrinkController dCtr = new DrinkController();

        public OrderLineController()
        {
            olDb = new OrderLineDB();
        }

        public Drink getDrink(int id)
        {
            return dCtr.GetDrink(id);
        }

        public void CreateOrderLine(OrderLine OrderLine, int orderID)
        {
            olDb.CreateOrderLine(OrderLine, orderID);
        }

        public OrderLine GetOrderLine(int ID)
        {
            return olDb.GetOrderLine(ID);
        }
        public IEnumerable<OrderLine> GetAllOrderLines()
        {
            return olDb.GetAllOrderLines();
        }

        public void DeleteOrderLineByID(int OrderLineID)
        {
            olDb.DeleteOrderLineByID(OrderLineID);
        }

    }
}

