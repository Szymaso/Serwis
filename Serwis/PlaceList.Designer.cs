namespace Serwis
{
    partial class PlaceList
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
            this.placeListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.placeListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // placeListGrid
            // 
            this.placeListGrid.AllowUserToAddRows = false;
            this.placeListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.placeListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.placeListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeListGrid.Location = new System.Drawing.Point(0, 0);
            this.placeListGrid.Name = "placeListGrid";
            this.placeListGrid.RowTemplate.Height = 24;
            this.placeListGrid.Size = new System.Drawing.Size(404, 364);
            this.placeListGrid.TabIndex = 0;
            this.placeListGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.placeListGrid_CellEndEdit);
            this.placeListGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.placeListGrid_KeyUp);
            // 
            // PlaceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.placeListGrid);
            this.Name = "PlaceList";
            this.Size = new System.Drawing.Size(404, 364);
            ((System.ComponentModel.ISupportInitialize)(this.placeListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView placeListGrid;
    }
}
