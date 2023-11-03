namespace eMediShop
{
    partial class PurchCheckListReconsile
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
            this.dgCheckList = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Particular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Received = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SRTQTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RunBal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCurStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblrunBal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dgCheckList
            // 
            this.dgCheckList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgCheckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Particular,
            this.Received,
            this.SRTQTY,
            this.RunBal});
            this.dgCheckList.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCheckList.FullRowSelect = true;
            this.dgCheckList.GridLines = true;
            this.dgCheckList.Location = new System.Drawing.Point(2, 33);
            this.dgCheckList.Name = "dgCheckList";
            this.dgCheckList.Size = new System.Drawing.Size(681, 260);
            this.dgCheckList.TabIndex = 3;
            this.dgCheckList.UseCompatibleStateImageBehavior = false;
            this.dgCheckList.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 99;
            // 
            // Particular
            // 
            this.Particular.Text = "Particular";
            this.Particular.Width = 294;
            // 
            // Received
            // 
            this.Received.Text = "Received Qty";
            this.Received.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Received.Width = 97;
            // 
            // SRTQTY
            // 
            this.SRTQTY.Text = "S/R Qty";
            this.SRTQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SRTQTY.Width = 83;
            // 
            // RunBal
            // 
            this.RunBal.Text = "RunBalance";
            this.RunBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RunBal.Width = 85;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 295);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(681, 16);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblCurStock
            // 
            this.lblCurStock.AutoSize = true;
            this.lblCurStock.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurStock.Location = new System.Drawing.Point(3, 7);
            this.lblCurStock.Name = "lblCurStock";
            this.lblCurStock.Size = new System.Drawing.Size(0, 17);
            this.lblCurStock.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(397, 8);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 17);
            this.lblStock.TabIndex = 6;
            // 
            // lblrunBal
            // 
            this.lblrunBal.AutoSize = true;
            this.lblrunBal.Font = new System.Drawing.Font("Calibri", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrunBal.Location = new System.Drawing.Point(550, 7);
            this.lblrunBal.Name = "lblrunBal";
            this.lblrunBal.Size = new System.Drawing.Size(0, 17);
            this.lblrunBal.TabIndex = 7;
            // 
            // PurchCheckListReconsile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.lblrunBal);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCurStock);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgCheckList);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PurchCheckListReconsile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reconcilation of Stock At Server";
            this.Load += new System.EventHandler(this.PurchCheckListReconsile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchCheckListReconsile_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dgCheckList;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Particular;
        private System.Windows.Forms.ColumnHeader Received;
        private System.Windows.Forms.ColumnHeader SRTQTY;
        private System.Windows.Forms.ColumnHeader RunBal;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCurStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblrunBal;
    }
}