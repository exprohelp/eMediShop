namespace eMediShop.forms.Stock
{
    partial class ucGR_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGR_Report));
            this.lv_info = new System.Windows.Forms.ListView();
            this.TrfId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoOfProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStock = new System.Windows.Forms.Button();
            this.lvProductInfo = new System.Windows.Forms.ListView();
            this.prodNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MasterKeyid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BatchNo1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Expdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaclType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInternalSheet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_info
            // 
            this.lv_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TrfId,
            this.NoOfProduct,
            this.Amount});
            this.lv_info.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_info.FullRowSelect = true;
            this.lv_info.GridLines = true;
            this.lv_info.Location = new System.Drawing.Point(4, 37);
            this.lv_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_info.Name = "lv_info";
            this.lv_info.Size = new System.Drawing.Size(302, 456);
            this.lv_info.TabIndex = 19;
            this.lv_info.UseCompatibleStateImageBehavior = false;
            this.lv_info.View = System.Windows.Forms.View.Details;
            this.lv_info.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_info_ItemSelectionChanged);
            // 
            // TrfId
            // 
            this.TrfId.Text = "Transfer Id";
            this.TrfId.Width = 150;
            // 
            // NoOfProduct
            // 
            this.NoOfProduct.Text = "NoS";
            this.NoOfProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NoOfProduct.Width = 50;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 70;
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(276, 7);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(29, 25);
            this.btnStock.TabIndex = 20;
            this.btnStock.Text = ">>";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // lvProductInfo
            // 
            this.lvProductInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodNAME,
            this.MasterKeyid,
            this.BatchNo1,
            this.Expdate,
            this.PaclType,
            this.packqty,
            this.Qty});
            this.lvProductInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProductInfo.FullRowSelect = true;
            this.lvProductInfo.GridLines = true;
            this.lvProductInfo.Location = new System.Drawing.Point(5, 24);
            this.lvProductInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvProductInfo.Name = "lvProductInfo";
            this.lvProductInfo.Size = new System.Drawing.Size(652, 428);
            this.lvProductInfo.TabIndex = 29;
            this.lvProductInfo.UseCompatibleStateImageBehavior = false;
            this.lvProductInfo.View = System.Windows.Forms.View.Details;
            // 
            // prodNAME
            // 
            this.prodNAME.Text = "Item Name";
            this.prodNAME.Width = 268;
            // 
            // MasterKeyid
            // 
            this.MasterKeyid.Text = "Master Key";
            this.MasterKeyid.Width = 0;
            // 
            // BatchNo1
            // 
            this.BatchNo1.Text = "Batch No";
            this.BatchNo1.Width = 91;
            // 
            // Expdate
            // 
            this.Expdate.Text = "Exp Dt";
            this.Expdate.Width = 85;
            // 
            // PaclType
            // 
            this.PaclType.Text = "PackType";
            this.PaclType.Width = 66;
            // 
            // packqty
            // 
            this.packqty.Text = "PackQty";
            this.packqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Qty.Width = 51;
            // 
            // btnInternalSheet
            // 
            this.btnInternalSheet.BackColor = System.Drawing.Color.Transparent;
            this.btnInternalSheet.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternalSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInternalSheet.Image = ((System.Drawing.Image)(resources.GetObject("btnInternalSheet.Image")));
            this.btnInternalSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternalSheet.Location = new System.Drawing.Point(889, 7);
            this.btnInternalSheet.Name = "btnInternalSheet";
            this.btnInternalSheet.Size = new System.Drawing.Size(81, 28);
            this.btnInternalSheet.TabIndex = 31;
            this.btnInternalSheet.Text = "PRINT";
            this.btnInternalSheet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInternalSheet.UseVisualStyleBackColor = false;
            this.btnInternalSheet.Click += new System.EventHandler(this.btnInternalSheet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "From";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(178, 8);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(93, 22);
            this.dtTo.TabIndex = 33;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(49, 7);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(94, 22);
            this.dtFrom.TabIndex = 32;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lvProductInfo);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXXXXXXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(311, 36);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(662, 454);
            this.radGroupBox1.TabIndex = 36;
            this.radGroupBox1.Text = "XXXXXXXXXXXXXXXXXX";
            // 
            // ucGR_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnInternalSheet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.lv_info);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucGR_Report";
            this.Size = new System.Drawing.Size(974, 500);
            this.Load += new System.EventHandler(this.ucExpiryReconcile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_info;
        private System.Windows.Forms.ColumnHeader NoOfProduct;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.ColumnHeader TrfId;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ListView lvProductInfo;
        private System.Windows.Forms.ColumnHeader prodNAME;
        private System.Windows.Forms.ColumnHeader MasterKeyid;
        private System.Windows.Forms.ColumnHeader BatchNo1;
        private System.Windows.Forms.ColumnHeader Expdate;
        private System.Windows.Forms.ColumnHeader PaclType;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader packqty;
        private System.Windows.Forms.Button btnInternalSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}
