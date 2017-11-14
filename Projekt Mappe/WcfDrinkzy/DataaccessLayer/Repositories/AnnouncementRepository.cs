using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellayer;
using DataaccessLayer.Interface;

namespace DataaccessLayer.Repositories
{
   public class AnnouncementRepository
    {
        DbContext db = new DbContext();

        public void Add(Announcement entity)
        {
            db.Announcements.Add(entity);
            db.SaveChanges();
        }

        public IEnumerable<Announcement> Find(string queryString)
        {
            return db.Announcements.Where(x => x.Title.ToLower().Contains(queryString.ToLower()));
        }

        public Announcement Get(int id, bool includeRelations)
        {
            return db.Announcements.Find(id);
        }

        public IEnumerable<Announcement> GetAll()
        {
            return db.Announcements;
        }

        public void Remove(Announcement entity)
        {
            db.Announcements.Remove(entity);
            db.SaveChanges();
        }

        public void Update(Announcement entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}

