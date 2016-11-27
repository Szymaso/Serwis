namespace Serwis
{
    partial class IndividualClientList
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
            this.individualClientGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.individualClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // individualClientGrid
            // 
            this.individualClientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.individualClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualClientGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.individualClientGrid.Location = new System.Drawing.Point(0, 0);
            this.individualClientGrid.Name = "individualClientGrid";
            this.individualClientGrid.RowTemplate.Height = 24;
            this.individualClientGrid.Size = new System.Drawing.Size(414, 297);
            this.individualClientGrid.TabIndex = 0;
            this.individualClientGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.individualClientGrid_CellEndEdit);
            this.individualClientGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.individualClientGrid_KeyUp);
            // 
            // IndividualClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.individualClientGrid);
            this.Name = "IndividualClientList";
            this.Size = new System.Drawing.Size(414, 297);
            ((System.ComponentModel.ISupportInitialize)(this.individualClientGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView individualClientGrid;
    }
}
