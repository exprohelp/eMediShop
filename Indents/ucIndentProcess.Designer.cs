namespace eMediShop.Indents
{
    partial class ucIndentProcess
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucIndentProcess));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor5 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_unit = new Telerik.WinControls.UI.RadGridView();
            this.rgv_detail = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnVerify = new Telerik.WinControls.UI.RadButton();
            this.btnProcess = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_unit
            // 
            this.rgv_unit.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_unit.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_unit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rgv_unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_unit.Location = new System.Drawing.Point(4, 4);
            // 
            // 
            // 
            this.rgv_unit.MasterTemplate.AllowAddNewRow = false;
            this.rgv_unit.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unit_id";
            gridViewTextBoxColumn1.HeaderText = "Unit ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "unit_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "unit_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Unit";
            gridViewTextBoxColumn2.Name = "Name of Unit";
            gridViewTextBoxColumn2.Width = 240;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "indent_no";
            gridViewTextBoxColumn3.HeaderText = "Indent No";
            gridViewTextBoxColumn3.Name = "indent_no";
            gridViewTextBoxColumn3.Width = 195;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.HeaderImage")));
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column3";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "process_type";
            gridViewTextBoxColumn4.HeaderText = "Process By:";
            gridViewTextBoxColumn4.Name = "process_type";
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "cr_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Date";
            gridViewDateTimeColumn1.Name = "cr_date";
            gridViewDateTimeColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            this.rgv_unit.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1});
            sortDescriptor1.PropertyName = "Name of Unit";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            sortDescriptor2.PropertyName = "cr_date";
            sortDescriptor3.PropertyName = "process_type";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2,
            sortDescriptor3});
            this.rgv_unit.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1,
            groupDescriptor2});
            sortDescriptor4.PropertyName = "cr_date";
            this.rgv_unit.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.rgv_unit.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_unit.Name = "rgv_unit";
            this.rgv_unit.ReadOnly = true;
            this.rgv_unit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_unit.ShowGroupPanel = false;
            this.rgv_unit.Size = new System.Drawing.Size(314, 484);
            this.rgv_unit.TabIndex = 0;
            this.rgv_unit.Text = "radGridView1";
            this.rgv_unit.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_unit_CommandCellClick);
            // 
            // rgv_detail
            // 
            this.rgv_detail.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_detail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_detail.ForeColor = System.Drawing.Color.Black;
            this.rgv_detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_detail.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_detail.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "auto_id";
            gridViewTextBoxColumn5.HeaderText = "auto id";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "auto_id";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "item_id";
            gridViewTextBoxColumn6.HeaderText = "Item ID";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "item_id";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "item_name";
            gridViewTextBoxColumn7.HeaderText = "Name of Product";
            gridViewTextBoxColumn7.Name = "item_name";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 284;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "instock";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "In Stock";
            gridViewDecimalColumn1.Name = "instock";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 57;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "qty";
            gridViewDecimalColumn2.FormatString = "{0:N0}";
            gridViewDecimalColumn2.HeaderText = "Req. Qty";
            gridViewDecimalColumn2.Name = "qty";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "conf_qty";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Conf Qty";
            gridViewDecimalColumn3.Name = "conf_qty";
            gridViewDecimalColumn3.Width = 69;
            gridViewComboBoxColumn1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "conf_flag";
            gridViewComboBoxColumn1.HeaderText = "Conf Flag";
            gridViewComboBoxColumn1.Name = "conf_flag";
            gridViewComboBoxColumn1.Width = 63;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "remarks";
            gridViewTextBoxColumn8.HeaderText = "Remarks";
            gridViewTextBoxColumn8.Name = "remarks";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn8.Width = 231;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "verified";
            gridViewTextBoxColumn9.HeaderText = "Verified";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "verified";
            this.rgv_detail.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            sortDescriptor5.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor5.PropertyName = "remarks";
            this.rgv_detail.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor5});
            this.rgv_detail.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_detail.Name = "rgv_detail";
            this.rgv_detail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_detail.ShowGroupPanel = false;
            this.rgv_detail.Size = new System.Drawing.Size(773, 426);
            this.rgv_detail.TabIndex = 1;
            this.rgv_detail.Text = "radGridView2";
            this.rgv_detail.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_detail_RowFormatting);
            this.rgv_detail.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.rgv_detail_CellBeginEdit);
            this.rgv_detail.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_detail_CellEndEdit);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_detail);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(325, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(780, 446);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "XXXXXXXX";
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(327, 456);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(87, 30);
            this.btnVerify.TabIndex = 92;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnVerify.GetChildAt(0))).Text = "Verify";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnVerify.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnVerify.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(1013, 454);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(87, 30);
            this.btnProcess.TabIndex = 93;
            this.btnProcess.Text = "-";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnProcess.GetChildAt(0))).Text = "-";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnProcess.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnProcess.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // ucIndentProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.rgv_unit);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucIndentProcess";
            this.Size = new System.Drawing.Size(1108, 491);
            this.Load += new System.EventHandler(this.ucIndentProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVerify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_unit;
        private Telerik.WinControls.UI.RadGridView rgv_detail;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton btnVerify;
        private Telerik.WinControls.UI.RadButton btnProcess;
    }
}
