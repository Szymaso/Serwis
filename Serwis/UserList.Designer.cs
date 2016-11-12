namespace Serwis
{
    partial class UserList
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
            this.components = new System.ComponentModel.Container();
            this.userListGrid = new System.Windows.Forms.DataGridView();
            this.projektEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userListGrid
            // 
            this.userListGrid.AllowUserToAddRows = false;
            this.userListGrid.AllowUserToDeleteRows = false;
            this.userListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListGrid.Location = new System.Drawing.Point(0, 0);
            this.userListGrid.Name = "userListGrid";
            this.userListGrid.RowTemplate.Height = 24;
            this.userListGrid.Size = new System.Drawing.Size(363, 297);
            this.userListGrid.TabIndex = 0;
            this.userListGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userListGrid_CellMouseDoubleClick);
            // 
            // projektEntitiesBindingSource
            // 
            this.projektEntitiesBindingSource.DataSource = typeof(Serwis.ProjektEntities);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userListGrid);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(363, 297);
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource projektEntitiesBindingSource;
        private System.Windows.Forms.DataGridView userListGrid;
    }
}
