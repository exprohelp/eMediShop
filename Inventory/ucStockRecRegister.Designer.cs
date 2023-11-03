namespace eMediShop.Inventory
{
    partial class ucStockRecRegister
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStockRecRegister));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rdp_to = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdp_from = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(325, 14);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 24);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = "Submit";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rdp_to
            // 
            this.rdp_to.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_to.Location = new System.Drawing.Point(202, 13);
            this.rdp_to.Name = "rdp_to";
            this.rdp_to.Size = new System.Drawing.Size(117, 25);
            this.rdp_to.TabIndex = 8;
            this.rdp_to.TabStop = false;
            this.rdp_to.Text = "21-06-2019";
            this.rdp_to.Value = new System.DateTime(2019, 6, 21, 13, 55, 32, 30);
            // 
            // rdp_from
            // 
            this.rdp_from.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdp_from.Location = new System.Drawing.Point(52, 13);
            this.rdp_from.Name = "rdp_from";
            this.rdp_from.Size = new System.Drawing.Size(117, 25);
            this.rdp_from.TabIndex = 7;
            this.rdp_from.TabStop = false;
            this.rdp_from.Text = "21-06-2019";
            this.rdp_from.Value = new System.DateTime(2019, 6, 21, 13, 55, 32, 30);
            this.rdp_from.Leave += new System.EventHandler(this.rdp_from_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "From ";
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(4, 59);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            gridViewDateTimeColumn2.AllowFiltering = false;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "rcpt_date";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "Rcpt Date";
            gridViewDateTimeColumn2.Name = "rcpt_date";
            gridViewDateTimeColumn2.Width = 96;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "trf_id";
            gridViewTextBoxColumn4.HeaderText = "Transfer ID";
            gridViewTextBoxColumn4.Name = "trf_id";
            gridViewTextBoxColumn4.Width = 131;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "trf_to";
            gridViewTextBoxColumn5.HeaderText = "trf_to";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "trf_to";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "unitName";
            gridViewTextBoxColumn6.HeaderText = "Transfer From";
            gridViewTextBoxColumn6.Name = "unitName";
            gridViewTextBoxColumn6.Width = 293;
            gridViewDecimalColumn5.AllowFiltering = false;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "taxablevalue";
            gridViewDecimalColumn5.HeaderText = "Taxable Value";
            gridViewDecimalColumn5.Name = "taxablevalue";
            gridViewDecimalColumn5.Width = 77;
            gridViewDecimalColumn6.AllowFiltering = false;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "taxvalue";
            gridViewDecimalColumn6.HeaderText = "Tax Value";
            gridViewDecimalColumn6.Name = "taxvalue";
            gridViewDecimalColumn6.Width = 69;
            gridViewDecimalColumn7.AllowFiltering = false;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "Total";
            gridViewDecimalColumn7.HeaderText = "Total";
            gridViewDecimalColumn7.Name = "total";
            gridViewDecimalColumn8.AllowFiltering = false;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "NoS";
            gridViewDecimalColumn8.HeaderText = "NoS";
            gridViewDecimalColumn8.Name = "NoS";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column1";
            gridViewCommandColumn2.Width = 25;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewCommandColumn2});
            this.rgv_info.MasterTemplate.EnableFiltering = true;
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(855, 391);
            this.rgv_info.TabIndex = 12;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.MasterTemplate_CommandCellClick);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.btnSubmit);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.rdp_to);
            this.radGroupBox1.Controls.Add(this.rdp_from);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 6);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(855, 47);
            this.radGroupBox1.TabIndex = 1;
            // 
            // ucStockRecRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.rgv_info);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucStockRecRegister";
            this.Size = new System.Drawing.Size(862, 455);
            this.Load += new System.EventHandler(this.ucStockRecRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_to;
        private Telerik.WinControls.UI.RadDateTimePicker rdp_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}
