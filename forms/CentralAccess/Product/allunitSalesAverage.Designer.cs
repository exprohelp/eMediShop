namespace eMediShop.forms.CentralAccess.Product
{
    partial class allunitSalesAverage
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allunitSalesAverage));
            this.rgvProdName = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProdName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProdName.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvProdName
            // 
            this.rgvProdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvProdName.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvProdName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvProdName.ForeColor = System.Drawing.Color.Black;
            this.rgvProdName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvProdName.Location = new System.Drawing.Point(0, 0);
            // 
            // rgvProdName
            // 
            this.rgvProdName.MasterTemplate.AllowAddNewRow = false;
            this.rgvProdName.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 266;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = " ";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "cmd";
            gridViewCommandColumn1.Width = 30;
            this.rgvProdName.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            this.rgvProdName.MasterTemplate.EnableGrouping = false;
            this.rgvProdName.Name = "rgvProdName";
            this.rgvProdName.ReadOnly = true;
            this.rgvProdName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvProdName.Size = new System.Drawing.Size(345, 496);
            this.rgvProdName.TabIndex = 0;
            this.rgvProdName.Text = "radGridView1";
            this.rgvProdName.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvProdName_CommandCellClick);
            // 
            // radPanel1
            // 
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel1.Location = new System.Drawing.Point(348, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(660, 495);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.Text = "radPanel1";
            // 
            // allunitSalesAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 495);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.rgvProdName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "allunitSalesAverage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sales Average : All Units";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.allunitSalesAverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvProdName.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProdName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvProdName;
        private Telerik.WinControls.UI.RadPanel radPanel1;
    }
}
