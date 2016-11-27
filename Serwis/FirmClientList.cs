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
    public partial class FirmClientList : UserControl
    {
        Home home;
        public FirmClientList(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.display();
        }
        private void display()
        {
            FirmClient firm = new FirmClient();
            firmClientGrid.DataSource = firm.list();
            firmClientGrid.Columns[0].HeaderText = "ID";
            firmClientGrid.Columns[0].ReadOnly = true;
            firmClientGrid.Columns[1].HeaderText = "Nazwa";
            firmClientGrid.Columns[2].HeaderText = "Miasto";
            firmClientGrid.Columns[3].HeaderText = "Ulica";
            firmClientGrid.Columns[4].HeaderText = "Numer domu";
            firmClientGrid.Columns[5].HeaderText = "Numer lokalu";
            firmClientGrid.Columns[6].HeaderText = "Numer telefonu";
            firmClientGrid.Columns[7].HeaderText = "Email";
            firmClientGrid.Columns[8].HeaderText = "NIP";
            firmClientGrid.Columns[9].HeaderText = "Utworzony";
            firmClientGrid.Columns[9].ReadOnly = true;
            firmClientGrid.Columns[10].HeaderText = "Edytowany";
            firmClientGrid.Columns[10].ReadOnly = true;
            firmClientGrid.Columns[11].Visible = false;
        }

        private void firmClientGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz edytować dane firmy " + firmClientGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                                     "Potwierdź edycję",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                FirmClient firm = new FirmClient();
                if(firm.edit(this.firmClientGrid.CurrentCell.ColumnIndex, Convert.ToInt32(this.firmClientGrid.CurrentRow.Cells[0].Value), this.firmClientGrid.CurrentCell.Value.ToString()))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Edytowano firmę " + firmClientGrid.CurrentRow.Cells[1].Value.ToString();
                    home.notifyIcon1.BalloonTipTitle = "Edycja firmy";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.display();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas edycji firmy";
                    home.notifyIcon1.BalloonTipTitle = "Edycja firmy";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
        }

        private void firmClientGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć firmę " + firmClientGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                                     "Potwierdź usuwanie",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    FirmClient firm = new FirmClient();
                    if (firm.delete(Convert.ToInt32(firmClientGrid.CurrentRow.Cells[0].Value)))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Usunięto firmę " + firmClientGrid.CurrentRow.Cells[1].Value.ToString();
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie firmy";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.display();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas usuwania firmy";
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie firmy";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }
                }
            }
        }
    }
}
