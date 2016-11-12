namespace Serwis
{
    partial class UserEdit
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.user_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUser_button = new System.Windows.Forms.Button();
            this.place = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(13, 203);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(408, 48);
            this.deleteButton.TabIndex = 45;
            this.deleteButton.Text = "Usuń użytkownika";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Miejsce";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Użytkownik",
            "Administrator",
            "Superadministrator"});
            this.type.Location = new System.Drawing.Point(193, 72);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(228, 24);
            this.type.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Typ konta";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Window;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(193, 40);
            this.password.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(228, 26);
            this.password.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Hasło";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Window;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(193, 10);
            this.name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(228, 26);
            this.name.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nazwa użytkownika";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(13, 151);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(408, 48);
            this.editButton.TabIndex = 36;
            this.editButton.Text = "Edytuj użytkownika";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // user_type
            // 
            this.user_type.FormattingEnabled = true;
            this.user_type.Items.AddRange(new object[] {
            "Użytkownik",
            "Administrator",
            "Superadministrator"});
            this.user_type.Location = new System.Drawing.Point(193, 72);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(228, 24);
            this.user_type.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Typ konta";
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.SystemColors.Window;
            this.user_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_password.Location = new System.Drawing.Point(193, 40);
            this.user_password.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '•';
            this.user_password.Size = new System.Drawing.Size(228, 26);
            this.user_password.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Hasło";
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.SystemColors.Window;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_name.Location = new System.Drawing.Point(193, 10);
            this.user_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(228, 26);
            this.user_name.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nazwa użytkownika";
            // 
            // addUser_button
            // 
            this.addUser_button.Location = new System.Drawing.Point(13, 151);
            this.addUser_button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addUser_button.Name = "addUser_button";
            this.addUser_button.Size = new System.Drawing.Size(408, 48);
            this.addUser_button.TabIndex = 29;
            this.addUser_button.Text = "Dodaj użytkownika";
            this.addUser_button.UseVisualStyleBackColor = true;
            // 
            // place
            // 
            this.place.FormattingEnabled = true;
            this.place.Location = new System.Drawing.Point(193, 101);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(228, 24);
            this.place.TabIndex = 46;
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 266);
            this.Controls.Add(this.place);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUser_button);
            this.Name = "UserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja danych użytkownika";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox user_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUser_button;
        private System.Windows.Forms.ComboBox place;
    }
}