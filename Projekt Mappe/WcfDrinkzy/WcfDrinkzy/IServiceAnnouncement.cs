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
        IEnumerable<ServiceAnnouncement> GetAnnouncement(string name);

        [OperationContract]
        IEnumerable<ServiceAnnouncement> GetAnnouncementList();

        [OperationContract]
        void CreateAnnoucement(ServiceAnnouncement Annoucement);

        [OperationContract]
        void DeleteAnnoucement(ServiceAnnouncement Annoucement);
    }
}
