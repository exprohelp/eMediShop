namespace eMediShop.Utility
{
    partial class ucBulkBillPrinting
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBulkBillPrinting));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgbPayMode = new Telerik.WinControls.UI.RadGroupBox();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rbByUHID = new Telerik.WinControls.UI.RadRadioButton();
            this.rbByIPD = new Telerik.WinControls.UI.RadRadioButton();
            this.btnGet = new Telerik.WinControls.UI.RadButton();
            this.btnPrintAll = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            this.roundRectShape2 = new Telerik.WinControls.RoundRectShape(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rgbPayMode)).BeginInit();
            this.rgbPayMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbByUHID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbByIPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbPayMode
            // 
            this.rgbPayMode.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbPayMode.Controls.Add(this.txtSearch);
            this.rgbPayMode.Controls.Add(this.rbByUHID);
            this.rgbPayMode.Controls.Add(this.rbByIPD);
            this.rgbPayMode.Controls.Add(this.btnGet);
            this.rgbPayMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbPayMode.HeaderText = "Search Criteria";
            this.rgbPayMode.Location = new System.Drawing.Point(5, 12);
            this.rgbPayMode.Name = "rgbPayMode";
            this.rgbPayMode.Size = new System.Drawing.Size(745, 70);
            this.rgbPayMode.TabIndex = 16;
            this.rgbPayMode.Text = "Search Criteria";
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(244, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MaxLength = 20;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(192, 25);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSearch.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSearch.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rbByUHID
            // 
            this.rbByUHID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByUHID.Location = new System.Drawing.Point(111, 31);
            this.rbByUHID.Name = "rbByUHID";
            this.rbByUHID.Size = new System.Drawing.Size(79, 24);
            this.rbByUHID.TabIndex = 1;
            this.rbByUHID.TabStop = false;
            this.rbByUHID.Text = "By UHID";
            // 
            // rbByIPD
            // 
            this.rbByIPD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbByIPD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByIPD.Location = new System.Drawing.Point(7, 31);
            this.rbByIPD.Name = "rbByIPD";
            this.rbByIPD.Size = new System.Drawing.Size(91, 24);
            this.rbByIPD.TabIndex = 0;
            this.rbByIPD.Text = "By IPD No";
            this.rbByIPD.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(690, 23);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(50, 34);
            this.btnGet.TabIndex = 14;
            this.btnGet.Text = ">>";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnGet.GetChildAt(0))).Text = ">>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnGet.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Enabled = false;
            this.btnPrintAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.Location = new System.Drawing.Point(12, 394);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(74, 24);
            this.btnPrintAll.TabIndex = 11;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnPrintAll.GetChildAt(0))).Text = "Print All";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnPrintAll.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgvInfo);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 107);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(749, 281);
            this.radGroupBox1.TabIndex = 15;
            this.radGroupBox1.Text = "XXXXXXXXXXX";
            // 
            // rgvInfo
            // 
            this.rgvInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rgvInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvInfo.ForeColor = System.Drawing.Color.Black;
            this.rgvInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvInfo.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgvInfo.MasterTemplate.AllowAddNewRow = false;
            this.rgvInfo.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "sale_inv_no";
            gridViewTextBoxColumn1.HeaderText = "sale_inv_no";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "sale_inv_no";
            gridViewDateTimeColumn1.AllowFiltering = false;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "sale_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Date";
            gridViewDateTimeColumn1.Name = "sale_date";
            gridViewDateTimeColumn1.Width = 80;
            gridViewTextBoxColumn2.AllowFiltering = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "pt_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Customer";
            gridViewTextBoxColumn2.Name = "pt_name";
            gridViewTextBoxColumn2.Width = 192;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "total";
            gridViewDecimalColumn1.HeaderText = "Total";
            gridViewDecimalColumn1.Name = "total";
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "discount";
            gridViewDecimalColumn2.HeaderText = "Discount";
            gridViewDecimalColumn2.Name = "discount";
            gridViewDecimalColumn2.Width = 58;
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "net";
            gridViewDecimalColumn3.HeaderText = "Net";
            gridViewDecimalColumn3.Name = "net";
            gridViewDecimalColumn3.Width = 68;
            gridViewDecimalColumn4.AllowFiltering = false;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "received";
            gridViewDecimalColumn4.HeaderText = "Received";
            gridViewDecimalColumn4.Name = "received";
            gridViewDecimalColumn4.Width = 61;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pay_mode";
            gridViewTextBoxColumn3.HeaderText = "Pay Mode";
            gridViewTextBoxColumn3.Name = "pay_mode";
            gridViewTextBoxColumn3.Width = 83;
            gridViewTextBoxColumn4.AllowFiltering = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "shiftID";
            gridViewTextBoxColumn4.HeaderText = "shiftID";
            gridViewTextBoxColumn4.Name = "shiftID";
            gridViewTextBoxColumn4.Width = 97;
            gridViewTextBoxColumn5.AllowFiltering = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "isActive";
            gridViewTextBoxColumn5.HeaderText = "isActive";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "isActive";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgvInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            this.rgvInfo.MasterTemplate.EnableFiltering = true;
            this.rgvInfo.MasterTemplate.EnableGrouping = false;
            this.rgvInfo.MasterTemplate.EnableSorting = false;
            this.rgvInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.ReadOnly = true;
            this.rgvInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvInfo.Size = new System.Drawing.Size(745, 261);
            this.rgvInfo.TabIndex = 0;
            this.rgvInfo.Text = "radGridView1";
            this.rgvInfo.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvInfo_CommandCellClick);
            // 
            // ucBulkBillPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.rgbPayMode);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBulkBillPrinting";
            this.Size = new System.Drawing.Size(755, 431);
            ((System.ComponentModel.ISupportInitialize)(this.rgbPayMode)).EndInit();
            this.rgbPayMode.ResumeLayout(false);
            this.rgbPayMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbByUHID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbByIPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgbPayMode;
        private Telerik.WinControls.UI.RadRadioButton rbByUHID;
        private Telerik.WinControls.UI.RadRadioButton rbByIPD;
        private Telerik.WinControls.UI.RadButton btnGet;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton btnPrintAll;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgvInfo;
        private Telerik.WinControls.RoundRectShape roundRectShape2;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
    }
}
