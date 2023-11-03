namespace eMediShop.forms.Product
{
    partial class BlockedProducts
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.getListButton = new Telerik.WinControls.UI.RadButton();
            this.exprotXLbutton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exprotXLbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.exprotXLbutton);
            this.radGroupBox1.Controls.Add(this.getListButton);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(605, 57);
            this.radGroupBox1.TabIndex = 0;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.Color.Black;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(0, 63);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item Id";
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.Width = 74;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 366;
            gridViewTextBoxColumn3.AllowFiltering = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pack_type";
            gridViewTextBoxColumn3.HeaderText = "Pack Type";
            gridViewTextBoxColumn3.Name = "pack_type";
            gridViewTextBoxColumn3.Width = 82;
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "pack_qty";
            gridViewDecimalColumn1.HeaderText = "Pack Qty";
            gridViewDecimalColumn1.Name = "pack_qty";
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1});
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(605, 387);
            this.rgv_info.TabIndex = 1;
            this.rgv_info.Text = "radGridView1";
            // 
            // getListButton
            // 
            this.getListButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getListButton.Location = new System.Drawing.Point(6, 3);
            this.getListButton.Name = "getListButton";
            this.getListButton.Size = new System.Drawing.Size(79, 49);
            this.getListButton.TabIndex = 0;
            this.getListButton.Text = "Get List";
            this.getListButton.Click += new System.EventHandler(this.getListButton_Click);
            // 
            // exprotXLbutton
            // 
            this.exprotXLbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exprotXLbutton.Image = global::eMediShop.Properties.Resources.export_excel;
            this.exprotXLbutton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.exprotXLbutton.Location = new System.Drawing.Point(550, 3);
            this.exprotXLbutton.Name = "exprotXLbutton";
            this.exprotXLbutton.Size = new System.Drawing.Size(50, 49);
            this.exprotXLbutton.TabIndex = 1;
            this.exprotXLbutton.Click += new System.EventHandler(this.exprotXLbutton_Click);
            // 
            // BlockedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BlockedProducts";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Blocked Product For Purchase Information";
            this.Load += new System.EventHandler(this.BlockedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getListButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exprotXLbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton exprotXLbutton;
        private Telerik.WinControls.UI.RadButton getListButton;
        private Telerik.WinControls.UI.RadGridView rgv_info;
    }
}
