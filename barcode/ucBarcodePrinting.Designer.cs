namespace eMediShop.barcode
{
    partial class ucBarcodePrinting
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBarcodePrinting));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpurchaseID = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.brnPrintAll = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurchaseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnPrintAll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(378, 13);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 26);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print KOT";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(378, 45);
            this.radButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(59, 25);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Print";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase Id";
            // 
            // txtpurchaseID
            // 
            this.txtpurchaseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpurchaseID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurchaseID.Location = new System.Drawing.Point(4, 39);
            this.txtpurchaseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtpurchaseID.MaxLength = 20;
            this.txtpurchaseID.Name = "txtpurchaseID";
            this.txtpurchaseID.Size = new System.Drawing.Size(224, 25);
            this.txtpurchaseID.TabIndex = 3;
            this.txtpurchaseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtpurchaseID.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtpurchaseID.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgvInfo
            // 
            this.rgvInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rgvInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgvInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvInfo.Location = new System.Drawing.Point(8, 72);
            // 
            // 
            // 
            this.rgvInfo.MasterTemplate.AllowAddNewRow = false;
            this.rgvInfo.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_name";
            gridViewTextBoxColumn1.HeaderText = "Name of Item";
            gridViewTextBoxColumn1.Name = "itemname";
            gridViewTextBoxColumn1.Width = 267;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "batch_no";
            gridViewTextBoxColumn2.HeaderText = "Batch No";
            gridViewTextBoxColumn2.Name = "batchno";
            gridViewTextBoxColumn2.Width = 107;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "expiry";
            gridViewTextBoxColumn3.HeaderText = "Expiry";
            gridViewTextBoxColumn3.Name = "expiry";
            gridViewTextBoxColumn3.Width = 77;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "barcode_no";
            gridViewTextBoxColumn4.HeaderText = "Barcode No";
            gridViewTextBoxColumn4.Name = "barcodeno";
            gridViewTextBoxColumn4.Width = 142;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "mrp";
            gridViewDecimalColumn1.HeaderText = "MRP";
            gridViewDecimalColumn1.Name = "mrp";
            gridViewDecimalColumn1.Width = 79;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.HeaderImage")));
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgvInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewCommandColumn1});
            this.rgvInfo.MasterTemplate.EnableGrouping = false;
            this.rgvInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.ReadOnly = true;
            this.rgvInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvInfo.Size = new System.Drawing.Size(721, 384);
            this.rgvInfo.TabIndex = 4;
            this.rgvInfo.Text = "radGridView1";
            this.rgvInfo.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvInfo_CommandCellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::eMediShop.Properties.Resources.click16;
            this.btnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(236, 39);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 26);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // brnPrintAll
            // 
            this.brnPrintAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnPrintAll.Image = global::eMediShop.Properties.Resources.printer;
            this.brnPrintAll.Location = new System.Drawing.Point(628, 29);
            this.brnPrintAll.Margin = new System.Windows.Forms.Padding(4);
            this.brnPrintAll.Name = "brnPrintAll";
            this.brnPrintAll.Size = new System.Drawing.Size(101, 36);
            this.brnPrintAll.TabIndex = 6;
            this.brnPrintAll.Text = "All Label";
            this.brnPrintAll.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.brnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // ucBarcodePrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brnPrintAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rgvInfo);
            this.Controls.Add(this.txtpurchaseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btnPrint);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBarcodePrinting";
            this.Size = new System.Drawing.Size(737, 459);
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpurchaseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnPrintAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnPrint;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtpurchaseID;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadGridView rgvInfo;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadButton brnPrintAll;
    }
}
