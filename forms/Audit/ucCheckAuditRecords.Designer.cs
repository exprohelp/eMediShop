namespace eMediShop.forms.Audit
{
    partial class ucCheckAuditRecords
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnProcess = new Telerik.WinControls.UI.RadButton();
            this.btn_Export = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.rbExtra = new Telerik.WinControls.UI.RadRadioButton();
            this.rbShortage = new Telerik.WinControls.UI.RadRadioButton();
            this.eMediShop = new eMediShop.dsCollection.eMediShop();
            this.auditCheckingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbShortage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMediShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditCheckingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnProcess);
            this.radGroupBox1.Controls.Add(this.btn_Export);
            this.radGroupBox1.Controls.Add(this.btnSubmit);
            this.radGroupBox1.Controls.Add(this.rbExtra);
            this.radGroupBox1.Controls.Add(this.rbShortage);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Criteria";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(222, 500);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Criteria";
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProcess.Location = new System.Drawing.Point(43, 437);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(108, 33);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Export.Location = new System.Drawing.Point(109, 99);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(108, 33);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "Export to XL";
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(12, 99);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 33);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbExtra
            // 
            this.rbExtra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbExtra.Location = new System.Drawing.Point(94, 24);
            this.rbExtra.Name = "rbExtra";
            this.rbExtra.Size = new System.Drawing.Size(51, 21);
            this.rbExtra.TabIndex = 1;
            this.rbExtra.Text = "Extra";
            // 
            // rbShortage
            // 
            this.rbShortage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbShortage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbShortage.Location = new System.Drawing.Point(12, 24);
            this.rbShortage.Name = "rbShortage";
            this.rbShortage.Size = new System.Drawing.Size(76, 21);
            this.rbShortage.TabIndex = 0;
            this.rbShortage.Text = "Shortage";
            this.rbShortage.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // eMediShop
            // 
            this.eMediShop.DataSetName = "eMediShop";
            this.eMediShop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditCheckingBindingSource
            // 
            this.auditCheckingBindingSource.DataMember = "AuditChecking";
            this.auditCheckingBindingSource.DataSource = this.eMediShop;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(240, 14);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Item_Id";
            gridViewTextBoxColumn1.HeaderText = "Item ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "Name of Product";
            gridViewTextBoxColumn2.Width = 219;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Master_Key_Id";
            gridViewTextBoxColumn3.HeaderText = "Master Key";
            gridViewTextBoxColumn3.Name = "Master Key";
            gridViewTextBoxColumn3.Width = 120;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "pack_type";
            gridViewTextBoxColumn4.HeaderText = "pack_type";
            gridViewTextBoxColumn4.Name = "pack_type";
            gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn4.Width = 85;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "pack_qty";
            gridViewTextBoxColumn5.HeaderText = "pack_qty";
            gridViewTextBoxColumn5.Name = "pack_qty";
            gridViewTextBoxColumn5.Width = 66;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "batch_no";
            gridViewTextBoxColumn6.HeaderText = "batch_no";
            gridViewTextBoxColumn6.Name = "batch_no";
            gridViewTextBoxColumn6.Width = 114;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "exp_date";
            gridViewTextBoxColumn7.HeaderText = "exp_date";
            gridViewTextBoxColumn7.Name = "exp_date";
            gridViewTextBoxColumn7.Width = 81;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "qty";
            gridViewDecimalColumn1.HeaderText = "Qty (Audit)";
            gridViewDecimalColumn1.Name = "Qty (Audit)";
            gridViewDecimalColumn1.Width = 70;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "amount";
            gridViewDecimalColumn2.HeaderText = "Amount";
            gridViewDecimalColumn2.Name = "amount";
            gridViewDecimalColumn3.AllowGroup = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Quantity";
            gridViewDecimalColumn3.HeaderText = "Qty (Stk)";
            gridViewDecimalColumn3.Name = "Qty (Stk)";
            gridViewDecimalColumn3.Width = 70;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "remarks";
            gridViewTextBoxColumn8.HeaderText = "remarks";
            gridViewTextBoxColumn8.Name = "remarks";
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "trf_id";
            gridViewTextBoxColumn9.HeaderText = "trf_id";
            gridViewTextBoxColumn9.Name = "trf_id";
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "trf_flag";
            gridViewTextBoxColumn10.HeaderText = "trf_flag";
            gridViewTextBoxColumn10.Name = "trf_flag";
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "diff_flag";
            gridViewTextBoxColumn11.HeaderText = "diff_flag";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "diff_flag";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "pack_type";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "amount";
            this.rgv_info.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(834, 489);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_info_RowFormatting);
            // 
            // ucCheckAuditRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucCheckAuditRecords";
            this.Size = new System.Drawing.Size(1077, 506);
            this.Load += new System.EventHandler(this.ucCheckAuditRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbShortage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMediShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditCheckingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadRadioButton rbExtra;
        private Telerik.WinControls.UI.RadRadioButton rbShortage;
        private dsCollection.eMediShop eMediShop;
        private System.Windows.Forms.BindingSource auditCheckingBindingSource;
        private Telerik.WinControls.UI.RadButton btn_Export;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnProcess;
    }
}
