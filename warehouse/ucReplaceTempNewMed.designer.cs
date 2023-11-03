namespace eMediShop.warehouse
{
    partial class ucReplaceTempNewMed
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
            this.GridNewMed = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.GrpSelectedMed = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ddlMedList = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.GridNewMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNewMed.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpSelectedMed)).BeginInit();
            this.GrpSelectedMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMedList)).BeginInit();
            this.SuspendLayout();
            // 
            // GridNewMed
            // 
            this.GridNewMed.BackColor = System.Drawing.SystemColors.Control;
            this.GridNewMed.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridNewMed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GridNewMed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GridNewMed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridNewMed.Location = new System.Drawing.Point(4, 43);
            this.GridNewMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            // 
            // GridNewMed
            // 
            this.GridNewMed.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "temp_id";
            gridViewTextBoxColumn1.HeaderText = "Temp.Id";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "temp_id";
            gridViewTextBoxColumn1.Width = 80;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "new_med";
            gridViewTextBoxColumn2.HeaderText = "Medicine Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "new_med";
            gridViewTextBoxColumn2.Width = 250;
            this.GridNewMed.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.GridNewMed.MasterTemplate.EnableFiltering = true;
            this.GridNewMed.Name = "GridNewMed";
            this.GridNewMed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridNewMed.ShowGroupPanel = false;
            this.GridNewMed.Size = new System.Drawing.Size(366, 538);
            this.GridNewMed.TabIndex = 0;
            this.GridNewMed.Text = "radGridView1";
            this.GridNewMed.Click += new System.EventHandler(this.GridNewMed_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(8, 8);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(214, 24);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "New Medicine Replacement ";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(7, 27);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(88, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Search Medicine";
            // 
            // GrpSelectedMed
            // 
            this.GrpSelectedMed.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GrpSelectedMed.Controls.Add(this.radButton1);
            this.GrpSelectedMed.Controls.Add(this.btnSave);
            this.GrpSelectedMed.Controls.Add(this.txtSearch);
            this.GrpSelectedMed.Controls.Add(this.radLabel2);
            this.GrpSelectedMed.Controls.Add(this.ddlMedList);
            this.GrpSelectedMed.Controls.Add(this.radLabel3);
            this.GrpSelectedMed.HeaderText = "";
            this.GrpSelectedMed.Location = new System.Drawing.Point(378, 43);
            this.GrpSelectedMed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GrpSelectedMed.Name = "GrpSelectedMed";
            this.GrpSelectedMed.Padding = new System.Windows.Forms.Padding(3, 21, 3, 2);
            this.GrpSelectedMed.Size = new System.Drawing.Size(426, 537);
            this.GrpSelectedMed.TabIndex = 4;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(258, 24);
            this.radButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(28, 28);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = ">>";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Text = ">>";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton1.GetChildAt(0))).Shape = this.ellipseShape1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(342, 90);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "REPLACE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(99, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(5, 60);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(85, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Select Medicine";
            // 
            // ddlMedList
            // 
            this.ddlMedList.Location = new System.Drawing.Point(99, 64);
            this.ddlMedList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ddlMedList.Name = "ddlMedList";
            this.ddlMedList.Size = new System.Drawing.Size(319, 20);
            this.ddlMedList.TabIndex = 4;
            // 
            // ucReplaceTempNewMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrpSelectedMed);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.GridNewMed);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucReplaceTempNewMed";
            this.Size = new System.Drawing.Size(808, 542);
            this.Load += new System.EventHandler(this.ucReplaceTempNewMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNewMed.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNewMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpSelectedMed)).EndInit();
            this.GrpSelectedMed.ResumeLayout(false);
            this.GrpSelectedMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GridNewMed;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGroupBox GrpSelectedMed;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList ddlMedList;
    }
}
