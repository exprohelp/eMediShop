namespace eMediShop.Asset
{
    partial class ucPrintTransferForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.dgAsset = new Telerik.WinControls.UI.RadGridView();
            this.gbxDate = new System.Windows.Forms.GroupBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).BeginInit();
            this.gbxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAsset
            // 
            this.dgAsset.BackColor = System.Drawing.SystemColors.Control;
            this.dgAsset.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAsset.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgAsset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgAsset.Location = new System.Drawing.Point(5, 56);
            this.dgAsset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // dgAsset
            // 
            this.dgAsset.MasterTemplate.AllowAddNewRow = false;
            this.dgAsset.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "auto_id";
            gridViewTextBoxColumn4.HeaderText = "column1";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "auto_id";
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
            gridViewTextBoxColumn6.FieldName = "to_address";
            gridViewTextBoxColumn6.HeaderText = "Transfer To";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "to_address";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 480;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "trf_date";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "Trf Date";
            gridViewDateTimeColumn2.Name = "trf_date";
            gridViewDateTimeColumn2.Width = 91;
            gridViewCommandColumn2.HeaderText = "Print";
            gridViewCommandColumn2.Name = "column1";
            this.dgAsset.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn2,
            gridViewCommandColumn2});
            this.dgAsset.MasterTemplate.EnableGrouping = false;
            sortDescriptor2.PropertyName = "eq_description";
            this.dgAsset.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAsset.Size = new System.Drawing.Size(940, 448);
            this.dgAsset.TabIndex = 25;
            this.dgAsset.Text = "radGridView2";
            this.dgAsset.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // gbxDate
            // 
            this.gbxDate.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDate.Controls.Add(this.dtFrom);
            this.gbxDate.Controls.Add(this.label16);
            this.gbxDate.Controls.Add(this.btnGo);
            this.gbxDate.Controls.Add(this.label17);
            this.gbxDate.Controls.Add(this.dtTo);
            this.gbxDate.Location = new System.Drawing.Point(4, 3);
            this.gbxDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDate.Name = "gbxDate";
            this.gbxDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDate.Size = new System.Drawing.Size(940, 49);
            this.gbxDate.TabIndex = 26;
            this.gbxDate.TabStop = false;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(54, 12);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(100, 25);
            this.dtFrom.TabIndex = 244;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(177, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 17);
            this.label16.TabIndex = 243;
            this.label16.Text = "To";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.LightCoral;
            this.btnGo.Image = global::eMediShop.Properties.Resources.click16;
            this.btnGo.Location = new System.Drawing.Point(332, 10);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(61, 35);
            this.btnGo.TabIndex = 242;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(8, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.TabIndex = 241;
            this.label17.Text = "From";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(210, 12);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(101, 25);
            this.dtTo.TabIndex = 240;
            // 
            // ucPrintTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxDate);
            this.Controls.Add(this.dgAsset);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucPrintTransferForm";
            this.Size = new System.Drawing.Size(950, 510);
            this.Load += new System.EventHandler(this.ucLodgeComplaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            this.gbxDate.ResumeLayout(false);
            this.gbxDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgAsset;
        private System.Windows.Forms.GroupBox gbxDate;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtTo;
    }
}
