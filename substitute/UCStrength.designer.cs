namespace eMediShop.Substitute
{
    partial class UCStrength
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtModifyStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvStrengtnName = new System.Windows.Forms.ListView();
            this.salt_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.txtModifyStr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 408);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(546, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(455, 17);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 38);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtModifyStr
            // 
            this.txtModifyStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModifyStr.Location = new System.Drawing.Point(92, 20);
            this.txtModifyStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModifyStr.Name = "txtModifyStr";
            this.txtModifyStr.Size = new System.Drawing.Size(352, 26);
            this.txtModifyStr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salt Name";
            // 
            // lvStrengtnName
            // 
            this.lvStrengtnName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.salt_code,
            this.SaltName});
            this.lvStrengtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStrengtnName.FullRowSelect = true;
            this.lvStrengtnName.GridLines = true;
            this.lvStrengtnName.HideSelection = false;
            this.lvStrengtnName.Location = new System.Drawing.Point(14, 90);
            this.lvStrengtnName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvStrengtnName.Name = "lvStrengtnName";
            this.lvStrengtnName.Size = new System.Drawing.Size(546, 314);
            this.lvStrengtnName.TabIndex = 4;
            this.lvStrengtnName.UseCompatibleStateImageBehavior = false;
            this.lvStrengtnName.View = System.Windows.Forms.View.Details;
            this.lvStrengtnName.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvStrengtnName_ItemSelectionChanged);
            // 
            // salt_code
            // 
            this.salt_code.Text = "Code";
            this.salt_code.Width = 103;
            // 
            // SaltName
            // 
            this.SaltName.Text = "Strength";
            this.SaltName.Width = 408;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtStrName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(546, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(484, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStrName
            // 
            this.txtStrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStrName.Location = new System.Drawing.Point(121, 20);
            this.txtStrName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStrName.Name = "txtStrName";
            this.txtStrName.Size = new System.Drawing.Size(352, 26);
            this.txtStrName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength Type";
            // 
            // UCStrength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvStrengtnName);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCStrength";
            this.Size = new System.Drawing.Size(565, 484);
            this.Load += new System.EventHandler(this.UCStrength_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtModifyStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvStrengtnName;
        private System.Windows.Forms.ColumnHeader salt_code;
        private System.Windows.Forms.ColumnHeader SaltName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStrName;
        private System.Windows.Forms.Label label1;

    }
}
