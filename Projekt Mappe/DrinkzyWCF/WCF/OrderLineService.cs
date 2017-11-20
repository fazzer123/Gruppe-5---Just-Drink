using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLayer;

namespace WCF
{
    public class OrderLineService : IOrderLineService
        
    {
        OrderLineController olCtr;

        public OrderLineService()
        {
            olCtr = new OrderLineController();
        }
        public void CreateOrderLine(OrderLine orderline, int orderID)
        {
            olCtr.CreateOrderLine(orderline, orderID);
        }

        public IEnumerable<OrderLine> GetAllOrderlines()
        {
           return olCtr.GetAllOrderLines();
        }

        public Drink GetDrink(int id)
        {
            return olCtr.getDrink(id);
        }

        public OrderLine GetOrderLine(int ID)
        {
           return olCtr.GetOrderLine(ID);
        }

        public void DeleteOrderLineByID(int OrderLineID)
        {
            olCtr.DeleteOrderLineByID(OrderLineID);
        }
    }
}
