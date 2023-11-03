namespace eMediShop.forms.Product
{
    partial class ucProductByCompany
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
            this.lvMfdInfo = new System.Windows.Forms.ListView();
            this.mfd_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mfd_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ProductInfo = new System.Windows.Forms.ListView();
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StkQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMfdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMfdInfo
            // 
            this.lvMfdInfo.BackColor = System.Drawing.Color.White;
            this.lvMfdInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMfdInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mfd_id,
            this.mfd_name});
            this.lvMfdInfo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMfdInfo.FullRowSelect = true;
            this.lvMfdInfo.GridLines = true;
            this.lvMfdInfo.Location = new System.Drawing.Point(8, 33);
            this.lvMfdInfo.Name = "lvMfdInfo";
            this.lvMfdInfo.Size = new System.Drawing.Size(226, 486);
            this.lvMfdInfo.TabIndex = 6;
            this.lvMfdInfo.UseCompatibleStateImageBehavior = false;
            this.lvMfdInfo.View = System.Windows.Forms.View.Details;
            this.lvMfdInfo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMfdInfo_ItemSelectionChanged);
            // 
            // mfd_id
            // 
            this.mfd_id.Text = "Mfd_Id";
            this.mfd_id.Width = 0;
            // 
            // mfd_name
            // 
            this.mfd_name.Text = "Name of Company";
            this.mfd_name.Width = 200;
            // 
            // lv_ProductInfo
            // 
            this.lv_ProductInfo.BackColor = System.Drawing.Color.White;
            this.lv_ProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_ProductInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_name,
            this.packType,
            this.Mtype,
            this.StkQty});
            this.lv_ProductInfo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ProductInfo.FullRowSelect = true;
            this.lv_ProductInfo.GridLines = true;
            this.lv_ProductInfo.Location = new System.Drawing.Point(239, 33);
            this.lv_ProductInfo.Name = "lv_ProductInfo";
            this.lv_ProductInfo.Size = new System.Drawing.Size(538, 486);
            this.lv_ProductInfo.TabIndex = 7;
            this.lv_ProductInfo.UseCompatibleStateImageBehavior = false;
            this.lv_ProductInfo.View = System.Windows.Forms.View.Details;
            // 
            // item_name
            // 
            this.item_name.Text = "Name of Product";
            this.item_name.Width = 320;
            // 
            // packType
            // 
            this.packType.Text = "P.Type";
            // 
            // Mtype
            // 
            this.Mtype.Text = "M.Type";
            this.Mtype.Width = 80;
            // 
            // StkQty
            // 
            this.StkQty.Text = "S.Qty";
            this.StkQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StkQty.Width = 40;
            // 
            // txtMfdName
            // 
            this.txtMfdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMfdName.Location = new System.Drawing.Point(51, 11);
            this.txtMfdName.MaxLength = 20;
            this.txtMfdName.Name = "txtMfdName";
            this.txtMfdName.Size = new System.Drawing.Size(181, 20);
            this.txtMfdName.TabIndex = 8;
            this.txtMfdName.TextChanged += new System.EventHandler(this.txtMfdName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(238, 14);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(302, 13);
            this.lblCompany.TabIndex = 10;
            this.lblCompany.Text = "Company : XXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // ucProductByCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMfdName);
            this.Controls.Add(this.lv_ProductInfo);
            this.Controls.Add(this.lvMfdInfo);
            this.Name = "ucProductByCompany";
            this.Size = new System.Drawing.Size(800, 520);
            this.Load += new System.EventHandler(this.ucChangeLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMfdInfo;
        private System.Windows.Forms.ColumnHeader mfd_id;
        private System.Windows.Forms.ColumnHeader mfd_name;
        private System.Windows.Forms.ListView lv_ProductInfo;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader packType;
        private System.Windows.Forms.ColumnHeader Mtype;
        private System.Windows.Forms.ColumnHeader StkQty;
        private System.Windows.Forms.TextBox txtMfdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompany;
    }
}
