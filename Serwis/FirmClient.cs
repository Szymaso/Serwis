using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class FirmClient : Client
    {
        override public bool addClient(string name, string surname, string city, string street, string houseNo, string locumNo, string phoneNo, string mail)
        {
            try
            {
                Firms firm = new Firms { name = name, nip = surname, city = city,street = street, house_no = houseNo, locum_no = locumNo, phone = phoneNo, mail = mail, created_at = DateTime.Now, updated_at = DateTime.Now };
                pe.Firms.Add(firm);
                pe.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString());
                return false;
            }            
        }
        public Array list()
        {
            return pe.Firms.OrderBy(f => f.Id).ToArray();
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
        public bool edit(int column, string value)
        {

        }
    }
}
