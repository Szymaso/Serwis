namespace Serwis
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miejscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klienciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaIndywidualnychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzętToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaAdministracyjneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNowyTypSprzętuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTypówSprzętuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaStatusówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.homePanel = new System.Windows.Forms.Panel();
            this.dodajStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUrządzeńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.miejscaToolStripMenuItem,
            this.klienciToolStripMenuItem,
            this.sprzętToolStripMenuItem,
            this.narzędziaAdministracyjneToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1196, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.listUsersToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.userToolStripMenuItem.Text = "Użytkownik";
            this.userToolStripMenuItem.Visible = false;
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.addNewToolStripMenuItem.Text = "Nowy";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // listUsersToolStripMenuItem
            // 
            this.listUsersToolStripMenuItem.Name = "listUsersToolStripMenuItem";
            this.listUsersToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.listUsersToolStripMenuItem.Text = "Lista ";
            this.listUsersToolStripMenuItem.Click += new System.EventHandler(this.listUsersToolStripMenuItem_Click);
            // 
            // miejscaToolStripMenuItem
            // 
            this.miejscaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.miejscaToolStripMenuItem.Name = "miejscaToolStripMenuItem";
            this.miejscaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.miejscaToolStripMenuItem.Text = "Miejsca";
            this.miejscaToolStripMenuItem.Visible = false;
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // klienciToolStripMenuItem
            // 
            this.klienciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.listaToolStripMenuItem1,
            this.listaIndywidualnychToolStripMenuItem});
            this.klienciToolStripMenuItem.Name = "klienciToolStripMenuItem";
            this.klienciToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.klienciToolStripMenuItem.Text = "Klienci";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.listaToolStripMenuItem1.Text = "Lista firm";
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // listaIndywidualnychToolStripMenuItem
            // 
            this.listaIndywidualnychToolStripMenuItem.Name = "listaIndywidualnychToolStripMenuItem";
            this.listaIndywidualnychToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.listaIndywidualnychToolStripMenuItem.Text = "Lista indywidualnych";
            this.listaIndywidualnychToolStripMenuItem.Click += new System.EventHandler(this.listaIndywidualnychToolStripMenuItem_Click);
            // 
            // sprzętToolStripMenuItem
            // 
            this.sprzętToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.listaUrządzeńToolStripMenuItem});
            this.sprzętToolStripMenuItem.Name = "sprzętToolStripMenuItem";
            this.sprzętToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.sprzętToolStripMenuItem.Text = "Sprzęt";
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.dodajToolStripMenuItem1.Text = "Dodaj kartę urządzenia";
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // narzędziaAdministracyjneToolStripMenuItem
            // 
            this.narzędziaAdministracyjneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowyTypSprzętuToolStripMenuItem,
            this.listaTypówSprzętuToolStripMenuItem,
            this.dodajStatusToolStripMenuItem,
            this.listaStatusówToolStripMenuItem});
            this.narzędziaAdministracyjneToolStripMenuItem.Name = "narzędziaAdministracyjneToolStripMenuItem";
            this.narzędziaAdministracyjneToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.narzędziaAdministracyjneToolStripMenuItem.Text = "Narzędzia administracyjne";
            this.narzędziaAdministracyjneToolStripMenuItem.Visible = false;
            // 
            // dodajNowyTypSprzętuToolStripMenuItem
            // 
            this.dodajNowyTypSprzętuToolStripMenuItem.Name = "dodajNowyTypSprzętuToolStripMenuItem";
            this.dodajNowyTypSprzętuToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.dodajNowyTypSprzętuToolStripMenuItem.Text = "Dodaj nowy typ sprzętu";
            this.dodajNowyTypSprzętuToolStripMenuItem.Click += new System.EventHandler(this.dodajNowyTypSprzętuToolStripMenuItem1_Click);
            // 
            // listaTypówSprzętuToolStripMenuItem
            // 
            this.listaTypówSprzętuToolStripMenuItem.Name = "listaTypówSprzętuToolStripMenuItem";
            this.listaTypówSprzętuToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.listaTypówSprzętuToolStripMenuItem.Text = "Lista typów sprzętu";
            this.listaTypówSprzętuToolStripMenuItem.Click += new System.EventHandler(this.listaTypówSprzętuToolStripMenuItem1_Click);
            // 
            // listaStatusówToolStripMenuItem
            // 
            this.listaStatusówToolStripMenuItem.Name = "listaStatusówToolStripMenuItem";
            this.listaStatusówToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.listaStatusówToolStripMenuItem.Text = "Lista statusów";
            this.listaStatusówToolStripMenuItem.Click += new System.EventHandler(this.listaStatusówToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // homePanel
            // 
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 28);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1196, 419);
            this.homePanel.TabIndex = 2;
            // 
            // dodajStatusToolStripMenuItem
            // 
            this.dodajStatusToolStripMenuItem.Name = "dodajStatusToolStripMenuItem";
            this.dodajStatusToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.dodajStatusToolStripMenuItem.Text = "Dodaj status";
            this.dodajStatusToolStripMenuItem.Click += new System.EventHandler(this.dodajStatusToolStripMenuItem_Click);
            // 
            // listaUrządzeńToolStripMenuItem
            // 
            this.listaUrządzeńToolStripMenuItem.Name = "listaUrządzeńToolStripMenuItem";
            this.listaUrządzeńToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.listaUrządzeńToolStripMenuItem.Text = "Karty urządzeń";
            this.listaUrządzeńToolStripMenuItem.Click += new System.EventHandler(this.listaUrządzeńToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 447);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Home";
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listUsersToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.ToolStripMenuItem miejscaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzętToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaIndywidualnychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem narzędziaAdministracyjneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyTypSprzętuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaTypówSprzętuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaStatusówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaUrządzeńToolStripMenuItem;
    }
}

