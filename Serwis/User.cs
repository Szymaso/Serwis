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
            foreach (var user in pe.Users)
            {
                if (user.name == username && user.password == this.generateSha1(password))
                {
                    currentUserId = user.Id;
                    return true;
                }
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

        public bool add(string name, string password, int place_id, int access_level)
        {

            return true;
        }
    }
}
