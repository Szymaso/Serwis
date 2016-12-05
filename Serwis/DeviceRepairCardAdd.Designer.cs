namespace Serwis
{
    partial class DeviceRepairCardAdd
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialNo = new System.Windows.Forms.ComboBox();
            this.damageDesc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(23, 243);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(587, 48);
            this.addButton.TabIndex = 43;
            this.addButton.Text = "Dodaj kartę naprawy";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Numer seryjny urządzenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Opis uszkodzenia:";
            // 
            // serialNo
            // 
            this.serialNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.serialNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.serialNo.FormattingEnabled = true;
            this.serialNo.Location = new System.Drawing.Point(235, 10);
            this.serialNo.Name = "serialNo";
            this.serialNo.Size = new System.Drawing.Size(376, 24);
            this.serialNo.TabIndex = 46;
            // 
            // damageDesc
            // 
            this.damageDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.damageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.damageDesc.Location = new System.Drawing.Point(235, 43);
            this.damageDesc.Name = "damageDesc";
            this.damageDesc.Size = new System.Drawing.Size(376, 165);
            this.damageDesc.TabIndex = 47;
            this.damageDesc.Text = "";
            // 
            // DeviceRepairCardAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 314);
            this.Controls.Add(this.damageDesc);
            this.Controls.Add(this.serialNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "DeviceRepairCardAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj kartę naprawy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serialNo;
        private System.Windows.Forms.RichTextBox damageDesc;
    }
}