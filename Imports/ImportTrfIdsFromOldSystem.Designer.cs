namespace eMediShop.Imports
{
    partial class ImportTrfIdsFromOldSystem
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportTrfIdsFromOldSystem));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_trfids = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_trfids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_trfids.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_trfids
            // 
            this.rgv_trfids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_trfids.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_trfids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_trfids.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_trfids.ForeColor = System.Drawing.Color.Black;
            this.rgv_trfids.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_trfids.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgv_trfids.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "trf_id";
            gridViewTextBoxColumn1.HeaderText = "Transfer Ids";
            gridViewTextBoxColumn1.Name = "trf_id";
            gridViewTextBoxColumn1.Width = 313;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_trfids.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1});
            this.rgv_trfids.MasterTemplate.EnableGrouping = false;
            this.rgv_trfids.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_trfids.Name = "rgv_trfids";
            this.rgv_trfids.ReadOnly = true;
            this.rgv_trfids.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_trfids.Size = new System.Drawing.Size(374, 455);
            this.rgv_trfids.TabIndex = 0;
            this.rgv_trfids.Text = "radGridView1";
            this.rgv_trfids.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_trfids_CommandCellClick);
            // 
            // ImportTrfIdsFromOldSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 455);
            this.Controls.Add(this.rgv_trfids);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ImportTrfIdsFromOldSystem";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import From Old Software (transfer Ids)";
            this.Load += new System.EventHandler(this.ImportTrfIdsFromOldSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_trfids.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_trfids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_trfids;
    }
}