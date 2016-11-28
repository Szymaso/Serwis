namespace Serwis
{
    partial class StatusList
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
            this.statusGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.statusGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusGrid
            // 
            this.statusGrid.AllowUserToAddRows = false;
            this.statusGrid.AllowUserToDeleteRows = false;
            this.statusGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusGrid.Location = new System.Drawing.Point(0, 0);
            this.statusGrid.Name = "statusGrid";
            this.statusGrid.RowTemplate.Height = 24;
            this.statusGrid.Size = new System.Drawing.Size(446, 205);
            this.statusGrid.TabIndex = 0;
            this.statusGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.statusGrid_CellEndEdit);
            this.statusGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.statusGrid_KeyUp);
            // 
            // StatusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusGrid);
            this.Name = "StatusList";
            this.Size = new System.Drawing.Size(446, 205);
            ((System.ComponentModel.ISupportInitialize)(this.statusGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statusGrid;
    }
}
