namespace eMediShop.forms.Promo
{
    partial class uc_GenericPromo
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
            Telerik.Pivot.Core.PropertyAggregateDescription propertyAggregateDescription1 = new Telerik.Pivot.Core.PropertyAggregateDescription();
            Telerik.Pivot.Core.SumAggregateFunction sumAggregateFunction1 = new Telerik.Pivot.Core.SumAggregateFunction();
            Telerik.Pivot.Core.PropertyAggregateDescription propertyAggregateDescription2 = new Telerik.Pivot.Core.PropertyAggregateDescription();
            Telerik.Pivot.Core.SumAggregateFunction sumAggregateFunction2 = new Telerik.Pivot.Core.SumAggregateFunction();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription1 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer1 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription2 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer2 = new Telerik.Pivot.Core.GroupNameComparer();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radPivotGrid1 = new Telerik.WinControls.UI.RadPivotGrid();
            this.rbtn_Submit = new Telerik.WinControls.UI.RadButton();
            this.rdtp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rdtp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPivotFieldList1 = new Telerik.WinControls.UI.RadPivotFieldList();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_Submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rbtn_Submit);
            this.radGroupBox1.Controls.Add(this.rdtp_to);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.rdtp_from);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1000, 38);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // radPivotGrid1
            // 
            propertyAggregateDescription1.AggregateFunction = sumAggregateFunction1;
            propertyAggregateDescription1.CustomName = "Sales Value";
            propertyAggregateDescription1.PropertyName = "Amt";
            propertyAggregateDescription1.StringFormat = null;
            propertyAggregateDescription1.StringFormatSelector = null;
            propertyAggregateDescription1.TotalFormat = null;
            propertyAggregateDescription2.AggregateFunction = sumAggregateFunction2;
            propertyAggregateDescription2.CustomName = "Inv. No";
            propertyAggregateDescription2.PropertyName = "Inv_No";
            propertyAggregateDescription2.StringFormat = null;
            propertyAggregateDescription2.StringFormatSelector = null;
            propertyAggregateDescription2.TotalFormat = null;
            this.radPivotGrid1.AggregateDescriptions.Add(propertyAggregateDescription1);
            this.radPivotGrid1.AggregateDescriptions.Add(propertyAggregateDescription2);
            this.radPivotGrid1.AggregatesPosition = Telerik.Pivot.Core.PivotAxis.Columns;
            this.radPivotGrid1.ColumnGrandTotalsPosition = Telerik.WinControls.UI.TotalsPos.Inline;
            this.radPivotGrid1.ColumnsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.Inline;
            this.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPivotGrid1.Location = new System.Drawing.Point(0, 38);
            this.radPivotGrid1.Name = "radPivotGrid1";
            this.radPivotGrid1.RowGrandTotalsPosition = Telerik.WinControls.UI.TotalsPos.Inline;
            propertyGroupDescription1.CustomName = "Worker Name";
            propertyGroupDescription1.GroupComparer = groupNameComparer1;
            propertyGroupDescription1.GroupFilter = null;
            propertyGroupDescription1.PropertyName = "SalesBy";
            propertyGroupDescription1.ShowGroupsWithNoData = false;
            propertyGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription2.CustomName = "Product";
            propertyGroupDescription2.GroupComparer = groupNameComparer2;
            propertyGroupDescription2.GroupFilter = null;
            propertyGroupDescription2.PropertyName = "Product";
            propertyGroupDescription2.ShowGroupsWithNoData = false;
            propertyGroupDescription2.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            this.radPivotGrid1.RowGroupDescriptions.Add(propertyGroupDescription1);
            this.radPivotGrid1.RowGroupDescriptions.Add(propertyGroupDescription2);
            this.radPivotGrid1.RowsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.Inline;
            this.radPivotGrid1.Size = new System.Drawing.Size(769, 452);
            this.radPivotGrid1.TabIndex = 1;
            this.radPivotGrid1.Text = "radPivotGrid1";
            // 
            // rbtn_Submit
            // 
            this.rbtn_Submit.Image = global::eMediShop.Properties.Resources.click16;
            this.rbtn_Submit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Submit.Location = new System.Drawing.Point(333, 9);
            this.rbtn_Submit.Name = "rbtn_Submit";
            this.rbtn_Submit.Size = new System.Drawing.Size(34, 24);
            this.rbtn_Submit.TabIndex = 10;
            this.rbtn_Submit.ThemeName = "ControlDefault";
            this.rbtn_Submit.Click += new System.EventHandler(this.rbtn_Submit_Click);
            // 
            // rdtp_to
            // 
            this.rdtp_to.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtp_to.Location = new System.Drawing.Point(210, 8);
            this.rdtp_to.Name = "rdtp_to";
            this.rdtp_to.Size = new System.Drawing.Size(109, 25);
            this.rdtp_to.TabIndex = 9;
            this.rdtp_to.TabStop = false;
            this.rdtp_to.Text = "20/08/2014";
            this.rdtp_to.Value = new System.DateTime(2014, 8, 20, 17, 7, 19, 795);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(173, 9);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(25, 24);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "To";
            // 
            // rdtp_from
            // 
            this.rdtp_from.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtp_from.Location = new System.Drawing.Point(53, 8);
            this.rdtp_from.Name = "rdtp_from";
            this.rdtp_from.Size = new System.Drawing.Size(109, 25);
            this.rdtp_from.TabIndex = 7;
            this.rdtp_from.TabStop = false;
            this.rdtp_from.Text = "20/08/2014";
            this.rdtp_from.Value = new System.DateTime(2014, 8, 20, 17, 7, 19, 795);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(7, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 24);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "From";
            // 
            // radPivotFieldList1
            // 
            this.radPivotFieldList1.AssociatedPivotGrid = this.radPivotGrid1;
            this.radPivotFieldList1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPivotFieldList1.Location = new System.Drawing.Point(775, 38);
            this.radPivotFieldList1.MinimumSize = new System.Drawing.Size(225, 305);
            this.radPivotFieldList1.Name = "radPivotFieldList1";
            this.radPivotFieldList1.Size = new System.Drawing.Size(225, 452);
            this.radPivotFieldList1.TabIndex = 2;
            this.radPivotFieldList1.ThemeName = null;
            // 
            // uc_GenericPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPivotFieldList1);
            this.Controls.Add(this.radPivotGrid1);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_GenericPromo";
            this.Size = new System.Drawing.Size(1000, 490);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_Submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadPivotGrid radPivotGrid1;
        private Telerik.WinControls.UI.RadButton rbtn_Submit;
        private Telerik.WinControls.UI.RadDateTimePicker rdtp_to;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker rdtp_from;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPivotFieldList radPivotFieldList1;
    }
}
