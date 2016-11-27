namespace Serwis
{
    partial class FirmClientList
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
            this.firmClientGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.firmClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // firmClientGrid
            // 
            this.firmClientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.firmClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmClientGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmClientGrid.GridColor = System.Drawing.SystemColors.Control;
            this.firmClientGrid.Location = new System.Drawing.Point(0, 0);
            this.firmClientGrid.MultiSelect = false;
            this.firmClientGrid.Name = "firmClientGrid";
            this.firmClientGrid.RowTemplate.Height = 24;
            this.firmClientGrid.Size = new System.Drawing.Size(728, 457);
            this.firmClientGrid.TabIndex = 0;
            this.firmClientGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.firmClientGrid_CellEndEdit);
            this.firmClientGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.firmClientGrid_KeyUp);
            // 
            // FirmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.firmClientGrid);
            this.Name = "FirmClientList";
            this.Size = new System.Drawing.Size(728, 457);
            ((System.ComponentModel.ISupportInitialize)(this.firmClientGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView firmClientGrid;
    }
}
