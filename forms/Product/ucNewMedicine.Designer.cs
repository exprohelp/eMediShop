namespace eMediShop.forms.Product
{
    partial class ucNewMedicine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtMedcineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_medicineDet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtMedcineName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(628, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Medicine ( Ctrl+D: To Delete )";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(569, 32);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(54, 22);
            this.txtQty.TabIndex = 3;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // txtMedcineName
            // 
            this.txtMedcineName.Location = new System.Drawing.Point(5, 32);
            this.txtMedcineName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMedcineName.Name = "txtMedcineName";
            this.txtMedcineName.Size = new System.Drawing.Size(560, 22);
            this.txtMedcineName.TabIndex = 2;
            this.txtMedcineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMedcineName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Product";
            // 
            // lv_medicineDet
            // 
            this.lv_medicineDet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_medicineDet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_medicineDet.FullRowSelect = true;
            this.lv_medicineDet.GridLines = true;
            this.lv_medicineDet.Location = new System.Drawing.Point(0, 72);
            this.lv_medicineDet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lv_medicineDet.Name = "lv_medicineDet";
            this.lv_medicineDet.Size = new System.Drawing.Size(628, 319);
            this.lv_medicineDet.TabIndex = 0;
            this.lv_medicineDet.UseCompatibleStateImageBehavior = false;
            this.lv_medicineDet.View = System.Windows.Forms.View.Details;
            this.lv_medicineDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_medicineDet_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sr.No";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 488;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 58;
            // 
            // ucNewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lv_medicineDet);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucNewMedicine";
            this.Size = new System.Drawing.Size(628, 391);
            this.Load += new System.EventHandler(this.ucNewMedicine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtMedcineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_medicineDet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
