namespace eMediShop
{
    partial class uc_ExpensiveItems
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rbtn_XL = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rbtn_submit = new Telerik.WinControls.UI.RadButton();
            this.rtxt_value = new Telerik.WinControls.UI.RadTextBox();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_XL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxt_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.comboBox1);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.rbtn_XL);
            this.radGroupBox1.Controls.Add(this.rbtn_submit);
            this.radGroupBox1.Controls.Add(this.rtxt_value);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(834, 39);
            this.radGroupBox1.TabIndex = 0;
            // 
            // rbtn_XL
            // 
            this.rbtn_XL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_XL.Image = global::eMediShop.Properties.Resources.export_excel;
            this.rbtn_XL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_XL.Location = new System.Drawing.Point(786, 6);
            this.rbtn_XL.Name = "rbtn_XL";
            this.rbtn_XL.Size = new System.Drawing.Size(43, 30);
            this.rbtn_XL.TabIndex = 3;
            this.rbtn_XL.Click += new System.EventHandler(this.rbtn_XL_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_XL.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.export_excel;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_XL.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_XL.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_XL.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rbtn_submit
            // 
            this.rbtn_submit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_submit.Image = global::eMediShop.Properties.Resources.click_32;
            this.rbtn_submit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_submit.Location = new System.Drawing.Point(188, 9);
            this.rbtn_submit.Name = "rbtn_submit";
            this.rbtn_submit.Size = new System.Drawing.Size(43, 30);
            this.rbtn_submit.TabIndex = 2;
            this.rbtn_submit.Click += new System.EventHandler(this.rbtn_submit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_submit.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.click_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_submit.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_submit.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtn_submit.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rtxt_value
            // 
            this.rtxt_value.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_value.Location = new System.Drawing.Point(102, 13);
            this.rtxt_value.Name = "rtxt_value";
            // 
            // 
            // 
            this.rtxt_value.RootElement.Shape = this.roundRectShape1;
            this.rtxt_value.Size = new System.Drawing.Size(66, 25);
            this.rtxt_value.TabIndex = 1;
            this.rtxt_value.Text = "500";
            this.rtxt_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtxt_value.GetChildAt(0))).Text = "500";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtxt_value.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(0, 39);
            // 
            // rgv_info
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AllowDeleteRow = false;
            this.rgv_info.MasterTemplate.AllowEditRow = false;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unit_id";
            gridViewTextBoxColumn1.HeaderText = "Unit Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Unit Id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "sh_name";
            gridViewTextBoxColumn2.HeaderText = "Unit";
            gridViewTextBoxColumn2.Name = "Unit";
            gridViewTextBoxColumn2.Width = 145;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_id";
            gridViewTextBoxColumn3.HeaderText = "Item Id";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Item Id";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "item_name";
            gridViewTextBoxColumn4.HeaderText = "Name of Product";
            gridViewTextBoxColumn4.Name = "Name of Product";
            gridViewTextBoxColumn4.Width = 290;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "usavg";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "Avg[U]";
            gridViewDecimalColumn1.Name = "Avg[U]";
            gridViewDecimalColumn1.Width = 80;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "gsavg";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Avg [G]";
            gridViewDecimalColumn2.Name = "Avg [G]";
            gridViewDecimalColumn2.Width = 72;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "StkInPack";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Stk [Packs]";
            gridViewDecimalColumn3.Name = "Stk [Packs]";
            gridViewDecimalColumn3.Width = 68;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "stkValue";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "Value [Stk]";
            gridViewDecimalColumn4.Name = "Value [Stk]";
            gridViewDecimalColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDecimalColumn4.Width = 77;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn1.FieldName = "trfDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Date [Last Trf]";
            gridViewDateTimeColumn1.Name = "Date [Last Trf]";
            gridViewDateTimeColumn1.Width = 89;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn2.FieldName = "saleDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.FormatString = "{0:dd/MM/yyyy}";
            gridViewDateTimeColumn2.HeaderText = "Date [Last Sale]";
            gridViewDateTimeColumn2.Name = "Date [Last Sale]";
            gridViewDateTimeColumn2.Width = 83;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2});
            sortDescriptor1.PropertyName = "Unit";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            sortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor2.PropertyName = "Value [Stk]";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.FormatString = "{0:N2}";
            gridViewSummaryItem1.Name = "Value [Stk]";
            this.rgv_info.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(832, 451);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_info_CellDoubleClick);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(5, 14);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(37, 24);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "NPR";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "=",
            ">=",
            "<=",
            "<>"});
            this.comboBox1.Location = new System.Drawing.Point(49, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = ">=";
            // 
            // uc_ExpensiveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_ExpensiveItems";
            this.Size = new System.Drawing.Size(834, 490);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_XL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxt_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox rtxt_value;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton rbtn_submit;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton rbtn_XL;
        private System.Windows.Forms.ComboBox comboBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;

    }
}
