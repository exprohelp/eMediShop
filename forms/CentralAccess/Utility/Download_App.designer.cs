namespace eMediShop
{
    partial class Download_App
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.cmdDownload = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.pbDownload);
            this.GroupBox1.Controls.Add(this.cmdDownload);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(8, 33);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(387, 137);
            this.GroupBox1.TabIndex = 47;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Downloading";
            // 
            // pbDownload
            // 
            this.pbDownload.Enabled = false;
            this.pbDownload.Location = new System.Drawing.Point(7, 22);
            this.pbDownload.MarqueeAnimationSpeed = 35;
            this.pbDownload.Maximum = 50;
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(372, 23);
            this.pbDownload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbDownload.TabIndex = 52;
            this.pbDownload.Visible = false;
            // 
            // cmdDownload
            // 
            this.cmdDownload.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDownload.Location = new System.Drawing.Point(118, 51);
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(161, 46);
            this.cmdDownload.TabIndex = 23;
            this.cmdDownload.Text = "Download Application";
            this.cmdDownload.UseVisualStyleBackColor = true;
            this.cmdDownload.Click += new System.EventHandler(this.cmdDownload_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 48;
            // 
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 182);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmDownload";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download eMediShop Application";
            this.Load += new System.EventHandler(this.FrmDownload_Load);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ProgressBar pbDownload;
        internal System.Windows.Forms.Button cmdDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;


    }
}