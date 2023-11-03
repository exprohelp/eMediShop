namespace eMediShop
{
    partial class PurchaseSearch
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgvInfo);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Search Vendor [By Name/Purchase Id] Only unPosted Bill";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(704, 500);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Search Vendor [By Name/Purchase Id] Only unPosted Bill";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // rgvInfo
            // 
            this.rgvInfo.BackColor = System.Drawing.SystemColors.Info;
            this.rgvInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rgvInfo.ForeColor = System.Drawing.Color.Black;
            this.rgvInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvInfo.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgvInfo.MasterTemplate.AllowAddNewRow = false;
            this.rgvInfo.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "purch_id";
            gridViewTextBoxColumn1.HeaderText = "ID No";
            gridViewTextBoxColumn1.Name = "Purchase Id";
            gridViewTextBoxColumn1.Width = 191;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "vendor_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Vendor";
            gridViewTextBoxColumn2.Name = "Name of Vendor";
            gridViewTextBoxColumn2.Width = 404;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "nos";
            gridViewTextBoxColumn3.HeaderText = "NoS";
            gridViewTextBoxColumn3.Name = "nos";
            this.rgvInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.rgvInfo.MasterTemplate.EnableGrouping = false;
            this.rgvInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.ReadOnly = true;
            this.rgvInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvInfo.Size = new System.Drawing.Size(700, 480);
            this.rgvInfo.TabIndex = 0;
            this.rgvInfo.Text = "radGridView1";
            this.rgvInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MasterTemplate_KeyUp);
            // 
            // PurchaseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(704, 500);
            this.ControlBox = false;
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseSearch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Search]";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.PurchaseSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseSearch_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgvInfo;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}