using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Reflection;


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

        public bool isSuperadmin()
        {
            if (pe.Users.Find(currentUserId).access_level != 2)
                return false;
            return true;
        }

        private int from(int id)
        {
            return pe.Users.Find(id).place_id;
        }
        private string getAddress(int id)
        {
            return pe.Places.Find(id).address;
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

        private static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public DataTable listUsers()
        {
            List<Users> list;

            if (isSuperadmin())
                list = pe.Users.ToList();
            else
                list = pe.Users.Where(u => u.place_id == from(currentUserId)).ToList();
            DataTable table = ToDataTable<Users>(list);
            table.Columns[0].ColumnName = "id";
            table.Columns[1].ColumnName = "Nazwa użytkownika";
            table.Columns[2].ColumnName = "Data utworzenia";
            table.Columns[3].ColumnName = "Data ostatniej modyfikacji";
            table.Columns[4].ColumnName = "Poziom uprawnień";
            table.Columns[5].ColumnName = "Miejsce";
            table.Columns.Add();
            return table;
        }
        public object[] getData(int id)
        {
            Users u = new Users();
            u = pe.Users.Find(id);
            object[] table = { u.name, this.getAddress(u.place_id), u.access_level};
            return table;
        }
    }
}
