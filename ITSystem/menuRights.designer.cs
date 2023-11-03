namespace eMediShop.ITSystem
{
    partial class menuRights
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
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuRights));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor3 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.rgv_employee = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(355, 52);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "element_name";
            gridViewTextBoxColumn1.HeaderText = "elementName";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "element_name";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "cmt_text";
            gridViewTextBoxColumn2.HeaderText = "Tab";
            gridViewTextBoxColumn2.Name = "cmd_tab";
            gridViewTextBoxColumn2.Width = 165;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "grp_text";
            gridViewTextBoxColumn3.HeaderText = "Group";
            gridViewTextBoxColumn3.Name = "grp_text";
            gridViewTextBoxColumn3.Width = 126;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "element_text";
            gridViewTextBoxColumn4.HeaderText = "Menu Name";
            gridViewTextBoxColumn4.Name = "element_text";
            gridViewTextBoxColumn4.Width = 319;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "allow";
            gridViewTextBoxColumn5.HeaderText = "Flag";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "allow";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "Action";
            gridViewCommandColumn1.Name = "A";
            gridViewCommandColumn1.Width = 64;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            sortDescriptor1.PropertyName = "cmd_tab";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            sortDescriptor2.PropertyName = "grp_text";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1,
            groupDescriptor2});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(473, 446);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_info_RowFormatting);
            this.rgv_info.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.rgv_info_ViewCellFormatting);
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // rgv_employee
            // 
            this.rgv_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_employee.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_employee.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_employee.ForeColor = System.Drawing.Color.Black;
            this.rgv_employee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_employee.Location = new System.Drawing.Point(1, 2);
            // 
            // 
            // 
            this.rgv_employee.MasterTemplate.AllowAddNewRow = false;
            this.rgv_employee.MasterTemplate.AllowSearchRow = true;
            this.rgv_employee.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "user_code";
            gridViewTextBoxColumn6.HeaderText = "emp_code";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "emp_code";
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "unit_name";
            gridViewTextBoxColumn7.HeaderText = "Name of Unit";
            gridViewTextBoxColumn7.Name = "unit_name";
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "emp_name";
            gridViewTextBoxColumn8.HeaderText = "Name of Employee";
            gridViewTextBoxColumn8.Name = "emp_name";
            gridViewTextBoxColumn8.Width = 270;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column1";
            gridViewCommandColumn2.Width = 25;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "unit_id";
            gridViewTextBoxColumn9.HeaderText = "unit_id";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "unit_id";
            this.rgv_employee.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewCommandColumn2,
            gridViewTextBoxColumn9});
            sortDescriptor3.PropertyName = "unit_name";
            groupDescriptor3.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_employee.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor3});
            this.rgv_employee.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_employee.Name = "rgv_employee";
            this.rgv_employee.ReadOnly = true;
            this.rgv_employee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_employee.ShowGroupPanel = false;
            this.rgv_employee.Size = new System.Drawing.Size(349, 495);
            this.rgv_employee.TabIndex = 2;
            this.rgv_employee.Text = "radGridView1";
            this.rgv_employee.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // menuRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.Controls.Add(this.rgv_employee);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "menuRights";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Assign Menu Rights To User";
            this.Load += new System.EventHandler(this.menuRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadGridView rgv_employee;
    }
}
