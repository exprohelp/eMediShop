namespace eMediShop.ITSystem
{
    partial class ucUnitAllotment
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.rgb_info = new Telerik.WinControls.UI.RadGroupBox();
            this.btnDlink = new Telerik.WinControls.UI.RadButton();
            this.btnLink = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStaffList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).BeginInit();
            this.rgb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDlink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLink)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(4, 4);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "unit_id";
            gridViewTextBoxColumn3.HeaderText = "Unit Code";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "unit_id";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "unit_name";
            gridViewTextBoxColumn4.HeaderText = "Name of Unit";
            gridViewTextBoxColumn4.Name = "unit_name";
            gridViewTextBoxColumn4.Width = 383;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Name = "column3";
            gridViewCommandColumn2.Width = 25;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn2});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(448, 505);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // rgb_info
            // 
            this.rgb_info.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_info.Controls.Add(this.btnDlink);
            this.rgb_info.Controls.Add(this.btnLink);
            this.rgb_info.Controls.Add(this.label1);
            this.rgb_info.Controls.Add(this.cmbStaffList);
            this.rgb_info.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_info.HeaderText = "XXXXXXXXXXXXXXX";
            this.rgb_info.Location = new System.Drawing.Point(468, -3);
            this.rgb_info.Name = "rgb_info";
            this.rgb_info.Size = new System.Drawing.Size(324, 397);
            this.rgb_info.TabIndex = 1;
            this.rgb_info.Text = "XXXXXXXXXXXXXXX";
            this.rgb_info.Click += new System.EventHandler(this.rgb_info_Click);
            // 
            // btnDlink
            // 
            this.btnDlink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDlink.Image = global::eMediShop.Properties.Resources.dilink_32;
            this.btnDlink.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnDlink.Location = new System.Drawing.Point(6, 339);
            this.btnDlink.Name = "btnDlink";
            this.btnDlink.Size = new System.Drawing.Size(51, 53);
            this.btnDlink.TabIndex = 3;
            this.btnDlink.Text = "Detach";
            this.btnDlink.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDlink.Click += new System.EventHandler(this.btnDlink_Click);
            // 
            // btnLink
            // 
            this.btnLink.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLink.Image = global::eMediShop.Properties.Resources.link_32;
            this.btnLink.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnLink.Location = new System.Drawing.Point(268, 339);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(51, 53);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "Attach";
            this.btnLink.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of Staff";
            // 
            // cmbStaffList
            // 
            this.cmbStaffList.FormattingEnabled = true;
            this.cmbStaffList.Location = new System.Drawing.Point(5, 57);
            this.cmbStaffList.Name = "cmbStaffList";
            this.cmbStaffList.Size = new System.Drawing.Size(305, 28);
            this.cmbStaffList.TabIndex = 0;
            // 
            // ucUnitAllotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgb_info);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucUnitAllotment";
            this.Size = new System.Drawing.Size(795, 512);
            this.Load += new System.EventHandler(this.ucUnitAllotment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_info)).EndInit();
            this.rgb_info.ResumeLayout(false);
            this.rgb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDlink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadGroupBox rgb_info;
        private Telerik.WinControls.UI.RadButton btnLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStaffList;
        private Telerik.WinControls.UI.RadButton btnDlink;
    }
}
