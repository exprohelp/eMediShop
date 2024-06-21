namespace eMediShop.forms.Sales
{
    partial class uc_NewPurchases
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_NewPurchases));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXL = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rgv = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(233, 21);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(44, 30);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = ">>";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXL);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Medicine Sold During The Period.";
            // 
            // btnXL
            // 
            this.btnXL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXL.BackgroundImage")));
            this.btnXL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXL.Enabled = false;
            this.btnXL.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXL.Location = new System.Drawing.Point(752, 9);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(41, 40);
            this.btnXL.TabIndex = 67;
            this.btnXL.UseVisualStyleBackColor = true;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(106, 27);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(93, 22);
            this.dtTo.TabIndex = 21;
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(7, 27);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(93, 22);
            this.dtFrom.TabIndex = 20;
            this.dtFrom.Leave += new System.EventHandler(this.dtFrom_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(103, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "From";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // rgv
            // 
            this.rgv.BackColor = System.Drawing.SystemColors.Control;
            this.rgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv.Location = new System.Drawing.Point(4, 66);
            // 
            // 
            // 
            this.rgv.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "Item ID";
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.Width = 92;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "item_name";
            gridViewTextBoxColumn2.HeaderText = "Name of Product";
            gridViewTextBoxColumn2.Name = "item_name";
            gridViewTextBoxColumn2.Width = 403;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "firstRcptDate";
            gridViewTextBoxColumn3.HeaderText = "First Rcpt Date";
            gridViewTextBoxColumn3.Name = "firstRcptDate";
            gridViewTextBoxColumn3.Width = 94;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "firstSaleDate";
            gridViewTextBoxColumn4.HeaderText = "First Sale Date";
            gridViewTextBoxColumn4.Name = "firstSaleDate";
            gridViewTextBoxColumn4.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn4.Width = 98;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "LastSaleDate";
            gridViewTextBoxColumn5.HeaderText = "Last Sale Date";
            gridViewTextBoxColumn5.Name = "LastSaleDate";
            gridViewTextBoxColumn5.Width = 78;
            this.rgv.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.rgv.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "firstSaleDate";
            this.rgv.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv.Name = "rgv";
            this.rgv.ReadOnly = true;
            this.rgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv.Size = new System.Drawing.Size(799, 471);
            this.rgv.TabIndex = 68;
            this.rgv.Text = "radGridView1";
            // 
            // uc_NewPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uc_NewPurchases";
            this.Size = new System.Drawing.Size(806, 540);
            this.Load += new System.EventHandler(this.uc_NewPurchases_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnXL;
        private Telerik.WinControls.UI.RadGridView rgv;
    }
}
