using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DBLayer;

namespace BusinessLayer
{
    public class IngredientController
    {
        private IngredientsDB db = new IngredientsDB();

        public void createIngredient(Ingredient i)
        {
            db.CreateIngredient(i);
        }

        public Ingredient GetIngredient(int id)
        {
            return db.GetIngredient(id);
        }

        public IEnumerable<Ingredient> getAllIngredients()
        {
            return db.GetAllIngredients();
        }
    }
}
