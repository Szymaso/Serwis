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
    public partial class DevicesCardsList : UserControl
    {
        Home home;
        public DevicesCardsList(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.display();
        }
        private void display()
        {
            devicesCardsGrid.DataSource = new DeviceCard().list();
            Client individualClient = new IndividualClient();
            Client firmClient = new FirmClient();
            Status status = new Status();
            DeviceType deviceType = new DeviceType();
            for (int i = 0; i < devicesCardsGrid.RowCount; i++)
            {
                if (!String.IsNullOrEmpty(devicesCardsGrid.Rows[i].Cells[6].Value.ToString()))
                {
                    devicesCardsGrid.Rows[i].Cells[16].Value = individualClient.getName(Convert.ToInt32(devicesCardsGrid.Rows[i].Cells[6].Value));
                }
                else
                {
                    devicesCardsGrid.Rows[i].Cells[16].Value = firmClient.getName(Convert.ToInt32(devicesCardsGrid.Rows[i].Cells[7].Value));
                }
                devicesCardsGrid.Rows[i].Cells[17].Value = status.getName(Convert.ToInt32(devicesCardsGrid.Rows[i].Cells[8].Value));
                devicesCardsGrid.Rows[i].Cells[15].Value = deviceType.getName(Convert.ToInt32(devicesCardsGrid.Rows[i].Cells[9].Value));
            }
            devicesCardsGrid.Columns[6].Visible = false;
            devicesCardsGrid.Columns[7].Visible = false;
            devicesCardsGrid.Columns[8].Visible = false;
            devicesCardsGrid.Columns[9].Visible = false;
            devicesCardsGrid.Columns[10].Visible = false;
            devicesCardsGrid.Columns[11].Visible = false;
            devicesCardsGrid.Columns[12].Visible = false;
            devicesCardsGrid.Columns[13].Visible = false;
            devicesCardsGrid.Columns[14].Visible = false;
            devicesCardsGrid.Columns[15].HeaderText = "Typ sprzętu";
            devicesCardsGrid.Columns[16].HeaderText = "Klient ( typ - id )";
            devicesCardsGrid.Columns[17].HeaderText = "Status";
        }
    }
}
