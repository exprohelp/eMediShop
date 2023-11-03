namespace eMediShop.Asset
{
    partial class ucTransferAsset
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEqpNo = new System.Windows.Forms.TextBox();
            this.dgAsset = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.tab6DdlUnit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tab6ddlTrfType = new System.Windows.Forms.ComboBox();
            this.tab6BtnTrf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "EQUIPMENT NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // txtEqpNo
            // 
            this.txtEqpNo.Location = new System.Drawing.Point(124, 8);
            this.txtEqpNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEqpNo.Name = "txtEqpNo";
            this.txtEqpNo.Size = new System.Drawing.Size(148, 25);
            this.txtEqpNo.TabIndex = 23;
            // 
            // dgAsset
            // 
            this.dgAsset.BackColor = System.Drawing.SystemColors.Control;
            this.dgAsset.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAsset.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgAsset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgAsset.Location = new System.Drawing.Point(15, 41);
            this.dgAsset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // dgAsset
            // 
            this.dgAsset.MasterTemplate.AllowAddNewRow = false;
            this.dgAsset.MasterTemplate.AutoGenerateColumns = false;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "eq_no";
            gridViewCheckBoxColumn2.HeaderText = "Asset No";
            gridViewCheckBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "eq_no";
            gridViewCheckBoxColumn2.Width = 114;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "eq_name";
            gridViewTextBoxColumn5.HeaderText = "Aseet Name";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "eq_name";
            gridViewTextBoxColumn5.Width = 165;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "eq_category";
            gridViewTextBoxColumn6.HeaderText = "Category";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "eq_category";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 121;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "eq_serial_no";
            gridViewTextBoxColumn7.HeaderText = "Serial Number";
            gridViewTextBoxColumn7.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn7.Name = "eq_serial_no";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 111;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "eq_description";
            gridViewTextBoxColumn8.HeaderText = "Description";
            gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn8.Name = "eq_description";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn8.Width = 400;
            this.dgAsset.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.dgAsset.MasterTemplate.EnableGrouping = false;
            sortDescriptor2.PropertyName = "eq_description";
            this.dgAsset.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAsset.Size = new System.Drawing.Size(953, 361);
            this.dgAsset.TabIndex = 25;
            this.dgAsset.Text = "radGridView2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(821, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Transfer Asset";
            // 
            // btnShow
            // 
            this.btnShow.Image = global::eMediShop.Properties.Resources.click16;
            this.btnShow.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.Location = new System.Drawing.Point(308, 5);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(31, 28);
            this.btnShow.TabIndex = 27;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tab6DdlUnit
            // 
            this.tab6DdlUnit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab6DdlUnit.Location = new System.Drawing.Point(131, 435);
            this.tab6DdlUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab6DdlUnit.Name = "tab6DdlUnit";
            this.tab6DdlUnit.Size = new System.Drawing.Size(678, 24);
            this.tab6DdlUnit.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(71, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Unit :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(12, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Transfer For :";
            // 
            // tab6ddlTrfType
            // 
            this.tab6ddlTrfType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab6ddlTrfType.Items.AddRange(new object[] {
            "Permanent",
            "Temprory"});
            this.tab6ddlTrfType.Location = new System.Drawing.Point(131, 408);
            this.tab6ddlTrfType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab6ddlTrfType.Name = "tab6ddlTrfType";
            this.tab6ddlTrfType.Size = new System.Drawing.Size(156, 24);
            this.tab6ddlTrfType.TabIndex = 29;
            // 
            // tab6BtnTrf
            // 
            this.tab6BtnTrf.BackColor = System.Drawing.Color.Black;
            this.tab6BtnTrf.ForeColor = System.Drawing.Color.Yellow;
            this.tab6BtnTrf.Location = new System.Drawing.Point(860, 423);
            this.tab6BtnTrf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab6BtnTrf.Name = "tab6BtnTrf";
            this.tab6BtnTrf.Size = new System.Drawing.Size(99, 36);
            this.tab6BtnTrf.TabIndex = 28;
            this.tab6BtnTrf.Text = "TRANSFER";
            this.tab6BtnTrf.UseVisualStyleBackColor = false;
            this.tab6BtnTrf.Click += new System.EventHandler(this.tab6BtnTrf_Click);
            // 
            // ucTransferAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab6DdlUnit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tab6ddlTrfType);
            this.Controls.Add(this.tab6BtnTrf);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAsset);
            this.Controls.Add(this.txtEqpNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucTransferAsset";
            this.Size = new System.Drawing.Size(983, 479);
            this.Load += new System.EventHandler(this.ucLodgeComplaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEqpNo;
        private Telerik.WinControls.UI.RadGridView dgAsset;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnShow;
        private System.Windows.Forms.ComboBox tab6DdlUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox tab6ddlTrfType;
        private System.Windows.Forms.Button tab6BtnTrf;
    }
}
