namespace eMediShop.forms.CentralAccess.RCM
{
    partial class order_remarks
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.dgRemarks = new Telerik.WinControls.UI.RadGridView();
            this.txtOrderNo = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.txtExistingRemark = new Telerik.WinControls.UI.RadTextBox();
            this.txtRemark = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.chkCancelOrder = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemarks.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistingRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRemarks
            // 
            this.dgRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.dgRemarks.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgRemarks.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgRemarks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgRemarks.Location = new System.Drawing.Point(0, 27);
            // 
            // dgRemarks
            // 
            this.dgRemarks.MasterTemplate.AllowAddNewRow = false;
            this.dgRemarks.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "RemarkFrom";
            gridViewTextBoxColumn1.HeaderText = "Remark From";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "RemarkFrom";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "cr_date";
            gridViewTextBoxColumn2.HeaderText = "Date";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "cr_date";
            gridViewTextBoxColumn2.Width = 147;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Remark";
            gridViewTextBoxColumn3.HeaderText = "Remark";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "Remark";
            gridViewTextBoxColumn3.Width = 198;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "emp_name";
            gridViewTextBoxColumn4.HeaderText = "Remark By";
            gridViewTextBoxColumn4.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "emp_name";
            gridViewTextBoxColumn4.Width = 144;
            this.dgRemarks.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgRemarks.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "RemarkFrom";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgRemarks.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.dgRemarks.Name = "dgRemarks";
            this.dgRemarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgRemarks.Size = new System.Drawing.Size(524, 247);
            this.dgRemarks.TabIndex = 39;
            this.dgRemarks.Click += new System.EventHandler(this.dgRemarks_Click);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Enabled = false;
            this.txtOrderNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Location = new System.Drawing.Point(204, 1);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(133, 23);
            this.txtOrderNo.TabIndex = 40;
            this.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtOrderNo.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtOrderNo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // txtExistingRemark
            // 
            this.txtExistingRemark.AutoSize = false;
            this.txtExistingRemark.Enabled = false;
            this.txtExistingRemark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistingRemark.Location = new System.Drawing.Point(0, 276);
            this.txtExistingRemark.Multiline = true;
            this.txtExistingRemark.Name = "txtExistingRemark";
            this.txtExistingRemark.Size = new System.Drawing.Size(524, 43);
            this.txtExistingRemark.TabIndex = 41;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtExistingRemark.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtExistingRemark.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // txtRemark
            // 
            this.txtRemark.AutoSize = false;
            this.txtRemark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(0, 348);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(472, 43);
            this.txtRemark.TabIndex = 42;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtRemark.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtRemark.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(476, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 40);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkCancelOrder
            // 
            this.chkCancelOrder.AutoSize = true;
            this.chkCancelOrder.Location = new System.Drawing.Point(0, 326);
            this.chkCancelOrder.Name = "chkCancelOrder";
            this.chkCancelOrder.Size = new System.Drawing.Size(93, 17);
            this.chkCancelOrder.TabIndex = 44;
            this.chkCancelOrder.Text = "Cancel Order";
            this.chkCancelOrder.UseVisualStyleBackColor = true;
            // 
            // order_remarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 393);
            this.Controls.Add(this.chkCancelOrder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtExistingRemark);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.dgRemarks);
            this.Name = "order_remarks";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.order_remarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRemarks.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistingRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgRemarks;
        private Telerik.WinControls.UI.RadTextBox txtOrderNo;
        private Telerik.WinControls.UI.RadTextBox txtExistingRemark;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadTextBox txtRemark;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.CheckBox chkCancelOrder;
    }
}
