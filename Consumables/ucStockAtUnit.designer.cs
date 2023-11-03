  partial class ucStockAtUnit
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
            this.btn_trfToxl = new System.Windows.Forms.Button();
            this.pbZeroStockUpdate = new System.Windows.Forms.ProgressBar();
            this.lv_Detail = new System.Windows.Forms.ListView();
            this.BatchNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_trfToxl
            // 
            this.btn_trfToxl.BackColor = System.Drawing.Color.LightCoral;
            this.btn_trfToxl.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trfToxl.Location = new System.Drawing.Point(542, 517);
            this.btn_trfToxl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_trfToxl.Name = "btn_trfToxl";
            this.btn_trfToxl.Size = new System.Drawing.Size(159, 38);
            this.btn_trfToxl.TabIndex = 55;
            this.btn_trfToxl.Text = "Transfer To Excel";
            this.btn_trfToxl.UseVisualStyleBackColor = false;
            this.btn_trfToxl.Click += new System.EventHandler(this.btn_trfToxl_Click);
            // 
            // pbZeroStockUpdate
            // 
            this.pbZeroStockUpdate.Enabled = false;
            this.pbZeroStockUpdate.Location = new System.Drawing.Point(516, 6);
            this.pbZeroStockUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbZeroStockUpdate.MarqueeAnimationSpeed = 35;
            this.pbZeroStockUpdate.Maximum = 50;
            this.pbZeroStockUpdate.Name = "pbZeroStockUpdate";
            this.pbZeroStockUpdate.Size = new System.Drawing.Size(185, 30);
            this.pbZeroStockUpdate.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbZeroStockUpdate.TabIndex = 54;
            this.pbZeroStockUpdate.Visible = false;
            // 
            // lv_Detail
            // 
            this.lv_Detail.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_Detail.BackColor = System.Drawing.Color.White;
            this.lv_Detail.BackgroundImageTiled = true;
            this.lv_Detail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BatchNo,
            this.Pack_Type,
            this.PackQty,
            this.ExpDate,
            this.NPR,
            this.UPR,
            this.Qty,
            this.Amount});
            this.lv_Detail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Detail.ForeColor = System.Drawing.Color.Maroon;
            this.lv_Detail.FullRowSelect = true;
            this.lv_Detail.GridLines = true;
            this.lv_Detail.Location = new System.Drawing.Point(14, 50);
            this.lv_Detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_Detail.Name = "lv_Detail";
            this.lv_Detail.Size = new System.Drawing.Size(685, 444);
            this.lv_Detail.TabIndex = 53;
            this.lv_Detail.UseCompatibleStateImageBehavior = false;
            this.lv_Detail.View = System.Windows.Forms.View.Details;
            // 
            // BatchNo
            // 
            this.BatchNo.Text = "Batch";
            this.BatchNo.Width = 163;
            // 
            // Pack_Type
            // 
            this.Pack_Type.Text = "Pack Type";
            this.Pack_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pack_Type.Width = 97;
            // 
            // PackQty
            // 
            this.PackQty.Text = "Pack Qty";
            this.PackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PackQty.Width = 61;
            // 
            // ExpDate
            // 
            this.ExpDate.Text = "Exp Date";
            this.ExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExpDate.Width = 82;
            // 
            // NPR
            // 
            this.NPR.Text = "NPR";
            this.NPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NPR.Width = 61;
            // 
            // UPR
            // 
            this.UPR.Text = "UPR";
            this.UPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UPR.Width = 59;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 59;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 4);
            this.panel1.TabIndex = 56;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Stock At Unit";
            // 
            // ucStockAtUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_trfToxl);
            this.Controls.Add(this.pbZeroStockUpdate);
            this.Controls.Add(this.lv_Detail);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucStockAtUnit";
            this.Size = new System.Drawing.Size(710, 510);
            this.Load += new System.EventHandler(this.ucStockAtUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_trfToxl;
        private System.Windows.Forms.ProgressBar pbZeroStockUpdate;
        internal System.Windows.Forms.ListView lv_Detail;
        internal System.Windows.Forms.ColumnHeader BatchNo;
        internal System.Windows.Forms.ColumnHeader Pack_Type;
        internal System.Windows.Forms.ColumnHeader PackQty;
        internal System.Windows.Forms.ColumnHeader ExpDate;
        internal System.Windows.Forms.ColumnHeader NPR;
        internal System.Windows.Forms.ColumnHeader UPR;
        internal System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
