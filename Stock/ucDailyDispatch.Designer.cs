namespace eMediShop.Stock
{
    partial class ucDailyDispatch
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvDailyDispatchStatus = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlUnits = new Telerik.WinControls.UI.RadDropDownList();
            this.btnProcess = new Telerik.WinControls.UI.RadButton();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDailyDispatchStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDailyDispatchStatus.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvDailyDispatchStatus
            // 
            this.rgvDailyDispatchStatus.BackColor = System.Drawing.SystemColors.Control;
            this.rgvDailyDispatchStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvDailyDispatchStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvDailyDispatchStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvDailyDispatchStatus.ForeColor = System.Drawing.Color.Black;
            this.rgvDailyDispatchStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvDailyDispatchStatus.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgvDailyDispatchStatus.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "item_id";
            gridViewTextBoxColumn5.HeaderText = "Item ID";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "item_id";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "item_name";
            gridViewTextBoxColumn6.HeaderText = "Name of Product";
            gridViewTextBoxColumn6.Name = "item_name";
            gridViewTextBoxColumn6.Width = 340;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "pack_type";
            gridViewTextBoxColumn7.HeaderText = "Pack Type";
            gridViewTextBoxColumn7.Name = "pack_type";
            gridViewTextBoxColumn7.Width = 76;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "pack_qty";
            gridViewDecimalColumn7.HeaderText = "Pack Qty";
            gridViewDecimalColumn7.Name = "pack_qty";
            gridViewDecimalColumn7.Width = 61;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "asp";
            gridViewDecimalColumn8.FormatString = "{0:N0}";
            gridViewDecimalColumn8.HeaderText = "Act Sold Packs";
            gridViewDecimalColumn8.Name = "asp";
            gridViewDecimalColumn8.Width = 95;
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "psap";
            gridViewDecimalColumn9.FormatString = "{0:N0}";
            gridViewDecimalColumn9.HeaderText = "Pur. Sale Avg. Packs";
            gridViewDecimalColumn9.Name = "psap";
            gridViewDecimalColumn9.Width = 122;
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FieldName = "InUnitStock";
            gridViewDecimalColumn10.FormatString = "{0:N0}";
            gridViewDecimalColumn10.HeaderText = "InUnitStock";
            gridViewDecimalColumn10.Name = "InUnitStock";
            gridViewDecimalColumn10.Width = 89;
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.FieldName = "InWHStock";
            gridViewDecimalColumn11.FormatString = "{0:N0}";
            gridViewDecimalColumn11.HeaderText = "InWHStock";
            gridViewDecimalColumn11.Name = "InWHStock";
            gridViewDecimalColumn11.Width = 75;
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.FieldName = "QtyInPacks";
            gridViewDecimalColumn12.FormatString = "{0:N0}";
            gridViewDecimalColumn12.HeaderText = "Dispatch Packs";
            gridViewDecimalColumn12.Name = "QtyInPacks";
            gridViewDecimalColumn12.Width = 85;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "alert";
            gridViewTextBoxColumn8.HeaderText = "Alert";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "alert";
            this.rgvDailyDispatchStatus.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDecimalColumn10,
            gridViewDecimalColumn11,
            gridViewDecimalColumn12,
            gridViewTextBoxColumn8});
            this.rgvDailyDispatchStatus.MasterTemplate.EnableGrouping = false;
            this.rgvDailyDispatchStatus.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvDailyDispatchStatus.Name = "rgvDailyDispatchStatus";
            this.rgvDailyDispatchStatus.ReadOnly = true;
            this.rgvDailyDispatchStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvDailyDispatchStatus.Size = new System.Drawing.Size(981, 423);
            this.rgvDailyDispatchStatus.TabIndex = 0;
            this.rgvDailyDispatchStatus.Text = "radGridView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgvDailyDispatchStatus);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Daily Dispatch Product\'s With Stock";
            this.radGroupBox1.Location = new System.Drawing.Point(4, 50);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(985, 443);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Daily Dispatch Product\'s With Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Unit";
            // 
            // ddlUnits
            // 
            this.ddlUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlUnits.Location = new System.Drawing.Point(93, 9);
            this.ddlUnits.Name = "ddlUnits";
            this.ddlUnits.Size = new System.Drawing.Size(355, 25);
            this.ddlUnits.TabIndex = 4;
            this.ddlUnits.Text = "Select";
            this.ddlUnits.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlUnits_SelectedIndexChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(923, 6);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(64, 35);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(454, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(38, 25);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // ucDailyDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.ddlUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucDailyDispatch";
            this.Size = new System.Drawing.Size(992, 496);
            this.Load += new System.EventHandler(this.ucDailyDispatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvDailyDispatchStatus.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDailyDispatchStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvDailyDispatchStatus;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList ddlUnits;
        private Telerik.WinControls.UI.RadButton btnProcess;
        private Telerik.WinControls.UI.RadButton btnGo;
    }
}
