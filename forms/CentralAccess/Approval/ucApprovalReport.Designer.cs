namespace eMediShop
{
    partial class ucApprovalReport
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
            this.lvDetail = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cr_by = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doc_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CrDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRemark = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.rdbtnAll = new System.Windows.Forms.RadioButton();
            this.rdbtnApp = new System.Windows.Forms.RadioButton();
            this.rdbtnCancelled = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDetail
            // 
            this.lvDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.cr_by,
            this.amount,
            this.date,
            this.doc_path,
            this.Path});
            this.lvDetail.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDetail.FullRowSelect = true;
            this.lvDetail.GridLines = true;
            this.lvDetail.Location = new System.Drawing.Point(10, 88);
            this.lvDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(733, 190);
            this.lvDetail.TabIndex = 20;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            this.lvDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvDetail_KeyDown);
            this.lvDetail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDetail_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "";
            this.id.Width = 0;
            // 
            // cr_by
            // 
            this.cr_by.Text = "Created by";
            this.cr_by.Width = 412;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 106;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 97;
            // 
            // doc_path
            // 
            this.doc_path.Text = "Document";
            this.doc_path.Width = 85;
            // 
            // Path
            // 
            this.Path.Text = "";
            this.Path.Width = 0;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(9, 441);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(734, 50);
            this.txtRemark.TabIndex = 24;
            // 
            // Remark
            // 
            this.Remark.Text = "Remark";
            this.Remark.Width = 517;
            // 
            // CrDate
            // 
            this.CrDate.Text = "Date";
            this.CrDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CrDate.Width = 185;
            // 
            // lvRemark
            // 
            this.lvRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRemark.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Remark,
            this.CrDate});
            this.lvRemark.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRemark.FullRowSelect = true;
            this.lvRemark.GridLines = true;
            this.lvRemark.Location = new System.Drawing.Point(9, 285);
            this.lvRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvRemark.Name = "lvRemark";
            this.lvRemark.Size = new System.Drawing.Size(734, 149);
            this.lvRemark.TabIndex = 23;
            this.lvRemark.UseCompatibleStateImageBehavior = false;
            this.lvRemark.View = System.Windows.Forms.View.Details;
            this.lvRemark.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvRemark_ItemSelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "From";
            // 
            // dtfrom
            // 
            this.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfrom.Location = new System.Drawing.Point(289, 17);
            this.dtfrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(102, 25);
            this.dtfrom.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "To";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Wheat;
            this.btnView.Location = new System.Drawing.Point(665, 13);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(69, 31);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(433, 18);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(108, 25);
            this.dtTo.TabIndex = 14;
            // 
            // rdbtnAll
            // 
            this.rdbtnAll.AutoSize = true;
            this.rdbtnAll.Location = new System.Drawing.Point(188, 18);
            this.rdbtnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnAll.Name = "rdbtnAll";
            this.rdbtnAll.Size = new System.Drawing.Size(46, 21);
            this.rdbtnAll.TabIndex = 18;
            this.rdbtnAll.Text = "ALL";
            this.rdbtnAll.UseVisualStyleBackColor = true;
            // 
            // rdbtnApp
            // 
            this.rdbtnApp.AutoSize = true;
            this.rdbtnApp.Checked = true;
            this.rdbtnApp.Location = new System.Drawing.Point(14, 18);
            this.rdbtnApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnApp.Name = "rdbtnApp";
            this.rdbtnApp.Size = new System.Drawing.Size(84, 21);
            this.rdbtnApp.TabIndex = 19;
            this.rdbtnApp.TabStop = true;
            this.rdbtnApp.Text = "Approved";
            this.rdbtnApp.UseVisualStyleBackColor = true;
            // 
            // rdbtnCancelled
            // 
            this.rdbtnCancelled.AutoSize = true;
            this.rdbtnCancelled.Location = new System.Drawing.Point(101, 18);
            this.rdbtnCancelled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnCancelled.Name = "rdbtnCancelled";
            this.rdbtnCancelled.Size = new System.Drawing.Size(82, 21);
            this.rdbtnCancelled.TabIndex = 20;
            this.rdbtnCancelled.Text = "Cancelled";
            this.rdbtnCancelled.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdbtnCancelled);
            this.groupBox1.Controls.Add(this.rdbtnApp);
            this.groupBox1.Controls.Add(this.rdbtnAll);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtfrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(734, 52);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Press Ctr+D to download document attached with selected aproovals";
            // 
            // ucApprovalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lvRemark);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvDetail);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucApprovalReport";
            this.Size = new System.Drawing.Size(751, 520);
            this.Load += new System.EventHandler(this.ucApprovalReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader cr_by;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.ColumnHeader CrDate;
        private System.Windows.Forms.ListView lvRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.RadioButton rdbtnAll;
        private System.Windows.Forms.RadioButton rdbtnApp;
        private System.Windows.Forms.RadioButton rdbtnCancelled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader doc_path;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Label label1;
    }

}