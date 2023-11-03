namespace eMediShop.GC
{
    partial class ucGCUpdReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_Comp = new System.Windows.Forms.ListView();
            this.UID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidUpto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.compType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 179);
            this.panel1.TabIndex = 3;
            // 
            // lv_Comp
            // 
            this.lv_Comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Comp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UID,
            this.RegNo,
            this.ValidUpto,
            this.Remark,
            this.compType});
            this.lv_Comp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Comp.FullRowSelect = true;
            this.lv_Comp.GridLines = true;
            this.lv_Comp.Location = new System.Drawing.Point(12, 8);
            this.lv_Comp.Name = "lv_Comp";
            this.lv_Comp.Size = new System.Drawing.Size(802, 291);
            this.lv_Comp.TabIndex = 2;
            this.lv_Comp.UseCompatibleStateImageBehavior = false;
            this.lv_Comp.View = System.Windows.Forms.View.Details;
            this.lv_Comp.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Comp_ItemSelectionChanged);
            // 
            // UID
            // 
            this.UID.Text = "UID";
            this.UID.Width = 3;
            // 
            // RegNo
            // 
            this.RegNo.Text = "Reg./Licence No";
            this.RegNo.Width = 161;
            // 
            // ValidUpto
            // 
            this.ValidUpto.Text = "ValidUpto";
            this.ValidUpto.Width = 106;
            // 
            // Remark
            // 
            this.Remark.Text = "Remark";
            this.Remark.Width = 413;
            // 
            // compType
            // 
            this.compType.Text = "comptype";
            this.compType.Width = 95;
            // 
            // ucGCUpdReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_Comp);
            this.Name = "ucGCUpdReport";
            this.Size = new System.Drawing.Size(830, 500);
            this.Load += new System.EventHandler(this.ucGCUpdReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_Comp;
        private System.Windows.Forms.ColumnHeader UID;
        private System.Windows.Forms.ColumnHeader RegNo;
        private System.Windows.Forms.ColumnHeader ValidUpto;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.ColumnHeader compType;
    }
}
