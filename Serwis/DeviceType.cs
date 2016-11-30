using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class DeviceType : Inameable
    {
        public bool add(string type)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    DeviceTypes deviceType = new DeviceTypes { type = type };
                    pe.DeviceTypes.Add(deviceType);
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
            using(ProjektEntities pe = new ProjektEntities())
            {
                return pe.DeviceTypes.OrderBy(p => p.Id).ToArray();
            }
        }
        public bool edit(int id, string type)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var deviceType = pe.DeviceTypes.Find(id);
                    deviceType.type = type;
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
                    var deviceType = pe.DeviceTypes.Find(id);
                    pe.DeviceTypes.Remove(deviceType);
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
                return pe.DeviceTypes.Find(id).type;
            }
        }
    }
}
