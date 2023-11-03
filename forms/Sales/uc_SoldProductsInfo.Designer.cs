namespace eMediShop.forms.Sales
{
    partial class uc_SoldProductsInfo
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgb_info = new Telerik.WinControls.UI.RadGroupBox();
            this.rbtn_Submit = new Telerik.WinControls.UI.RadButton();
            this.rdtp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rdtp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.btnXL = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).BeginInit();
            this.rgb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_Submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).BeginInit();
            this.SuspendLayout();
            // 
            // rgb_info
            // 
            this.rgb_info.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_info.Controls.Add(this.btnXL);
            this.rgb_info.Controls.Add(this.rbtn_Submit);
            this.rgb_info.Controls.Add(this.rdtp_to);
            this.rgb_info.Controls.Add(this.radLabel3);
            this.rgb_info.Controls.Add(this.rdtp_from);
            this.rgb_info.Controls.Add(this.radLabel2);
            this.rgb_info.Controls.Add(this.radLabel1);
            this.rgb_info.HeaderText = "";
            this.rgb_info.Location = new System.Drawing.Point(4, 2);
            this.rgb_info.Name = "rgb_info";
            this.rgb_info.Size = new System.Drawing.Size(904, 47);
            this.rgb_info.TabIndex = 0;
            this.rgb_info.Click += new System.EventHandler(this.rgb_info_Click);
            // 
            // rbtn_Submit
            // 
            this.rbtn_Submit.Image = global::eMediShop.Properties.Resources.click16;
            this.rbtn_Submit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Submit.Location = new System.Drawing.Point(339, 13);
            this.rbtn_Submit.Name = "rbtn_Submit";
            this.rbtn_Submit.Size = new System.Drawing.Size(34, 24);
            this.rbtn_Submit.TabIndex = 5;
            this.rbtn_Submit.ThemeName = "ControlDefault";
            this.rbtn_Submit.Click += new System.EventHandler(this.rbtn_Submit_Click);
            // 
            // rdtp_to
            // 
            this.rdtp_to.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtp_to.Location = new System.Drawing.Point(216, 12);
            this.rdtp_to.Name = "rdtp_to";
            this.rdtp_to.Size = new System.Drawing.Size(109, 25);
            this.rdtp_to.TabIndex = 4;
            this.rdtp_to.TabStop = false;
            this.rdtp_to.Text = "20-08-2014";
            this.rdtp_to.Value = new System.DateTime(2014, 8, 20, 17, 7, 19, 795);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(179, 13);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(25, 24);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "To";
            // 
            // rdtp_from
            // 
            this.rdtp_from.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtp_from.Location = new System.Drawing.Point(59, 12);
            this.rdtp_from.Name = "rdtp_from";
            this.rdtp_from.Size = new System.Drawing.Size(109, 25);
            this.rdtp_from.TabIndex = 2;
            this.rdtp_from.TabStop = false;
            this.rdtp_from.Text = "20-08-2014";
            this.rdtp_from.Value = new System.DateTime(2014, 8, 20, 17, 7, 19, 795);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(150, 13);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(25, 24);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "To";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(13, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "From";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(4, 54);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ITEM_ID";
            gridViewTextBoxColumn1.HeaderText = "ITEM ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ITEM ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "Name of Product";
            gridViewTextBoxColumn2.Width = 275;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "master_key_id";
            gridViewTextBoxColumn3.HeaderText = "Master Key Id";
            gridViewTextBoxColumn3.Name = "Master Key Id";
            gridViewTextBoxColumn3.Width = 140;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "category";
            gridViewTextBoxColumn4.HeaderText = "Category";
            gridViewTextBoxColumn4.Name = "Category";
            gridViewTextBoxColumn4.Width = 131;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "mfd_name";
            gridViewTextBoxColumn5.HeaderText = "Company";
            gridViewTextBoxColumn5.Name = "Company";
            gridViewTextBoxColumn5.Width = 106;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "openqty";
            gridViewDecimalColumn1.HeaderText = "Opening";
            gridViewDecimalColumn1.Name = "Opening";
            gridViewDecimalColumn2.AllowFiltering = false;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "trf_qty";
            gridViewDecimalColumn2.HeaderText = "Qty [T]";
            gridViewDecimalColumn2.Name = "Qty [T]";
            gridViewDecimalColumn2.Width = 55;
            gridViewDecimalColumn3.AllowFiltering = false;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "SoldQty";
            gridViewDecimalColumn3.HeaderText = "Qty [S]";
            gridViewDecimalColumn3.Name = "Qty [S]";
            gridViewDecimalColumn3.Width = 62;
            gridViewDecimalColumn4.AllowFiltering = false;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "rcpt_qty";
            gridViewDecimalColumn4.HeaderText = "Qty [Ret]";
            gridViewDecimalColumn4.Name = "Qty [Ret]";
            gridViewDecimalColumn4.Width = 67;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4});
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(904, 463);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            // 
            // btnXL
            // 
            this.btnXL.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnXL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXL.Location = new System.Drawing.Point(853, 5);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(45, 37);
            this.btnXL.TabIndex = 6;
            this.btnXL.ThemeName = "ControlDefault";
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // uc_SoldProductsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.rgb_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_SoldProductsInfo";
            this.Size = new System.Drawing.Size(917, 520);
            this.Load += new System.EventHandler(this.uc_SoldProductsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).EndInit();
            this.rgb_info.ResumeLayout(false);
            this.rgb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_Submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgb_info;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadDateTimePicker rdtp_to;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker rdtp_from;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton rbtn_Submit;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton btnXL;
    }
}
