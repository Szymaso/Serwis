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
    public partial class UserAdd : Form
    {
        Home home;
        public UserAdd(Home h)
        {
            InitializeComponent();
            this.home = home;
            AcceptButton = addUser_button;
            User u = new User();
            if (!u.isSuperadmin())
                user_type.Items.Remove("Superadministrator");
            user_type.Text = user_type.Items[0].ToString();
        }
    }
}
