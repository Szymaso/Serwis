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
    public partial class DeviceRepairCardsList : UserControl
    {
        Home home;
        public DeviceRepairCardsList(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.display();
        }
        public void display()
        {
               
            DeviceCard dc = new DeviceCard();
            Place place = new Place();
            tableLayoutPanel1.RowStyles[0].Height = 7;
            bool rep;
            rep = this.repaired.Text == "TAK" ? true : false;
            deviceRepairCardList.DataSource = new DeviceRepairCard().list(rep);
            deviceRepairCardList.Columns[0].HeaderText = "ID";
            deviceRepairCardList.Columns[1].HeaderText = "Opis uszkodzenia";
            deviceRepairCardList.Columns[2].HeaderText = "Diagnoza";
            deviceRepairCardList.Columns[3].HeaderText = "Notatka z naprawy";
            deviceRepairCardList.Columns[4].HeaderText = "Naprawione";
            deviceRepairCardList.Columns[5].HeaderText = "Utworzone";
            deviceRepairCardList.Columns[6].HeaderText = "Edytowane";
            deviceRepairCardList.Columns[7].Visible = false;
            deviceRepairCardList.Columns[8].Visible = false;
            deviceRepairCardList.Columns[9].HeaderText = "Numer seryjny";
            deviceRepairCardList.Columns[10].Visible = false;
            deviceRepairCardList.Columns[11].HeaderText = "Miejsce";

            for (int i = 0; i < deviceRepairCardList.RowCount - 1; i++)
            {
                deviceRepairCardList.Rows[i].Cells[9].Value = (dc.getDeviceData(Convert.ToInt32(deviceRepairCardList.Rows[i].Cells[7].Value.ToString())).serial_no).ToString();
                deviceRepairCardList.Rows[i].Cells[11].Value = place.getAddress(Convert.ToInt32(deviceRepairCardList.Rows[i].Cells[8].Value)).ToString();
            }
        }

        private void repaired_TextChanged(object sender, EventArgs e)
        {
            this.display();
        }
    }
}
