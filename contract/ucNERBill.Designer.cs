namespace eMediShop.contract
{
    partial class ucNERBill
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNERBill));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgCriteria = new Telerik.WinControls.UI.RadGroupBox();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            this.rdtpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdtpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgCriteria)).BeginInit();
            this.rgCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgCriteria
            // 
            this.rgCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgCriteria.Controls.Add(this.btnGo);
            this.rgCriteria.Controls.Add(this.rdtpTo);
            this.rgCriteria.Controls.Add(this.rdtpFrom);
            this.rgCriteria.Controls.Add(this.label1);
            this.rgCriteria.Controls.Add(this.label2);
            this.rgCriteria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgCriteria.HeaderText = "";
            this.rgCriteria.Location = new System.Drawing.Point(3, 3);
            this.rgCriteria.Name = "rgCriteria";
            this.rgCriteria.Size = new System.Drawing.Size(403, 56);
            this.rgCriteria.TabIndex = 4;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(350, 14);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(41, 24);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = ">>";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // rdtpTo
            // 
            this.rdtpTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtpTo.Location = new System.Drawing.Point(225, 13);
            this.rdtpTo.Name = "rdtpTo";
            this.rdtpTo.Size = new System.Drawing.Size(107, 25);
            this.rdtpTo.TabIndex = 4;
            this.rdtpTo.TabStop = false;
            this.rdtpTo.Text = "16-01-2024";
            this.rdtpTo.Value = new System.DateTime(2024, 1, 16, 14, 10, 12, 459);
            // 
            // rdtpFrom
            // 
            this.rdtpFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtpFrom.Location = new System.Drawing.Point(55, 13);
            this.rdtpFrom.Name = "rdtpFrom";
            this.rdtpFrom.Size = new System.Drawing.Size(107, 25);
            this.rdtpFrom.TabIndex = 3;
            this.rdtpFrom.TabStop = false;
            this.rdtpFrom.Text = "16-01-2024";
            this.rdtpFrom.Value = new System.DateTime(2024, 1, 16, 14, 10, 12, 459);
            this.rdtpFrom.Leave += new System.EventHandler(this.rdtpFrom_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(4, 65);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "sale_inv_no";
            gridViewTextBoxColumn1.HeaderText = "Sale Inv No";
            gridViewTextBoxColumn1.Name = "sale_inv_no";
            gridViewTextBoxColumn1.Width = 146;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "category";
            gridViewTextBoxColumn2.HeaderText = "Category";
            gridViewTextBoxColumn2.Name = "category";
            gridViewTextBoxColumn2.Width = 153;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Nos";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "NoS";
            gridViewDecimalColumn1.Name = "Nos";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewCommandColumn1.Width = 25;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn1,
            gridViewCommandColumn1});
            sortDescriptor1.PropertyName = "column1";
            this.rgv_info.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.ShowGroupPanel = false;
            this.rgv_info.Size = new System.Drawing.Size(403, 446);
            this.rgv_info.TabIndex = 5;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_info_CommandCellClick);
            // 
            // ucNERBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.rgCriteria);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucNERBill";
            this.Size = new System.Drawing.Size(410, 514);
            this.Load += new System.EventHandler(this.ucNERBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgCriteria)).EndInit();
            this.rgCriteria.ResumeLayout(false);
            this.rgCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgCriteria;
        private Telerik.WinControls.UI.RadButton btnGo;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpTo;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView rgv_info;
    }
}
