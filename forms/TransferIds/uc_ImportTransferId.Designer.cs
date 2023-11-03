namespace eMediShop.forms.TransferIds
{
    partial class uc_ImportTransferId
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirm = new Telerik.WinControls.UI.RadButton();
            this.btn_RefreshIds = new System.Windows.Forms.Button();
            this.lblTrfId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.rgv_items = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Image = global::eMediShop.Properties.Resources.check_32;
            this.btnConfirm.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Location = new System.Drawing.Point(972, 461);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(42, 42);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnConfirm.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.check_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnConfirm.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnConfirm.GetChildAt(0))).Text = "";
            // 
            // btn_RefreshIds
            // 
            this.btn_RefreshIds.ForeColor = System.Drawing.Color.Green;
            this.btn_RefreshIds.Image = global::eMediShop.Properties.Resources.Refresh_16;
            this.btn_RefreshIds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RefreshIds.Location = new System.Drawing.Point(8, 6);
            this.btn_RefreshIds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RefreshIds.Name = "btn_RefreshIds";
            this.btn_RefreshIds.Size = new System.Drawing.Size(218, 26);
            this.btn_RefreshIds.TabIndex = 23;
            this.btn_RefreshIds.Text = "Fill Ids";
            this.btn_RefreshIds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RefreshIds.UseVisualStyleBackColor = true;
            this.btn_RefreshIds.Click += new System.EventHandler(this.btn_RefreshIds_Click);
            // 
            // lblTrfId
            // 
            this.lblTrfId.AutoSize = true;
            this.lblTrfId.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTrfId.Location = new System.Drawing.Point(232, 9);
            this.lblTrfId.Name = "lblTrfId";
            this.lblTrfId.Size = new System.Drawing.Size(239, 17);
            this.lblTrfId.TabIndex = 26;
            this.lblTrfId.Text = "Transfer Id : XXXXXXXXXXXXXXXX";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(487, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(201, 17);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Transfer Date : XX/XX/XXXX";
            // 
            // rgv_items
            // 
            this.rgv_items.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_items.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_items.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_items.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_items.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_items.Location = new System.Drawing.Point(232, 35);
            this.rgv_items.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_items.MasterTemplate.AllowAddNewRow = false;
            this.rgv_items.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "master_key_id";
            gridViewTextBoxColumn1.HeaderText = "Master Key Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Master Key Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_id";
            gridViewTextBoxColumn2.HeaderText = "Item Id";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Item Id";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Product";
            gridViewTextBoxColumn3.Name = "Name of Product";
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn3.Width = 302;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "pack_type";
            gridViewTextBoxColumn4.HeaderText = "Type [P]";
            gridViewTextBoxColumn4.Name = "Type [P]";
            gridViewTextBoxColumn4.Width = 98;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "pack_qty";
            gridViewTextBoxColumn5.HeaderText = "Pack [Q]";
            gridViewTextBoxColumn5.Name = "Pack [Q]";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "batch_no";
            gridViewTextBoxColumn6.HeaderText = "Batch No";
            gridViewTextBoxColumn6.Name = "Batch No";
            gridViewTextBoxColumn6.Width = 92;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Exp Date";
            gridViewDateTimeColumn1.Name = "Exp Date";
            gridViewDateTimeColumn1.Width = 70;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "mrp";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "MRP";
            gridViewDecimalColumn1.Name = "MRP";
            gridViewDecimalColumn1.Width = 70;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "qty";
            gridViewDecimalColumn2.FormatString = "{0:N0}";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.Name = "Qty";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Import_Flag";
            gridViewTextBoxColumn7.HeaderText = "Flag";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Import_Flag";
            this.rgv_items.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn7});
            sortDescriptor1.PropertyName = "Name of Product";
            this.rgv_items.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_items.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_items.Name = "rgv_items";
            this.rgv_items.ReadOnly = true;
            this.rgv_items.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_items.ShowGroupPanel = false;
            this.rgv_items.Size = new System.Drawing.Size(782, 418);
            this.rgv_items.TabIndex = 28;
            this.rgv_items.Text = "radGridView1";
            this.rgv_items.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.MasterTemplate_RowFormatting);
            // 
            // radButton1
            // 
            this.radButton1.Enabled = false;
            this.radButton1.Image = global::eMediShop.Properties.Resources.update_32;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(740, 601);
            this.radButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(42, 59);
            this.radButton1.TabIndex = 22;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.update_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(3, 35);
            this.rgv_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "trf_from";
            gridViewTextBoxColumn8.HeaderText = "From : ";
            gridViewTextBoxColumn8.Name = "From : ";
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "disp_id_info";
            gridViewTextBoxColumn9.HeaderText = "Trf Id/Purch Id";
            gridViewTextBoxColumn9.Name = "Trf Id/Purch Id";
            gridViewTextBoxColumn9.Width = 110;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "trf_id";
            gridViewTextBoxColumn10.HeaderText = "Transfer Id";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "Transfer Id";
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "NoS";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "NoS";
            gridViewDecimalColumn3.Name = "NoS";
            gridViewDecimalColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime;
            gridViewDateTimeColumn2.FieldName = "trf_date";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.HeaderText = "Trf Date";
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "Trf Date";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn2});
            sortDescriptor2.PropertyName = "From : ";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            sortDescriptor3.PropertyName = "NoS";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(223, 471);
            this.rgv_info.TabIndex = 22;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.SelectionChanged += new System.EventHandler(this.MasterTemplate_SelectionChanged);
            this.rgv_info.DoubleClick += new System.EventHandler(this.rgv_info_DoubleClick);
            // 
            // uc_ImportTransferId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_items);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTrfId);
            this.Controls.Add(this.btn_RefreshIds);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.btnConfirm);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_ImportTransferId";
            this.Size = new System.Drawing.Size(1024, 510);
            this.Load += new System.EventHandler(this.uc_ImportTransferId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadButton btnConfirm;
        private System.Windows.Forms.Button btn_RefreshIds;
        private System.Windows.Forms.Label lblTrfId;
        private System.Windows.Forms.Label lblDate;
        private Telerik.WinControls.UI.RadGridView rgv_items;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
    }
}
