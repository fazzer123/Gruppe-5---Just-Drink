using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using BusinessLayer;

namespace WCF
{
    public class AnnouncementService
    {
        Announcement aCtr;

        public AnnouncementService()
        {
            aCtr = new AnnouncementController();
        }
        public void CreateAnnouncement(AnnouncementService announcement)
        {
            aCtr.CreateAnnouncement(announcement);
        }

        public Announcement GetAnnouncement(string Title)
        {
            return aCtr.GetAnnouncement(Title);
        }
    }
}
