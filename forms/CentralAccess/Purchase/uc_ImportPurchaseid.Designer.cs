namespace eMediShop
{
    partial class uc_ImportPurchaseid
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ImportPurchaseid));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfirm = new Telerik.WinControls.UI.RadButton();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btn_RefreshIds = new System.Windows.Forms.Button();
            this.lblTrfId = new System.Windows.Forms.Label();
            this.rgv_items = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::eMediShop.Properties.Resources.update_32;
            this.btnConfirm.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Location = new System.Drawing.Point(983, 6);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(31, 28);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnConfirm.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.update_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnConfirm.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnConfirm.GetChildAt(0))).Text = "";
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
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "purch_id";
            gridViewTextBoxColumn1.HeaderText = "Purchase ID";
            gridViewTextBoxColumn1.Name = "purchase_id";
            gridViewTextBoxColumn1.Width = 154;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "NoS";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "NoS";
            gridViewDecimalColumn1.Name = "NoS";
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.Width = 45;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime;
            gridViewDateTimeColumn1.FieldName = "inv_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.HeaderText = "Inv Date";
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "inv_date";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.HeaderImage")));
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewDateTimeColumn1,
            gridViewCommandColumn1});
            sortDescriptor1.PropertyName = "NoS";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(255, 473);
            this.rgv_info.TabIndex = 22;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // btn_RefreshIds
            // 
            this.btn_RefreshIds.ForeColor = System.Drawing.Color.Green;
            this.btn_RefreshIds.Image = global::eMediShop.Properties.Resources.Refresh_16;
            this.btn_RefreshIds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RefreshIds.Location = new System.Drawing.Point(8, 6);
            this.btn_RefreshIds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RefreshIds.Name = "btn_RefreshIds";
            this.btn_RefreshIds.Size = new System.Drawing.Size(250, 26);
            this.btn_RefreshIds.TabIndex = 23;
            this.btn_RefreshIds.Text = "Click To Fill Purchase Ids/Challan ID";
            this.btn_RefreshIds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RefreshIds.UseVisualStyleBackColor = true;
            this.btn_RefreshIds.Click += new System.EventHandler(this.btn_RefreshIds_Click);
            // 
            // lblTrfId
            // 
            this.lblTrfId.AutoSize = true;
            this.lblTrfId.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTrfId.Location = new System.Drawing.Point(266, 9);
            this.lblTrfId.Name = "lblTrfId";
            this.lblTrfId.Size = new System.Drawing.Size(243, 17);
            this.lblTrfId.TabIndex = 26;
            this.lblTrfId.Text = "Purchase Id : XXXXXXXXXXXXXXXX";
            // 
            // rgv_items
            // 
            this.rgv_items.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_items.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_items.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_items.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_items.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_items.Location = new System.Drawing.Point(264, 36);
            this.rgv_items.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_items.MasterTemplate.AllowAddNewRow = false;
            this.rgv_items.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "master_key_id";
            gridViewTextBoxColumn2.HeaderText = "Master Key Id";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Master Key Id";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_id";
            gridViewTextBoxColumn3.HeaderText = "Item Id";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Item Id";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "item_name";
            gridViewTextBoxColumn4.HeaderText = "Name of Product";
            gridViewTextBoxColumn4.Name = "Name of Product";
            gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn4.Width = 200;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "pack_type";
            gridViewTextBoxColumn5.HeaderText = "Type [P]";
            gridViewTextBoxColumn5.Name = "Type [P]";
            gridViewTextBoxColumn5.Width = 70;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "pack_qty";
            gridViewTextBoxColumn6.HeaderText = "Pack [Q]";
            gridViewTextBoxColumn6.Name = "Pack [Q]";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "batch_no";
            gridViewTextBoxColumn7.HeaderText = "Batch No";
            gridViewTextBoxColumn7.Name = "Batch No";
            gridViewTextBoxColumn7.Width = 70;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime;
            gridViewDateTimeColumn2.FieldName = "exp_date";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn2.HeaderText = "Exp Date";
            gridViewDateTimeColumn2.Name = "Exp Date";
            gridViewDateTimeColumn2.Width = 70;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ptr";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "PTR";
            gridViewDecimalColumn2.Name = "PTR";
            gridViewDecimalColumn2.Width = 70;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "npr";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "NPR";
            gridViewDecimalColumn3.Name = "NPR";
            gridViewDecimalColumn3.Width = 70;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "mrp";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "MRP";
            gridViewDecimalColumn4.Name = "MRP";
            gridViewDecimalColumn4.Width = 70;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "qty";
            gridViewDecimalColumn5.FormatString = "{0:N0}";
            gridViewDecimalColumn5.HeaderText = "Qty";
            gridViewDecimalColumn5.Name = "Qty";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "stock_Flag";
            gridViewTextBoxColumn8.HeaderText = "Flag";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Flag";
            this.rgv_items.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn8});
            sortDescriptor2.PropertyName = "Name of Product";
            this.rgv_items.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_items.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_items.Name = "rgv_items";
            this.rgv_items.ReadOnly = true;
            this.rgv_items.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_items.ShowGroupPanel = false;
            this.rgv_items.Size = new System.Drawing.Size(750, 474);
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
            // uc_ImportPurchaseid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_items);
            this.Controls.Add(this.lblTrfId);
            this.Controls.Add(this.btn_RefreshIds);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.btnConfirm);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_ImportPurchaseid";
            this.Size = new System.Drawing.Size(1024, 510);
            this.Load += new System.EventHandler(this.uc_ImportTransferId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadButton btnConfirm;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private System.Windows.Forms.Button btn_RefreshIds;
        private System.Windows.Forms.Label lblTrfId;
        private Telerik.WinControls.UI.RadGridView rgv_items;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
