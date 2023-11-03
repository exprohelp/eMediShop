
    partial class ucStockReceiving
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReicptCode = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtTrfId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvtrfGrid = new System.Windows.Forms.ListView();
            this.masterkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.batch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Expiry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trf_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcpt_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcptflag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReicptCode);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.txtTrfId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(682, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtReicptCode
            // 
            this.txtReicptCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReicptCode.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReicptCode.Location = new System.Drawing.Point(395, 21);
            this.txtReicptCode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtReicptCode.Name = "txtReicptCode";
            this.txtReicptCode.Size = new System.Drawing.Size(91, 23);
            this.txtReicptCode.TabIndex = 4;
            this.txtReicptCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReicptCode_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGo.Font = new System.Drawing.Font("Arial Narrow", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(495, 16);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(56, 37);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtTrfId
            // 
            this.txtTrfId.AcceptsTab = true;
            this.txtTrfId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrfId.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrfId.Location = new System.Drawing.Point(103, 21);
            this.txtTrfId.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTrfId.Name = "txtTrfId";
            this.txtTrfId.Size = new System.Drawing.Size(183, 23);
            this.txtTrfId.TabIndex = 2;
            this.txtTrfId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrfId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = " Receipt Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(14, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 10);
            this.panel1.TabIndex = 2;
            // 
            // lvtrfGrid
            // 
            this.lvtrfGrid.BackColor = System.Drawing.Color.White;
            this.lvtrfGrid.CheckBoxes = true;
            this.lvtrfGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masterkey,
            this.product,
            this.batch,
            this.Expiry,
            this.trf_qty,
            this.rcpt_qty,
            this.rcptflag});
            this.lvtrfGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvtrfGrid.ForeColor = System.Drawing.Color.Black;
            this.lvtrfGrid.FullRowSelect = true;
            this.lvtrfGrid.GridLines = true;
            this.lvtrfGrid.Location = new System.Drawing.Point(14, 92);
            this.lvtrfGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lvtrfGrid.Name = "lvtrfGrid";
            this.lvtrfGrid.Size = new System.Drawing.Size(681, 334);
            this.lvtrfGrid.TabIndex = 3;
            this.lvtrfGrid.UseCompatibleStateImageBehavior = false;
            this.lvtrfGrid.View = System.Windows.Forms.View.Details;
            this.lvtrfGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvtrfGrid_KeyDown);
            // 
            // masterkey
            // 
            this.masterkey.Text = "";
            this.masterkey.Width = 22;
            // 
            // product
            // 
            this.product.Text = "Product Name";
            this.product.Width = 326;
            // 
            // batch
            // 
            this.batch.Text = "Batch No";
            this.batch.Width = 99;
            // 
            // Expiry
            // 
            this.Expiry.Text = "Expiry";
            this.Expiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Expiry.Width = 65;
            // 
            // trf_qty
            // 
            this.trf_qty.Text = "Trf(qty)";
            this.trf_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.trf_qty.Width = 65;
            // 
            // rcpt_qty
            // 
            this.rcpt_qty.Text = "Rec(Qty)";
            this.rcpt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rcpt_qty.Width = 74;
            // 
            // rcptflag
            // 
            this.rcptflag.Text = "rcptflag";
            this.rcptflag.Width = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Received Qty";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(14, 434);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 37);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Complete Receiving";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(608, 434);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(87, 22);
            this.txtQty.TabIndex = 8;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // ucStockReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lvtrfGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucStockReceiving";
            this.Size = new System.Drawing.Size(703, 477);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReicptCode;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtTrfId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvtrfGrid;
        private System.Windows.Forms.ColumnHeader masterkey;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader batch;
        private System.Windows.Forms.ColumnHeader Expiry;
        private System.Windows.Forms.ColumnHeader trf_qty;
        private System.Windows.Forms.ColumnHeader rcpt_qty;
        private System.Windows.Forms.ColumnHeader rcptflag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQty;
    }

