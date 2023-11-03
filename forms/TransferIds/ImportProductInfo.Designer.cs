namespace eMediShop
{
    partial class ImportProductInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_Product = new System.Windows.Forms.ListView();
            this.item_id = new System.Windows.Forms.ColumnHeader();
            this.item_name = new System.Windows.Forms.ColumnHeader();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_Product);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import && Update Product From Server";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lv_Product
            // 
            this.lv_Product.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.item_name});
            this.lv_Product.FullRowSelect = true;
            this.lv_Product.GridLines = true;
            this.lv_Product.Location = new System.Drawing.Point(11, 71);
            this.lv_Product.Name = "lv_Product";
            this.lv_Product.Size = new System.Drawing.Size(270, 317);
            this.lv_Product.TabIndex = 2;
            this.lv_Product.UseCompatibleStateImageBehavior = false;
            this.lv_Product.View = System.Windows.Forms.View.Details;
            this.lv_Product.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_Product_KeyUp);
            // 
            // item_id
            // 
            this.item_id.Text = "item_id";
            this.item_id.Width = 0;
            // 
            // item_name
            // 
            this.item_name.Text = "Name of Product";
            this.item_name.Width = 245;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search  Name";
            // 
            // ImportProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 400);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImportProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import & Update Product From Server";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImportProductInfo_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_Product;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader item_name;
    }
}