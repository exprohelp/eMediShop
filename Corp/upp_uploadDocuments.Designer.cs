namespace eMediShop.Corp
{
    partial class upp_uploadDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(upp_uploadDocuments));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            this.rbtnGetInfo = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.lblFileSize = new System.Windows.Forms.Label();
            this.btnScanner = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rgbInfo = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvDocInfo = new Telerik.WinControls.UI.RadGridView();
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.btnMobileCheck = new Telerik.WinControls.UI.RadButton();
            this.txtMobileNo = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radGridView1 = new Telerik.WinControls.UI.MasterGridViewTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnGetInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbInfo)).BeginInit();
            this.rgbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDocInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDocInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMobileCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvInfo
            // 
            this.rgvInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rgvInfo.ForeColor = System.Drawing.Color.Black;
            this.rgvInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvInfo.Location = new System.Drawing.Point(-1, 32);
            // 
            // 
            // 
            this.rgvInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "sale_inv_no";
            gridViewTextBoxColumn1.HeaderText = "Sales Inv No";
            gridViewTextBoxColumn1.Name = "Sales_Inv_No";
            gridViewTextBoxColumn1.Width = 159;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Act";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "Act";
            gridViewCommandColumn1.Width = 31;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Nos";
            gridViewDecimalColumn1.HeaderText = "NoS";
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "NoS";
            this.rgvInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1,
            gridViewDecimalColumn1});
            this.rgvInfo.MasterTemplate.EnableGrouping = false;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.ReadOnly = true;
            this.rgvInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvInfo.Size = new System.Drawing.Size(240, 468);
            this.rgvInfo.TabIndex = 0;
            this.rgvInfo.Text = "radGridView1";
            this.rgvInfo.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvInfo_CommandCellClick);
            // 
            // rbtnGetInfo
            // 
            this.rbtnGetInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGetInfo.Location = new System.Drawing.Point(170, 2);
            this.rbtnGetInfo.Name = "rbtnGetInfo";
            this.rbtnGetInfo.Size = new System.Drawing.Size(69, 28);
            this.rbtnGetInfo.TabIndex = 1;
            this.rbtnGetInfo.Text = "Get Info";
            this.rbtnGetInfo.Click += new System.EventHandler(this.rbtnGetInfo_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtnGetInfo.GetChildAt(0))).Text = "Get Info";
            ((Telerik.WinControls.UI.RadButtonElement)(this.rbtnGetInfo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.Location = new System.Drawing.Point(254, 461);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(65, 20);
            this.lblFileSize.TabIndex = 30;
            this.lblFileSize.Text = "File Size : ";
            // 
            // btnScanner
            // 
            this.btnScanner.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanner.Image = global::eMediShop.Properties.Resources.scanner_32;
            this.btnScanner.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScanner.Location = new System.Drawing.Point(186, 97);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(45, 45);
            this.btnScanner.TabIndex = 31;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnScanner.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.scanner_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnScanner.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnScanner.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnScanner.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "HealthCard",
            "ID",
            "MAF",
            "Prescription",
            "Receipt"});
            this.comboType.Location = new System.Drawing.Point(6, 111);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(140, 25);
            this.comboType.TabIndex = 32;
            this.comboType.Text = "HealthCard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Document Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::eMediShop.Properties.Resources.upload_Doc_161;
            this.btnSubmit.Location = new System.Drawing.Point(676, 462);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(61, 24);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Upload";
            this.btnSubmit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.radDateTimePicker1.Location = new System.Drawing.Point(47, 3);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(98, 25);
            this.radDateTimePicker1.TabIndex = 35;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "07/02/2015";
            this.radDateTimePicker1.Value = new System.DateTime(2015, 2, 7, 14, 25, 38, 16);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Date";
            // 
            // rgbInfo
            // 
            this.rgbInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbInfo.Controls.Add(this.rgvDocInfo);
            this.rgbInfo.Controls.Add(this.pbBox);
            this.rgbInfo.Controls.Add(this.btnMobileCheck);
            this.rgbInfo.Controls.Add(this.txtMobileNo);
            this.rgbInfo.Controls.Add(this.label3);
            this.rgbInfo.Controls.Add(this.btnSubmit);
            this.rgbInfo.Controls.Add(this.lblFileSize);
            this.rgbInfo.Controls.Add(this.btnScanner);
            this.rgbInfo.Controls.Add(this.label1);
            this.rgbInfo.Controls.Add(this.comboType);
            this.rgbInfo.Enabled = false;
            this.rgbInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbInfo.HeaderText = "XXXXXXXXXX";
            this.rgbInfo.Location = new System.Drawing.Point(243, 3);
            this.rgbInfo.Name = "rgbInfo";
            this.rgbInfo.Size = new System.Drawing.Size(747, 497);
            this.rgbInfo.TabIndex = 37;
            this.rgbInfo.Text = "XXXXXXXXXX";
            // 
            // rgvDocInfo
            // 
            this.rgvDocInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvDocInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvDocInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvDocInfo.ForeColor = System.Drawing.Color.Black;
            this.rgvDocInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvDocInfo.Location = new System.Drawing.Point(3, 164);
            // 
            // 
            // 
            this.rgvDocInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Doc_Type";
            gridViewTextBoxColumn2.HeaderText = "Type";
            gridViewTextBoxColumn2.Name = "Type";
            gridViewTextBoxColumn2.Width = 161;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Doc_Path";
            gridViewTextBoxColumn3.HeaderText = "Path";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Path";
            gridViewTextBoxColumn3.Width = 25;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Act";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "Act";
            gridViewCommandColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewCommandColumn2.Width = 30;
            this.rgvDocInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn2});
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Act";
            this.rgvDocInfo.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgvDocInfo.Name = "rgvDocInfo";
            this.rgvDocInfo.ReadOnly = true;
            this.rgvDocInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvDocInfo.ShowGroupPanel = false;
            this.rgvDocInfo.Size = new System.Drawing.Size(240, 322);
            this.rgvDocInfo.TabIndex = 40;
            this.rgvDocInfo.Text = "radGridView2";
            this.rgvDocInfo.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvDocInfo_CommandCellClick);
            // 
            // pbBox
            // 
            this.pbBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBox.Location = new System.Drawing.Point(250, 21);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(487, 434);
            this.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBox.TabIndex = 39;
            this.pbBox.TabStop = false;
            // 
            // btnMobileCheck
            // 
            this.btnMobileCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobileCheck.Image = global::eMediShop.Properties.Resources.card_16;
            this.btnMobileCheck.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMobileCheck.Location = new System.Drawing.Point(126, 52);
            this.btnMobileCheck.Name = "btnMobileCheck";
            this.btnMobileCheck.Size = new System.Drawing.Size(20, 22);
            this.btnMobileCheck.TabIndex = 38;
            this.btnMobileCheck.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMobileCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMobileCheck.Click += new System.EventHandler(this.btnMobileCheck_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnMobileCheck.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.card_16;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnMobileCheck.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnMobileCheck.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnMobileCheck.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnMobileCheck.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnMobileCheck.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(6, 50);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(111, 25);
            this.txtMobileNo.TabIndex = 37;
            this.txtMobileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mobile No (e.g. 9839690999)";
            // 
            // radGridView1
            // 
            this.radGridView1.AllowAddNewRow = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "doc_type";
            gridViewTextBoxColumn4.HeaderText = "Type";
            gridViewTextBoxColumn4.Name = "Type";
            gridViewTextBoxColumn4.Width = 115;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "doc_path";
            gridViewTextBoxColumn5.HeaderText = "Path";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Path";
            gridViewTextBoxColumn5.Width = 103;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.HeaderText = "Document";
            gridViewImageColumn1.Name = "Document";
            gridViewImageColumn1.Width = 194;
            this.radGridView1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewImageColumn1});
            sortDescriptor2.PropertyName = "Type";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.radGridView1.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            // 
            // upp_uploadDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 500);
            this.Controls.Add(this.rgbInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.rbtnGetInfo);
            this.Controls.Add(this.rgvInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "upp_uploadDocuments";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "UPP: Pending Invoice Against Sales Invoice No";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.upp_uploadDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnGetInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbInfo)).EndInit();
            this.rgbInfo.ResumeLayout(false);
            this.rgbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDocInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDocInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMobileCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvInfo;
        private Telerik.WinControls.UI.RadButton rbtnGetInfo;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private System.Windows.Forms.Label lblFileSize;
        private Telerik.WinControls.UI.RadButton btnScanner;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGroupBox rgbInfo;
        private Telerik.WinControls.UI.RadTextBox txtMobileNo;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btnMobileCheck;
        private System.Windows.Forms.PictureBox pbBox;
        private Telerik.WinControls.UI.MasterGridViewTemplate radGridView1;
        private Telerik.WinControls.UI.RadGridView rgvDocInfo;
    }
}
