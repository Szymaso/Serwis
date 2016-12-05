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
    public partial class DeviceRepairCardAdd : Form
    {
        Home home;
        public DeviceRepairCardAdd(Home h)
        {
            InitializeComponent();
            this.AcceptButton = addButton;
            this.home = h;
            foreach (var device in new ProjektEntities().DevicesCards) 
            {
                this.serialNo.Items.Add(new ComboBoxItem(device.serial_no.ToString(), device.Id));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.serialNo.Text) || String.IsNullOrEmpty(this.damageDesc.Text)) 
                MessageBox.Show("Wypełnij wszystkie pola formularza");
            else
                if(new DeviceRepairCard().add(((ComboBoxItem)this.serialNo.SelectedItem).HiddenValue, this.damageDesc.Text))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Dodano kartę naprawy";
                    home.notifyIcon1.BalloonTipTitle = "Dodawanie kart napraw";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    new Printer();
                    this.Close();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania karty naprawy. Sprawdź poprawność wprowadzanych danych i spróbuj ponownie";
                    home.notifyIcon1.BalloonTipTitle = "Dodawanie kart napraw";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
        }
    }
}
