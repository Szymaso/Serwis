using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;

namespace Serwis
{
    class User
    {
        ProjektEntities pe = new ProjektEntities();

        private static int currentUserId = 0;
        public bool login(string username, string password)
        {
            try
            {
                password = generateSha1(password);
                var user = pe.Users.FirstOrDefault(u => u.name == username && u.password == password);
                if (user != null)
                {
                    currentUserId = user.Id;
                    return true;
                }
            } catch { return false; }
            return false;
        }

        // Generate SHA1 hash from string
        private string generateSha1(string password)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                string hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
        public int getCurrentUserId()
        {
            return currentUserId;
        }
        public bool isAdmin()
        {
            if (pe.Users.Find(currentUserId).access_level == 0)
                return false;
            return true;
        }

        public bool isSuperadmin()
        {
            if (pe.Users.Find(currentUserId).access_level != 2)
                return false;
            return true;
        }

        public int from(int id)
        {
            return pe.Users.Find(id).place_id;
        }

        public bool add(string username, string password, int access_level, string place)
        {
            int placeId = pe.Places.FirstOrDefault(p => p.address == place).id;
            Users user = new Users { name = username, password = generateSha1(password), access_level = Convert.ToByte(access_level), place_id = placeId, created_at = DateTime.Now, updated_at = DateTime.Now };
            pe.Users.Add(user);
            try
            {
                pe.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable listUsers()
        {
            List<Users> list;
            if (isSuperadmin())
                list = pe.Users.ToList();
            else
            {
                int placeId = from(currentUserId);
                list = pe.Users.Where(u => u.place_id == placeId).ToList();
            }
            DataTable table = DataHelper.ToDataTable<Users>(list);
            table.Columns.Add();
            return table;
        }
        public object[] getData(int id)
        {
            Users u = new Users();
            u = pe.Users.Find(id);
            object[] table = { u.name, new Place().getAddress(u.place_id), u.access_level};
            return table;
        }
        public bool edit(int id, string name, string password, int type, string place)
        {
            var user = pe.Users.Find(id);
            user.name = name;
            user.password = this.generateSha1(password);
            user.access_level = Convert.ToByte(type);
            user.place_id = new Place().getPlaceId(place);
            try
            {
                pe.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool edit(int id, string name, int type, string place)
        {
            var user = pe.Users.Find(id);
            user.name = name;
            user.access_level = Convert.ToByte(type);
            user.place_id = new Place().getPlaceId(place);
            try
            {
                pe.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(int id)
        {
            var user = pe.Users.Find(id);
            try
            {
                pe.Users.Remove(user);
                pe.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
