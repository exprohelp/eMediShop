namespace eMediShop.warehouse
{
    partial class uc_ExpiryReceiving
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
            this.components = new System.ComponentModel.Container();
            this.lv_info = new System.Windows.Forms.ListView();
            this.CheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.batch_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exp_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RcptQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Packs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dmg_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dmgAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masterKeyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trf_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vendor_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetData = new Telerik.WinControls.UI.RadButton();
            this.chkSortOrder = new System.Windows.Forms.CheckBox();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.cmbTrfId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUnitName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblShort = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblnr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalGR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModify = new System.Windows.Forms.Label();
            this.txtCorr = new System.Windows.Forms.TextBox();
            this.lblGr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Complete = new System.Windows.Forms.Button();
            this.rgb_ChangeVendor = new Telerik.WinControls.UI.RadGroupBox();
            this.rddl_vendor = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_ChangeVendor)).BeginInit();
            this.rgb_ChangeVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_info
            // 
            this.lv_info.CheckBoxes = true;
            this.lv_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CheckBox,
            this.item_name,
            this.batch_no,
            this.Exp_Date,
            this.MRP,
            this.NPR,
            this.Qty,
            this.RcptQty,
            this.grAmount,
            this.Packs,
            this.dmg_qty,
            this.dmgAmt,
            this.masterKeyId,
            this.trf_Id,
            this.unitId,
            this.PackQty,
            this.vendor_info,
            this.Company});
            this.lv_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_info.FullRowSelect = true;
            this.lv_info.GridLines = true;
            this.lv_info.HideSelection = false;
            this.lv_info.Location = new System.Drawing.Point(7, 104);
            this.lv_info.Name = "lv_info";
            this.lv_info.Size = new System.Drawing.Size(978, 271);
            this.lv_info.TabIndex = 18;
            this.lv_info.UseCompatibleStateImageBehavior = false;
            this.lv_info.View = System.Windows.Forms.View.Details;
            this.lv_info.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_info_ItemChecked);
            this.lv_info.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_info_ItemSelectionChanged);
            this.lv_info.SelectedIndexChanged += new System.EventHandler(this.lv_info_SelectedIndexChanged);
            this.lv_info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_info_KeyDown);
            // 
            // CheckBox
            // 
            this.CheckBox.Text = "";
            this.CheckBox.Width = 18;
            // 
            // item_name
            // 
            this.item_name.Text = "PRODUCT NAME";
            this.item_name.Width = 230;
            // 
            // batch_no
            // 
            this.batch_no.Text = "BATCH";
            // 
            // Exp_Date
            // 
            this.Exp_Date.Text = "EX-DT";
            this.Exp_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MRP
            // 
            this.MRP.Text = "MRP";
            this.MRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NPR
            // 
            this.NPR.Text = "NPR";
            this.NPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 40;
            // 
            // RcptQty
            // 
            this.RcptQty.Text = "R.Qty";
            this.RcptQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RcptQty.Width = 50;
            // 
            // grAmount
            // 
            this.grAmount.Text = "GR.AMT";
            this.grAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.grAmount.Width = 70;
            // 
            // Packs
            // 
            this.Packs.Text = "Packs";
            this.Packs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Packs.Width = 45;
            // 
            // dmg_qty
            // 
            this.dmg_qty.Text = "Dmg.Qty";
            this.dmg_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dmgAmt
            // 
            this.dmgAmt.Text = "DMG.AMT";
            this.dmgAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dmgAmt.Width = 75;
            // 
            // masterKeyId
            // 
            this.masterKeyId.Text = "masterKeyId";
            this.masterKeyId.Width = 0;
            // 
            // trf_Id
            // 
            this.trf_Id.Width = 0;
            // 
            // unitId
            // 
            this.unitId.Width = 0;
            // 
            // PackQty
            // 
            this.PackQty.Text = "P.Qty";
            this.PackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PackQty.Width = 0;
            // 
            // vendor_info
            // 
            this.vendor_info.Text = "Vendor";
            this.vendor_info.Width = 0;
            // 
            // Company
            // 
            this.Company.Text = "Company";
            this.Company.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetData);
            this.groupBox1.Controls.Add(this.chkSortOrder);
            this.groupBox1.Controls.Add(this.lblVendorName);
            this.groupBox1.Controls.Add(this.cmbTrfId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbUnitName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(976, 89);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Information";
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(852, 36);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(71, 24);
            this.btnGetData.TabIndex = 7;
            this.btnGetData.Text = "Submit";
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // chkSortOrder
            // 
            this.chkSortOrder.AutoSize = true;
            this.chkSortOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.chkSortOrder.Checked = true;
            this.chkSortOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSortOrder.ForeColor = System.Drawing.Color.Black;
            this.chkSortOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSortOrder.Location = new System.Drawing.Point(15, 41);
            this.chkSortOrder.Name = "chkSortOrder";
            this.chkSortOrder.Size = new System.Drawing.Size(94, 20);
            this.chkSortOrder.TabIndex = 6;
            this.chkSortOrder.Text = "By Vendor";
            this.chkSortOrder.UseVisualStyleBackColor = false;
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblVendorName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVendorName.ForeColor = System.Drawing.Color.Black;
            this.lblVendorName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVendorName.Location = new System.Drawing.Point(166, 66);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(64, 16);
            this.lblVendorName.TabIndex = 5;
            this.lblVendorName.Text = "Vendor :";
            this.lblVendorName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTrfId
            // 
            this.cmbTrfId.Enabled = false;
            this.cmbTrfId.FormattingEnabled = true;
            this.cmbTrfId.Location = new System.Drawing.Point(615, 36);
            this.cmbTrfId.Name = "cmbTrfId";
            this.cmbTrfId.Size = new System.Drawing.Size(223, 24);
            this.cmbTrfId.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cmbTrfId, "Press Enter After Selection");
            this.cmbTrfId.SelectedIndexChanged += new System.EventHandler(this.cmbTrfId_SelectedIndexChanged);
            this.cmbTrfId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTrfId_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(612, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transfer Id";
            // 
            // cmbUnitName
            // 
            this.cmbUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbUnitName.FormattingEnabled = true;
            this.cmbUnitName.Location = new System.Drawing.Point(167, 39);
            this.cmbUnitName.Name = "cmbUnitName";
            this.cmbUnitName.Size = new System.Drawing.Size(339, 23);
            this.cmbUnitName.TabIndex = 2;
            this.cmbUnitName.SelectedIndexChanged += new System.EventHandler(this.cmbUnitName_SelectedIndexChanged);
            this.cmbUnitName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUnitName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(167, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of Unit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnShow.FlatAppearance.BorderSize = 5;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnShow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShow.Location = new System.Drawing.Point(7, 378);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 67);
            this.btnShow.TabIndex = 42;
            this.btnShow.Text = "Summary";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblShort.ForeColor = System.Drawing.Color.LightCoral;
            this.lblShort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblShort.Location = new System.Drawing.Point(285, 441);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(75, 16);
            this.lblShort.TabIndex = 41;
            this.lblShort.Text = "XXXXX.XX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(163, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Shortage Rs.";
            // 
            // lblnr
            // 
            this.lblnr.AutoSize = true;
            this.lblnr.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblnr.ForeColor = System.Drawing.Color.Crimson;
            this.lblnr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblnr.Location = new System.Drawing.Point(285, 423);
            this.lblnr.Name = "lblnr";
            this.lblnr.Size = new System.Drawing.Size(75, 16);
            this.lblnr.TabIndex = 39;
            this.lblnr.Text = "XXXXX.XX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(117, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Non Returnable Rs.";
            // 
            // lblTotalGR
            // 
            this.lblTotalGR.AutoSize = true;
            this.lblTotalGR.Font = new System.Drawing.Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTotalGR.ForeColor = System.Drawing.Color.Black;
            this.lblTotalGR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalGR.Location = new System.Drawing.Point(278, 382);
            this.lblTotalGR.Name = "lblTotalGR";
            this.lblTotalGR.Size = new System.Drawing.Size(83, 18);
            this.lblTotalGR.TabIndex = 37;
            this.lblTotalGR.Text = "XXXXX.XX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(129, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total Expiry Rs.";
            // 
            // lblModify
            // 
            this.lblModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.lblModify.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblModify.ForeColor = System.Drawing.Color.Black;
            this.lblModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModify.Location = new System.Drawing.Point(407, 461);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(335, 25);
            this.lblModify.TabIndex = 34;
            this.lblModify.Text = "Received Qty";
            this.lblModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCorr
            // 
            this.txtCorr.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCorr.Location = new System.Drawing.Point(749, 451);
            this.txtCorr.Name = "txtCorr";
            this.txtCorr.Size = new System.Drawing.Size(72, 33);
            this.txtCorr.TabIndex = 33;
            this.txtCorr.Text = "0";
            this.txtCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCorr.Enter += new System.EventHandler(this.txtCorr_Enter);
            this.txtCorr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCorr_KeyDown);
            // 
            // lblGr
            // 
            this.lblGr.AutoSize = true;
            this.lblGr.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblGr.ForeColor = System.Drawing.Color.Green;
            this.lblGr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGr.Location = new System.Drawing.Point(285, 406);
            this.lblGr.Name = "lblGr";
            this.lblGr.Size = new System.Drawing.Size(75, 16);
            this.lblGr.TabIndex = 32;
            this.lblGr.Text = "XXXXX.XX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(131, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Goods Return Rs.";
            // 
            // btn_Complete
            // 
            this.btn_Complete.Enabled = false;
            this.btn_Complete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Complete.FlatAppearance.BorderSize = 2;
            this.btn_Complete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Complete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Complete.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Complete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Complete.Location = new System.Drawing.Point(877, 453);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(103, 31);
            this.btn_Complete.TabIndex = 35;
            this.btn_Complete.Text = "Complete";
            this.btn_Complete.UseVisualStyleBackColor = true;
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
            // 
            // rgb_ChangeVendor
            // 
            this.rgb_ChangeVendor.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_ChangeVendor.Controls.Add(this.btnChange);
            this.rgb_ChangeVendor.Controls.Add(this.rddl_vendor);
            this.rgb_ChangeVendor.Controls.Add(this.radLabel1);
            this.rgb_ChangeVendor.HeaderText = "Change Vendor Information";
            this.rgb_ChangeVendor.Location = new System.Drawing.Point(383, 380);
            this.rgb_ChangeVendor.Name = "rgb_ChangeVendor";
            this.rgb_ChangeVendor.Padding = new System.Windows.Forms.Padding(2, 19, 2, 2);
            this.rgb_ChangeVendor.Size = new System.Drawing.Size(600, 65);
            this.rgb_ChangeVendor.TabIndex = 43;
            this.rgb_ChangeVendor.Text = "Change Vendor Information";
            // 
            // rddl_vendor
            // 
            this.rddl_vendor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_vendor.Location = new System.Drawing.Point(128, 25);
            this.rddl_vendor.Name = "rddl_vendor";
            this.rddl_vendor.Size = new System.Drawing.Size(384, 25);
            this.rddl_vendor.TabIndex = 1;
            this.rddl_vendor.Text = "Select Vendor";
            this.rddl_vendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rddl_vendor_KeyDown);
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.Black;
            this.radLabel1.Location = new System.Drawing.Point(7, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(102, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Select Vendor";
            // 
            // btnChange
            // 
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnChange.FlatAppearance.BorderSize = 2;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.Red;
            this.btnChange.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChange.Location = new System.Drawing.Point(531, 23);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(64, 31);
            this.btnChange.TabIndex = 36;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // uc_ExpiryReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.rgb_ChangeVendor);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblnr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalGR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblModify);
            this.Controls.Add(this.txtCorr);
            this.Controls.Add(this.lblGr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Complete);
            this.Controls.Add(this.lv_info);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "uc_ExpiryReceiving";
            this.Size = new System.Drawing.Size(990, 498);
            this.Load += new System.EventHandler(this.uc_ExpiryReceiving_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_ChangeVendor)).EndInit();
            this.rgb_ChangeVendor.ResumeLayout(false);
            this.rgb_ChangeVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_info;
        private System.Windows.Forms.ColumnHeader CheckBox;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader batch_no;
        private System.Windows.Forms.ColumnHeader Exp_Date;
        private System.Windows.Forms.ColumnHeader MRP;
        private System.Windows.Forms.ColumnHeader NPR;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader RcptQty;
        private System.Windows.Forms.ColumnHeader grAmount;
        private System.Windows.Forms.ColumnHeader Packs;
        private System.Windows.Forms.ColumnHeader dmg_qty;
        private System.Windows.Forms.ColumnHeader dmgAmt;
        private System.Windows.Forms.ColumnHeader masterKeyId;
        private System.Windows.Forms.ColumnHeader trf_Id;
        private System.Windows.Forms.ColumnHeader unitId;
        private System.Windows.Forms.ColumnHeader PackQty;
        private System.Windows.Forms.ColumnHeader vendor_info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSortOrder;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.ComboBox cmbTrfId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblnr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalGR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.TextBox txtCorr;
        private System.Windows.Forms.Label lblGr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Complete;
        private Telerik.WinControls.UI.RadGroupBox rgb_ChangeVendor;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rddl_vendor;
        private System.Windows.Forms.ColumnHeader Company;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadButton btnGetData;
        private System.Windows.Forms.Button btnChange;
    }
}
