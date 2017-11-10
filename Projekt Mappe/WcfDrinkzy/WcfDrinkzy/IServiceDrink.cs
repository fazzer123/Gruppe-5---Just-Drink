using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using System.ServiceModel;

namespace WcfDrinkzy
{
    [ServiceContract]
    interface IServiceDrink
    {
        [OperationContract]
        IEnumerable<Drink> GetDrink(string name);

        [OperationContract]
        IEnumerable<Drink> GetDrinkList();

        [OperationContract]
        void CreateDrink(Drink Drink);

        [OperationContract]
        void DeleteDrink(Drink Drink);
    }
}
