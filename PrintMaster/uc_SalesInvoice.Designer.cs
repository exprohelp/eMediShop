namespace eMediShop.PrintMaster
{
    partial class uc_SalesInvoice
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_SalesInvoice));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.rgv_ids = new Telerik.WinControls.UI.RadGridView();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnprint = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(324, 4);
            this.rgv_info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "item_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pack_type";
            gridViewTextBoxColumn3.HeaderText = "P. Type";
            gridViewTextBoxColumn3.Name = "pack_type";
            gridViewTextBoxColumn3.Width = 79;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "pack_qty";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "P. Qty";
            gridViewDecimalColumn1.Name = "pack_qty";
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "master_key_id";
            gridViewDecimalColumn2.HeaderText = "Master Key";
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "master_key_id";
            gridViewDecimalColumn2.Width = 121;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "batch_no";
            gridViewTextBoxColumn4.HeaderText = "Batch No";
            gridViewTextBoxColumn4.Name = "batch_no";
            gridViewTextBoxColumn4.Width = 69;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "expiry";
            gridViewTextBoxColumn5.HeaderText = "Expiry";
            gridViewTextBoxColumn5.Name = "exp_date";
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "qty";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Qty";
            gridViewDecimalColumn3.Name = "qty";
            gridViewDecimalColumn3.Width = 35;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "usr";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "USR";
            gridViewDecimalColumn4.Name = "usr";
            gridViewDecimalColumn4.Width = 62;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "taxablevalue";
            gridViewDecimalColumn5.HeaderText = "Taxable Value";
            gridViewDecimalColumn5.Name = "taxableValue";
            gridViewDecimalColumn5.Width = 87;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "taxvalue";
            gridViewDecimalColumn6.HeaderText = "Tax Value";
            gridViewDecimalColumn6.Name = "taxvalue";
            gridViewDecimalColumn6.Width = 65;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "total";
            gridViewDecimalColumn7.FormatString = "{0:N2}";
            gridViewDecimalColumn7.HeaderText = "Total";
            gridViewDecimalColumn7.Name = "total";
            gridViewDecimalColumn7.Width = 70;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(800, 488);
            this.rgv_info.TabIndex = 8;
            this.rgv_info.Text = "radGridView2";
            // 
            // rgv_ids
            // 
            this.rgv_ids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgv_ids.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_ids.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_ids.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_ids.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_ids.Location = new System.Drawing.Point(7, 62);
            this.rgv_ids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // 
            // 
            this.rgv_ids.MasterTemplate.AllowAddNewRow = false;
            this.rgv_ids.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "unit_name";
            gridViewTextBoxColumn6.HeaderText = "Name of Unit";
            gridViewTextBoxColumn6.Name = "unit_name";
            gridViewTextBoxColumn6.Width = 125;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "sale_inv_no";
            gridViewTextBoxColumn7.HeaderText = "Invoice No";
            gridViewTextBoxColumn7.Name = "sale_inv_no";
            gridViewTextBoxColumn7.Width = 157;
            gridViewDecimalColumn8.AllowFiltering = false;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "BillAmt";
            gridViewDecimalColumn8.FormatString = "{0:N0}";
            gridViewDecimalColumn8.HeaderText = "Bill Amt";
            gridViewDecimalColumn8.Name = "BillAmt";
            gridViewDecimalColumn8.Width = 64;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column3";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "unit_id";
            gridViewTextBoxColumn8.HeaderText = "trf_to";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "unit_id";
            this.rgv_ids.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn8,
            gridViewCommandColumn1,
            gridViewTextBoxColumn8});
            this.rgv_ids.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "unit_name";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_ids.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            sortDescriptor2.PropertyName = "column1";
            this.rgv_ids.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_ids.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_ids.Name = "rgv_ids";
            this.rgv_ids.ReadOnly = true;
            this.rgv_ids.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_ids.ShowGroupPanel = false;
            this.rgv_ids.Size = new System.Drawing.Size(309, 430);
            this.rgv_ids.TabIndex = 5;
            this.rgv_ids.Text = "radGridView1";
            this.rgv_ids.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_ids_CommandCellClick);
            // 
            // btnGo
            // 
            this.btnGo.Image = global::eMediShop.Properties.Resources.click16;
            this.btnGo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGo.Location = new System.Drawing.Point(158, 7);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(35, 51);
            this.btnGo.TabIndex = 7;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // rdp_from
            // 
            this.rdp_from.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_from.Location = new System.Drawing.Point(48, 7);
            this.rdp_from.Name = "rdp_from";
            this.rdp_from.Size = new System.Drawing.Size(103, 25);
            this.rdp_from.TabIndex = 10;
            this.rdp_from.TabStop = false;
            this.rdp_from.Text = "24/06/2018";
            this.rdp_from.Value = new System.DateTime(2018, 6, 24, 17, 40, 50, 378);
            this.rdp_from.Leave += new System.EventHandler(this.rdp_from_Leave);
            // 
            // rdp_to
            // 
            this.rdp_to.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_to.Location = new System.Drawing.Point(48, 33);
            this.rdp_to.Name = "rdp_to";
            this.rdp_to.Size = new System.Drawing.Size(103, 25);
            this.rdp_to.TabIndex = 12;
            this.rdp_to.TabStop = false;
            this.rdp_to.Text = "24/06/2018";
            this.rdp_to.Value = new System.DateTime(2018, 6, 24, 17, 40, 50, 378);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "To";
            // 
            // btnprint
            // 
            this.btnprint.Image = global::eMediShop.Properties.Resources.printer;
            this.btnprint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnprint.Location = new System.Drawing.Point(281, 7);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(35, 51);
            this.btnprint.TabIndex = 13;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // uc_SalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.rdp_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdp_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rgv_ids);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_SalesInvoice";
            this.Size = new System.Drawing.Size(1131, 497);
            this.Load += new System.EventHandler(this.uc_idPrintig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnGo;
        private Telerik.WinControls.UI.RadGridView rgv_ids;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_from;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_to;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnprint;
    }
}
