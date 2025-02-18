namespace eMediShop.LocalWarehouse
{
    partial class ucLW_Orders
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLW_Orders));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.rpvp_orderView = new Telerik.WinControls.UI.RadPageViewPage();
            this.btnXL = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgv_ditributed = new Telerik.WinControls.UI.RadGridView();
            this.rgvOrderInfo = new Telerik.WinControls.UI.RadGridView();
            this.rgvOrders = new Telerik.WinControls.UI.RadGridView();
            this.rpvp_generate = new Telerik.WinControls.UI.RadPageViewPage();
            this.btnGenPo = new Telerik.WinControls.UI.RadButton();
            this.txtProductNo = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderFor = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.rpvp_orderView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ditributed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ditributed.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrders.MasterTemplate)).BeginInit();
            this.rpvp_generate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenPo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.rpvp_orderView);
            this.radPageView1.Controls.Add(this.rpvp_generate);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.rpvp_orderView;
            this.radPageView1.Size = new System.Drawing.Size(1100, 535);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            // 
            // rpvp_orderView
            // 
            this.rpvp_orderView.Controls.Add(this.btnClose);
            this.rpvp_orderView.Controls.Add(this.btnXL);
            this.rpvp_orderView.Controls.Add(this.radGroupBox1);
            this.rpvp_orderView.Controls.Add(this.rgvOrders);
            this.rpvp_orderView.ItemSize = new System.Drawing.SizeF(50F, 34F);
            this.rpvp_orderView.Location = new System.Drawing.Point(10, 43);
            this.rpvp_orderView.Name = "rpvp_orderView";
            this.rpvp_orderView.Size = new System.Drawing.Size(1079, 481);
            this.rpvp_orderView.Text = "View";
            // 
            // btnXL
            // 
            this.btnXL.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnXL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXL.Location = new System.Drawing.Point(1037, 19);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(38, 39);
            this.btnXL.TabIndex = 2;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_ditributed);
            this.radGroupBox1.Controls.Add(this.rgvOrderInfo);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "XXXXXXXXXXXX";
            this.radGroupBox1.Location = new System.Drawing.Point(259, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(771, 477);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "XXXXXXXXXXXX";
            // 
            // rgv_ditributed
            // 
            this.rgv_ditributed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgv_ditributed.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_ditributed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_ditributed.ForeColor = System.Drawing.Color.Black;
            this.rgv_ditributed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_ditributed.Location = new System.Drawing.Point(5, 337);
            // 
            // 
            // 
            this.rgv_ditributed.MasterTemplate.AllowAddNewRow = false;
            this.rgv_ditributed.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgv_ditributed.MasterTemplate.EnableGrouping = false;
            this.rgv_ditributed.MasterTemplate.EnableSorting = false;
            this.rgv_ditributed.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.rgv_ditributed.Name = "rgv_ditributed";
            this.rgv_ditributed.ReadOnly = true;
            this.rgv_ditributed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_ditributed.Size = new System.Drawing.Size(761, 131);
            this.rgv_ditributed.TabIndex = 2;
            this.rgv_ditributed.Text = "radGridView2";
            // 
            // rgvOrderInfo
            // 
            this.rgvOrderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgvOrderInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvOrderInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvOrderInfo.ForeColor = System.Drawing.Color.Black;
            this.rgvOrderInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvOrderInfo.Location = new System.Drawing.Point(5, 21);
            // 
            // 
            // 
            this.rgvOrderInfo.MasterTemplate.AllowAddNewRow = false;
            this.rgvOrderInfo.MasterTemplate.EnableAlternatingRowColor = true;
            this.rgvOrderInfo.MasterTemplate.EnableFiltering = true;
            this.rgvOrderInfo.MasterTemplate.EnableGrouping = false;
            this.rgvOrderInfo.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.rgvOrderInfo.Name = "rgvOrderInfo";
            this.rgvOrderInfo.ReadOnly = true;
            this.rgvOrderInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvOrderInfo.ShowGroupPanel = false;
            this.rgvOrderInfo.Size = new System.Drawing.Size(761, 310);
            this.rgvOrderInfo.TabIndex = 1;
            this.rgvOrderInfo.Text = "radGridView2";
            this.rgvOrderInfo.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvOrderInfo_CellDoubleClick);
            // 
            // rgvOrders
            // 
            this.rgvOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.rgvOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvOrders.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgvOrders.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvOrders.Location = new System.Drawing.Point(4, 4);
            // 
            // 
            // 
            this.rgvOrders.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "order_no";
            gridViewTextBoxColumn2.HeaderText = "Order No";
            gridViewTextBoxColumn2.Name = "order_no";
            gridViewTextBoxColumn2.Width = 191;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "-";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.Name = "column2";
            gridViewCommandColumn2.Width = 25;
            this.rgvOrders.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2,
            gridViewCommandColumn2});
            this.rgvOrders.MasterTemplate.EnableGrouping = false;
            this.rgvOrders.MasterTemplate.EnableSorting = false;
            this.rgvOrders.MasterTemplate.ViewDefinition = tableViewDefinition6;
            this.rgvOrders.Name = "rgvOrders";
            this.rgvOrders.ReadOnly = true;
            this.rgvOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvOrders.Size = new System.Drawing.Size(248, 474);
            this.rgvOrders.TabIndex = 0;
            this.rgvOrders.Text = "radGridView1";
            this.rgvOrders.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgvOrders_CommandCellClick);
            // 
            // rpvp_generate
            // 
            this.rpvp_generate.Controls.Add(this.lblMessage);
            this.rpvp_generate.Controls.Add(this.btnGenPo);
            this.rpvp_generate.Controls.Add(this.txtProductNo);
            this.rpvp_generate.Controls.Add(this.label2);
            this.rpvp_generate.Controls.Add(this.txtOrderFor);
            this.rpvp_generate.Controls.Add(this.label1);
            this.rpvp_generate.ItemSize = new System.Drawing.SizeF(123F, 34F);
            this.rpvp_generate.Location = new System.Drawing.Point(10, 43);
            this.rpvp_generate.Name = "rpvp_generate";
            this.rpvp_generate.Size = new System.Drawing.Size(1079, 481);
            this.rpvp_generate.Text = "Generate/Close";
            // 
            // btnGenPo
            // 
            this.btnGenPo.Location = new System.Drawing.Point(544, 39);
            this.btnGenPo.Name = "btnGenPo";
            this.btnGenPo.Size = new System.Drawing.Size(110, 24);
            this.btnGenPo.TabIndex = 4;
            this.btnGenPo.Text = "Generate Orders";
            this.btnGenPo.Click += new System.EventHandler(this.btnGenPo_Click);
            // 
            // txtProductNo
            // 
            this.txtProductNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNo.Location = new System.Drawing.Point(322, 39);
            this.txtProductNo.MaxLength = 5;
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.Size = new System.Drawing.Size(132, 25);
            this.txtProductNo.TabIndex = 3;
            this.txtProductNo.Text = "99999";
            this.txtProductNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtProductNo.GetChildAt(0))).Text = "99999";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtProductNo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order For ? Months";
            // 
            // txtOrderFor
            // 
            this.txtOrderFor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderFor.Location = new System.Drawing.Point(22, 39);
            this.txtOrderFor.MaxLength = 5;
            this.txtOrderFor.Name = "txtOrderFor";
            this.txtOrderFor.Size = new System.Drawing.Size(132, 25);
            this.txtOrderFor.TabIndex = 1;
            this.txtOrderFor.Text = "2";
            this.txtOrderFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtOrderFor.GetChildAt(0))).Text = "2";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtOrderFor.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of products";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(20, 99);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(78, 20);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message : ";
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Image = global::eMediShop.Properties.Resources.Close_32;
            this.btnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(1036, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucLW_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPageView1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucLW_Orders";
            this.Size = new System.Drawing.Size(1100, 535);
            this.Load += new System.EventHandler(this.ucLW_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.rpvp_orderView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ditributed.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_ditributed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrders.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOrders)).EndInit();
            this.rpvp_generate.ResumeLayout(false);
            this.rpvp_generate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenPo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage rpvp_orderView;
        private Telerik.WinControls.UI.RadPageViewPage rpvp_generate;
        private Telerik.WinControls.UI.RadButton btnXL;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView rgvOrderInfo;
        private Telerik.WinControls.UI.RadGridView rgvOrders;
        private Telerik.WinControls.UI.RadTextBox txtProductNo;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txtOrderFor;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton btnGenPo;
        private Telerik.WinControls.UI.RadGridView rgv_ditributed;
        private System.Windows.Forms.Label lblMessage;
        private Telerik.WinControls.UI.RadButton btnClose;
    }
}
