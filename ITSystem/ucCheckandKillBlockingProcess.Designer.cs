namespace eMediShop.ITSystem
{
    partial class ucCheckandKillBlockingProcess
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btnGet = new Telerik.WinControls.UI.RadButton();
            this.btnKill = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKill)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_info
            // 
            this.rgv_info.Location = new System.Drawing.Point(4, 76);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.Size = new System.Drawing.Size(1053, 446);
            this.rgv_info.TabIndex = 0;
            this.rgv_info.Text = "radGridView1";
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(4, 18);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(78, 52);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get Info";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnKill
            // 
            this.btnKill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Location = new System.Drawing.Point(960, 18);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(97, 52);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "Kill Process";
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // ucCheckandKillBlockingProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucCheckandKillBlockingProcess";
            this.Size = new System.Drawing.Size(1060, 525);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btnGet;
        private Telerik.WinControls.UI.RadButton btnKill;
    }
}
