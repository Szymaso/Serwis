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
        private bool add_date = false, edit_date = false;
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
                if (placeBox.Items.Count == 0)
                {
                    foreach (var p in new ProjektEntities().Places)
                    {
                        this.placeBox.Items.Add(new ComboBoxItem(p.address, p.id));
                    }
                }
            }
            DeviceCard dc = new DeviceCard();
            Place place = new Place();
            tableLayoutPanel1.RowStyles[0].Height = 18;
            bool rep, diagnosis, note;
            rep = this.repaired.Text == "TAK" ? true : false;
            diagnosis = this.diagnosisBox.Text == "TAK" ? true : false;
            note = this.noteBox.Text == "TAK" ? true : false;
            if(this.add_date == false)
            {
                this.addFrom.Value = DateTime.Now;
                this.addTo.Value = DateTime.Now;
            }
            if (this.edit_date == false)
            {
                this.changeFrom.Value = DateTime.Now;
                this.changeTo.Value = DateTime.Now;
            }

            int placeId;
            try
            {
                placeId = ((ComboBoxItem)this.placeBox.SelectedItem).HiddenValue;
            }
            catch(NullReferenceException)
            {
                placeId = 0;
            }

            deviceRepairCardList.DataSource = new DeviceRepairCard().list(rep,diagnosis,note,this.addFrom.Value,this.addTo.Value, this.add_date,
                                                                          this.changeFrom.Value, this.changeTo.Value, this.edit_date, placeId
                                                                        );
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

            for (int i = 0; i < deviceRepairCardList.RowCount; i++)
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
            try
            {
                new DeviceRepairCardNote(home, Convert.ToInt32(deviceRepairCardList.CurrentRow.Cells[0].Value)).Show();
            }
            catch { }
        }

        private void repairEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (new DeviceRepairCard().makeRepaired(Convert.ToInt32(deviceRepairCardList.CurrentRow.Cells[0].Value)))
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
            catch { }
        }

        private void statusChange_Click(object sender, EventArgs e)
        {
            try
            {
                new DeviceRepairCardStatus(home, Convert.ToInt32(deviceRepairCardList.CurrentRow.Cells[7].Value)).Show();
            }
            catch { }
        }

        private void diagnosisBox_TextChanged(object sender, EventArgs e)
        {
            this.display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.display();
        }

        private void addFrom_ValueChanged(object sender, EventArgs e)
        {
            this.add_date = true;
            this.display();
        }

        private void addTo_ValueChanged(object sender, EventArgs e)
        {
            this.add_date = true;
            this.display();
        }

        private void changeFrom_ValueChanged(object sender, EventArgs e)
        {
            this.edit_date = true;
            this.display();
        }

        private void changeTo_ValueChanged(object sender, EventArgs e)
        {
            this.edit_date = true;
            this.display();
        }

        private void placeBox_TextChanged(object sender, EventArgs e)
        {
            this.display();
        }
    }
}
