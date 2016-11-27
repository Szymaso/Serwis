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
    public partial class DeviceTypeList : UserControl
    {
        Home home;
        public DeviceTypeList(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.display();
        }
        public void display()
        {
            DeviceType deviceType = new DeviceType();
            deviceTypeGrid.DataSource = deviceType.list();
            deviceTypeGrid.Columns[0].ReadOnly = true;
            deviceTypeGrid.Columns[1].HeaderText = "Typ";
            deviceTypeGrid.Columns[2].Visible = false;
        }

        private void deviceTypeGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DeviceType deviceType = new DeviceType();
            if (deviceTypeGrid.CurrentCell.Value != null)
            {
                if (deviceType.edit(Convert.ToInt32(deviceTypeGrid.CurrentRow.Cells[0].Value), deviceTypeGrid.CurrentRow.Cells[1].Value.ToString()))
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

        private void deviceTypeGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć typ sprzętu " + deviceTypeGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                                     "Potwierdź usuwanie",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeviceType deviceType = new DeviceType();
                    if (deviceType.delete(Convert.ToInt32(deviceTypeGrid.CurrentRow.Cells[0].Value)))
                    {
                        home.notifyIcon1.Icon = SystemIcons.Application;
                        home.notifyIcon1.BalloonTipText = "Usunięto typ sprzętu " + deviceTypeGrid.CurrentRow.Cells[1].Value.ToString();
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie typu sprzętu";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                        this.display();
                    }
                    else
                    {
                        home.notifyIcon1.Icon = SystemIcons.Exclamation;
                        home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas usuwania typu sprzętu";
                        home.notifyIcon1.BalloonTipTitle = "Usuwanie typu sprzętu";
                        home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                        home.notifyIcon1.Visible = true;
                        home.notifyIcon1.ShowBalloonTip(3000);
                    }
                }
            }
        }
    }
}
