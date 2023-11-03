namespace eMediShop.forms.Audit
{
    partial class ucBulkChecking
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
            this.lv_unit = new eMediShop.DragAndDropListView();
            this.btn_Process = new System.Windows.Forms.Button();
            this.item_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MASTER_KEY_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OPENING = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STOCK_R = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STOCK_S = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STOCK_T = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sys_bal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CUR_STOCK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dragAndDropListView1 = new eMediShop.DragAndDropListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_unit
            // 
            this.lv_unit.AllowDrop = true;
            this.lv_unit.AllowReorder = true;
            this.lv_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lv_unit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.MASTER_KEY_ID,
            this.OPENING,
            this.STOCK_R,
            this.STOCK_S,
            this.STOCK_T,
            this.sys_bal,
            this.CUR_STOCK});
            this.lv_unit.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.lv_unit.FullRowSelect = true;
            this.lv_unit.GridLines = true;
            this.lv_unit.LineColor = System.Drawing.Color.Red;
            this.lv_unit.Location = new System.Drawing.Point(3, 30);
            this.lv_unit.Name = "lv_unit";
            this.lv_unit.Result = "";
            this.lv_unit.Size = new System.Drawing.Size(510, 488);
            this.lv_unit.TabIndex = 36;
            this.lv_unit.UseCompatibleStateImageBehavior = false;
            this.lv_unit.View = System.Windows.Forms.View.Details;
            // 
            // btn_Process
            // 
            this.btn_Process.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(3, 3);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(57, 23);
            this.btn_Process.TabIndex = 37;
            this.btn_Process.Text = "Submit";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // item_id
            // 
            this.item_id.Text = "ITEM ID";
            // 
            // MASTER_KEY_ID
            // 
            this.MASTER_KEY_ID.Text = "MASTER KEY ID";
            this.MASTER_KEY_ID.Width = 100;
            // 
            // OPENING
            // 
            this.OPENING.Text = "O.STK";
            this.OPENING.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OPENING.Width = 50;
            // 
            // STOCK_R
            // 
            this.STOCK_R.Text = "STK[R]";
            this.STOCK_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.STOCK_R.Width = 50;
            // 
            // STOCK_S
            // 
            this.STOCK_S.Text = "STK[S]";
            this.STOCK_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.STOCK_S.Width = 50;
            // 
            // STOCK_T
            // 
            this.STOCK_T.Text = "STK[T]";
            this.STOCK_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.STOCK_T.Width = 50;
            // 
            // sys_bal
            // 
            this.sys_bal.Text = "SYSBAL";
            this.sys_bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sys_bal.Width = 55;
            // 
            // CUR_STOCK
            // 
            this.CUR_STOCK.Text = "STK[C]";
            this.CUR_STOCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CUR_STOCK.Width = 50;
            // 
            // dragAndDropListView1
            // 
            this.dragAndDropListView1.AllowDrop = true;
            this.dragAndDropListView1.AllowReorder = true;
            this.dragAndDropListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dragAndDropListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.dragAndDropListView1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.dragAndDropListView1.FullRowSelect = true;
            this.dragAndDropListView1.GridLines = true;
            this.dragAndDropListView1.LineColor = System.Drawing.Color.Red;
            this.dragAndDropListView1.Location = new System.Drawing.Point(519, 31);
            this.dragAndDropListView1.Name = "dragAndDropListView1";
            this.dragAndDropListView1.Result = "";
            this.dragAndDropListView1.Size = new System.Drawing.Size(510, 488);
            this.dragAndDropListView1.TabIndex = 38;
            this.dragAndDropListView1.UseCompatibleStateImageBehavior = false;
            this.dragAndDropListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ITEM ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MASTER KEY ID";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "O.STK";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STK[R]";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STK[S]";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STK[T]";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SYSBAL";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 55;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STK[C]";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 50;
            // 
            // ucBulkChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dragAndDropListView1);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.lv_unit);
            this.Name = "ucBulkChecking";
            this.Size = new System.Drawing.Size(1040, 520);
            this.ResumeLayout(false);

        }

        #endregion

        private DragAndDropListView lv_unit;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader MASTER_KEY_ID;
        private System.Windows.Forms.ColumnHeader OPENING;
        private System.Windows.Forms.ColumnHeader STOCK_R;
        private System.Windows.Forms.ColumnHeader STOCK_S;
        private System.Windows.Forms.ColumnHeader STOCK_T;
        private System.Windows.Forms.ColumnHeader sys_bal;
        private System.Windows.Forms.ColumnHeader CUR_STOCK;
        private DragAndDropListView dragAndDropListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}
