namespace eMediShop.forms.Product
{
    partial class ucCheckSubstitute
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lvs_Info = new System.Windows.Forms.ListView();
            this.SaltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.strength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Search = new System.Windows.Forms.ListView();
            this.item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.i_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvf_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Found = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // txtProduct
            // 
            this.txtProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduct.Location = new System.Drawing.Point(52, 7);
            this.txtProduct.MaxLength = 20;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(181, 22);
            this.txtProduct.TabIndex = 12;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // lvs_Info
            // 
            this.lvs_Info.BackColor = System.Drawing.Color.White;
            this.lvs_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvs_Info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaltName,
            this.strength,
            this.unit});
            this.lvs_Info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvs_Info.FullRowSelect = true;
            this.lvs_Info.GridLines = true;
            this.lvs_Info.Location = new System.Drawing.Point(316, 18);
            this.lvs_Info.Name = "lvs_Info";
            this.lvs_Info.Size = new System.Drawing.Size(482, 208);
            this.lvs_Info.TabIndex = 11;
            this.lvs_Info.UseCompatibleStateImageBehavior = false;
            this.lvs_Info.View = System.Windows.Forms.View.Details;
            // 
            // SaltName
            // 
            this.SaltName.Text = "Name of Salt";
            this.SaltName.Width = 350;
            // 
            // strength
            // 
            this.strength.Text = "Strength";
            this.strength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // unit
            // 
            this.unit.Text = "Unit";
            this.unit.Width = 43;
            // 
            // lv_Search
            // 
            this.lv_Search.BackColor = System.Drawing.Color.White;
            this.lv_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.i_name});
            this.lv_Search.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Search.FullRowSelect = true;
            this.lv_Search.GridLines = true;
            this.lv_Search.Location = new System.Drawing.Point(5, 18);
            this.lv_Search.Name = "lv_Search";
            this.lv_Search.Size = new System.Drawing.Size(279, 208);
            this.lv_Search.TabIndex = 10;
            this.lv_Search.UseCompatibleStateImageBehavior = false;
            this.lv_Search.View = System.Windows.Forms.View.Details;
            this.lv_Search.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Search_ItemSelectionChanged);
            this.lv_Search.DoubleClick += new System.EventHandler(this.lv_Search_DoubleClick);
            // 
            // item_id
            // 
            this.item_id.Text = "item_id";
            this.item_id.Width = 0;
            // 
            // i_name
            // 
            this.i_name.Text = "Name of Product";
            this.i_name.Width = 250;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lvs_Info);
            this.gbSearch.Controls.Add(this.lv_Search);
            this.gbSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 35);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(807, 228);
            this.gbSearch.TabIndex = 14;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Product For Substitute";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvf_info);
            this.groupBox1.Controls.Add(this.lv_Found);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 228);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Found Product For Substitute";
            // 
            // lvf_info
            // 
            this.lvf_info.BackColor = System.Drawing.Color.White;
            this.lvf_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvf_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvf_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvf_info.FullRowSelect = true;
            this.lvf_info.GridLines = true;
            this.lvf_info.Location = new System.Drawing.Point(316, 18);
            this.lvf_info.Name = "lvf_info";
            this.lvf_info.Size = new System.Drawing.Size(482, 208);
            this.lvf_info.TabIndex = 11;
            this.lvf_info.UseCompatibleStateImageBehavior = false;
            this.lvf_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name of Salt";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Strength";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit";
            this.columnHeader3.Width = 38;
            // 
            // lv_Found
            // 
            this.lv_Found.BackColor = System.Drawing.Color.White;
            this.lv_Found.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Found.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lv_Found.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Found.FullRowSelect = true;
            this.lv_Found.GridLines = true;
            this.lv_Found.Location = new System.Drawing.Point(5, 18);
            this.lv_Found.Name = "lv_Found";
            this.lv_Found.Size = new System.Drawing.Size(279, 208);
            this.lv_Found.TabIndex = 10;
            this.lv_Found.UseCompatibleStateImageBehavior = false;
            this.lv_Found.View = System.Windows.Forms.View.Details;
            this.lv_Found.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Found_ItemSelectionChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "item_id";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name of Product";
            this.columnHeader5.Width = 250;
            // 
            // ucCheckSubstitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduct);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucCheckSubstitute";
            this.Size = new System.Drawing.Size(833, 522);
            this.gbSearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ListView lvs_Info;
        private System.Windows.Forms.ColumnHeader SaltName;
        private System.Windows.Forms.ColumnHeader strength;
        private System.Windows.Forms.ColumnHeader unit;
        private System.Windows.Forms.ListView lv_Search;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader i_name;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvf_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lv_Found;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
