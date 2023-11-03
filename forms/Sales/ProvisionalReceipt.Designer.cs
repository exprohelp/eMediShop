namespace eMediShop.forms.Sales
{
    partial class ProvisionalReceipt
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvisionalReceipt));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rtxt_CardNo = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.ItemSaleGrid = new System.Windows.Forms.ListView();
            this.Master_Key_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BatchNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Packq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tax_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinv_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rtxt_CardNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxt_CardNo
            // 
            this.rtxt_CardNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_CardNo.Location = new System.Drawing.Point(1, 3);
            this.rtxt_CardNo.Name = "rtxt_CardNo";
            this.rtxt_CardNo.NullText = "Type Card No && Press Enter";
            this.rtxt_CardNo.Size = new System.Drawing.Size(201, 25);
            this.rtxt_CardNo.TabIndex = 0;
            this.rtxt_CardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rtxt_CardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_CardNo_KeyDown);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtxt_CardNo.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtxt_CardNo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(1, 31);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "sale_inv_no";
            gridViewTextBoxColumn1.HeaderText = "Sale Inv No";
            gridViewTextBoxColumn1.Name = "sale_inv_no";
            gridViewTextBoxColumn1.Width = 134;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(203, 181);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // ItemSaleGrid
            // 
            this.ItemSaleGrid.BackColor = System.Drawing.Color.LemonChiffon;
            this.ItemSaleGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Master_Key_No,
            this.Item_Name,
            this.BatchNo,
            this.ExpDate,
            this.packs,
            this.Packq,
            this.MRP,
            this.uRate,
            this.Tax_Id,
            this.qty,
            this.amount,
            this.ItemId,
            this.cinv_no});
            this.ItemSaleGrid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.ItemSaleGrid.ForeColor = System.Drawing.Color.Navy;
            this.ItemSaleGrid.FullRowSelect = true;
            this.ItemSaleGrid.GridLines = true;
            this.ItemSaleGrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ItemSaleGrid.Location = new System.Drawing.Point(1, 239);
            this.ItemSaleGrid.Name = "ItemSaleGrid";
            this.ItemSaleGrid.Size = new System.Drawing.Size(931, 228);
            this.ItemSaleGrid.TabIndex = 2;
            this.ItemSaleGrid.UseCompatibleStateImageBehavior = false;
            this.ItemSaleGrid.View = System.Windows.Forms.View.Details;
            // 
            // Master_Key_No
            // 
            this.Master_Key_No.Text = "Master_Key_No";
            this.Master_Key_No.Width = 0;
            // 
            // Item_Name
            // 
            this.Item_Name.Text = "Name of Item";
            this.Item_Name.Width = 283;
            // 
            // BatchNo
            // 
            this.BatchNo.Text = "Batch No";
            this.BatchNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BatchNo.Width = 90;
            // 
            // ExpDate
            // 
            this.ExpDate.Text = "Exp.Date";
            this.ExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExpDate.Width = 82;
            // 
            // packs
            // 
            this.packs.Text = "Pack Size";
            this.packs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.packs.Width = 75;
            // 
            // Packq
            // 
            this.Packq.Text = "Pack Qty";
            this.Packq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Packq.Width = 70;
            // 
            // MRP
            // 
            this.MRP.Text = "MRP";
            this.MRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MRP.Width = 73;
            // 
            // uRate
            // 
            this.uRate.Text = "Unit Rate";
            this.uRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uRate.Width = 74;
            // 
            // Tax_Id
            // 
            this.Tax_Id.Text = "Tax Id";
            this.Tax_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tax_Id.Width = 50;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qty.Width = 63;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 66;
            // 
            // ItemId
            // 
            this.ItemId.Text = "itemId";
            this.ItemId.Width = 0;
            // 
            // cinv_no
            // 
            this.cinv_no.Text = "inv_no";
            this.cinv_no.Width = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(548, 219);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(61, 14);
            this.label10.TabIndex = 128;
            this.label10.Text = "PACK QTY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(459, 219);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(62, 14);
            this.label9.TabIndex = 127;
            this.label9.Text = "PACK SIZE";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.Black;
            this.Label19.Location = new System.Drawing.Point(872, 220);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(54, 14);
            this.Label19.TabIndex = 126;
            this.Label19.Text = "AMOUNT";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.Black;
            this.Label18.Location = new System.Drawing.Point(755, 220);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(41, 14);
            this.Label18.TabIndex = 125;
            this.Label18.Text = "TAX ID";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.Location = new System.Drawing.Point(804, 220);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(61, 14);
            this.Label17.TabIndex = 124;
            this.Label17.Text = "QUANTITY";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label16.Location = new System.Drawing.Point(680, 220);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label16.Size = new System.Drawing.Size(61, 14);
            this.Label16.TabIndex = 123;
            this.Label16.Text = "UNIT RATE";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(633, 220);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(39, 14);
            this.Label15.TabIndex = 122;
            this.Label15.Text = "M.R.P.";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(381, 219);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(56, 14);
            this.Label14.TabIndex = 121;
            this.Label14.Text = "EXP.DATE";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.Black;
            this.Label13.Location = new System.Drawing.Point(292, 219);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(64, 14);
            this.Label13.TabIndex = 120;
            this.Label13.Text = "BATCH NO.";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(7, 220);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(137, 14);
            this.Label12.TabIndex = 119;
            this.Label12.Text = "NAME OF MEDICINE/ITEM";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btn_print);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Information";
            this.radGroupBox1.Location = new System.Drawing.Point(211, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(715, 209);
            this.radGroupBox1.TabIndex = 129;
            this.radGroupBox1.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 120;
            this.label1.Text = "Name : ";
            // 
            // btn_print
            // 
            this.btn_print.Enabled = false;
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.Location = new System.Drawing.Point(660, 160);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(49, 44);
            this.btn_print.TabIndex = 121;
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // ProvisionalReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 466);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.ItemSaleGrid);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.rtxt_CardNo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProvisionalReceipt";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Provisional Receipt Information";
            this.Load += new System.EventHandler(this.ProvisionalReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rtxt_CardNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox rtxt_CardNo;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private System.Windows.Forms.ListView ItemSaleGrid;
        private System.Windows.Forms.ColumnHeader Master_Key_No;
        private System.Windows.Forms.ColumnHeader Item_Name;
        private System.Windows.Forms.ColumnHeader BatchNo;
        private System.Windows.Forms.ColumnHeader ExpDate;
        private System.Windows.Forms.ColumnHeader packs;
        private System.Windows.Forms.ColumnHeader Packq;
        private System.Windows.Forms.ColumnHeader MRP;
        private System.Windows.Forms.ColumnHeader uRate;
        private System.Windows.Forms.ColumnHeader Tax_Id;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.ColumnHeader cinv_no;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label Label19;
        public System.Windows.Forms.Label Label18;
        public System.Windows.Forms.Label Label17;
        public System.Windows.Forms.Label Label16;
        public System.Windows.Forms.Label Label15;
        public System.Windows.Forms.Label Label14;
        public System.Windows.Forms.Label Label13;
        public System.Windows.Forms.Label Label12;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print;
    }
}
