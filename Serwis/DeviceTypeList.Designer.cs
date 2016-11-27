namespace Serwis
{
    partial class DeviceTypeList
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
            this.deviceTypeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceTypeGrid
            // 
            this.deviceTypeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deviceTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceTypeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceTypeGrid.Location = new System.Drawing.Point(0, 0);
            this.deviceTypeGrid.Name = "deviceTypeGrid";
            this.deviceTypeGrid.RowTemplate.Height = 24;
            this.deviceTypeGrid.Size = new System.Drawing.Size(224, 221);
            this.deviceTypeGrid.TabIndex = 0;
            this.deviceTypeGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.deviceTypeGrid_CellEndEdit);
            this.deviceTypeGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.deviceTypeGrid_KeyUp);
            // 
            // DeviceTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deviceTypeGrid);
            this.Name = "DeviceTypeList";
            this.Size = new System.Drawing.Size(224, 221);
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deviceTypeGrid;
    }
}
