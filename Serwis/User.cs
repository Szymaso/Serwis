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

        private int currentUserId;

        public bool login(string username, string password)
        {
            foreach (var user in pe.Users)
            {
                if (user.name == username && user.password == this.generateSha1(password))
                {
                    this.currentUserId = user.Id;
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
    }
}
