using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serwis
{
    public partial class IndividualClientList : UserControl
    {
        Home home;
        public IndividualClientList(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.display();
        }
        private void display()
        {
            IndividualClient client = new IndividualClient();
            individualClientGrid.DataSource = client.list();
            individualClientGrid.Columns[0].HeaderText = "ID";
            individualClientGrid.Columns[0].ReadOnly = true;
            individualClientGrid.Columns[1].HeaderText = "Nazwa";
            individualClientGrid.Columns[2].HeaderText = "Nazwisko";
            individualClientGrid.Columns[3].HeaderText = "Miasto";
            individualClientGrid.Columns[4].HeaderText = "Ulica";
            individualClientGrid.Columns[5].HeaderText = "Numer domu";
            individualClientGrid.Columns[6].HeaderText = "Numer lokalu";
            individualClientGrid.Columns[7].HeaderText = "Numer telefonu";
            individualClientGrid.Columns[8].HeaderText = "Email";
            individualClientGrid.Columns[9].HeaderText = "Utworzony";
            individualClientGrid.Columns[9].ReadOnly = true;
            individualClientGrid.Columns[10].HeaderText = "Edytowany";
            individualClientGrid.Columns[10].ReadOnly = true;
            individualClientGrid.Columns[11].Visible = false;
        }

        private void individualClientGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz edytować dane klienta " + individualClientGrid.CurrentRow.Cells[1].Value.ToString() + " " + individualClientGrid.CurrentRow.Cells[2].Value.ToString() + "?",
                                    "Potwierdź edycję",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                IndividualClient client = new IndividualClient();
                if (client.edit(this.individualClientGrid.CurrentCell.ColumnIndex, Convert.ToInt32(this.individualClientGrid.CurrentRow.Cells[0].Value), this.individualClientGrid.CurrentCell.Value.ToString()))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Edytowano klienta " + individualClientGrid.CurrentRow.Cells[1].Value.ToString() + " " + individualClientGrid.CurrentRow.Cells[2].Value.ToString();
                    home.notifyIcon1.BalloonTipTitle = "Edycja klienta";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.display();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas edycji klienta";
                    home.notifyIcon1.BalloonTipTitle = "Edycja klienta";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
        }

        private void individualClientGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć klienta " + individualClientGrid.CurrentRow.Cells[1].Value.ToString() + "" + individualClientGrid.CurrentRow.Cells[2].Value.ToString() + "?",
                                     "Potwierdź usuwanie",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    IndividualClient client = new IndividualClient();
                    if (client.delete(Convert.ToInt32(individualClientGrid.CurrentRow.Cells[0].Value)))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Usunięto klienta " + individualClientGrid.CurrentRow.Cells[1].Value.ToString() + " " + individualClientGrid.CurrentRow.Cells[2].Value.ToString();
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie klienta";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.display();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas usuwania klienta";
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie klienta";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }
                }

            }
        }
    }
}
