namespace Serwis
{
    partial class DeviceRepairCardsList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceRepairCardList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusChange = new System.Windows.Forms.Button();
            this.repairEnd = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.Button();
            this.diagnosis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.placeBox = new System.Windows.Forms.ComboBox();
            this.placeLabel = new System.Windows.Forms.Label();
            this.changeTo = new System.Windows.Forms.DateTimePicker();
            this.changeFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addTo = new System.Windows.Forms.DateTimePicker();
            this.addFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diagnosisBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repaired = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deviceRepairCardList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceRepairCardList
            // 
            this.deviceRepairCardList.AllowUserToAddRows = false;
            this.deviceRepairCardList.AllowUserToDeleteRows = false;
            this.deviceRepairCardList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deviceRepairCardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceRepairCardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceRepairCardList.Location = new System.Drawing.Point(0, 220);
            this.deviceRepairCardList.Margin = new System.Windows.Forms.Padding(0);
            this.deviceRepairCardList.Name = "deviceRepairCardList";
            this.deviceRepairCardList.RowTemplate.Height = 24;
            this.deviceRepairCardList.Size = new System.Drawing.Size(1804, 242);
            this.deviceRepairCardList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.deviceRepairCardList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.74347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.25653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1804, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1798, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusChange);
            this.groupBox3.Controls.Add(this.repairEnd);
            this.groupBox3.Controls.Add(this.note);
            this.groupBox3.Controls.Add(this.diagnosis);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(3, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1792, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Akcje";
            // 
            // statusChange
            // 
            this.statusChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusChange.Location = new System.Drawing.Point(393, 25);
            this.statusChange.Name = "statusChange";
            this.statusChange.Size = new System.Drawing.Size(206, 33);
            this.statusChange.TabIndex = 3;
            this.statusChange.Text = "Zmień status";
            this.statusChange.UseVisualStyleBackColor = true;
            this.statusChange.Click += new System.EventHandler(this.statusChange_Click);
            // 
            // repairEnd
            // 
            this.repairEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repairEnd.Location = new System.Drawing.Point(181, 25);
            this.repairEnd.Name = "repairEnd";
            this.repairEnd.Size = new System.Drawing.Size(206, 33);
            this.repairEnd.TabIndex = 2;
            this.repairEnd.Text = "Oznacz jako naprawione";
            this.repairEnd.UseVisualStyleBackColor = true;
            this.repairEnd.Click += new System.EventHandler(this.repairEnd_Click);
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.note.Location = new System.Drawing.Point(95, 25);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(80, 33);
            this.note.TabIndex = 1;
            this.note.Text = "Notatka";
            this.note.UseVisualStyleBackColor = true;
            this.note.Click += new System.EventHandler(this.note_Click);
            // 
            // diagnosis
            // 
            this.diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diagnosis.Location = new System.Drawing.Point(9, 25);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(80, 33);
            this.diagnosis.TabIndex = 0;
            this.diagnosis.Text = "Diagnoza";
            this.diagnosis.UseVisualStyleBackColor = true;
            this.diagnosis.Click += new System.EventHandler(this.diagnosis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.placeBox);
            this.groupBox2.Controls.Add(this.placeLabel);
            this.groupBox2.Controls.Add(this.changeTo);
            this.groupBox2.Controls.Add(this.changeFrom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.addTo);
            this.groupBox2.Controls.Add(this.addFrom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.noteBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.diagnosisBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.repaired);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1792, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtry";
            // 
            // placeBox
            // 
            this.placeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeBox.FormattingEnabled = true;
            this.placeBox.Location = new System.Drawing.Point(1221, 35);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(172, 24);
            this.placeBox.TabIndex = 17;
            this.placeBox.Visible = false;
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeLabel.Location = new System.Drawing.Point(1160, 38);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(55, 17);
            this.placeLabel.TabIndex = 16;
            this.placeLabel.Text = "Miejsce";
            this.placeLabel.Visible = false;
            // 
            // changeTo
            // 
            this.changeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeTo.Location = new System.Drawing.Point(916, 87);
            this.changeTo.Name = "changeTo";
            this.changeTo.Size = new System.Drawing.Size(200, 23);
            this.changeTo.TabIndex = 15;
            this.changeTo.Value = new System.DateTime(2016, 12, 7, 22, 13, 55, 0);
            // 
            // changeFrom
            // 
            this.changeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeFrom.Location = new System.Drawing.Point(916, 58);
            this.changeFrom.Name = "changeFrom";
            this.changeFrom.Size = new System.Drawing.Size(200, 23);
            this.changeFrom.TabIndex = 14;
            this.changeFrom.Value = new System.DateTime(2016, 12, 7, 22, 13, 55, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(886, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(885, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Od";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(868, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Data edycji";
            // 
            // addTo
            // 
            this.addTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTo.Location = new System.Drawing.Point(641, 87);
            this.addTo.Name = "addTo";
            this.addTo.Size = new System.Drawing.Size(200, 23);
            this.addTo.TabIndex = 10;
            this.addTo.Value = new System.DateTime(2016, 12, 7, 22, 13, 55, 0);
            // 
            // addFrom
            // 
            this.addFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addFrom.Location = new System.Drawing.Point(641, 58);
            this.addFrom.Name = "addFrom";
            this.addFrom.Size = new System.Drawing.Size(200, 23);
            this.addFrom.TabIndex = 9;
            this.addFrom.Value = new System.DateTime(2016, 12, 7, 22, 13, 55, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(609, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(610, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(593, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data dodania";
            // 
            // noteBox
            // 
            this.noteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noteBox.FormattingEnabled = true;
            this.noteBox.Items.AddRange(new object[] {
            "TAK",
            "NIE"});
            this.noteBox.Location = new System.Drawing.Point(479, 35);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(62, 24);
            this.noteBox.TabIndex = 5;
            this.noteBox.Text = "NIE";
            this.noteBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(405, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notatka";
            // 
            // diagnosisBox
            // 
            this.diagnosisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diagnosisBox.FormattingEnabled = true;
            this.diagnosisBox.Items.AddRange(new object[] {
            "TAK",
            "NIE"});
            this.diagnosisBox.Location = new System.Drawing.Point(292, 35);
            this.diagnosisBox.Name = "diagnosisBox";
            this.diagnosisBox.Size = new System.Drawing.Size(62, 24);
            this.diagnosisBox.TabIndex = 3;
            this.diagnosisBox.Text = "NIE";
            this.diagnosisBox.TextChanged += new System.EventHandler(this.diagnosisBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(218, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diagnoza";
            // 
            // repaired
            // 
            this.repaired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repaired.FormattingEnabled = true;
            this.repaired.Items.AddRange(new object[] {
            "TAK",
            "NIE"});
            this.repaired.Location = new System.Drawing.Point(95, 35);
            this.repaired.Name = "repaired";
            this.repaired.Size = new System.Drawing.Size(62, 24);
            this.repaired.TabIndex = 1;
            this.repaired.Text = "NIE";
            this.repaired.TextChanged += new System.EventHandler(this.repaired_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naprawione";
            // 
            // DeviceRepairCardsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeviceRepairCardsList";
            this.Size = new System.Drawing.Size(1804, 462);
            ((System.ComponentModel.ISupportInitialize)(this.deviceRepairCardList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deviceRepairCardList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox repaired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button repairEnd;
        private System.Windows.Forms.Button note;
        private System.Windows.Forms.Button diagnosis;
        private System.Windows.Forms.ComboBox diagnosisBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox noteBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker addTo;
        private System.Windows.Forms.DateTimePicker addFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker changeTo;
        private System.Windows.Forms.DateTimePicker changeFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.ComboBox placeBox;
        private System.Windows.Forms.Button statusChange;
    }
}
