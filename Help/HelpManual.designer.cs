
    partial class HelpManual
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
            this.radPdfViewer2 = new Telerik.WinControls.UI.RadPdfViewer();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radPdfViewerNavigator1 = new Telerik.WinControls.UI.RadPdfViewerNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPdfViewer2
            // 
            this.radPdfViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPdfViewer2.Location = new System.Drawing.Point(76, 44);
            this.radPdfViewer2.Name = "radPdfViewer2";
            this.radPdfViewer2.ReadingMode = Telerik.WinControls.UI.ReadingMode.OnDemand;
            this.radPdfViewer2.Size = new System.Drawing.Size(822, 480);
            this.radPdfViewer2.TabIndex = 0;
            this.radPdfViewer2.Text = "radPdfViewer2";
            this.radPdfViewer2.ThumbnailsScaleFactor = 0.15F;
            this.radPdfViewer2.ViewerMode = Telerik.WinControls.UI.FixedDocumentViewerMode.TextSelection;
            // 
            // radPdfViewerNavigator1
            // 
            this.radPdfViewerNavigator1.AssociatedViewer = this.radPdfViewer2;
            this.radPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPdfViewerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radPdfViewerNavigator1.Name = "radPdfViewerNavigator1";
            this.radPdfViewerNavigator1.Size = new System.Drawing.Size(898, 38);
            this.radPdfViewerNavigator1.TabIndex = 1;
            this.radPdfViewerNavigator1.Text = "radPdfViewerNavigator1";
            // 
            // HelpManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 524);
            this.Controls.Add(this.radPdfViewerNavigator1);
            this.Controls.Add(this.radPdfViewer2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Name = "HelpManual";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eMediShop Manual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer2;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadPdfViewerNavigator radPdfViewerNavigator1;
    }

