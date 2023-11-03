namespace eMediShop.forms.CentralAccess.Stock
{
    partial class usStockTransferToConsumption
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn13 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn14 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn15 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem3 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usStockTransferToConsumption));
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor3 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnProcess = new Telerik.WinControls.UI.RadButton();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.rgvInvoices = new Telerik.WinControls.UI.RadGridView();
            this.btnGetInfo = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInvoices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(1051, 11);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(79, 36);
            this.btnProcess.TabIndex = 13;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(250, 53);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "item_id";
            gridViewTextBoxColumn15.HeaderText = "Item Id";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "item_id";
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "item_name";
            gridViewTextBoxColumn16.HeaderText = "Name of Product";
            gridViewTextBoxColumn16.Name = "item_name";
            gridViewTextBoxColumn16.Width = 250;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "pack_type";
            gridViewTextBoxColumn17.HeaderText = "P. Type";
            gridViewTextBoxColumn17.Name = "pack_type";
            gridViewTextBoxColumn17.Width = 86;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "pack_qty";
            gridViewTextBoxColumn18.HeaderText = "P. Qty";
            gridViewTextBoxColumn18.Name = "pack_qty";
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "batch_no";
            gridViewTextBoxColumn19.HeaderText = "Batch No";
            gridViewTextBoxColumn19.Name = "batch_no";
            gridViewTextBoxColumn19.Width = 94;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "exp_date";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn3.FormatString = "{0:MM-yyyy}";
            gridViewDateTimeColumn3.HeaderText = "Exp Date";
            gridViewDateTimeColumn3.Name = "exp_date";
            gridViewDateTimeColumn3.Width = 57;
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.FieldName = "mrp";
            gridViewDecimalColumn11.FormatString = "{0:N2}";
            gridViewDecimalColumn11.HeaderText = "MRP";
            gridViewDecimalColumn11.Name = "mrp";
            gridViewDecimalColumn11.Width = 56;
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.FieldName = "tax_rate";
            gridViewDecimalColumn12.FormatString = "{0:N2}";
            gridViewDecimalColumn12.HeaderText = "Tax Rate";
            gridViewDecimalColumn12.Name = "tax_rate";
            gridViewDecimalColumn12.Width = 76;
            gridViewDecimalColumn13.EnableExpressionEditor = false;
            gridViewDecimalColumn13.FieldName = "npr";
            gridViewDecimalColumn13.FormatString = "{0:N2}";
            gridViewDecimalColumn13.HeaderText = "NPR";
            gridViewDecimalColumn13.Name = "npr";
            gridViewDecimalColumn13.Width = 64;
            gridViewDecimalColumn14.EnableExpressionEditor = false;
            gridViewDecimalColumn14.FieldName = "salesInPack";
            gridViewDecimalColumn14.FormatString = "{0:N0}";
            gridViewDecimalColumn14.HeaderText = "Qty";
            gridViewDecimalColumn14.Name = "qty";
            gridViewDecimalColumn15.EnableExpressionEditor = false;
            gridViewDecimalColumn15.FieldName = "amount";
            gridViewDecimalColumn15.FormatString = "{0:N2}";
            gridViewDecimalColumn15.HeaderText = "Amount";
            gridViewDecimalColumn15.Name = "amount";
            gridViewDecimalColumn15.Width = 67;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewDateTimeColumn3,
            gridViewDecimalColumn11,
            gridViewDecimalColumn12,
            gridViewDecimalColumn13,
            gridViewDecimalColumn14,
            gridViewDecimalColumn15});
            gridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem3.FormatString = "{0:N0}";
            gridViewSummaryItem3.Name = "amount";
            this.rgv_info.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem3}));
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(880, 492);
            this.rgv_info.TabIndex = 10;
            this.rgv_info.Text = "radGridView1";
            // 
            // rgvInvoices
            // 
            this.rgvInvoices.BackColor = System.Drawing.SystemColors.Control;
            this.rgvInvoices.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvInvoices.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvInvoices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgvInvoices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvInvoices.Location = new System.Drawing.Point(0, 53);
            // 
            // 
            // 
            this.rgvInvoices.MasterTemplate.AllowAddNewRow = false;
            this.rgvInvoices.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "sale_inv_no";
            gridViewTextBoxColumn20.HeaderText = "Invoice Nos";
            gridViewTextBoxColumn20.Name = "saleinvno";
            gridViewTextBoxColumn20.Width = 154;
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.FieldName = "sale_date";
            gridViewTextBoxColumn21.HeaderText = "Dated";
            gridViewTextBoxColumn21.Name = "date";
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn3.HeaderImage")));
            gridViewCommandColumn3.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn3.Image")));
            gridViewCommandColumn3.Name = "column3";
            gridViewCommandColumn3.Width = 25;
            this.rgvInvoices.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewCommandColumn3});
            this.rgvInvoices.MasterTemplate.EnableFiltering = true;
            sortDescriptor3.PropertyName = "date";
            groupDescriptor3.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgvInvoices.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor3});
            this.rgvInvoices.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.rgvInvoices.Name = "rgvInvoices";
            this.rgvInvoices.ReadOnly = true;
            this.rgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvInvoices.ShowGroupPanel = false;
            this.rgvInvoices.Size = new System.Drawing.Size(244, 492);
            this.rgvInvoices.TabIndex = 14;
            this.rgvInvoices.Text = "radGridView1";
            this.rgvInvoices.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvInvoices_CommandCellClick);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetInfo.Location = new System.Drawing.Point(3, 11);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(139, 36);
            this.btnGetInfo.TabIndex = 15;
            this.btnGetInfo.Text = "Get Sales Invoices";
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // usStockTransferToConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.rgvInvoices);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usStockTransferToConsumption";
            this.Size = new System.Drawing.Size(1136, 548);
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInvoices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnProcess;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadGridView rgvInvoices;
        private Telerik.WinControls.UI.RadButton btnGetInfo;
    }
}
