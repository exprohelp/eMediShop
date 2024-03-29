﻿namespace eMediShop.purchase.orders
{
    partial class MonthlyPurchaseOrderForUnits
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyPurchaseOrderForUnits));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lstZeroStockOrder = new System.Windows.Forms.ListView();
            this.Srno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mfdname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameOfITem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PKTYPE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PKQTY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SAVG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderPAck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alrt_flag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vendor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wh_stk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPreserve = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_laserPrint = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExcel = new System.Windows.Forms.Button();
            this.rgv_unit = new Telerik.WinControls.UI.RadGridView();
            this.btngetList = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lstZeroStockOrder
            // 
            this.lstZeroStockOrder.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstZeroStockOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Srno,
            this.mfdname,
            this.NameOfITem,
            this.PKTYPE,
            this.PKQTY,
            this.SAVG,
            this.OrderPAck,
            this.NPR,
            this.TOTAL,
            this.lsd,
            this.alrt_flag,
            this.Vendor,
            this.wh_stk});
            this.lstZeroStockOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstZeroStockOrder.FullRowSelect = true;
            this.lstZeroStockOrder.GridLines = true;
            this.lstZeroStockOrder.HideSelection = false;
            this.lstZeroStockOrder.Location = new System.Drawing.Point(237, 55);
            this.lstZeroStockOrder.Name = "lstZeroStockOrder";
            this.lstZeroStockOrder.Size = new System.Drawing.Size(827, 396);
            this.lstZeroStockOrder.TabIndex = 47;
            this.lstZeroStockOrder.UseCompatibleStateImageBehavior = false;
            this.lstZeroStockOrder.View = System.Windows.Forms.View.Details;
            // 
            // Srno
            // 
            this.Srno.Text = "Sr No.";
            this.Srno.Width = 45;
            // 
            // mfdname
            // 
            this.mfdname.Text = "mfdName";
            this.mfdname.Width = 0;
            // 
            // NameOfITem
            // 
            this.NameOfITem.Text = "Name of Item";
            this.NameOfITem.Width = 272;
            // 
            // PKTYPE
            // 
            this.PKTYPE.Text = "P.TYPE";
            this.PKTYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PKTYPE.Width = 65;
            // 
            // PKQTY
            // 
            this.PKQTY.Text = "P.QTY";
            this.PKQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SAVG
            // 
            this.SAVG.Text = "S. AVG";
            this.SAVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OrderPAck
            // 
            this.OrderPAck.Text = "ORD.PACK";
            this.OrderPAck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OrderPAck.Width = 80;
            // 
            // NPR
            // 
            this.NPR.Text = "NPR";
            this.NPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TOTAL
            // 
            this.TOTAL.Text = "TOTAL";
            this.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TOTAL.Width = 65;
            // 
            // lsd
            // 
            this.lsd.Text = "LSD";
            this.lsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lsd.Width = 80;
            // 
            // alrt_flag
            // 
            this.alrt_flag.Text = "Alert";
            this.alrt_flag.Width = 40;
            // 
            // Vendor
            // 
            this.Vendor.Text = "Vendor_Name";
            this.Vendor.Width = 150;
            // 
            // wh_stk
            // 
            this.wh_stk.Text = "WH Stk";
            this.wh_stk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtOrder);
            this.GroupBox3.Controls.Add(this.lblOrder);
            this.GroupBox3.Controls.Add(this.lblOrderNo);
            this.GroupBox3.Controls.Add(this.btnView);
            this.GroupBox3.Controls.Add(this.btnPreserve);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(237, 0);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(827, 49);
            this.GroupBox3.TabIndex = 46;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "{Minimum Stock Purchase Order}";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(294, 21);
            this.txtOrder.MaxLength = 6;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(48, 20);
            this.txtOrder.TabIndex = 57;
            this.txtOrder.Text = "2";
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOrder.Visible = false;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(184, 28);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(103, 13);
            this.lblOrder.TabIndex = 56;
            this.lblOrder.Text = "Order For Month ";
            this.lblOrder.Visible = false;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.Location = new System.Drawing.Point(344, 21);
            this.lblOrderNo.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(0, 19);
            this.lblOrderNo.TabIndex = 55;
            this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrderNo.UseCompatibleTextRendering = true;
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(720, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 27);
            this.btnView.TabIndex = 54;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPreserve
            // 
            this.btnPreserve.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreserve.Location = new System.Drawing.Point(9, 17);
            this.btnPreserve.Name = "btnPreserve";
            this.btnPreserve.Size = new System.Drawing.Size(142, 27);
            this.btnPreserve.TabIndex = 53;
            this.btnPreserve.Text = "CHECK OPEN ORDER";
            this.btnPreserve.UseVisualStyleBackColor = true;
            this.btnPreserve.Click += new System.EventHandler(this.btnPreserve_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(237, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 27);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_laserPrint
            // 
            this.btn_laserPrint.Enabled = false;
            this.btn_laserPrint.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laserPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laserPrint.Location = new System.Drawing.Point(881, 454);
            this.btn_laserPrint.Name = "btn_laserPrint";
            this.btn_laserPrint.Size = new System.Drawing.Size(96, 28);
            this.btn_laserPrint.TabIndex = 51;
            this.btn_laserPrint.Text = "PDF";
            this.btn_laserPrint.UseVisualStyleBackColor = true;
            this.btn_laserPrint.Click += new System.EventHandler(this.btn_laserPrint_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Purchase Order";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnExcel
            // 
            this.btnExcel.Enabled = false;
            this.btnExcel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(985, 454);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(78, 28);
            this.btnExcel.TabIndex = 57;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // rgv_unit
            // 
            this.rgv_unit.BackColor = System.Drawing.Color.White;
            this.rgv_unit.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_unit.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_unit.ForeColor = System.Drawing.Color.Black;
            this.rgv_unit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_unit.Location = new System.Drawing.Point(0, 55);
            // 
            // 
            // 
            this.rgv_unit.MasterTemplate.AllowAddNewRow = false;
            this.rgv_unit.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "unit_id";
            gridViewTextBoxColumn1.HeaderText = "Unit ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "unit_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "sh_name";
            gridViewTextBoxColumn2.HeaderText = "Unit Name";
            gridViewTextBoxColumn2.Name = "sh_name";
            gridViewTextBoxColumn2.Width = 173;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "chk";
            gridViewCheckBoxColumn1.HeaderText = "-";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "chk";
            gridViewCheckBoxColumn1.Width = 25;
            this.rgv_unit.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1});
            this.rgv_unit.MasterTemplate.EnableGrouping = false;
            this.rgv_unit.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_unit.Name = "rgv_unit";
            this.rgv_unit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_unit.Size = new System.Drawing.Size(231, 427);
            this.rgv_unit.TabIndex = 58;
            this.rgv_unit.Text = "radGridView1";
            // 
            // btngetList
            // 
            this.btngetList.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetList.Location = new System.Drawing.Point(0, 14);
            this.btngetList.Name = "btngetList";
            this.btngetList.Size = new System.Drawing.Size(231, 27);
            this.btngetList.TabIndex = 59;
            this.btngetList.Text = "Get Unit List";
            this.btngetList.UseVisualStyleBackColor = true;
            this.btngetList.Click += new System.EventHandler(this.btngetList_Click);
            // 
            // MonthlyPurchaseOrderForUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 485);
            this.Controls.Add(this.btngetList);
            this.Controls.Add(this.rgv_unit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lstZeroStockOrder);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.btn_laserPrint);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MonthlyPurchaseOrderForUnits";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Minimum Stock Purchase Order";
            this.Load += new System.EventHandler(this.Zero_Stock_Order_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lstZeroStockOrder;
        internal System.Windows.Forms.ColumnHeader Srno;
        internal System.Windows.Forms.ColumnHeader NameOfITem;
        internal System.Windows.Forms.ColumnHeader PKTYPE;
        internal System.Windows.Forms.ColumnHeader PKQTY;
        internal System.Windows.Forms.ColumnHeader SAVG;
        internal System.Windows.Forms.ColumnHeader OrderPAck;
        internal System.Windows.Forms.ColumnHeader NPR;
        internal System.Windows.Forms.ColumnHeader TOTAL;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btn_laserPrint;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPreserve;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ColumnHeader mfdname;
        private System.Windows.Forms.ColumnHeader lsd;
        private System.Windows.Forms.ColumnHeader alrt_flag;
        private System.Windows.Forms.ColumnHeader Vendor;
        private System.Windows.Forms.ColumnHeader wh_stk;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblOrder;
        private Telerik.WinControls.UI.RadGridView rgv_unit;
        private System.Windows.Forms.Button btngetList;
    }
}