namespace eMediShop.forms.CentralAccess.RCM
{
    partial class ucTakeOrder
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtdeldate = new System.Windows.Forms.DateTimePicker();
            this.cmbtime = new System.Windows.Forms.ComboBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.dtRmdDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbdeltime = new System.Windows.Forms.ComboBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvNewproduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtnewqty = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.itemid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.chkDeliveryMode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPresBy = new System.Windows.Forms.TextBox();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.btnAddReg = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(9, 319);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(844, 32);
            this.txtRemark.TabIndex = 50;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightCoral;
            this.btnSave.Location = new System.Drawing.Point(769, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 27);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Submit";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtdeldate
            // 
            this.dtdeldate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdeldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdeldate.Location = new System.Drawing.Point(501, 360);
            this.dtdeldate.Name = "dtdeldate";
            this.dtdeldate.Size = new System.Drawing.Size(102, 25);
            this.dtdeldate.TabIndex = 39;
            // 
            // cmbtime
            // 
            this.cmbtime.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtime.FormattingEnabled = true;
            this.cmbtime.Items.AddRange(new object[] {
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 AM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM",
            "12:00 PM"});
            this.cmbtime.Location = new System.Drawing.Point(651, 402);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(91, 24);
            this.cmbtime.TabIndex = 52;
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnComplete.Location = new System.Drawing.Point(774, 359);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(77, 27);
            this.btnComplete.TabIndex = 46;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // dtRmdDate
            // 
            this.dtRmdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRmdDate.Location = new System.Drawing.Point(503, 403);
            this.dtRmdDate.Name = "dtRmdDate";
            this.dtRmdDate.Size = new System.Drawing.Size(100, 25);
            this.dtRmdDate.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(405, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 15);
            this.label17.TabIndex = 48;
            this.label17.Text = "Next Call Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(649, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Order No";
            // 
            // cmbdeltime
            // 
            this.cmbdeltime.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdeltime.FormattingEnabled = true;
            this.cmbdeltime.Items.AddRange(new object[] {
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 AM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM",
            "12:00 PM"});
            this.cmbdeltime.Location = new System.Drawing.Point(650, 360);
            this.cmbdeltime.Name = "cmbdeltime";
            this.cmbdeltime.Size = new System.Drawing.Size(92, 24);
            this.cmbdeltime.TabIndex = 40;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Location = new System.Drawing.Point(718, 9);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.ReadOnly = true;
            this.txtOrderNo.Size = new System.Drawing.Size(142, 23);
            this.txtOrderNo.TabIndex = 44;
            this.txtOrderNo.Text = "New";
            this.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Delivery Date";
            // 
            // lvNewproduct
            // 
            this.lvNewproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvNewproduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvNewproduct.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNewproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvNewproduct.FullRowSelect = true;
            this.lvNewproduct.GridLines = true;
            this.lvNewproduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvNewproduct.Location = new System.Drawing.Point(9, 298);
            this.lvNewproduct.Name = "lvNewproduct";
            this.lvNewproduct.Size = new System.Drawing.Size(667, 140);
            this.lvNewproduct.TabIndex = 41;
            this.lvNewproduct.UseCompatibleStateImageBehavior = false;
            this.lvNewproduct.View = System.Windows.Forms.View.Details;
            this.lvNewproduct.Visible = false;
            this.lvNewproduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvNewproduct_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "itemid";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 455;
            // 
            // txtnewqty
            // 
            this.txtnewqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnewqty.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewqty.Location = new System.Drawing.Point(758, 272);
            this.txtnewqty.Name = "txtnewqty";
            this.txtnewqty.Size = new System.Drawing.Size(77, 25);
            this.txtnewqty.TabIndex = 38;
            this.txtnewqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnewqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnewqty_KeyDown);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(10, 272);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(745, 25);
            this.txtItemName.TabIndex = 37;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // lvOrder
            // 
            this.lvOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemid,
            this.productname,
            this.Qty});
            this.lvOrder.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrder.ForeColor = System.Drawing.Color.Blue;
            this.lvOrder.FullRowSelect = true;
            this.lvOrder.GridLines = true;
            this.lvOrder.Location = new System.Drawing.Point(9, 13);
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(846, 253);
            this.lvOrder.TabIndex = 36;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            this.lvOrder.Click += new System.EventHandler(this.lv_Click);
            this.lvOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lv_MouseDown);
            // 
            // itemid
            // 
            this.itemid.Text = "itemid";
            this.itemid.Width = 0;
            // 
            // productname
            // 
            this.productname.Text = "Product Name";
            this.productname.Width = 747;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BackColor = System.Drawing.Color.White;
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCardNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(78, 7);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(121, 23);
            this.txtCardNumber.TabIndex = 56;
            this.txtCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardNumber_KeyDown);
            // 
            // pnlOrder
            // 
            this.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder.Controls.Add(this.chkDeliveryMode);
            this.pnlOrder.Controls.Add(this.label3);
            this.pnlOrder.Controls.Add(this.txtPresBy);
            this.pnlOrder.Controls.Add(this.lvOrder);
            this.pnlOrder.Controls.Add(this.txtItemName);
            this.pnlOrder.Controls.Add(this.txtnewqty);
            this.pnlOrder.Controls.Add(this.label1);
            this.pnlOrder.Controls.Add(this.label5);
            this.pnlOrder.Controls.Add(this.lvNewproduct);
            this.pnlOrder.Controls.Add(this.label7);
            this.pnlOrder.Controls.Add(this.cmbdeltime);
            this.pnlOrder.Controls.Add(this.txtRemark);
            this.pnlOrder.Controls.Add(this.label4);
            this.pnlOrder.Controls.Add(this.btnSave);
            this.pnlOrder.Controls.Add(this.label17);
            this.pnlOrder.Controls.Add(this.dtdeldate);
            this.pnlOrder.Controls.Add(this.dtRmdDate);
            this.pnlOrder.Controls.Add(this.cmbtime);
            this.pnlOrder.Controls.Add(this.btnComplete);
            this.pnlOrder.Enabled = false;
            this.pnlOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.pnlOrder.Location = new System.Drawing.Point(3, 42);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(869, 443);
            this.pnlOrder.TabIndex = 58;
            this.pnlOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrder_Paint);
            // 
            // chkDeliveryMode
            // 
            this.chkDeliveryMode.AutoSize = true;
            this.chkDeliveryMode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkDeliveryMode.Location = new System.Drawing.Point(97, 401);
            this.chkDeliveryMode.Name = "chkDeliveryMode";
            this.chkDeliveryMode.Size = new System.Drawing.Size(109, 17);
            this.chkDeliveryMode.TabIndex = 58;
            this.chkDeliveryMode.Text = "Home Delivery";
            this.chkDeliveryMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Prescribed By ";
            // 
            // txtPresBy
            // 
            this.txtPresBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPresBy.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresBy.Location = new System.Drawing.Point(97, 361);
            this.txtPresBy.MaxLength = 40;
            this.txtPresBy.Name = "txtPresBy";
            this.txtPresBy.Size = new System.Drawing.Size(285, 25);
            this.txtPresBy.TabIndex = 56;
            this.txtPresBy.Text = "SELF";
            this.txtPresBy.Enter += new System.EventHandler(this.txtPresBy_Enter);
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.BackColor = System.Drawing.Color.Transparent;
            this.lblCardHolder.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardHolder.Location = new System.Drawing.Point(239, 12);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(210, 15);
            this.lblCardHolder.TabIndex = 59;
            this.lblCardHolder.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // btnAddReg
            // 
            this.btnAddReg.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddReg.Enabled = false;
            this.btnAddReg.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReg.Location = new System.Drawing.Point(509, 8);
            this.btnAddReg.Name = "btnAddReg";
            this.btnAddReg.Size = new System.Drawing.Size(134, 27);
            this.btnAddReg.TabIndex = 60;
            this.btnAddReg.Text = "ADD REGULAR MEDICINE";
            this.btnAddReg.UseVisualStyleBackColor = false;
            this.btnAddReg.Click += new System.EventHandler(this.btnAddReg_Click);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.LightCoral;
            this.btnGet.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(207, 5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(33, 27);
            this.btnGet.TabIndex = 61;
            this.btnGet.Text = ">>";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // ucTakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnAddReg);
            this.Controls.Add(this.lblCardHolder);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtOrderNo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "ucTakeOrder";
            this.Size = new System.Drawing.Size(875, 510);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtdeldate;
        private System.Windows.Forms.ComboBox cmbtime;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.DateTimePicker dtRmdDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbdeltime;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvNewproduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtnewqty;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ColumnHeader itemid;
        private System.Windows.Forms.ColumnHeader productname;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.Button btnAddReg;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPresBy;
        private System.Windows.Forms.CheckBox chkDeliveryMode;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}
