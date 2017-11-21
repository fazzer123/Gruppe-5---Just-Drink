﻿using System;
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
        UserController usCtr;
        CustomerController cuCtr;

        public OrderController()
        {
            oDb = new OrderDB();
            usCtr = new UserController();
            cuCtr = new CustomerController();
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

        public void CompleteOrder(Order order)
        {
            oDb.CompleteOrder(order);
        }

        public User getUser(int id)
        {
            return usCtr.GetUser(id);
        }

        public Customer getCustomer(int id)
        {
            return cuCtr.GetCustomer(id);
        }

        public Order GetOrderByStatus(string status)
        {
            return oDb.GetOrderByStatus(status);
        }
    }
}

    
