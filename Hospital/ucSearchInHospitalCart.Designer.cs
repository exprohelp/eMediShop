namespace eMediShop.Hospital
{
    partial class ucSearchInHospitalCart
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.rtb_Search = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnSubmit);
            this.radGroupBox1.Controls.Add(this.rtb_Search);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Search Product In Cart (% as prefix to Search embeded)";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(451, 62);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Search Product In Cart (% as prefix to Search embeded)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::eMediShop.Properties.Resources.click16;
            this.btnSubmit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Location = new System.Drawing.Point(408, 21);
            this.btnSubmit.Name = "btnSubmit";
            // 
            // 
            // 
            this.btnSubmit.RootElement.Shape = this.ellipseShape1;
            this.btnSubmit.Size = new System.Drawing.Size(38, 35);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.click16;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // rtb_Search
            // 
            this.rtb_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Search.Location = new System.Drawing.Point(6, 31);
            this.rtb_Search.Name = "rtb_Search";
            this.rtb_Search.NullText = "Type Product Name";
            this.rtb_Search.Size = new System.Drawing.Size(268, 25);
            this.rtb_Search.TabIndex = 0;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_Search.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_Search.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgvInfo
            // 
            this.rgvInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rgvInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgvInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvInfo.Location = new System.Drawing.Point(4, 73);
            // 
            // 
            // 
            this.rgvInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "cart_name";
            gridViewTextBoxColumn3.HeaderText = "Name of Cart";
            gridViewTextBoxColumn3.Name = "cart_name";
            gridViewTextBoxColumn3.Width = 318;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "item_name";
            gridViewTextBoxColumn4.HeaderText = "Name of Product";
            gridViewTextBoxColumn4.Name = "item_name";
            gridViewTextBoxColumn4.Width = 344;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "qty";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.Name = "qty";
            gridViewDecimalColumn2.Width = 42;
            this.rgvInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn2});
            sortDescriptor2.PropertyName = "cart_name";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgvInfo.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor2});
            this.rgvInfo.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.ReadOnly = true;
            this.rgvInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvInfo.Size = new System.Drawing.Size(451, 468);
            this.rgvInfo.TabIndex = 1;
            this.rgvInfo.Text = "radGridView1";
            // 
            // ucSearchInHospitalCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgvInfo);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSearchInHospitalCart";
            this.Size = new System.Drawing.Size(458, 544);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.UI.RadTextBox rtb_Search;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadGridView rgvInfo;
    }
}
