namespace eMediShop.purchase.debitNote
{
    partial class ucInterCompany_DebitNoteImport
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInterCompany_DebitNoteImport));
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_debitNotes = new Telerik.WinControls.UI.RadGridView();
            this.rgb_info = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_products = new Telerik.WinControls.UI.RadGridView();
            this.btngetDebitNote = new Telerik.WinControls.UI.RadButton();
            this.btnGenerate = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).BeginInit();
            this.rgb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_products.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngetDebitNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_debitNotes
            // 
            this.rgv_debitNotes.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_debitNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_debitNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_debitNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_debitNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_debitNotes.Location = new System.Drawing.Point(4, 36);
            // 
            // 
            // 
            this.rgv_debitNotes.MasterTemplate.AllowAddNewRow = false;
            this.rgv_debitNotes.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "debitnote_no";
            gridViewTextBoxColumn9.HeaderText = "Debit Note No";
            gridViewTextBoxColumn9.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn9.Name = "debitnoteno";
            gridViewTextBoxColumn9.Width = 181;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "dc_date";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.HeaderText = "Date";
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "doc_date";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.HeaderImage")));
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column2";
            gridViewCommandColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn2.Width = 25;
            this.rgv_debitNotes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn2,
            gridViewCommandColumn2});
            this.rgv_debitNotes.MasterTemplate.EnableFiltering = true;
            sortDescriptor3.PropertyName = "doc_date";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_debitNotes.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor2});
            sortDescriptor4.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor4.PropertyName = "column2";
            this.rgv_debitNotes.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.rgv_debitNotes.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_debitNotes.Name = "rgv_debitNotes";
            this.rgv_debitNotes.ReadOnly = true;
            this.rgv_debitNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_debitNotes.ShowGroupPanel = false;
            this.rgv_debitNotes.Size = new System.Drawing.Size(246, 495);
            this.rgv_debitNotes.TabIndex = 0;
            this.rgv_debitNotes.Text = "radGridView1";
            this.rgv_debitNotes.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_debitNotes_CommandCellClick);
            // 
            // rgb_info
            // 
            this.rgb_info.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_info.Controls.Add(this.rgv_products);
            this.rgb_info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_info.HeaderText = "XXXXXX";
            this.rgb_info.Location = new System.Drawing.Point(255, 4);
            this.rgb_info.Name = "rgb_info";
            this.rgb_info.Size = new System.Drawing.Size(796, 527);
            this.rgb_info.TabIndex = 1;
            this.rgb_info.Text = "XXXXXX";
            // 
            // rgv_products
            // 
            this.rgv_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_products.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_products.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_products.ForeColor = System.Drawing.Color.Black;
            this.rgv_products.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_products.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_products.MasterTemplate.AllowAddNewRow = false;
            this.rgv_products.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "item_id";
            gridViewTextBoxColumn10.HeaderText = "code";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "item_id";
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "item_name";
            gridViewTextBoxColumn11.HeaderText = "Name of Product";
            gridViewTextBoxColumn11.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn11.Name = "item_name";
            gridViewTextBoxColumn11.Width = 293;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "master_key_id";
            gridViewTextBoxColumn12.HeaderText = "master_key_id";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "master_key_id";
            gridViewTextBoxColumn12.Width = 199;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "pack_type";
            gridViewTextBoxColumn13.HeaderText = "Pack Type";
            gridViewTextBoxColumn13.Name = "pack_type";
            gridViewTextBoxColumn13.Width = 74;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "pack_qty";
            gridViewDecimalColumn4.FormatString = "{0:N0}";
            gridViewDecimalColumn4.HeaderText = "Pack Qty";
            gridViewDecimalColumn4.Name = "pack_qty";
            gridViewDecimalColumn4.Width = 51;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "batch_no";
            gridViewTextBoxColumn14.HeaderText = "Batch No";
            gridViewTextBoxColumn14.Name = "batch_no";
            gridViewTextBoxColumn14.Width = 76;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "expiry";
            gridViewTextBoxColumn15.HeaderText = "Expiry";
            gridViewTextBoxColumn15.Name = "expiry";
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "mrp";
            gridViewDecimalColumn5.FormatString = "{0:N2}";
            gridViewDecimalColumn5.HeaderText = "MRP";
            gridViewDecimalColumn5.Name = "mrp";
            gridViewDecimalColumn5.Width = 65;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "quantity";
            gridViewDecimalColumn6.FormatString = "{0:N0}";
            gridViewDecimalColumn6.HeaderText = "Qty";
            gridViewDecimalColumn6.Name = "qty";
            gridViewDecimalColumn6.Width = 56;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "referenceNo";
            gridViewTextBoxColumn16.HeaderText = "My Master Key";
            gridViewTextBoxColumn16.Name = "referenceNo";
            gridViewTextBoxColumn16.Width = 99;
            this.rgv_products.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn16});
            this.rgv_products.MasterTemplate.EnableGrouping = false;
            this.rgv_products.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgv_products.Name = "rgv_products";
            this.rgv_products.ReadOnly = true;
            this.rgv_products.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_products.Size = new System.Drawing.Size(792, 507);
            this.rgv_products.TabIndex = 14;
            this.rgv_products.Text = "radGridView2";
            this.rgv_products.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_products_RowFormatting);
            // 
            // btngetDebitNote
            // 
            this.btngetDebitNote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetDebitNote.Location = new System.Drawing.Point(4, 6);
            this.btngetDebitNote.Name = "btngetDebitNote";
            this.btngetDebitNote.Size = new System.Drawing.Size(242, 24);
            this.btngetDebitNote.TabIndex = 2;
            this.btngetDebitNote.Text = "Get InterCompany Debit Note";
            this.btngetDebitNote.Click += new System.EventHandler(this.btngetDebitNote_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(1055, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(77, 41);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ucInterCompany_DebitNoteImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btngetDebitNote);
            this.Controls.Add(this.rgb_info);
            this.Controls.Add(this.rgv_debitNotes);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucInterCompany_DebitNoteImport";
            this.Size = new System.Drawing.Size(1137, 537);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).EndInit();
            this.rgb_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_products.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngetDebitNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_debitNotes;
        private Telerik.WinControls.UI.RadGroupBox rgb_info;
        private Telerik.WinControls.UI.RadGridView rgv_products;
        private Telerik.WinControls.UI.RadButton btngetDebitNote;
        private Telerik.WinControls.UI.RadButton btnGenerate;
    }
}
