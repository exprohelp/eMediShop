namespace eMediShop.Hospital.Sales
{
    partial class PreBookCounter
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreBookCounter));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgv_Pending = new Telerik.WinControls.UI.RadGridView();
            this.btn_refresh = new Telerik.WinControls.UI.RadButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rtb_receive = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Pending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Pending.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_receive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_Pending
            // 
            this.rgv_Pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_Pending.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_Pending.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_Pending.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_Pending.ForeColor = System.Drawing.Color.Black;
            this.rgv_Pending.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_Pending.Location = new System.Drawing.Point(0, 44);
            // 
            // 
            // 
            this.rgv_Pending.MasterTemplate.AllowAddNewRow = false;
            this.rgv_Pending.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "estimate_no";
            gridViewTextBoxColumn1.HeaderText = "Estimate No";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "estimate_no";
            gridViewTextBoxColumn1.Width = 127;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "token_no";
            gridViewTextBoxColumn2.HeaderText = "Token No";
            gridViewTextBoxColumn2.Name = "token_no";
            gridViewTextBoxColumn2.Width = 83;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "pt_name";
            gridViewTextBoxColumn3.HeaderText = "Customer Name";
            gridViewTextBoxColumn3.Name = "pt_name";
            gridViewTextBoxColumn3.Width = 224;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "sale_type";
            gridViewTextBoxColumn4.HeaderText = "Sale Type";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "sale_type";
            gridViewDecimalColumn1.AllowFiltering = false;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "net";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "Net Amount";
            gridViewDecimalColumn1.Name = "net";
            gridViewDecimalColumn1.Width = 85;
            gridViewTextBoxColumn5.AllowFiltering = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "hosp_ipop_no";
            gridViewTextBoxColumn5.HeaderText = "Indent No";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "hosp_ipop_no";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "-";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "hosp_cr_no";
            gridViewTextBoxColumn6.HeaderText = "hosp_cr_no";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "hosp_cr_no";
            this.rgv_Pending.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1,
            gridViewTextBoxColumn6});
            this.rgv_Pending.MasterTemplate.EnableFiltering = true;
            this.rgv_Pending.MasterTemplate.EnableGrouping = false;
            this.rgv_Pending.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_Pending.Name = "rgv_Pending";
            this.rgv_Pending.ReadOnly = true;
            this.rgv_Pending.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_Pending.Size = new System.Drawing.Size(456, 486);
            this.rgv_Pending.TabIndex = 0;
            this.rgv_Pending.Text = "radGridView1";
            this.rgv_Pending.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.rgv_Pending_RowFormatting);
            this.rgv_Pending.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_Pending_CommandCellClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = global::eMediShop.Properties.Resources.Refresh_16;
            this.btn_refresh.Location = new System.Drawing.Point(-1, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(76, 32);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // rtb_receive
            // 
            this.rtb_receive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_receive.Location = new System.Drawing.Point(188, 9);
            this.rtb_receive.Name = "rtb_receive";
            this.rtb_receive.NullText = "Type Sales Invoice No. To Receive";
            this.rtb_receive.Size = new System.Drawing.Size(268, 25);
            this.rtb_receive.TabIndex = 3;
            this.rtb_receive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rtb_receive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb_receive_KeyDown);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_receive.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.rtb_receive.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).NullText = "Type Sales Invoice No. To Receive";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).ToolTipText = "After Typing Press Enter Key";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.rtb_receive.GetChildAt(0).GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // PreBookCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 530);
            this.Controls.Add(this.rtb_receive);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.rgv_Pending);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PreBookCounter";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreBookCounter Window";
            this.Load += new System.EventHandler(this.PreBookCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Pending.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_Pending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtb_receive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_Pending;
        private Telerik.WinControls.UI.RadButton btn_refresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadTextBox rtb_receive;
    }
}