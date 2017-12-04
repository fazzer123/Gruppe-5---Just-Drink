using DBLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AlchoholController
    {
        AlchoholDB aDB;

        public AlchoholController()
        {
            aDB = new AlchoholDB();
        }

        public void CreateAlchohol(Alchohol alchohol)
        {
            aDB.CreateAlchohol(alchohol);
        }

        public Alchohol GetAlchohol(int id)
        {
            return aDB.GetAlchohol(id);
        }

        public IEnumerable<Alchohol> GetAllAlchohol()
        {
            return aDB.GetAllAlchohols();
        }
    }
}
