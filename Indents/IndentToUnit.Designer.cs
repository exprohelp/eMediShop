namespace eMediShop.Indents
{
    partial class IndentToUnit
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndentToUnit));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor2 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lv_Product = new System.Windows.Forms.ListView();
            this.temid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mktby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnSubmitIndent = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_processedIndent = new Telerik.WinControls.UI.RadGridView();
            this.btnIndentStatus = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.packqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIndentStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_Product
            // 
            this.lv_Product.BackColor = System.Drawing.SystemColors.Info;
            this.lv_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.temid,
            this.itemname,
            this.mktby,
            this.Code,
            this.packqty});
            this.lv_Product.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Product.FullRowSelect = true;
            this.lv_Product.GridLines = true;
            this.lv_Product.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Product.HideSelection = false;
            this.lv_Product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_Product.Location = new System.Drawing.Point(6, 49);
            this.lv_Product.Name = "lv_Product";
            this.lv_Product.Size = new System.Drawing.Size(513, 25);
            this.lv_Product.TabIndex = 84;
            this.lv_Product.TabStop = false;
            this.lv_Product.UseCompatibleStateImageBehavior = false;
            this.lv_Product.View = System.Windows.Forms.View.Details;
            this.lv_Product.Visible = false;
            this.lv_Product.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_Product_KeyUp);
            // 
            // temid
            // 
            this.temid.Text = "Item Id";
            this.temid.Width = 0;
            // 
            // itemname
            // 
            this.itemname.Text = "NAME OF PRODUCT";
            this.itemname.Width = 310;
            // 
            // mktby
            // 
            this.mktby.Text = "MFD/MKT BY";
            this.mktby.Width = 100;
            // 
            // Code
            // 
            this.Code.Text = "HSN";
            this.Code.Width = 0;
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.Blue;
            this.txtProdName.Location = new System.Drawing.Point(6, 23);
            this.txtProdName.MaxLength = 50;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(446, 25);
            this.txtProdName.TabIndex = 83;
            this.txtProdName.TabStop = false;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            this.txtProdName.Enter += new System.EventHandler(this.txtProdName_Enter);
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdName_KeyDown);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Blue;
            this.txtQty.Location = new System.Drawing.Point(458, 23);
            this.txtQty.MaxLength = 0;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(61, 25);
            this.txtQty.TabIndex = 89;
            this.txtQty.TabStop = false;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.Enter += new System.EventHandler(this.txtQty_Enter);
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(5, 49);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "item_id";
            gridViewTextBoxColumn13.HeaderText = "Item ID";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "item_id";
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "item_name";
            gridViewTextBoxColumn14.HeaderText = "Name of Product";
            gridViewTextBoxColumn14.Name = "item_name";
            gridViewTextBoxColumn14.Width = 266;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "qty";
            gridViewDecimalColumn3.HeaderText = "Qty";
            gridViewDecimalColumn3.Name = "qty";
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "CreatedBy";
            gridViewTextBoxColumn15.HeaderText = "Created By";
            gridViewTextBoxColumn15.Name = "CreatedBy";
            gridViewTextBoxColumn15.Width = 143;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.Name = "column5";
            gridViewCommandColumn2.Width = 25;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "auto_id";
            gridViewTextBoxColumn16.HeaderText = "auto_id";
            gridViewTextBoxColumn16.IsVisible = false;
            gridViewTextBoxColumn16.Name = "auto_id";
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "indent_no";
            gridViewTextBoxColumn17.HeaderText = "indent_no";
            gridViewTextBoxColumn17.IsVisible = false;
            gridViewTextBoxColumn17.Name = "indent_no";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn15,
            gridViewCommandColumn2,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17});
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(518, 423);
            this.rgv_info.TabIndex = 90;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // btnSubmitIndent
            // 
            this.btnSubmitIndent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitIndent.Location = new System.Drawing.Point(5, 495);
            this.btnSubmitIndent.Name = "btnSubmitIndent";
            this.btnSubmitIndent.Size = new System.Drawing.Size(110, 30);
            this.btnSubmitIndent.TabIndex = 91;
            this.btnSubmitIndent.Text = "Submit";
            this.btnSubmitIndent.Click += new System.EventHandler(this.btnSubmitIndent_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmitIndent.GetChildAt(0))).Text = "Submit";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmitIndent.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnSubmitIndent.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_processedIndent);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(533, 25);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(573, 500);
            this.radGroupBox1.TabIndex = 92;
            this.radGroupBox1.Text = "XXXXXXXXXXX";
            // 
            // rgv_processedIndent
            // 
            this.rgv_processedIndent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_processedIndent.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_processedIndent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_processedIndent.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_processedIndent.ForeColor = System.Drawing.Color.Black;
            this.rgv_processedIndent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_processedIndent.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_processedIndent.MasterTemplate.AllowAddNewRow = false;
            this.rgv_processedIndent.MasterTemplate.AutoExpandGroups = true;
            this.rgv_processedIndent.MasterTemplate.AutoGenerateColumns = false;
            this.rgv_processedIndent.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "item_id";
            gridViewTextBoxColumn18.HeaderText = "Item ID";
            gridViewTextBoxColumn18.IsVisible = false;
            gridViewTextBoxColumn18.Name = "item_id";
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "item_name";
            gridViewTextBoxColumn19.HeaderText = "Name of Product";
            gridViewTextBoxColumn19.Name = "item_name";
            gridViewTextBoxColumn19.Width = 226;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "qty";
            gridViewDecimalColumn4.HeaderText = "Qty";
            gridViewDecimalColumn4.Name = "qty";
            gridViewDecimalColumn4.Width = 55;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "auto_id";
            gridViewTextBoxColumn20.HeaderText = "auto_id";
            gridViewTextBoxColumn20.IsVisible = false;
            gridViewTextBoxColumn20.Name = "auto_id";
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.FieldName = "indent_no";
            gridViewTextBoxColumn21.HeaderText = "Indent No.";
            gridViewTextBoxColumn21.Name = "indent_no";
            gridViewTextBoxColumn21.Width = 22;
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.FieldName = "conf_flag";
            gridViewTextBoxColumn22.HeaderText = "Conf Flag";
            gridViewTextBoxColumn22.Name = "conf_flag";
            gridViewTextBoxColumn22.Width = 66;
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.FieldName = "remarks";
            gridViewTextBoxColumn23.HeaderText = "Remarks";
            gridViewTextBoxColumn23.Name = "remarks";
            gridViewTextBoxColumn23.Width = 109;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.FieldName = "CreatedBy";
            gridViewTextBoxColumn24.HeaderText = "Created By";
            gridViewTextBoxColumn24.Name = "CreatedBy";
            gridViewTextBoxColumn24.Width = 76;
            this.rgv_processedIndent.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24});
            sortDescriptor2.PropertyName = "indent_no";
            groupDescriptor2.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.rgv_processedIndent.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor2});
            this.rgv_processedIndent.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgv_processedIndent.Name = "rgv_processedIndent";
            this.rgv_processedIndent.ReadOnly = true;
            this.rgv_processedIndent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_processedIndent.ShowGroupPanel = false;
            this.rgv_processedIndent.Size = new System.Drawing.Size(569, 480);
            this.rgv_processedIndent.TabIndex = 91;
            this.rgv_processedIndent.Text = "radGridView1";
            // 
            // btnIndentStatus
            // 
            this.btnIndentStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndentStatus.Location = new System.Drawing.Point(996, 4);
            this.btnIndentStatus.Name = "btnIndentStatus";
            this.btnIndentStatus.Size = new System.Drawing.Size(110, 30);
            this.btnIndentStatus.TabIndex = 93;
            this.btnIndentStatus.Text = "Indent Status";
            this.btnIndentStatus.Click += new System.EventHandler(this.btnIndentStatus_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnIndentStatus.GetChildAt(0))).Text = "Indent Status";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnIndentStatus.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnIndentStatus.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.lv_Product);
            this.radGroupBox2.Controls.Add(this.rgv_info);
            this.radGroupBox2.Controls.Add(this.txtProdName);
            this.radGroupBox2.Controls.Add(this.txtQty);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox2.HeaderText = "New Indent Creation (Qty Should be Loose e.g. 1x10=10";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(529, 477);
            this.radGroupBox2.TabIndex = 94;
            this.radGroupBox2.Text = "New Indent Creation (Qty Should be Loose e.g. 1x10=10";
            // 
            // packqty
            // 
            this.packqty.Text = "Pack Qty";
            this.packqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.packqty.Width = 80;
            // 
            // IndentToUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 525);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.btnSubmitIndent);
            this.Controls.Add(this.btnIndentStatus);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IndentToUnit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indent To Unit [For Supply Stock]";
            this.Load += new System.EventHandler(this.IndentToUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIndentStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lv_Product;
        internal System.Windows.Forms.ColumnHeader temid;
        internal System.Windows.Forms.ColumnHeader itemname;
        internal System.Windows.Forms.ColumnHeader mktby;
        private System.Windows.Forms.ColumnHeader Code;
        internal System.Windows.Forms.TextBox txtProdName;
        internal System.Windows.Forms.TextBox txtQty;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnSubmitIndent;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgv_processedIndent;
        private Telerik.WinControls.UI.RadButton btnIndentStatus;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.ColumnHeader packqty;
    }
}