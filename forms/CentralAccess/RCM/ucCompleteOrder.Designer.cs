namespace eMediShop.forms.CentralAccess.RCM
{
    partial class ucCompleteOrder
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCompleteOrder));
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem3 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbdeltime = new System.Windows.Forms.ComboBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.gbxDate = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelay = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.btnComplete = new Telerik.WinControls.UI.RadButton();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.dtFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtdeldate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.gbxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdeldate)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 263;
            this.label9.Text = "Order No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(384, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 261;
            this.label10.Text = "Delivered Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(521, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 14);
            this.label11.TabIndex = 260;
            this.label11.Text = "Delivery Time";
            // 
            // cmbdeltime
            // 
            this.cmbdeltime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdeltime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbdeltime.Location = new System.Drawing.Point(526, 481);
            this.cmbdeltime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbdeltime.Name = "cmbdeltime";
            this.cmbdeltime.Size = new System.Drawing.Size(121, 22);
            this.cmbdeltime.TabIndex = 259;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNo.Enabled = false;
            this.txtOrderNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Location = new System.Drawing.Point(114, 478);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(173, 23);
            this.txtOrderNo.TabIndex = 257;
            this.txtOrderNo.TextChanged += new System.EventHandler(this.txtOrderNo_TextChanged);
            // 
            // gbxDate
            // 
            this.gbxDate.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDate.Controls.Add(this.dtTo);
            this.gbxDate.Controls.Add(this.dtFrom);
            this.gbxDate.Controls.Add(this.label13);
            this.gbxDate.Controls.Add(this.btnGo);
            this.gbxDate.Controls.Add(this.label14);
            this.gbxDate.Controls.Add(this.label12);
            this.gbxDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDate.Location = new System.Drawing.Point(5, -1);
            this.gbxDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDate.Name = "gbxDate";
            this.gbxDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDate.Size = new System.Drawing.Size(975, 52);
            this.gbxDate.TabIndex = 256;
            this.gbxDate.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(750, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 243;
            this.label13.Text = "To";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.LightCoral;
            this.btnGo.Location = new System.Drawing.Point(897, 15);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(57, 28);
            this.btnGo.TabIndex = 242;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(585, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 241;
            this.label14.Text = "From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 16);
            this.label12.TabIndex = 247;
            this.label12.Text = "Delivery Marking Information";
            // 
            // btnDelay
            // 
            this.btnDelay.Enabled = false;
            this.btnDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelay.Location = new System.Drawing.Point(15, 461);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(52, 46);
            this.btnDelay.TabIndex = 264;
            this.btnDelay.Text = "Remark";
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDelay.GetChildAt(0))).Text = "Remark";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDelay.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.Control;
            this.btnComplete.Enabled = false;
            this.btnComplete.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(909, 454);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(55, 49);
            this.btnComplete.TabIndex = 265;
            this.btnComplete.Text = "Complete";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnComplete.GetChildAt(0))).Text = "Complete";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnComplete.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(5, 59);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn15.AllowFiltering = false;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "order_no";
            gridViewTextBoxColumn15.HeaderText = "Order No";
            gridViewTextBoxColumn15.Name = "order_no";
            gridViewTextBoxColumn15.Width = 104;
            gridViewTextBoxColumn16.AllowFiltering = false;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "card_no";
            gridViewTextBoxColumn16.HeaderText = "Health Card No";
            gridViewTextBoxColumn16.Name = "card_no";
            gridViewTextBoxColumn16.Width = 117;
            gridViewTextBoxColumn17.AllowFiltering = false;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "cust_name";
            gridViewTextBoxColumn17.HeaderText = "Name of Customer";
            gridViewTextBoxColumn17.Name = "cust_name";
            gridViewTextBoxColumn17.Width = 186;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "mobileno";
            gridViewTextBoxColumn18.HeaderText = "Mobile No";
            gridViewTextBoxColumn18.Name = "mobile_no";
            gridViewTextBoxColumn18.Width = 102;
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "net";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Amount";
            gridViewDecimalColumn3.Name = "net";
            gridViewDecimalColumn3.Width = 66;
            gridViewDateTimeColumn3.AllowFiltering = false;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "order_date";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn3.FormatString = "{0:dd-MM-yyyy}";
            gridViewDateTimeColumn3.HeaderText = "Order Date";
            gridViewDateTimeColumn3.Name = "order_date";
            gridViewDateTimeColumn3.Width = 72;
            gridViewTextBoxColumn19.AllowFiltering = false;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "del_date";
            gridViewTextBoxColumn19.HeaderText = "Delivery  Comitted";
            gridViewTextBoxColumn19.Name = "del_date";
            gridViewTextBoxColumn19.Width = 115;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "deld_date";
            gridViewTextBoxColumn20.HeaderText = "Delivered On";
            gridViewTextBoxColumn20.Name = "deld_date";
            gridViewTextBoxColumn20.Width = 105;
            gridViewTextBoxColumn21.AllowFiltering = false;
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.FieldName = "del_status";
            gridViewTextBoxColumn21.HeaderText = "Status";
            gridViewTextBoxColumn21.Name = "del_status";
            gridViewCommandColumn3.EnableExpressionEditor = false;
            gridViewCommandColumn3.HeaderText = "-";
            gridViewCommandColumn3.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn3.Image")));
            gridViewCommandColumn3.Name = "column1";
            gridViewCommandColumn3.Width = 25;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewCommandColumn3});
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            gridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem3.FormatString = "{0:N0}";
            gridViewSummaryItem3.Name = "net";
            this.rgv_info.MasterTemplate.SummaryRowsTop.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem3}));
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(975, 382);
            this.rgv_info.TabIndex = 266;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(626, 17);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(102, 25);
            this.dtFrom.TabIndex = 248;
            this.dtFrom.TabStop = false;
            this.dtFrom.Text = "11/09/2017";
            this.dtFrom.Value = new System.DateTime(2017, 9, 11, 17, 31, 56, 702);
            this.dtFrom.Leave += new System.EventHandler(this.dtFrom_Leave);
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(778, 17);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(102, 25);
            this.dtTo.TabIndex = 249;
            this.dtTo.TabStop = false;
            this.dtTo.Text = "11/09/2017";
            this.dtTo.Value = new System.DateTime(2017, 9, 11, 17, 31, 56, 702);
            // 
            // dtdeldate
            // 
            this.dtdeldate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdeldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdeldate.Location = new System.Drawing.Point(387, 478);
            this.dtdeldate.Name = "dtdeldate";
            this.dtdeldate.Size = new System.Drawing.Size(102, 25);
            this.dtdeldate.TabIndex = 267;
            this.dtdeldate.TabStop = false;
            this.dtdeldate.Text = "11/09/2017";
            this.dtdeldate.Value = new System.DateTime(2017, 9, 11, 17, 31, 56, 702);
            // 
            // ucCompleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtdeldate);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnDelay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbdeltime);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.gbxDate);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucCompleteOrder";
            this.Size = new System.Drawing.Size(983, 510);
            this.Load += new System.EventHandler(this.ucCompleteOrder_Load);
            this.gbxDate.ResumeLayout(false);
            this.gbxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdeldate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbdeltime;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.GroupBox gbxDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private Telerik.WinControls.UI.RadButton btnDelay;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.UI.RadButton btnComplete;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadDateTimePicker dtTo;
        private Telerik.WinControls.UI.RadDateTimePicker dtFrom;
        private Telerik.WinControls.UI.RadDateTimePicker dtdeldate;
    }
}
