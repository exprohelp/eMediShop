namespace eMediShop.forms.CentralAccess.Purchase
{
    partial class BulkPOReceiving
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgb_info = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btn_LoadOrders = new Telerik.WinControls.UI.RadButton();
            this.btn_Complete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).BeginInit();
            this.rgb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LoadOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Complete)).BeginInit();
            this.SuspendLayout();
            // 
            // rgb_info
            // 
            this.rgb_info.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_info.Controls.Add(this.rgv_info);
            this.rgb_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgb_info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_info.HeaderText = "";
            this.rgb_info.Location = new System.Drawing.Point(0, 41);
            this.rgb_info.Name = "rgb_info";
            this.rgb_info.Size = new System.Drawing.Size(905, 446);
            this.rgb_info.TabIndex = 1;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(2, 5);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "auto_id";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "auto_id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 75;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "order_no";
            gridViewTextBoxColumn2.HeaderText = "Order No";
            gridViewTextBoxColumn2.Name = "order_no";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 134;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Product";
            gridViewTextBoxColumn3.Name = "item_name";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 357;
            gridViewTextBoxColumn4.AllowFiltering = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "pack_type";
            gridViewTextBoxColumn4.HeaderText = "Pack Type";
            gridViewTextBoxColumn4.Name = "pack_type";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 92;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ord_qty";
            gridViewDecimalColumn1.HeaderText = "Ord Qty";
            gridViewDecimalColumn1.Name = "ord_qty";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 67;
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "sup_qty";
            gridViewDecimalColumn2.FormatString = "{0:N0}";
            gridViewDecimalColumn2.HeaderText = "Supplied";
            gridViewDecimalColumn2.Name = "sup_qty";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 69;
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Rcpt_Qty";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Rcpt Qty";
            gridViewDecimalColumn3.Name = "Rcpt_Qty";
            gridViewDecimalColumn3.Width = 84;
            gridViewDecimalColumn4.AllowFiltering = false;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "balance";
            gridViewDecimalColumn4.FormatString = "{0:N0}";
            gridViewDecimalColumn4.HeaderText = "Balance";
            gridViewDecimalColumn4.Name = "balance";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "item_id";
            gridViewTextBoxColumn5.HeaderText = "item_id";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "item_id";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn5});
            this.rgv_info.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(901, 439);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.rgv_info_CellBeginEdit);
            this.rgv_info.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_info_CellEndEdit);
            // 
            // btn_LoadOrders
            // 
            this.btn_LoadOrders.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadOrders.Location = new System.Drawing.Point(4, 3);
            this.btn_LoadOrders.Name = "btn_LoadOrders";
            this.btn_LoadOrders.Size = new System.Drawing.Size(120, 35);
            this.btn_LoadOrders.TabIndex = 4;
            this.btn_LoadOrders.Text = "Load Orders";
            this.btn_LoadOrders.Click += new System.EventHandler(this.btn_LoadOrders_Click);
            // 
            // btn_Complete
            // 
            this.btn_Complete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Complete.Location = new System.Drawing.Point(820, 3);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(81, 35);
            this.btn_Complete.TabIndex = 5;
            this.btn_Complete.Text = "Complete";
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click_1);
            // 
            // BulkPOReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Complete);
            this.Controls.Add(this.btn_LoadOrders);
            this.Controls.Add(this.rgb_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BulkPOReceiving";
            this.Size = new System.Drawing.Size(905, 487);
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).EndInit();
            this.rgb_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LoadOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Complete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGroupBox rgb_info;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btn_LoadOrders;
        private Telerik.WinControls.UI.RadButton btn_Complete;
    }
}
