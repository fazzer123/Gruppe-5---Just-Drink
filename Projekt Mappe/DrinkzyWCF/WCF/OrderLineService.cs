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
        public void CreateOrderLine(OrderLine orderline)
        {
            olCtr.CreateOrderLine(orderline);
        }

        public IEnumerable<OrderLine> GetAllOrderlines()
        {
           return olCtr.GetAllOrderLines();
        }

        public OrderLine GetOrderLine(int ID)
        {
           return olCtr.GetOrderLine(ID);
        }
    }
}
