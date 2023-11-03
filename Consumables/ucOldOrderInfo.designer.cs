namespace eMediShop.Inventory
{
    partial class ucOldOrderInfo
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
            this.btnGo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lvOldOrder = new System.Windows.Forms.ListView();
            this.autoid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pack_size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pack_qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ordQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vflag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trfFlag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cr_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGo.Location = new System.Drawing.Point(325, 16);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(50, 33);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(205, 20);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(114, 25);
            this.dtTo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "From ";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(52, 20);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(114, 25);
            this.dtFrom.TabIndex = 11;
            // 
            // lvOldOrder
            // 
            this.lvOldOrder.BackColor = System.Drawing.Color.White;
            this.lvOldOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvOldOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.autoid,
            this.item_name,
            this.pack_size,
            this.pack_qty,
            this.ordQty,
            this.vqty,
            this.vflag,
            this.trfFlag,
            this.cr_date,
            this.Vby});
            this.lvOldOrder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOldOrder.FullRowSelect = true;
            this.lvOldOrder.GridLines = true;
            this.lvOldOrder.Location = new System.Drawing.Point(7, 55);
            this.lvOldOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvOldOrder.Name = "lvOldOrder";
            this.lvOldOrder.Size = new System.Drawing.Size(685, 427);
            this.lvOldOrder.TabIndex = 10;
            this.lvOldOrder.UseCompatibleStateImageBehavior = false;
            this.lvOldOrder.View = System.Windows.Forms.View.Details;
            this.lvOldOrder.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvOldOrder_ColumnClick);
            // 
            // autoid
            // 
            this.autoid.Text = "autoid";
            this.autoid.Width = 0;
            // 
            // item_name
            // 
            this.item_name.Text = "Item Name";
            this.item_name.Width = 233;
            // 
            // pack_size
            // 
            this.pack_size.Text = "P.Size";
            this.pack_size.Width = 61;
            // 
            // pack_qty
            // 
            this.pack_qty.Text = "P.Qty";
            this.pack_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pack_qty.Width = 42;
            // 
            // ordQty
            // 
            this.ordQty.Text = "Ord Qty";
            this.ordQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ordQty.Width = 59;
            // 
            // vqty
            // 
            this.vqty.Text = "V.Qty";
            this.vqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vqty.Width = 59;
            // 
            // vflag
            // 
            this.vflag.Text = "V.Flag";
            this.vflag.Width = 61;
            // 
            // trfFlag
            // 
            this.trfFlag.Text = "T.Flag";
            this.trfFlag.Width = 61;
            // 
            // cr_date
            // 
            this.cr_date.Text = "Date/Time";
            this.cr_date.Width = 75;
            // 
            // Vby
            // 
            this.Vby.Text = "VBy";
            this.Vby.Width = 0;
            // 
            // ucOldOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.lvOldOrder);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucOldOrderInfo";
            this.Size = new System.Drawing.Size(695, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.ListView lvOldOrder;
        private System.Windows.Forms.ColumnHeader autoid;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader pack_size;
        private System.Windows.Forms.ColumnHeader pack_qty;
        private System.Windows.Forms.ColumnHeader ordQty;
        private System.Windows.Forms.ColumnHeader vqty;
        private System.Windows.Forms.ColumnHeader vflag;
        private System.Windows.Forms.ColumnHeader trfFlag;
        private System.Windows.Forms.ColumnHeader cr_date;
        private System.Windows.Forms.ColumnHeader Vby;
    }
}
