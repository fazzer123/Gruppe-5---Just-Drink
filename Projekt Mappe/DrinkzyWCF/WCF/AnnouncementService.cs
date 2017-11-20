using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLayer;

namespace WCF
{
    public class AnnouncementService : IAnnouncementService
    {
        AnnouncementController aCtr;

        public AnnouncementService()
        {
            aCtr = new AnnouncementController();
        }
        public void CreateAnnouncement(Announcement announcement)
        {
            aCtr.CreateAnnouncement(announcement);
        }

        public Announcement GetAnnouncement(int id)
        {
            return aCtr.GetAnnouncement(id);
        }
        public IEnumerable<Announcement> GetAllAnnouncements()
        {
            return aCtr.GetAllAnnouncements();
        }
            
    }
}
