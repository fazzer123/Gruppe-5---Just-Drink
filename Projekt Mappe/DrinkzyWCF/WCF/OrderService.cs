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
            oCtr.CreateOrder(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return oCtr.getAllOrders();
        }

        public Order GetOrder(int ID)
        {
            return oCtr.GetOrder(ID);
        }

        public void CompleteOrder(Order order)
        {
            oCtr.CompleteOrder(order);
        }

        public Order GetOrderByStatus(string status)
        {
            return oCtr.GetOrderByStatus(status);
        }
        public User GetUser(int id)
        {
            return oCtr.getUser(id);
        }

        public Customer GetCustomer(int id)
        {
            return oCtr.getCustomer(id);
        }
    }
}
