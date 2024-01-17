namespace eMediShop.contract
{
    partial class HAL_Orders
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HAL_Orders));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOrderDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.txtpbno = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.txtSrNo = new Telerik.WinControls.UI.RadTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lv_referralList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemhelpgrid = new System.Windows.Forms.ListView();
            this.itemid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtptname = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new Telerik.WinControls.UI.RadButton();
            this.rgvOrderHeaders = new Telerik.WinControls.UI.RadGridView();
            this.rgbItems = new Telerik.WinControls.UI.RadGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.rgvItemGrid = new Telerik.WinControls.UI.RadGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrescribedBy = new Telerik.WinControls.UI.RadTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpbno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSrNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtptname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders.MasterTemplate)).BeginInit();
            this.rgvOrderHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbItems)).BeginInit();
            this.rgbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvItemGrid.MasterTemplate)).BeginInit();
            this.rgvItemGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrescribedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtpbno);
            this.groupBox1.Controls.Add(this.txtSrNo);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Order";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(253, 47);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(110, 25);
            this.dtpOrderDate.TabIndex = 121;
            this.dtpOrderDate.TabStop = false;
            this.dtpOrderDate.Text = "11-01-2024";
            this.dtpOrderDate.Value = new System.DateTime(2024, 1, 11, 15, 35, 30, 360);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(250, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 20);
            this.label27.TabIndex = 120;
            this.label27.Text = "Order Date";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtpbno
            // 
            this.txtpbno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpbno.Location = new System.Drawing.Point(118, 47);
            this.txtpbno.MaxLength = 10;
            this.txtpbno.Name = "txtpbno";
            this.txtpbno.Size = new System.Drawing.Size(110, 25);
            this.txtpbno.TabIndex = 119;
            this.txtpbno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpbno.Enter += new System.EventHandler(this.txtpbno_Enter);
            this.txtpbno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpbno_KeyUp);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtpbno.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtpbno.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // txtSrNo
            // 
            this.txtSrNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrNo.Location = new System.Drawing.Point(14, 47);
            this.txtSrNo.MaxLength = 4;
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(74, 25);
            this.txtSrNo.TabIndex = 118;
            this.txtSrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSrNo.Enter += new System.EventHandler(this.txtSrNo_Enter);
            this.txtSrNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrNo_KeyUp);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSrNo.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSrNo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(155, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 20);
            this.label26.TabIndex = 117;
            this.label26.Text = "PB No.";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 20);
            this.label25.TabIndex = 116;
            this.label25.Text = "Sr. No.";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lv_referralList
            // 
            this.lv_referralList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lv_referralList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lv_referralList.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_referralList.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_referralList.ForeColor = System.Drawing.Color.Black;
            this.lv_referralList.FullRowSelect = true;
            this.lv_referralList.GridLines = true;
            this.lv_referralList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_referralList.HideSelection = false;
            this.lv_referralList.Location = new System.Drawing.Point(137, 0);
            this.lv_referralList.Name = "lv_referralList";
            this.lv_referralList.Size = new System.Drawing.Size(338, 358);
            this.lv_referralList.TabIndex = 139;
            this.lv_referralList.UseCompatibleStateImageBehavior = false;
            this.lv_referralList.View = System.Windows.Forms.View.Details;
            this.lv_referralList.Visible = false;
            this.lv_referralList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_referralList_KeyDown);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name of Referral";
            this.columnHeader3.Width = 300;
            // 
            // itemhelpgrid
            // 
            this.itemhelpgrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.itemhelpgrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemid,
            this.itemname});
            this.itemhelpgrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemhelpgrid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemhelpgrid.ForeColor = System.Drawing.Color.Black;
            this.itemhelpgrid.FullRowSelect = true;
            this.itemhelpgrid.GridLines = true;
            this.itemhelpgrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemhelpgrid.HideSelection = false;
            this.itemhelpgrid.Location = new System.Drawing.Point(5, -4);
            this.itemhelpgrid.Name = "itemhelpgrid";
            this.itemhelpgrid.Size = new System.Drawing.Size(425, 407);
            this.itemhelpgrid.TabIndex = 25;
            this.itemhelpgrid.UseCompatibleStateImageBehavior = false;
            this.itemhelpgrid.View = System.Windows.Forms.View.Details;
            this.itemhelpgrid.Visible = false;
            this.itemhelpgrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemhelpgrid_KeyDown);
            // 
            // itemid
            // 
            this.itemid.Text = "ItemID";
            this.itemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemid.Width = 0;
            // 
            // itemname
            // 
            this.itemname.Text = "Product Name";
            this.itemname.Width = 400;
            // 
            // txtptname
            // 
            this.txtptname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtptname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtptname.Location = new System.Drawing.Point(138, 103);
            this.txtptname.MaxLength = 100;
            this.txtptname.Name = "txtptname";
            this.txtptname.Size = new System.Drawing.Size(341, 25);
            this.txtptname.TabIndex = 124;
            this.txtptname.Enter += new System.EventHandler(this.txtptname_Enter);
            this.txtptname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtptname_KeyUp);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtptname.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtptname.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Name of patient";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(520, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(66, 46);
            this.btnCreate.TabIndex = 122;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rgvOrderHeaders
            // 
            this.rgvOrderHeaders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvOrderHeaders.Controls.Add(this.lv_referralList);
            this.rgvOrderHeaders.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvOrderHeaders.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvOrderHeaders.ForeColor = System.Drawing.Color.Black;
            this.rgvOrderHeaders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvOrderHeaders.Location = new System.Drawing.Point(1, 163);
            // 
            // 
            // 
            this.rgvOrderHeaders.MasterTemplate.AllowAddNewRow = false;
            this.rgvOrderHeaders.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "orderNo";
            gridViewTextBoxColumn1.HeaderText = "Internal Order No";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "orderNo";
            gridViewTextBoxColumn1.Width = 107;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column5";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "srno";
            gridViewTextBoxColumn2.HeaderText = "Sr. No.";
            gridViewTextBoxColumn2.Name = "srno";
            gridViewTextBoxColumn2.Width = 56;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pbno";
            gridViewTextBoxColumn3.HeaderText = "PBNO";
            gridViewTextBoxColumn3.Name = "pbno";
            gridViewTextBoxColumn3.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "orderdate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.HeaderText = "Order Date";
            gridViewDateTimeColumn1.Name = "orderdate";
            gridViewDateTimeColumn1.Width = 91;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ptname";
            gridViewTextBoxColumn4.HeaderText = "Name of Patient";
            gridViewTextBoxColumn4.Name = "ptname";
            gridViewTextBoxColumn4.Width = 290;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "prescribedBy";
            gridViewTextBoxColumn5.HeaderText = "Prescribed By";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "prescribedBy";
            this.rgvOrderHeaders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.rgvOrderHeaders.MasterTemplate.EnableFiltering = true;
            this.rgvOrderHeaders.MasterTemplate.EnableGrouping = false;
            this.rgvOrderHeaders.MasterTemplate.EnableSorting = false;
            this.rgvOrderHeaders.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvOrderHeaders.Name = "rgvOrderHeaders";
            this.rgvOrderHeaders.ReadOnly = true;
            this.rgvOrderHeaders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvOrderHeaders.Size = new System.Drawing.Size(585, 319);
            this.rgvOrderHeaders.TabIndex = 1;
            this.rgvOrderHeaders.Text = "radGridView1";
            this.rgvOrderHeaders.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // rgbItems
            // 
            this.rgbItems.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbItems.Controls.Add(this.label2);
            this.rgbItems.Controls.Add(this.label1);
            this.rgbItems.Controls.Add(this.txtQty);
            this.rgbItems.Controls.Add(this.txtMedName);
            this.rgbItems.Controls.Add(this.rgvItemGrid);
            this.rgbItems.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbItems.HeaderText = "XXXXXXXXXXXX";
            this.rgbItems.Location = new System.Drawing.Point(592, 3);
            this.rgbItems.Name = "rgbItems";
            this.rgbItems.Size = new System.Drawing.Size(524, 492);
            this.rgbItems.TabIndex = 2;
            this.rgbItems.Text = "XXXXXXXXXXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 119;
            this.label2.Text = "Qty";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Name of Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQty
            // 
            this.txtQty.AcceptsReturn = true;
            this.txtQty.BackColor = System.Drawing.Color.Black;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Yellow;
            this.txtQty.Location = new System.Drawing.Point(431, 48);
            this.txtQty.MaxLength = 10;
            this.txtQty.Name = "txtQty";
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQty.Size = new System.Drawing.Size(60, 26);
            this.txtQty.TabIndex = 107;
            this.txtQty.TabStop = false;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.Enter += new System.EventHandler(this.txtQty_Enter);
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // txtMedName
            // 
            this.txtMedName.AcceptsReturn = true;
            this.txtMedName.BackColor = System.Drawing.Color.White;
            this.txtMedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMedName.Location = new System.Drawing.Point(10, 49);
            this.txtMedName.MaxLength = 100;
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMedName.Size = new System.Drawing.Size(419, 25);
            this.txtMedName.TabIndex = 3;
            this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);
            this.txtMedName.Enter += new System.EventHandler(this.txtMedName_Enter);
            this.txtMedName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedName_KeyDown);
            // 
            // rgvItemGrid
            // 
            this.rgvItemGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvItemGrid.Controls.Add(this.itemhelpgrid);
            this.rgvItemGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvItemGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvItemGrid.ForeColor = System.Drawing.Color.Black;
            this.rgvItemGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvItemGrid.Location = new System.Drawing.Point(5, 80);
            // 
            // 
            // 
            this.rgvItemGrid.MasterTemplate.AllowAddNewRow = false;
            this.rgvItemGrid.MasterTemplate.AllowColumnReorder = false;
            this.rgvItemGrid.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "itemID";
            gridViewTextBoxColumn6.HeaderText = "Item ID";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "itemID";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "item_Name";
            gridViewTextBoxColumn7.HeaderText = "Name of Product";
            gridViewTextBoxColumn7.Name = "itemName";
            gridViewTextBoxColumn7.Width = 360;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "qty";
            gridViewTextBoxColumn8.HeaderText = "Qty";
            gridViewTextBoxColumn8.Name = "qty";
            gridViewTextBoxColumn8.Width = 52;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column1";
            gridViewCommandColumn2.Width = 25;
            this.rgvItemGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewCommandColumn2});
            this.rgvItemGrid.MasterTemplate.EnableGrouping = false;
            this.rgvItemGrid.MasterTemplate.EnableSorting = false;
            this.rgvItemGrid.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvItemGrid.Name = "rgvItemGrid";
            this.rgvItemGrid.ReadOnly = true;
            this.rgvItemGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvItemGrid.Size = new System.Drawing.Size(486, 407);
            this.rgvItemGrid.TabIndex = 2;
            this.rgvItemGrid.Text = "radGridView2";
            this.rgvItemGrid.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvItemGrid_CommandCellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 125;
            this.label4.Text = "Prescribed By";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrescribedBy
            // 
            this.txtPrescribedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrescribedBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrescribedBy.Location = new System.Drawing.Point(138, 132);
            this.txtPrescribedBy.MaxLength = 100;
            this.txtPrescribedBy.Name = "txtPrescribedBy";
            this.txtPrescribedBy.Size = new System.Drawing.Size(341, 25);
            this.txtPrescribedBy.TabIndex = 125;
            this.txtPrescribedBy.TextChanged += new System.EventHandler(this.txtPrescribedBy_TextChanged);
            this.txtPrescribedBy.Enter += new System.EventHandler(this.txtPrescribedBy_Enter);
            this.txtPrescribedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrescribedBy_KeyDown);
            this.txtPrescribedBy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrescribedBy_KeyUp);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPrescribedBy.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtPrescribedBy.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // HAL_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 498);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPrescribedBy);
            this.Controls.Add(this.rgbItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rgvOrderHeaders);
            this.Controls.Add(this.txtptname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HAL_Orders";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Entry [HAL]";
            this.Load += new System.EventHandler(this.HAL_Orders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpbno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSrNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtptname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders)).EndInit();
            this.rgvOrderHeaders.ResumeLayout(false);
            this.rgvOrderHeaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbItems)).EndInit();
            this.rgbItems.ResumeLayout(false);
            this.rgbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvItemGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvItemGrid)).EndInit();
            this.rgvItemGrid.ResumeLayout(false);
            this.rgvItemGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrescribedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btnCreate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label27;
        private Telerik.WinControls.UI.RadTextBox txtpbno;
        private Telerik.WinControls.UI.RadTextBox txtSrNo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private Telerik.WinControls.UI.RadGridView rgvOrderHeaders;
        private Telerik.WinControls.UI.RadGroupBox rgbItems;
        private Telerik.WinControls.UI.RadGridView rgvItemGrid;
        public System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtQty;
        private Telerik.WinControls.UI.RadTextBox txtptname;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadTextBox txtPrescribedBy;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListView lv_referralList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ListView itemhelpgrid;
        public System.Windows.Forms.ColumnHeader itemid;
        private System.Windows.Forms.ColumnHeader itemname;
    }
}