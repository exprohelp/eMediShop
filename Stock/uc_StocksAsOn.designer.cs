namespace eMediShop.forms.Stock
{
    partial class uc_StocksAsOn
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem2 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgb = new Telerik.WinControls.UI.RadGroupBox();
            this.rbtn_xl = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rbtn_GetStocks = new Telerik.WinControls.UI.RadButton();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgb)).BeginInit();
            this.rgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_xl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_GetStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgb
            // 
            this.rgb.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb.Controls.Add(this.rbtn_xl);
            this.rgb.Controls.Add(this.rbtn_GetStocks);
            this.rgb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb.HeaderText = "";
            this.rgb.Location = new System.Drawing.Point(4, 4);
            this.rgb.Name = "rgb";
            this.rgb.Size = new System.Drawing.Size(61, 502);
            this.rgb.TabIndex = 0;
            // 
            // rbtn_xl
            // 
            this.rbtn_xl.Image = global::eMediShop.Properties.Resources.export_excel;
            this.rbtn_xl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_xl.Location = new System.Drawing.Point(5, 457);
            this.rbtn_xl.Name = "rbtn_xl";
            this.rbtn_xl.Size = new System.Drawing.Size(47, 40);
            this.rbtn_xl.TabIndex = 1;
            this.rbtn_xl.Click += new System.EventHandler(this.rbtn_xl_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_xl.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.export_excel;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_xl.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_xl.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_xl.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rbtn_GetStocks
            // 
            this.rbtn_GetStocks.Image = global::eMediShop.Properties.Resources.click16;
            this.rbtn_GetStocks.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_GetStocks.Location = new System.Drawing.Point(5, 5);
            this.rbtn_GetStocks.Name = "rbtn_GetStocks";
            this.rbtn_GetStocks.Size = new System.Drawing.Size(50, 43);
            this.rbtn_GetStocks.TabIndex = 0;
            this.rbtn_GetStocks.Click += new System.EventHandler(this.rbtn_GetStocks_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_GetStocks.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.click16;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_GetStocks.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_GetStocks.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_GetStocks.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(80, 3);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "item_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "Name of Product";
            gridViewTextBoxColumn2.Width = 241;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "mfd_name";
            gridViewTextBoxColumn3.HeaderText = "Company";
            gridViewTextBoxColumn3.Name = "Company";
            gridViewTextBoxColumn3.Width = 89;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "pack_type";
            gridViewTextBoxColumn4.HeaderText = "Pack Type";
            gridViewTextBoxColumn4.Name = "Pack Type";
            gridViewTextBoxColumn4.Width = 81;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "batch_no";
            gridViewTextBoxColumn5.HeaderText = "Batch No";
            gridViewTextBoxColumn5.Name = "Batch No";
            gridViewTextBoxColumn5.Width = 81;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:MM/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Exp.Date";
            gridViewDateTimeColumn1.Name = "Exp.Date";
            gridViewDateTimeColumn1.Width = 63;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "MRP";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "MRP";
            gridViewDecimalColumn1.Name = "MRP";
            gridViewDecimalColumn1.Width = 64;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "NPR";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "NPR";
            gridViewDecimalColumn2.Name = "NPR";
            gridViewDecimalColumn2.Width = 60;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "packs";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "Qty [P]";
            gridViewDecimalColumn3.Name = "Qty [P]";
            gridViewDecimalColumn3.Width = 46;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "stkNprValue";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "Purch. Value";
            gridViewDecimalColumn4.Name = "Purch. Value";
            gridViewDecimalColumn4.Width = 76;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "stkMrpValue";
            gridViewDecimalColumn5.FormatString = "{0:N2}";
            gridViewDecimalColumn5.HeaderText = "Mrp Value";
            gridViewDecimalColumn5.Name = "Mrp Value";
            gridViewDecimalColumn5.Width = 75;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Category";
            gridViewTextBoxColumn6.HeaderText = "Category";
            gridViewTextBoxColumn6.Name = "Category";
            gridViewTextBoxColumn6.Width = 104;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Shelf_No";
            gridViewTextBoxColumn7.HeaderText = "Location";
            gridViewTextBoxColumn7.Name = "Location";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            sortDescriptor1.PropertyName = "Category";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            sortDescriptor2.PropertyName = "column2";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.FormatString = "{0:N2}";
            gridViewSummaryItem1.Name = "Purch. Value";
            gridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem2.FormatString = "{0:N2}";
            gridViewSummaryItem2.Name = "Mrp Value";
            this.rgv_info.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1,
                gridViewSummaryItem2}));
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(991, 506);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            // 
            // uc_StocksAsOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.rgb);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_StocksAsOn";
            this.Size = new System.Drawing.Size(1076, 512);
            ((System.ComponentModel.ISupportInitialize)(this.rgb)).EndInit();
            this.rgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_xl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_GetStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgb;
        private Telerik.WinControls.UI.RadButton rbtn_xl;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton rbtn_GetStocks;
        private Telerik.WinControls.UI.RadGridView rgv_info;
    }
}
