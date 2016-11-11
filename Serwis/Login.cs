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
    public partial class Login : Form
    {
        Home home;
        public Login(Home h)
        {
            InitializeComponent();
            this.home = h;
            AcceptButton = login_button;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.login_button.Enabled = false;
            User u = new User();
            if (!u.login(user_name.Text, user_password.Text))
            {
                error_label.Text = "Podano nieprawidłowe dane\nlub wystąpił problem z serwerem";
                this.login_button.Enabled = true;
            }
            else
            {
                home.WindowState = FormWindowState.Maximized;
                home.ShowInTaskbar = true;
                this.Close();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            home.Close();
        }
    }
}
