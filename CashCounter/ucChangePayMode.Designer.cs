namespace eMediShop.CashCounter
{
    partial class ucChangePayMode
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChangePayMode));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtSaleInvNo = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.roundRectShape2 = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnGet = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            this.rgbPayMode = new Telerik.WinControls.UI.RadGroupBox();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.rbCash = new Telerik.WinControls.UI.RadRadioButton();
            this.rbSwipeCard = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleInvNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbPayMode)).BeginInit();
            this.rgbPayMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSwipeCard)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaleInvNo
            // 
            this.txtSaleInvNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaleInvNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleInvNo.Location = new System.Drawing.Point(7, 50);
            this.txtSaleInvNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaleInvNo.MaxLength = 20;
            this.txtSaleInvNo.Name = "txtSaleInvNo";
            this.txtSaleInvNo.Size = new System.Drawing.Size(192, 25);
            this.txtSaleInvNo.TabIndex = 0;
            this.txtSaleInvNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSaleInvNo.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSaleInvNo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale Inv No";
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(207, 50);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(38, 24);
            this.btnGet.TabIndex = 10;
            this.btnGet.Text = ">>";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnGet.GetChildAt(0))).Text = ">>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnGet.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgvInfo);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 84);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(731, 124);
            this.radGroupBox1.TabIndex = 11;
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
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "sale_inv_no";
            gridViewTextBoxColumn6.HeaderText = "sale_inv_no";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "sale_inv_no";
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "sale_date";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "Date";
            gridViewDateTimeColumn2.Name = "sale_date";
            gridViewDateTimeColumn2.Width = 80;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "pt_name";
            gridViewTextBoxColumn7.HeaderText = "Name of Customer";
            gridViewTextBoxColumn7.Name = "pt_name";
            gridViewTextBoxColumn7.Width = 192;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "total";
            gridViewDecimalColumn5.HeaderText = "Total";
            gridViewDecimalColumn5.Name = "total";
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "discount";
            gridViewDecimalColumn6.HeaderText = "Discount";
            gridViewDecimalColumn6.Name = "discount";
            gridViewDecimalColumn6.Width = 58;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "net";
            gridViewDecimalColumn7.HeaderText = "Net";
            gridViewDecimalColumn7.Name = "net";
            gridViewDecimalColumn7.Width = 68;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "received";
            gridViewDecimalColumn8.HeaderText = "Received";
            gridViewDecimalColumn8.Name = "received";
            gridViewDecimalColumn8.Width = 61;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "pay_mode";
            gridViewTextBoxColumn8.HeaderText = "Pay Mode";
            gridViewTextBoxColumn8.Name = "pay_mode";
            gridViewTextBoxColumn8.Width = 83;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "shiftID";
            gridViewTextBoxColumn9.HeaderText = "shiftID";
            gridViewTextBoxColumn9.Name = "shiftID";
            gridViewTextBoxColumn9.Width = 97;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "isActive";
            gridViewTextBoxColumn10.HeaderText = "isActive";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "isActive";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column1";
            gridViewCommandColumn2.Width = 25;
            this.rgvInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewCommandColumn2});
            this.rgvInfo.MasterTemplate.EnableGrouping = false;
            this.rgvInfo.MasterTemplate.EnableSorting = false;
            this.rgvInfo.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.ReadOnly = true;
            this.rgvInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvInfo.Size = new System.Drawing.Size(727, 104);
            this.rgvInfo.TabIndex = 0;
            this.rgvInfo.Text = "radGridView1";
            this.rgvInfo.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvInfo_CommandCellClick);
            // 
            // rgbPayMode
            // 
            this.rgbPayMode.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbPayMode.Controls.Add(this.btnUpdate);
            this.rgbPayMode.Controls.Add(this.rbCash);
            this.rgbPayMode.Controls.Add(this.rbSwipeCard);
            this.rgbPayMode.Enabled = false;
            this.rgbPayMode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbPayMode.HeaderText = "Pay Mode";
            this.rgbPayMode.Location = new System.Drawing.Point(4, 214);
            this.rgbPayMode.Name = "rgbPayMode";
            this.rgbPayMode.Size = new System.Drawing.Size(484, 70);
            this.rgbPayMode.TabIndex = 12;
            this.rgbPayMode.Text = "Pay Mode";
            this.rgbPayMode.Click += new System.EventHandler(this.rgbPayMode_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(393, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 24);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUpdate.GetChildAt(0))).Text = "Update";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUpdate.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rbCash
            // 
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(111, 31);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(54, 24);
            this.rbCash.TabIndex = 1;
            this.rbCash.Text = "Cash";
            // 
            // rbSwipeCard
            // 
            this.rbSwipeCard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSwipeCard.Location = new System.Drawing.Point(7, 31);
            this.rbSwipeCard.Name = "rbSwipeCard";
            this.rbSwipeCard.Size = new System.Drawing.Size(98, 24);
            this.rbSwipeCard.TabIndex = 0;
            this.rbSwipeCard.Text = "Swipe Card";
            // 
            // ucChangePayMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgbPayMode);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaleInvNo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucChangePayMode";
            this.Size = new System.Drawing.Size(737, 447);
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleInvNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbPayMode)).EndInit();
            this.rgbPayMode.ResumeLayout(false);
            this.rgbPayMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSwipeCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtSaleInvNo;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.RoundRectShape roundRectShape2;
        private Telerik.WinControls.UI.RadButton btnGet;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgvInfo;
        private Telerik.WinControls.UI.RadGroupBox rgbPayMode;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadRadioButton rbCash;
        private Telerik.WinControls.UI.RadRadioButton rbSwipeCard;
    }
}
