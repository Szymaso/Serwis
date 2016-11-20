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
            firmClientGrid.Columns[1].HeaderText = "Nazwa";
            firmClientGrid.Columns[2].HeaderText = "Miasto";
            firmClientGrid.Columns[3].HeaderText = "Ulica";
            firmClientGrid.Columns[4].HeaderText = "Numer domu";
            firmClientGrid.Columns[5].HeaderText = "Numer lokalu";
            firmClientGrid.Columns[6].HeaderText = "Numer telefonu";
            firmClientGrid.Columns[7].HeaderText = "Email";
            firmClientGrid.Columns[8].HeaderText = "NIP";
            firmClientGrid.Columns[9].HeaderText = "Utworzony";
            firmClientGrid.Columns[10].HeaderText = "Edytowany";
            firmClientGrid.Columns[11].Visible = false;
        }
    }
}
