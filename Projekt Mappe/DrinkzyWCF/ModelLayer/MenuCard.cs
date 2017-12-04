using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class MenuCard
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public Customer Customer { get; set; }
        [DataMember]
        public List<Drink> Drinks { get; set; }
        [DataMember]
        public List<Alchohol> alchohols { get; set; }

        public MenuCard() { }

        public MenuCard(int ID, Customer Customer)
        {
            this.ID = ID;
            this.Customer = Customer;
            Drinks = new List<Drink>();
            alchohols = new List<Alchohol>();
        }

        public void addDrink(Drink d)
        {
            Drinks.Add(d);
        }
    }
}
