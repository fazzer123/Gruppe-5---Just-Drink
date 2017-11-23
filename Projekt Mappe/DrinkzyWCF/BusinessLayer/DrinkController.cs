using DBLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DrinkController
    {
        DrinkDB dDb;

        public DrinkController()
        {
            dDb = new DrinkDB();
        }

        public void CreateDrink(Drink drink)
        {
            dDb.CreateDrink(drink);
        }

        public Drink GetDrink(int id)
        {
            return dDb.GetDrink(id);
        }

        public IEnumerable<Drink> getAllDrinks()
        {
            return dDb.getAllDrinks();
        }

        public void UpdateDrink(Drink drink)
        {
            dDb.UpdateDrink(drink);
        }

        public void DeleteDrinkById(int DrinkId)
        {
            dDb.DeleteDrinkById(DrinkId);
        }

        public void AddIngredientToDrink(int ingredientID, Drink drink)
        {
            dDb.AddIngredientToDrink(ingredientID, drink);
        }

        public void DeleteIngredientFromDrink(int ingredientID, Drink drink)
        {
            dDb.DeleteIngredientFromDrink(ingredientID, drink);
        }
    }
}
