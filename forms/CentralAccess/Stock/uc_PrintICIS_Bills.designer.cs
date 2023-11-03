namespace eMediShop.forms.CentralAccess.Stock
{
    partial class uc_PrintICIS_Bills
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_PrintICIS_Bills));
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rb_print = new Telerik.WinControls.UI.RadButton();
            this.rb_go = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.officeShape1 = new Telerik.WinControls.UI.OfficeShape();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rdp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rgv_ids = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rb_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_ids);
            this.radGroupBox1.Controls.Add(this.rdp_to);
            this.radGroupBox1.Controls.Add(this.rdp_from);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.rb_print);
            this.radGroupBox1.Controls.Add(this.rb_go);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(211, 497);
            this.radGroupBox1.TabIndex = 0;
            // 
            // rb_print
            // 
            this.rb_print.Enabled = false;
            this.rb_print.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb_print.Image = global::eMediShop.Properties.Resources.pdf_32;
            this.rb_print.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_print.Location = new System.Drawing.Point(172, 75);
            this.rb_print.Name = "rb_print";
            this.rb_print.Size = new System.Drawing.Size(34, 36);
            this.rb_print.TabIndex = 3;
            this.rb_print.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_print.Click += new System.EventHandler(this.rb_print_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_print.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.pdf_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_print.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_print.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_print.GetChildAt(0))).Text = "";
            // 
            // rb_go
            // 
            this.rb_go.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb_go.Location = new System.Drawing.Point(168, 14);
            this.rb_go.Name = "rb_go";
            this.rb_go.Size = new System.Drawing.Size(40, 41);
            this.rb_go.TabIndex = 2;
            this.rb_go.Text = ">>";
            this.rb_go.Click += new System.EventHandler(this.rb_go_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_go.GetChildAt(0))).Text = ">>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_go.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(5, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(40, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "From";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(218, 4);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "hsn";
            gridViewTextBoxColumn3.HeaderText = "HSN";
            gridViewTextBoxColumn3.Name = "hsn";
            gridViewTextBoxColumn3.Width = 70;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "item_name";
            gridViewTextBoxColumn4.HeaderText = "NAME OF PRODUCT";
            gridViewTextBoxColumn4.Name = "NAME OF PRODUCT";
            gridViewTextBoxColumn4.Width = 240;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "unit";
            gridViewTextBoxColumn5.HeaderText = "Unit";
            gridViewTextBoxColumn5.Name = "unit";
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "qty";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "QTY";
            gridViewDecimalColumn1.Name = "QTY";
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "f_qty";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Free";
            gridViewDecimalColumn2.Name = "fqty";
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "trade_rate";
            gridViewDecimalColumn3.HeaderText = "PTR";
            gridViewDecimalColumn3.Name = "traderate";
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "gst_rate";
            gridViewDecimalColumn4.HeaderText = "GST%";
            gridViewDecimalColumn4.Name = "gst";
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "amount";
            gridViewDecimalColumn5.HeaderText = "Amount";
            gridViewDecimalColumn5.Name = "amount";
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "mrp";
            gridViewDecimalColumn6.FormatString = "{0:N2}";
            gridViewDecimalColumn6.HeaderText = "MRP";
            gridViewDecimalColumn6.Name = "MRP";
            gridViewDecimalColumn6.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn6.Width = 70;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "expiry";
            gridViewTextBoxColumn6.HeaderText = "Expiry";
            gridViewTextBoxColumn6.Name = "Expiry";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "batch_no";
            gridViewTextBoxColumn7.HeaderText = "BATCH NO";
            gridViewTextBoxColumn7.Name = "BATCH NO";
            gridViewTextBoxColumn7.Width = 80;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            sortDescriptor3.PropertyName = "MRP";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(859, 498);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(5, 43);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(23, 21);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "To";
            // 
            // rdp_from
            // 
            this.rdp_from.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_from.Location = new System.Drawing.Point(51, 12);
            this.rdp_from.Name = "rdp_from";
            this.rdp_from.Size = new System.Drawing.Size(97, 23);
            this.rdp_from.TabIndex = 5;
            this.rdp_from.TabStop = false;
            this.rdp_from.Text = "22/11/2017";
            this.rdp_from.Value = new System.DateTime(2017, 11, 22, 12, 18, 39, 337);
            this.rdp_from.Leave += new System.EventHandler(this.rdp_from_Leave);
            // 
            // rdp_to
            // 
            this.rdp_to.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_to.Location = new System.Drawing.Point(51, 41);
            this.rdp_to.Name = "rdp_to";
            this.rdp_to.Size = new System.Drawing.Size(97, 23);
            this.rdp_to.TabIndex = 6;
            this.rdp_to.TabStop = false;
            this.rdp_to.Text = "22/11/2017";
            this.rdp_to.Value = new System.DateTime(2017, 11, 22, 12, 18, 39, 337);
            // 
            // rgv_ids
            // 
            this.rgv_ids.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_ids.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_ids.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgv_ids.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_ids.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_ids.Location = new System.Drawing.Point(5, 117);
            // 
            // 
            // 
            this.rgv_ids.MasterTemplate.AllowAddNewRow = false;
            this.rgv_ids.MasterTemplate.AllowEditRow = false;
            this.rgv_ids.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "sale_inv_no";
            gridViewTextBoxColumn1.HeaderText = "Sale Inv No";
            gridViewTextBoxColumn1.Name = "sales_ids";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 131;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "unit_name";
            gridViewTextBoxColumn2.HeaderText = "Sold To";
            gridViewTextBoxColumn2.Name = "unit_name";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_ids.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            sortDescriptor1.PropertyName = "unit_name";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_ids.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            sortDescriptor2.PropertyName = "sales_ids";
            this.rgv_ids.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_ids.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_ids.Name = "rgv_ids";
            this.rgv_ids.ReadOnly = true;
            this.rgv_ids.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_ids.ShowGroupPanel = false;
            this.rgv_ids.Size = new System.Drawing.Size(203, 375);
            this.rgv_ids.TabIndex = 7;
            this.rgv_ids.Text = "radGridView2";
            this.rgv_ids.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_ids_CommandCellClick);
            // 
            // uc_PrintICIS_Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_PrintICIS_Bills";
            this.Size = new System.Drawing.Size(1081, 501);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rb_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton rb_go;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.OfficeShape officeShape1;
        private Telerik.WinControls.UI.RadButton rb_print;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_to;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_from;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGridView rgv_ids;
    }
}
