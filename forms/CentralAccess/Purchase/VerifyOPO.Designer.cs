namespace eMediShop.forms.CentralAccess.Purchase
{
    partial class VerifyOPO
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyOPO));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_orders = new Telerik.WinControls.UI.RadGridView();
            this.rgb_info = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btn_Load = new Telerik.WinControls.UI.RadButton();
            this.btn_Complete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_orders.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).BeginInit();
            this.rgb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Complete)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_orders
            // 
            this.rgv_orders.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_orders.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_orders.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_orders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_orders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_orders.Location = new System.Drawing.Point(9, 54);
            // 
            // 
            // 
            this.rgv_orders.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "order_no";
            gridViewTextBoxColumn1.HeaderText = "Order No";
            gridViewTextBoxColumn1.Name = "order_no";
            gridViewTextBoxColumn1.Width = 103;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "order_info";
            gridViewTextBoxColumn2.HeaderText = "Header";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "order_info";
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "NoS";
            gridViewDecimalColumn1.HeaderText = "NoS";
            gridViewDecimalColumn1.Name = "NoS";
            gridViewDecimalColumn1.Width = 34;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.FormatString = "{0:N0}";
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_orders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewCommandColumn1});
            this.rgv_orders.MasterTemplate.EnableFiltering = true;
            this.rgv_orders.MasterTemplate.EnableGrouping = false;
            this.rgv_orders.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_orders.Name = "rgv_orders";
            this.rgv_orders.ReadOnly = true;
            this.rgv_orders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_orders.Size = new System.Drawing.Size(197, 416);
            this.rgv_orders.TabIndex = 0;
            this.rgv_orders.Text = "radGridView1";
            this.rgv_orders.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // rgb_info
            // 
            this.rgb_info.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_info.Controls.Add(this.rgv_info);
            this.rgb_info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_info.HeaderText = "XXXXXXXXXXX";
            this.rgb_info.Location = new System.Drawing.Point(212, 13);
            this.rgb_info.Name = "rgb_info";
            this.rgb_info.Size = new System.Drawing.Size(753, 464);
            this.rgb_info.TabIndex = 1;
            this.rgb_info.Text = "XXXXXXXXXXX";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "auto_id";
            gridViewTextBoxColumn3.HeaderText = "ID";
            gridViewTextBoxColumn3.Name = "auto_id";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "item_name";
            gridViewTextBoxColumn4.HeaderText = "Name of Product";
            gridViewTextBoxColumn4.Name = "item_name";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 331;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "pack_type";
            gridViewTextBoxColumn5.HeaderText = "Pack Type";
            gridViewTextBoxColumn5.Name = "pack_type";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 92;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ord_qty";
            gridViewDecimalColumn2.HeaderText = "Ord Qty";
            gridViewDecimalColumn2.Name = "ord_qty";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 67;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "sup_qty";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Supplied";
            gridViewDecimalColumn3.Name = "sup_qty";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Rcpt_Qty";
            gridViewDecimalColumn4.HeaderText = "Rcpt Qty";
            gridViewDecimalColumn4.Name = "Rcpt_Qty";
            gridViewDecimalColumn4.Width = 66;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "balance";
            gridViewDecimalColumn5.FormatString = "{0:N2}";
            gridViewDecimalColumn5.HeaderText = "Balance";
            gridViewDecimalColumn5.Name = "balance";
            gridViewDecimalColumn5.ReadOnly = true;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5});
            this.rgv_info.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(749, 439);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.rgv_info_CellBeginEdit);
            this.rgv_info.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_info_CellEndEdit);
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(9, 13);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(197, 35);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Fill Orders";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Complete
            // 
            this.btn_Complete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Complete.Location = new System.Drawing.Point(971, 31);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(81, 35);
            this.btn_Complete.TabIndex = 3;
            this.btn_Complete.Text = "Complete";
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
            // 
            // VerifyOPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Complete);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.rgb_info);
            this.Controls.Add(this.rgv_orders);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VerifyOPO";
            this.Size = new System.Drawing.Size(1055, 481);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_orders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).EndInit();
            this.rgb_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Complete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_orders;
        private Telerik.WinControls.UI.RadGroupBox rgb_info;
        private Telerik.WinControls.UI.RadButton btn_Load;
        private Telerik.WinControls.UI.RadButton btn_Complete;
        private Telerik.WinControls.UI.RadGridView rgv_info;
    }
}
