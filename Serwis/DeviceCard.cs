﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Serwis
{
    class DeviceCard
    {
        DevicesCards device;
        public bool add(bool firm, string model, string manufacturer, string serialNo, int deviceType, int statusId, int clientId)
        {
            // TODO: Add statuses
            try
            {
                if (firm == true)
                {
                    device = new DevicesCards { manufacturer = manufacturer, model = model, serial_no = serialNo, type_id = deviceType, status_id = statusId, firm_id = clientId, created_at = DateTime.Now, updated_at = DateTime.Now };
                }
                else
                {
                    device = new DevicesCards { manufacturer = manufacturer, model = model, serial_no = serialNo, type_id = deviceType, status_id = statusId, client_id = clientId, created_at = DateTime.Now, updated_at = DateTime.Now };
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
        public DataTable list()
        {
            List<DevicesCards> list;
            ProjektEntities pe = new ProjektEntities();
            list = pe.DevicesCards.ToList();
            DataTable table = DataHelper.ToDataTable<DevicesCards>(list);
            table.Columns.Add();
            table.Columns.Add();
            table.Columns.Add();
            return table;
        }
        public DevicesCards getDeviceData(int id)
        {
            using(ProjektEntities pe = new ProjektEntities())
            {
                return pe.DevicesCards.Find(id);
            }
        }
        public bool statusChange(int id, int status)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var dc = pe.DevicesCards.Find(id);
                    dc.status_id = status;
                    dc.updated_at = DateTime.Now;
                    pe.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                //System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
