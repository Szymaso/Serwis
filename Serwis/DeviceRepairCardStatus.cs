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
    public partial class DeviceRepairCardStatus : Form
    {
        Home home;
        private int id;
        public DeviceRepairCardStatus(Home h, int id)
        {
            InitializeComponent();
            this.home = h;
            this.id = id;
            foreach (var status in new ProjektEntities().Statuses)
                this.comboBox1.Items.Add(new ComboBoxItem(status.name, status.Id));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("Wybierz status z listy");
            }
            else
            {
                if(new DeviceCard().statusChange(id, ((ComboBoxItem)this.comboBox1.SelectedItem).HiddenValue))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Zmieniono status";
                    home.notifyIcon1.BalloonTipTitle = "Serwis";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.Close();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas zmiany statusu.";
                    home.notifyIcon1.BalloonTipTitle = "Serwis";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
        }
    }
}
