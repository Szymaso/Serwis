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
            tableLayoutPanel1.RowStyles[0].Height = 7;
            bool rep;
            rep = this.repaired.Text == "TAK" ? true : false;
            deviceRepairCardList.DataSource = new DeviceRepairCard().list(rep);
        }

        private void repaired_TextChanged(object sender, EventArgs e)
        {
            this.display();
        }
    }
}
