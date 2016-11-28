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
    public partial class StatusAdd : Form
    {
        Home home;
        public StatusAdd(Home h)
        {
            InitializeComponent();
            this.home = h;
            this.AcceptButton = addButton;
        }
    }
}
