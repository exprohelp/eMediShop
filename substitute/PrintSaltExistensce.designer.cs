namespace eMediShop.Substitute
{
    partial class PrintSaltExistensce
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor1 = new Telerik.WinControls.Data.FilterDescriptor();
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor2 = new Telerik.WinControls.Data.FilterDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor3 = new Telerik.WinControls.Data.FilterDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridOrderDetail = new Telerik.WinControls.UI.MasterGridViewTemplate();
            this.MasterTemplate = new Telerik.WinControls.UI.RadGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gridUnitList = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnitList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnitList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrderDetail
            // 
            this.gridOrderDetail.AllowAddNewRow = false;
            this.gridOrderDetail.AllowColumnReorder = false;
            this.gridOrderDetail.AllowDeleteRow = false;
            this.gridOrderDetail.AllowEditRow = false;
            this.gridOrderDetail.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "item_name";
            gridViewTextBoxColumn1.HeaderText = "Product Name";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "item_name";
            gridViewTextBoxColumn1.Width = 200;
            gridViewTextBoxColumn2.FieldName = "pack_type";
            gridViewTextBoxColumn2.HeaderText = "Pack Type";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "pack_type";
            gridViewTextBoxColumn2.Width = 80;
            gridViewTextBoxColumn3.FieldName = "order_pack";
            gridViewTextBoxColumn3.HeaderText = "Ord.Pack";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Name = "order_pack";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 80;
            gridViewTextBoxColumn4.FieldName = "vendor_name";
            gridViewTextBoxColumn4.HeaderText = "Vendor Info";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "vendor_name";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "Company";
            gridViewTextBoxColumn5.HeaderText = "Company";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "Company";
            gridViewTextBoxColumn5.Width = 150;
            this.gridOrderDetail.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gridOrderDetail.EnableGrouping = false;
            this.gridOrderDetail.ViewDefinition = tableViewDefinition1;
            // 
            // MasterTemplate
            // 
            this.MasterTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.MasterTemplate.Cursor = System.Windows.Forms.Cursors.Default;
            this.MasterTemplate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MasterTemplate.ForeColor = System.Drawing.Color.Black;
            this.MasterTemplate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MasterTemplate.Location = new System.Drawing.Point(346, 4);
            // 
            // 
            // 
            this.MasterTemplate.MasterTemplate.AllowAddNewRow = false;
            this.MasterTemplate.MasterTemplate.AllowColumnReorder = false;
            this.MasterTemplate.MasterTemplate.AllowDeleteRow = false;
            this.MasterTemplate.MasterTemplate.AllowEditRow = false;
            this.MasterTemplate.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "item_name";
            gridViewTextBoxColumn6.HeaderText = "Product Name";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "Product Name";
            gridViewTextBoxColumn6.Width = 180;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "salts";
            gridViewTextBoxColumn7.HeaderText = "Salts";
            gridViewTextBoxColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn7.Name = "salts";
            gridViewTextBoxColumn7.Width = 180;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "salt_component";
            gridViewTextBoxColumn8.HeaderText = "Salt Component";
            gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn8.Name = "Salt Component";
            gridViewTextBoxColumn8.Width = 230;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "StockQty";
            gridViewTextBoxColumn9.FormatString = "{0:N1}";
            gridViewTextBoxColumn9.HeaderText = "Qty[S]";
            gridViewTextBoxColumn9.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Name = "Qty[S]";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Width = 60;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "SaleAvgPacks";
            gridViewTextBoxColumn10.FormatString = "{0:N2}";
            gridViewTextBoxColumn10.HeaderText = "Avg[P]";
            gridViewTextBoxColumn10.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn10.Name = "Avg[P]";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn10.Width = 60;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "mrp";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "MRP";
            gridViewDecimalColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Name = "MRP";
            gridViewDecimalColumn1.Width = 70;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "npr";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "NPR";
            gridViewDecimalColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn2.Name = "NPR";
            gridViewDecimalColumn2.Width = 70;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "MARGIN";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "MARGIN";
            gridViewDecimalColumn3.Name = "MARGIN";
            gridViewDecimalColumn3.Width = 80;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "mfd_name";
            gridViewTextBoxColumn11.HeaderText = "Marketed By";
            gridViewTextBoxColumn11.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn11.Name = "Marketed By";
            gridViewTextBoxColumn11.Width = 200;
            this.MasterTemplate.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn11});
            this.MasterTemplate.MasterTemplate.EnableFiltering = true;
            this.MasterTemplate.MasterTemplate.EnableGrouping = false;
            this.MasterTemplate.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor1,
            filterDescriptor2});
            this.MasterTemplate.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.MasterTemplate.Name = "MasterTemplate";
            this.MasterTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MasterTemplate.Size = new System.Drawing.Size(797, 463);
            this.MasterTemplate.TabIndex = 1;
            this.MasterTemplate.Text = "radGridView1";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(1058, 470);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 27);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Export To XL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // gridUnitList
            // 
            this.gridUnitList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridUnitList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridUnitList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridUnitList.ForeColor = System.Drawing.Color.Black;
            this.gridUnitList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridUnitList.Location = new System.Drawing.Point(1, 4);
            // 
            // 
            // 
            this.gridUnitList.MasterTemplate.AllowAddNewRow = false;
            this.gridUnitList.MasterTemplate.AllowColumnReorder = false;
            this.gridUnitList.MasterTemplate.AllowDeleteRow = false;
            this.gridUnitList.MasterTemplate.AllowEditRow = false;
            this.gridUnitList.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "unit_id";
            gridViewTextBoxColumn12.HeaderText = "column1";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "column1";
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "sh_name";
            gridViewTextBoxColumn13.HeaderText = "Shop Name";
            gridViewTextBoxColumn13.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn13.Name = "sh_name";
            gridViewTextBoxColumn13.Width = 150;
            gridViewCommandColumn1.DefaultText = "View";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Command1";
            gridViewCommandColumn1.Name = "PRINT";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 70;
            gridViewCommandColumn2.DefaultText = "Print";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Command2";
            gridViewCommandColumn2.Name = "VIEW";
            gridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn2.UseDefaultText = true;
            gridViewCommandColumn2.Width = 80;
            this.gridUnitList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.gridUnitList.MasterTemplate.EnableGrouping = false;
            this.gridUnitList.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor3});
            this.gridUnitList.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gridUnitList.Name = "gridUnitList";
            this.gridUnitList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridUnitList.Size = new System.Drawing.Size(339, 493);
            this.gridUnitList.TabIndex = 3;
            this.gridUnitList.Text = "radGridView1";
            this.gridUnitList.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gridUnitList_CommandCellClick);
            // 
            // PrintSaltExistensce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 499);
            this.Controls.Add(this.gridUnitList);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.MasterTemplate);
            this.MaximizeBox = false;
            this.Name = "PrintSaltExistensce";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Print Unit Wise Salt Information";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Gen_UnitOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnitList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnitList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.MasterGridViewTemplate gridOrderDetail;
        private Telerik.WinControls.UI.RadGridView gridSaltInfo;
        private System.Windows.Forms.Button btnExcel;
        private Telerik.WinControls.UI.RadGridView MasterTemplate;
        private Telerik.WinControls.UI.RadGridView gridUnitList;
    }
}
