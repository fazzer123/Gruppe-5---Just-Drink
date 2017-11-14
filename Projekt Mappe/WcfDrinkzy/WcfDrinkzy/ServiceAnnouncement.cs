using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfDrinkzy
{
    class ServiceAnnouncement : IServiceAnnouncement;
    
    {
        public void CreateAnnoucement(ServiceAnnouncement Annoucement)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnnoucement(ServiceAnnouncement Annoucement)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServiceAnnouncement> GetAnnouncement(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServiceAnnouncement> GetAnnouncementList()
        {
            throw new NotImplementedException();
        }
    }
}
