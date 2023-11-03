
    partial class ucAuditStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lvSearchItem = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_tracking = new System.Windows.Forms.ListView();
            this.mkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mkeytrf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcvdqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.retqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txtFStkQty = new System.Windows.Forms.TextBox();
            this.lblMkey = new System.Windows.Forms.Label();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.gb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 188;
            this.label1.Text = "Filter Product By Type";
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.Blue;
            this.txtProdName.Location = new System.Drawing.Point(8, 26);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(221, 22);
            this.txtProdName.TabIndex = 187;
            this.txtProdName.TabStop = false;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            // 
            // lvSearchItem
            // 
            this.lvSearchItem.BackColor = System.Drawing.Color.Silver;
            this.lvSearchItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19});
            this.lvSearchItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSearchItem.ForeColor = System.Drawing.Color.Black;
            this.lvSearchItem.FullRowSelect = true;
            this.lvSearchItem.GridLines = true;
            this.lvSearchItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSearchItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvSearchItem.Location = new System.Drawing.Point(8, 58);
            this.lvSearchItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvSearchItem.Name = "lvSearchItem";
            this.lvSearchItem.Size = new System.Drawing.Size(221, 439);
            this.lvSearchItem.TabIndex = 186;
            this.lvSearchItem.TabStop = false;
            this.lvSearchItem.UseCompatibleStateImageBehavior = false;
            this.lvSearchItem.View = System.Windows.Forms.View.Details;
            this.lvSearchItem.SelectedIndexChanged += new System.EventHandler(this.lvSearchItem_SelectedIndexChanged);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Item Id";
            this.columnHeader18.Width = 0;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "";
            this.columnHeader19.Width = 170;
            // 
            // lv_tracking
            // 
            this.lv_tracking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_tracking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_tracking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mkey,
            this.Unit_name,
            this.dt,
            this.mkeytrf,
            this.packtype,
            this.rcvdqty,
            this.IssQty,
            this.retqty,
            this.bal});
            this.lv_tracking.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_tracking.ForeColor = System.Drawing.Color.Black;
            this.lv_tracking.FullRowSelect = true;
            this.lv_tracking.GridLines = true;
            this.lv_tracking.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_tracking.Location = new System.Drawing.Point(5, 25);
            this.lv_tracking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_tracking.Name = "lv_tracking";
            this.lv_tracking.Size = new System.Drawing.Size(583, 379);
            this.lv_tracking.TabIndex = 189;
            this.lv_tracking.UseCompatibleStateImageBehavior = false;
            this.lv_tracking.View = System.Windows.Forms.View.Details;
            this.lv_tracking.SelectedIndexChanged += new System.EventHandler(this.lv_tracking_SelectedIndexChanged);
            this.lv_tracking.Enter += new System.EventHandler(this.lv_tracking_Enter);
            // 
            // mkey
            // 
            this.mkey.Text = "Master_Key_Id";
            this.mkey.Width = 0;
            // 
            // Unit_name
            // 
            this.Unit_name.Text = "Unit Name";
            this.Unit_name.Width = 114;
            // 
            // dt
            // 
            this.dt.Text = "Date";
            this.dt.Width = 50;
            // 
            // mkeytrf
            // 
            this.mkeytrf.Text = "Trfid/IssueId";
            this.mkeytrf.Width = 68;
            // 
            // packtype
            // 
            this.packtype.Text = "P.Type";
            this.packtype.Width = 51;
            // 
            // rcvdqty
            // 
            this.rcvdqty.Text = "Rcvd.Qty";
            this.rcvdqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rcvdqty.Width = 62;
            // 
            // IssQty
            // 
            this.IssQty.Text = "Issued";
            this.IssQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IssQty.Width = 45;
            // 
            // retqty
            // 
            this.retqty.Text = "Ret.Qty";
            this.retqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.retqty.Width = 55;
            // 
            // bal
            // 
            this.bal.Text = "Bal";
            this.bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bal.Width = 37;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(242, 477);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(485, 22);
            this.txtRemark.TabIndex = 190;
            this.txtRemark.Visible = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(731, 466);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(96, 35);
            this.btn_Submit.TabIndex = 191;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txtFStkQty
            // 
            this.txtFStkQty.BackColor = System.Drawing.Color.White;
            this.txtFStkQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFStkQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFStkQty.Enabled = false;
            this.txtFStkQty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFStkQty.ForeColor = System.Drawing.Color.Blue;
            this.txtFStkQty.Location = new System.Drawing.Point(731, 14);
            this.txtFStkQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFStkQty.MaxLength = 50;
            this.txtFStkQty.Name = "txtFStkQty";
            this.txtFStkQty.ReadOnly = true;
            this.txtFStkQty.Size = new System.Drawing.Size(85, 23);
            this.txtFStkQty.TabIndex = 193;
            this.txtFStkQty.TabStop = false;
            this.txtFStkQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFStkQty.Visible = false;
            // 
            // lblMkey
            // 
            this.lblMkey.AutoSize = true;
            this.lblMkey.Enabled = false;
            this.lblMkey.Location = new System.Drawing.Point(636, 21);
            this.lblMkey.Name = "lblMkey";
            this.lblMkey.Size = new System.Drawing.Size(89, 17);
            this.lblMkey.TabIndex = 192;
            this.lblMkey.Text = "Final Stock of ";
            this.lblMkey.Visible = false;
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.lv_tracking);
            this.gb_info.ForeColor = System.Drawing.Color.Green;
            this.gb_info.Location = new System.Drawing.Point(233, 52);
            this.gb_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_info.Name = "gb_info";
            this.gb_info.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_info.Size = new System.Drawing.Size(598, 408);
            this.gb_info.TabIndex = 194;
            this.gb_info.TabStop = false;
            this.gb_info.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // ucAuditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_info);
            this.Controls.Add(this.txtFStkQty);
            this.Controls.Add(this.lblMkey);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lvSearchItem);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucAuditStock";
            this.Size = new System.Drawing.Size(832, 509);
            this.Load += new System.EventHandler(this.ucAuditStock_Load);
            this.gb_info.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtProdName;
        internal System.Windows.Forms.ListView lvSearchItem;
        internal System.Windows.Forms.ColumnHeader columnHeader18;
        internal System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ListView lv_tracking;
        private System.Windows.Forms.ColumnHeader mkey;
        private System.Windows.Forms.ColumnHeader Unit_name;
        private System.Windows.Forms.ColumnHeader dt;
        private System.Windows.Forms.ColumnHeader mkeytrf;
        private System.Windows.Forms.ColumnHeader packtype;
        private System.Windows.Forms.ColumnHeader rcvdqty;
        private System.Windows.Forms.ColumnHeader IssQty;
        private System.Windows.Forms.ColumnHeader retqty;
        private System.Windows.Forms.ColumnHeader bal;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btn_Submit;
        internal System.Windows.Forms.TextBox txtFStkQty;
        private System.Windows.Forms.Label lblMkey;
        private System.Windows.Forms.GroupBox gb_info;
    }

