namespace eMediShop
{
    partial class ucUploadScanedDoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.btnBrowse = new Telerik.WinControls.UI.RadButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtDocType = new System.Windows.Forms.TextBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.txtDocId = new System.Windows.Forms.TextBox();

            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.txtDocType);
            this.groupBox1.Controls.Add(this.txtpath);
            this.groupBox1.Controls.Add(this.txtDocId);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 46);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::eMediShop.Properties.Resources.UploadScan_32;
            this.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Location = new System.Drawing.Point(663, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 34);
            this.btnSave.TabIndex = 63;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.UploadScan_32;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Image = global::eMediShop.Properties.Resources.file_search;
            this.btnBrowse.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Location = new System.Drawing.Point(592, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(38, 34);
            this.btnBrowse.TabIndex = 62;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(703, 18);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(37, 15);
            this.lblMsg.TabIndex = 61;
            this.lblMsg.Text = "XXXXX";
            // 
            // txtDocType
            // 
            this.txtDocType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDocType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocType.Enabled = false;
            this.txtDocType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocType.Location = new System.Drawing.Point(6, 15);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.Size = new System.Drawing.Size(140, 25);
            this.txtDocType.TabIndex = 60;
            // 
            // txtpath
            // 
            this.txtpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpath.Enabled = false;
            this.txtpath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpath.Location = new System.Drawing.Point(300, 15);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(286, 25);
            this.txtpath.TabIndex = 54;
            // 
            // txtDocId
            // 
            this.txtDocId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDocId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocId.Enabled = false;
            this.txtDocId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocId.Location = new System.Drawing.Point(152, 15);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.Size = new System.Drawing.Size(142, 25);
            this.txtDocId.TabIndex = 59;
            // 
            // ucUploadScanedDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucUploadScanedDoc";
            this.Size = new System.Drawing.Size(864, 72);
            this.Load += new System.EventHandler(this.ucUploadScanedDoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDocType;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label lblMsg;

        private Telerik.WinControls.UI.RadButton btnBrowse;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.EllipseShape ellipseShape1;

    }
}
