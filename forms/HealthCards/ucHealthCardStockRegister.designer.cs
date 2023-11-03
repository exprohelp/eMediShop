namespace eMediShop.forms.HealthCards
{
    partial class ucHealthCardStockRegister
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnxl = new Telerik.WinControls.UI.RadButton();
            this.rgv_cardInfo = new Telerik.WinControls.UI.RadGridView();
            this.btn_click = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnxl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cardInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cardInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_click)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnxl);
            this.radGroupBox1.Controls.Add(this.rgv_cardInfo);
            this.radGroupBox1.Controls.Add(this.btn_click);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Health Card Stock";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(263, 541);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Health Card Stock";
            // 
            // btnxl
            // 
            this.btnxl.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnxl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxl.Location = new System.Drawing.Point(210, 31);
            this.btnxl.Name = "btnxl";
            this.btnxl.Size = new System.Drawing.Size(45, 36);
            this.btnxl.TabIndex = 2;
            this.btnxl.Text = "Click";
            this.btnxl.Click += new System.EventHandler(this.btnxl_Click);
            // 
            // rgv_cardInfo
            // 
            this.rgv_cardInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_cardInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_cardInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_cardInfo.ForeColor = System.Drawing.Color.Black;
            this.rgv_cardInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_cardInfo.Location = new System.Drawing.Point(6, 72);
            // 
            // 
            // 
            this.rgv_cardInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "card_no";
            gridViewTextBoxColumn1.HeaderText = "Health Card No.";
            gridViewTextBoxColumn1.Name = "card_no";
            gridViewTextBoxColumn1.Width = 204;
            this.rgv_cardInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.rgv_cardInfo.MasterTemplate.EnableFiltering = true;
            this.rgv_cardInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_cardInfo.Name = "rgv_cardInfo";
            this.rgv_cardInfo.ReadOnly = true;
            this.rgv_cardInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_cardInfo.ShowGroupPanel = false;
            this.rgv_cardInfo.Size = new System.Drawing.Size(248, 464);
            this.rgv_cardInfo.TabIndex = 1;
            this.rgv_cardInfo.Text = "radGridView1";
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(6, 32);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(37, 33);
            this.btn_click.TabIndex = 0;
            this.btn_click.Text = "Click";
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // ucHealthCardStockRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "ucHealthCardStockRegister";
            this.Size = new System.Drawing.Size(270, 545);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnxl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cardInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_cardInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_click)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgv_cardInfo;
        private Telerik.WinControls.UI.RadButton btn_click;
        private Telerik.WinControls.UI.RadButton btnxl;
    }
}
