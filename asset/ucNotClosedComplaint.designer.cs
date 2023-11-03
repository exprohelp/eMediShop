namespace eMediShop.Asset
{
    partial class ucNotClosedComplaint
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgAsset = new Telerik.WinControls.UI.RadGridView();
            this.btnGetNotClosed = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAsset
            // 
            this.dgAsset.BackColor = System.Drawing.SystemColors.Control;
            this.dgAsset.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAsset.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgAsset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgAsset.Location = new System.Drawing.Point(10, 60);
            this.dgAsset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.dgAsset.MasterTemplate.AllowAddNewRow = false;
            this.dgAsset.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "auto_id";
            gridViewTextBoxColumn1.HeaderText = "column1";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "auto_id";
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "eq_no";
            gridViewCheckBoxColumn1.HeaderText = "Asset No";
            gridViewCheckBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "eq_no";
            gridViewCheckBoxColumn1.Width = 114;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "eq_name";
            gridViewTextBoxColumn2.HeaderText = "Aseet Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "eq_name";
            gridViewTextBoxColumn2.Width = 165;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "to_address";
            gridViewTextBoxColumn3.HeaderText = "Transfer To";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "to_address";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 480;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "trf_date";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "Trf Date";
            gridViewDateTimeColumn1.Name = "trf_date";
            gridViewDateTimeColumn1.Width = 91;
            gridViewCommandColumn1.HeaderText = "Print";
            gridViewCommandColumn1.Name = "column1";
            this.dgAsset.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn1,
            gridViewCommandColumn1});
            this.dgAsset.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "eq_description";
            this.dgAsset.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgAsset.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAsset.Size = new System.Drawing.Size(942, 447);
            this.dgAsset.TabIndex = 25;
            this.dgAsset.Text = "radGridView2";
            // 
            // btnGetNotClosed
            // 
            this.btnGetNotClosed.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetNotClosed.ForeColor = System.Drawing.Color.Black;
            this.btnGetNotClosed.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGetNotClosed.Location = new System.Drawing.Point(10, 16);
            this.btnGetNotClosed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetNotClosed.Name = "btnGetNotClosed";
            this.btnGetNotClosed.Size = new System.Drawing.Size(232, 32);
            this.btnGetNotClosed.TabIndex = 26;
            this.btnGetNotClosed.Text = "GET NOT CLOSED COMPLAINT";
            this.btnGetNotClosed.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::eMediShop.Properties.Resources.export_excel;
            this.button3.Location = new System.Drawing.Point(895, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 50);
            this.button3.TabIndex = 27;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ucNotClosedComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGetNotClosed);
            this.Controls.Add(this.dgAsset);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucNotClosedComplaint";
            this.Size = new System.Drawing.Size(960, 510);
            this.Load += new System.EventHandler(this.ucLodgeComplaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgAsset;
        private System.Windows.Forms.Button btnGetNotClosed;
        private System.Windows.Forms.Button button3;
    }
}
