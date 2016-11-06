namespace Serwis
{
    partial class Login
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
            this.exit_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_button.Location = new System.Drawing.Point(17, 217);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(408, 48);
            this.exit_button.TabIndex = 13;
            this.exit_button.Text = "Wyjście";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // error_label
            // 
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(13, 9);
            this.error_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(412, 39);
            this.error_label.TabIndex = 12;
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(17, 165);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(408, 48);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Zaloguj";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.SystemColors.Window;
            this.user_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_password.Location = new System.Drawing.Point(197, 110);
            this.user_password.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '•';
            this.user_password.Size = new System.Drawing.Size(228, 26);
            this.user_password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasło";
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.SystemColors.Window;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_name.Location = new System.Drawing.Point(197, 83);
            this.user_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(228, 26);
            this.user_name.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa użytkownika";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 374);
            this.ControlBox = false;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label1;
    }
}