using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace WCF
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void CreateOrder(Order order);

        [OperationContract]
        Order GetOrder(int ID);

        [OperationContract]
        IEnumerable<Order> GetAllOrders();
        
    }
}
