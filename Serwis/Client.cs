using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    abstract class Client
    {
        abstract public bool addClient(string name, string surname, string city, string street, string houseNo, string locumNo, string phoneNo, string mail);
        abstract public string getName(int id);
    }
}
