using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Modellayer;

namespace WcfDrinkzy
{
    [ServiceContract]
    interface IServiceIngredients
    {
        [OperationContract]
        IEnumerable<Ingredients> GetIngredients(string name);

        [OperationContract]
        IEnumerable<Ingredients> GetIngredientsList();

        [OperationContract]
        void CreateIngredients(Ingredients Ingredients);

        [OperationContract]
        void DeleteIngredients(Ingredients Ingredients);
    }
}
