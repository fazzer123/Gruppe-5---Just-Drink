using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace BusinessLayer
{
    public class OrderController
    { 
    OrderDB oDb;

    public OrderController()
    {
        oDb = new OrderDB();
    }

    public void CreateOrder(Order order)
    {
        oDb.CreateOrder(order);
    }

    public Order GetOrder(int ID)
    {
        return oDb.GetOrder(ID);
    }
    public IEnumerable<Order> getAllOrders()
    {
        return oDb.GetAllOrders();
    }
}
}
    

