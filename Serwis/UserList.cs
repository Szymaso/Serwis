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
    public partial class UserList : UserControl
    {
        Home home;
        public UserList(Home h)
        {
            InitializeComponent();
            this.display();
            this.home = h;
        }
        public void display()
        {
            User u = new User();
            userListGrid.DataSource = u.listUsers();
            ProjektEntities pe = new ProjektEntities();
            for (int i=0; i < userListGrid.RowCount; i++)
            {
                userListGrid.Rows[i].Cells[8].Value = pe.Places.Find(Convert.ToInt32(userListGrid.Rows[i].Cells[6].Value)).address;
            }
            userListGrid.Columns[0].HeaderText = "ID";
            userListGrid.Columns[1].HeaderText = "Nazwa";
            userListGrid.Columns[2].Visible = false;
            userListGrid.Columns[3].HeaderText = "Utworzony";
            userListGrid.Columns[4].HeaderText = "Zmodyfikowany";
            userListGrid.Columns[5].HeaderText = "Poziom uprawnień";
            userListGrid.Columns[6].Visible = false;
            userListGrid.Columns[7].Visible = false;
            userListGrid.Columns[8].HeaderText = "Miejsce";

        }

        private void userListGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserEdit u = new UserEdit(Convert.ToInt32(userListGrid.CurrentRow.Cells["id"].Value), home, this);
            u.Show();
        }
    }
}
