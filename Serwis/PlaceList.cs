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
    public partial class PlaceList : UserControl
    {
        Home home;
        public PlaceList(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.display();
        }
        private void display()
        {
            Place p = new Place();
            placeListGrid.DataSource = p.list();
            placeListGrid.Columns[2].Visible = false;
            placeListGrid.Columns[0].HeaderText = "ID";
            placeListGrid.Columns[0].ReadOnly = true;
            placeListGrid.Columns[1].HeaderText = "Adres";
        }

        private void placeListGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Place p = new Place();
            if (placeListGrid.CurrentCell.Value != null)
            {
                if (p.edit(Convert.ToInt32(placeListGrid.CurrentRow.Cells[0].Value), placeListGrid.CurrentRow.Cells[1].Value.ToString()))
                {
                    home.notifyIcon1.Icon = SystemIcons.Application;
                    home.notifyIcon1.BalloonTipText = "Edycja zakończona pomyślnie";
                    home.notifyIcon1.BalloonTipTitle = "Lista miejsc";
                    home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    home.notifyIcon1.Visible = true;
                    home.notifyIcon1.ShowBalloonTip(3000);
                    this.display();
                }
                else
                {
                    home.notifyIcon1.Icon = SystemIcons.Exclamation;
                    home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas edycji miejsca";
                    home.notifyIcon1.BalloonTipTitle = "Lista miejsc";
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

        private void placeListGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć miejsce " + placeListGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                                     "Potwierdź usuwanie",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Place p = new Place();
                    if(p.delete(Convert.ToInt32(placeListGrid.CurrentRow.Cells[0].Value)))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Usunięto miejsce " + placeListGrid.CurrentRow.Cells[1].Value.ToString();
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie miejsca";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.display();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas usuwania miejsca";
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie miejsca";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }
                }
            }
        }
    }
}
