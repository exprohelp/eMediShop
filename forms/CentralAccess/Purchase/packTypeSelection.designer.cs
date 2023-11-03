namespace eMediShop
{
    partial class packTypeSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvPackType = new System.Windows.Forms.ListView();
            this.packType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.packQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pack Type Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "=============";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvPackType
            // 
            this.lvPackType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.packType,
            this.packQty});
            this.lvPackType.FullRowSelect = true;
            this.lvPackType.Location = new System.Drawing.Point(4, 44);
            this.lvPackType.Name = "lvPackType";
            this.lvPackType.Size = new System.Drawing.Size(155, 197);
            this.lvPackType.TabIndex = 2;
            this.lvPackType.UseCompatibleStateImageBehavior = false;
            this.lvPackType.View = System.Windows.Forms.View.Details;
            this.lvPackType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPackType_KeyDown);
            // 
            // packType
            // 
            this.packType.Text = "Pack Type";
            this.packType.Width = 90;
            // 
            // packQty
            // 
            this.packQty.Text = "P.Qty";
            this.packQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // packTypeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 245);
            this.Controls.Add(this.lvPackType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "packTypeSelection";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Pack Type";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.packTypeSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvPackType;
        private System.Windows.Forms.ColumnHeader packType;
        private System.Windows.Forms.ColumnHeader packQty;
    }
}
