using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    abstract class Client
    {
        protected ProjektEntities pe = new ProjektEntities();
        abstract public bool addClient(string name, string surname, string city, string street, string houseNo, string locumNo, string phoneNo, string mail);
    }
}
