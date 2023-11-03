namespace eMediShop.forms.CentralAccess.Stock
{
    partial class ucPurchaseReturnSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPurchaseReturnSlip));
            this.lv_GRno = new System.Windows.Forms.ListView();
            this.grno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Info = new System.Windows.Forms.ListView();
            this.gr_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.batch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Packs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ptr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mrp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTinNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.btnSlipPrint = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_GRno
            // 
            this.lv_GRno.BackColor = System.Drawing.SystemColors.Control;
            this.lv_GRno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.grno,
            this.columnHeader1});
            this.lv_GRno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_GRno.ForeColor = System.Drawing.Color.Black;
            this.lv_GRno.FullRowSelect = true;
            this.lv_GRno.GridLines = true;
            this.lv_GRno.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_GRno.Location = new System.Drawing.Point(3, 76);
            this.lv_GRno.Name = "lv_GRno";
            this.lv_GRno.Size = new System.Drawing.Size(219, 432);
            this.lv_GRno.TabIndex = 124;
            this.lv_GRno.UseCompatibleStateImageBehavior = false;
            this.lv_GRno.View = System.Windows.Forms.View.Details;
            this.lv_GRno.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_GRno_ItemSelectionChanged);
            // 
            // grno
            // 
            this.grno.Text = "GR NO";
            this.grno.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GR No.";
            this.columnHeader1.Width = 115;
            // 
            // lv_Info
            // 
            this.lv_Info.BackColor = System.Drawing.SystemColors.Control;
            this.lv_Info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gr_no,
            this.Item_id,
            this.ItemName,
            this.batch,
            this.exp,
            this.Packs,
            this.ptr,
            this.mrp,
            this.Qty,
            this.pInfo});
            this.lv_Info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Info.ForeColor = System.Drawing.Color.Black;
            this.lv_Info.FullRowSelect = true;
            this.lv_Info.GridLines = true;
            this.lv_Info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Info.Location = new System.Drawing.Point(228, 77);
            this.lv_Info.Name = "lv_Info";
            this.lv_Info.Size = new System.Drawing.Size(638, 433);
            this.lv_Info.TabIndex = 125;
            this.lv_Info.UseCompatibleStateImageBehavior = false;
            this.lv_Info.View = System.Windows.Forms.View.Details;
            // 
            // gr_no
            // 
            this.gr_no.Text = "GR_No";
            this.gr_no.Width = 0;
            // 
            // Item_id
            // 
            this.Item_id.Width = 0;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 211;
            // 
            // batch
            // 
            this.batch.Text = "Batch No";
            this.batch.Width = 70;
            // 
            // exp
            // 
            this.exp.Text = "Ex.Dt";
            this.exp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exp.Width = 54;
            // 
            // Packs
            // 
            this.Packs.Text = "P.Type";
            this.Packs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ptr
            // 
            this.ptr.Text = "ptr";
            this.ptr.Width = 0;
            // 
            // mrp
            // 
            this.mrp.Text = "MRP";
            this.mrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 30;
            // 
            // pInfo
            // 
            this.pInfo.Text = "Purch Info";
            this.pInfo.Width = 124;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTinNo);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblVendorName);
            this.groupBox1.Controls.Add(this.btnSlipPrint);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 69);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Return Slip Printing";
            // 
            // lblTinNo
            // 
            this.lblTinNo.AutoSize = true;
            this.lblTinNo.Location = new System.Drawing.Point(327, 16);
            this.lblTinNo.Name = "lblTinNo";
            this.lblTinNo.Size = new System.Drawing.Size(99, 16);
            this.lblTinNo.TabIndex = 129;
            this.lblTinNo.Text = "XXXXXXXXXXXXX";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Italic);
            this.lblAddress.Location = new System.Drawing.Point(327, 49);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(403, 15);
            this.lblAddress.TabIndex = 128;
            this.lblAddress.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(327, 32);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(218, 16);
            this.lblVendorName.TabIndex = 127;
            this.lblVendorName.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // btnSlipPrint
            // 
            this.btnSlipPrint.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold);
            this.btnSlipPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnSlipPrint.Image")));
            this.btnSlipPrint.Location = new System.Drawing.Point(790, 11);
            this.btnSlipPrint.Name = "btnSlipPrint";
            this.btnSlipPrint.Size = new System.Drawing.Size(71, 53);
            this.btnSlipPrint.TabIndex = 5;
            this.btnSlipPrint.Text = ">>";
            this.btnSlipPrint.UseVisualStyleBackColor = true;
            this.btnSlipPrint.Click += new System.EventHandler(this.btnSlipPrint_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold);
            this.btnGo.Location = new System.Drawing.Point(159, 21);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(43, 38);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(57, 44);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(89, 22);
            this.dtTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(57, 19);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(89, 22);
            this.dtFrom.TabIndex = 0;
            // 
            // ucPurchaseReturnSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv_Info);
            this.Controls.Add(this.lv_GRno);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucPurchaseReturnSlip";
            this.Size = new System.Drawing.Size(877, 511);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_GRno;
        private System.Windows.Forms.ListView lv_Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnSlipPrint;
        private System.Windows.Forms.ColumnHeader grno;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblTinNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ColumnHeader gr_no;
        private System.Windows.Forms.ColumnHeader Item_id;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader batch;
        private System.Windows.Forms.ColumnHeader exp;
        private System.Windows.Forms.ColumnHeader Packs;
        private System.Windows.Forms.ColumnHeader ptr;
        private System.Windows.Forms.ColumnHeader mrp;
        private System.Windows.Forms.ColumnHeader pInfo;
        private System.Windows.Forms.ColumnHeader Qty;
    }
}
