namespace eMediShop
{
    partial class GetPurchaseInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.txtMth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.InvNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Batch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Expiry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PTR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.npr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Free = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProduct = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchaseBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Product";
            // 
            // txtBatch
            // 
            this.txtBatch.AcceptsReturn = true;
            this.txtBatch.BackColor = System.Drawing.Color.White;
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBatch.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBatch.Location = new System.Drawing.Point(317, 27);
            this.txtBatch.MaxLength = 0;
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBatch.Size = new System.Drawing.Size(100, 25);
            this.txtBatch.TabIndex = 24;
            this.txtBatch.Text = "N/A";
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
            // 
            // txtMedName
            // 
            this.txtMedName.AcceptsReturn = true;
            this.txtMedName.BackColor = System.Drawing.Color.White;
            this.txtMedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMedName.Location = new System.Drawing.Point(2, 27);
            this.txtMedName.MaxLength = 0;
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMedName.Size = new System.Drawing.Size(314, 25);
            this.txtMedName.TabIndex = 23;
            this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);
            this.txtMedName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedName_KeyDown);
            // 
            // txtMth
            // 
            this.txtMth.AcceptsReturn = true;
            this.txtMth.BackColor = System.Drawing.Color.White;
            this.txtMth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMth.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMth.Location = new System.Drawing.Point(418, 27);
            this.txtMth.MaxLength = 0;
            this.txtMth.Name = "txtMth";
            this.txtMth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMth.Size = new System.Drawing.Size(53, 25);
            this.txtMth.TabIndex = 27;
            this.txtMth.Text = "-12";
            this.txtMth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMth_KeyDown);
            this.txtMth.Leave += new System.EventHandler(this.txtMth_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Month";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(474, 25);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(48, 28);
            this.btnGo.TabIndex = 30;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(722, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 31;
            this.progressBar1.Visible = false;
            // 
            // lv_Detail
            // 
            this.lv_Detail.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_Detail.BackColor = System.Drawing.Color.White;
            this.lv_Detail.BackgroundImageTiled = true;
            this.lv_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InvNo,
            this.InvDate,
            this.Batch,
            this.Expiry,
            this.Pack,
            this.MRP,
            this.PTR,
            this.npr,
            this.Quantity,
            this.Free,
            this.Tax,
            this.orderNo,
            this.purchaseBy});
            this.lv_Detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.ForeColor = System.Drawing.Color.Maroon;
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.HideSelection = false;
            this.lv_Detail.Location = new System.Drawing.Point(2, 54);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(1101, 399);
            this.lv_Detail.TabIndex = 181;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            // 
            // InvNo
            // 
            this.InvNo.Text = "Inv No";
            this.InvNo.Width = 114;
            // 
            // InvDate
            // 
            this.InvDate.Text = "Inv Date";
            this.InvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InvDate.Width = 88;
            // 
            // Batch
            // 
            this.Batch.Text = "Batch";
            this.Batch.Width = 133;
            // 
            // Expiry
            // 
            this.Expiry.Text = "Expiry";
            this.Expiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Expiry.Width = 67;
            // 
            // Pack
            // 
            this.Pack.Text = "Pack Type";
            this.Pack.Width = 80;
            // 
            // MRP
            // 
            this.MRP.Text = "MRP";
            this.MRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MRP.Width = 61;
            // 
            // PTR
            // 
            this.PTR.Text = "PTR";
            this.PTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PTR.Width = 59;
            // 
            // npr
            // 
            this.npr.Text = "NPR";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.Width = 61;
            // 
            // Free
            // 
            this.Free.Text = "Free";
            this.Free.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Free.Width = 45;
            // 
            // Tax
            // 
            this.Tax.Text = "Tax";
            this.Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tax.Width = 43;
            // 
            // lvProduct
            // 
            this.lvProduct.BackColor = System.Drawing.Color.GhostWhite;
            this.lvProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lvProduct.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(2, 54);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(314, 176);
            this.lvProduct.TabIndex = 182;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.Visible = false;
            this.lvProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvProduct_KeyDown);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ItemId";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Item Name";
            this.columnHeader9.Width = 291;
            // 
            // orderNo
            // 
            this.orderNo.Text = "Order No";
            this.orderNo.Width = 120;
            // 
            // purchaseBy
            // 
            this.purchaseBy.Text = "Purchase By";
            this.purchaseBy.Width = 150;
            // 
            // GetPurchaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1102, 457);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.lv_Detail);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.txtMedName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "GetPurchaseInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Product Purchase Information";
            this.Load += new System.EventHandler(this.GetPurchaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBatch;
        public System.Windows.Forms.TextBox txtMedName;
        public System.Windows.Forms.TextBox txtMth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        internal System.Windows.Forms.ListView lv_Detail;
        internal System.Windows.Forms.ColumnHeader InvNo;
        internal System.Windows.Forms.ColumnHeader InvDate;
        internal System.Windows.Forms.ColumnHeader Batch;
        internal System.Windows.Forms.ColumnHeader Expiry;
        internal System.Windows.Forms.ColumnHeader MRP;
        internal System.Windows.Forms.ColumnHeader PTR;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Free;
        private System.Windows.Forms.ColumnHeader Tax;
        private System.Windows.Forms.ColumnHeader Pack;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader npr;
        private System.Windows.Forms.ColumnHeader orderNo;
        private System.Windows.Forms.ColumnHeader purchaseBy;
    }
}