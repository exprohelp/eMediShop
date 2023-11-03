namespace eMediShop.Substitute
{
    partial class UCView
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
            this.lvStrength = new System.Windows.Forms.ListView();
            this.SaltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvStrength
            // 
            this.lvStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStrength.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaltName,
            this.Strength});
            this.lvStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStrength.FullRowSelect = true;
            this.lvStrength.GridLines = true;
            this.lvStrength.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStrength.HideSelection = false;
            this.lvStrength.Location = new System.Drawing.Point(10, 50);
            this.lvStrength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvStrength.Name = "lvStrength";
            this.lvStrength.Size = new System.Drawing.Size(548, 417);
            this.lvStrength.TabIndex = 7;
            this.lvStrength.UseCompatibleStateImageBehavior = false;
            this.lvStrength.View = System.Windows.Forms.View.Details;
            // 
            // SaltName
            // 
            this.SaltName.Text = "Salt Name";
            this.SaltName.Width = 402;
            // 
            // Strength
            // 
            this.Strength.Text = "Strength";
            this.Strength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Strength.Width = 118;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(8, 9);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(111, 37);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // UCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lvStrength);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCView";
            this.Size = new System.Drawing.Size(566, 475);
            this.Load += new System.EventHandler(this.UCView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStrength;
        private System.Windows.Forms.ColumnHeader SaltName;
        private System.Windows.Forms.ColumnHeader Strength;
        private System.Windows.Forms.Button btnView;
    }
}
