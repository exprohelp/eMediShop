namespace eMediShop
{
    partial class SearchStaff
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
            this.cbxEmpForMessage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReffresh = new System.Windows.Forms.Button();
            this.cbxSearched = new System.Windows.Forms.ComboBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Name For Message";
            // 
            // cbxEmpForMessage
            // 
            this.cbxEmpForMessage.FormattingEnabled = true;
            this.cbxEmpForMessage.Location = new System.Drawing.Point(174, 27);
            this.cbxEmpForMessage.Name = "cbxEmpForMessage";
            this.cbxEmpForMessage.Size = new System.Drawing.Size(269, 21);
            this.cbxEmpForMessage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Name";
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(77, 23);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(84, 20);
            this.txtkey.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnReffresh);
            this.groupBox1.Controls.Add(this.cbxSearched);
            this.groupBox1.Controls.Add(this.txtkey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Staff";
            this.groupBox1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(167, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = ">>";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReffresh
            // 
            this.btnReffresh.Location = new System.Drawing.Point(442, 23);
            this.btnReffresh.Name = "btnReffresh";
            this.btnReffresh.Size = new System.Drawing.Size(75, 23);
            this.btnReffresh.TabIndex = 5;
            this.btnReffresh.Text = "Reffresh";
            this.btnReffresh.UseVisualStyleBackColor = true;
            this.btnReffresh.Click += new System.EventHandler(this.btnReffresh_Click);
            // 
            // cbxSearched
            // 
            this.cbxSearched.FormattingEnabled = true;
            this.cbxSearched.Location = new System.Drawing.Point(213, 23);
            this.cbxSearched.Name = "cbxSearched";
            this.cbxSearched.Size = new System.Drawing.Size(220, 21);
            this.cbxSearched.TabIndex = 4;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(449, 25);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 6;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // SearchStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 167);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxEmpForMessage);
            this.Controls.Add(this.label1);
            this.Name = "SearchStaff";
            this.Text = "Search Staff";
            this.Load += new System.EventHandler(this.SearchStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEmpForMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReffresh;
        private System.Windows.Forms.ComboBox cbxSearched;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnSearch;
    }
}