namespace eMediShop.forms.CentralAccess.Stock
{
    partial class uc_TransferRegister
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_master = new Telerik.WinControls.UI.RadGridView();
            this.rgv_detail = new Telerik.WinControls.UI.GridViewTemplate();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btn_sheet = new Telerik.WinControls.UI.RadButton();
            this.btn_pdf = new Telerik.WinControls.UI.RadButton();
            this.btn_Submit = new Telerik.WinControls.UI.RadButton();
            this.dtpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_master.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_master
            // 
            this.rgv_master.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_master.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_master.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_master.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_master.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_master.Location = new System.Drawing.Point(3, 51);
            // 
            // 
            // 
            this.rgv_master.MasterTemplate.AllowAddNewRow = false;
            this.rgv_master.MasterTemplate.AutoExpandGroups = true;
            gridViewDateTimeColumn3.AllowFiltering = false;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "trf_date";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn3.FormatString = "{0:dd-MM-yyyy}";
            gridViewDateTimeColumn3.HeaderText = "Date";
            gridViewDateTimeColumn3.Name = "Date";
            gridViewDateTimeColumn3.Width = 93;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "trf_id";
            gridViewTextBoxColumn11.HeaderText = "Transfer Id";
            gridViewTextBoxColumn11.Name = "Transfer Id";
            gridViewTextBoxColumn11.Width = 120;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "trf_to";
            gridViewTextBoxColumn12.HeaderText = "Transfer To";
            gridViewTextBoxColumn12.Name = "Transfer To";
            gridViewTextBoxColumn12.Width = 277;
            gridViewTextBoxColumn13.AllowFiltering = false;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "trf_type";
            gridViewTextBoxColumn13.HeaderText = "Type";
            gridViewTextBoxColumn13.Name = "Type";
            gridViewTextBoxColumn13.Width = 99;
            gridViewDecimalColumn6.AllowFiltering = false;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "nos";
            gridViewDecimalColumn6.FormatString = "{0:N0}";
            gridViewDecimalColumn6.HeaderText = "NoS";
            gridViewDecimalColumn6.Name = "NoS";
            gridViewTextBoxColumn14.AllowFiltering = false;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "GenFrom";
            gridViewTextBoxColumn14.HeaderText = "Gen. From";
            gridViewTextBoxColumn14.Name = "Gen. From";
            gridViewTextBoxColumn14.Width = 82;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "lock";
            gridViewCheckBoxColumn2.HeaderText = "Complete";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "Complete";
            gridViewCheckBoxColumn2.Width = 71;
            gridViewTextBoxColumn15.FieldName = "ImportFlag";
            gridViewTextBoxColumn15.HeaderText = "Flag";
            gridViewTextBoxColumn15.Name = "Flag";
            gridViewTextBoxColumn15.Width = 20;
            this.rgv_master.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewDecimalColumn6,
            gridViewTextBoxColumn14,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn15});
            this.rgv_master.MasterTemplate.EnableFiltering = true;
            groupDescriptor2.Format = "{0}: {1:dd-MM-yyyy}";
            sortDescriptor2.PropertyName = "Date";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_master.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor2});
            this.rgv_master.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.rgv_detail});
            this.rgv_master.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgv_master.Name = "rgv_master";
            this.rgv_master.ReadOnly = true;
            this.rgv_master.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_master.Size = new System.Drawing.Size(792, 456);
            this.rgv_master.TabIndex = 0;
            this.rgv_master.Text = "radGridView1";
            this.rgv_master.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_master_RowFormatting);
            this.rgv_master.RowSourceNeeded += new Telerik.WinControls.UI.GridViewRowSourceNeededEventHandler(this.MasterTemplate_RowSourceNeeded);
            this.rgv_master.Click += new System.EventHandler(this.rgv_master_Click);
            // 
            // rgv_detail
            // 
            this.rgv_detail.AllowAddNewRow = false;
            this.rgv_detail.AllowDeleteRow = false;
            this.rgv_detail.AllowEditRow = false;
            this.rgv_detail.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn16.FieldName = "item_id";
            gridViewTextBoxColumn16.HeaderText = "Item Id";
            gridViewTextBoxColumn16.Name = "Item Id";
            gridViewTextBoxColumn17.FieldName = "item_name";
            gridViewTextBoxColumn17.HeaderText = "Name of Product";
            gridViewTextBoxColumn17.Name = "Name of Product";
            gridViewTextBoxColumn17.Width = 200;
            gridViewTextBoxColumn18.FieldName = "master_key_id";
            gridViewTextBoxColumn18.HeaderText = "Master Key Id";
            gridViewTextBoxColumn18.Name = "Master Key Id";
            gridViewTextBoxColumn18.Width = 80;
            gridViewTextBoxColumn19.FieldName = "batch_no";
            gridViewTextBoxColumn19.HeaderText = "Batch No";
            gridViewTextBoxColumn19.Name = "Batch No";
            gridViewTextBoxColumn19.Width = 70;
            gridViewDateTimeColumn4.FieldName = "exp_date";
            gridViewDateTimeColumn4.FormatString = "{0:MM-yyyy}";
            gridViewDateTimeColumn4.HeaderText = "Expiry";
            gridViewDateTimeColumn4.Name = "Expiry";
            gridViewDateTimeColumn4.Width = 70;
            gridViewTextBoxColumn20.FieldName = "pack_type";
            gridViewTextBoxColumn20.HeaderText = "Pack [T]";
            gridViewTextBoxColumn20.Name = "Pack [T]";
            gridViewTextBoxColumn20.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn7.FieldName = "pack_qty";
            gridViewDecimalColumn7.FormatString = "{0:N0}";
            gridViewDecimalColumn7.HeaderText = "Pack [Q]";
            gridViewDecimalColumn7.Name = "Pack [Q]";
            gridViewDecimalColumn8.FieldName = "mrp";
            gridViewDecimalColumn8.FormatString = "{0:N2}";
            gridViewDecimalColumn8.HeaderText = "MRP";
            gridViewDecimalColumn8.Name = "mrp";
            gridViewDecimalColumn8.Width = 70;
            gridViewDecimalColumn9.FieldName = "upr";
            gridViewDecimalColumn9.FormatString = "{0:N2}";
            gridViewDecimalColumn9.HeaderText = "UPR";
            gridViewDecimalColumn9.Name = "UPR";
            gridViewDecimalColumn9.Width = 70;
            gridViewDecimalColumn10.FieldName = "qty";
            gridViewDecimalColumn10.FormatString = "{0:N2}";
            gridViewDecimalColumn10.HeaderText = "Qty";
            gridViewDecimalColumn10.Name = "Qty";
            gridViewDecimalColumn10.Width = 70;
            this.rgv_detail.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewDateTimeColumn4,
            gridViewTextBoxColumn20,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDecimalColumn10});
            this.rgv_detail.ViewDefinition = tableViewDefinition3;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btn_sheet);
            this.radGroupBox1.Controls.Add(this.btn_pdf);
            this.radGroupBox1.Controls.Add(this.btn_Submit);
            this.radGroupBox1.Controls.Add(this.dtpTo);
            this.radGroupBox1.Controls.Add(this.dtpFrom);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(795, 41);
            this.radGroupBox1.TabIndex = 1;
            // 
            // btn_sheet
            // 
            this.btn_sheet.Image = global::eMediShop.Properties.Resources.printer_32;
            this.btn_sheet.Location = new System.Drawing.Point(482, 4);
            this.btn_sheet.Name = "btn_sheet";
            this.btn_sheet.Size = new System.Drawing.Size(84, 34);
            this.btn_sheet.TabIndex = 6;
            this.btn_sheet.Text = "Int. Sheet";
            this.btn_sheet.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sheet.Click += new System.EventHandler(this.btn_sheet_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Image = global::eMediShop.Properties.Resources.printer_32;
            this.btn_pdf.Location = new System.Drawing.Point(680, 4);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(90, 34);
            this.btn_pdf.TabIndex = 5;
            this.btn_pdf.Text = "Form T-01";
            this.btn_pdf.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Image = global::eMediShop.Properties.Resources.click16;
            this.btn_Submit.Location = new System.Drawing.Point(294, 9);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(59, 24);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(187, 10);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(101, 23);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.TabStop = false;
            this.dtpTo.Text = "10/09/2014";
            this.dtpTo.Value = new System.DateTime(2014, 9, 10, 16, 27, 20, 29);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(51, 10);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(101, 23);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.TabStop = false;
            this.dtpFrom.Text = "10/09/2014";
            this.dtpFrom.Value = new System.DateTime(2014, 9, 10, 16, 27, 20, 29);
            this.dtpFrom.Leave += new System.EventHandler(this.dtpFrom_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // uc_TransferRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.rgv_master);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_TransferRegister";
            this.Size = new System.Drawing.Size(799, 510);
            this.Load += new System.EventHandler(this.uc_TransferRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_master.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_master;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpTo;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btn_Submit;
        private Telerik.WinControls.UI.GridViewTemplate rgv_detail;
        private Telerik.WinControls.UI.RadButton btn_sheet;
        private Telerik.WinControls.UI.RadButton btn_pdf;
    }
}
