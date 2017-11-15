﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string CusName { get; set; }
        [DataMember]
        public string Img { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Email { get; set; }

        public Customer(string CusName, string img, string Region, string Adress, string Phone, string Email)
        {
            this.CusName = CusName;
            this.Img = Img;
            this.Region = Region;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
        }
        public Customer()
        {

        }
    }
}
