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

        private void editButton_Click(object sender, EventArgs e)
        {
            this.editButton.Enabled = false;
            int t = 0;
            switch (type.Text)
            {
                case "Administrator": t = 1; break;
                case "Superadministrator": t = 2; break;
                default: t = 0; break;
            }
            bool status;
            User u = new User();
            if (password.Text.Length > 0)
                status = u.edit(this.userid, name.Text, password.Text, t, place.Text);
            else
                status = u.edit(this.userid, name.Text, t, place.Text);
            if (status)
            {
                home.notifyIcon1.Icon = SystemIcons.Application;
                home.notifyIcon1.BalloonTipText = "Edytowano użytkownika " + name.Text;
                home.notifyIcon1.BalloonTipTitle = "Edycja użytkownika";
                home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                home.notifyIcon1.Visible = true;
                home.notifyIcon1.ShowBalloonTip(3000);
                ul.display();
                this.Close();
            }
            else
            {
                home.notifyIcon1.Icon = SystemIcons.Exclamation;
                home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas edycji użytkownika";
                home.notifyIcon1.BalloonTipTitle = "Edycja użytkownik";
                home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                home.notifyIcon1.Visible = true;
                home.notifyIcon1.ShowBalloonTip(3000);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            User u = new User();
            if (u.delete(this.userid))
            {
                home.notifyIcon1.Icon = SystemIcons.Application;
                home.notifyIcon1.BalloonTipText = "Usunięto użytkownika";
                home.notifyIcon1.BalloonTipTitle = "Edycja użytkownika";
                home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                home.notifyIcon1.Visible = true;
                home.notifyIcon1.ShowBalloonTip(3000);
                ul.display();
                this.Close();
            }
            else
            {
                home.notifyIcon1.Icon = SystemIcons.Exclamation;
                home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas usuwania użytkownika";
                home.notifyIcon1.BalloonTipTitle = "Edycja użytkownik";
                home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                home.notifyIcon1.Visible = true;
                home.notifyIcon1.ShowBalloonTip(3000);
            }
        }
    }
}
