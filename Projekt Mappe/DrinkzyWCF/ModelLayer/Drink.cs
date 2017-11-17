﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class Drink
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string Img { get; set; }
        [DataMember]
        public List<Ingredient> Ingredients  { get; set; }

        public Drink(int ID, string Name, string Description, decimal Price, string Img)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Img = Img;
            Ingredients = new List<Ingredient>();
        }

        public Drink()
        {

        }
    }
}
