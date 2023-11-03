namespace eMediShop.Substitute
{
    partial class UCSaltInfo
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFillSalt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSaltName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saltCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saltName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rgvSaltInfo = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaltInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaltInfo.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFillSalt);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtSaltName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(680, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnFillSalt
            // 
            this.btnFillSalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillSalt.Location = new System.Drawing.Point(15, 16);
            this.btnFillSalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFillSalt.Name = "btnFillSalt";
            this.btnFillSalt.Size = new System.Drawing.Size(102, 38);
            this.btnFillSalt.TabIndex = 3;
            this.btnFillSalt.Text = "Fill Salts Info";
            this.btnFillSalt.UseVisualStyleBackColor = true;
            this.btnFillSalt.Click += new System.EventHandler(this.btnFillSalt_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(612, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSaltName
            // 
            this.txtSaltName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaltName.Location = new System.Drawing.Point(238, 22);
            this.txtSaltName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaltName.Name = "txtSaltName";
            this.txtSaltName.Size = new System.Drawing.Size(352, 26);
            this.txtSaltName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salt Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(3, 486);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(680, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Note : To Edit Double Click On Salt Name Then Modify The Name and Press Enter To " +
    "Update The Name";
            // 
            // saltCode
            // 
            this.saltCode.Text = "Code";
            this.saltCode.Width = 62;
            // 
            // saltName
            // 
            this.saltName.Text = "Salt Name";
            this.saltName.Width = 679;
            // 
            // rgvSaltInfo
            // 
            this.rgvSaltInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rgvSaltInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvSaltInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvSaltInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgvSaltInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvSaltInfo.Location = new System.Drawing.Point(4, 72);
            // 
            // 
            // 
            this.rgvSaltInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "salt_code";
            gridViewTextBoxColumn1.HeaderText = "Salt Code";
            gridViewTextBoxColumn1.Name = "salt_code";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 82;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "salt_name";
            gridViewTextBoxColumn2.HeaderText = "Name of salt";
            gridViewTextBoxColumn2.Name = "salt_name";
            gridViewTextBoxColumn2.Width = 460;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ItemCount";
            gridViewTextBoxColumn3.HeaderText = "Nos";
            gridViewTextBoxColumn3.Name = "ItemCount";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 82;
            this.rgvSaltInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.rgvSaltInfo.MasterTemplate.EnableFiltering = true;
            this.rgvSaltInfo.MasterTemplate.EnableGrouping = false;
            this.rgvSaltInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvSaltInfo.Name = "rgvSaltInfo";
            this.rgvSaltInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvSaltInfo.Size = new System.Drawing.Size(679, 417);
            this.rgvSaltInfo.TabIndex = 3;
            this.rgvSaltInfo.Text = "radGridView1";
            this.rgvSaltInfo.CellBeginEdit += new Telerik.WinControls.UI.GridViewCellCancelEventHandler(this.rgvSaltInfo_CellBeginEdit);
            this.rgvSaltInfo.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvSaltInfo_CellEndEdit);
            this.rgvSaltInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rgvSaltInfo_KeyDown);
            // 
            // UCSaltInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgvSaltInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCSaltInfo";
            this.Size = new System.Drawing.Size(692, 542);
            this.Load += new System.EventHandler(this.UCSaltInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaltInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaltInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaltName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader saltCode;
        private System.Windows.Forms.ColumnHeader saltName;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView rgvSaltInfo;
        private System.Windows.Forms.Button btnFillSalt;
    }
}
