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
        public string Title { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Img { set; get; }
        

        public Announcement(string Title, string Text, DateTime Date, string Img)
        {
            this.Title = Title;
            this.Text = Text;
            this.Date = Date;
            this.Img = Img;
        }

        public Announcement()
        {

        }
    }
}
