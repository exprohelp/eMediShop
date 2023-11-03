namespace eMediShop.forms.TransferIds
{
    partial class ucSearchInTransit
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.btn_Submit = new Telerik.WinControls.UI.RadButton();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnxl = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxl)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Image = global::eMediShop.Properties.Resources.click_32;
            this.btn_Submit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Submit.Location = new System.Drawing.Point(11, 3);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(45, 40);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(62, 3);
            // 
            // rgv_info
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unit";
            gridViewTextBoxColumn1.HeaderText = "Unit";
            gridViewTextBoxColumn1.Name = "Unit";
            gridViewTextBoxColumn1.Width = 177;
            gridViewTextBoxColumn2.AllowFiltering = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "trf_id";
            gridViewTextBoxColumn2.HeaderText = "Transfer Id";
            gridViewTextBoxColumn2.Name = "Transfer Id";
            gridViewTextBoxColumn2.Width = 124;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "item_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Product";
            gridViewTextBoxColumn3.Name = "Name of Product";
            gridViewTextBoxColumn3.Width = 356;
            gridViewTextBoxColumn4.AllowFiltering = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "batch_no";
            gridViewTextBoxColumn4.HeaderText = "Batch No";
            gridViewTextBoxColumn4.Name = "Batch No";
            gridViewTextBoxColumn4.Width = 82;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "mrp";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "MRP";
            gridViewDecimalColumn1.Name = "MRP";
            gridViewDecimalColumn1.Width = 77;
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "packs";
            gridViewDecimalColumn2.FormatString = "{0:N0}";
            gridViewDecimalColumn2.HeaderText = "Packs";
            gridViewDecimalColumn2.Name = "Packs";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2});
            this.rgv_info.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "Unit";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(911, 504);
            this.rgv_info.TabIndex = 6;
            this.rgv_info.Text = "radGridView1";
            // 
            // btnxl
            // 
            this.btnxl.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnxl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxl.Location = new System.Drawing.Point(11, 467);
            this.btnxl.Name = "btnxl";
            this.btnxl.Size = new System.Drawing.Size(45, 40);
            this.btnxl.TabIndex = 7;
            this.btnxl.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxl.Click += new System.EventHandler(this.btnxl_Click);
            // 
            // ucSearchInTransit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnxl);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.btn_Submit);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucSearchInTransit";
            this.Size = new System.Drawing.Size(981, 510);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnxl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_Submit;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnxl;
    }
}
