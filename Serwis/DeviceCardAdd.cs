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
    public partial class DeviceCardAdd : Form
    {
        Home home;
        public DeviceCardAdd(Home h)
        {
            InitializeComponent();
            this.home = h;
            foreach (var type in new ProjektEntities().DeviceTypes)
                this.deviceType.Items.Add(new ComboBoxItem(type.type, type.Id));
            foreach (var client in new ProjektEntities().Clients)
                this.name.Items.Add(client.name.ToString() + " " + client.surname.ToString());
        }
        private void isFirm_CheckedChanged(object sender, EventArgs e)
        {
            // Simply way to get id from ComboBox:  ((ComboBoxItem)this.deviceType.SelectedItem).HiddenValue
            if (this.isFirm.Checked == true)
            {
                this.nameLabel.Text = "Nazwa";
                this.name.Items.Clear();
                foreach (var firm in new ProjektEntities().Firms)
                    this.name.Items.Add(firm.name.ToString());
            }
            else
            {
                this.nameLabel.Text = "Imię i nazwisko";
                this.name.Items.Clear();
                foreach (var client in new ProjektEntities().Clients)
                    this.name.Items.Add(client.name.ToString() + " " + client.surname.ToString());
            }
        }
    }
}
