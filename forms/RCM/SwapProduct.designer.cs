namespace eMediShop.forms.RCM
{
    partial class SwapProduct
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
            this.gb_FindProd = new System.Windows.Forms.GroupBox();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.lv_FindProducts = new System.Windows.Forms.ListView();
            this.item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_FindProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_FindProd
            // 
            this.gb_FindProd.Controls.Add(this.txtSearchString);
            this.gb_FindProd.Controls.Add(this.lv_FindProducts);
            this.gb_FindProd.Location = new System.Drawing.Point(5, 1);
            this.gb_FindProd.Name = "gb_FindProd";
            this.gb_FindProd.Size = new System.Drawing.Size(411, 423);
            this.gb_FindProd.TabIndex = 2;
            this.gb_FindProd.TabStop = false;
            this.gb_FindProd.Text = "XXXXXXXXXXXXXXXXX";
            // 
            // txtSearchString
            // 
            this.txtSearchString.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchString.Location = new System.Drawing.Point(7, 24);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(400, 20);
            this.txtSearchString.TabIndex = 2;
            this.txtSearchString.TextChanged += new System.EventHandler(this.txtSearchString_TextChanged);
            // 
            // lv_FindProducts
            // 
            this.lv_FindProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.product_Name});
            this.lv_FindProducts.FullRowSelect = true;
            this.lv_FindProducts.GridLines = true;
            this.lv_FindProducts.Location = new System.Drawing.Point(7, 47);
            this.lv_FindProducts.Name = "lv_FindProducts";
            this.lv_FindProducts.Size = new System.Drawing.Size(400, 369);
            this.lv_FindProducts.TabIndex = 1;
            this.lv_FindProducts.UseCompatibleStateImageBehavior = false;
            this.lv_FindProducts.View = System.Windows.Forms.View.Details;
            this.lv_FindProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_FindProducts_KeyDown);
            // 
            // item_id
            // 
            this.item_id.Text = "";
            this.item_id.Width = 1;
            // 
            // product_Name
            // 
            this.product_Name.Text = "Product Available In eMediShop";
            this.product_Name.Width = 368;
            // 
            // SwapProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 428);
            this.Controls.Add(this.gb_FindProd);
            this.MaximizeBox = false;
            this.Name = "SwapProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substitute Entry";
            this.Load += new System.EventHandler(this.CGHS_SwapProduct_Load);
            this.gb_FindProd.ResumeLayout(false);
            this.gb_FindProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_FindProd;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.ListView lv_FindProducts;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader product_Name;
    }
}