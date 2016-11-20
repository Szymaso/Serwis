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
                Clients client = new Clients { name = name, surname = surname, city = city, street = street, house_no = houseNo, locum_no = locumNo, phone = phoneNo, mail = mail, created_at = DateTime.Now, updated_at = DateTime.Now };
                pe.Clients.Add(client);
                pe.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
