using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using BusinessLayer;

namespace WcfDrinkzy
{
    class ServiceIngredients : IServiceIngredients
    {
        IngredientsController iCtr = new IngredientsController();

        public void CreateIngredients(Ingredients Ingredients)
        {
            iCtr.Add(Ingredients);
        }

        public void DeleteIngredients(Ingredients Ingredients)
        {
            iCtr.Remove(Ingredients);
        }

        public IEnumerable<Ingredients> GetIngredients(string name)
        {
            return iCtr.Find(name);
        }

        public IEnumerable<Ingredients> GetIngredientsList()
        {
            return iCtr.GetAll();
        }
    }
}
