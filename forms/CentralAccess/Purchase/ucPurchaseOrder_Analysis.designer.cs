namespace eMediShop.forms.CentralAccess.Purchase
{
    partial class ucPurchaseOrder_Analysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPurchaseOrder_Analysis));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrer_Nos = new System.Windows.Forms.ComboBox();
            this.gb_info = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnBest = new System.Windows.Forms.Button();
            this.btnExcess = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btn_perfect = new System.Windows.Forms.Button();
            this.btnXL = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_detail = new System.Windows.Forms.GroupBox();
            this.btnReturnReport = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReturnPack = new System.Windows.Forms.Button();
            this.txtRetPacks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lv_keyInfo = new System.Windows.Forms.ListView();
            this.masterkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PackQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Batch_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PurchQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITFREE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taxRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mnpr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.V_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_detail = new System.Windows.Forms.ListView();
            this.gbRetReport = new System.Windows.Forms.GroupBox();
            this.lv_RetReport = new System.Windows.Forms.ListView();
            this.r_master_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rItem_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rPackType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rPackQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rMRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rBatchNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rExp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rNPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rRetQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.origin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.gb_detail.SuspendLayout();
            this.gbRetReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Purchase Order No";
            // 
            // cmbOrer_Nos
            // 
            this.cmbOrer_Nos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrer_Nos.FormattingEnabled = true;
            this.cmbOrer_Nos.Location = new System.Drawing.Point(15, 34);
            this.cmbOrer_Nos.Name = "cmbOrer_Nos";
            this.cmbOrer_Nos.Size = new System.Drawing.Size(258, 24);
            this.cmbOrer_Nos.TabIndex = 52;
            this.toolTip1.SetToolTip(this.cmbOrer_Nos, "Press Enter Key To Seprate Data");
            this.cmbOrer_Nos.SelectedIndexChanged += new System.EventHandler(this.cmbOrer_Nos_SelectedIndexChanged);
            this.cmbOrer_Nos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrer_Nos_KeyDown);
            this.cmbOrer_Nos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbOrer_Nos_KeyUp);
            this.cmbOrer_Nos.MouseEnter += new System.EventHandler(this.cmbOrer_Nos_MouseEnter);
            // 
            // gb_info
            // 
            this.gb_info.Controls.Add(this.btnRefresh);
            this.gb_info.Controls.Add(this.btnDiff);
            this.gb_info.Controls.Add(this.btnBest);
            this.gb_info.Controls.Add(this.btnExcess);
            this.gb_info.Controls.Add(this.btnShort);
            this.gb_info.Controls.Add(this.btn_perfect);
            this.gb_info.Controls.Add(this.btnXL);
            this.gb_info.Controls.Add(this.btnSummary);
            this.gb_info.Controls.Add(this.label7);
            this.gb_info.Controls.Add(this.label6);
            this.gb_info.Controls.Add(this.label5);
            this.gb_info.Controls.Add(this.label4);
            this.gb_info.Controls.Add(this.label3);
            this.gb_info.Controls.Add(this.txtTotal);
            this.gb_info.Controls.Add(this.label2);
            this.gb_info.Controls.Add(this.cmbOrer_Nos);
            this.gb_info.Controls.Add(this.label1);
            this.gb_info.Location = new System.Drawing.Point(5, 0);
            this.gb_info.Name = "gb_info";
            this.gb_info.Size = new System.Drawing.Size(934, 69);
            this.gb_info.TabIndex = 53;
            this.gb_info.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::eMediShop.Properties.Resources.Refresh_32;
            this.btnRefresh.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Location = new System.Drawing.Point(801, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 38);
            this.btnRefresh.TabIndex = 72;
            this.btnRefresh.Text = "-";
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresh Purchase Packs");
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiff.ForeColor = System.Drawing.Color.Red;
            this.btnDiff.Location = new System.Drawing.Point(737, 35);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(58, 26);
            this.btnDiff.TabIndex = 71;
            this.btnDiff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.btnDiff_Click);
            // 
            // btnBest
            // 
            this.btnBest.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBest.ForeColor = System.Drawing.Color.Green;
            this.btnBest.Location = new System.Drawing.Point(650, 35);
            this.btnBest.Name = "btnBest";
            this.btnBest.Size = new System.Drawing.Size(58, 26);
            this.btnBest.TabIndex = 70;
            this.btnBest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBest.UseVisualStyleBackColor = true;
            this.btnBest.Click += new System.EventHandler(this.btnBest_Click);
            // 
            // btnExcess
            // 
            this.btnExcess.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcess.ForeColor = System.Drawing.Color.Red;
            this.btnExcess.Location = new System.Drawing.Point(572, 36);
            this.btnExcess.Name = "btnExcess";
            this.btnExcess.Size = new System.Drawing.Size(58, 26);
            this.btnExcess.TabIndex = 69;
            this.btnExcess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcess.UseVisualStyleBackColor = true;
            this.btnExcess.Click += new System.EventHandler(this.btnExcess_Click);
            // 
            // btnShort
            // 
            this.btnShort.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShort.ForeColor = System.Drawing.Color.Maroon;
            this.btnShort.Location = new System.Drawing.Point(503, 37);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(58, 26);
            this.btnShort.TabIndex = 68;
            this.btnShort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btn_perfect
            // 
            this.btn_perfect.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perfect.ForeColor = System.Drawing.Color.Green;
            this.btn_perfect.Location = new System.Drawing.Point(426, 37);
            this.btn_perfect.Name = "btn_perfect";
            this.btn_perfect.Size = new System.Drawing.Size(58, 26);
            this.btn_perfect.TabIndex = 67;
            this.btn_perfect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_perfect.UseVisualStyleBackColor = true;
            this.btn_perfect.Click += new System.EventHandler(this.btn_perfect_Click);
            // 
            // btnXL
            // 
            this.btnXL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXL.BackgroundImage")));
            this.btnXL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXL.Enabled = false;
            this.btnXL.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXL.Location = new System.Drawing.Point(887, 21);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(41, 40);
            this.btnXL.TabIndex = 66;
            this.btnXL.UseVisualStyleBackColor = true;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Enabled = false;
            this.btnSummary.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(281, 12);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(41, 51);
            this.btnSummary.TabIndex = 65;
            this.btnSummary.Text = ">>>";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(729, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "High NPR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(656, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Best";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(567, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Excess %";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(503, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Short %";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(418, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Perfect %";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(353, 39);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(51, 22);
            this.txtTotal.TabIndex = 54;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "NoS";
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.btnReturnReport);
            this.gb_detail.Controls.Add(this.lblResult);
            this.gb_detail.Controls.Add(this.btnReturnPack);
            this.gb_detail.Controls.Add(this.txtRetPacks);
            this.gb_detail.Controls.Add(this.label8);
            this.gb_detail.Controls.Add(this.lblName);
            this.gb_detail.Controls.Add(this.lv_keyInfo);
            this.gb_detail.Controls.Add(this.lv_detail);
            this.gb_detail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_detail.Location = new System.Drawing.Point(0, 73);
            this.gb_detail.Name = "gb_detail";
            this.gb_detail.Size = new System.Drawing.Size(929, 400);
            this.gb_detail.TabIndex = 54;
            this.gb_detail.TabStop = false;
            this.gb_detail.Text = "XXXXXXXXXXXXXX";
            this.gb_detail.Enter += new System.EventHandler(this.gb_detail_Enter);
            // 
            // btnReturnReport
            // 
            this.btnReturnReport.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnReport.ForeColor = System.Drawing.Color.Green;
            this.btnReturnReport.Location = new System.Drawing.Point(8, 371);
            this.btnReturnReport.Name = "btnReturnReport";
            this.btnReturnReport.Size = new System.Drawing.Size(121, 26);
            this.btnReturnReport.TabIndex = 72;
            this.btnReturnReport.Text = "Return Report";
            this.btnReturnReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturnReport.UseVisualStyleBackColor = true;
            this.btnReturnReport.Click += new System.EventHandler(this.btnReturnReport_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Crimson;
            this.lblResult.Location = new System.Drawing.Point(574, 371);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 17);
            this.lblResult.TabIndex = 71;
            this.lblResult.Text = "Result";
            // 
            // btnReturnPack
            // 
            this.btnReturnPack.Enabled = false;
            this.btnReturnPack.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnPack.ForeColor = System.Drawing.Color.Green;
            this.btnReturnPack.Location = new System.Drawing.Point(386, 369);
            this.btnReturnPack.Name = "btnReturnPack";
            this.btnReturnPack.Size = new System.Drawing.Size(180, 26);
            this.btnReturnPack.TabIndex = 70;
            this.btnReturnPack.Text = "Submit Return Packs";
            this.btnReturnPack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturnPack.UseVisualStyleBackColor = true;
            this.btnReturnPack.Click += new System.EventHandler(this.btnReturnPack_Click);
            // 
            // txtRetPacks
            // 
            this.txtRetPacks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRetPacks.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetPacks.Location = new System.Drawing.Point(279, 373);
            this.txtRetPacks.Name = "txtRetPacks";
            this.txtRetPacks.ReadOnly = true;
            this.txtRetPacks.Size = new System.Drawing.Size(51, 22);
            this.txtRetPacks.TabIndex = 69;
            this.txtRetPacks.Text = "0";
            this.txtRetPacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetPacks.Enter += new System.EventHandler(this.txtRetPacks_Enter);
            this.txtRetPacks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRetPacks_KeyDown);
            this.txtRetPacks.Leave += new System.EventHandler(this.txtRetPacks_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Return Packs ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 240);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 20);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "XXXXXXXXXXXXXXXXXXXX";
            // 
            // lv_keyInfo
            // 
            this.lv_keyInfo.BackColor = System.Drawing.Color.White;
            this.lv_keyInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.masterkey,
            this.Pack,
            this.PackQty,
            this.Batch_No,
            this.expdt,
            this.MRP,
            this.Trade,
            this.Dis,
            this.PurchQty,
            this.ITFREE,
            this.taxRate,
            this.Mnpr,
            this.V_name});
            this.lv_keyInfo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_keyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lv_keyInfo.FullRowSelect = true;
            this.lv_keyInfo.GridLines = true;
            this.lv_keyInfo.Location = new System.Drawing.Point(9, 262);
            this.lv_keyInfo.Name = "lv_keyInfo";
            this.lv_keyInfo.Size = new System.Drawing.Size(914, 89);
            this.lv_keyInfo.TabIndex = 5;
            this.lv_keyInfo.UseCompatibleStateImageBehavior = false;
            this.lv_keyInfo.View = System.Windows.Forms.View.Details;
            this.lv_keyInfo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_keyInfo_ItemSelectionChanged);
            this.lv_keyInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_keyInfo_KeyUp);
            // 
            // masterkey
            // 
            this.masterkey.Text = "Master Key Id";
            this.masterkey.Width = 0;
            // 
            // Pack
            // 
            this.Pack.Text = "Pack";
            // 
            // PackQty
            // 
            this.PackQty.Text = "P.Qty";
            this.PackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PackQty.Width = 40;
            // 
            // Batch_No
            // 
            this.Batch_No.Text = "Batch No";
            this.Batch_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expdt
            // 
            this.expdt.Text = "Ex.Dt";
            this.expdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expdt.Width = 40;
            // 
            // MRP
            // 
            this.MRP.Text = "MRP";
            this.MRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Trade
            // 
            this.Trade.Text = "Trade";
            this.Trade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Dis
            // 
            this.Dis.Text = "DIS%";
            this.Dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Dis.Width = 40;
            // 
            // PurchQty
            // 
            this.PurchQty.Text = "QTY[P]";
            this.PurchQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PurchQty.Width = 50;
            // 
            // ITFREE
            // 
            this.ITFREE.Text = "FREE";
            this.ITFREE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ITFREE.Width = 40;
            // 
            // taxRate
            // 
            this.taxRate.Text = "Tax %";
            this.taxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.taxRate.Width = 45;
            // 
            // Mnpr
            // 
            this.Mnpr.Text = "NPR";
            this.Mnpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // V_name
            // 
            this.V_name.Text = "Vendor Name";
            this.V_name.Width = 200;
            // 
            // lv_detail
            // 
            this.lv_detail.BackColor = System.Drawing.Color.White;
            this.lv_detail.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lv_detail.FullRowSelect = true;
            this.lv_detail.GridLines = true;
            this.lv_detail.Location = new System.Drawing.Point(7, 22);
            this.lv_detail.Name = "lv_detail";
            this.lv_detail.Size = new System.Drawing.Size(914, 211);
            this.lv_detail.TabIndex = 4;
            this.lv_detail.UseCompatibleStateImageBehavior = false;
            this.lv_detail.View = System.Windows.Forms.View.Details;
            this.lv_detail.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_detail_ItemSelectionChanged);
            this.lv_detail.SelectedIndexChanged += new System.EventHandler(this.lv_detail_SelectedIndexChanged);
            this.lv_detail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_detail_KeyUp);
            // 
            // gbRetReport
            // 
            this.gbRetReport.Controls.Add(this.lv_RetReport);
            this.gbRetReport.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRetReport.Location = new System.Drawing.Point(5, 427);
            this.gbRetReport.Name = "gbRetReport";
            this.gbRetReport.Size = new System.Drawing.Size(918, 14);
            this.gbRetReport.TabIndex = 55;
            this.gbRetReport.TabStop = false;
            this.gbRetReport.Text = "Return Report Status";
            this.gbRetReport.Visible = false;
            // 
            // lv_RetReport
            // 
            this.lv_RetReport.BackColor = System.Drawing.Color.White;
            this.lv_RetReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r_master_key,
            this.rItem_Name,
            this.rPackType,
            this.rPackQty,
            this.rMRP,
            this.rBatchNo,
            this.rExp,
            this.rNPR,
            this.rRetQty,
            this.origin});
            this.lv_RetReport.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_RetReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lv_RetReport.FullRowSelect = true;
            this.lv_RetReport.GridLines = true;
            this.lv_RetReport.Location = new System.Drawing.Point(9, 22);
            this.lv_RetReport.Name = "lv_RetReport";
            this.lv_RetReport.Size = new System.Drawing.Size(914, 499);
            this.lv_RetReport.TabIndex = 6;
            this.lv_RetReport.UseCompatibleStateImageBehavior = false;
            this.lv_RetReport.View = System.Windows.Forms.View.Details;
            // 
            // r_master_key
            // 
            this.r_master_key.Text = "Master Key Id";
            this.r_master_key.Width = 0;
            // 
            // rItem_Name
            // 
            this.rItem_Name.Text = "Item Name";
            this.rItem_Name.Width = 250;
            // 
            // rPackType
            // 
            this.rPackType.Text = "P.Type";
            // 
            // rPackQty
            // 
            this.rPackQty.Text = "P.Qty";
            this.rPackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rMRP
            // 
            this.rMRP.Text = "MRP";
            // 
            // rBatchNo
            // 
            this.rBatchNo.Text = "Batch No";
            this.rBatchNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rExp
            // 
            this.rExp.Text = "EX.DT";
            this.rExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rNPR
            // 
            this.rNPR.Text = "NPR";
            this.rNPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rRetQty
            // 
            this.rRetQty.Text = "Ret.Qty";
            this.rRetQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // origin
            // 
            this.origin.Text = "Origin";
            this.origin.Width = 85;
            // 
            // ucPurchaseOrder_Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbRetReport);
            this.Controls.Add(this.gb_detail);
            this.Controls.Add(this.gb_info);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucPurchaseOrder_Analysis";
            this.Size = new System.Drawing.Size(961, 523);
            this.Load += new System.EventHandler(this.ucPurchaseOrder_Analysis_Load);
            this.gb_info.ResumeLayout(false);
            this.gb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.gb_detail.ResumeLayout(false);
            this.gb_detail.PerformLayout();
            this.gbRetReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrer_Nos;
        private System.Windows.Forms.GroupBox gb_info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.GroupBox gb_detail;
        private System.Windows.Forms.Button btnXL;
        private System.Windows.Forms.ListView lv_detail;
        private System.Windows.Forms.Button btn_perfect;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnBest;
        private System.Windows.Forms.Button btnExcess;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView lv_keyInfo;
        private System.Windows.Forms.ColumnHeader masterkey;
        private System.Windows.Forms.ColumnHeader Pack;
        private System.Windows.Forms.ColumnHeader PackQty;
        private System.Windows.Forms.ColumnHeader Batch_No;
        private System.Windows.Forms.ColumnHeader expdt;
        private System.Windows.Forms.ColumnHeader MRP;
        private System.Windows.Forms.ColumnHeader Trade;
        private System.Windows.Forms.ColumnHeader Dis;
        private System.Windows.Forms.ColumnHeader PurchQty;
        private System.Windows.Forms.ColumnHeader ITFREE;
        private System.Windows.Forms.ColumnHeader Mnpr;
        private System.Windows.Forms.ColumnHeader V_name;
        private System.Windows.Forms.ColumnHeader taxRate;
        private System.Windows.Forms.Button btnReturnPack;
        private System.Windows.Forms.TextBox txtRetPacks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReturnReport;
        private System.Windows.Forms.GroupBox gbRetReport;
        private System.Windows.Forms.ListView lv_RetReport;
        private System.Windows.Forms.ColumnHeader r_master_key;
        private System.Windows.Forms.ColumnHeader rItem_Name;
        private System.Windows.Forms.ColumnHeader rPackType;
        private System.Windows.Forms.ColumnHeader rPackQty;
        private System.Windows.Forms.ColumnHeader rMRP;
        private System.Windows.Forms.ColumnHeader rBatchNo;
        private System.Windows.Forms.ColumnHeader rExp;
        private System.Windows.Forms.ColumnHeader rNPR;
        private System.Windows.Forms.ColumnHeader rRetQty;
        private System.Windows.Forms.ColumnHeader origin;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.UI.RadButton btnRefresh;
    }
}
