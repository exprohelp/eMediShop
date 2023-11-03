namespace eMediShop.forms.Product
{
    partial class ucBatchExpMrpCorrection
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBatchExpMrpCorrection));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbBlock = new System.Windows.Forms.GroupBox();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.rgv_items = new Telerik.WinControls.UI.RadGridView();
            this.btnSend = new Telerik.WinControls.UI.RadButton();
            this.txtInformation = new Telerik.WinControls.UI.RadTextBox();
            this.btnModify = new Telerik.WinControls.UI.RadButton();
            this.gbBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMedName
            // 
            this.txtMedName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedName.Location = new System.Drawing.Point(7, 10);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(324, 25);
            this.txtMedName.TabIndex = 30;
            this.txtMedName.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtMedName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedName_KeyDown);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(342, 36);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(218, 16);
            this.lblProduct.TabIndex = 31;
            this.lblProduct.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "BATCH /EXPIRY/MRP CORRECTION";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(45, 18);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(91, 22);
            this.txtBatch.TabIndex = 33;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(189, 18);
            this.txtExpDate.MaxLength = 5;
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(67, 22);
            this.txtExpDate.TabIndex = 34;
            this.txtExpDate.Text = "-";
            this.txtExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpDate.Leave += new System.EventHandler(this.txtExpDate_Leave);
            // 
            // txtMRP
            // 
            this.txtMRP.Location = new System.Drawing.Point(310, 18);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(57, 22);
            this.txtMRP.TabIndex = 35;
            this.txtMRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Batch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Expiry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "MRP";
            // 
            // gbBlock
            // 
            this.gbBlock.Controls.Add(this.txtBatch);
            this.gbBlock.Controls.Add(this.label4);
            this.gbBlock.Controls.Add(this.txtExpDate);
            this.gbBlock.Controls.Add(this.label3);
            this.gbBlock.Controls.Add(this.txtMRP);
            this.gbBlock.Controls.Add(this.label2);
            this.gbBlock.Enabled = false;
            this.gbBlock.Location = new System.Drawing.Point(337, 374);
            this.gbBlock.Name = "gbBlock";
            this.gbBlock.Size = new System.Drawing.Size(588, 50);
            this.gbBlock.TabIndex = 40;
            this.gbBlock.TabStop = false;
            this.gbBlock.Text = "Modification Block";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(339, 55);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "master_key_id";
            gridViewTextBoxColumn1.HeaderText = "Master Key Id";
            gridViewTextBoxColumn1.Name = "master_key_id";
            gridViewTextBoxColumn1.Width = 133;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "batch_no";
            gridViewTextBoxColumn2.HeaderText = "Batch No";
            gridViewTextBoxColumn2.Name = "batch_no";
            gridViewTextBoxColumn2.Width = 105;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatString = "{0:MM-yy}";
            gridViewDateTimeColumn1.HeaderText = "Expiry";
            gridViewDateTimeColumn1.Name = "exp_date";
            gridViewDateTimeColumn1.Width = 75;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pack_type";
            gridViewTextBoxColumn3.HeaderText = "P. Type";
            gridViewTextBoxColumn3.Name = "pack_type";
            gridViewTextBoxColumn3.Width = 70;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "pack_qty";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "P. Qty";
            gridViewDecimalColumn1.Name = "pack_qty";
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "mrp";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "MRP";
            gridViewDecimalColumn2.Name = "MRP";
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "npr";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "NPR";
            gridViewDecimalColumn3.Name = "npr";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "sold_flag";
            gridViewTextBoxColumn4.HeaderText = "Sold Flag";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "sold_flag";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewCommandColumn1,
            gridViewTextBoxColumn4});
            sortDescriptor1.PropertyName = "pack_qty";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(586, 311);
            this.rgv_info.TabIndex = 41;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // rgv_items
            // 
            this.rgv_items.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_items.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_items.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_items.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_items.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_items.Location = new System.Drawing.Point(7, 38);
            // 
            // 
            // 
            this.rgv_items.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "item_id";
            gridViewTextBoxColumn5.HeaderText = "Item id";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "item_id";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "item_name";
            gridViewTextBoxColumn6.HeaderText = "Name of Product";
            gridViewTextBoxColumn6.Name = "item_name";
            gridViewTextBoxColumn6.Width = 259;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.Name = "column1";
            gridViewCommandColumn2.Width = 25;
            this.rgv_items.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn2});
            this.rgv_items.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_items.Name = "rgv_items";
            this.rgv_items.ReadOnly = true;
            this.rgv_items.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_items.ShowGroupPanel = false;
            this.rgv_items.Size = new System.Drawing.Size(324, 459);
            this.rgv_items.TabIndex = 42;
            this.rgv_items.Text = "radGridView1";
            this.rgv_items.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_items_CommandCellClick);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSend.Location = new System.Drawing.Point(855, 459);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 35);
            this.btnSend.TabIndex = 40;
            this.btnSend.Text = "Send For Correction";
            this.btnSend.TextWrap = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.Location = new System.Drawing.Point(337, 431);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.NullText = "Write Information of Correction";
            this.txtInformation.Size = new System.Drawing.Size(588, 23);
            this.txtInformation.TabIndex = 43;
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnModify.Location = new System.Drawing.Point(337, 459);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(70, 36);
            this.btnModify.TabIndex = 44;
            this.btnModify.Text = "Modify By Unit";
            this.btnModify.TextWrap = true;
            this.btnModify.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // ucBatchExpMrpCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rgv_items);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.gbBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtMedName);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucBatchExpMrpCorrection";
            this.Size = new System.Drawing.Size(932, 500);
            this.Load += new System.EventHandler(this.ucBatchExpMrpCorrection_Load);
            this.gbBlock.ResumeLayout(false);
            this.gbBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbBlock;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadGridView rgv_items;
        private Telerik.WinControls.UI.RadButton btnSend;
        private Telerik.WinControls.UI.RadTextBox txtInformation;
        private Telerik.WinControls.UI.RadButton btnModify;
    }
}
