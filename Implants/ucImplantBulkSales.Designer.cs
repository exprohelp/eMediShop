namespace eMediShop.Implants
{
    partial class ucImplantBulkSales
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucImplantBulkSales));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_purchaseid = new Telerik.WinControls.UI.RadGridView();
            this.btnRefreshIds = new Telerik.WinControls.UI.RadButton();
            this.rgv_purchase = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSalesProcess = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchaseid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchaseid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshIds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchase.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalesProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_purchaseid
            // 
            this.rgv_purchaseid.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_purchaseid.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_purchaseid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_purchaseid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_purchaseid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_purchaseid.Location = new System.Drawing.Point(4, 34);
            // 
            // 
            // 
            this.rgv_purchaseid.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "purchase_id";
            gridViewTextBoxColumn1.HeaderText = "Purchase ID";
            gridViewTextBoxColumn1.Name = "purchase_id";
            gridViewTextBoxColumn1.Width = 174;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column2";
            gridViewCommandColumn1.Width = 25;
            this.rgv_purchaseid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1});
            this.rgv_purchaseid.MasterTemplate.EnableFiltering = true;
            this.rgv_purchaseid.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "column1";
            this.rgv_purchaseid.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_purchaseid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_purchaseid.Name = "rgv_purchaseid";
            this.rgv_purchaseid.ReadOnly = true;
            this.rgv_purchaseid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_purchaseid.Size = new System.Drawing.Size(240, 186);
            this.rgv_purchaseid.TabIndex = 0;
            this.rgv_purchaseid.Text = "radGridView1";
            this.rgv_purchaseid.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_purchaseid_CommandCellClick);
            // 
            // btnRefreshIds
            // 
            this.btnRefreshIds.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshIds.Image = global::eMediShop.Properties.Resources.Refresh;
            this.btnRefreshIds.Location = new System.Drawing.Point(4, 4);
            this.btnRefreshIds.Name = "btnRefreshIds";
            this.btnRefreshIds.Size = new System.Drawing.Size(240, 24);
            this.btnRefreshIds.TabIndex = 1;
            this.btnRefreshIds.Text = "Refresh Purchase Id\'s";
            this.btnRefreshIds.Click += new System.EventHandler(this.btnRefreshIds_Click);
            // 
            // rgv_purchase
            // 
            this.rgv_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_purchase.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_purchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_purchase.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_purchase.ForeColor = System.Drawing.Color.Black;
            this.rgv_purchase.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rgv_purchase.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_purchase.MasterTemplate.AllowAddNewRow = false;
            this.rgv_purchase.MasterTemplate.AllowColumnChooser = false;
            this.rgv_purchase.MasterTemplate.AllowColumnResize = false;
            this.rgv_purchase.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_id";
            gridViewTextBoxColumn2.HeaderText = "Item Id";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "item_id";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Product";
            gridViewTextBoxColumn3.Name = "item_name";
            gridViewTextBoxColumn3.Width = 230;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "master_key_id";
            gridViewTextBoxColumn4.HeaderText = "Master key Id";
            gridViewTextBoxColumn4.Name = "master_key_id";
            gridViewTextBoxColumn4.Width = 120;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "hsn";
            gridViewTextBoxColumn5.HeaderText = "HSN";
            gridViewTextBoxColumn5.Name = "hsn";
            gridViewTextBoxColumn5.Width = 55;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "batch_no";
            gridViewTextBoxColumn6.HeaderText = "Batch No";
            gridViewTextBoxColumn6.Name = "batch_no";
            gridViewTextBoxColumn6.Width = 80;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "exp_date";
            gridViewTextBoxColumn7.HeaderText = "Exp Dt.";
            gridViewTextBoxColumn7.Name = "exp_date";
            gridViewTextBoxColumn7.Width = 60;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ptr";
            gridViewDecimalColumn1.HeaderText = "Trade";
            gridViewDecimalColumn1.Name = "trade";
            gridViewDecimalColumn1.Width = 60;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "mrp";
            gridViewDecimalColumn2.HeaderText = "MRP";
            gridViewDecimalColumn2.Name = "mrp";
            gridViewDecimalColumn2.Width = 55;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "pack_type";
            gridViewTextBoxColumn8.HeaderText = "P. Type";
            gridViewTextBoxColumn8.Name = "pack_type";
            gridViewTextBoxColumn8.Width = 62;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "pack_qty";
            gridViewDecimalColumn3.HeaderText = "P.Qty";
            gridViewDecimalColumn3.Name = "pack_qty";
            gridViewDecimalColumn3.Width = 40;
            gridViewTextBoxColumn9.DataType = typeof(decimal);
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "quantity";
            gridViewTextBoxColumn9.HeaderText = "Qty";
            gridViewTextBoxColumn9.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Name = "qty";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Width = 45;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "it_free";
            gridViewDecimalColumn4.HeaderText = "Free";
            gridViewDecimalColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn4.Name = "it_free";
            gridViewDecimalColumn4.Width = 35;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "tax_id";
            gridViewTextBoxColumn10.HeaderText = "TAX";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "tax_id";
            gridViewTextBoxColumn10.Width = 25;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "tax_rate";
            gridViewDecimalColumn5.FormatString = "{0:N2}";
            gridViewDecimalColumn5.HeaderText = "GST%";
            gridViewDecimalColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn5.Name = "tax_rate";
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "disper";
            gridViewDecimalColumn6.HeaderText = "Dis%";
            gridViewDecimalColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn6.Name = "disper";
            gridViewDecimalColumn6.Width = 35;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "amount";
            gridViewDecimalColumn7.HeaderText = "Amount";
            gridViewDecimalColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn7.Name = "amount";
            gridViewDecimalColumn7.Width = 63;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "StkQty";
            gridViewDecimalColumn8.HeaderText = "StkQty";
            gridViewDecimalColumn8.Name = "StkQty";
            gridViewDecimalColumn8.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            this.rgv_purchase.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn8,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn10,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8});
            this.rgv_purchase.MasterTemplate.EnableGrouping = false;
            sortDescriptor2.PropertyName = "StkQty";
            this.rgv_purchase.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_purchase.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_purchase.Name = "rgv_purchase";
            this.rgv_purchase.ReadOnly = true;
            this.rgv_purchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_purchase.Size = new System.Drawing.Size(1073, 299);
            this.rgv_purchase.TabIndex = 129;
            this.rgv_purchase.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_purchase_RowFormatting);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_purchase);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 227);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1077, 319);
            this.radGroupBox1.TabIndex = 130;
            this.radGroupBox1.Tag = "";
            this.radGroupBox1.Text = "XXXXXXXXXXXX";
            // 
            // btnSalesProcess
            // 
            this.btnSalesProcess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesProcess.Location = new System.Drawing.Point(952, 4);
            this.btnSalesProcess.Name = "btnSalesProcess";
            this.btnSalesProcess.Size = new System.Drawing.Size(127, 45);
            this.btnSalesProcess.TabIndex = 2;
            this.btnSalesProcess.Text = "Generate Sales";
            this.btnSalesProcess.Click += new System.EventHandler(this.btnSalesProcess_Click);
            // 
            // ucImplantBulkSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalesProcess);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnRefreshIds);
            this.Controls.Add(this.rgv_purchaseid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucImplantBulkSales";
            this.Size = new System.Drawing.Size(1084, 549);
            this.Load += new System.EventHandler(this.ucImplantBulkSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchaseid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchaseid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshIds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchase.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_purchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalesProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_purchaseid;
        private Telerik.WinControls.UI.RadButton btnRefreshIds;
        private Telerik.WinControls.UI.RadGridView rgv_purchase;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSalesProcess;
    }
}
