namespace eMediShop
{
    partial class ucAssetList
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAssetList));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnExcel = new Telerik.WinControls.UI.RadButton();
            this.dgAssetList = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewTemplate1 = new Telerik.WinControls.UI.GridViewTemplate();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label19 = new System.Windows.Forms.Label();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcel.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnExcel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.Location = new System.Drawing.Point(108, 6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(45, 33);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgAssetList
            // 
            this.dgAssetList.BackColor = System.Drawing.SystemColors.Control;
            this.dgAssetList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAssetList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgAssetList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAssetList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgAssetList.Location = new System.Drawing.Point(6, 42);
            // 
            // 
            // 
            this.dgAssetList.MasterTemplate.AllowAddNewRow = false;
            this.dgAssetList.MasterTemplate.AutoExpandGroups = true;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "R";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "R";
            gridViewCommandColumn1.Width = 37;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "eq_no";
            gridViewTextBoxColumn1.HeaderText = "Equipment No";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "eq_no";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 111;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Main_eq_no";
            gridViewTextBoxColumn2.HeaderText = "Main_eq_no";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "Main_eq_no";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "eq_name";
            gridViewTextBoxColumn3.HeaderText = "Equipment Name";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "eq_name";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 140;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "eq_serial_no";
            gridViewTextBoxColumn4.HeaderText = "S.No.";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "eq_serial_no";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "eq_description";
            gridViewTextBoxColumn5.HeaderText = "Description";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "eq_description";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 214;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "eq_category";
            gridViewTextBoxColumn6.HeaderText = "Category";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "eq_category";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewComboBoxColumn1.DisplayMember = "eq_location";
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "eq_location";
            gridViewComboBoxColumn1.HeaderText = "Location";
            gridViewComboBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewComboBoxColumn1.Name = "eq_location";
            gridViewComboBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewComboBoxColumn1.Width = 221;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "L";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "L";
            gridViewCommandColumn2.Width = 30;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "unit_rec_flag";
            gridViewTextBoxColumn7.HeaderText = "Rec.";
            gridViewTextBoxColumn7.Name = "unit_rec_flag";
            gridViewTextBoxColumn7.Width = 42;
            this.dgAssetList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCommandColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewComboBoxColumn1,
            gridViewCommandColumn2,
            gridViewTextBoxColumn7});
            this.dgAssetList.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "eq_category";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgAssetList.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            sortDescriptor2.PropertyName = "eq_location";
            this.dgAssetList.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.dgAssetList.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.gridViewTemplate1});
            this.dgAssetList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgAssetList.Name = "dgAssetList";
            this.dgAssetList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAssetList.Size = new System.Drawing.Size(919, 509);
            this.dgAssetList.TabIndex = 6;
            this.dgAssetList.Text = "radGridView1";
            this.dgAssetList.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.dgAssetList_RowFormatting);
            this.dgAssetList.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgAssetList_CommandCellClick);
            this.dgAssetList.Click += new System.EventHandler(this.dgAssetList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Help: R button is used to recieve asset at unit";
            // 
            // gridViewTemplate1
            // 
            this.gridViewTemplate1.AllowAddNewRow = false;
            this.gridViewTemplate1.AllowDeleteRow = false;
            this.gridViewTemplate1.AutoExpandGroups = true;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "eq_no";
            gridViewTextBoxColumn8.HeaderText = "Equipment No";
            gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn8.Name = "eq_no1";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 120;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "eq_category";
            gridViewTextBoxColumn9.HeaderText = "Category";
            gridViewTextBoxColumn9.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn9.Name = "eq_category1";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 100;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "eq_name";
            gridViewTextBoxColumn10.HeaderText = "Equipment Name";
            gridViewTextBoxColumn10.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn10.Name = "eq_name1";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.Width = 150;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "eq_serial_no";
            gridViewTextBoxColumn11.HeaderText = "Serail Number";
            gridViewTextBoxColumn11.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn11.Name = "eq_serial_no1";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.Width = 80;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "eq_description";
            gridViewTextBoxColumn12.HeaderText = "Description";
            gridViewTextBoxColumn12.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn12.Name = "eq_description1";
            gridViewTextBoxColumn12.ReadOnly = true;
            gridViewTextBoxColumn12.Width = 180;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "eq_location";
            gridViewTextBoxColumn13.HeaderText = "Location";
            gridViewTextBoxColumn13.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn13.Name = "eq_location1";
            gridViewTextBoxColumn13.Width = 250;
            this.gridViewTemplate1.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.gridViewTemplate1.ViewDefinition = tableViewDefinition1;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(6, 7);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(91, 31);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "LOAD ASSET";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(358, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(214, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "Add New Location in Drop Down List";
            // 
            // radButton2
            // 
            this.radButton2.Image = global::eMediShop.Properties.Resources.Save_16;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton2.Location = new System.Drawing.Point(894, 9);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(31, 27);
            this.radButton2.TabIndex = 29;
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoc.Location = new System.Drawing.Point(587, 11);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(272, 25);
            this.txtLoc.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(188, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Asset List exists on unit";
            // 
            // ucAssetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgAssetList);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "ucAssetList";
            this.Size = new System.Drawing.Size(926, 560);
            this.Load += new System.EventHandler(this.ucAssetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTemplate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnExcel;
        private Telerik.WinControls.UI.RadGridView dgAssetList;
        private Telerik.WinControls.UI.GridViewTemplate gridViewTemplate1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label19;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
