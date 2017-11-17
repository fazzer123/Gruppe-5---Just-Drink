using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class Announcement
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Img { set; get; }
        [DataMember]
        public Customer Customer { get; set; }


        public Announcement(int ID, string Title, string Text, DateTime Date, string Img, Customer Customer)
        {
            this.ID = ID;
            this.Title = Title;
            this.Text = Text;
            this.Date = Date;
            this.Img = Img;
            this.Customer = Customer;
        }

        public Announcement()
        {

        }
    }
}
