namespace eMediShop.Promo
{
    partial class PromoProducts
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rg_Group = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.rdd_Products = new Telerik.WinControls.UI.RadDropDownList();
            this.rb_Search = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rg_expiryList = new Telerik.WinControls.UI.RadGridView();
            this.rdd_Category = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtMonths = new Telerik.WinControls.UI.RadTextBox();
            this.rc_All = new Telerik.WinControls.UI.RadCheckBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rg_Group)).BeginInit();
            this.rg_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdd_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_expiryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_expiryList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdd_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rc_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rg_Group
            // 
            this.rg_Group.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rg_Group.Controls.Add(this.radLabel4);
            this.rg_Group.Controls.Add(this.rdd_Products);
            this.rg_Group.Controls.Add(this.rb_Search);
            this.rg_Group.Controls.Add(this.txtSearch);
            this.rg_Group.Controls.Add(this.radLabel3);
            this.rg_Group.Enabled = false;
            this.rg_Group.HeaderText = "";
            this.rg_Group.Location = new System.Drawing.Point(384, 6);
            this.rg_Group.Name = "rg_Group";
            this.rg_Group.Size = new System.Drawing.Size(463, 56);
            this.rg_Group.TabIndex = 0;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(154, 5);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(83, 18);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Product Name";
            // 
            // rdd_Products
            // 
            this.rdd_Products.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdd_Products.Location = new System.Drawing.Point(154, 24);
            this.rdd_Products.Name = "rdd_Products";
            this.rdd_Products.Size = new System.Drawing.Size(304, 23);
            this.rdd_Products.TabIndex = 6;
            this.rdd_Products.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rdd_Products_SelectedIndexChanged);
            // 
            // rb_Search
            // 
            this.rb_Search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rb_Search.Location = new System.Drawing.Point(108, 20);
            this.rb_Search.Name = "rb_Search";
            this.rb_Search.Size = new System.Drawing.Size(30, 30);
            this.rb_Search.TabIndex = 5;
            this.rb_Search.Text = ">>";
            this.rb_Search.Click += new System.EventHandler(this.rb_Search_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_Search.GetChildAt(0))).Text = ">>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.rb_Search.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(8, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(94, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(5, 6);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(42, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Search";
            // 
            // rg_expiryList
            // 
            this.rg_expiryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rg_expiryList.Cursor = System.Windows.Forms.Cursors.Default;
            this.rg_expiryList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rg_expiryList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rg_expiryList.ForeColor = System.Drawing.Color.Black;
            this.rg_expiryList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rg_expiryList.Location = new System.Drawing.Point(0, 87);
            // 
            // 
            // 
            this.rg_expiryList.MasterTemplate.AllowAddNewRow = false;
            this.rg_expiryList.MasterTemplate.AllowDeleteRow = false;
            this.rg_expiryList.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "item_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Products";
            gridViewTextBoxColumn2.MinWidth = 300;
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn2.Width = 300;
            gridViewTextBoxColumn3.AllowFiltering = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Master_key_id";
            gridViewTextBoxColumn3.HeaderText = "Master Key";
            gridViewTextBoxColumn3.MinWidth = 130;
            gridViewTextBoxColumn3.Name = "Master Key";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 130;
            gridViewTextBoxColumn4.AllowFiltering = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Batch_No";
            gridViewTextBoxColumn4.HeaderText = "Batch No.";
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "Batch_No";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 100;
            gridViewDateTimeColumn1.AllowFiltering = false;
            gridViewDateTimeColumn1.CustomFormat = "dd-MM-yyyy";
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Exp Dt.";
            gridViewDateTimeColumn1.Name = "Exp Date";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewTextBoxColumn5.AllowFiltering = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Pack_Type";
            gridViewTextBoxColumn5.HeaderText = "Pack Type";
            gridViewTextBoxColumn5.MinWidth = 70;
            gridViewTextBoxColumn5.Name = "Pack Type";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 70;
            gridViewTextBoxColumn6.AllowFiltering = false;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Pack_Qty";
            gridViewTextBoxColumn6.HeaderText = "Pack Qty";
            gridViewTextBoxColumn6.Name = "Pack Qty";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "npr";
            gridViewDecimalColumn1.HeaderText = "NPR";
            gridViewDecimalColumn1.Name = "NPR";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn7.AllowFiltering = false;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Quantity";
            gridViewTextBoxColumn7.HeaderText = "Qty";
            gridViewTextBoxColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Name = "Qty";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "disc_per";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Dis%age";
            gridViewDecimalColumn2.Name = "Dis%age";
            gridViewDecimalColumn2.Width = 64;
            this.rg_expiryList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn2});
            this.rg_expiryList.MasterTemplate.EnableAlternatingRowColor = true;
            this.rg_expiryList.MasterTemplate.EnableFiltering = true;
            this.rg_expiryList.MasterTemplate.EnableGrouping = false;
            this.rg_expiryList.MasterTemplate.ShowGroupedColumns = true;
            sortDescriptor1.PropertyName = "item_name";
            this.rg_expiryList.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rg_expiryList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rg_expiryList.Name = "rg_expiryList";
            this.rg_expiryList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rg_expiryList.ShowGroupPanel = false;
            this.rg_expiryList.Size = new System.Drawing.Size(912, 367);
            this.rg_expiryList.TabIndex = 1;
            this.rg_expiryList.Text = "radGridView1";
            this.rg_expiryList.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.rg_expiryList_CellBeginEdit);
            this.rg_expiryList.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rg_expiryList_CellEndEdit);
            // 
            // rdd_Category
            // 
            this.rdd_Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdd_Category.Location = new System.Drawing.Point(15, 30);
            this.rdd_Category.Name = "rdd_Category";
            this.rdd_Category.Size = new System.Drawing.Size(202, 23);
            this.rdd_Category.TabIndex = 0;
            this.rdd_Category.Text = "Select Category";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(12, 6);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Category";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(231, 13);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Expired In ";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(238, 33);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(49, 20);
            this.txtMonths.TabIndex = 3;
            this.txtMonths.Text = "2";
            this.txtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rc_All
            // 
            this.rc_All.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rc_All.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rc_All.Location = new System.Drawing.Point(342, 33);
            this.rc_All.Name = "rc_All";
            this.rc_All.Size = new System.Drawing.Size(36, 21);
            this.rc_All.TabIndex = 4;
            this.rc_All.Text = "All";
            this.rc_All.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rc_All.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rc_All_ToggleStateChanged);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radButton1.Location = new System.Drawing.Point(862, 24);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(30, 30);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Go";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = "Go";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel5.Location = new System.Drawing.Point(239, 54);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(47, 18);
            this.radLabel5.TabIndex = 5;
            this.radLabel5.Text = "Months";
            // 
            // PromoProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 454);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.rc_All);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.rg_expiryList);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rg_Group);
            this.Controls.Add(this.rdd_Category);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "PromoProducts";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Promotional Products Information";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.PromoProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rg_Group)).EndInit();
            this.rg_Group.ResumeLayout(false);
            this.rg_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdd_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_expiryList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rg_expiryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdd_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rc_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rg_Group;
        private Telerik.WinControls.UI.RadGridView rg_expiryList;
        private Telerik.WinControls.UI.RadTextBox txtMonths;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList rdd_Category;
        private Telerik.WinControls.UI.RadCheckBox rc_All;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList rdd_Products;
        private Telerik.WinControls.UI.RadButton rb_Search;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
    }
}
