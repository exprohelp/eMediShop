namespace eMediShop
{
    partial class SingleProductAnalysis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_working = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvBestDeal = new System.Windows.Forms.ListView();
            this.Vendor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TRADE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FREE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DISC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvProAtUnit = new System.Windows.Forms.ListView();
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Packqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Consumption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lastpurdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastTrfDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockAsON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReqPacks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastSaleDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblMfd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_working);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.cbxProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(891, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pb_working
            // 
            this.pb_working.Location = new System.Drawing.Point(498, 15);
            this.pb_working.Name = "pb_working";
            this.pb_working.Size = new System.Drawing.Size(321, 23);
            this.pb_working.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_working.TabIndex = 9;
            this.pb_working.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(102, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(717, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Type product Name and Press Enter Key to Fill Matching Products Name , After That" +
                " Select Product and Press View Button To See The Analysis.";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Maroon;
            this.btnGo.Enabled = false;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(431, 12);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(62, 28);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "View";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(105, 14);
            this.cbxProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(315, 24);
            this.cbxProduct.TabIndex = 1;
            this.cbxProduct.TextChanged += new System.EventHandler(this.cbxProduct_TextChanged);
            this.cbxProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxProduct_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Product";
            // 
            // lvBestDeal
            // 
            this.lvBestDeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBestDeal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Vendor,
            this.MRP,
            this.TRADE,
            this.FREE,
            this.DISC,
            this.NPR,
            this.QTY});
            this.lvBestDeal.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBestDeal.ForeColor = System.Drawing.Color.Maroon;
            this.lvBestDeal.FullRowSelect = true;
            this.lvBestDeal.GridLines = true;
            this.lvBestDeal.Location = new System.Drawing.Point(3, 88);
            this.lvBestDeal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvBestDeal.Name = "lvBestDeal";
            this.lvBestDeal.Size = new System.Drawing.Size(892, 53);
            this.lvBestDeal.TabIndex = 1;
            this.lvBestDeal.UseCompatibleStateImageBehavior = false;
            this.lvBestDeal.View = System.Windows.Forms.View.Details;
            // 
            // Vendor
            // 
            this.Vendor.Text = "Vendor Name";
            this.Vendor.Width = 331;
            // 
            // MRP
            // 
            this.MRP.Text = "Mrp";
            this.MRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MRP.Width = 98;
            // 
            // TRADE
            // 
            this.TRADE.Text = "Trade";
            this.TRADE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TRADE.Width = 95;
            // 
            // FREE
            // 
            this.FREE.Text = "Free";
            this.FREE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FREE.Width = 91;
            // 
            // DISC
            // 
            this.DISC.Text = "Disc%";
            this.DISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DISC.Width = 91;
            // 
            // NPR
            // 
            this.NPR.Text = "Npr";
            this.NPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NPR.Width = 80;
            // 
            // QTY
            // 
            this.QTY.Text = "Qty";
            this.QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QTY.Width = 78;
            // 
            // lvProAtUnit
            // 
            this.lvProAtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProAtUnit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Unit,
            this.Packqty,
            this.Consumption,
            this.Lastpurdate,
            this.LastTrfDate,
            this.StockAsON,
            this.ReqPacks,
            this.LastSaleDate});
            this.lvProAtUnit.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProAtUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvProAtUnit.FullRowSelect = true;
            this.lvProAtUnit.GridLines = true;
            this.lvProAtUnit.Location = new System.Drawing.Point(3, 146);
            this.lvProAtUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvProAtUnit.Name = "lvProAtUnit";
            this.lvProAtUnit.Size = new System.Drawing.Size(892, 348);
            this.lvProAtUnit.TabIndex = 2;
            this.lvProAtUnit.UseCompatibleStateImageBehavior = false;
            this.lvProAtUnit.View = System.Windows.Forms.View.Details;
            // 
            // Unit
            // 
            this.Unit.Text = "Unit Name";
            this.Unit.Width = 282;
            // 
            // Packqty
            // 
            this.Packqty.Text = "Pack Qty";
            this.Packqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Packqty.Width = 92;
            // 
            // Consumption
            // 
            this.Consumption.Text = "Consumption";
            this.Consumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Consumption.Width = 92;
            // 
            // Lastpurdate
            // 
            this.Lastpurdate.Text = "Last Pur Date";
            this.Lastpurdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Lastpurdate.Width = 84;
            // 
            // LastTrfDate
            // 
            this.LastTrfDate.Text = "Last Trf Date";
            this.LastTrfDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LastTrfDate.Width = 82;
            // 
            // StockAsON
            // 
            this.StockAsON.Text = "Stock As On";
            this.StockAsON.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockAsON.Width = 80;
            // 
            // ReqPacks
            // 
            this.ReqPacks.Text = "Req.Packs";
            this.ReqPacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ReqPacks.Width = 71;
            // 
            // LastSaleDate
            // 
            this.LastSaleDate.Text = "LastSaleDate";
            this.LastSaleDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LastSaleDate.Width = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Best Deal";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Arial Narrow", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(112, 69);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(0, 15);
            this.lblProduct.TabIndex = 4;
            // 
            // lblMfd
            // 
            this.lblMfd.AutoSize = true;
            this.lblMfd.Font = new System.Drawing.Font("Arial Narrow", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMfd.Location = new System.Drawing.Point(529, 69);
            this.lblMfd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMfd.Name = "lblMfd";
            this.lblMfd.Size = new System.Drawing.Size(0, 15);
            this.lblMfd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "1- Above Calculation Based on Daily Sales Average and with Current Sales Average " +
                "Policy.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "2- Consumption : In Per month Packs .";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(244, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "3- Stock as on : In Packs .";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(417, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "4- Req. Packs  : According To Current Monthly Order Days/Month.";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // SingleProductAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(897, 549);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMfd);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvProAtUnit);
            this.Controls.Add(this.lvBestDeal);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "SingleProductAnalysis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Product Analysis";
            this.Load += new System.EventHandler(this.SingleProductAnalysis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.ListView lvBestDeal;
        private System.Windows.Forms.ListView lvProAtUnit;
        private System.Windows.Forms.ColumnHeader Vendor;
        private System.Windows.Forms.ColumnHeader MRP;
        private System.Windows.Forms.ColumnHeader TRADE;
        private System.Windows.Forms.ColumnHeader FREE;
        private System.Windows.Forms.ColumnHeader DISC;
        private System.Windows.Forms.ColumnHeader NPR;
        private System.Windows.Forms.ColumnHeader QTY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Packqty;
        private System.Windows.Forms.ColumnHeader Consumption;
        private System.Windows.Forms.ColumnHeader Lastpurdate;
        private System.Windows.Forms.ColumnHeader LastTrfDate;
        private System.Windows.Forms.ColumnHeader StockAsON;
        private System.Windows.Forms.ColumnHeader ReqPacks;
        private System.Windows.Forms.ColumnHeader LastSaleDate;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblMfd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pb_working;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}