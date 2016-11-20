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
    public partial class AddClient : Form
    {
        Home home;
        public AddClient(Home h)
        {
            InitializeComponent();
            this.home = h;
        }
        private void client_type_TextChanged(object sender, EventArgs e)
        {
            if (client_type.Text == "Firma")
            {
                label2.Text = "NIP";
                label1.Text = "Nazwa";
            }
            else
            {
                label2.Text = "Nazwisko";
                label1.Text = "Imie";
            }
        }

        private void addClient_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(client_type.Text) || String.IsNullOrEmpty(client_name.Text) || String.IsNullOrEmpty(client_surname.Text)
                || String.IsNullOrEmpty(client_city.Text) || String.IsNullOrEmpty(client_houseNo.Text) 
                || String.IsNullOrEmpty(client_phoneNo.Text) || String.IsNullOrEmpty(client_email.Text))
                MessageBox.Show("Wypełnij wszystkie pola formularza");
            else
            {
                if (client_type.Text == "Firma")
                {
                    Client firm = new FirmClient();
                    if(firm.addClient(client_name.Text, client_surname.Text, client_city.Text, client_street.Text, client_houseNo.Text, client_locumNo.Text, client_phoneNo.Text, client_email.Text))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Dodano klienta " + client_name.Text;
                        home.notifyIcon1.BalloonTipTitle = "Nowy klient";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.Close();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania nowego klienta. Sprawdź poprawność wprowadzanych danych i spróbuj ponownie";
                        home.notifyIcon1.BalloonTipTitle = "Nowy klient";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }

                }
                else
                {
                    Client individual = new IndividualClient();
                    if (individual.addClient(client_name.Text, client_surname.Text, client_city.Text, client_street.Text, client_houseNo.Text, client_locumNo.Text, client_phoneNo.Text, client_email.Text))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Dodano klienta " + client_name.Text + " " + client_surname.Text;
                        home.notifyIcon1.BalloonTipTitle = "Nowy klient";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.Close();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas dodawania nowego klienta. Sprawdź poprawność wprowadzanych danych i spróbuj ponownie";
                        home.notifyIcon1.BalloonTipTitle = "Nowy klient";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }
                }
            }
        }
    }
}
