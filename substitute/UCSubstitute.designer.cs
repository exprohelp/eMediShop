namespace eMediShop.Substitute
{
    partial class UCSubstitute
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
            this.lvStrength = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SaltSearch = new System.Windows.Forms.Button();
            this.txtSaltSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlStrength = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlSalt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlProduct = new System.Windows.Forms.ComboBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStrength
            // 
            this.lvStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStrength.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.SaltName,
            this.Strength});
            this.lvStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStrength.FullRowSelect = true;
            this.lvStrength.GridLines = true;
            this.lvStrength.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStrength.HideSelection = false;
            this.lvStrength.Location = new System.Drawing.Point(6, 173);
            this.lvStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvStrength.Name = "lvStrength";
            this.lvStrength.Size = new System.Drawing.Size(496, 227);
            this.lvStrength.TabIndex = 6;
            this.lvStrength.UseCompatibleStateImageBehavior = false;
            this.lvStrength.View = System.Windows.Forms.View.Details;
            this.lvStrength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvStrength_KeyDown);
            // 
            // Id
            // 
            this.Id.Text = "id";
            this.Id.Width = 0;
            // 
            // SaltName
            // 
            this.SaltName.Text = "Salt Name";
            this.SaltName.Width = 350;
            // 
            // Strength
            // 
            this.Strength.Text = "Strength";
            this.Strength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Strength.Width = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvStrength);
            this.groupBox1.Controls.Add(this.btn_SaltSearch);
            this.groupBox1.Controls.Add(this.txtSaltSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtStrength);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ddlStrength);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlSalt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ddlProduct);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(514, 410);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_SaltSearch
            // 
            this.btn_SaltSearch.Location = new System.Drawing.Point(206, 56);
            this.btn_SaltSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaltSearch.Name = "btn_SaltSearch";
            this.btn_SaltSearch.Size = new System.Drawing.Size(45, 26);
            this.btn_SaltSearch.TabIndex = 12;
            this.btn_SaltSearch.Text = ">>";
            this.btn_SaltSearch.UseVisualStyleBackColor = true;
            this.btn_SaltSearch.Click += new System.EventHandler(this.btn_SaltSearch_Click);
            // 
            // txtSaltSearch
            // 
            this.txtSaltSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaltSearch.Location = new System.Drawing.Point(107, 58);
            this.txtSaltSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaltSearch.Name = "txtSaltSearch";
            this.txtSaltSearch.Size = new System.Drawing.Size(98, 23);
            this.txtSaltSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(206, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 24);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = ">>";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStrength
            // 
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStrength.Location = new System.Drawing.Point(107, 132);
            this.txtStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(98, 23);
            this.txtStrength.TabIndex = 9;
            this.txtStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Strength";
            // 
            // ddlStrength
            // 
            this.ddlStrength.FormattingEnabled = true;
            this.ddlStrength.Location = new System.Drawing.Point(107, 95);
            this.ddlStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlStrength.Name = "ddlStrength";
            this.ddlStrength.Size = new System.Drawing.Size(241, 23);
            this.ddlStrength.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 132);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Strength Type";
            // 
            // ddlSalt
            // 
            this.ddlSalt.FormattingEnabled = true;
            this.ddlSalt.Location = new System.Drawing.Point(255, 58);
            this.ddlSalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlSalt.Name = "ddlSalt";
            this.ddlSalt.Size = new System.Drawing.Size(247, 23);
            this.ddlSalt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salt Used";
            // 
            // ddlProduct
            // 
            this.ddlProduct.FormattingEnabled = true;
            this.ddlProduct.Location = new System.Drawing.Point(254, 21);
            this.ddlProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlProduct.Name = "ddlProduct";
            this.ddlProduct.Size = new System.Drawing.Size(248, 23);
            this.ddlProduct.TabIndex = 3;
            this.ddlProduct.SelectedIndexChanged += new System.EventHandler(this.ddlProduct_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(107, 21);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(98, 23);
            this.txtItemName.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(3, 24);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Search Product";
            // 
            // UCSubstitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCSubstitute";
            this.Size = new System.Drawing.Size(525, 426);
            this.Load += new System.EventHandler(this.UCSubstitute_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStrength;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox ddlStrength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlProduct;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader SaltName;
        private System.Windows.Forms.ColumnHeader Strength;
        private System.Windows.Forms.Button btn_SaltSearch;
        private System.Windows.Forms.TextBox txtSaltSearch;
    }
}
