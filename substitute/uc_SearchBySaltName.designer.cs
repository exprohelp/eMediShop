namespace eMediShop.Substitute
{
    partial class uc_SearchBySaltName
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
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.gb_Products = new System.Windows.Forms.GroupBox();
            this.lv_products = new System.Windows.Forms.ListView();
            this.item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.strength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mfd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mrp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.npr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_ProductInfo = new System.Windows.Forms.GroupBox();
            this.lv_product_info = new System.Windows.Forms.ListView();
            this.SaltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strgth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_salt_name = new System.Windows.Forms.ListView();
            this.saltid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salt_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_Products.SuspendLayout();
            this.gb_ProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type Salt Name To Search";
            // 
            // txtSearchString
            // 
            this.txtSearchString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchString.Location = new System.Drawing.Point(7, 39);
            this.txtSearchString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(260, 23);
            this.txtSearchString.TabIndex = 7;
            this.txtSearchString.TextChanged += new System.EventHandler(this.txtSearchString_TextChanged);
            // 
            // gb_Products
            // 
            this.gb_Products.Controls.Add(this.lv_products);
            this.gb_Products.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Products.Location = new System.Drawing.Point(321, 39);
            this.gb_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Products.Name = "gb_Products";
            this.gb_Products.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Products.Size = new System.Drawing.Size(527, 297);
            this.gb_Products.TabIndex = 8;
            this.gb_Products.TabStop = false;
            this.gb_Products.Text = "XXXXXXXXXXXXXXXXXXXX";
            // 
            // lv_products
            // 
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.ItemName,
            this.strength,
            this.mfd,
            this.mrp,
            this.npr});
            this.lv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_products.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_products.FullRowSelect = true;
            this.lv_products.GridLines = true;
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(3, 23);
            this.lv_products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(521, 270);
            this.lv_products.TabIndex = 23;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            this.lv_products.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_products_ItemSelectionChanged);
            // 
            // item_id
            // 
            this.item_id.Text = "Item Id";
            this.item_id.Width = 0;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name of Items";
            this.ItemName.Width = 210;
            // 
            // strength
            // 
            this.strength.Text = "Strength";
            this.strength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.strength.Width = 70;
            // 
            // mfd
            // 
            this.mfd.Text = "Mfd Name";
            this.mfd.Width = 80;
            // 
            // mrp
            // 
            this.mrp.Text = "MRP";
            this.mrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // npr
            // 
            this.npr.Text = "NPR";
            this.npr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_ProductInfo
            // 
            this.gb_ProductInfo.Controls.Add(this.lv_product_info);
            this.gb_ProductInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ProductInfo.Location = new System.Drawing.Point(321, 344);
            this.gb_ProductInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ProductInfo.Name = "gb_ProductInfo";
            this.gb_ProductInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_ProductInfo.Size = new System.Drawing.Size(527, 211);
            this.gb_ProductInfo.TabIndex = 9;
            this.gb_ProductInfo.TabStop = false;
            // 
            // lv_product_info
            // 
            this.lv_product_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaltName,
            this.Strgth});
            this.lv_product_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_product_info.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_product_info.FullRowSelect = true;
            this.lv_product_info.GridLines = true;
            this.lv_product_info.HideSelection = false;
            this.lv_product_info.Location = new System.Drawing.Point(3, 23);
            this.lv_product_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_product_info.Name = "lv_product_info";
            this.lv_product_info.Size = new System.Drawing.Size(521, 184);
            this.lv_product_info.TabIndex = 24;
            this.lv_product_info.UseCompatibleStateImageBehavior = false;
            this.lv_product_info.View = System.Windows.Forms.View.Details;
            // 
            // SaltName
            // 
            this.SaltName.Text = "Name of Salt";
            this.SaltName.Width = 370;
            // 
            // Strgth
            // 
            this.Strgth.Text = "Strength";
            this.Strgth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Strgth.Width = 100;
            // 
            // lv_salt_name
            // 
            this.lv_salt_name.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.saltid,
            this.Salt_Name});
            this.lv_salt_name.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_salt_name.FullRowSelect = true;
            this.lv_salt_name.GridLines = true;
            this.lv_salt_name.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_salt_name.HideSelection = false;
            this.lv_salt_name.Location = new System.Drawing.Point(7, 67);
            this.lv_salt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_salt_name.Name = "lv_salt_name";
            this.lv_salt_name.Size = new System.Drawing.Size(260, 488);
            this.lv_salt_name.TabIndex = 22;
            this.lv_salt_name.UseCompatibleStateImageBehavior = false;
            this.lv_salt_name.View = System.Windows.Forms.View.Details;
            this.lv_salt_name.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_salt_name_ItemSelectionChanged);
            // 
            // saltid
            // 
            this.saltid.Text = "Salt Id";
            this.saltid.Width = 0;
            // 
            // Salt_Name
            // 
            this.Salt_Name.Text = "Name of Salt";
            this.Salt_Name.Width = 230;
            // 
            // uc_SearchBySaltName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lv_salt_name);
            this.Controls.Add(this.gb_ProductInfo);
            this.Controls.Add(this.gb_Products);
            this.Controls.Add(this.txtSearchString);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_SearchBySaltName";
            this.Size = new System.Drawing.Size(857, 556);
            this.Load += new System.EventHandler(this.uc_SearchBySaltName_Load);
            this.gb_Products.ResumeLayout(false);
            this.gb_ProductInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.GroupBox gb_Products;
        private System.Windows.Forms.GroupBox gb_ProductInfo;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader strength;
        private System.Windows.Forms.ColumnHeader mfd;
        private System.Windows.Forms.ListView lv_salt_name;
        private System.Windows.Forms.ColumnHeader saltid;
        private System.Windows.Forms.ColumnHeader Salt_Name;
        private System.Windows.Forms.ListView lv_product_info;
        private System.Windows.Forms.ColumnHeader SaltName;
        private System.Windows.Forms.ColumnHeader Strgth;
        private System.Windows.Forms.ColumnHeader mrp;
        private System.Windows.Forms.ColumnHeader npr;
    }
}
