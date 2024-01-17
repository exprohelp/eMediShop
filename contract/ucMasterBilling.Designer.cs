namespace eMediShop.contract
{
    partial class ucMasterBilling
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMasterBilling));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgCriteria = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvOrderHeaders = new Telerik.WinControls.UI.RadGridView();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            this.rdtpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.rgCriteria)).BeginInit();
            this.rgCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpTo)).BeginInit();
            this.SuspendLayout();
            // 
            // rgCriteria
            // 
            this.rgCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgCriteria.Controls.Add(this.rdpTo);
            this.rgCriteria.Controls.Add(this.label2);
            this.rgCriteria.Controls.Add(this.rgvOrderHeaders);
            this.rgCriteria.Controls.Add(this.btnGo);
            this.rgCriteria.Controls.Add(this.rdtpFrom);
            this.rgCriteria.Controls.Add(this.label1);
            this.rgCriteria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgCriteria.HeaderText = "";
            this.rgCriteria.Location = new System.Drawing.Point(3, 3);
            this.rgCriteria.Name = "rgCriteria";
            this.rgCriteria.Size = new System.Drawing.Size(553, 533);
            this.rgCriteria.TabIndex = 5;
            // 
            // rgvOrderHeaders
            // 
            this.rgvOrderHeaders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgvOrderHeaders.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvOrderHeaders.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvOrderHeaders.ForeColor = System.Drawing.Color.Black;
            this.rgvOrderHeaders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvOrderHeaders.Location = new System.Drawing.Point(8, 44);
            // 
            // 
            // 
            this.rgvOrderHeaders.MasterTemplate.AllowAddNewRow = false;
            this.rgvOrderHeaders.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "column1";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "tg";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "isactive";
            gridViewTextBoxColumn2.HeaderText = "Is Active";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "isactive";
            this.rgvOrderHeaders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1,
            gridViewTextBoxColumn2});
            this.rgvOrderHeaders.MasterTemplate.EnableFiltering = true;
            this.rgvOrderHeaders.MasterTemplate.EnableGrouping = false;
            this.rgvOrderHeaders.MasterTemplate.EnableSorting = false;
            this.rgvOrderHeaders.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvOrderHeaders.Name = "rgvOrderHeaders";
            this.rgvOrderHeaders.ReadOnly = true;
            this.rgvOrderHeaders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvOrderHeaders.Size = new System.Drawing.Size(540, 484);
            this.rgvOrderHeaders.TabIndex = 6;
            this.rgvOrderHeaders.Text = "radGridView1";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(312, 14);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(41, 24);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = ">>";
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
            this.label2.Location = new System.Drawing.Point(168, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // rdpTo
            // 
            this.rdpTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdpTo.Location = new System.Drawing.Point(199, 12);
            this.rdpTo.Name = "rdpTo";
            this.rdpTo.Size = new System.Drawing.Size(107, 25);
            this.rdpTo.TabIndex = 8;
            this.rdpTo.TabStop = false;
            this.rdpTo.Text = "16-01-2024";
            this.rdpTo.Value = new System.DateTime(2024, 1, 16, 14, 10, 12, 459);
            // 
            // ucMasterBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgCriteria);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMasterBilling";
            this.Size = new System.Drawing.Size(1221, 546);
            ((System.ComponentModel.ISupportInitialize)(this.rgCriteria)).EndInit();
            this.rgCriteria.ResumeLayout(false);
            this.rgCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderHeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox rgCriteria;
        private Telerik.WinControls.UI.RadDateTimePicker rdpTo;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView rgvOrderHeaders;
        private Telerik.WinControls.UI.RadButton btnGo;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpFrom;
        private System.Windows.Forms.Label label1;
    }
}
