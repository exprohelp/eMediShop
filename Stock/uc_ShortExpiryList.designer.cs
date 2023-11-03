namespace eMediShop.forms.Stock
{
    partial class uc_ShortExpiryList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btn_xl = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.chkIntercompany = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_xl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(210, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(214, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Type  Number of Days For Expiry";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(466, 18);
            this.txtDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(54, 25);
            this.txtDays.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(620, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 26);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Number";
            this.lblTotal.Visible = false;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(5, 54);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_name";
            gridViewTextBoxColumn1.HeaderText = "Name of Product";
            gridViewTextBoxColumn1.Name = "Name of Product";
            gridViewTextBoxColumn1.Width = 306;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "master_key_id";
            gridViewTextBoxColumn2.HeaderText = "Master Key";
            gridViewTextBoxColumn2.Name = "master_key_id";
            gridViewTextBoxColumn2.Width = 136;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pack_type";
            gridViewTextBoxColumn3.HeaderText = "Pack Type";
            gridViewTextBoxColumn3.Name = "Pack Type";
            gridViewTextBoxColumn3.Width = 83;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "batch_no";
            gridViewTextBoxColumn4.HeaderText = "Batch No";
            gridViewTextBoxColumn4.Name = "Batch No";
            gridViewTextBoxColumn4.Width = 87;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "exp_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Expiry";
            gridViewDateTimeColumn1.Name = "Expiry";
            gridViewDateTimeColumn1.Width = 67;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "quantity";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "Qty";
            gridViewDecimalColumn1.Name = "Qty";
            gridViewDecimalColumn1.Width = 69;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "shelf_no";
            gridViewTextBoxColumn5.HeaderText = "Location";
            gridViewTextBoxColumn5.Name = "Location";
            gridViewTextBoxColumn5.Width = 91;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Purch_logic";
            gridViewTextBoxColumn6.HeaderText = "Purch. Logic";
            gridViewTextBoxColumn6.Name = "Purch_logic";
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "vend_info";
            gridViewTextBoxColumn7.HeaderText = "vend_info";
            gridViewTextBoxColumn7.Name = "vend_info";
            gridViewTextBoxColumn7.Width = 200;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "sale_avg_packs";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Sales Avg";
            gridViewDecimalColumn2.Name = "column1";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn2});
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(905, 449);
            this.radGridView1.TabIndex = 8;
            this.radGridView1.Text = "radGridView1";
            // 
            // btn_xl
            // 
            this.btn_xl.Image = global::eMediShop.Properties.Resources.export_excel1;
            this.btn_xl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xl.Location = new System.Drawing.Point(869, 13);
            this.btn_xl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xl.Name = "btn_xl";
            this.btn_xl.Size = new System.Drawing.Size(41, 40);
            this.btn_xl.TabIndex = 10;
            this.btn_xl.Click += new System.EventHandler(this.btn_xl_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_xl.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.export_excel1;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_xl.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_xl.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btn_xl.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::eMediShop.Properties.Resources.click16;
            this.btnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(550, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 31);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSearch.GetChildAt(0))).Image = global::eMediShop.Properties.Resources.click16;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSearch.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSearch.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSearch.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // chkIntercompany
            // 
            this.chkIntercompany.AutoSize = true;
            this.chkIntercompany.Location = new System.Drawing.Point(5, 18);
            this.chkIntercompany.Name = "chkIntercompany";
            this.chkIntercompany.Size = new System.Drawing.Size(116, 21);
            this.chkIntercompany.TabIndex = 11;
            this.chkIntercompany.Text = "Inter Company ";
            this.chkIntercompany.UseVisualStyleBackColor = true;
            // 
            // uc_ShortExpiryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkIntercompany);
            this.Controls.Add(this.btn_xl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_ShortExpiryList";
            this.Size = new System.Drawing.Size(913, 510);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_xl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblTotal;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton btn_xl;
        private System.Windows.Forms.CheckBox chkIntercompany;
    }
}