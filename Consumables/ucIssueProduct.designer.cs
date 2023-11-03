namespace eMediShop
{

    partial class ucIssueProduct
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtPack = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtbatch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lv_batchno = new System.Windows.Forms.ListView();
            this.masterkey = new System.Windows.Forms.ColumnHeader();
            this.batchno = new System.Windows.Forms.ColumnHeader();
            this.exp = new System.Windows.Forms.ColumnHeader();
            this.packsize = new System.Windows.Forms.ColumnHeader();
            this.MFD = new System.Windows.Forms.ColumnHeader();
            this.pqty = new System.Windows.Forms.ColumnHeader();
            this.mfdiD = new System.Windows.Forms.ColumnHeader();
            this.itemhelpgrid = new System.Windows.Forms.ListView();
            this._itemhelpgrid_ColumnHeader_1 = new System.Windows.Forms.ColumnHeader();
            this._itemhelpgrid_ColumnHeader_2 = new System.Windows.Forms.ColumnHeader();
            this._itemhelpgrid_ColumnHeader_3 = new System.Windows.Forms.ColumnHeader();
            this.lv_Issued = new System.Windows.Forms.ListView();
            this.product = new System.Windows.Forms.ColumnHeader();
            this.batch = new System.Windows.Forms.ColumnHeader();
            this.Expiry = new System.Windows.Forms.ColumnHeader();
            this.Pack = new System.Windows.Forms.ColumnHeader();
            this.Qty = new System.Windows.Forms.ColumnHeader();
            this.auto_id = new System.Windows.Forms.ColumnHeader();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.txtPack);
            this.panel2.Controls.Add(this.txtExpiry);
            this.panel2.Controls.Add(this.txtbatch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProduct);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 77);
            this.panel2.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(573, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 17);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pack Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ExPiry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Batch No.";
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(597, 40);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(76, 26);
            this.txtqty.TabIndex = 5;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            // 
            // txtPack
            // 
            this.txtPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPack.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPack.Location = new System.Drawing.Point(517, 40);
            this.txtPack.Name = "txtPack";
            this.txtPack.Size = new System.Drawing.Size(75, 26);
            this.txtPack.TabIndex = 4;
            // 
            // txtExpiry
            // 
            this.txtExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpiry.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiry.Location = new System.Drawing.Point(437, 40);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(75, 26);
            this.txtExpiry.TabIndex = 3;
            // 
            // txtbatch
            // 
            this.txtbatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbatch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbatch.Location = new System.Drawing.Point(336, 40);
            this.txtbatch.Name = "txtbatch";
            this.txtbatch.Size = new System.Drawing.Size(97, 26);
            this.txtbatch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(6, 40);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(326, 26);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lv_batchno);
            this.panel3.Controls.Add(this.itemhelpgrid);
            this.panel3.Controls.Add(this.lv_Issued);
            this.panel3.Location = new System.Drawing.Point(3, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 394);
            this.panel3.TabIndex = 3;
            // 
            // lv_batchno
            // 
            this.lv_batchno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lv_batchno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masterkey,
            this.batchno,
            this.exp,
            this.packsize,
            this.MFD,
            this.pqty,
            this.mfdiD});
            this.lv_batchno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_batchno.ForeColor = System.Drawing.Color.White;
            this.lv_batchno.FullRowSelect = true;
            this.lv_batchno.GridLines = true;
            this.lv_batchno.Location = new System.Drawing.Point(176, 1);
            this.lv_batchno.Name = "lv_batchno";
            this.lv_batchno.Size = new System.Drawing.Size(510, 161);
            this.lv_batchno.TabIndex = 179;
            this.lv_batchno.UseCompatibleStateImageBehavior = false;
            this.lv_batchno.View = System.Windows.Forms.View.Details;
            this.lv_batchno.Visible = false;
            this.lv_batchno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_batchno_KeyDown);
            // 
            // masterkey
            // 
            this.masterkey.Text = "Master key";
            this.masterkey.Width = 0;
            // 
            // batchno
            // 
            this.batchno.Text = "batch";
            this.batchno.Width = 96;
            // 
            // exp
            // 
            this.exp.Text = "Expiry";
            this.exp.Width = 86;
            // 
            // packsize
            // 
            this.packsize.Text = "packsize";
            this.packsize.Width = 100;
            // 
            // MFD
            // 
            this.MFD.Text = "Manufacturer";
            this.MFD.Width = 141;
            // 
            // pqty
            // 
            this.pqty.Text = "Qty";
            this.pqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pqty.Width = 64;
            // 
            // mfdiD
            // 
            this.mfdiD.Text = "mfdid";
            this.mfdiD.Width = 0;
            // 
            // itemhelpgrid
            // 
            this.itemhelpgrid.BackColor = System.Drawing.Color.DimGray;
            this.itemhelpgrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._itemhelpgrid_ColumnHeader_1,
            this._itemhelpgrid_ColumnHeader_2,
            this._itemhelpgrid_ColumnHeader_3});
            this.itemhelpgrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemhelpgrid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemhelpgrid.ForeColor = System.Drawing.Color.White;
            this.itemhelpgrid.FullRowSelect = true;
            this.itemhelpgrid.GridLines = true;
            this.itemhelpgrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemhelpgrid.Location = new System.Drawing.Point(5, 1);
            this.itemhelpgrid.Name = "itemhelpgrid";
            this.itemhelpgrid.Size = new System.Drawing.Size(362, 229);
            this.itemhelpgrid.TabIndex = 178;
            this.itemhelpgrid.UseCompatibleStateImageBehavior = false;
            this.itemhelpgrid.View = System.Windows.Forms.View.Details;
            this.itemhelpgrid.Visible = false;
            this.itemhelpgrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemhelpgrid_KeyDown);
            // 
            // _itemhelpgrid_ColumnHeader_1
            // 
            this._itemhelpgrid_ColumnHeader_1.Text = "Item_Id";
            this._itemhelpgrid_ColumnHeader_1.Width = 0;
            // 
            // _itemhelpgrid_ColumnHeader_2
            // 
            this._itemhelpgrid_ColumnHeader_2.Text = "QTY";
            this._itemhelpgrid_ColumnHeader_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._itemhelpgrid_ColumnHeader_2.Width = 41;
            // 
            // _itemhelpgrid_ColumnHeader_3
            // 
            this._itemhelpgrid_ColumnHeader_3.Text = "Name of Product";
            this._itemhelpgrid_ColumnHeader_3.Width = 296;
            // 
            // lv_Issued
            // 
            this.lv_Issued.BackColor = System.Drawing.Color.White;
            this.lv_Issued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Issued.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product,
            this.batch,
            this.Expiry,
            this.Pack,
            this.Qty,
            this.auto_id});
            this.lv_Issued.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Issued.FullRowSelect = true;
            this.lv_Issued.GridLines = true;
            this.lv_Issued.Location = new System.Drawing.Point(4, 3);
            this.lv_Issued.Name = "lv_Issued";
            this.lv_Issued.Size = new System.Drawing.Size(682, 385);
            this.lv_Issued.TabIndex = 0;
            this.lv_Issued.UseCompatibleStateImageBehavior = false;
            this.lv_Issued.View = System.Windows.Forms.View.Details;
            this.lv_Issued.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Issued_KeyDown);
            // 
            // product
            // 
            this.product.Text = "Product Name";
            this.product.Width = 343;
            // 
            // batch
            // 
            this.batch.Text = "Batch No";
            this.batch.Width = 101;
            // 
            // Expiry
            // 
            this.Expiry.Text = "ExPiry";
            this.Expiry.Width = 79;
            // 
            // Pack
            // 
            this.Pack.Text = "Pack Size";
            this.Pack.Width = 80;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 68;
            // 
            // auto_id
            // 
            this.auto_id.Text = "auto_id";
            this.auto_id.Width = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(6, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 3);
            this.panel1.TabIndex = 58;
            // 
            // ucIssueProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ucIssueProduct";
            this.Size = new System.Drawing.Size(700, 475);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtPack;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtbatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_batchno;
        private System.Windows.Forms.ColumnHeader masterkey;
        private System.Windows.Forms.ColumnHeader batchno;
        private System.Windows.Forms.ColumnHeader exp;
        private System.Windows.Forms.ColumnHeader packsize;
        private System.Windows.Forms.ColumnHeader MFD;
        private System.Windows.Forms.ColumnHeader pqty;
        private System.Windows.Forms.ColumnHeader mfdiD;
        public System.Windows.Forms.ListView itemhelpgrid;
        public System.Windows.Forms.ColumnHeader _itemhelpgrid_ColumnHeader_1;
        public System.Windows.Forms.ColumnHeader _itemhelpgrid_ColumnHeader_2;
        public System.Windows.Forms.ColumnHeader _itemhelpgrid_ColumnHeader_3;
        private System.Windows.Forms.ListView lv_Issued;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader batch;
        private System.Windows.Forms.ColumnHeader Expiry;
        private System.Windows.Forms.ColumnHeader Pack;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader auto_id;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}
