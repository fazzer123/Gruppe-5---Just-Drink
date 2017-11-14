using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using BusinessLayer;

namespace WcfDrinkzy
{
    class ServiceAnnouncement : IServiceAnnouncement

    {
        AnnouncementController aCtr = new AnnouncementController();

        public void CreateAnnouncement(Announcement Announcement)
        {
            aCtr.Add(Announcement);
        }

        public void DeleteAnnouncement(Announcement announcement)
        {
            aCtr.Remove(announcement);
        }

        public IEnumerable<Announcement> GetAnnouncement(string Title)
        {
            return aCtr.Find(Title);
        }

        public IEnumerable<Announcement> GetAnnouncementList()
        {
            return aCtr.GetAll();
        }


    }
}

