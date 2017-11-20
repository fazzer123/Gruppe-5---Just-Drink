﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }

        public List<Drink> FavoritesDrinks { get; set; }

        public User(int ID, string UserName, string FirstName, string LastName, string Gender, DateTime Birthday, string Password, string Email, string Phone)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Birthday = Birthday;
            this.Password = Password;
            this.Email = Email;
            this.Phone = Phone;
        }
        public User()
        {

        }

        public void addDrinkToFavorites(Drink d)
        {
            FavoritesDrinks.Add(d);
        }
    }
}
