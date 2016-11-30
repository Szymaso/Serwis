using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class FirmClient : Client, Inameable
    {
        override public bool addClient(string name, string surname, string city, string street, string houseNo, string locumNo, string phoneNo, string mail)
        {
            try
            {
                using (ProjektEntities pe = new ProjektEntities())
                {
                    Firms firm = new Firms { name = name, nip = surname, city = city, street = street, house_no = houseNo, locum_no = locumNo, phone = phoneNo, mail = mail, created_at = DateTime.Now, updated_at = DateTime.Now };
                    pe.Firms.Add(firm);
                    pe.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString());
                return false;
            }            
        }
        public Array list()
        {
            using (ProjektEntities pe = new ProjektEntities())
            {
                return pe.Firms.OrderBy(f => f.Id).ToArray();
            }
        }
        /*
         * int column
         *      1 - name
         *      2 - city
         *      3 - street
         *      4 - houseNo
         *      5 - locumNo
         *      6 - phone
         *      7 - mail
         *      8 - nip
         */
        public bool edit(int column, int id, string value)
        {
            try
            {
                using(ProjektEntities pe = new ProjektEntities())
                {
                    var firm = pe.Firms.Find(id);
                    switch(column)
                    {
                        case 1: firm.name = value; break;
                        case 2: firm.city = value; break;
                        case 3: firm.street = value; break;
                        case 4: firm.house_no = value; break;
                        case 5: firm.locum_no = value; break;
                        case 6: firm.phone = value; break;
                        case 7: firm.mail = value; break;
                        case 8: firm.nip = value; break;
                    }
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
                    var firm = pe.Firms.Find(id);
                    pe.Firms.Remove(firm);
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
            using (ProjektEntities pe = new ProjektEntities())
            {
                var client = pe.Firms.Find(id);
                return client.name + " ( firma - " + client.Id + ")";
            }
        }
    }
}
