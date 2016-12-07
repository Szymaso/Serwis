using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        public DataTable list(bool repaired)
        {
            List<DeviceRepairCards> list;
            ProjektEntities pe = new ProjektEntities();
            list = pe.DeviceRepairCards.Where(drc => drc.repaired == repaired).ToList();
            DataTable table = DataHelper.ToDataTable<DeviceRepairCards>(list);
            table.Columns.Add();
            table.Columns.Add();
            table.Columns.Add();
            return table;
        }
    }
}
