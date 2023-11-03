namespace eMediShop.Stock
{
    partial class ucCheckWholeStockAudit
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnReconcile = new Telerik.WinControls.UI.RadButton();
            this.btnXL = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReconcile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(0, 67);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewDateTimeColumn1.AllowFiltering = false;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "ClosingDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Closing Date";
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "ClosingDate";
            gridViewDateTimeColumn1.Width = 109;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.Width = 78;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 255;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "master_key_id";
            gridViewTextBoxColumn3.HeaderText = "Master Key Id";
            gridViewTextBoxColumn3.Name = "master_key_id";
            gridViewTextBoxColumn3.Width = 132;
            gridViewTextBoxColumn4.AllowFiltering = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "pack_type";
            gridViewTextBoxColumn4.HeaderText = "pack_type";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "pack_type";
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "pack_qty";
            gridViewDecimalColumn1.HeaderText = "Pack Qty";
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "pack_qty";
            gridViewTextBoxColumn5.AllowFiltering = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "shelf_no";
            gridViewTextBoxColumn5.HeaderText = "Shelf No";
            gridViewTextBoxColumn5.Name = "shelf_no";
            gridViewTextBoxColumn5.Width = 80;
            gridViewTextBoxColumn6.AllowFiltering = false;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "batch_no";
            gridViewTextBoxColumn6.HeaderText = "Batch No";
            gridViewTextBoxColumn6.Name = "batch_no";
            gridViewTextBoxColumn6.Width = 87;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "exp_date";
            gridViewTextBoxColumn7.HeaderText = "Expiry";
            gridViewTextBoxColumn7.Name = "exp_date";
            gridViewTextBoxColumn7.Width = 67;
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "mrp";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "MRP";
            gridViewDecimalColumn2.Name = "mrp";
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "openingQty";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Opening";
            gridViewDecimalColumn3.Name = "openingQty";
            gridViewDecimalColumn4.AllowFiltering = false;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "rcptqty";
            gridViewDecimalColumn4.FormatString = "{0:N0}";
            gridViewDecimalColumn4.HeaderText = "Received";
            gridViewDecimalColumn4.Name = "rcptqty";
            gridViewDecimalColumn4.Width = 59;
            gridViewDecimalColumn5.AllowFiltering = false;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "purchQty";
            gridViewDecimalColumn5.FormatString = "{0:N0}";
            gridViewDecimalColumn5.HeaderText = "Purchased";
            gridViewDecimalColumn5.Name = "purchQty";
            gridViewDecimalColumn5.Width = 67;
            gridViewDecimalColumn6.AllowFiltering = false;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "soldqty";
            gridViewDecimalColumn6.FormatString = "{0:N0}";
            gridViewDecimalColumn6.HeaderText = "Sold";
            gridViewDecimalColumn6.Name = "soldqty";
            gridViewDecimalColumn7.AllowFiltering = false;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "trfQty";
            gridViewDecimalColumn7.FormatString = "{0:N0}";
            gridViewDecimalColumn7.HeaderText = "Transfered";
            gridViewDecimalColumn7.Name = "trfQty";
            gridViewDecimalColumn7.Width = 62;
            gridViewDecimalColumn8.AllowFiltering = false;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "balQty";
            gridViewDecimalColumn8.FormatString = "{0:N0}";
            gridViewDecimalColumn8.HeaderText = "Sys Balance";
            gridViewDecimalColumn8.Name = "balQty";
            gridViewDecimalColumn8.Width = 74;
            gridViewDecimalColumn9.AllowFiltering = false;
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "stkQty";
            gridViewDecimalColumn9.FormatString = "{0:N0}";
            gridViewDecimalColumn9.HeaderText = "In Stock";
            gridViewDecimalColumn9.Name = "stkQty";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9});
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(1113, 447);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.DoubleClick += new System.EventHandler(this.rgv_info_DoubleClick);
            this.rgv_info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rgv_info_KeyDown);
            // 
            // btnReconcile
            // 
            this.btnReconcile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconcile.Location = new System.Drawing.Point(4, 3);
            this.btnReconcile.Name = "btnReconcile";
            this.btnReconcile.Size = new System.Drawing.Size(85, 55);
            this.btnReconcile.TabIndex = 1;
            this.btnReconcile.Text = "Reconcile";
            this.btnReconcile.Click += new System.EventHandler(this.btnReconcile_Click);
            // 
            // btnXL
            // 
            this.btnXL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXL.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnXL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXL.Location = new System.Drawing.Point(1056, 3);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(49, 55);
            this.btnXL.TabIndex = 2;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // ucCheckWholeStockAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXL);
            this.Controls.Add(this.btnReconcile);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucCheckWholeStockAudit";
            this.Size = new System.Drawing.Size(1113, 514);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReconcile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnReconcile;
        private Telerik.WinControls.UI.RadButton btnXL;
    }
}
