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
            this.home = h;
            AcceptButton = addUser_button;
            User u = new User();
            if (!u.isSuperadmin())
                user_type.Items.Remove("Superadministrator");
            user_type.Text = user_type.Items[0].ToString();
            ProjektEntities pe = new ProjektEntities();
            if (u.isAdmin())
            {
                this.placeBox.Items.Add(new Place().getAddress(u.from(u.getCurrentUserId())));
                this.placeBox.Text = this.placeBox.Items[0].ToString();
            }
            if (u.isSuperadmin())
            {
                this.placeBox.Items.Remove(new Place().getAddress(u.from(u.getCurrentUserId())));
                foreach (var place in pe.Places)
                    this.placeBox.Items.Add(place.address);
            }
        }

        private void addUser_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user_name.Text))
                MessageBox.Show("Musisz podać nazwę uzytkownika");
            else if (user_password.Text.Length < 5)
                MessageBox.Show("Hasło musi być dłuższe niż 4 znaki");
            else if (String.IsNullOrEmpty(placeBox.Text))
                MessageBox.Show("Musisz podać nazwę uzytkownika");
            else
            {
                int type = 0;
                switch (user_type.Text)
                {
                    case "Administrator": type = 1; break;
                    case "Superadministrator": type = 2; break;
                    default: type = 0; break;
                }
                User user = new User();
               if (user.add(user_name.Text, user_password.Text, type, placeBox.Text))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Dodano użytkownika " + user_name.Text;
                    home.notifyIcon1.BalloonTipTitle = "Nowy użytkownik";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.Close();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania nowego użytkownika. Upewnij się czy nazwa użytkownika nie jest zajęta.";
                    home.notifyIcon1.BalloonTipTitle = "Nowy użytkownik";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
        }
    }
}
