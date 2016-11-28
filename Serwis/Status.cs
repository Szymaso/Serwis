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
    }
}
