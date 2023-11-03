namespace WindowsFormsApplication1
{
    partial class uploadexcel
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnupload = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rdgrid = new Telerik.WinControls.UI.RadGridView();
            this.lblfilename = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnupload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblfilename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(104, 29);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(82, 24);
            this.btnupload.TabIndex = 0;
            this.btnupload.Text = "Upload File";
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 29);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Select File";
            // 
            // rdgrid
            // 
            this.rdgrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rdgrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgrid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rdgrid.ForeColor = System.Drawing.Color.Black;
            this.rdgrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdgrid.Location = new System.Drawing.Point(1, 75);
            // 
            // 
            // 
            this.rdgrid.MasterTemplate.AllowAddNewRow = false;
            this.rdgrid.MasterTemplate.EnableGrouping = false;
            this.rdgrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rdgrid.Name = "rdgrid";
            this.rdgrid.ReadOnly = true;
            this.rdgrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgrid.Size = new System.Drawing.Size(786, 452);
            this.rdgrid.TabIndex = 1;
            this.rdgrid.Text = "radGridView1";
            // 
            // lblfilename
            // 
            this.lblfilename.Location = new System.Drawing.Point(192, 35);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(55, 18);
            this.lblfilename.TabIndex = 2;
            this.lblfilename.Text = "radLabel2";
            // 
            // uploadexcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 533);
            this.Controls.Add(this.lblfilename);
            this.Controls.Add(this.rdgrid);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnupload);
            this.Name = "uploadexcel";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "uploadexcel";
            this.Load += new System.EventHandler(this.uploadexcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnupload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblfilename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadButton btnupload;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView rdgrid;
        private Telerik.WinControls.UI.RadLabel lblfilename;

    }
}
