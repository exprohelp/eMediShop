namespace eMediShop.Corp
{
    partial class Corp_SalesRegister
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem2 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem3 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem4 = new Telerik.WinControls.UI.GridViewSummaryItem();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rbtnSubmit = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rgvSalesRegister = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSalesRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSalesRegister.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rbtnSubmit);
            this.radGroupBox1.Controls.Add(this.rdpTo);
            this.radGroupBox1.Controls.Add(this.rdpFrom);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(766, 43);
            this.radGroupBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // rdpFrom
            // 
            this.rdpFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdpFrom.Location = new System.Drawing.Point(55, 9);
            this.rdpFrom.Name = "rdpFrom";
            this.rdpFrom.Size = new System.Drawing.Size(101, 25);
            this.rdpFrom.TabIndex = 4;
            this.rdpFrom.TabStop = false;
            this.rdpFrom.Text = "04/02/2015";
            this.rdpFrom.Value = new System.DateTime(2015, 2, 4, 15, 21, 11, 420);
            this.rdpFrom.Leave += new System.EventHandler(this.rdpFrom_Leave);
            // 
            // rdpTo
            // 
            this.rdpTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdpTo.Location = new System.Drawing.Point(205, 9);
            this.rdpTo.Name = "rdpTo";
            this.rdpTo.Size = new System.Drawing.Size(101, 25);
            this.rdpTo.TabIndex = 5;
            this.rdpTo.TabStop = false;
            this.rdpTo.Text = "04/02/2015";
            this.rdpTo.Value = new System.DateTime(2015, 2, 4, 15, 21, 11, 420);

            // 
            // rgvSalesRegister
            // 
            this.rgvSalesRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvSalesRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvSalesRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgvSalesRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvSalesRegister.ForeColor = System.Drawing.Color.Black;
            this.rgvSalesRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvSalesRegister.Location = new System.Drawing.Point(0, 51);
            // 
            // rgvSalesRegister
            // 
            this.rgvSalesRegister.MasterTemplate.AllowAddNewRow = false;
            this.rgvSalesRegister.MasterTemplate.AutoExpandGroups = true;
            this.rgvSalesRegister.MasterTemplate.AutoGenerateColumns = false;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn1.FieldName = "sale_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:dd-MM-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Sale Date";
            gridViewDateTimeColumn1.Name = "Sale_Date";
            gridViewDateTimeColumn1.Width = 76;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "inst_name";
            gridViewTextBoxColumn1.HeaderText = "Contract";
            gridViewTextBoxColumn1.Name = "Contract";
            gridViewTextBoxColumn1.Width = 137;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "pt_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Patient";
            gridViewTextBoxColumn2.Name = "pt_name";
            gridViewTextBoxColumn2.Width = 231;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "sale_inv_no";
            gridViewTextBoxColumn3.HeaderText = "Sales Inv No";
            gridViewTextBoxColumn3.Name = "Sales_Inv_No";
            gridViewTextBoxColumn3.Width = 139;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Total";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "Total";
            gridViewDecimalColumn1.Name = "Total";
            gridViewDecimalColumn1.Width = 80;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Discount";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Discount";
            gridViewDecimalColumn2.Name = "Discount";
            gridViewDecimalColumn2.Width = 80;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Net";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Net (Credit)";
            gridViewDecimalColumn3.Name = "Net";
            gridViewDecimalColumn3.Width = 93;
            this.rgvSalesRegister.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3});
            sortDescriptor1.PropertyName = "Contract";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgvSalesRegister.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.rgvSalesRegister.MasterTemplate.ShowTotals = true;
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count;
            gridViewSummaryItem1.FormatString = "{0:N0}";
            gridViewSummaryItem1.Name = "Sale Inv No";
            gridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem2.FormatString = "{0:N2}";
            gridViewSummaryItem2.Name = "Total";
            gridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem3.FormatString = "{0:N2}";
            gridViewSummaryItem3.Name = "Discount";
            gridViewSummaryItem4.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem4.FormatString = "{0:N2}";
            gridViewSummaryItem4.Name = "Net";
            this.rgvSalesRegister.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1,
                gridViewSummaryItem2,
                gridViewSummaryItem3,
                gridViewSummaryItem4}));
            this.rgvSalesRegister.Name = "rgvSalesRegister";
            this.rgvSalesRegister.ReadOnly = true;
            this.rgvSalesRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvSalesRegister.Size = new System.Drawing.Size(766, 449);
            this.rgvSalesRegister.TabIndex = 1;
            this.rgvSalesRegister.Text = "radGridView1";
            this.rgvSalesRegister.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.MasterTemplate_ViewCellFormatting);
            // 
            // Corp_SalesRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 500);
            this.Controls.Add(this.rgvSalesRegister);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Corp_SalesRegister";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Credit Sales Register";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Corp_SalesRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSalesRegister.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSalesRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton rbtnSubmit;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadDateTimePicker rdpTo;
        private Telerik.WinControls.UI.RadDateTimePicker rdpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView rgvSalesRegister;
    }
}
