using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serwis
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
          //  if (!CurrentUser.is_loggged())
          //  {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                new Login(this).Show();
          //  }
        }
    }
}
