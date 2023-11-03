namespace eMediShop.Stock
{
    partial class ucStockTransfer
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStockTransfer));
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor4 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rpv_main = new Telerik.WinControls.UI.RadPageView();
            this.rpvp_bypurchid = new Telerik.WinControls.UI.RadPageViewPage();
            this.btnPost = new Telerik.WinControls.UI.RadButton();
            this.rddl_units = new Telerik.WinControls.UI.RadDropDownList();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.rgv_ids = new Telerik.WinControls.UI.RadGridView();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.rpv_main)).BeginInit();
            this.rpv_main.SuspendLayout();
            this.rpvp_bypurchid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_units)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv_main
            // 
            this.rpv_main.Controls.Add(this.rpvp_bypurchid);
            this.rpv_main.Controls.Add(this.radPageViewPage2);
            this.rpv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_main.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpv_main.Location = new System.Drawing.Point(0, 0);
            this.rpv_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rpv_main.Name = "rpv_main";
            this.rpv_main.SelectedPage = this.rpvp_bypurchid;
            this.rpv_main.Size = new System.Drawing.Size(1140, 515);
            this.rpv_main.TabIndex = 0;
            // 
            // rpvp_bypurchid
            // 
            this.rpvp_bypurchid.Controls.Add(this.btnPost);
            this.rpvp_bypurchid.Controls.Add(this.rddl_units);
            this.rpvp_bypurchid.Controls.Add(this.rgv_info);
            this.rpvp_bypurchid.Controls.Add(this.btnGo);
            this.rpvp_bypurchid.Controls.Add(this.radTextBox1);
            this.rpvp_bypurchid.Controls.Add(this.rgv_ids);
            this.rpvp_bypurchid.ItemSize = new System.Drawing.SizeF(176F, 34F);
            this.rpvp_bypurchid.Location = new System.Drawing.Point(10, 43);
            this.rpvp_bypurchid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rpvp_bypurchid.Name = "rpvp_bypurchid";
            this.rpvp_bypurchid.Size = new System.Drawing.Size(1119, 461);
            this.rpvp_bypurchid.Text = "Transfer By Purchase Id";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPost.Location = new System.Drawing.Point(1034, 434);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(82, 26);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click_1);
            // 
            // rddl_units
            // 
            this.rddl_units.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_units.Location = new System.Drawing.Point(5, 5);
            this.rddl_units.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rddl_units.Name = "rddl_units";
            this.rddl_units.Size = new System.Drawing.Size(235, 27);
            this.rddl_units.TabIndex = 5;
            this.rddl_units.Text = "Select Units";
            this.rddl_units.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_units_SelectedIndexChanged);
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(250, 1);
            this.rgv_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "auto_id";
            gridViewTextBoxColumn11.HeaderText = "auto_id";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "auto_id";
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "trf_id";
            gridViewTextBoxColumn12.HeaderText = "trf_id";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "trf_id";
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "trf_to";
            gridViewTextBoxColumn13.HeaderText = "trf_to";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "trf_to";
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "item_id";
            gridViewTextBoxColumn14.HeaderText = "item_id";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "item_id";
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "item_name";
            gridViewTextBoxColumn15.HeaderText = "Name of Product";
            gridViewTextBoxColumn15.Name = "item_name";
            gridViewTextBoxColumn15.Width = 277;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "pack_type";
            gridViewTextBoxColumn16.HeaderText = "P. Type";
            gridViewTextBoxColumn16.Name = "pack_type";
            gridViewTextBoxColumn16.Width = 79;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "pack_qty";
            gridViewDecimalColumn6.FormatString = "{0:N0}";
            gridViewDecimalColumn6.HeaderText = "P. Qty";
            gridViewDecimalColumn6.Name = "pack_qty";
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "master_key_id";
            gridViewDecimalColumn7.HeaderText = "Master Key";
            gridViewDecimalColumn7.Name = "master_key_id";
            gridViewDecimalColumn7.Width = 121;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "batch_no";
            gridViewTextBoxColumn17.HeaderText = "Batch No";
            gridViewTextBoxColumn17.Name = "batch_no";
            gridViewTextBoxColumn17.Width = 84;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "exp_date";
            gridViewTextBoxColumn18.HeaderText = "Expiry";
            gridViewTextBoxColumn18.Name = "exp_date";
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "qty";
            gridViewDecimalColumn8.FormatString = "{0:N0}";
            gridViewDecimalColumn8.HeaderText = "Qty";
            gridViewDecimalColumn8.Name = "qty";
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "upr";
            gridViewDecimalColumn9.FormatString = "{0:N2}";
            gridViewDecimalColumn9.HeaderText = "UPR";
            gridViewDecimalColumn9.Name = "upr";
            gridViewDecimalColumn9.Width = 78;
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FieldName = "total";
            gridViewDecimalColumn10.FormatString = "{0:N2}";
            gridViewDecimalColumn10.HeaderText = "Total";
            gridViewDecimalColumn10.Name = "total";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDecimalColumn10});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(867, 425);
            this.rgv_info.TabIndex = 4;
            this.rgv_info.Text = "radGridView2";
            // 
            // btnGo
            // 
            this.btnGo.Image = global::eMediShop.Properties.Resources.click16;
            this.btnGo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGo.Location = new System.Drawing.Point(208, 433);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(30, 27);
            this.btnGo.TabIndex = 3;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(3, 433);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Type Purchasde Id";
            this.radTextBox1.Size = new System.Drawing.Size(196, 27);
            this.radTextBox1.TabIndex = 2;
            // 
            // rgv_ids
            // 
            this.rgv_ids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgv_ids.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_ids.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_ids.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_ids.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_ids.Location = new System.Drawing.Point(3, 42);
            this.rgv_ids.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.rgv_ids.MasterTemplate.AllowAddNewRow = false;
            this.rgv_ids.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "unit_name";
            gridViewTextBoxColumn19.HeaderText = "Name of Unit";
            gridViewTextBoxColumn19.Name = "unit_name";
            gridViewTextBoxColumn19.Width = 125;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "purch_id";
            gridViewTextBoxColumn20.HeaderText = "Purchase Id";
            gridViewTextBoxColumn20.Name = "purch_id";
            gridViewTextBoxColumn20.Width = 157;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column3";
            gridViewCommandColumn2.Width = 25;
            this.rgv_ids.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewCommandColumn2});
            sortDescriptor3.PropertyName = "unit_name";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_ids.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor2});
            sortDescriptor4.PropertyName = "column1";
            this.rgv_ids.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor4});
            this.rgv_ids.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgv_ids.Name = "rgv_ids";
            this.rgv_ids.ReadOnly = true;
            this.rgv_ids.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_ids.ShowGroupPanel = false;
            this.rgv_ids.Size = new System.Drawing.Size(243, 384);
            this.rgv_ids.TabIndex = 1;
            this.rgv_ids.Text = "radGridView1";
            this.rgv_ids.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_ids_CommandCellClick);
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(148F, 34F);
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 43);
            this.radPageViewPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(1119, 461);
            this.radPageViewPage2.Text = "radPageViewPage2";
            // 
            // ucStockTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpv_main);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucStockTransfer";
            this.Size = new System.Drawing.Size(1140, 515);
            this.Load += new System.EventHandler(this.ucStockTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpv_main)).EndInit();
            this.rpv_main.ResumeLayout(false);
            this.rpvp_bypurchid.ResumeLayout(false);
            this.rpvp_bypurchid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_units)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ids)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView rpv_main;
        private Telerik.WinControls.UI.RadPageViewPage rpvp_bypurchid;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadButton btnGo;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadGridView rgv_ids;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadDropDownList rddl_units;
        private Telerik.WinControls.UI.RadButton btnPost;
    }
}
