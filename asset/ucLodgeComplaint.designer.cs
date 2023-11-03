namespace eMediShop.Asset
{
    partial class ucLodgeComplaint
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtComplaint = new System.Windows.Forms.RichTextBox();
            this.txtEqpNo = new System.Windows.Forms.TextBox();
            this.dgAsset = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(12, 274);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "PROBLEM :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "EQUIPMENT NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(893, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(13, 294);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(950, 143);
            this.txtComplaint.TabIndex = 17;
            this.txtComplaint.Text = "";
            // 
            // txtEqpNo
            // 
            this.txtEqpNo.Location = new System.Drawing.Point(96, 5);
            this.txtEqpNo.Name = "txtEqpNo";
            this.txtEqpNo.Size = new System.Drawing.Size(159, 21);
            this.txtEqpNo.TabIndex = 23;
            // 
            // dgAsset
            // 
            this.dgAsset.BackColor = System.Drawing.SystemColors.Control;
            this.dgAsset.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAsset.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgAsset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgAsset.Location = new System.Drawing.Point(13, 34);
            // 
            // dgAsset
            // 
            this.dgAsset.MasterTemplate.AllowAddNewRow = false;
            this.dgAsset.MasterTemplate.AutoGenerateColumns = false;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "eq_no";
            gridViewCheckBoxColumn1.HeaderText = "Asset No";
            gridViewCheckBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "eq_no";
            gridViewCheckBoxColumn1.Width = 114;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "eq_name";
            gridViewTextBoxColumn1.HeaderText = "Aseet Name";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "eq_name";
            gridViewTextBoxColumn1.Width = 165;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "eq_category";
            gridViewTextBoxColumn2.HeaderText = "Category";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "eq_category";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 121;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "eq_serial_no";
            gridViewTextBoxColumn3.HeaderText = "Serial Number";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "eq_serial_no";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 111;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "eq_description";
            gridViewTextBoxColumn4.HeaderText = "Description";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "eq_description";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn4.Width = 400;
            this.dgAsset.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgAsset.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "eq_description";
            this.dgAsset.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAsset.Size = new System.Drawing.Size(951, 232);
            this.dgAsset.TabIndex = 25;
            this.dgAsset.Text = "radGridView2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(771, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Complaint Logging";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(261, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(27, 24);
            this.btnShow.TabIndex = 27;
            this.btnShow.Text = ">>";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ucLodgeComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAsset);
            this.Controls.Add(this.txtEqpNo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtComplaint);
            this.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucLodgeComplaint";
            this.Size = new System.Drawing.Size(972, 494);
            this.Load += new System.EventHandler(this.ucLodgeComplaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtComplaint;
        private System.Windows.Forms.TextBox txtEqpNo;
        private Telerik.WinControls.UI.RadGridView dgAsset;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnShow;
    }
}
