namespace eMediShop
{
    partial class CheckMedicineAtStores
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lv_Searched = new System.Windows.Forms.ListView();
            this.lv_AtStore = new System.Windows.Forms.ListView();
            this.Col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name of Product To Search";
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::eMediShop.Properties.Resources.SearchInNet_32;
            this.btn_Search.Location = new System.Drawing.Point(306, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(43, 41);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lv_Searched
            // 
            this.lv_Searched.BackColor = System.Drawing.Color.LightGray;
            this.lv_Searched.FullRowSelect = true;
            this.lv_Searched.GridLines = true;
            this.lv_Searched.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Searched.Location = new System.Drawing.Point(1, 55);
            this.lv_Searched.Name = "lv_Searched";
            this.lv_Searched.Size = new System.Drawing.Size(264, 300);
            this.lv_Searched.TabIndex = 4;
            this.lv_Searched.UseCompatibleStateImageBehavior = false;
            this.lv_Searched.View = System.Windows.Forms.View.Details;
            this.lv_Searched.Enter += new System.EventHandler(this.lv_Searched_Enter);
            this.lv_Searched.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Searched_KeyDown);
            // 
            // lv_AtStore
            // 
            this.lv_AtStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col1,
            this.Col2});
            this.lv_AtStore.FullRowSelect = true;
            this.lv_AtStore.GridLines = true;
            this.lv_AtStore.Location = new System.Drawing.Point(1, 55);
            this.lv_AtStore.Name = "lv_AtStore";
            this.lv_AtStore.Size = new System.Drawing.Size(348, 375);
            this.lv_AtStore.TabIndex = 5;
            this.lv_AtStore.UseCompatibleStateImageBehavior = false;
            this.lv_AtStore.View = System.Windows.Forms.View.Details;
            // 
            // Col1
            // 
            this.Col1.Text = "Name of Store";
            this.Col1.Width = 260;
            // 
            // Col2
            // 
            this.Col2.Text = "Qty";
            this.Col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CheckMedicineAtStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 435);
            this.Controls.Add(this.lv_Searched);
            this.Controls.Add(this.lv_AtStore);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckMedicineAtStores";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check Medicine At Other Stores";
            this.Load += new System.EventHandler(this.CheckMedicineAtStores_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lv_Searched;
        private System.Windows.Forms.ListView lv_AtStore;
        private System.Windows.Forms.ColumnHeader Col1;
        private System.Windows.Forms.ColumnHeader Col2;
    }
}