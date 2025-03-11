namespace eMediShop.warehouse
{
    partial class Bulk_PO_Distribution
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bulk_PO_Distribution));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rddl_order_no = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.rgv_dist_info = new Telerik.WinControls.UI.RadGridView();
            this.btn_submit = new Telerik.WinControls.UI.RadButton();
            this.rgb_info = new Telerik.WinControls.UI.RadGroupBox();
            this.btn_process = new Telerik.WinControls.UI.RadButton();
            this.rgv_detail = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlNames = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_order_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).BeginInit();
            this.rgb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rddl_order_no
            // 
            this.rddl_order_no.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_order_no.Location = new System.Drawing.Point(221, 30);
            this.rddl_order_no.Name = "rddl_order_no";
            this.rddl_order_no.Size = new System.Drawing.Size(205, 25);
            this.rddl_order_no.TabIndex = 0;
            this.rddl_order_no.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order No";
            // 
            // rgv_dist_info
            // 
            this.rgv_dist_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_dist_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_dist_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_dist_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_dist_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_dist_info.Location = new System.Drawing.Point(-3, 61);
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
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "NoS";
            gridViewDecimalColumn1.HeaderText = "NoS";
            gridViewDecimalColumn1.Name = "nos";
            gridViewDecimalColumn1.Width = 43;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_dist_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn1,
            gridViewCommandColumn1});
            this.rgv_dist_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_dist_info.Name = "rgv_dist_info";
            this.rgv_dist_info.ReadOnly = true;
            this.rgv_dist_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_dist_info.ShowGroupPanel = false;
            this.rgv_dist_info.Size = new System.Drawing.Size(483, 484);
            this.rgv_dist_info.TabIndex = 2;
            this.rgv_dist_info.Text = "radGridView1";
            this.rgv_dist_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_dist_info_CommandCellClick);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(441, 19);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(39, 36);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = ">>";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // rgb_info
            // 
            this.rgb_info.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_info.Controls.Add(this.btn_process);
            this.rgb_info.Controls.Add(this.rgv_detail);
            this.rgb_info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_info.HeaderText = "XXXXXXXXXX";
            this.rgb_info.Location = new System.Drawing.Point(487, 3);
            this.rgb_info.Name = "rgb_info";
            this.rgb_info.Size = new System.Drawing.Size(729, 542);
            this.rgb_info.TabIndex = 4;
            this.rgb_info.Text = "XXXXXXXXXX";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(304, 489);
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
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "item_id";
            gridViewTextBoxColumn6.HeaderText = "Item Id";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "item_id";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "item_name";
            gridViewTextBoxColumn7.HeaderText = "Name of Product";
            gridViewTextBoxColumn7.Name = "item_name";
            gridViewTextBoxColumn7.Width = 266;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "master_key_id";
            gridViewTextBoxColumn8.HeaderText = "Master Key ID";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "master_key_id";
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "pack_type";
            gridViewTextBoxColumn9.HeaderText = "Pack Type";
            gridViewTextBoxColumn9.Name = "pack_type";
            gridViewTextBoxColumn9.Width = 92;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "pack_qty";
            gridViewDecimalColumn2.FormatString = "{0:0}";
            gridViewDecimalColumn2.HeaderText = "P. Qty";
            gridViewDecimalColumn2.Name = "pack_qty";
            gridViewDecimalColumn2.Width = 95;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "InStock";
            gridViewDecimalColumn3.FormatString = "{0:0}";
            gridViewDecimalColumn3.HeaderText = "InStock";
            gridViewDecimalColumn3.Name = "InStock";
            gridViewDecimalColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn3.Width = 82;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "order_pack";
            gridViewDecimalColumn4.FormatString = "{0:0}";
            gridViewDecimalColumn4.HeaderText = "Ord Pack";
            gridViewDecimalColumn4.Name = "order_pack";
            gridViewDecimalColumn4.Width = 82;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "olQty";
            gridViewDecimalColumn5.FormatString = "{0:0}";
            gridViewDecimalColumn5.HeaderText = "Qty(L)";
            gridViewDecimalColumn5.Name = "olQty";
            this.rgv_detail.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5});
            sortDescriptor1.PropertyName = "InStock";
            this.rgv_detail.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_detail.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_detail.Name = "rgv_detail";
            this.rgv_detail.ReadOnly = true;
            this.rgv_detail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_detail.ShowGroupPanel = false;
            this.rgv_detail.Size = new System.Drawing.Size(719, 462);
            this.rgv_detail.TabIndex = 3;
            this.rgv_detail.Text = "radGridView1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unit/Sub-Warehouse";
            // 
            // ddlNames
            // 
            this.ddlNames.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlNames.Location = new System.Drawing.Point(7, 30);
            this.ddlNames.Name = "ddlNames";
            this.ddlNames.Size = new System.Drawing.Size(205, 25);
            this.ddlNames.TabIndex = 6;
            this.ddlNames.Text = "Select";
            // 
            // Bulk_PO_Distribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 547);
            this.Controls.Add(this.ddlNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rgb_info);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rgv_dist_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rddl_order_no);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bulk_PO_Distribution";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulk Purchase Order Distribution";
            this.Load += new System.EventHandler(this.Bulk_PO_Distribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rddl_order_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_dist_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).EndInit();
            this.rgb_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList rddl_order_no;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView rgv_dist_info;
        private Telerik.WinControls.UI.RadButton btn_submit;
        private Telerik.WinControls.UI.RadGridView rgv_detail;
        private Telerik.WinControls.UI.RadGroupBox rgb_info;
        private Telerik.WinControls.UI.RadButton btn_process;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList ddlNames;
    }
}
