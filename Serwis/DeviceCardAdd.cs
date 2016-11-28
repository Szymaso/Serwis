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
                this.name.Items.Add(new ComboBoxItem(client.name.ToString() + " " + client.surname.ToString(), client.Id));
            foreach (var status in new ProjektEntities().Statuses)
                this.status.Items.Add(new ComboBoxItem(status.name.ToString(), status.Id));
        }
        private void isFirm_CheckedChanged(object sender, EventArgs e)
        {
            // Simply way to get id from ComboBox:  ((ComboBoxItem)this.deviceType.SelectedItem).HiddenValue
            if (this.isFirm.Checked == true)
            {
                this.nameLabel.Text = "Nazwa";
                this.name.Items.Clear();
                foreach (var firm in new ProjektEntities().Firms)
                    this.name.Items.Add(new ComboBoxItem(firm.name.ToString(), firm.Id));
            }
            else
            {
                this.nameLabel.Text = "Imię i nazwisko";
                this.name.Items.Clear();
                foreach (var client in new ProjektEntities().Clients)
                    this.name.Items.Add(new ComboBoxItem(client.name.ToString() + " " + client.surname.ToString(),client.Id));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.model.Text) || String.IsNullOrEmpty(this.manufacturer.Text) || String.IsNullOrEmpty(this.serialNo.Text) || String.IsNullOrEmpty(this.deviceType.Text) || String.IsNullOrEmpty(this.status.Text) || String.IsNullOrEmpty(this.name.Text))
                MessageBox.Show("Wypełnij wszystkie pola formularza");
            else
            {
                try
                {
                    if (new DeviceCard().add(Convert.ToBoolean(this.isFirm.Checked), this.model.Text, this.manufacturer.Text, this.serialNo.Text, ((ComboBoxItem)this.deviceType.SelectedItem).HiddenValue, ((ComboBoxItem)this.status.SelectedItem).HiddenValue, ((ComboBoxItem)this.name.SelectedItem).HiddenValue))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Dodano urządzenie " + manufacturer.Text + "  " + model.Text;
                        home.notifyIcon1.BalloonTipTitle = "Dodawanie urządzenia";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.Close();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania urządzenia. Sprawdź poprawność wprowadzanych danych i spróbuj ponownie";
                        home.notifyIcon1.BalloonTipTitle = "Dodawanie urządzenia";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Wybierz prawidłowe elementy z list rozwijanych");
                }
        }

        }
    }
}
