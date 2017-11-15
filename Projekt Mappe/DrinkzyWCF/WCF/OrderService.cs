using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace WCF
{
    public class OrderService : IOrderService
    {
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
            throw new NotImplementedException();
        }
    }
}
