namespace eMediShop.ITSystem
{
    partial class manager_signature
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn5 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_signature));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn3 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn6 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor3 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.ddlManager = new Telerik.WinControls.UI.RadDropDownList();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgShop = new Telerik.WinControls.UI.RadGridView();
            this.dgSignList = new Telerik.WinControls.UI.RadGridView();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.pic_sign = new System.Windows.Forms.PictureBox();
            this.lblShName = new System.Windows.Forms.Label();
            this.imageResizer1 = new ImageResizer.ImageResizer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShop.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSignList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSignList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(528, 318);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(97, 23);
            this.txtSearch.TabIndex = 96;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSearch.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSearch.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // ddlManager
            // 
            this.ddlManager.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlManager.Location = new System.Drawing.Point(528, 346);
            this.ddlManager.Name = "ddlManager";
            this.ddlManager.Size = new System.Drawing.Size(250, 23);
            this.ddlManager.TabIndex = 95;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::eMediShop.Properties.Resources.search_16;
            this.btnSearch.Location = new System.Drawing.Point(631, 318);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.TabIndex = 94;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Search Manager";
            // 
            // dgShop
            // 
            this.dgShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgShop.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgShop.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgShop.ForeColor = System.Drawing.Color.Black;
            this.dgShop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgShop.Location = new System.Drawing.Point(1, 2);
            // 
            // 
            // 
            this.dgShop.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "unit_id";
            gridViewTextBoxColumn11.HeaderText = "Shop Code";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "unit_id";
            gridViewTextBoxColumn11.Width = 82;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "sh_name";
            gridViewTextBoxColumn12.HeaderText = "Shop Name";
            gridViewTextBoxColumn12.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn12.Name = "sh_name";
            gridViewTextBoxColumn12.Width = 163;
            gridViewCommandColumn5.EnableExpressionEditor = false;
            gridViewCommandColumn5.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn5.Image")));
            gridViewCommandColumn5.Name = "column1";
            gridViewCommandColumn5.Width = 26;
            this.dgShop.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewCommandColumn5});
            this.dgShop.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.dgShop.Name = "dgShop";
            this.dgShop.ReadOnly = true;
            this.dgShop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgShop.ShowGroupPanel = false;
            this.dgShop.Size = new System.Drawing.Size(226, 487);
            this.dgShop.TabIndex = 103;
            this.dgShop.Text = "radGridView1";
            this.dgShop.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgShop_CommandCellClick);
            // 
            // dgSignList
            // 
            this.dgSignList.AutoSizeRows = true;
            this.dgSignList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.dgSignList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgSignList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgSignList.ForeColor = System.Drawing.Color.Black;
            this.dgSignList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgSignList.Location = new System.Drawing.Point(789, 2);
            // 
            // 
            // 
            this.dgSignList.MasterTemplate.AllowAddNewRow = false;
            this.dgSignList.MasterTemplate.AllowDeleteRow = false;
            this.dgSignList.MasterTemplate.AllowEditRow = false;
            this.dgSignList.MasterTemplate.AutoExpandGroups = true;
            this.dgSignList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "emp_name";
            gridViewTextBoxColumn13.HeaderText = "Manager Name";
            gridViewTextBoxColumn13.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn13.Name = "emp_name";
            gridViewTextBoxColumn13.Width = 115;
            gridViewImageColumn3.EnableExpressionEditor = false;
            gridViewImageColumn3.FieldName = "sign_image";
            gridViewImageColumn3.HeaderText = "Signature";
            gridViewImageColumn3.Name = "sign_image";
            gridViewImageColumn3.Width = 113;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "auto_id";
            gridViewTextBoxColumn14.HeaderText = "auto_id";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "auto_id";
            gridViewTextBoxColumn14.Width = 46;
            gridViewCommandColumn6.EnableExpressionEditor = false;
            gridViewCommandColumn6.HeaderText = "D";
            gridViewCommandColumn6.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn6.Image")));
            gridViewCommandColumn6.Name = "column1";
            gridViewCommandColumn6.Width = 26;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "sh_name";
            gridViewTextBoxColumn15.Name = "sh_name";
            gridViewTextBoxColumn15.Width = 5;
            this.dgSignList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn13,
            gridViewImageColumn3,
            gridViewTextBoxColumn14,
            gridViewCommandColumn6,
            gridViewTextBoxColumn15});
            sortDescriptor3.PropertyName = "sh_name";
            groupDescriptor3.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.dgSignList.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor3});
            this.dgSignList.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.dgSignList.Name = "dgSignList";
            this.dgSignList.ReadOnly = true;
            this.dgSignList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgSignList.ShowGroupPanel = false;
            this.dgSignList.Size = new System.Drawing.Size(293, 487);
            this.dgSignList.TabIndex = 115;
            this.dgSignList.Text = "radGridView1";
            this.dgSignList.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgSignList_CommandCellClick);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::eMediShop.Properties.Resources.Save_16;
            this.btnSave.Location = new System.Drawing.Point(724, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 27);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.Save_16;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "Save";
            // 
            // pic_sign
            // 
            this.pic_sign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_sign.Location = new System.Drawing.Point(242, 318);
            this.pic_sign.Name = "pic_sign";
            this.pic_sign.Size = new System.Drawing.Size(100, 60);
            this.pic_sign.TabIndex = 117;
            this.pic_sign.TabStop = false;
            // 
            // lblShName
            // 
            this.lblShName.AutoSize = true;
            this.lblShName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShName.Location = new System.Drawing.Point(513, 9);
            this.lblShName.Name = "lblShName";
            this.lblShName.Size = new System.Drawing.Size(39, 15);
            this.lblShName.TabIndex = 118;
            this.lblShName.Text = "XXXX";
            // 
            // imageResizer1
            // 
            this.imageResizer1.Location = new System.Drawing.Point(233, 2);
            this.imageResizer1.MinimumSize = new System.Drawing.Size(550, 300);
            this.imageResizer1.Name = "imageResizer1";
            this.imageResizer1.RequiredHeight = 0;
            this.imageResizer1.RequiredWidth = 0;
            this.imageResizer1.Size = new System.Drawing.Size(550, 300);
            this.imageResizer1.StandAloneMode = false;
            this.imageResizer1.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "100x60";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.Location = new System.Drawing.Point(529, 378);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(98, 13);
            this.lblUnitName.TabIndex = 121;
            this.lblUnitName.Text = "XXXXXXXXXXXXX";
            // 
            // manager_signature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 489);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageResizer1);
            this.Controls.Add(this.lblShName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pic_sign);
            this.Controls.Add(this.dgSignList);
            this.Controls.Add(this.dgShop);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ddlManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "manager_signature";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reconcile Product Movement";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.BlockUnBlock_ForSaleAvg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShop.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSignList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSignList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadDropDownList ddlManager;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView dgShop;
        private Telerik.WinControls.UI.RadGridView dgSignList;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.PictureBox pic_sign;
        private System.Windows.Forms.Label lblShName;
        private ImageResizer.ImageResizer imageResizer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnitName;
    }
}
