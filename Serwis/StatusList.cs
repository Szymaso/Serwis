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
    public partial class StatusList : UserControl
    {
        Home home;
        public StatusList(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.display();
        }
        public void display()
        {
            Status status = new Status();
            statusGrid.DataSource = status.list();
            statusGrid.Columns[0].ReadOnly = true;
            statusGrid.Columns[1].HeaderText = "Status";
            statusGrid.Columns[2].Visible = false;
        }

        private void statusGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Status status = new Status();
            if (statusGrid.CurrentCell.Value != null)
            {
                if (status.edit(Convert.ToInt32(statusGrid.CurrentRow.Cells[0].Value), statusGrid.CurrentRow.Cells[1].Value.ToString()))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Edycja zakończona pomyślnie";
                    home.notifyIcon1.BalloonTipTitle = "Lista typów urządzeń";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.display();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas edycji typu urządzeń";
                    home.notifyIcon1.BalloonTipTitle = "Lista typów urządzeń";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                }
            }
            else
            {
                this.display();
            }
        }

        private void statusGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć status " + statusGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                                     "Potwierdź usuwanie",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Status status = new Status();
                    if (status.delete(Convert.ToInt32(statusGrid.CurrentRow.Cells[0].Value)))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Usunięto status " + statusGrid.CurrentRow.Cells[1].Value.ToString();
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie statusu";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.display();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas usuwania statusu";
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie statusu";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }
                }
            }
        }
    }
}
