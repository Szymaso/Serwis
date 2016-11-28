using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class DeviceCard
    {
        DevicesCards device;
        public bool add(bool firm, string model, string manufacturer, string serialNo, int deviceType, int clientId)
        {
            // TODO: Add statuses
            try
            {
                if (firm == true)
                {
                    device = new DevicesCards { manufacturer = manufacturer, model = model, serial_no = serialNo, status_id = 0, firm_id = clientId, created_at = DateTime.Now, updated_at = DateTime.Now };
                }
                else
                {
                    device = new DevicesCards { manufacturer = manufacturer, model = model, serial_no = serialNo, status_id = 0, client_id = clientId, created_at = DateTime.Now, updated_at = DateTime.Now };
                }

                using (ProjektEntities pe = new ProjektEntities())
                {                        
                    pe.DevicesCards.Add(device);
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
