namespace eMediShop.Asset
{
    partial class ucComplaintStatus
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor3 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor3 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucComplaintStatus));
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.RichTextBox();
            this.txtEqpNo = new System.Windows.Forms.TextBox();
            this.dgAsset = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.tab2LblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab2BtnSubmit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.label18.Location = new System.Drawing.Point(14, 333);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "PROBLEM :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(15, 357);
            this.txtComplaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(942, 103);
            this.txtComplaint.TabIndex = 17;
            this.txtComplaint.Text = "";
            // 
            // txtEqpNo
            // 
            this.txtEqpNo.Location = new System.Drawing.Point(229, 6);
            this.txtEqpNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEqpNo.Name = "txtEqpNo";
            this.txtEqpNo.Size = new System.Drawing.Size(168, 25);
            this.txtEqpNo.TabIndex = 23;
            // 
            // dgAsset
            // 
            this.dgAsset.BackColor = System.Drawing.SystemColors.Control;
            this.dgAsset.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAsset.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgAsset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgAsset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgAsset.Location = new System.Drawing.Point(15, 41);
            this.dgAsset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // dgAsset
            // 
            this.dgAsset.MasterTemplate.AllowAddNewRow = false;
            this.dgAsset.MasterTemplate.AutoGenerateColumns = false;
            gridViewCheckBoxColumn3.EnableExpressionEditor = false;
            gridViewCheckBoxColumn3.FieldName = "cr_date";
            gridViewCheckBoxColumn3.HeaderText = "Date";
            gridViewCheckBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewCheckBoxColumn3.MinWidth = 20;
            gridViewCheckBoxColumn3.Name = "cr_date";
            gridViewCheckBoxColumn3.Width = 114;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "remarks";
            gridViewTextBoxColumn3.HeaderText = "Remark";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "remarks";
            gridViewTextBoxColumn3.Width = 870;
            this.dgAsset.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn3,
            gridViewTextBoxColumn3});
            sortDescriptor3.PropertyName = "cr_date";
            groupDescriptor3.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor3});
            this.dgAsset.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor3});
            this.dgAsset.Name = "dgAsset";
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            this.dgAsset.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.dgAsset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAsset.Size = new System.Drawing.Size(942, 282);
            this.dgAsset.TabIndex = 25;
            this.dgAsset.Text = "radGridView2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(782, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Complaint Status";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(405, 4);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(31, 29);
            this.btnShow.TabIndex = 27;
            this.btnShow.Text = ">>";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tab2LblStatus
            // 
            this.tab2LblStatus.AutoSize = true;
            this.tab2LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.tab2LblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab2LblStatus.Location = new System.Drawing.Point(553, 11);
            this.tab2LblStatus.Name = "tab2LblStatus";
            this.tab2LblStatus.Size = new System.Drawing.Size(13, 17);
            this.tab2LblStatus.TabIndex = 29;
            this.tab2LblStatus.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(479, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "STATUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "EQUIPMENT NO/COMPLAINT CODE";
            // 
            // tab2BtnSubmit
            // 
            this.tab2BtnSubmit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tab2BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tab2BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tab2BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.tab2BtnSubmit.Location = new System.Drawing.Point(871, 468);
            this.tab2BtnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab2BtnSubmit.Name = "tab2BtnSubmit";
            this.tab2BtnSubmit.Size = new System.Drawing.Size(86, 40);
            this.tab2BtnSubmit.TabIndex = 31;
            this.tab2BtnSubmit.Text = "SUBMIT";
            this.tab2BtnSubmit.UseVisualStyleBackColor = false;
            this.tab2BtnSubmit.Click += new System.EventHandler(this.tab2BtnSubmit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 479);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(314, 24);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Mark the Check Box to Close the Complaint";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ucComplaintStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tab2BtnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tab2LblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAsset);
            this.Controls.Add(this.txtEqpNo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComplaint);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucComplaintStatus";
            this.Size = new System.Drawing.Size(969, 510);
            this.Load += new System.EventHandler(this.ucLodgeComplaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtComplaint;
        private System.Windows.Forms.TextBox txtEqpNo;
        private Telerik.WinControls.UI.RadGridView dgAsset;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnShow;
        private System.Windows.Forms.Label tab2LblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tab2BtnSubmit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
