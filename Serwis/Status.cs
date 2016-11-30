using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class Status
    {
        public bool add(string statusName)
        {
            try
            {
                var status = new Statuses { name = statusName };
                using (ProjektEntities pe = new ProjektEntities())
                {
                    pe.Statuses.Add(status);
                    pe.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Array list()
        {
            using (ProjektEntities pe = new ProjektEntities())
            {
                return pe.Statuses.OrderBy(p => p.Id).ToArray();
            }
        } 
        public bool edit(int id, string statusName)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var status = pe.Statuses.Find(id);
                    status.name = statusName;
                    pe.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(int id)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var status = pe.Statuses.Find(id);
                    pe.Statuses.Remove(status);
                    pe.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string getName(int id)
        {
            using(ProjektEntities pe = new ProjektEntities())
            {
                return pe.Statuses.Find(id).name;
            }
        }
    }
}
