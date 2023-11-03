namespace eMediShop.forms.CentralAccess.RCM
{
    partial class ucIncomingOrder
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucIncomingOrder));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnChkOrder = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnDelay = new Telerik.WinControls.UI.RadButton();
            this.btn_print = new System.Windows.Forms.Button();
            this.lblTot = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lv_prodInfo = new System.Windows.Forms.ListView();
            this.srno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.products = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instkqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelay)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(251, 17);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(10, 13);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "-";
            // 
            // btnChkOrder
            // 
            this.btnChkOrder.Image = global::eMediShop.Properties.Resources.click_32;
            this.btnChkOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChkOrder.Location = new System.Drawing.Point(4, 7);
            this.btnChkOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChkOrder.Name = "btnChkOrder";
            this.btnChkOrder.Size = new System.Drawing.Size(178, 28);
            this.btnChkOrder.TabIndex = 2;
            this.btnChkOrder.Text = "Click To Get Order No";
            this.btnChkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChkOrder.UseVisualStyleBackColor = true;
            this.btnChkOrder.Click += new System.EventHandler(this.btnChkOrder_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnDelay);
            this.gb1.Controls.Add(this.btn_print);
            this.gb1.Controls.Add(this.lblTot);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.groupBox3);
            this.gb1.Controls.Add(this.panel1);
            this.gb1.Controls.Add(this.btnClose);
            this.gb1.Controls.Add(this.lv_prodInfo);
            this.gb1.Enabled = false;
            this.gb1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(4, 35);
            this.gb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb1.Size = new System.Drawing.Size(1012, 463);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(330, 419);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(110, 37);
            this.btnDelay.TabIndex = 24;
            this.btnDelay.Text = "Write Delay Remark";
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            // 
            // btn_print
            // 
            this.btn_print.Image = global::eMediShop.Properties.Resources.printer;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(759, 420);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(99, 38);
            this.btn_print.TabIndex = 23;
            this.btn_print.Text = "Print Bill";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.ForeColor = System.Drawing.Color.Red;
            this.lblTot.Location = new System.Drawing.Point(974, 587);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(16, 14);
            this.lblTot.TabIndex = 7;
            this.lblTot.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(873, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount(Rs) ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rgv_info);
            this.groupBox3.Location = new System.Drawing.Point(7, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(314, 447);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order No";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(7, 17);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AllowDeleteRow = false;
            this.rgv_info.MasterTemplate.AllowEditRow = false;
            this.rgv_info.MasterTemplate.AllowSearchRow = true;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "order_no";
            gridViewTextBoxColumn1.HeaderText = "Order Number";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Order Number";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 123;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "cust_name";
            gridViewTextBoxColumn2.HeaderText = "Member Name";
            gridViewTextBoxColumn2.Name = "cust_name";
            gridViewTextBoxColumn2.Width = 187;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "cmd";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "orderType";
            gridViewTextBoxColumn3.HeaderText = "Order Type";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Order Type";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "viewunit_flag";
            gridViewTextBoxColumn4.HeaderText = "column1";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "viewUnit_flag";
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "orderdate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:dd-MM-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Date";
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "order_date";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1});
            groupDescriptor1.Format = "{0}: {1:dd-MM-yyyy}";
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "order_date";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            sortDescriptor2.PropertyName = "Order Type";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1,
            groupDescriptor2});
            sortDescriptor3.PropertyName = "Order Number";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(295, 425);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_info_RowFormatting);
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(327, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 138);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(467, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(208, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delivery Info";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(73, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(11, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "-";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTime.Location = new System.Drawing.Point(73, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(11, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(22, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(22, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContactNo);
            this.groupBox1.Controls.Add(this.lblAdd);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Controls.Add(this.lblCardNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info ";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.Maroon;
            this.lblContactNo.Location = new System.Drawing.Point(132, 99);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(14, 14);
            this.lblContactNo.TabIndex = 7;
            this.lblContactNo.Text = "-";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Verdana", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAdd.Location = new System.Drawing.Point(132, 71);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(9, 10);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "-";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCustName.Location = new System.Drawing.Point(132, 44);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(14, 14);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "-";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.ForeColor = System.Drawing.Color.Red;
            this.lblCardNo.Location = new System.Drawing.Point(132, 24);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(12, 14);
            this.lblCardNo.TabIndex = 4;
            this.lblCardNo.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact No  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cust. Name  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card No       :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(536, 419);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(187, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close Popup Reminder";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lv_prodInfo
            // 
            this.lv_prodInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.srno,
            this.itemid,
            this.products,
            this.qty,
            this.rate,
            this.amount,
            this.instkqty});
            this.lv_prodInfo.FullRowSelect = true;
            this.lv_prodInfo.GridLines = true;
            this.lv_prodInfo.HideSelection = false;
            this.lv_prodInfo.Location = new System.Drawing.Point(327, 167);
            this.lv_prodInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_prodInfo.Name = "lv_prodInfo";
            this.lv_prodInfo.Size = new System.Drawing.Size(678, 245);
            this.lv_prodInfo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lv_prodInfo, "F12: To Transfer As Urgent, F11: Replace medicine");
            this.lv_prodInfo.UseCompatibleStateImageBehavior = false;
            this.lv_prodInfo.View = System.Windows.Forms.View.Details;
            this.lv_prodInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_prodInfo_KeyUp);
            // 
            // srno
            // 
            this.srno.Text = "SrNo.";
            // 
            // itemid
            // 
            this.itemid.DisplayIndex = 6;
            this.itemid.Text = "Item Id";
            this.itemid.Width = 0;
            // 
            // products
            // 
            this.products.DisplayIndex = 1;
            this.products.Text = "Name of Product";
            this.products.Width = 269;
            // 
            // qty
            // 
            this.qty.DisplayIndex = 2;
            this.qty.Text = "Qty";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rate
            // 
            this.rate.DisplayIndex = 3;
            this.rate.Text = "Rate";
            this.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rate.Width = 85;
            // 
            // amount
            // 
            this.amount.DisplayIndex = 4;
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 80;
            // 
            // instkqty
            // 
            this.instkqty.DisplayIndex = 5;
            this.instkqty.Text = "Qty [InStk]";
            this.instkqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instkqty.Width = 100;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // ucIncomingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChkOrder);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucIncomingOrder";
            this.Size = new System.Drawing.Size(1018, 498);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnChkOrder;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lv_prodInfo;
        private System.Windows.Forms.ColumnHeader srno;
        private System.Windows.Forms.ColumnHeader products;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader rate;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnDelay;
        private System.Windows.Forms.ColumnHeader instkqty;
        private System.Windows.Forms.ColumnHeader itemid;
    }
}
