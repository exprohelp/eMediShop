namespace eMediShop.forms.Product
{
    partial class ucTrfNewMedicine
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
            this.label2 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lv_medicineDet = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_CentralmedDet = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Date and Press Enter Key to Get Product List.";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(5, 9);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(32, 16);
            this.lable.TabIndex = 9;
            this.lable.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lv_medicineDet);
            this.groupBox4.Location = new System.Drawing.Point(7, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 442);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unmatched Products";
            // 
            // lv_medicineDet
            // 
            this.lv_medicineDet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_medicineDet.FullRowSelect = true;
            this.lv_medicineDet.GridLines = true;
            this.lv_medicineDet.Location = new System.Drawing.Point(4, 23);
            this.lv_medicineDet.Name = "lv_medicineDet";
            this.lv_medicineDet.Size = new System.Drawing.Size(328, 409);
            this.lv_medicineDet.TabIndex = 2;
            this.lv_medicineDet.UseCompatibleStateImageBehavior = false;
            this.lv_medicineDet.View = System.Windows.Forms.View.Details;
            this.lv_medicineDet.Click += new System.EventHandler(this.lv_medicineDet_Click);
            this.lv_medicineDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_medicineDet_KeyDown);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "auto Id";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SrNo.";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_CentralmedDet);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(345, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 425);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Products At Central Server";
            // 
            // lv_CentralmedDet
            // 
            this.lv_CentralmedDet.AutoArrange = false;
            this.lv_CentralmedDet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lv_CentralmedDet.FullRowSelect = true;
            this.lv_CentralmedDet.GridLines = true;
            this.lv_CentralmedDet.Location = new System.Drawing.Point(7, 56);
            this.lv_CentralmedDet.Name = "lv_CentralmedDet";
            this.lv_CentralmedDet.Size = new System.Drawing.Size(276, 367);
            this.lv_CentralmedDet.TabIndex = 5;
            this.lv_CentralmedDet.UseCompatibleStateImageBehavior = false;
            this.lv_CentralmedDet.View = System.Windows.Forms.View.Details;
            this.lv_CentralmedDet.DoubleClick += new System.EventHandler(this.lv_CentralmedDet_DoubleClick);
            this.lv_CentralmedDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_CentralmedDet_KeyDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "item Id";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Name";
            this.columnHeader5.Width = 246;
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(7, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products To Search";
            // 
            // ucTrfNewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucTrfNewMedicine";
            this.Size = new System.Drawing.Size(668, 503);
            this.Load += new System.EventHandler(this.ucTrfNewMedicine_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lv_medicineDet;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_CentralmedDet;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}
