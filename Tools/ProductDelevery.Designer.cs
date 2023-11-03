namespace eMediShop.Tools
{
    partial class ProductDelevery
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDelevery));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rtb_receive = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rgv_tokenInfo = new Telerik.WinControls.UI.RadGridView();
            this.rgv_detail = new Telerik.WinControls.UI.RadGridView();
            this.btnDelivered = new Telerik.WinControls.UI.RadButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_receive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_tokenInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_tokenInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelivered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_receive
            // 
            this.rtb_receive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_receive.Location = new System.Drawing.Point(674, 5);
            this.rtb_receive.Name = "rtb_receive";
            this.rtb_receive.NullText = "Type Sales Invoice No. To Receive";
            this.rtb_receive.Size = new System.Drawing.Size(274, 25);
            this.rtb_receive.TabIndex = 0;
            this.rtb_receive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rtb_receive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_receive_KeyDown);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_receive.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_receive.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).NullText = "Type Sales Invoice No. To Receive";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).ToolTipText = "After Typing Press Enter Key";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_tokenInfo
            // 
            this.rgv_tokenInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_tokenInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_tokenInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_tokenInfo.ForeColor = System.Drawing.Color.Black;
            this.rgv_tokenInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_tokenInfo.Location = new System.Drawing.Point(4, 36);
            // 
            // 
            // 
            this.rgv_tokenInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "token_no";
            gridViewDecimalColumn1.HeaderText = "Token";
            gridViewDecimalColumn1.Name = "token_no";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "sale_inv_no";
            gridViewTextBoxColumn1.HeaderText = "sale_inv_no";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "sale_inv_no";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "cust_name";
            gridViewTextBoxColumn2.HeaderText = "Customer Name";
            gridViewTextBoxColumn2.Name = "cust_name";
            gridViewTextBoxColumn2.Width = 162;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_tokenInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            this.rgv_tokenInfo.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_tokenInfo.MasterTemplate.EnableFiltering = true;
            this.rgv_tokenInfo.MasterTemplate.EnableGrouping = false;
            this.rgv_tokenInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_tokenInfo.Name = "rgv_tokenInfo";
            this.rgv_tokenInfo.ReadOnly = true;
            this.rgv_tokenInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_tokenInfo.Size = new System.Drawing.Size(274, 508);
            this.rgv_tokenInfo.TabIndex = 1;
            this.rgv_tokenInfo.Text = "radGridView1";
            this.rgv_tokenInfo.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_tokenInfo_CommandCellClick);
            // 
            // rgv_detail
            // 
            this.rgv_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_detail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_detail.ForeColor = System.Drawing.Color.Black;
            this.rgv_detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_detail.Location = new System.Drawing.Point(284, 36);
            // 
            // 
            // 
            this.rgv_detail.MasterTemplate.AllowAddNewRow = false;
            this.rgv_detail.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Product";
            gridViewTextBoxColumn3.Name = "item_name";
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn3.Width = 240;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "mfd_name";
            gridViewTextBoxColumn4.HeaderText = "Mkt/Mfd By";
            gridViewTextBoxColumn4.Name = "mfd_name";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "batch_no";
            gridViewTextBoxColumn5.HeaderText = "Batch No";
            gridViewTextBoxColumn5.Name = "batch_no";
            gridViewTextBoxColumn5.Width = 95;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "exp_date";
            gridViewTextBoxColumn6.HeaderText = "Expiry";
            gridViewTextBoxColumn6.Name = "exp_date";
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "sale_qty";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Sold Qty";
            gridViewDecimalColumn2.Name = "sale_qty";
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "salesinpack";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "Sold(P)";
            gridViewDecimalColumn3.Name = "salesinpack";
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "unit_mrp";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "MRP";
            gridViewDecimalColumn4.Name = "mrp";
            this.rgv_detail.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4});
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "item_name";
            this.rgv_detail.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_detail.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_detail.Name = "rgv_detail";
            this.rgv_detail.ReadOnly = true;
            this.rgv_detail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_detail.ShowGroupPanel = false;
            this.rgv_detail.Size = new System.Drawing.Size(664, 458);
            this.rgv_detail.TabIndex = 2;
            this.rgv_detail.Text = "radGridView2";
            // 
            // btnDelivered
            // 
            this.btnDelivered.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivered.Location = new System.Drawing.Point(838, 502);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(110, 40);
            this.btnDelivered.TabIndex = 3;
            this.btnDelivered.Text = "Checcked";
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(284, 516);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(136, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total No. XXXXXXX";
            // 
            // ProductDelevery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 545);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.rgv_detail);
            this.Controls.Add(this.rgv_tokenInfo);
            this.Controls.Add(this.rtb_receive);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductDelevery";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine Checking";
            this.Load += new System.EventHandler(this.ProductDelevery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rtb_receive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_tokenInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_tokenInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelivered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox rtb_receive;
        private Telerik.WinControls.UI.RadGridView rgv_tokenInfo;
        private Telerik.WinControls.UI.RadGridView rgv_detail;
        private Telerik.WinControls.UI.RadButton btnDelivered;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotal;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
    }
}