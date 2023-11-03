namespace eMediShop.Hospital
{
    partial class ucIndentChecking
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucIndentChecking));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_Info = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndentNo = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.rgv_detail = new Telerik.WinControls.UI.RadGridView();
            this.btnProcessSales = new Telerik.WinControls.UI.RadButton();
            this.rpv_Pages = new Telerik.WinControls.UI.RadPageView();
            this.rpvView1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.rgv_Header = new Telerik.WinControls.UI.RadGridView();
            this.rpvIndent = new Telerik.WinControls.UI.RadPageViewPage();
            this.rgvIndent = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndentNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpv_Pages)).BeginInit();
            this.rpv_Pages.SuspendLayout();
            this.rpvView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Header.MasterTemplate)).BeginInit();
            this.rpvIndent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvIndent.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_Info
            // 
            this.rgv_Info.BackColor = System.Drawing.SystemColors.Control;
            this.rgv_Info.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Info.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_Info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Info.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Info.Location = new System.Drawing.Point(4, 48);
            // 
            // 
            // 
            this.rgv_Info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Info.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "indent_no";
            gridViewTextBoxColumn1.HeaderText = "Indent No";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "indent_no";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "proctype";
            gridViewTextBoxColumn2.HeaderText = "Proc Type";
            gridViewTextBoxColumn2.Name = "proctype";
            gridViewTextBoxColumn2.Width = 155;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Trn_No";
            gridViewTextBoxColumn3.HeaderText = "Transaction No";
            gridViewTextBoxColumn3.Name = "Trn_No";
            gridViewTextBoxColumn3.Width = 151;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.HeaderImage")));
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column4";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "indentgroup";
            gridViewTextBoxColumn4.HeaderText = "indentgroup";
            gridViewTextBoxColumn4.Name = "indentgroup";
            this.rgv_Info.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1,
            gridViewTextBoxColumn4});
            this.rgv_Info.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "indentgroup";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_Info.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.rgv_Info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Info.Name = "rgv_Info";
            this.rgv_Info.ReadOnly = true;
            this.rgv_Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_Info.ShowGroupPanel = false;
            this.rgv_Info.Size = new System.Drawing.Size(386, 414);
            this.rgv_Info.TabIndex = 0;
            this.rgv_Info.Text = "radGridView1";
            this.rgv_Info.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_Info_CommandCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indent No.";
            // 
            // txtIndentNo
            // 
            this.txtIndentNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndentNo.Location = new System.Drawing.Point(79, 12);
            this.txtIndentNo.Name = "txtIndentNo";
            this.txtIndentNo.Size = new System.Drawing.Size(162, 25);
            this.txtIndentNo.TabIndex = 2;
            this.txtIndentNo.Text = "All";
            this.txtIndentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(248, 10);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(30, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = ">>";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // rgv_detail
            // 
            this.rgv_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgv_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_detail.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.rgv_detail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_detail.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.rgv_detail.MasterTemplate.AllowAddNewRow = false;
            this.rgv_detail.MasterTemplate.EnableFiltering = true;
            this.rgv_detail.MasterTemplate.EnableGrouping = false;
            this.rgv_detail.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_detail.Name = "rgv_detail";
            this.rgv_detail.ReadOnly = true;
            this.rgv_detail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_detail.ShowGroupPanel = false;
            this.rgv_detail.Size = new System.Drawing.Size(754, 247);
            this.rgv_detail.TabIndex = 1;
            this.rgv_detail.Text = "radGridView2";
            // 
            // btnProcessSales
            // 
            this.btnProcessSales.Enabled = false;
            this.btnProcessSales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessSales.Location = new System.Drawing.Point(1047, 18);
            this.btnProcessSales.Name = "btnProcessSales";
            this.btnProcessSales.Size = new System.Drawing.Size(128, 24);
            this.btnProcessSales.TabIndex = 4;
            this.btnProcessSales.Text = "Process Sales";
            this.btnProcessSales.Click += new System.EventHandler(this.btnProcessSales_Click);
            // 
            // rpv_Pages
            // 
            this.rpv_Pages.Controls.Add(this.rpvView1);
            this.rpv_Pages.Controls.Add(this.rpvIndent);
            this.rpv_Pages.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpv_Pages.Location = new System.Drawing.Point(397, 48);
            this.rpv_Pages.Name = "rpv_Pages";
            this.rpv_Pages.SelectedPage = this.rpvView1;
            this.rpv_Pages.Size = new System.Drawing.Size(778, 414);
            this.rpv_Pages.TabIndex = 5;
            this.rpv_Pages.Text = "radPageView1";
            // 
            // rpvView1
            // 
            this.rpvView1.Controls.Add(this.rgv_Header);
            this.rpvView1.Controls.Add(this.rgv_detail);
            this.rpvView1.ItemSize = new System.Drawing.SizeF(57F, 28F);
            this.rpvView1.Location = new System.Drawing.Point(10, 37);
            this.rpvView1.Name = "rpvView1";
            this.rpvView1.Size = new System.Drawing.Size(757, 366);
            this.rpvView1.Text = "Invoices";
            // 
            // rgv_Header
            // 
            this.rgv_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgv_Header.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Header.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.rgv_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv_Header.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Header.Location = new System.Drawing.Point(3, 256);
            // 
            // 
            // 
            this.rgv_Header.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Header.MasterTemplate.EnableFiltering = true;
            this.rgv_Header.MasterTemplate.EnableGrouping = false;
            this.rgv_Header.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgv_Header.Name = "rgv_Header";
            this.rgv_Header.ReadOnly = true;
            this.rgv_Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_Header.ShowGroupPanel = false;
            this.rgv_Header.Size = new System.Drawing.Size(754, 113);
            this.rgv_Header.TabIndex = 2;
            this.rgv_Header.Text = "radGridView2";
            // 
            // rpvIndent
            // 
            this.rpvIndent.Controls.Add(this.rgvIndent);
            this.rpvIndent.ItemSize = new System.Drawing.SizeF(69F, 28F);
            this.rpvIndent.Location = new System.Drawing.Point(10, 37);
            this.rpvIndent.Name = "rpvIndent";
            this.rpvIndent.Size = new System.Drawing.Size(757, 366);
            this.rpvIndent.Text = "Indent Info";
            // 
            // rgvIndent
            // 
            this.rgvIndent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgvIndent.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvIndent.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.rgvIndent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgvIndent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvIndent.Location = new System.Drawing.Point(1, 3);
            // 
            // 
            // 
            this.rgvIndent.MasterTemplate.AllowAddNewRow = false;
            this.rgvIndent.MasterTemplate.EnableFiltering = true;
            this.rgvIndent.MasterTemplate.EnableGrouping = false;
            this.rgvIndent.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgvIndent.Name = "rgvIndent";
            this.rgvIndent.ReadOnly = true;
            this.rgvIndent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvIndent.ShowGroupPanel = false;
            this.rgvIndent.Size = new System.Drawing.Size(754, 363);
            this.rgvIndent.TabIndex = 2;
            this.rgvIndent.Text = "radGridView2";
            // 
            // ucIndentChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rpv_Pages);
            this.Controls.Add(this.btnProcessSales);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtIndentNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgv_Info);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucIndentChecking";
            this.Size = new System.Drawing.Size(1183, 465);
            this.Load += new System.EventHandler(this.ucIndentChecking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndentNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpv_Pages)).EndInit();
            this.rpv_Pages.ResumeLayout(false);
            this.rpvView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Header.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Header)).EndInit();
            this.rpvIndent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvIndent.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvIndent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_Info;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtIndentNo;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView rgv_detail;
        private Telerik.WinControls.UI.RadButton btnProcessSales;
        private Telerik.WinControls.UI.RadPageView rpv_Pages;
        private Telerik.WinControls.UI.RadPageViewPage rpvView1;
        private Telerik.WinControls.UI.RadGridView rgv_Header;
        private Telerik.WinControls.UI.RadPageViewPage rpvIndent;
        private Telerik.WinControls.UI.RadGridView rgvIndent;
    }
}
