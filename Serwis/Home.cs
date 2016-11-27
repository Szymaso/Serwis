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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            User u = new User();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            new Login(this).Show();
        }
        private void Home_Activated(object sender, EventArgs e)
        {
            User u = new User();
            if(u.isAdmin())
            {
                this.userToolStripMenuItem.Visible = true;
                this.dodajNowyTypSprzętuToolStripMenuItem.Visible = true;
                this.listaTypówSprzętuToolStripMenuItem.Visible = true;
            }
            if (u.isSuperadmin())
            {
                this.miejscaToolStripMenuItem.Visible = true;
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserAdd(this).Show();
        }

        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList list = new UserList(this);
            list.Dock = DockStyle.Fill;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(list);
        }
        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PlaceAdd(this).Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PlaceList list = new PlaceList(this);
            list.Dock = DockStyle.Fill;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(list);
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddClient(this).Show();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FirmClientList list = new FirmClientList(this);
            list.Dock = DockStyle.Fill;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(list);
        }

        private void listaIndywidualnychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualClientList list = new IndividualClientList(this);
            list.Dock = DockStyle.Fill;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(list);
        }

        private void dodajNowyTypSprzętuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeviceTypeAdd(this).Show();
        }

        private void listaTypówSprzętuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceTypeList list = new DeviceTypeList(this);
            list.Dock = DockStyle.Fill;
            homePanel.Controls.Clear();
            homePanel.Controls.Add(list);
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeviceCardAdd(this).Show();
        }
    }
}
