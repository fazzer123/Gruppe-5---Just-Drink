using DBLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HelflaskController
    {
        HelFlaskDB hfDB = new HelFlaskDB();

        public HelFlask GetHelflask(int id)
        {
            return hfDB.GetHelFlask(id);
        }
    }
}
