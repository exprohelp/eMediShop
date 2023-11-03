namespace eMediShop.forms.Audit
{
    partial class ImportXtraByPurchase
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPurchId = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            this.btnXL = new Telerik.WinControls.UI.RadButton();
            this.btnProcess = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Id :";
            // 
            // txtPurchId
            // 
            this.txtPurchId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchId.Location = new System.Drawing.Point(98, 9);
            this.txtPurchId.MaxLength = 16;
            this.txtPurchId.Name = "txtPurchId";
            this.txtPurchId.Size = new System.Drawing.Size(167, 25);
            this.txtPurchId.TabIndex = 2;
            this.txtPurchId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPurchId.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPurchId.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(0, 40);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 250;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pack_type";
            gridViewTextBoxColumn3.HeaderText = "P. Type";
            gridViewTextBoxColumn3.Name = "pack_type";
            gridViewTextBoxColumn3.Width = 86;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "pack_qty";
            gridViewTextBoxColumn4.HeaderText = "P. Qty";
            gridViewTextBoxColumn4.Name = "pack_qty";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "batch_no";
            gridViewTextBoxColumn5.HeaderText = "Batch No";
            gridViewTextBoxColumn5.Name = "batch_no";
            gridViewTextBoxColumn5.Width = 94;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:MM-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Exp Date";
            gridViewDateTimeColumn1.Name = "exp_date";
            gridViewDateTimeColumn1.Width = 57;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "trade";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "Trade";
            gridViewDecimalColumn1.Name = "Trade";
            gridViewDecimalColumn1.Width = 67;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "mrp";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "MRP";
            gridViewDecimalColumn2.Name = "mrp";
            gridViewDecimalColumn2.Width = 56;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "tax_rate";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "Tax Rate";
            gridViewDecimalColumn3.Name = "tax_rate";
            gridViewDecimalColumn3.Width = 76;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "npr";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "NPR";
            gridViewDecimalColumn4.Name = "npr";
            gridViewDecimalColumn4.Width = 64;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "qty";
            gridViewDecimalColumn5.FormatString = "{0:N0}";
            gridViewDecimalColumn5.HeaderText = "Qty";
            gridViewDecimalColumn5.Name = "qty";
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "amount";
            gridViewDecimalColumn6.FormatString = "{0:N2}";
            gridViewDecimalColumn6.HeaderText = "Amount";
            gridViewDecimalColumn6.Name = "amount";
            gridViewDecimalColumn6.Width = 67;
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
            gridViewDecimalColumn6});
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.FormatString = "{0:N0}";
            gridViewSummaryItem1.Name = "amount";
            this.rgv_info.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(949, 396);
            this.rgv_info.TabIndex = 3;
            this.rgv_info.Text = "radGridView1";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(271, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(38, 24);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = ">>";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnXL
            // 
            this.btnXL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXL.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnXL.Location = new System.Drawing.Point(757, 3);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(38, 36);
            this.btnXL.TabIndex = 5;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(870, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(79, 36);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note : Only Audit Account Vendor Id\'s Will be processed.";
            // 
            // ImportXtraByPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnXL);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.txtPurchId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ImportXtraByPurchase";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra By Batch Not Found(Import)";
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtPurchId;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnGo;
        private Telerik.WinControls.UI.RadButton btnXL;
        private Telerik.WinControls.UI.RadButton btnProcess;
        private System.Windows.Forms.Label label2;
    }
}