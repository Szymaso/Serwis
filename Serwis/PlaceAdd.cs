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
    public partial class PlaceAdd : Form
    {
        Home home;
        public PlaceAdd(Home h)
        {
            InitializeComponent();
            this.home = h;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.addButton.Enabled = false;
            if (String.IsNullOrEmpty(this.address.Text))
                MessageBox.Show("Musisz podać nazwę uzytkownika");
            else
            {
                if (new Place().add(this.address.Text))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Dodano miejsce " + this.address.Text;
                    home.notifyIcon1.BalloonTipTitle = "Nowe miejsce";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.Close();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania nowego miejsca. ";
                    home.notifyIcon1.BalloonTipTitle = "Nowe miejsce";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
            this.addButton.Enabled = true;

        }
    }
}
