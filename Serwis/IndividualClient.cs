using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class IndividualClient : Client
    {
        override public bool addClient(string name, string surname, string city, string street, string houseNo, string locumNo, string phoneNo, string mail)
        {
            try
            {
                using (ProjektEntities pe = new ProjektEntities())
                {
                    Clients client = new Clients { name = name, surname = surname, city = city, street = street, house_no = houseNo, locum_no = locumNo, phone = phoneNo, mail = mail, created_at = DateTime.Now, updated_at = DateTime.Now };
                    pe.Clients.Add(client);
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
                return pe.Clients.OrderBy(f => f.Id).ToArray();
            }
        }
        /*
         * int column
         *      1 - name
         *      2 - surname
         *      3 - city
         *      4 - street
         *      5 - houseNo
         *      6 - locumNo
         *      7 - phone
         *      8 - mail
         */
        public bool edit(int column, int id, string value)
        {
            try
            {
                using (ProjektEntities pe = new ProjektEntities())
                {
                    var client = pe.Clients.Find(id);
                    switch (column)
                    {
                        case 1: client.name = value; break;
                        case 2: client.surname = value; break;
                        case 3: client.city = value; break;
                        case 4: client.street = value; break;
                        case 5: client.house_no = value; break;
                        case 6: client.locum_no = value; break;
                        case 7: client.phone = value; break;
                        case 8: client.mail = value; break;
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
                using (ProjektEntities pe = new ProjektEntities())
                {
                    var client = pe.Clients.Find(id);
                    pe.Clients.Remove(client);
                    pe.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        override public string getName(int id)
        {
            using(ProjektEntities pe = new ProjektEntities())
            {
                var client = pe.Clients.Find(id);
                return client.name + " " + client.surname + " ( indywidualny - " + client.Id + ")";
            }
        }
    }
}
