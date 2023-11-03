namespace eMediShop.forms.RCM
{
    partial class remarks
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.dgCALL = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCALL.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCALL
            // 
            this.dgCALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dgCALL.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgCALL.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgCALL.ForeColor = System.Drawing.Color.Black;
            this.dgCALL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgCALL.Location = new System.Drawing.Point(-1, 0);
            // 
            // dgCALL
            // 
            this.dgCALL.MasterTemplate.AllowAddNewRow = false;
            this.dgCALL.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "call_date";
            gridViewTextBoxColumn1.HeaderText = "Call Date Time";
            gridViewTextBoxColumn1.Name = "call_date";
            gridViewTextBoxColumn1.Width = 148;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "remarks";
            gridViewTextBoxColumn2.HeaderText = "Remarks";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "remarks";
            gridViewTextBoxColumn2.Width = 293;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "call_type";
            gridViewTextBoxColumn3.HeaderText = "Call Type";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "call_type";
            this.dgCALL.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgCALL.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "call_type";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgCALL.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.dgCALL.Name = "dgCALL";
            this.dgCALL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgCALL.ShowGroupPanel = false;
            this.dgCALL.Size = new System.Drawing.Size(499, 397);
            this.dgCALL.TabIndex = 0;
            this.dgCALL.Text = "radGridView1";
            // 
            // remarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 398);
            this.Controls.Add(this.dgCALL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "remarks";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.remarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCALL.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgCALL;

    }
}