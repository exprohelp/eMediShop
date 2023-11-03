namespace eMediShop.Substitute
{
    partial class addSaltToProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSaltToProduct));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dispPanel = new Telerik.WinControls.UI.RadPanel();
            this.dgItemList = new Telerik.WinControls.UI.RadGridView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.rdp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.MasterPnl = new Telerik.WinControls.UI.RadPanel();
            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dispPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterPnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dispPanel
            // 
            this.dispPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dispPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dispPanel.Location = new System.Drawing.Point(0, 0);
            this.dispPanel.Name = "dispPanel";
            this.dispPanel.Size = new System.Drawing.Size(534, 501);
            this.dispPanel.TabIndex = 1;
            // 
            // dgItemList
            // 
            this.dgItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItemList.BackColor = System.Drawing.SystemColors.Control;
            this.dgItemList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgItemList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgItemList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgItemList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgItemList.Location = new System.Drawing.Point(0, 131);
            // 
            // 
            // 
            this.dgItemList.MasterTemplate.AllowAddNewRow = false;
            this.dgItemList.MasterTemplate.AllowColumnReorder = false;
            this.dgItemList.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "item_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 261;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "img_flag";
            gridViewTextBoxColumn3.HeaderText = "img_flag";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "img_flag";
            this.dgItemList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewTextBoxColumn3});
            this.dgItemList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgItemList.Name = "dgItemList";
            this.dgItemList.ReadOnly = true;
            this.dgItemList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgItemList.ShowGroupPanel = false;
            this.dgItemList.Size = new System.Drawing.Size(315, 370);
            this.dgItemList.TabIndex = 7;
            this.dgItemList.Text = "radGridView1";
            this.dgItemList.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.MasterTemplate_ViewCellFormatting);
            this.dgItemList.Click += new System.EventHandler(this.dgItemList_Click);
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Controls.Add(this.splitPanel3);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Size = new System.Drawing.Size(1171, 501);
            this.radSplitContainer1.TabIndex = 9;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.chkImage);
            this.splitPanel1.Controls.Add(this.richTextBox1);
            this.splitPanel1.Controls.Add(this.btnSubmit);
            this.splitPanel1.Controls.Add(this.rdp_to);
            this.splitPanel1.Controls.Add(this.label1);
            this.splitPanel1.Controls.Add(this.label2);
            this.splitPanel1.Controls.Add(this.rdp_from);
            this.splitPanel1.Controls.Add(this.dgItemList);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            this.splitPanel1.Size = new System.Drawing.Size(315, 501);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.0624821F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-73, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // chkImage
            // 
            this.chkImage.AutoSize = true;
            this.chkImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImage.Location = new System.Drawing.Point(246, 71);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(63, 21);
            this.chkImage.TabIndex = 13;
            this.chkImage.Text = "Image";
            this.chkImage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(306, 65);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "List of Created Product i Date Range. \nClick Image Check Box To View List of Prod" +
    "uct with Image\nattached bwetween dates.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = global::eMediShop.Properties.Resources.click_32;
            this.btnSubmit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Location = new System.Drawing.Point(247, 100);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(65, 25);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdp_to
            // 
            this.rdp_to.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_to.Location = new System.Drawing.Point(140, 100);
            this.rdp_to.Name = "rdp_to";
            this.rdp_to.Size = new System.Drawing.Size(100, 25);
            this.rdp_to.TabIndex = 9;
            this.rdp_to.TabStop = false;
            this.rdp_to.Text = "06/06/2016";
            this.rdp_to.Value = new System.DateTime(2016, 6, 6, 14, 55, 2, 210);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "From";
            // 
            // rdp_from
            // 
            this.rdp_from.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_from.Location = new System.Drawing.Point(17, 100);
            this.rdp_from.Name = "rdp_from";
            this.rdp_from.Size = new System.Drawing.Size(100, 25);
            this.rdp_from.TabIndex = 8;
            this.rdp_from.TabStop = false;
            this.rdp_from.Text = "06/06/2016";
            this.rdp_from.Value = new System.DateTime(2016, 6, 6, 14, 55, 2, 210);
            this.rdp_from.Leave += new System.EventHandler(this.rdp_from_Leave);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.MasterPnl);
            this.splitPanel2.Location = new System.Drawing.Point(319, 0);
            this.splitPanel2.Name = "splitPanel2";
            this.splitPanel2.Size = new System.Drawing.Size(314, 501);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.06334195F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-74, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // MasterPnl
            // 
            this.MasterPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPnl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MasterPnl.Location = new System.Drawing.Point(0, 0);
            this.MasterPnl.Name = "MasterPnl";
            this.MasterPnl.Size = new System.Drawing.Size(314, 501);
            this.MasterPnl.TabIndex = 0;
            // 
            // splitPanel3
            // 
            this.splitPanel3.Controls.Add(this.dispPanel);
            this.splitPanel3.Location = new System.Drawing.Point(637, 0);
            this.splitPanel3.Name = "splitPanel3";
            this.splitPanel3.Size = new System.Drawing.Size(534, 501);
            this.splitPanel3.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.125824F, 0F);
            this.splitPanel3.SizeInfo.SplitterCorrection = new System.Drawing.Size(147, 0);
            this.splitPanel3.TabIndex = 2;
            this.splitPanel3.TabStop = false;
            this.splitPanel3.Text = "splitPanel3";
            // 
            // addSaltToProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 501);
            this.Controls.Add(this.radSplitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "addSaltToProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Salt Information";
            this.Load += new System.EventHandler(this.addSaltToProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MasterPnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel dispPanel;
        private Telerik.WinControls.UI.RadGridView dgItemList;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_from;
        private Telerik.WinControls.UI.RadPanel MasterPnl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkImage;
    }
}
