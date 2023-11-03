namespace eMediShop.forms.Product
{
    partial class UploadSubstitute_Doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadSubstitute_Doc));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgItemName = new Telerik.WinControls.UI.RadGridView();
            this.MasterPanel = new Telerik.WinControls.UI.RadPanel();
            this.lblItemNAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.pnlMaster = new Telerik.WinControls.UI.RadPanel();
            this.chkImages = new System.Windows.Forms.CheckBox();
            this.uploadSubstitute_Control1 = new eMediShop.UploadSubstitute_Control();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemName.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPanel)).BeginInit();
            this.MasterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgItemName
            // 
            this.dgItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgItemName.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgItemName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgItemName.ForeColor = System.Drawing.Color.Black;
            this.dgItemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgItemName.Location = new System.Drawing.Point(1, 27);
            // 
            // 
            // 
            this.dgItemName.MasterTemplate.AllowAddNewRow = false;
            this.dgItemName.MasterTemplate.AllowDeleteRow = false;
            this.dgItemName.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.Width = 62;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Item Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 212;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 24;
            this.dgItemName.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            this.dgItemName.MasterTemplate.EnableFiltering = true;
            this.dgItemName.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgItemName.Name = "dgItemName";
            this.dgItemName.ReadOnly = true;
            this.dgItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgItemName.ShowGroupPanel = false;
            this.dgItemName.Size = new System.Drawing.Size(275, 434);
            this.dgItemName.TabIndex = 0;
            this.dgItemName.Text = "radGridView1";
            this.dgItemName.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgItemName_CommandCellClick);
            // 
            // MasterPanel
            // 
            this.MasterPanel.AutoScroll = true;
            this.MasterPanel.Controls.Add(this.uploadSubstitute_Control1);
            this.MasterPanel.Enabled = false;
            this.MasterPanel.Location = new System.Drawing.Point(282, 28);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(503, 433);
            this.MasterPanel.TabIndex = 1;
            // 
            // lblItemNAME
            // 
            this.lblItemNAME.AutoSize = true;
            this.lblItemNAME.Location = new System.Drawing.Point(283, 9);
            this.lblItemNAME.Name = "lblItemNAME";
            this.lblItemNAME.Size = new System.Drawing.Size(70, 13);
            this.lblItemNAME.TabIndex = 3;
            this.lblItemNAME.Text = "XXXXXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Product";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(91, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 21);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(216, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 21);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlMaster
            // 
            this.pnlMaster.AutoScroll = true;
            this.pnlMaster.Location = new System.Drawing.Point(790, 7);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(361, 451);
            this.pnlMaster.TabIndex = 9;
            // 
            // chkImages
            // 
            this.chkImages.AutoSize = true;
            this.chkImages.Location = new System.Drawing.Point(636, 5);
            this.chkImages.Name = "chkImages";
            this.chkImages.Size = new System.Drawing.Size(133, 17);
            this.chkImages.TabIndex = 10;
            this.chkImages.Text = "Check Image Upload";
            this.chkImages.UseVisualStyleBackColor = true;
            // 
            // uploadSubstitute_Control1
            // 
            this.uploadSubstitute_Control1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadSubstitute_Control1.ItemId = "";
            this.uploadSubstitute_Control1.ItemName = "";
            this.uploadSubstitute_Control1.Location = new System.Drawing.Point(4, 5);
            this.uploadSubstitute_Control1.Name = "uploadSubstitute_Control1";
            this.uploadSubstitute_Control1.Size = new System.Drawing.Size(498, 190);
            this.uploadSubstitute_Control1.TabIndex = 0;
            // 
            // UploadSubstitute_Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 464);
            this.Controls.Add(this.chkImages);
            this.Controls.Add(this.pnlMaster);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItemNAME);
            this.Controls.Add(this.MasterPanel);
            this.Controls.Add(this.dgItemName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UploadSubstitute_Doc";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Upload Substitute Document";
            this.Load += new System.EventHandler(this.UploadSubstitute_Doc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItemName.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPanel)).EndInit();
            this.MasterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgItemName;
        private Telerik.WinControls.UI.RadPanel MasterPanel;
        private UploadSubstitute_Control uploadSubstitute_Control1;
        private System.Windows.Forms.Label lblItemNAME;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadPanel pnlMaster;
        private System.Windows.Forms.CheckBox chkImages;
    }
}
