using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellayer
{
    public class Ingredients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Procent { get; set; }
        public virtual List<Drink> Drinks { get; set; }
    }
}
