using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serwis
{
    public partial class UserEdit : Form
    {
        Home home;
        UserList ul;
        private int userid;
        public UserEdit(int id, Home t, UserList ul)
        {
            InitializeComponent();
            this.userid = id;
            this.home = t;
            this.ul = ul;
            AcceptButton = editButton;
            User u = new User();
            if (!u.isSuperadmin())
                type.Items.Remove("Superadministrator");
            user_type.Text = user_type.Items[0].ToString();
            ProjektEntities pe = new ProjektEntities();
            foreach (var place in pe.Places)
                this.place.Items.Add(place.address);
        }
        private void UserEdit_Load(object sender, EventArgs e)
        {
            User u = new User();
            object[] tab = (object[])u.getData(this.userid);
            this.name.Text = tab[0].ToString();
            this.place.Text = tab[1].ToString();
            switch (Convert.ToInt32(tab[2]))
            {
                case 1: type.Text = "Administrator"; break;
                case 2: type.Text = "Superadministrator"; break;
                default: type.Text = "Użytkownik"; break;
            }
        }
    }
}
