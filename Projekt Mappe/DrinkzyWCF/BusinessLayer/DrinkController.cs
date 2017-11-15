﻿using DBLayer;
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

        public Drink GetDrink(string name)
        {
            return dDb.GetDrink(name);
        }

        public IEnumerable<Drink> getAllDrinks()
        {
            return dDb.getAllDrinks();
        }
    }
}
