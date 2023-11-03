namespace eMediShop.Hospital
{
    partial class IPD_BulkSalesReturn
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPDNO = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.rgv_ReturnInfo = new Telerik.WinControls.UI.RadGridView();
            this.btnGenerate = new Telerik.WinControls.UI.RadButton();
            this.cmbPayMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPDNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ReturnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ReturnInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type IPD No.";
            // 
            // txtIPDNO
            // 
            this.txtIPDNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIPDNO.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPDNO.Location = new System.Drawing.Point(105, 8);
            this.txtIPDNO.MaxLength = 16;
            this.txtIPDNO.Name = "txtIPDNO";
            this.txtIPDNO.Size = new System.Drawing.Size(140, 23);
            this.txtIPDNO.TabIndex = 1;
            this.txtIPDNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIPDNO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIPDNO_KeyUp);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtIPDNO.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtIPDNO.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(510, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(60, 26);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = "Submit";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_ReturnInfo
            // 
            this.rgv_ReturnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_ReturnInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_ReturnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_ReturnInfo.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.rgv_ReturnInfo.ForeColor = System.Drawing.Color.Black;
            this.rgv_ReturnInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_ReturnInfo.Location = new System.Drawing.Point(0, 37);
            // 
            // 
            // 
            this.rgv_ReturnInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "item_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 396;
            gridViewTextBoxColumn3.AllowFiltering = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "master_key_id";
            gridViewTextBoxColumn3.HeaderText = "master_key_id";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "master_key_id";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "batch_no";
            gridViewTextBoxColumn4.HeaderText = "Batch No";
            gridViewTextBoxColumn4.Name = "batch_no";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.AllowFiltering = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "exp_date";
            gridViewTextBoxColumn5.FormatString = "{0:MM-yyyy}";
            gridViewTextBoxColumn5.HeaderText = "Expiry";
            gridViewTextBoxColumn5.Name = "exp_date";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 56;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "mrp";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "MRP";
            gridViewDecimalColumn1.Name = "mrp";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 91;
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "usr";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "USR";
            gridViewDecimalColumn2.Name = "usr";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 100;
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "sale_qty";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Sold Qty";
            gridViewDecimalColumn3.Name = "sale_qty";
            gridViewDecimalColumn3.ReadOnly = true;
            gridViewDecimalColumn3.Width = 92;
            gridViewDecimalColumn4.AllowFiltering = false;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Ret_Qty";
            gridViewDecimalColumn4.HeaderText = "Return Qty";
            gridViewDecimalColumn4.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            gridViewDecimalColumn4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            gridViewDecimalColumn4.Name = "Ret_Qty";
            gridViewDecimalColumn4.Width = 100;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "sale_inv_no";
            gridViewTextBoxColumn6.HeaderText = "sale_inv_no";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "sale_inv_no";
            this.rgv_ReturnInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn6});
            this.rgv_ReturnInfo.MasterTemplate.EnableFiltering = true;
            this.rgv_ReturnInfo.MasterTemplate.EnableGrouping = false;
            this.rgv_ReturnInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_ReturnInfo.Name = "rgv_ReturnInfo";
            this.rgv_ReturnInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_ReturnInfo.Size = new System.Drawing.Size(974, 502);
            this.rgv_ReturnInfo.TabIndex = 3;
            this.rgv_ReturnInfo.Text = "radGridView1";
            this.rgv_ReturnInfo.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.MasterTemplate_RowFormatting);
            this.rgv_ReturnInfo.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_ReturnInfo_ViewCellFormatting);
            this.rgv_ReturnInfo.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.MasterTemplate_CellBeginEdit);
            this.rgv_ReturnInfo.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_ReturnInfo_CellEditorInitialized);
            this.rgv_ReturnInfo.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellEndEdit);
            this.rgv_ReturnInfo.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.MasterTemplate_CellValueChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(785, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 26);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Return Invoice";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnGenerate.GetChildAt(0))).Text = "Generate Return Invoice";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnGenerate.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // cmbPayMode
            // 
            this.cmbPayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayMode.FormattingEnabled = true;
            this.cmbPayMode.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbPayMode.Location = new System.Drawing.Point(316, 7);
            this.cmbPayMode.Name = "cmbPayMode";
            this.cmbPayMode.Size = new System.Drawing.Size(121, 21);
            this.cmbPayMode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Return In ";
            // 
            // IPD_BulkSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPayMode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rgv_ReturnInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtIPDNO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IPD_BulkSalesReturn";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPD Bulk Sales Return";
            this.Load += new System.EventHandler(this.IPD_BulkSalesReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIPDNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ReturnInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ReturnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtIPDNO;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadGridView rgv_ReturnInfo;
        private Telerik.WinControls.UI.RadButton btnGenerate;
        private System.Windows.Forms.ComboBox cmbPayMode;
        private System.Windows.Forms.Label label2;
    }
}