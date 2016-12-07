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
            User user = new User();
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var repairCard = new DeviceRepairCards { damage_desc = damageDesc, repaired = false, created_at = DateTime.Now, updated_at = DateTime.Now, device_id = id, place_id = user.from(user.getCurrentUserId())};
                    pe.DeviceRepairCards.Add(repairCard);
                    pe.SaveChanges();
                }
                return true;
            }
            catch { return false; }
        }
        public DataTable list(bool repaired, bool diagnosis, bool note)
        {
            User user = new User();
            List<DeviceRepairCards> list;
            ProjektEntities pe = new ProjektEntities();
            int diagnosisLength = diagnosis == true ? 1 : 0;
            if (user.isSuperadmin())
                list = pe.DeviceRepairCards.Where(drc => drc.repaired == repaired).ToList();
            else
            {
                int from = user.from(user.getCurrentUserId());
                list = pe.DeviceRepairCards.Where(drc => drc.repaired == repaired).Where(drc => drc.place_id == from).ToList();
            }
            DataTable table = DataHelper.ToDataTable<DeviceRepairCards>(list);
            table.Columns.Add();
            return table;
        }
        public bool diagnosis(int id, string diag)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var drc = pe.DeviceRepairCards.Find(id);
                    drc.diagnosis = diag;
                    drc.updated_at = DateTime.Now;
                    pe.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool note(int id, string note)
        {
            try
            {
                using (ProjektEntities pe = new ProjektEntities())
                {
                    var drc = pe.DeviceRepairCards.Find(id);
                    drc.repair_note = note;
                    drc.updated_at = DateTime.Now;
                    pe.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool makeRepaired(int id)
        {
            try
            {
                using (ProjektEntities pe = new ProjektEntities())
                {
                    var drc = pe.DeviceRepairCards.Find(id);
                    drc.repaired = true;
                    drc.updated_at = DateTime.Now;
                    pe.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
