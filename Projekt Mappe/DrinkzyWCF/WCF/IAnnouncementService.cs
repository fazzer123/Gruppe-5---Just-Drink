using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ModelLayer;
using System.Threading.Tasks;

namespace WCF
{ 
    
        [ServiceContract]
        public interface IAnnouncementService
        {
            [OperationContract]
            void CreateAnnouncement(Announcement announcement);

            [OperationContract]
            Announcement GetAnnouncement(int id);

        [OperationContract]
            IEnumerable<Announcement> GetAllAnnouncements();
    }
}


