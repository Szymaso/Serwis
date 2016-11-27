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
    public partial class DeviceTypeAdd : Form
    {
        Home home;
        public DeviceTypeAdd(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.AcceptButton = addButton;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DeviceType deviceType = new DeviceType();
            if(!String.IsNullOrEmpty(this.deviceType.Text))
            {
                if(deviceType.add(this.deviceType.Text))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Dodano typ sprzętu " + this.deviceType.Text;
                    home.notifyIcon1.BalloonTipTitle = "Nowy typ sprzętu";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.Close();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania typu sprzętu. Sprawdź poprawność wprowadzanych danych i spróbuj ponownie";
                    home.notifyIcon1.BalloonTipTitle = "Nowy typ sprzętu";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij pole tekstowe");
            }
        }
    }
}
