namespace eMediShop.forms.Product
{
    partial class ucMkeyCorrection
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMkeyCorrection));
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnView = new System.Windows.Forms.Button();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtPackType = new System.Windows.Forms.TextBox();
            this.txtPackQty = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnReplace = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rgv_editkey = new Telerik.WinControls.UI.RadGridView();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_editkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_editkey.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(3, 0);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 25);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "GET RECORDS";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.AcceptsReturn = true;
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBatch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.Location = new System.Drawing.Point(134, 404);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBatch.MaxLength = 5;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(75, 26);
            this.txtBatch.TabIndex = 4;
            this.txtBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBatch.Enter += new System.EventHandler(this.txtBatch_Enter);
            // 
            // txtPackType
            // 
            this.txtPackType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPackType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackType.Location = new System.Drawing.Point(215, 404);
            this.txtPackType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPackType.Name = "txtPackType";
            this.txtPackType.Size = new System.Drawing.Size(65, 26);
            this.txtPackType.TabIndex = 5;
            // 
            // txtPackQty
            // 
            this.txtPackQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackQty.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackQty.Location = new System.Drawing.Point(290, 404);
            this.txtPackQty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPackQty.Name = "txtPackQty";
            this.txtPackQty.Size = new System.Drawing.Size(60, 26);
            this.txtPackQty.TabIndex = 6;
            this.txtPackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPackQty.Enter += new System.EventHandler(this.txtPackQty_Enter);
            // 
            // txtMRP
            // 
            this.txtMRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(364, 404);
            this.txtMRP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(63, 26);
            this.txtMRP.TabIndex = 7;
            this.txtMRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMRP.Enter += new System.EventHandler(this.txtMRP_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Batch No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pack Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pack Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "MRP";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(474, 397);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 32);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "UPDATE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Exp.Date";
            // 
            // txtExpDate
            // 
            this.txtExpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExpDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Location = new System.Drawing.Point(66, 404);
            this.txtExpDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtExpDate.MaxLength = 5;
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(58, 26);
            this.txtExpDate.TabIndex = 16;
            this.txtExpDate.Text = "-";
            this.txtExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpDate.Enter += new System.EventHandler(this.txtExpDate_Enter);
            this.txtExpDate.Leave += new System.EventHandler(this.txtExpDate_Leave);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rgv_info);
            this.gbInfo.Controls.Add(this.btnReplace);
            this.gbInfo.Controls.Add(this.txtBatch);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.txtPackType);
            this.gbInfo.Controls.Add(this.txtExpDate);
            this.gbInfo.Controls.Add(this.txtPackQty);
            this.gbInfo.Controls.Add(this.btnSave);
            this.gbInfo.Controls.Add(this.txtMRP);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Location = new System.Drawing.Point(369, 23);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbInfo.Size = new System.Drawing.Size(800, 435);
            this.gbInfo.TabIndex = 18;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "[XXXXXXXXXXXXXXXXXXXXXX]";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(5, 25);
            this.rgv_info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unit_name";
            gridViewTextBoxColumn1.HeaderText = "Unit";
            gridViewTextBoxColumn1.Name = "unit_name";
            gridViewTextBoxColumn1.Width = 172;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "eType";
            gridViewTextBoxColumn2.HeaderText = "eType";
            gridViewTextBoxColumn2.Name = "eType";
            gridViewTextBoxColumn2.Width = 76;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_id";
            gridViewTextBoxColumn3.HeaderText = "Item Id";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "item_id";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "batch_no";
            gridViewTextBoxColumn4.HeaderText = "Batch No";
            gridViewTextBoxColumn4.Name = "batch_no";
            gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn4.Width = 78;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:MM-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Expiry";
            gridViewDateTimeColumn1.Name = "exp_date";
            gridViewDateTimeColumn1.Width = 61;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "pack_type";
            gridViewTextBoxColumn5.HeaderText = "P.Type";
            gridViewTextBoxColumn5.Name = "pack_type";
            gridViewTextBoxColumn5.Width = 67;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "pack_qty";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "P.Qty";
            gridViewDecimalColumn1.Name = "pack_qty";
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "mrp";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "MRP";
            gridViewDecimalColumn2.Name = "mrp";
            gridViewDecimalColumn2.Width = 63;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "npr";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "NPR";
            gridViewDecimalColumn3.Name = "npr";
            gridViewDecimalColumn3.Width = 67;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "pis";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "S.Packs";
            gridViewDecimalColumn4.Name = "pis";
            gridViewDecimalColumn4.Width = 67;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "seqno";
            gridViewTextBoxColumn6.HeaderText = "Seq No";
            gridViewTextBoxColumn6.Name = "seqno";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn6});
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "batch_no";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(791, 354);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReplace.Location = new System.Drawing.Point(589, 397);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(77, 32);
            this.btnReplace.TabIndex = 19;
            this.btnReplace.Text = "Replace Item";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // rgv_editkey
            // 
            this.rgv_editkey.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_editkey.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_editkey.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.rgv_editkey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_editkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_editkey.Location = new System.Drawing.Point(3, 31);
            this.rgv_editkey.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            // 
            // 
            // 
            this.rgv_editkey.MasterTemplate.AllowAddNewRow = false;
            this.rgv_editkey.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "sh_name";
            gridViewTextBoxColumn7.HeaderText = "Name of Unit";
            gridViewTextBoxColumn7.Name = "sh_name";
            gridViewTextBoxColumn7.Width = 142;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "master_key_id";
            gridViewTextBoxColumn8.HeaderText = "Master Key";
            gridViewTextBoxColumn8.Name = "master_key_id";
            gridViewTextBoxColumn8.Width = 149;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "remark";
            gridViewTextBoxColumn9.HeaderText = "Remarks";
            gridViewTextBoxColumn9.Name = "remark";
            gridViewTextBoxColumn9.Width = 252;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_editkey.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewCommandColumn1});
            sortDescriptor2.PropertyName = "sh_name";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            sortDescriptor3.PropertyName = "master_key_id";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_editkey.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1,
            groupDescriptor2});
            this.rgv_editkey.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_editkey.Name = "rgv_editkey";
            this.rgv_editkey.ReadOnly = true;
            this.rgv_editkey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_editkey.Size = new System.Drawing.Size(360, 427);
            this.rgv_editkey.TabIndex = 20;
            this.rgv_editkey.Text = "radGridView1";
            this.rgv_editkey.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            this.rgv_editkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasterTemplate_KeyDown);
            // 
            // ucMkeyCorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_editkey);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnView);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucMkeyCorrection";
            this.Size = new System.Drawing.Size(1171, 466);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_editkey.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_editkey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtPackType;
        private System.Windows.Forms.TextBox txtPackQty;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadGridView rgv_editkey;
    }
}
