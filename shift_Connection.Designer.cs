namespace eMediShop
{
    partial class shift_Connection
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTATA = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSetAirtel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(341, 133);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTATA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(333, 107);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TATA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTATA
            // 
            this.btnTATA.Location = new System.Drawing.Point(106, 28);
            this.btnTATA.Name = "btnTATA";
            this.btnTATA.Size = new System.Drawing.Size(119, 45);
            this.btnTATA.TabIndex = 0;
            this.btnTATA.Text = "SET TATA";
            this.btnTATA.UseVisualStyleBackColor = true;
            this.btnTATA.Click += new System.EventHandler(this.btnTATA_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSetAirtel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(333, 107);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AirTel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSetAirtel
            // 
            this.btnSetAirtel.Location = new System.Drawing.Point(107, 31);
            this.btnSetAirtel.Name = "btnSetAirtel";
            this.btnSetAirtel.Size = new System.Drawing.Size(119, 45);
            this.btnSetAirtel.TabIndex = 1;
            this.btnSetAirtel.Text = "SET AIRTEL";
            this.btnSetAirtel.UseVisualStyleBackColor = true;
            this.btnSetAirtel.Click += new System.EventHandler(this.btnSetAirtel_Click);
            // 
            // shift_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 136);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "shift_Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Connection";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTATA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSetAirtel;
    }
}