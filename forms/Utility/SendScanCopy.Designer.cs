namespace eMediShop
{
    partial class SendScanCopy
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
            this.components = new System.ComponentModel.Container();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReffresh = new System.Windows.Forms.Button();
            this.cbxSearched = new System.Windows.Forms.ComboBox();
            this.txtkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSendMessage = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.cbxEmpForMessage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(573, 219);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 26);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(573, 265);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 26);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Transfer";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(85, 219);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(482, 26);
            this.txtFileName.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eMediShop.Properties.Resources.yahoo_loading;
            this.pictureBox1.Location = new System.Drawing.Point(263, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 33);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnReffresh);
            this.groupBox1.Controls.Add(this.cbxSearched);
            this.groupBox1.Controls.Add(this.txtkey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Staff";
            this.groupBox1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(251, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = ">>";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReffresh
            // 
            this.btnReffresh.Location = new System.Drawing.Point(555, 26);
            this.btnReffresh.Name = "btnReffresh";
            this.btnReffresh.Size = new System.Drawing.Size(75, 28);
            this.btnReffresh.TabIndex = 5;
            this.btnReffresh.Text = "Add";
            this.btnReffresh.UseVisualStyleBackColor = true;
            this.btnReffresh.Click += new System.EventHandler(this.btnReffresh_Click);
            // 
            // cbxSearched
            // 
            this.cbxSearched.FormattingEnabled = true;
            this.cbxSearched.Location = new System.Drawing.Point(289, 25);
            this.cbxSearched.Name = "cbxSearched";
            this.cbxSearched.Size = new System.Drawing.Size(260, 28);
            this.cbxSearched.TabIndex = 4;
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(98, 28);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(147, 25);
            this.txtkey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Name";
            // 
            // chkSendMessage
            // 
            this.chkSendMessage.AutoSize = true;
            this.chkSendMessage.BackColor = System.Drawing.Color.Transparent;
            this.chkSendMessage.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSendMessage.Location = new System.Drawing.Point(12, 12);
            this.chkSendMessage.Name = "chkSendMessage";
            this.chkSendMessage.Size = new System.Drawing.Size(116, 24);
            this.chkSendMessage.TabIndex = 10;
            this.chkSendMessage.Text = "Send Message";
            this.chkSendMessage.UseVisualStyleBackColor = false;
            this.chkSendMessage.CheckedChanged += new System.EventHandler(this.chkSendMessage_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAddStaff);
            this.groupBox2.Controls.Add(this.cbxEmpForMessage);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 48);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Name of Staff For Message Deliver";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(556, 19);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 12;
            this.btnAddStaff.Text = "Search Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxEmpForMessage
            // 
            this.cbxEmpForMessage.FormattingEnabled = true;
            this.cbxEmpForMessage.Location = new System.Drawing.Point(68, 18);
            this.cbxEmpForMessage.Name = "cbxEmpForMessage";
            this.cbxEmpForMessage.Size = new System.Drawing.Size(269, 24);
            this.cbxEmpForMessage.TabIndex = 11;
            this.cbxEmpForMessage.SelectedIndexChanged += new System.EventHandler(this.cbxEmpForMessage_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Send To";
            // 
            // SendScanCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eMediShop.Properties.Resources.Blue_hills;
            this.ClientSize = new System.Drawing.Size(660, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkSendMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btn_browse);
            this.MaximizeBox = false;
            this.Name = "SendScanCopy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Send Scan Copy to Head Office ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendScanCopy_FormClosing);
            this.Load += new System.EventHandler(this.SendScanCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReffresh;
        private System.Windows.Forms.ComboBox cbxSearched;
        private System.Windows.Forms.TextBox txtkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSendMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ComboBox cbxEmpForMessage;
        private System.Windows.Forms.Label label3;
    }
}