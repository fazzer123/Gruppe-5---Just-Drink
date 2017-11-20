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
    public interface IOrderLineService
    {
        [OperationContract]
        void CreateOrderLine(OrderLine orderline, int orderID);

        [OperationContract]
        OrderLine GetOrderLine(int ID);

        [OperationContract]
        IEnumerable<OrderLine> GetAllOrderlines();

        [OperationContract]
        Drink GetDrink(int id);

        [OperationContract]
        void DeleteOrderLineByID(int OrderLineID);
    }
}
