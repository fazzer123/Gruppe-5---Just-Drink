using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using DataaccessLayer.Interface;
using DataaccessLayer.Repositories;

namespace BusinessLayer
{
    public class AnnouncementController : ICRUD<Announcement>
    {
        AnnouncementRepository aRep = new AnnouncementRepository();
        public void Add(Announcement entity)
        {
            aRep.Add(entity);
        }

        public IEnumerable<Announcement> Find(string queryString)
        {
            return aRep.Find(queryString);
        }

        public Announcement Get(int id, bool includeRelations)
        {
            return aRep.Get(id, includeRelations);
        }

        public IEnumerable<Announcement> GetAll()
        {
            return aRep.GetAll();
        }

        public void Remove(Announcement entity)
        {
            aRep.Remove(entity);
        }

        public void Update(Announcement entity)
        {
            aRep.Update(entity);
        }
    }
}