namespace eMediShop.Hospital
{
    partial class ucIPD_ExtraIn
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.txtIpdNo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_processedIndent = new Telerik.WinControls.UI.RadGridView();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnGenExtra = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIpdNo
            // 
            this.txtIpdNo.BackColor = System.Drawing.Color.White;
            this.txtIpdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIpdNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIpdNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpdNo.ForeColor = System.Drawing.Color.Blue;
            this.txtIpdNo.Location = new System.Drawing.Point(9, 30);
            this.txtIpdNo.MaxLength = 20;
            this.txtIpdNo.Name = "txtIpdNo";
            this.txtIpdNo.Size = new System.Drawing.Size(149, 25);
            this.txtIpdNo.TabIndex = 84;
            this.txtIpdNo.TabStop = false;
            this.txtIpdNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(9, 7);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 20);
            this.Label3.TabIndex = 85;
            this.Label3.Text = "IPD No.";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_processedIndent);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(7, 61);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(888, 460);
            this.radGroupBox1.TabIndex = 94;
            this.radGroupBox1.Text = "XXXXXXXXXXX";
            // 
            // rgv_processedIndent
            // 
            this.rgv_processedIndent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_processedIndent.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_processedIndent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_processedIndent.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_processedIndent.ForeColor = System.Drawing.Color.Black;
            this.rgv_processedIndent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_processedIndent.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_processedIndent.MasterTemplate.AllowAddNewRow = false;
            this.rgv_processedIndent.MasterTemplate.AllowDeleteRow = false;
            this.rgv_processedIndent.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "item_id";
            gridViewTextBoxColumn15.HeaderText = "item_id";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "item_id";
            gridViewTextBoxColumn15.ReadOnly = true;
            gridViewTextBoxColumn15.Width = 307;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "item_name";
            gridViewTextBoxColumn16.HeaderText = "Name of Product";
            gridViewTextBoxColumn16.Name = "item_name";
            gridViewTextBoxColumn16.ReadOnly = true;
            gridViewTextBoxColumn16.Width = 238;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "master_key_id";
            gridViewTextBoxColumn17.HeaderText = "Master Key ID";
            gridViewTextBoxColumn17.Name = "master_key_id";
            gridViewTextBoxColumn17.ReadOnly = true;
            gridViewTextBoxColumn17.Width = 125;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "pack_type";
            gridViewTextBoxColumn18.HeaderText = "Pack Type";
            gridViewTextBoxColumn18.Name = "pack_type";
            gridViewTextBoxColumn18.ReadOnly = true;
            gridViewTextBoxColumn18.Width = 77;
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "pack_qty";
            gridViewDecimalColumn9.FormatString = "{0:N0}";
            gridViewDecimalColumn9.HeaderText = "P. Qty";
            gridViewDecimalColumn9.Name = "pack_qty";
            gridViewDecimalColumn9.ReadOnly = true;
            gridViewDecimalColumn9.Width = 49;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "batch_no";
            gridViewTextBoxColumn19.HeaderText = "Batch No";
            gridViewTextBoxColumn19.Name = "batch_no";
            gridViewTextBoxColumn19.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn19.Width = 75;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "exp_date";
            gridViewTextBoxColumn20.HeaderText = "Expiry";
            gridViewTextBoxColumn20.Name = "exp_date";
            gridViewTextBoxColumn20.Width = 60;
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FieldName = "mrp";
            gridViewDecimalColumn10.FormatString = "{0:N2}";
            gridViewDecimalColumn10.HeaderText = "MRP";
            gridViewDecimalColumn10.Name = "mrp";
            gridViewDecimalColumn10.ReadOnly = true;
            gridViewDecimalColumn10.Width = 53;
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.FieldName = "sale_qty";
            gridViewDecimalColumn11.FormatString = "{0:N0}";
            gridViewDecimalColumn11.HeaderText = "Sold Qty";
            gridViewDecimalColumn11.Name = "sale_qty";
            gridViewDecimalColumn11.ReadOnly = true;
            gridViewDecimalColumn11.Width = 59;
            gridViewDecimalColumn12.DecimalPlaces = 0;
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.FieldName = "ExtraIn";
            gridViewDecimalColumn12.HeaderText = "Extra In";
            gridViewDecimalColumn12.Name = "ExtraIn";
            gridViewDecimalColumn12.Width = 59;
            gridViewTextBoxColumn21.EnableExpressionEditor = false;
            gridViewTextBoxColumn21.FieldName = "trf_flag";
            gridViewTextBoxColumn21.HeaderText = "Trf Flag";
            gridViewTextBoxColumn21.IsVisible = false;
            gridViewTextBoxColumn21.Name = "trf_flag";
            this.rgv_processedIndent.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewDecimalColumn9,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewDecimalColumn10,
            gridViewDecimalColumn11,
            gridViewDecimalColumn12,
            gridViewTextBoxColumn21});
            sortDescriptor3.PropertyName = "batch_no";
            this.rgv_processedIndent.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.rgv_processedIndent.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_processedIndent.Name = "rgv_processedIndent";
            this.rgv_processedIndent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_processedIndent.ShowGroupPanel = false;
            this.rgv_processedIndent.Size = new System.Drawing.Size(884, 440);
            this.rgv_processedIndent.TabIndex = 91;
            this.rgv_processedIndent.Text = "radGridView1";
            this.rgv_processedIndent.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_processedIndent_RowFormatting);
            this.rgv_processedIndent.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.MasterTemplate_CellBeginEdit);
            this.rgv_processedIndent.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgv_processedIndent_CellEndEdit);
            // 
            // btnGenExtra
            // 
            this.btnGenExtra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenExtra.Location = new System.Drawing.Point(783, 25);
            this.btnGenExtra.Name = "btnGenExtra";
            this.btnGenExtra.Size = new System.Drawing.Size(110, 30);
            this.btnGenExtra.TabIndex = 96;
            this.btnGenExtra.Text = "Generate Extra";
            this.btnGenExtra.Click += new System.EventHandler(this.btnGenExtra_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnGenExtra.GetChildAt(0))).Text = "Generate Extra";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnGenExtra.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnGenExtra.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(164, 25);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(37, 30);
            this.btnSubmit.TabIndex = 97;
            this.btnSubmit.Text = ">>";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSubmit.GetChildAt(0))).Text = ">>";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.btnSubmit.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.btnSubmit.GetChildAt(0).GetChildAt(1))).Shape = this.roundRectShape1;
            // 
            // ucIPD_ExtraIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnGenExtra);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtIpdNo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucIPD_ExtraIn";
            this.Size = new System.Drawing.Size(907, 521);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_processedIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtIpdNo;
        internal System.Windows.Forms.Label Label3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgv_processedIndent;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton btnGenExtra;
        private Telerik.WinControls.UI.RadButton btnSubmit;
    }
}
