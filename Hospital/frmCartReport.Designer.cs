namespace eMediShop.Hospital
{
    partial class frmCartReport
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartReport));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvCartName = new Telerik.WinControls.UI.RadGridView();
            this.rgvCartInfo = new Telerik.WinControls.UI.RadGridView();
            this.btnFillCartName = new Telerik.WinControls.UI.RadButton();
            this.btnxl = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartName.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFillCartName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvCartName
            // 
            this.rgvCartName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvCartName.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvCartName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvCartName.ForeColor = System.Drawing.Color.Black;
            this.rgvCartName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvCartName.Location = new System.Drawing.Point(-2, 40);
            // 
            // 
            // 
            this.rgvCartName.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "hosp_store_id";
            gridViewTextBoxColumn1.HeaderText = "Hsopital Store Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "hosp_store_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "cart_name";
            gridViewTextBoxColumn2.HeaderText = "Medicine Cart Name";
            gridViewTextBoxColumn2.Name = "cart_name";
            gridViewTextBoxColumn2.Width = 217;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgvCartName.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            this.rgvCartName.MasterTemplate.EnableGrouping = false;
            this.rgvCartName.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvCartName.Name = "rgvCartName";
            this.rgvCartName.ReadOnly = true;
            this.rgvCartName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvCartName.Size = new System.Drawing.Size(274, 481);
            this.rgvCartName.TabIndex = 0;
            this.rgvCartName.Text = "radGridView1";
            this.rgvCartName.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvCartName_CommandCellClick);
            // 
            // rgvCartInfo
            // 
            this.rgvCartInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvCartInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvCartInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvCartInfo.ForeColor = System.Drawing.Color.Black;
            this.rgvCartInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvCartInfo.Location = new System.Drawing.Point(286, 1);
            // 
            // 
            // 
            this.rgvCartInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_id";
            gridViewTextBoxColumn3.HeaderText = "Item Id";
            gridViewTextBoxColumn3.Name = "item_id";
            gridViewTextBoxColumn3.Width = 83;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "item_name";
            gridViewTextBoxColumn4.HeaderText = "Name of Medicine";
            gridViewTextBoxColumn4.Name = "item_name";
            gridViewTextBoxColumn4.Width = 310;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "rcptQty";
            gridViewDecimalColumn1.HeaderText = "Rcpt Qty";
            gridViewDecimalColumn1.Name = "rcptQty";
            gridViewDecimalColumn1.Width = 65;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "trfQty";
            gridViewDecimalColumn2.HeaderText = "Trf. Qty";
            gridViewDecimalColumn2.Name = "trfQty";
            gridViewDecimalColumn2.Width = 60;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "qty";
            gridViewDecimalColumn3.FormatString = "{0:N0}";
            gridViewDecimalColumn3.HeaderText = "In Stock";
            gridViewDecimalColumn3.Name = "qty";
            gridViewDecimalColumn3.Width = 63;
            this.rgvCartInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3});
            this.rgvCartInfo.MasterTemplate.EnableGrouping = false;
            this.rgvCartInfo.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvCartInfo.Name = "rgvCartInfo";
            this.rgvCartInfo.ReadOnly = true;
            this.rgvCartInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvCartInfo.Size = new System.Drawing.Size(628, 520);
            this.rgvCartInfo.TabIndex = 1;
            this.rgvCartInfo.Text = "radGridView1";
            // 
            // btnFillCartName
            // 
            this.btnFillCartName.Location = new System.Drawing.Point(-2, 10);
            this.btnFillCartName.Name = "btnFillCartName";
            this.btnFillCartName.Size = new System.Drawing.Size(110, 24);
            this.btnFillCartName.TabIndex = 2;
            this.btnFillCartName.Text = "Fill Cart Name";
            this.btnFillCartName.Click += new System.EventHandler(this.btnFillCartName_Click);
            // 
            // btnxl
            // 
            this.btnxl.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnxl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxl.Location = new System.Drawing.Point(1040, 1);
            this.btnxl.Name = "btnxl";
            this.btnxl.Size = new System.Drawing.Size(53, 39);
            this.btnxl.TabIndex = 3;
            this.btnxl.Click += new System.EventHandler(this.btnxl_Click);
            // 
            // frmCartReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 520);
            this.Controls.Add(this.btnxl);
            this.Controls.Add(this.btnFillCartName);
            this.Controls.Add(this.rgvCartInfo);
            this.Controls.Add(this.rgvCartName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCartReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Medicine Cart Report";
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartName.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvCartInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFillCartName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvCartName;
        private Telerik.WinControls.UI.RadGridView rgvCartInfo;
        private Telerik.WinControls.UI.RadButton btnFillCartName;
        private Telerik.WinControls.UI.RadButton btnxl;
    }
}