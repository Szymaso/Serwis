namespace Serwis
{
    partial class DeviceCardAdd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deviceType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isFirm = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deviceType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.serialNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.manufacturer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane urządzenia";
            // 
            // deviceType
            // 
            this.deviceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.deviceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.deviceType.FormattingEnabled = true;
            this.deviceType.Location = new System.Drawing.Point(143, 109);
            this.deviceType.Name = "deviceType";
            this.deviceType.Size = new System.Drawing.Size(269, 24);
            this.deviceType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typ";
            // 
            // serialNo
            // 
            this.serialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serialNo.Location = new System.Drawing.Point(143, 77);
            this.serialNo.Name = "serialNo";
            this.serialNo.Size = new System.Drawing.Size(269, 26);
            this.serialNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numer seryjny";
            // 
            // manufacturer
            // 
            this.manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manufacturer.Location = new System.Drawing.Point(143, 49);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(269, 26);
            this.manufacturer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producent";
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.model.Location = new System.Drawing.Point(143, 21);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(269, 26);
            this.model.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isFirm);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane właściciela";
            // 
            // isFirm
            // 
            this.isFirm.AutoSize = true;
            this.isFirm.Location = new System.Drawing.Point(143, 22);
            this.isFirm.Name = "isFirm";
            this.isFirm.Size = new System.Drawing.Size(18, 17);
            this.isFirm.TabIndex = 11;
            this.isFirm.UseVisualStyleBackColor = true;
            this.isFirm.CheckedChanged += new System.EventHandler(this.isFirm_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(7, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Czy firma";
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(143, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(269, 24);
            this.name.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(6, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(123, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Imię i nazwisko";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj urządzenie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeviceCardAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeviceCardAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawnie urządzenia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deviceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serialNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox isFirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button button1;
    }
}