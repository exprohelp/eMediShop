namespace eMediShop
{
    partial class ucImportApprovals
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cr_by = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(636, 460);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 33);
            this.btnImport.TabIndex = 18;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Wheat;
            this.btnView.Location = new System.Drawing.Point(10, 4);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(69, 31);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lvDetail
            // 
            this.lvDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDetail.CheckBoxes = true;
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Remark,
            this.expName,
            this.cr_by,
            this.amount,
            this.date});
            this.lvDetail.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDetail.FullRowSelect = true;
            this.lvDetail.GridLines = true;
            this.lvDetail.Location = new System.Drawing.Point(12, 41);
            this.lvDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(734, 411);
            this.lvDetail.TabIndex = 12;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "";
            this.id.Width = 22;
            // 
            // Remark
            // 
            this.Remark.Text = "Remark";
            this.Remark.Width = 385;
            // 
            // expName
            // 
            this.expName.Text = "Expense Name";
            this.expName.Width = 0;
            // 
            // cr_by
            // 
            this.cr_by.Text = "Created by";
            this.cr_by.Width = 120;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 86;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 86;
            // 
            // ucImportApprovals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lvDetail);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucImportApprovals";
            this.Size = new System.Drawing.Size(758, 503);
            this.Load += new System.EventHandler(this.ucImportApprovals_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader expName;
        private System.Windows.Forms.ColumnHeader cr_by;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader Remark;
    }
}