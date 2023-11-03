namespace eMediShop.forms.CentralAccess.RCM
{
    partial class add_regularorder
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
            this.components = new System.ComponentModel.Container();
            this.chkOld = new System.Windows.Forms.CheckBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.itemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNewproduct = new System.Windows.Forms.ListView();
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // chkOld
            // 
            this.chkOld.AutoSize = true;
            this.chkOld.Location = new System.Drawing.Point(6, 37);
            this.chkOld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkOld.Name = "chkOld";
            this.chkOld.Size = new System.Drawing.Size(83, 21);
            this.chkOld.TabIndex = 0;
            this.chkOld.Text = "OLD PUR.";
            this.toolTip1.SetToolTip(this.chkOld, "After ticking of old pur you will get the last 3 month purchased medicine by the " +
        "card holder\r\n");
            this.chkOld.UseVisualStyleBackColor = true;
            this.chkOld.CheckedChanged += new System.EventHandler(this.chkOld_CheckedChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(105, 33);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(372, 22);
            this.txtItemName.TabIndex = 33;
            this.toolTip1.SetToolTip(this.txtItemName, "F5 Key :To add new medicine");
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(484, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 31);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvItems
            // 
            this.lvItems.CheckBoxes = true;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemId,
            this.MedName});
            this.lvItems.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItems.Location = new System.Drawing.Point(6, 65);
            this.lvItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(535, 353);
            this.lvItems.TabIndex = 35;
            this.toolTip1.SetToolTip(this.lvItems, "Green color represents already added in regular medicine");
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvItems_KeyDown);
            // 
            // itemId
            // 
            this.itemId.Text = "";
            this.itemId.Width = 20;
            // 
            // MedName
            // 
            this.MedName.Text = "Item Name";
            this.MedName.Width = 436;
            // 
            // lvNewproduct
            // 
            this.lvNewproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvNewproduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.ProductName});
            this.lvNewproduct.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNewproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lvNewproduct.FullRowSelect = true;
            this.lvNewproduct.GridLines = true;
            this.lvNewproduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvNewproduct.Location = new System.Drawing.Point(6, 422);
            this.lvNewproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvNewproduct.Name = "lvNewproduct";
            this.lvNewproduct.Size = new System.Drawing.Size(435, 6);
            this.lvNewproduct.TabIndex = 36;
            this.lvNewproduct.UseCompatibleStateImageBehavior = false;
            this.lvNewproduct.View = System.Windows.Forms.View.Details;
            this.lvNewproduct.Visible = false;
            this.lvNewproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvNewproduct_KeyDown);
            // 
            // item
            // 
            this.item.Text = "itemid";
            this.item.Width = 0;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 350;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(140, 5);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(251, 18);
            this.lbl.TabIndex = 37;
            this.lbl.Text = "REGULAR CUSTOMER MEDICINE";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(456, 424);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 31);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // add_regularorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 471);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lvNewproduct);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.chkOld);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "add_regularorder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.add_regularorder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOld;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ListView lvNewproduct;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ColumnHeader itemId;
        private System.Windows.Forms.ColumnHeader MedName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}