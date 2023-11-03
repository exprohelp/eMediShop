namespace eMediShop.forms.Promo
{
    partial class ucPromoProducts
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btn_print = new System.Windows.Forms.Button();
            this.btninternal = new Telerik.WinControls.UI.RadButton();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.btnExternal = new Telerik.WinControls.UI.RadButton();
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btninternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Image = global::eMediShop.Properties.Resources.printer;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(583, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(45, 35);
            this.btn_print.TabIndex = 26;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btninternal
            // 
            this.btninternal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninternal.Location = new System.Drawing.Point(4, 8);
            this.btninternal.Name = "btninternal";
            this.btninternal.Size = new System.Drawing.Size(82, 29);
            this.btninternal.TabIndex = 29;
            this.btninternal.Text = "Internal";
            this.btninternal.Click += new System.EventHandler(this.btninternal_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btninternal.GetChildAt(0))).Text = "Internal";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btninternal.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // btnExternal
            // 
            this.btnExternal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExternal.Location = new System.Drawing.Point(116, 8);
            this.btnExternal.Name = "btnExternal";
            this.btnExternal.Size = new System.Drawing.Size(82, 29);
            this.btnExternal.TabIndex = 30;
            this.btnExternal.Text = "For Display";
            this.btnExternal.Click += new System.EventHandler(this.btnExternal_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExternal.GetChildAt(0))).Text = "For Display";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnExternal.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_info
            // 
            this.rgv_info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_info.Location = new System.Drawing.Point(4, 47);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "sno";
            gridViewDecimalColumn1.HeaderText = "S.No.";
            gridViewDecimalColumn1.Name = "S.No.";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_name";
            gridViewTextBoxColumn1.HeaderText = "Name of Product";
            gridViewTextBoxColumn1.Name = "Name of Product";
            gridViewTextBoxColumn1.Width = 416;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "qty";
            gridViewDecimalColumn2.FormatString = "{0:N0}";
            gridViewDecimalColumn2.HeaderText = "Qty";
            gridViewDecimalColumn2.Name = "Qty";
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "disc_per";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "Discount %";
            gridViewDecimalColumn3.Name = "Discount %";
            gridViewDecimalColumn3.Width = 72;
            this.rgv_info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3});
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_info.Size = new System.Drawing.Size(623, 406);
            this.rgv_info.TabIndex = 31;
            this.rgv_info.Text = "radGridView1";
            this.rgv_info.Click += new System.EventHandler(this.rgv_info_Click);
            // 
            // ucPromoProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.btnExternal);
            this.Controls.Add(this.btninternal);
            this.Controls.Add(this.btn_print);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucPromoProducts";
            this.Size = new System.Drawing.Size(634, 454);
            this.Load += new System.EventHandler(this.ucPromoProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btninternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private Telerik.WinControls.UI.RadButton btninternal;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadButton btnExternal;
        private Telerik.WinControls.UI.RadGridView rgv_info;
    }
}
