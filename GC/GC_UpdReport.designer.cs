namespace eMediShop
{
    partial class GC_UpdReport
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
            this.lv_Comp = new System.Windows.Forms.ListView();
            this.UID = new System.Windows.Forms.ColumnHeader();
            this.RegNo = new System.Windows.Forms.ColumnHeader();
            this.ValidUpto = new System.Windows.Forms.ColumnHeader();
            this.Remark = new System.Windows.Forms.ColumnHeader();
            this.compType = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.lv_Comp.Location = new System.Drawing.Point(4, 7);
            this.lv_Comp.Name = "lv_Comp";
            this.lv_Comp.Size = new System.Drawing.Size(666, 246);
            this.lv_Comp.TabIndex = 0;
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
            this.RegNo.Width = 146;
            // 
            // ValidUpto
            // 
            this.ValidUpto.Text = "ValidUpto";
            this.ValidUpto.Width = 85;
            // 
            // Remark
            // 
            this.Remark.Text = "Remark";
            this.Remark.Width = 413;
            // 
            // compType
            // 
            this.compType.Text = "comptype";
            this.compType.Width = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(4, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 179);
            this.panel1.TabIndex = 1;
            // 
            // GC_UpdReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_Comp);
            this.MaximizeBox = false;
            this.Name = "GC_UpdReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Upload Government Compliances";
            this.Load += new System.EventHandler(this.GC_UpdReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Comp;
        private System.Windows.Forms.ColumnHeader UID;
        private System.Windows.Forms.ColumnHeader RegNo;
        private System.Windows.Forms.ColumnHeader ValidUpto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.ColumnHeader compType;
    }
}