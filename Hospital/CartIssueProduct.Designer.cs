namespace eMediShop.Hospital
{
    partial class CartIssueProduct
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartIssueProduct));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_cartItems = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_IssueInfo = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rddl_cartName = new Telerik.WinControls.UI.RadDropDownList();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.rtb_issueqty = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIssueType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cartItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cartItems.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_IssueInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_IssueInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_cartName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_issueqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_cartItems);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Select Product";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 70);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(386, 464);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Select Product";
            // 
            // rgv_cartItems
            // 
            this.rgv_cartItems.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_cartItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_cartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_cartItems.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_cartItems.ForeColor = System.Drawing.Color.Black;
            this.rgv_cartItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_cartItems.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_cartItems.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 259;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "qty";
            gridViewDecimalColumn1.HeaderText = "Qty";
            gridViewDecimalColumn1.Name = "stock";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_cartItems.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewCommandColumn1});
            this.rgv_cartItems.MasterTemplate.EnableFiltering = true;
            this.rgv_cartItems.MasterTemplate.EnableGrouping = false;
            this.rgv_cartItems.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_cartItems.Name = "rgv_cartItems";
            this.rgv_cartItems.ReadOnly = true;
            this.rgv_cartItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_cartItems.Size = new System.Drawing.Size(382, 444);
            this.rgv_cartItems.TabIndex = 0;
            this.rgv_cartItems.Text = "radGridView1";
            this.rgv_cartItems.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_cartItems_CommandCellClick);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.rgv_IssueInfo);
            this.radGroupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox3.HeaderText = "XXXXXXXXXX";
            this.radGroupBox3.Location = new System.Drawing.Point(394, 148);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(555, 383);
            this.radGroupBox3.TabIndex = 4;
            this.radGroupBox3.Text = "XXXXXXXXXX";
            // 
            // rgv_IssueInfo
            // 
            this.rgv_IssueInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_IssueInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_IssueInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_IssueInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_IssueInfo.ForeColor = System.Drawing.Color.Black;
            this.rgv_IssueInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_IssueInfo.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_IssueInfo.MasterTemplate.AllowAddNewRow = false;
            this.rgv_IssueInfo.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_id";
            gridViewTextBoxColumn3.HeaderText = "Item Id";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "item_id";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "issue_type";
            gridViewTextBoxColumn4.HeaderText = "Issue Type";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "issue_type";
            gridViewTextBoxColumn4.Width = 157;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "item_name";
            gridViewTextBoxColumn5.HeaderText = "Name of Product";
            gridViewTextBoxColumn5.Name = "item_name";
            gridViewTextBoxColumn5.Width = 311;
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "qty";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.Name = "stock";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "issue_by";
            gridViewTextBoxColumn6.HeaderText = "Issue By";
            gridViewTextBoxColumn6.Name = "issue_by";
            gridViewTextBoxColumn6.Width = 100;
            this.rgv_IssueInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn6});
            sortDescriptor1.PropertyName = "issue_type";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_IssueInfo.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.rgv_IssueInfo.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_IssueInfo.Name = "rgv_IssueInfo";
            this.rgv_IssueInfo.ReadOnly = true;
            this.rgv_IssueInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_IssueInfo.Size = new System.Drawing.Size(551, 363);
            this.rgv_IssueInfo.TabIndex = 2;
            this.rgv_IssueInfo.Text = "radGridView2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Cart";
            // 
            // rddl_cartName
            // 
            this.rddl_cartName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_cartName.Location = new System.Drawing.Point(7, 28);
            this.rddl_cartName.Name = "rddl_cartName";
            this.rddl_cartName.Size = new System.Drawing.Size(294, 25);
            this.rddl_cartName.TabIndex = 6;
            this.rddl_cartName.Text = "Select";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::eMediShop.Properties.Resources.click16;
            this.btnSubmit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Location = new System.Drawing.Point(320, 25);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(39, 32);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.txtRemarks);
            this.radGroupBox2.Controls.Add(this.label4);
            this.radGroupBox2.Controls.Add(this.cmbIssueType);
            this.radGroupBox2.Controls.Add(this.label3);
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.label2);
            this.radGroupBox2.Controls.Add(this.rtb_issueqty);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox2.HeaderText = "XXXXXXXXXX";
            this.radGroupBox2.Location = new System.Drawing.Point(392, 3);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(555, 139);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "XXXXXXXXXX";
            // 
            // rtb_issueqty
            // 
            this.rtb_issueqty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_issueqty.Location = new System.Drawing.Point(469, 23);
            this.rtb_issueqty.Name = "rtb_issueqty";
            // 
            // 
            // 
            this.rtb_issueqty.RootElement.Shape = this.roundRectShape1;
            this.rtb_issueqty.Size = new System.Drawing.Size(81, 27);
            this.rtb_issueqty.TabIndex = 0;
            this.rtb_issueqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rtb_issueqty.Enter += new System.EventHandler(this.rtb_issueqty_Enter);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_issueqty.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_issueqty.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Issue Qty";
            // 
            // radButton1
            // 
            this.radButton1.Image = global::eMediShop.Properties.Resources.click16;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(511, 107);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(39, 27);
            this.radButton1.TabIndex = 8;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.click16;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Issue Type";
            // 
            // cmbIssueType
            // 
            this.cmbIssueType.FormattingEnabled = true;
            this.cmbIssueType.Items.AddRange(new object[] {
            "Consumables",
            "To Patient"});
            this.cmbIssueType.Location = new System.Drawing.Point(88, 32);
            this.cmbIssueType.Name = "cmbIssueType";
            this.cmbIssueType.Size = new System.Drawing.Size(121, 25);
            this.cmbIssueType.TabIndex = 10;
            this.cmbIssueType.Text = "Consumables";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(88, 63);
            this.txtRemarks.Name = "txtRemarks";
            // 
            // 
            // 
            this.txtRemarks.RootElement.Shape = this.roundRectShape1;
            this.txtRemarks.Size = new System.Drawing.Size(462, 27);
            this.txtRemarks.TabIndex = 12;
            this.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtRemarks.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtRemarks.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // CartIssueProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rddl_cartName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CartIssueProduct";
            this.Size = new System.Drawing.Size(949, 534);
            this.Load += new System.EventHandler(this.CartIssueProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cartItems.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cartItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_IssueInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_IssueInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_cartName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_issueqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgv_cartItems;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadGridView rgv_IssueInfo;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList rddl_cartName;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox rtb_issueqty;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIssueType;
        private System.Windows.Forms.Label label3;
    }
}
