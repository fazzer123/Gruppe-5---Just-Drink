using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataaccessLayer.Interface
{
    public interface ICRUD<T>
    {
        void Add(T entity);
        T Get(int id, bool includeRelations);
        void Remove(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(string queryString);
    }
}
