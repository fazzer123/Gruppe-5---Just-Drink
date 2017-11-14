using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using System.ServiceModel;

namespace WcfDrinkzy
{
    [ServiceContract]
    interface IServiceAnnouncement
    {
        [OperationContract]
        IEnumerable<Announcement> GetAnnouncement(string Title);

        [OperationContract]
        IEnumerable<Announcement> GetAnnouncementList();

        [OperationContract]
        void CreateAnnouncement(Announcement Announcement);

        [OperationContract]
        void DeleteAnnouncement(Announcement announcement);
    }
}
