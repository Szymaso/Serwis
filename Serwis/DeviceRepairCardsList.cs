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
            if(new User().isSuperadmin())
            {
                this.placeBox.Visible = true;
                this.placeLabel.Visible = true;
                foreach(var p in new ProjektEntities().Places)
                {
                    this.placeBox.Items.Add(new ComboBoxItem(p.address, p.id));
                }
            }
            DeviceCard dc = new DeviceCard();
            Place place = new Place();
            tableLayoutPanel1.RowStyles[0].Height = 18;
            bool rep, diagnosis, note;
            rep = this.repaired.Text == "TAK" ? true : false;
            diagnosis = this.diagnosisBox.Text == "TAK" ? true : false;
            note = this.noteBox.Text == "TAK" ? true : false;
            deviceRepairCardList.DataSource = new DeviceRepairCard().list(rep,diagnosis,note);
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
        private void diagnosis_Click(object sender, EventArgs e)
        {
            new DeviceRepairCardDiagnosis(home, Convert.ToInt32(deviceRepairCardList.CurrentRow.Cells[0].Value)).Show();
        }

        private void note_Click(object sender, EventArgs e)
        {
            new DeviceRepairCardNote(home, Convert.ToInt32(deviceRepairCardList.CurrentRow.Cells[0].Value)).Show();
        }

        private void repairEnd_Click(object sender, EventArgs e)
        {
            if(new DeviceRepairCard().makeRepaired(Convert.ToInt32(deviceRepairCardList.CurrentRow.Cells[0].Value)))
            {
                home.notifyIcon1.Icon = SystemIcons.Application;
                home.notifyIcon1.BalloonTipText = "Urządzenie oznaczono jako naprawione";
                home.notifyIcon1.BalloonTipTitle = "Serwis";
                home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                home.notifyIcon1.Visible = true;
                home.notifyIcon1.ShowBalloonTip(3000);
                this.display();
            }
            else
            {
                home.notifyIcon1.Icon = SystemIcons.Exclamation;
                home.notifyIcon1.BalloonTipText = "Wystąpił błąd podczas oznaczania urządzenia jako naprawione. Spróbuj ponownie później.";
                home.notifyIcon1.BalloonTipTitle = "Serwis";
                home.notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                home.notifyIcon1.Visible = true;
                home.notifyIcon1.ShowBalloonTip(3000);
            }
        }

        private void statusChange_Click(object sender, EventArgs e)
        {
            new DeviceRepairCardStatus(home, Convert.ToInt32(deviceRepairCardList.CurrentRow.Cells[7].Value)).Show();
        }

        private void diagnosisBox_TextChanged(object sender, EventArgs e)
        {
            this.display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.display();
        }
    }
}
