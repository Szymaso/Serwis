namespace Serwis
{
    partial class UserAdd
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
            this.label4 = new System.Windows.Forms.Label();
            this.user_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUser_button = new System.Windows.Forms.Button();
            this.placeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(44, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Miejsce";
            // 
            // user_type
            // 
            this.user_type.FormattingEnabled = true;
            this.user_type.Items.AddRange(new object[] {
            "Użytkownik",
            "Administrator",
            "Superadministrator"});
            this.user_type.Location = new System.Drawing.Point(228, 87);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(228, 24);
            this.user_type.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Typ konta";
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.SystemColors.Window;
            this.user_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_password.Location = new System.Drawing.Point(228, 55);
            this.user_password.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '•';
            this.user_password.Size = new System.Drawing.Size(228, 26);
            this.user_password.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hasło";
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.SystemColors.Window;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_name.Location = new System.Drawing.Point(228, 25);
            this.user_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(228, 26);
            this.user_name.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa użytkownika";
            // 
            // addUser_button
            // 
            this.addUser_button.Location = new System.Drawing.Point(48, 166);
            this.addUser_button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addUser_button.Name = "addUser_button";
            this.addUser_button.Size = new System.Drawing.Size(408, 48);
            this.addUser_button.TabIndex = 14;
            this.addUser_button.Text = "Dodaj użytkownika";
            this.addUser_button.UseVisualStyleBackColor = true;
            this.addUser_button.Click += new System.EventHandler(this.addUser_button_Click);
            // 
            // placeBox
            // 
            this.placeBox.FormattingEnabled = true;
            this.placeBox.Location = new System.Drawing.Point(228, 117);
            this.placeBox.Name = "placeBox";
            this.placeBox.Size = new System.Drawing.Size(228, 24);
            this.placeBox.TabIndex = 22;
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 259);
            this.Controls.Add(this.placeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUser_button);
            this.Name = "UserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox user_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUser_button;
        private System.Windows.Forms.ComboBox placeBox;
    }
}