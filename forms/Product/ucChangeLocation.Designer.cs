namespace eMediShop.forms.Product
{
    partial class ucChangeLocation
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChangeLocation));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOldLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rgv_product = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rb_loadAll = new System.Windows.Forms.RadioButton();
            this.rb_search = new System.Windows.Forms.RadioButton();
            this.chkRackSwap = new System.Windows.Forms.CheckBox();
            this.gbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_product.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(27, 0);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(0, 15);
            this.lblProduct.TabIndex = 9;
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(12, 45);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(342, 24);
            this.txtProduct.TabIndex = 7;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            // 
            // gbinfo
            // 
            this.gbinfo.BackColor = System.Drawing.SystemColors.Control;
            this.gbinfo.Controls.Add(this.btnSave);
            this.gbinfo.Controls.Add(this.txtOldLocation);
            this.gbinfo.Controls.Add(this.lblProduct);
            this.gbinfo.Controls.Add(this.label3);
            this.gbinfo.Controls.Add(this.txtNewLocation);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbinfo.ForeColor = System.Drawing.Color.Black;
            this.gbinfo.Location = new System.Drawing.Point(384, 85);
            this.gbinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbinfo.Size = new System.Drawing.Size(246, 207);
            this.gbinfo.TabIndex = 8;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "XXXXXXXXXXXXXXXXXXXX";
            this.gbinfo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(147, 130);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOldLocation
            // 
            this.txtOldLocation.Enabled = false;
            this.txtOldLocation.Location = new System.Drawing.Point(139, 34);
            this.txtOldLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldLocation.Name = "txtOldLocation";
            this.txtOldLocation.Size = new System.Drawing.Size(79, 20);
            this.txtOldLocation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Old Location";
            // 
            // txtNewLocation
            // 
            this.txtNewLocation.Location = new System.Drawing.Point(139, 87);
            this.txtNewLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewLocation.Name = "txtNewLocation";
            this.txtNewLocation.Size = new System.Drawing.Size(79, 20);
            this.txtNewLocation.TabIndex = 2;
            this.txtNewLocation.TextChanged += new System.EventHandler(this.txtNewLocation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Location";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(395, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Transfer Un-Identified Location as N/A ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rgv_product
            // 
            this.rgv_product.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_product.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_product.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_product.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_product.Location = new System.Drawing.Point(12, 71);
            // 
            // 
            // 
            this.rgv_product.MasterTemplate.AllowAddNewRow = false;
            this.rgv_product.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "item_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "cur_loc";
            gridViewTextBoxColumn3.HeaderText = "Location";
            gridViewTextBoxColumn3.Name = "location";
            gridViewTextBoxColumn3.Width = 80;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_product.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.rgv_product.MasterTemplate.EnableFiltering = true;
            this.rgv_product.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_product.Name = "rgv_product";
            this.rgv_product.ReadOnly = true;
            this.rgv_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_product.ShowGroupPanel = false;
            this.rgv_product.Size = new System.Drawing.Size(342, 369);
            this.rgv_product.TabIndex = 12;
            this.rgv_product.Text = "radGridView1";
            this.rgv_product.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_product_CommandCellClick);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rb_loadAll);
            this.radGroupBox1.Controls.Add(this.rb_search);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 7);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(342, 35);
            this.radGroupBox1.TabIndex = 13;
            // 
            // rb_loadAll
            // 
            this.rb_loadAll.AutoSize = true;
            this.rb_loadAll.Location = new System.Drawing.Point(235, 8);
            this.rb_loadAll.Name = "rb_loadAll";
            this.rb_loadAll.Size = new System.Drawing.Size(100, 24);
            this.rb_loadAll.TabIndex = 1;
            this.rb_loadAll.Text = "All Product";
            this.rb_loadAll.UseVisualStyleBackColor = true;
            this.rb_loadAll.CheckedChanged += new System.EventHandler(this.rb_loadAll_CheckedChanged);
            // 
            // rb_search
            // 
            this.rb_search.AutoSize = true;
            this.rb_search.Checked = true;
            this.rb_search.Location = new System.Drawing.Point(6, 8);
            this.rb_search.Name = "rb_search";
            this.rb_search.Size = new System.Drawing.Size(126, 24);
            this.rb_search.TabIndex = 0;
            this.rb_search.TabStop = true;
            this.rb_search.Text = "Search Product";
            this.rb_search.UseVisualStyleBackColor = true;
            this.rb_search.CheckedChanged += new System.EventHandler(this.rb_search_CheckedChanged);
            // 
            // chkRackSwap
            // 
            this.chkRackSwap.AutoSize = true;
            this.chkRackSwap.Location = new System.Drawing.Point(384, 15);
            this.chkRackSwap.Name = "chkRackSwap";
            this.chkRackSwap.Size = new System.Drawing.Size(265, 24);
            this.chkRackSwap.TabIndex = 14;
            this.chkRackSwap.Text = "Replace All Product of Old Location";
            this.chkRackSwap.UseVisualStyleBackColor = true;
            // 
            // ucChangeLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkRackSwap);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.rgv_product);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.gbinfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucChangeLocation";
            this.Size = new System.Drawing.Size(674, 448);
            this.Load += new System.EventHandler(this.ucChangeLocation_Load);
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_product.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.TextBox txtOldLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadGridView rgv_product;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.RadioButton rb_loadAll;
        private System.Windows.Forms.RadioButton rb_search;
        private System.Windows.Forms.CheckBox chkRackSwap;
    }
}
