namespace eMediShop.forms.Product
{
    partial class ucProductNotSold
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_submit = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtPurchDays = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnXL = new Telerik.WinControls.UI.RadButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.btnXL);
            this.GroupBox1.Controls.Add(this.rbtn_submit);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.txtPurchDays);
            this.GroupBox1.Controls.Add(this.label20);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(940, 63);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = " Select Month And Pack";
            // 
            // rbtn_submit
            // 
            this.rbtn_submit.Image = global::eMediShop.Properties.Resources.click16;
            this.rbtn_submit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_submit.Location = new System.Drawing.Point(617, 19);
            this.rbtn_submit.Name = "rbtn_submit";
            this.rbtn_submit.Size = new System.Drawing.Size(44, 37);
            this.rbtn_submit.TabIndex = 177;
            this.rbtn_submit.Click += new System.EventHandler(this.rbtn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 175;
            this.label1.Text = "Exclude Purchase (Last x Days)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.White;
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonth.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.ForeColor = System.Drawing.Color.Blue;
            this.txtMonth.Location = new System.Drawing.Point(216, 26);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonth.MaxLength = 50;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(45, 25);
            this.txtMonth.TabIndex = 1;
            this.txtMonth.Text = "90";
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonth_KeyDown);
            // 
            // txtPurchDays
            // 
            this.txtPurchDays.BackColor = System.Drawing.Color.White;
            this.txtPurchDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPurchDays.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchDays.ForeColor = System.Drawing.Color.Blue;
            this.txtPurchDays.Location = new System.Drawing.Point(546, 26);
            this.txtPurchDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPurchDays.MaxLength = 0;
            this.txtPurchDays.Name = "txtPurchDays";
            this.txtPurchDays.Size = new System.Drawing.Size(45, 25);
            this.txtPurchDays.TabIndex = 173;
            this.txtPurchDays.Text = "10";
            this.txtPurchDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPurchDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPack_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(189, 17);
            this.label20.TabIndex = 7;
            this.label20.Text = "Product Not Sold In last x Days";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.Transparent;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(0, 70);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            this.rgv_info.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "item_id";
            gridViewTextBoxColumn8.HeaderText = "Item Id";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Item Id";
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "item_name";
            gridViewTextBoxColumn9.HeaderText = "Name of Product";
            gridViewTextBoxColumn9.Name = "Name of Product";
            gridViewTextBoxColumn9.Width = 282;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Quantity";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "Stk Qty [P]";
            gridViewDecimalColumn3.Name = "Stk Qty [P]";
            gridViewDecimalColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn3.Width = 64;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "amount";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "Amount";
            gridViewDecimalColumn4.Name = "Amount";
            gridViewDecimalColumn4.Width = 72;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "orgVendorInfo";
            gridViewTextBoxColumn10.HeaderText = "First Vendor";
            gridViewTextBoxColumn10.Name = "orgVendorInfo";
            gridViewTextBoxColumn10.Width = 227;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "vendor_info";
            gridViewTextBoxColumn11.FormatString = "{0:N2}";
            gridViewTextBoxColumn11.HeaderText = "Vendor Info.";
            gridViewTextBoxColumn11.Name = "Vendor Info.";
            gridViewTextBoxColumn11.Width = 284;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "lrd";
            gridViewTextBoxColumn12.HeaderText = "Last Rcpt.";
            gridViewTextBoxColumn12.Name = "lrd";
            gridViewTextBoxColumn12.Width = 76;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "lpd";
            gridViewTextBoxColumn13.HeaderText = "Last Purch.";
            gridViewTextBoxColumn13.Name = "lpd";
            gridViewTextBoxColumn13.Width = 75;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "lsd";
            gridViewTextBoxColumn14.HeaderText = "Last Sold";
            gridViewTextBoxColumn14.Name = "lsd";
            gridViewTextBoxColumn14.Width = 75;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14});
            sortDescriptor3.PropertyName = "Vendor Info.";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor2});
            sortDescriptor4.PropertyName = "Stk Qty [P]";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(940, 440);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            // 
            // btnXL
            // 
            this.btnXL.Enabled = false;
            this.btnXL.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnXL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXL.Location = new System.Drawing.Point(890, 19);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(44, 37);
            this.btnXL.TabIndex = 178;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // ucProductNotSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucProductNotSold";
            this.Size = new System.Drawing.Size(940, 510);
            this.Load += new System.EventHandler(this.ProductNotSold_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox txtMonth;
        internal System.Windows.Forms.TextBox txtPurchDays;
        internal System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton rbtn_submit;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnXL;
    }
}