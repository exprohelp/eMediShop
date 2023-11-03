
    partial class ucOrderGenration
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPqty = new System.Windows.Forms.TextBox();
            this.cbxPack = new System.Windows.Forms.ComboBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtPendOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemhelpgrid = new System.Windows.Forms.ListView();
            this.Item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Itemname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_Issued = new System.Windows.Forms.ListView();
            this.auto_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockatunit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 201;
            this.label8.Text = "In Stock";
            // 
            // txtInStock
            // 
            this.txtInStock.BackColor = System.Drawing.Color.LightGray;
            this.txtInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInStock.Enabled = false;
            this.txtInStock.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInStock.Location = new System.Drawing.Point(413, 33);
            this.txtInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(49, 26);
            this.txtInStock.TabIndex = 200;
            this.txtInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(213, 465);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(117, 38);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 198;
            this.progressBar1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 196;
            this.label5.Text = "P. Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 187;
            this.label1.Text = "Product Name";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShow.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(8, 465);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 38);
            this.btnShow.TabIndex = 199;
            this.btnShow.Text = "Refresh";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(10, 33);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(400, 26);
            this.txtProduct.TabIndex = 186;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.Enter += new System.EventHandler(this.txtProduct_Enter);
            this.txtProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            // 
            // txtPqty
            // 
            this.txtPqty.BackColor = System.Drawing.Color.LightGray;
            this.txtPqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPqty.Enabled = false;
            this.txtPqty.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPqty.Location = new System.Drawing.Point(588, 33);
            this.txtPqty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPqty.Name = "txtPqty";
            this.txtPqty.Size = new System.Drawing.Size(61, 26);
            this.txtPqty.TabIndex = 195;
            this.txtPqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxPack
            // 
            this.cbxPack.BackColor = System.Drawing.Color.Silver;
            this.cbxPack.Enabled = false;
            this.cbxPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPack.ForeColor = System.Drawing.Color.Yellow;
            this.cbxPack.FormattingEnabled = true;
            this.cbxPack.Location = new System.Drawing.Point(464, 34);
            this.cbxPack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPack.Name = "cbxPack";
            this.cbxPack.Size = new System.Drawing.Size(121, 24);
            this.cbxPack.TabIndex = 190;
            this.cbxPack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPack_KeyDown);
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(734, 33);
            this.txtqty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(64, 26);
            this.txtqty.TabIndex = 189;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtqty.Enter += new System.EventHandler(this.txtqty_Enter);
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
            // 
            // txtPendOrder
            // 
            this.txtPendOrder.BackColor = System.Drawing.Color.Silver;
            this.txtPendOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendOrder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendOrder.Location = new System.Drawing.Point(653, 33);
            this.txtPendOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPendOrder.Name = "txtPendOrder";
            this.txtPendOrder.ReadOnly = true;
            this.txtPendOrder.Size = new System.Drawing.Size(78, 26);
            this.txtPendOrder.TabIndex = 194;
            this.txtPendOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 191;
            this.label2.Text = "Pack Size";
            // 
            // itemhelpgrid
            // 
            this.itemhelpgrid.BackColor = System.Drawing.Color.White;
            this.itemhelpgrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item_id,
            this.Itemname});
            this.itemhelpgrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemhelpgrid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemhelpgrid.ForeColor = System.Drawing.Color.Black;
            this.itemhelpgrid.FullRowSelect = true;
            this.itemhelpgrid.GridLines = true;
            this.itemhelpgrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemhelpgrid.Location = new System.Drawing.Point(13, 69);
            this.itemhelpgrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemhelpgrid.Name = "itemhelpgrid";
            this.itemhelpgrid.Size = new System.Drawing.Size(397, 327);
            this.itemhelpgrid.TabIndex = 197;
            this.itemhelpgrid.UseCompatibleStateImageBehavior = false;
            this.itemhelpgrid.View = System.Windows.Forms.View.Details;
            this.itemhelpgrid.Visible = false;
            this.itemhelpgrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemhelpgrid_KeyDown);
            // 
            // Item_id
            // 
            this.Item_id.Text = "Item_Id";
            this.Item_id.Width = 0;
            // 
            // Itemname
            // 
            this.Itemname.Text = "Name of Product";
            this.Itemname.Width = 315;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 192;
            this.label3.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 193;
            this.label4.Text = "Pend.Order";
            // 
            // lv_Issued
            // 
            this.lv_Issued.BackColor = System.Drawing.Color.White;
            this.lv_Issued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Issued.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.auto_id,
            this.product,
            this.stockatunit,
            this.Pack,
            this.packqty,
            this.Qty});
            this.lv_Issued.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Issued.FullRowSelect = true;
            this.lv_Issued.GridLines = true;
            this.lv_Issued.Location = new System.Drawing.Point(10, 69);
            this.lv_Issued.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_Issued.Name = "lv_Issued";
            this.lv_Issued.Size = new System.Drawing.Size(787, 389);
            this.lv_Issued.TabIndex = 188;
            this.lv_Issued.UseCompatibleStateImageBehavior = false;
            this.lv_Issued.View = System.Windows.Forms.View.Details;
            this.lv_Issued.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Issued_KeyDown);
            // 
            // auto_id
            // 
            this.auto_id.Text = "auto_id";
            this.auto_id.Width = 0;
            // 
            // product
            // 
            this.product.Text = "Product Name";
            this.product.Width = 375;
            // 
            // stockatunit
            // 
            this.stockatunit.Text = "In StK";
            this.stockatunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stockatunit.Width = 50;
            // 
            // Pack
            // 
            this.Pack.Text = "Pack Size";
            this.Pack.Width = 104;
            // 
            // packqty
            // 
            this.packqty.Text = "P.Qty";
            // 
            // Qty
            // 
            this.Qty.Text = "Ord.Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::eMediShop.Properties.Resources.printer;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(113, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 38);
            this.button1.TabIndex = 203;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucOrderGenration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInStock);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtPqty);
            this.Controls.Add(this.cbxPack);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtPendOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemhelpgrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lv_Issued);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucOrderGenration";
            this.Size = new System.Drawing.Size(807, 510);
            this.Load += new System.EventHandler(this.ucOrderGenration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPqty;
        private System.Windows.Forms.ComboBox cbxPack;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtPendOrder;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView itemhelpgrid;
        public System.Windows.Forms.ColumnHeader Item_id;
        public System.Windows.Forms.ColumnHeader Itemname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_Issued;
        private System.Windows.Forms.ColumnHeader auto_id;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader stockatunit;
        private System.Windows.Forms.ColumnHeader Pack;
        private System.Windows.Forms.ColumnHeader packqty;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
