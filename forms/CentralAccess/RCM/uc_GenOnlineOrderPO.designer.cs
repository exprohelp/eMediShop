namespace eMediShop.forms.CentralAccess.RCM
{
    partial class uc_GenOnlineOrderPO
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgPO = new Telerik.WinControls.UI.RadGridView();
            this.btnExcelConvert = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnGenerate = new Telerik.WinControls.UI.RadButton();
            this.chkGenerate = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPO.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcelConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPO
            // 
            this.dgPO.BackColor = System.Drawing.SystemColors.Control;
            this.dgPO.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgPO.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgPO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgPO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgPO.Location = new System.Drawing.Point(3, 47);
            this.dgPO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.dgPO.MasterTemplate.AllowAddNewRow = false;
            this.dgPO.MasterTemplate.AllowDeleteRow = false;
            this.dgPO.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "item_id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Product Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 361;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ReqQty";
            gridViewTextBoxColumn3.HeaderText = "Req";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Name = "ReqQty";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 57;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "InStock";
            gridViewTextBoxColumn4.HeaderText = "InStock";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Name = "InStock";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 51;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "OrderQty";
            gridViewTextBoxColumn5.HeaderText = "OrderQty";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Name = "OrderQty";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 54;
            this.dgPO.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dgPO.MasterTemplate.EnableGrouping = false;
            this.dgPO.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgPO.Name = "dgPO";
            this.dgPO.ReadOnly = true;
            this.dgPO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgPO.Size = new System.Drawing.Size(560, 449);
            this.dgPO.TabIndex = 0;
            this.dgPO.Text = "radGridView1";
            // 
            // btnExcelConvert
            // 
            this.btnExcelConvert.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnExcelConvert.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcelConvert.Location = new System.Drawing.Point(518, 6);
            this.btnExcelConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcelConvert.Name = "btnExcelConvert";
            this.btnExcelConvert.Size = new System.Drawing.Size(45, 37);
            this.btnExcelConvert.TabIndex = 30;
            this.btnExcelConvert.Click += new System.EventHandler(this.btnExcelConvert_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(231, 15);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(156, 25);
            this.radLabel1.TabIndex = 31;
            this.radLabel1.Text = "PO of Online Order";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Image = global::eMediShop.Properties.Resources.Next;
            this.btnGenerate.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Location = new System.Drawing.Point(410, 6);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(45, 37);
            this.btnGenerate.TabIndex = 32;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkGenerate
            // 
            this.chkGenerate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGenerate.Location = new System.Drawing.Point(12, 11);
            this.chkGenerate.Name = "chkGenerate";
            this.chkGenerate.Size = new System.Drawing.Size(101, 30);
            this.chkGenerate.TabIndex = 33;
            this.chkGenerate.Text = "Generate";
            // 
            // uc_GenOnlineOrderPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkGenerate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnExcelConvert);
            this.Controls.Add(this.dgPO);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_GenOnlineOrderPO";
            this.Size = new System.Drawing.Size(569, 500);
            this.Load += new System.EventHandler(this.uc_GenOnlineOrderPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPO.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcelConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgPO;
        private Telerik.WinControls.UI.RadButton btnExcelConvert;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnGenerate;
        private Telerik.WinControls.UI.RadCheckBox chkGenerate;
    }
}
