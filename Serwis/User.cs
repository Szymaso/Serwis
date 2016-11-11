using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Serwis
{
    class User
    {
        ProjektEntities pe = new ProjektEntities();

        private static int currentUserId = 0;

        public bool login(string username, string password)
        {
            password = generateSha1(password);
            var user = pe.Users.FirstOrDefault(u => u.name == username && u.password == password);
            if (user != null)
            {
                currentUserId = user.Id;
                return true;
            }
            return false;
        }

        // Generate SHA1 hash from string
        public string generateSha1(string password)
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

        public bool isSuperadmin()
        {
            if (pe.Users.Find(currentUserId).access_level != 2)
                return false;
            return true;
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
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
