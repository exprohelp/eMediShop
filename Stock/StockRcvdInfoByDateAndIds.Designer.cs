namespace eMediShop.forms.Stock
{
    partial class StockRcvdInfoByDateAndIds
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

        #region Windows Form Designer generated code

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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem2 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.dtp_date = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btn_Submit = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(2, 53);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "trf_id";
            gridViewTextBoxColumn1.HeaderText = "Transfer Id";
            gridViewTextBoxColumn1.Name = "Transfer Id";
            gridViewTextBoxColumn2.AllowFiltering = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_id";
            gridViewTextBoxColumn2.HeaderText = "Item Id";
            gridViewTextBoxColumn2.Name = "Item Id";
            gridViewTextBoxColumn2.Width = 5;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Product";
            gridViewTextBoxColumn3.Name = "Name of Product";
            gridViewTextBoxColumn3.Width = 303;
            gridViewTextBoxColumn4.AllowFiltering = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "pack_type";
            gridViewTextBoxColumn4.HeaderText = "Pack[T]";
            gridViewTextBoxColumn4.Name = "Pack[T]";
            gridViewTextBoxColumn4.Width = 83;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "pack_qty";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "Pack[Q]";
            gridViewDecimalColumn1.Name = "Pack[Q]";
            gridViewDecimalColumn1.Width = 60;
            gridViewTextBoxColumn5.AllowFiltering = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "master_key_id";
            gridViewTextBoxColumn5.HeaderText = "Master Key Id";
            gridViewTextBoxColumn5.Name = "Master Key Id";
            gridViewTextBoxColumn5.Width = 110;
            gridViewTextBoxColumn6.AllowFiltering = false;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "batch_no";
            gridViewTextBoxColumn6.HeaderText = "Batch No";
            gridViewTextBoxColumn6.Name = "Batch No";
            gridViewTextBoxColumn6.Width = 81;
            gridViewDateTimeColumn1.AllowFiltering = false;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatString = "{0:dd-MM-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Exp.Date";
            gridViewDateTimeColumn1.Name = "Exp.Date";
            gridViewDateTimeColumn1.Width = 78;
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "upr";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "UPR";
            gridViewDecimalColumn2.Name = "UPR";
            gridViewDecimalColumn2.Width = 60;
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "mrp";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "MRP";
            gridViewDecimalColumn3.Name = "MRP";
            gridViewDecimalColumn3.Width = 59;
            gridViewDecimalColumn4.AllowFiltering = false;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Qty";
            gridViewDecimalColumn4.FormatString = "{0:N0}";
            gridViewDecimalColumn4.HeaderText = "Qty";
            gridViewDecimalColumn4.Name = "Qty";
            gridViewDecimalColumn5.AllowFiltering = false;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "amount";
            gridViewDecimalColumn5.FormatString = "{0:N2}";
            gridViewDecimalColumn5.HeaderText = "Amount";
            gridViewDecimalColumn5.Name = "Amount";
            gridViewDecimalColumn5.Width = 69;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5});
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "Transfer Id";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "Master Key Id";
            gridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem2.FormatString = "{0:N2}";
            gridViewSummaryItem2.Name = "Amount";
            this.rgv_info.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1,
                gridViewSummaryItem2}));
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(1004, 436);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_info_RowFormatting);
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(51, 13);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(89, 23);
            this.dtp_date.TabIndex = 1;
            this.dtp_date.TabStop = false;
            this.dtp_date.Text = "21/06/2014";
            this.dtp_date.Value = new System.DateTime(2014, 6, 21, 13, 30, 40, 516);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(10, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(35, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Date";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(923, 10);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(69, 24);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.dtp_date);
            this.radGroupBox1.Controls.Add(this.btn_Submit);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(2, 5);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1001, 41);
            this.radGroupBox1.TabIndex = 4;
            // 
            // StockRcvdInfoByDateAndIds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 490);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StockRcvdInfoByDateAndIds";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Stocks Receiving Information Checking";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.StockRcvdInfoByDateAndIds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadDateTimePicker dtp_date;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btn_Submit;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}
