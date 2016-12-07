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
    public partial class DeviceRepairCardDiagnosis : Form
    {
        Home home;
        private int id;
        public DeviceRepairCardDiagnosis(Home h, int id)
        {
            InitializeComponent();
            this.home = h;
            this.AcceptButton = addButton;
            this.id = id;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.richTextBox1.Text))
                MessageBox.Show("Wypełnij wszystkie pola formularza");
            else
            {
                if (new DeviceRepairCard().diagnosis(id, richTextBox1.Text))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Dodano diagnozę";
                    home.notifyIcon1.BalloonTipTitle = "Dodawanie diagnozy";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.Close();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania diagnozy. Sprawdź poprawność wprowadzanych danych i spróbuj ponownie";
                    home.notifyIcon1.BalloonTipTitle = "Dodawanie diagnozy";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
        }
    }
}
