namespace eMediShop.forms.Stock
{
    partial class ucExpiryProcess
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnStock = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.cmbPendingIds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Process = new System.Windows.Forms.Button();
            this.btnFillrecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Enabled = false;
            this.btnStock.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(732, 6);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(112, 31);
            this.btnStock.TabIndex = 20;
            this.btnStock.Text = "Check Expired";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Enabled = false;
            this.btn_Finish.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finish.Location = new System.Drawing.Point(726, 468);
            this.btn_Finish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(118, 28);
            this.btn_Finish.TabIndex = 32;
            this.btn_Finish.Text = "Complete";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(5, 44);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item Code";
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 79;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "master_key_id";
            gridViewTextBoxColumn2.HeaderText = "Master Key";
            gridViewTextBoxColumn2.Name = "master_key_id";
            gridViewTextBoxColumn2.Width = 117;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Product";
            gridViewTextBoxColumn3.Name = "item_name";
            gridViewTextBoxColumn3.Width = 229;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "batch_no";
            gridViewTextBoxColumn4.HeaderText = "Batch No";
            gridViewTextBoxColumn4.Name = "batch_no";
            gridViewTextBoxColumn4.Width = 97;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Expiry";
            gridViewDateTimeColumn1.Name = "exp_date";
            gridViewDateTimeColumn1.Width = 62;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "packs";
            gridViewDecimalColumn1.HeaderText = "Packs";
            gridViewDecimalColumn1.Name = "packs";
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "quantity";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.Name = "qty";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2});
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "item_id";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(712, 453);
            this.rgv_info.TabIndex = 39;
            this.rgv_info.Text = "radGridView1";
            // 
            // cmbPendingIds
            // 
            this.cmbPendingIds.FormattingEnabled = true;
            this.cmbPendingIds.Location = new System.Drawing.Point(74, 14);
            this.cmbPendingIds.Name = "cmbPendingIds";
            this.cmbPendingIds.Size = new System.Drawing.Size(218, 24);
            this.cmbPendingIds.TabIndex = 40;
            this.cmbPendingIds.SelectedIndexChanged += new System.EventHandler(this.cmbPendingIds_SelectedIndexChanged);
            this.cmbPendingIds.SelectionChangeCommitted += new System.EventHandler(this.cmbPendingIds_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id\'s Info";
            // 
            // btn_Process
            // 
            this.btn_Process.Enabled = false;
            this.btn_Process.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(730, 74);
            this.btn_Process.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(117, 28);
            this.btn_Process.TabIndex = 24;
            this.btn_Process.Text = "PROCESS";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // btnFillrecords
            // 
            this.btnFillrecords.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillrecords.Location = new System.Drawing.Point(298, 11);
            this.btnFillrecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFillrecords.Name = "btnFillrecords";
            this.btnFillrecords.Size = new System.Drawing.Size(84, 28);
            this.btnFillrecords.TabIndex = 42;
            this.btnFillrecords.Text = "Fill Records";
            this.btnFillrecords.UseVisualStyleBackColor = true;
            this.btnFillrecords.Visible = false;
            this.btnFillrecords.Click += new System.EventHandler(this.btnFillrecords_Click);
            // 
            // ucExpiryProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFillrecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPendingIds);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.btnStock);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucExpiryProcess";
            this.Size = new System.Drawing.Size(851, 500);
            this.Load += new System.EventHandler(this.ucExpiryReconcile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private System.Windows.Forms.ComboBox cmbPendingIds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Button btnFillrecords;
    }
}
