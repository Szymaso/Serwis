using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis
{
    class Place
    {
        ProjektEntities pe = new ProjektEntities();
        public string getAddress(int id)
        {
            return pe.Places.Find(id).address;
        }
        public int getPlaceId(string address)
        {
            return pe.Places.FirstOrDefault(p => p.address == address).id;
        }
    }
}
