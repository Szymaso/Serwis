using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class DeviceRepairCard
    {
        public bool add(int id, string damageDesc)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var repairCard = new DeviceRepairCards { damage_desc = damageDesc, repaired = false, created_at = DateTime.Now, updated_at = DateTime.Now, device_id = id};
                    pe.DeviceRepairCards.Add(repairCard);
                    pe.SaveChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
