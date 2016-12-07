namespace Serwis
{
    partial class DeviceRepairCardDiagnosis
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(659, 228);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 248);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(659, 53);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Diagnozuj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DeviceRepairCardDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 335);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DeviceRepairCardDiagnosis";
            this.Text = "Diagnoza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addButton;
    }
}