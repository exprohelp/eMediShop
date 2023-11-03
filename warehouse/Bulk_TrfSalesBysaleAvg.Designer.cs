namespace eMediShop.warehouse
{
    partial class Bulk_TrfSalesBysaleAvg
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bulk_TrfSalesBysaleAvg));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_dist_info = new Telerik.WinControls.UI.RadGridView();
            this.rgb_info = new Telerik.WinControls.UI.RadGroupBox();
            this.btn_process = new Telerik.WinControls.UI.RadButton();
            this.rgv_detail = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).BeginInit();
            this.rgb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_dist_info
            // 
            this.rgv_dist_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_dist_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_dist_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_dist_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_dist_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_dist_info.Location = new System.Drawing.Point(-3, 12);
            // 
            // 
            // 
            this.rgv_dist_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unit_id";
            gridViewTextBoxColumn1.HeaderText = "unit_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "unit_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "unit_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Unit";
            gridViewTextBoxColumn2.Name = "unit_name";
            gridViewTextBoxColumn2.Width = 288;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "tran_type";
            gridViewTextBoxColumn3.HeaderText = "Tran Type";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "tran_type";
            gridViewTextBoxColumn3.Width = 93;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ac_code";
            gridViewTextBoxColumn4.HeaderText = "ac_code";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ac_code";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "vendor_id";
            gridViewTextBoxColumn5.HeaderText = "vendor_id";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "vendor_id";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "comp_id";
            gridViewTextBoxColumn6.HeaderText = "comp_id";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "comp_id";
            this.rgv_dist_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1,
            gridViewTextBoxColumn6});
            this.rgv_dist_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_dist_info.Name = "rgv_dist_info";
            this.rgv_dist_info.ReadOnly = true;
            this.rgv_dist_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_dist_info.ShowGroupPanel = false;
            this.rgv_dist_info.Size = new System.Drawing.Size(334, 533);
            this.rgv_dist_info.TabIndex = 2;
            this.rgv_dist_info.Text = "radGridView1";
            this.rgv_dist_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_dist_info_CommandCellClick);
            // 
            // rgb_info
            // 
            this.rgb_info.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_info.Controls.Add(this.btn_process);
            this.rgb_info.Controls.Add(this.rgv_detail);
            this.rgb_info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_info.HeaderText = "XXXXXXXXXX";
            this.rgb_info.Location = new System.Drawing.Point(337, 3);
            this.rgb_info.Name = "rgb_info";
            this.rgb_info.Size = new System.Drawing.Size(785, 542);
            this.rgb_info.TabIndex = 4;
            this.rgb_info.Text = "XXXXXXXXXX";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(668, 21);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(95, 43);
            this.btn_process.TabIndex = 4;
            this.btn_process.Text = "Click To process";
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // rgv_detail
            // 
            this.rgv_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_detail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_detail.ForeColor = System.Drawing.Color.Black;
            this.rgv_detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_detail.Location = new System.Drawing.Point(5, 21);
            // 
            // 
            // 
            this.rgv_detail.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "item_id";
            gridViewTextBoxColumn7.HeaderText = "Item Id";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "item_id";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "item_name";
            gridViewTextBoxColumn8.HeaderText = "Name of Product";
            gridViewTextBoxColumn8.Name = "item_name";
            gridViewTextBoxColumn8.Width = 266;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "pack_type";
            gridViewTextBoxColumn9.HeaderText = "Pack Type";
            gridViewTextBoxColumn9.Name = "pack_type";
            gridViewTextBoxColumn9.Width = 92;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "pack_qty";
            gridViewDecimalColumn1.FormatString = "{0:0}";
            gridViewDecimalColumn1.HeaderText = "P. Qty";
            gridViewDecimalColumn1.Name = "pack_qty";
            gridViewDecimalColumn1.Width = 95;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "InStock";
            gridViewDecimalColumn2.FormatString = "{0:0}";
            gridViewDecimalColumn2.HeaderText = "InStock";
            gridViewDecimalColumn2.Name = "InStock";
            gridViewDecimalColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn2.Width = 82;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "order_pack";
            gridViewDecimalColumn3.FormatString = "{0:0}";
            gridViewDecimalColumn3.HeaderText = "Ord Pack";
            gridViewDecimalColumn3.Name = "order_pack";
            gridViewDecimalColumn3.Width = 82;
            this.rgv_detail.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3});
            sortDescriptor1.PropertyName = "InStock";
            this.rgv_detail.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_detail.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_detail.Name = "rgv_detail";
            this.rgv_detail.ReadOnly = true;
            this.rgv_detail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_detail.ShowGroupPanel = false;
            this.rgv_detail.Size = new System.Drawing.Size(650, 516);
            this.rgv_detail.TabIndex = 3;
            this.rgv_detail.Text = "radGridView1";
            // 
            // Bulk_TrfSalesBysaleAvg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 547);
            this.Controls.Add(this.rgb_info);
            this.Controls.Add(this.rgv_dist_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bulk_TrfSalesBysaleAvg";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk Transfer/Sales On Average Basis";
            this.Load += new System.EventHandler(this.Bulk_TrfSalesBysaleAvg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).EndInit();
            this.rgb_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView rgv_dist_info;
        private Telerik.WinControls.UI.RadGridView rgv_detail;
        private Telerik.WinControls.UI.RadGroupBox rgb_info;
        private Telerik.WinControls.UI.RadButton btn_process;
    }
}
