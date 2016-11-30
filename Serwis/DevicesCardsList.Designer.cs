namespace Serwis
{
    partial class DevicesCardsList
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
            this.devicesCardsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.devicesCardsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // devicesCardsGrid
            // 
            this.devicesCardsGrid.AllowUserToAddRows = false;
            this.devicesCardsGrid.AllowUserToDeleteRows = false;
            this.devicesCardsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devicesCardsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicesCardsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesCardsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.devicesCardsGrid.Location = new System.Drawing.Point(0, 0);
            this.devicesCardsGrid.Name = "devicesCardsGrid";
            this.devicesCardsGrid.RowTemplate.Height = 24;
            this.devicesCardsGrid.Size = new System.Drawing.Size(150, 150);
            this.devicesCardsGrid.TabIndex = 0;
            // 
            // DevicesCardsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.devicesCardsGrid);
            this.Name = "DevicesCardsList";
            ((System.ComponentModel.ISupportInitialize)(this.devicesCardsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView devicesCardsGrid;
    }
}
