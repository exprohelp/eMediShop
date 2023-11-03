namespace eMediShop.Substitute
{
    partial class UploadSubstitute_Control
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
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.btnBrowse = new Telerik.WinControls.UI.RadButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = global::eMediShop.Properties.Resources.Save_16;
            this.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(5, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 38);
            this.btnSave.TabIndex = 63;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.Save_16;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Location = new System.Drawing.Point(181, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 28);
            this.btnBrowse.TabIndex = 62;
            this.btnBrowse.Text = "Link";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowse.GetChildAt(0))).Image = null;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowse.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowse.GetChildAt(0))).Text = "Link";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnBrowse.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(62, 159);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(37, 15);
            this.lblMsg.TabIndex = 61;
            this.lblMsg.Text = "XXXXX";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.txtpath);
            this.radPanel1.Controls.Add(this.pictureBox1);
            this.radPanel1.Controls.Add(this.btnSave);
            this.radPanel1.Controls.Add(this.lblMsg);
            this.radPanel1.Controls.Add(this.btnBrowse);
            this.radPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.radPanel1.Location = new System.Drawing.Point(3, 2);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(490, 184);
            this.radPanel1.TabIndex = 67;
            // 
            // txtpath
            // 
            this.txtpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpath.Enabled = false;
            this.txtpath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpath.Location = new System.Drawing.Point(5, 11);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(172, 25);
            this.txtpath.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(225, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 177);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // UploadSubstitute_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UploadSubstitute_Control";
            this.Size = new System.Drawing.Size(498, 196);
            this.Load += new System.EventHandler(this.ucUploadScanedDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private Telerik.WinControls.UI.RadButton btnBrowse;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpath;

    }
}
