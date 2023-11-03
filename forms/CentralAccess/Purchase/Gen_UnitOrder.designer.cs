namespace eMediShop.forms.CentralAccess.Purchase
{
    partial class Gen_UnitOrder
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor1 = new Telerik.WinControls.Data.FilterDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridOrderUnit = new Telerik.WinControls.UI.RadGridView();
            this.gridOrderDetail = new Telerik.WinControls.UI.RadGridView();
            this.btnUnits = new Telerik.WinControls.UI.RadButton();
            this.OrderMonth = new System.Windows.Forms.Label();
            this.txtOrdMth = new Telerik.WinControls.UI.RadTextBox();
            this.txtnProduct = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderUnit.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdMth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrderUnit
            // 
            this.gridOrderUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridOrderUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridOrderUnit.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridOrderUnit.ForeColor = System.Drawing.Color.Black;
            this.gridOrderUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridOrderUnit.Location = new System.Drawing.Point(1, 30);
            // 
            // 
            // 
            this.gridOrderUnit.MasterTemplate.AllowAddNewRow = false;
            this.gridOrderUnit.MasterTemplate.AllowColumnReorder = false;
            this.gridOrderUnit.MasterTemplate.AllowDeleteRow = false;
            this.gridOrderUnit.MasterTemplate.AllowEditRow = false;
            this.gridOrderUnit.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "sh_code";
            gridViewTextBoxColumn1.HeaderText = "column1";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "sh_name";
            gridViewTextBoxColumn2.HeaderText = "Shop Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "sh_name";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "order_no";
            gridViewTextBoxColumn3.HeaderText = "Order No";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "order_no";
            gridViewTextBoxColumn3.Width = 110;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.FieldName = "status";
            gridViewCommandColumn1.HeaderText = "Command1";
            gridViewCommandColumn1.Name = "Proccess";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.Width = 70;
            gridViewCommandColumn2.DefaultText = "View Detail";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.FieldName = "cmd_2";
            gridViewCommandColumn2.HeaderText = "Command2";
            gridViewCommandColumn2.Name = "View";
            gridViewCommandColumn2.Width = 80;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "unit_id";
            gridViewTextBoxColumn4.HeaderText = "unit_id";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "unit_id";
            this.gridOrderUnit.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewTextBoxColumn4});
            this.gridOrderUnit.MasterTemplate.EnableGrouping = false;
            this.gridOrderUnit.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor1});
            this.gridOrderUnit.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridOrderUnit.Name = "gridOrderUnit";
            this.gridOrderUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridOrderUnit.Size = new System.Drawing.Size(448, 457);
            this.gridOrderUnit.TabIndex = 0;
            this.gridOrderUnit.Text = "radGridView1";
            this.gridOrderUnit.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.gridOrderUnit_RowFormatting);
            this.gridOrderUnit.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.gridOrderUnit_CommandCellClick);
            // 
            // gridOrderDetail
            // 
            this.gridOrderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gridOrderDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridOrderDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridOrderDetail.ForeColor = System.Drawing.Color.Black;
            this.gridOrderDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridOrderDetail.Location = new System.Drawing.Point(451, 50);
            // 
            // 
            // 
            this.gridOrderDetail.MasterTemplate.AllowAddNewRow = false;
            this.gridOrderDetail.MasterTemplate.AllowColumnReorder = false;
            this.gridOrderDetail.MasterTemplate.AllowDeleteRow = false;
            this.gridOrderDetail.MasterTemplate.AllowEditRow = false;
            this.gridOrderDetail.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "item_name";
            gridViewTextBoxColumn5.HeaderText = "Product Name";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "item_name";
            gridViewTextBoxColumn5.Width = 200;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "pack_type";
            gridViewTextBoxColumn6.HeaderText = "Pack Type";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "pack_type";
            gridViewTextBoxColumn6.Width = 80;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "order_pack";
            gridViewTextBoxColumn7.HeaderText = "Ord.Pack";
            gridViewTextBoxColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Name = "order_pack";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Width = 80;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "vendor_name";
            gridViewTextBoxColumn8.HeaderText = "Vendor Info";
            gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn8.Name = "vendor_name";
            gridViewTextBoxColumn8.Width = 150;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Company";
            gridViewTextBoxColumn9.HeaderText = "Company";
            gridViewTextBoxColumn9.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn9.Name = "Company";
            gridViewTextBoxColumn9.Width = 150;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "npr";
            gridViewDecimalColumn1.HeaderText = "NPR";
            gridViewDecimalColumn1.Name = "NPR";
            gridViewDecimalColumn1.Width = 5;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "unitStock";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Unit Stock";
            gridViewDecimalColumn2.Name = "unitStock";
            this.gridOrderDetail.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2});
            this.gridOrderDetail.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridOrderDetail.Name = "gridOrderDetail";
            this.gridOrderDetail.ReadOnly = true;
            this.gridOrderDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridOrderDetail.Size = new System.Drawing.Size(694, 439);
            this.gridOrderDetail.TabIndex = 1;
            this.gridOrderDetail.Text = "radGridView2";
            // 
            // btnUnits
            // 
            this.btnUnits.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnits.Location = new System.Drawing.Point(1, 4);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(137, 24);
            this.btnUnits.TabIndex = 2;
            this.btnUnits.Text = "Check Order Status";
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // OrderMonth
            // 
            this.OrderMonth.AutoSize = true;
            this.OrderMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderMonth.Location = new System.Drawing.Point(150, 7);
            this.OrderMonth.Name = "OrderMonth";
            this.OrderMonth.Size = new System.Drawing.Size(99, 20);
            this.OrderMonth.TabIndex = 3;
            this.OrderMonth.Text = "Order Month";
            // 
            // txtOrdMth
            // 
            this.txtOrdMth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdMth.Location = new System.Drawing.Point(255, 6);
            this.txtOrdMth.Name = "txtOrdMth";
            this.txtOrdMth.Size = new System.Drawing.Size(32, 23);
            this.txtOrdMth.TabIndex = 4;
            this.txtOrdMth.Text = "1";
            this.txtOrdMth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnProduct
            // 
            this.txtnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnProduct.Location = new System.Drawing.Point(329, 6);
            this.txtnProduct.Name = "txtnProduct";
            this.txtnProduct.Size = new System.Drawing.Size(49, 23);
            this.txtnProduct.TabIndex = 6;
            this.txtnProduct.Text = "1000";
            this.txtnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnExport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Location = new System.Drawing.Point(468, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(42, 42);
            this.btnExport.TabIndex = 7;
            this.btnExport.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExport.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.export_excel;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExport.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExport.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExport.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Products";
            // 
            // Gen_UnitOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtnProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrdMth);
            this.Controls.Add(this.OrderMonth);
            this.Controls.Add(this.btnUnits);
            this.Controls.Add(this.gridOrderDetail);
            this.Controls.Add(this.gridOrderUnit);
            this.Name = "Gen_UnitOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Generate Purchase Order For Units";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Gen_UnitOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderUnit.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdMth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridOrderUnit;
        private Telerik.WinControls.UI.RadGridView gridOrderDetail;
        private Telerik.WinControls.UI.RadButton btnUnits;
        private System.Windows.Forms.Label OrderMonth;
        private Telerik.WinControls.UI.RadTextBox txtOrdMth;
        private Telerik.WinControls.UI.RadTextBox txtnProduct;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnExport;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.EllipseShape ellipseShape1;
    }
}
