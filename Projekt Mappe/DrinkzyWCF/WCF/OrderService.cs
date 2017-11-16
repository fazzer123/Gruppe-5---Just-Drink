using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLayer;

namespace WCF
{
    public class OrderService : IOrderService
    {
        OrderController oCtr = new OrderController();
        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int ID)
        {
            return oCtr.GetOrder(ID);
        }
    }
}
