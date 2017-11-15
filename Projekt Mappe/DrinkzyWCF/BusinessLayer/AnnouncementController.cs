using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;

namespace BusinessLayer
{
   public class AnnouncementController
    {
        AnnouncementDB aDb;

        public AnnouncementController()
        {
            aDb = new AnnouncementDB();
        }

        public void CreateAnnouncement(Announcement announcement)
        {
            aDb.CreateAnnouncement(announcement);
        }

        public Announcement GetAnnouncement(string Title)
        {
            return aDb.GetAnnouncement(Title);
        }
        public IEnumerable<Announcement> GetAllAnnouncements()
        {
            return aDb.GetAllAnnouncements();
        }

    }
}
