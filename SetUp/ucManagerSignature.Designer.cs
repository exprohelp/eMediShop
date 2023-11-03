namespace eMediShop.SetUp
{
    partial class ucManagerSignature
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnImportSignature = new Telerik.WinControls.UI.RadButton();
            this.pic_sign = new System.Windows.Forms.PictureBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImportSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sign)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pic_sign);
            this.groupBox5.Controls.Add(this.btnImportSignature);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(513, 120);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manager Signature";
            // 
            // btnImportSignature
            // 
            this.btnImportSignature.Location = new System.Drawing.Point(8, 34);
            this.btnImportSignature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportSignature.Name = "btnImportSignature";
            this.btnImportSignature.Size = new System.Drawing.Size(147, 55);
            this.btnImportSignature.TabIndex = 120;
            this.btnImportSignature.Text = "Import Signature";
            this.btnImportSignature.Click += new System.EventHandler(this.btnImportSignature_Click);
            // 
            // pic_sign
            // 
            this.pic_sign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_sign.Location = new System.Drawing.Point(359, 19);
            this.pic_sign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_sign.Name = "pic_sign";
            this.pic_sign.Size = new System.Drawing.Size(139, 91);
            this.pic_sign.TabIndex = 121;
            this.pic_sign.TabStop = false;
            // 
            // ucManagerSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucManagerSignature";
            this.Size = new System.Drawing.Size(547, 146);
            this.Load += new System.EventHandler(this.ucManagerSignature_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnImportSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pic_sign;
        private Telerik.WinControls.UI.RadButton btnImportSignature;
    }
}
