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

        public OrderLineController()
        {
            olDb = new OrderLineDB();
        }

        public void CreateOrderLine(OrderLine OrderLine)
        {
            olDb.CreateOrderLine(OrderLine);
        }

        public OrderLine GetOrderLine(int ID)
        {
            return olDb.GetOrderLine(ID);
        }
        public IEnumerable<OrderLine> GetAllOrderLines()
        {
            return olDb.GetAllOrderLines();
        }

    }
}

