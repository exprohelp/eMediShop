namespace eMediShop.Substitute
{
    partial class UCSubstituteReport
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
            this.lvProduct = new System.Windows.Forms.ListView();
            this.ItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSubstitute = new System.Windows.Forms.ListView();
            this.SaltCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Crdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProduct
            // 
            this.lvProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.ItemName});
            this.lvProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(8, 60);
            this.lvProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(302, 462);
            this.lvProduct.TabIndex = 8;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvProduct_KeyDown);
            this.lvProduct.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProduct_MouseDoubleClick);
            // 
            // ItemId
            // 
            this.ItemId.Text = "ItemId";
            this.ItemId.Width = 1;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Product Name";
            this.ItemName.Width = 274;
            // 
            // lvSubstitute
            // 
            this.lvSubstitute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSubstitute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaltCode,
            this.SaltName,
            this.Strength,
            this.Crdate});
            this.lvSubstitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSubstitute.FullRowSelect = true;
            this.lvSubstitute.GridLines = true;
            this.lvSubstitute.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSubstitute.HideSelection = false;
            this.lvSubstitute.Location = new System.Drawing.Point(316, 60);
            this.lvSubstitute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvSubstitute.Name = "lvSubstitute";
            this.lvSubstitute.Size = new System.Drawing.Size(492, 462);
            this.lvSubstitute.TabIndex = 9;
            this.lvSubstitute.UseCompatibleStateImageBehavior = false;
            this.lvSubstitute.View = System.Windows.Forms.View.Details;
            // 
            // SaltCode
            // 
            this.SaltCode.Text = "Code";
            this.SaltCode.Width = 61;
            // 
            // SaltName
            // 
            this.SaltName.Text = "Salt Name";
            this.SaltName.Width = 211;
            // 
            // Strength
            // 
            this.Strength.Text = "Strength";
            this.Strength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Strength.Width = 118;
            // 
            // Crdate
            // 
            this.Crdate.Text = "Creation Date";
            this.Crdate.Width = 79;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(41, 26);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(105, 20);
            this.dtFrom.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(180, 26);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(105, 20);
            this.dtTo.TabIndex = 12;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(292, 25);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(47, 30);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // UCSubstituteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.lvSubstitute);
            this.Controls.Add(this.lvProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCSubstituteReport";
            this.Size = new System.Drawing.Size(808, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ListView lvSubstitute;
        private System.Windows.Forms.ColumnHeader SaltName;
        private System.Windows.Forms.ColumnHeader Strength;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.ColumnHeader Crdate;
        private System.Windows.Forms.ColumnHeader SaltCode;
    }
}
