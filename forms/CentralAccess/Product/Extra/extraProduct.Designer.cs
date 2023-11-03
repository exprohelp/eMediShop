namespace eMediShop
{
    partial class extraProduct
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
            this.btnRcv = new System.Windows.Forms.Button();
            this.grp_MisMatch = new System.Windows.Forms.GroupBox();
            this.lv_MisMatchDetail = new System.Windows.Forms.ListView();
            this.master_key_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack_size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pack_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shelf_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_MatchDet = new System.Windows.Forms.GroupBox();
            this.lv_MatchDet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenrateId = new System.Windows.Forms.Button();
            this.btnTrfToHO = new System.Windows.Forms.Button();
            this.ddlTrfId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_IntSheet = new System.Windows.Forms.Button();
            this.btn_PrintFormT03 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Mismatch = new System.Windows.Forms.Button();
            this.grp_MisMatch.SuspendLayout();
            this.grp_MatchDet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRcv
            // 
            this.btnRcv.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRcv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRcv.FlatAppearance.BorderSize = 5;
            this.btnRcv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRcv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRcv.ForeColor = System.Drawing.Color.Coral;
            this.btnRcv.Location = new System.Drawing.Point(13, 12);
            this.btnRcv.Name = "btnRcv";
            this.btnRcv.Size = new System.Drawing.Size(248, 30);
            this.btnRcv.TabIndex = 0;
            this.btnRcv.Text = "Click To Start Extra Product Streaming";
            this.btnRcv.UseVisualStyleBackColor = false;
            this.btnRcv.Click += new System.EventHandler(this.btnRcv_Click);
            // 
            // grp_MisMatch
            // 
            this.grp_MisMatch.Controls.Add(this.lv_MisMatchDetail);
            this.grp_MisMatch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_MisMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grp_MisMatch.Location = new System.Drawing.Point(13, 49);
            this.grp_MisMatch.Name = "grp_MisMatch";
            this.grp_MisMatch.Size = new System.Drawing.Size(794, 133);
            this.grp_MisMatch.TabIndex = 2;
            this.grp_MisMatch.TabStop = false;
            this.grp_MisMatch.Text = "Mismatch Details";
            // 
            // lv_MisMatchDetail
            // 
            this.lv_MisMatchDetail.BackColor = System.Drawing.Color.PapayaWhip;
            this.lv_MisMatchDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.master_key_id,
            this.item_id,
            this.item_name,
            this.Pack_size,
            this.pack_type,
            this.qty,
            this.Shelf_no});
            this.lv_MisMatchDetail.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_MisMatchDetail.FullRowSelect = true;
            this.lv_MisMatchDetail.GridLines = true;
            this.lv_MisMatchDetail.Location = new System.Drawing.Point(6, 20);
            this.lv_MisMatchDetail.Name = "lv_MisMatchDetail";
            this.lv_MisMatchDetail.Size = new System.Drawing.Size(782, 104);
            this.lv_MisMatchDetail.TabIndex = 2;
            this.lv_MisMatchDetail.UseCompatibleStateImageBehavior = false;
            this.lv_MisMatchDetail.View = System.Windows.Forms.View.Details;
            // 
            // master_key_id
            // 
            this.master_key_id.Text = "Master Key Id";
            this.master_key_id.Width = 150;
            // 
            // item_id
            // 
            this.item_id.Text = "Item Id";
            this.item_id.Width = 83;
            // 
            // item_name
            // 
            this.item_name.Text = "Item Name";
            this.item_name.Width = 213;
            // 
            // Pack_size
            // 
            this.Pack_size.Text = "Pack Size";
            this.Pack_size.Width = 86;
            // 
            // pack_type
            // 
            this.pack_type.Text = "Pack Type";
            this.pack_type.Width = 86;
            // 
            // qty
            // 
            this.qty.Text = "Packs";
            this.qty.Width = 61;
            // 
            // Shelf_no
            // 
            this.Shelf_no.Text = "Shelf No";
            // 
            // grp_MatchDet
            // 
            this.grp_MatchDet.Controls.Add(this.lv_MatchDet);
            this.grp_MatchDet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_MatchDet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grp_MatchDet.Location = new System.Drawing.Point(10, 188);
            this.grp_MatchDet.Name = "grp_MatchDet";
            this.grp_MatchDet.Size = new System.Drawing.Size(797, 179);
            this.grp_MatchDet.TabIndex = 3;
            this.grp_MatchDet.TabStop = false;
            this.grp_MatchDet.Text = "Match Detail";
            // 
            // lv_MatchDet
            // 
            this.lv_MatchDet.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lv_MatchDet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_MatchDet.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_MatchDet.FullRowSelect = true;
            this.lv_MatchDet.GridLines = true;
            this.lv_MatchDet.Location = new System.Drawing.Point(7, 23);
            this.lv_MatchDet.Name = "lv_MatchDet";
            this.lv_MatchDet.Size = new System.Drawing.Size(782, 150);
            this.lv_MatchDet.TabIndex = 2;
            this.lv_MatchDet.UseCompatibleStateImageBehavior = false;
            this.lv_MatchDet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Master Key Id";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Id";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Name";
            this.columnHeader3.Width = 213;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pack Size";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pack Type";
            this.columnHeader5.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Packs";
            this.columnHeader6.Width = 61;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Shelf No";
            // 
            // btnGenrateId
            // 
            this.btnGenrateId.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenrateId.Enabled = false;
            this.btnGenrateId.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGenrateId.FlatAppearance.BorderSize = 3;
            this.btnGenrateId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenrateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenrateId.ForeColor = System.Drawing.Color.White;
            this.btnGenrateId.Location = new System.Drawing.Point(10, 373);
            this.btnGenrateId.Name = "btnGenrateId";
            this.btnGenrateId.Size = new System.Drawing.Size(179, 28);
            this.btnGenrateId.TabIndex = 4;
            this.btnGenrateId.Text = "Generate Transfer Ids.";
            this.btnGenrateId.UseVisualStyleBackColor = false;
            this.btnGenrateId.Click += new System.EventHandler(this.btnGenrateId_Click);
            // 
            // btnTrfToHO
            // 
            this.btnTrfToHO.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTrfToHO.Enabled = false;
            this.btnTrfToHO.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnTrfToHO.FlatAppearance.BorderSize = 3;
            this.btnTrfToHO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrfToHO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrfToHO.ForeColor = System.Drawing.Color.White;
            this.btnTrfToHO.Location = new System.Drawing.Point(656, 31);
            this.btnTrfToHO.Name = "btnTrfToHO";
            this.btnTrfToHO.Size = new System.Drawing.Size(133, 29);
            this.btnTrfToHO.TabIndex = 5;
            this.btnTrfToHO.Text = "Transfer To HO.";
            this.btnTrfToHO.UseVisualStyleBackColor = false;
            this.btnTrfToHO.Click += new System.EventHandler(this.btnTrfToHO_Click);
            // 
            // ddlTrfId
            // 
            this.ddlTrfId.FormattingEnabled = true;
            this.ddlTrfId.Location = new System.Drawing.Point(204, 38);
            this.ddlTrfId.Name = "ddlTrfId";
            this.ddlTrfId.Size = new System.Drawing.Size(144, 22);
            this.ddlTrfId.TabIndex = 6;
            this.ddlTrfId.SelectedIndexChanged += new System.EventHandler(this.ddlTrfId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Transfer Id.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_IntSheet);
            this.groupBox1.Controls.Add(this.btn_PrintFormT03);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.ddlTrfId);
            this.groupBox1.Controls.Add(this.btnTrfToHO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Id to Send & Print transfer Form ";
            // 
            // btn_IntSheet
            // 
            this.btn_IntSheet.BackColor = System.Drawing.Color.White;
            this.btn_IntSheet.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_IntSheet.FlatAppearance.BorderSize = 3;
            this.btn_IntSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_IntSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IntSheet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_IntSheet.Image = global::eMediShop.Properties.Resources.newprinter;
            this.btn_IntSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IntSheet.Location = new System.Drawing.Point(372, 31);
            this.btn_IntSheet.Name = "btn_IntSheet";
            this.btn_IntSheet.Size = new System.Drawing.Size(102, 29);
            this.btn_IntSheet.TabIndex = 11;
            this.btn_IntSheet.Text = "Int .Sheet";
            this.btn_IntSheet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_IntSheet.UseVisualStyleBackColor = false;
            this.btn_IntSheet.Click += new System.EventHandler(this.btn_IntSheet_Click);
            // 
            // btn_PrintFormT03
            // 
            this.btn_PrintFormT03.BackColor = System.Drawing.Color.White;
            this.btn_PrintFormT03.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_PrintFormT03.FlatAppearance.BorderSize = 3;
            this.btn_PrintFormT03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_PrintFormT03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintFormT03.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_PrintFormT03.Image = global::eMediShop.Properties.Resources.newprinter;
            this.btn_PrintFormT03.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PrintFormT03.Location = new System.Drawing.Point(495, 31);
            this.btn_PrintFormT03.Name = "btn_PrintFormT03";
            this.btn_PrintFormT03.Size = new System.Drawing.Size(102, 29);
            this.btn_PrintFormT03.TabIndex = 10;
            this.btn_PrintFormT03.Text = "Form T-03";
            this.btn_PrintFormT03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PrintFormT03.UseVisualStyleBackColor = false;
            this.btn_PrintFormT03.Click += new System.EventHandler(this.btn_PrintFormT03_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Date For Id.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_Mismatch
            // 
            this.btn_Mismatch.BackColor = System.Drawing.Color.White;
            this.btn_Mismatch.Enabled = false;
            this.btn_Mismatch.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Mismatch.FlatAppearance.BorderSize = 3;
            this.btn_Mismatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Mismatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mismatch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_Mismatch.Image = global::eMediShop.Properties.Resources.newprinter;
            this.btn_Mismatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mismatch.Location = new System.Drawing.Point(704, 14);
            this.btn_Mismatch.Name = "btn_Mismatch";
            this.btn_Mismatch.Size = new System.Drawing.Size(102, 29);
            this.btn_Mismatch.TabIndex = 11;
            this.btn_Mismatch.Text = "Mismatch";
            this.btn_Mismatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Mismatch.UseVisualStyleBackColor = false;
            this.btn_Mismatch.Click += new System.EventHandler(this.btn_Mismatch_Click);
            // 
            // frmExtraProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(818, 519);
            this.Controls.Add(this.btn_Mismatch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenrateId);
            this.Controls.Add(this.grp_MatchDet);
            this.Controls.Add(this.grp_MisMatch);
            this.Controls.Add(this.btnRcv);
            this.MaximizeBox = false;
            this.Name = "frmExtraProd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Extra Product";
            this.Load += new System.EventHandler(this.frmExtraProd_Load);
            this.grp_MisMatch.ResumeLayout(false);
            this.grp_MatchDet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRcv;
        private System.Windows.Forms.GroupBox grp_MisMatch;
        private System.Windows.Forms.ListView lv_MisMatchDetail;
        private System.Windows.Forms.ColumnHeader master_key_id;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader Pack_size;
        private System.Windows.Forms.ColumnHeader pack_type;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader Shelf_no;
        private System.Windows.Forms.GroupBox grp_MatchDet;
        private System.Windows.Forms.ListView lv_MatchDet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnGenrateId;
        private System.Windows.Forms.Button btnTrfToHO;
        private System.Windows.Forms.ComboBox ddlTrfId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_PrintFormT03;
        private System.Windows.Forms.Button btn_IntSheet;
        private System.Windows.Forms.Button btn_Mismatch;
    }
}