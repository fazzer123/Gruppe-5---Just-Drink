using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Drink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Img { get; set; }
        public virtual List<Ingredients> Ingredientses { get; set; }
        public virtual List<Menucard> Menucards { get; set; }
        public virtual List<Favourite> Favourites { get; set; }
    }
}
