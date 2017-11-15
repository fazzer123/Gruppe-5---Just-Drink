using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
   public class Storage
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public int MaxAmount { get; set; }
        [DataMember]
        public int MinAmount { get; set; }
    }
}
