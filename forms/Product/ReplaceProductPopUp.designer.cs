namespace eMediShop
{
    partial class ReplaceProductPopUp
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
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkConfirm = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.lv_FindProducts = new System.Windows.Forms.ListView();
            this.item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_FindProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_FindProd
            // 
            this.gb_FindProd.Controls.Add(this.lblItemId);
            this.gb_FindProd.Controls.Add(this.lblItem);
            this.gb_FindProd.Controls.Add(this.label2);
            this.gb_FindProd.Controls.Add(this.label1);
            this.gb_FindProd.Controls.Add(this.chkConfirm);
            this.gb_FindProd.Controls.Add(this.btnUpdate);
            this.gb_FindProd.Controls.Add(this.txtSearchString);
            this.gb_FindProd.Controls.Add(this.lv_FindProducts);
            this.gb_FindProd.Location = new System.Drawing.Point(5, 1);
            this.gb_FindProd.Name = "gb_FindProd";
            this.gb_FindProd.Size = new System.Drawing.Size(411, 423);
            this.gb_FindProd.TabIndex = 2;
            this.gb_FindProd.TabStop = false;
            this.gb_FindProd.Text = "Search Product";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblItemId.Location = new System.Drawing.Point(338, 376);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(57, 16);
            this.lblItemId.TabIndex = 8;
            this.lblItemId.Text = "XXXXXXX";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblItem.Location = new System.Drawing.Point(7, 378);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(155, 16);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "XXXXXXXXXXXXXXXXXXXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change By Product Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Change By Product Name";
            // 
            // chkConfirm
            // 
            this.chkConfirm.AutoSize = true;
            this.chkConfirm.Location = new System.Drawing.Point(11, 401);
            this.chkConfirm.Name = "chkConfirm";
            this.chkConfirm.Size = new System.Drawing.Size(154, 17);
            this.chkConfirm.TabIndex = 4;
            this.chkConfirm.Text = "I accept to replace product";
            this.chkConfirm.UseVisualStyleBackColor = true;
            this.chkConfirm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(282, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "REPLACE PRODUCT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.lv_FindProducts.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_FindProducts.FullRowSelect = true;
            this.lv_FindProducts.GridLines = true;
            this.lv_FindProducts.Location = new System.Drawing.Point(7, 46);
            this.lv_FindProducts.Name = "lv_FindProducts";
            this.lv_FindProducts.Size = new System.Drawing.Size(400, 308);
            this.lv_FindProducts.TabIndex = 1;
            this.lv_FindProducts.UseCompatibleStateImageBehavior = false;
            this.lv_FindProducts.View = System.Windows.Forms.View.Details;
            this.lv_FindProducts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_FindProducts_ItemSelectionChanged);
            // 
            // item_id
            // 
            this.item_id.Text = "";
            this.item_id.Width = 1;
            // 
            // product_Name
            // 
            this.product_Name.Text = "Products ";
            this.product_Name.Width = 368;
            // 
            // ReplaceProductPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 428);
            this.Controls.Add(this.gb_FindProd);
            this.MaximizeBox = false;
            this.Name = "ReplaceProductPopUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkConfirm;
        private System.Windows.Forms.Button btnUpdate;
    }
}