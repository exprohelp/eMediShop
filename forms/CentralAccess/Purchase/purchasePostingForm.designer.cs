namespace eMediShop
{
    partial class purchasePostingForm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.lblChqDate = new System.Windows.Forms.Label();
            this.dtChqDate = new System.Windows.Forms.DateTimePicker();
            this.lblAc = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbCash_Credit = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPlusMinus = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRoundOff = new System.Windows.Forms.TextBox();
            this.txtAdjusted = new System.Windows.Forms.TextBox();
            this.txtFinalTax = new System.Windows.Forms.TextBox();
            this.txtAccu_Discount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFinal_Total = new System.Windows.Forms.TextBox();
            this.txtFinal_Net = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btn_grAdjustment = new Telerik.WinControls.UI.RadButton();
            this.txtFreeQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKeyNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInvType = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.cmb_Ledger = new Telerik.WinControls.UI.RadDropDownList();
            this.txtRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Complete = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPurchBy = new System.Windows.Forms.ComboBox();
            this.cmbCheckBy = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rgv_TaxInfo = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grAdjustment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Ledger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Complete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChqDate
            // 
            this.lblChqDate.AutoSize = true;
            this.lblChqDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChqDate.ForeColor = System.Drawing.Color.Black;
            this.lblChqDate.Location = new System.Drawing.Point(10, 59);
            this.lblChqDate.Name = "lblChqDate";
            this.lblChqDate.Size = new System.Drawing.Size(86, 20);
            this.lblChqDate.TabIndex = 148;
            this.lblChqDate.Text = "Cheque Date";
            this.lblChqDate.Visible = false;
            // 
            // dtChqDate
            // 
            this.dtChqDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtChqDate.Location = new System.Drawing.Point(101, 58);
            this.dtChqDate.Name = "dtChqDate";
            this.dtChqDate.Size = new System.Drawing.Size(101, 22);
            this.dtChqDate.TabIndex = 147;
            this.dtChqDate.Visible = false;
            // 
            // lblAc
            // 
            this.lblAc.AutoSize = true;
            this.lblAc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAc.ForeColor = System.Drawing.Color.Black;
            this.lblAc.Location = new System.Drawing.Point(211, 31);
            this.lblAc.Name = "lblAc";
            this.lblAc.Size = new System.Drawing.Size(55, 16);
            this.lblAc.TabIndex = 145;
            this.lblAc.Text = "Cr. A/C ";
            this.lblAc.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(671, 144);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 16);
            this.label27.TabIndex = 144;
            this.label27.Text = "+-";
            // 
            // cmbCash_Credit
            // 
            this.cmbCash_Credit.BackColor = System.Drawing.Color.White;
            this.cmbCash_Credit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCash_Credit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCash_Credit.ForeColor = System.Drawing.Color.Blue;
            this.cmbCash_Credit.FormattingEnabled = true;
            this.cmbCash_Credit.Items.AddRange(new object[] {
            "Select",
            "Credit",
            "Cash",
            "Cheque"});
            this.cmbCash_Credit.Location = new System.Drawing.Point(101, 28);
            this.cmbCash_Credit.Name = "cmbCash_Credit";
            this.cmbCash_Credit.Size = new System.Drawing.Size(104, 24);
            this.cmbCash_Credit.TabIndex = 130;
            this.cmbCash_Credit.Tag = "";
            this.cmbCash_Credit.SelectedIndexChanged += new System.EventHandler(this.cmbCash_Credit_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(22, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 16);
            this.label25.TabIndex = 140;
            this.label25.Text = "Pay. Mode";
            // 
            // txtPlusMinus
            // 
            this.txtPlusMinus.BackColor = System.Drawing.Color.White;
            this.txtPlusMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlusMinus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlusMinus.Location = new System.Drawing.Point(696, 135);
            this.txtPlusMinus.MaxLength = 5;
            this.txtPlusMinus.Name = "txtPlusMinus";
            this.txtPlusMinus.Size = new System.Drawing.Size(77, 23);
            this.txtPlusMinus.TabIndex = 143;
            this.txtPlusMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPlusMinus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPlusMinus_KeyUp);
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.Color.Black;
            this.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillAmount.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAmount.ForeColor = System.Drawing.Color.Yellow;
            this.txtBillAmount.Location = new System.Drawing.Point(825, 125);
            this.txtBillAmount.MaxLength = 5;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(131, 33);
            this.txtBillAmount.TabIndex = 142;
            this.txtBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(850, 99);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 22);
            this.label26.TabIndex = 141;
            this.label26.Text = "Payable";
            // 
            // txtRoundOff
            // 
            this.txtRoundOff.BackColor = System.Drawing.Color.White;
            this.txtRoundOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoundOff.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundOff.Location = new System.Drawing.Point(641, 42);
            this.txtRoundOff.MaxLength = 5;
            this.txtRoundOff.Name = "txtRoundOff";
            this.txtRoundOff.ReadOnly = true;
            this.txtRoundOff.Size = new System.Drawing.Size(71, 23);
            this.txtRoundOff.TabIndex = 138;
            this.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAdjusted
            // 
            this.txtAdjusted.BackColor = System.Drawing.Color.White;
            this.txtAdjusted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdjusted.Enabled = false;
            this.txtAdjusted.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjusted.Location = new System.Drawing.Point(696, 109);
            this.txtAdjusted.MaxLength = 5;
            this.txtAdjusted.Name = "txtAdjusted";
            this.txtAdjusted.Size = new System.Drawing.Size(77, 23);
            this.txtAdjusted.TabIndex = 139;
            this.txtAdjusted.Text = "0.00";
            this.txtAdjusted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdjusted.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAdjusted_KeyUp);
            this.txtAdjusted.Leave += new System.EventHandler(this.txtAdjusted_Leave);
            // 
            // txtFinalTax
            // 
            this.txtFinalTax.BackColor = System.Drawing.Color.White;
            this.txtFinalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalTax.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalTax.Location = new System.Drawing.Point(558, 42);
            this.txtFinalTax.MaxLength = 5;
            this.txtFinalTax.Name = "txtFinalTax";
            this.txtFinalTax.ReadOnly = true;
            this.txtFinalTax.Size = new System.Drawing.Size(77, 23);
            this.txtFinalTax.TabIndex = 136;
            this.txtFinalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAccu_Discount
            // 
            this.txtAccu_Discount.BackColor = System.Drawing.Color.White;
            this.txtAccu_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccu_Discount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccu_Discount.Location = new System.Drawing.Point(475, 42);
            this.txtAccu_Discount.MaxLength = 5;
            this.txtAccu_Discount.Name = "txtAccu_Discount";
            this.txtAccu_Discount.ReadOnly = true;
            this.txtAccu_Discount.Size = new System.Drawing.Size(77, 23);
            this.txtAccu_Discount.TabIndex = 137;
            this.txtAccu_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(640, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 16);
            this.label21.TabIndex = 135;
            this.label21.Text = "GR.Adj";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(665, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 16);
            this.label22.TabIndex = 134;
            this.label22.Text = "Round";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(490, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 133;
            this.label18.Text = "Discount";
            // 
            // txtFinal_Total
            // 
            this.txtFinal_Total.BackColor = System.Drawing.Color.White;
            this.txtFinal_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinal_Total.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal_Total.Location = new System.Drawing.Point(392, 42);
            this.txtFinal_Total.MaxLength = 5;
            this.txtFinal_Total.Name = "txtFinal_Total";
            this.txtFinal_Total.ReadOnly = true;
            this.txtFinal_Total.Size = new System.Drawing.Size(77, 23);
            this.txtFinal_Total.TabIndex = 128;
            this.txtFinal_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFinal_Net
            // 
            this.txtFinal_Net.BackColor = System.Drawing.Color.White;
            this.txtFinal_Net.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinal_Net.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal_Net.Location = new System.Drawing.Point(720, 42);
            this.txtFinal_Net.MaxLength = 5;
            this.txtFinal_Net.Name = "txtFinal_Net";
            this.txtFinal_Net.ReadOnly = true;
            this.txtFinal_Net.Size = new System.Drawing.Size(71, 23);
            this.txtFinal_Net.TabIndex = 129;
            this.txtFinal_Net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(604, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 16);
            this.label19.TabIndex = 131;
            this.label19.Text = "Tax";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(733, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 132;
            this.label20.Text = "Net Amt";
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayment.ForeColor = System.Drawing.Color.Black;
            this.lblpayment.Location = new System.Drawing.Point(405, 23);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(64, 16);
            this.lblpayment.TabIndex = 127;
            this.lblpayment.Text = "Bill Total";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rgv_TaxInfo);
            this.radGroupBox1.Controls.Add(this.btn_grAdjustment);
            this.radGroupBox1.Controls.Add(this.txtFreeQty);
            this.radGroupBox1.Controls.Add(this.label12);
            this.radGroupBox1.Controls.Add(this.txtKeyNo);
            this.radGroupBox1.Controls.Add(this.label9);
            this.radGroupBox1.Controls.Add(this.txtItemNo);
            this.radGroupBox1.Controls.Add(this.label8);
            this.radGroupBox1.Controls.Add(this.lblInvType);
            this.radGroupBox1.Controls.Add(this.txtInvNo);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.txtInvDate);
            this.radGroupBox1.Controls.Add(this.txtFinal_Total);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.lblpayment);
            this.radGroupBox1.Controls.Add(this.label20);
            this.radGroupBox1.Controls.Add(this.label19);
            this.radGroupBox1.Controls.Add(this.txtFinal_Net);
            this.radGroupBox1.Controls.Add(this.label27);
            this.radGroupBox1.Controls.Add(this.label18);
            this.radGroupBox1.Controls.Add(this.txtPlusMinus);
            this.radGroupBox1.Controls.Add(this.label22);
            this.radGroupBox1.Controls.Add(this.txtAccu_Discount);
            this.radGroupBox1.Controls.Add(this.txtFinalTax);
            this.radGroupBox1.Controls.Add(this.txtAdjusted);
            this.radGroupBox1.Controls.Add(this.txtBillAmount);
            this.radGroupBox1.Controls.Add(this.label21);
            this.radGroupBox1.Controls.Add(this.txtRoundOff);
            this.radGroupBox1.Controls.Add(this.label26);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "Bill Information";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 7);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(965, 216);
            this.radGroupBox1.TabIndex = 149;
            this.radGroupBox1.Text = "Bill Information";
            // 
            // btn_grAdjustment
            // 
            this.btn_grAdjustment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grAdjustment.Location = new System.Drawing.Point(643, 99);
            this.btn_grAdjustment.Name = "btn_grAdjustment";
            this.btn_grAdjustment.Size = new System.Drawing.Size(130, 35);
            this.btn_grAdjustment.TabIndex = 174;
            this.btn_grAdjustment.Text = "GR Adjustment";
            this.btn_grAdjustment.Click += new System.EventHandler(this.btn_grAdjustment_Click);
            // 
            // txtFreeQty
            // 
            this.txtFreeQty.BackColor = System.Drawing.Color.White;
            this.txtFreeQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreeQty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreeQty.ForeColor = System.Drawing.Color.Red;
            this.txtFreeQty.Location = new System.Drawing.Point(329, 42);
            this.txtFreeQty.MaxLength = 5;
            this.txtFreeQty.Name = "txtFreeQty";
            this.txtFreeQty.ReadOnly = true;
            this.txtFreeQty.Size = new System.Drawing.Size(60, 23);
            this.txtFreeQty.TabIndex = 173;
            this.txtFreeQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(329, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 172;
            this.label12.Text = "Free Qty";
            // 
            // txtKeyNo
            // 
            this.txtKeyNo.BackColor = System.Drawing.Color.White;
            this.txtKeyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyNo.Location = new System.Drawing.Point(264, 42);
            this.txtKeyNo.MaxLength = 5;
            this.txtKeyNo.Name = "txtKeyNo";
            this.txtKeyNo.ReadOnly = true;
            this.txtKeyNo.Size = new System.Drawing.Size(60, 23);
            this.txtKeyNo.TabIndex = 161;
            this.txtKeyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(265, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 160;
            this.label9.Text = "Key No.";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BackColor = System.Drawing.Color.White;
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(197, 42);
            this.txtItemNo.MaxLength = 5;
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.ReadOnly = true;
            this.txtItemNo.Size = new System.Drawing.Size(60, 23);
            this.txtItemNo.TabIndex = 158;
            this.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(197, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 157;
            this.label8.Text = "Item No.";
            // 
            // lblInvType
            // 
            this.lblInvType.AutoSize = true;
            this.lblInvType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvType.ForeColor = System.Drawing.Color.Black;
            this.lblInvType.Location = new System.Drawing.Point(797, 44);
            this.lblInvType.Name = "lblInvType";
            this.lblInvType.Size = new System.Drawing.Size(161, 16);
            this.lblInvType.TabIndex = 156;
            this.lblInvType.Text = "Inv. Type :: XXXXXXXXX";
            // 
            // txtInvNo
            // 
            this.txtInvNo.BackColor = System.Drawing.Color.White;
            this.txtInvNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvNo.Location = new System.Drawing.Point(102, 42);
            this.txtInvNo.MaxLength = 5;
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.ReadOnly = true;
            this.txtInvNo.Size = new System.Drawing.Size(88, 23);
            this.txtInvNo.TabIndex = 155;
            this.txtInvNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 154;
            this.label3.Text = "Inv. No";
            // 
            // txtInvDate
            // 
            this.txtInvDate.BackColor = System.Drawing.Color.White;
            this.txtInvDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvDate.Location = new System.Drawing.Point(8, 42);
            this.txtInvDate.MaxLength = 5;
            this.txtInvDate.Name = "txtInvDate";
            this.txtInvDate.ReadOnly = true;
            this.txtInvDate.Size = new System.Drawing.Size(88, 23);
            this.txtInvDate.TabIndex = 153;
            this.txtInvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 152;
            this.label2.Text = "Inv. Date";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.cmb_Ledger);
            this.radGroupBox2.Controls.Add(this.txtRemarks);
            this.radGroupBox2.Controls.Add(this.label1);
            this.radGroupBox2.Controls.Add(this.rb_Complete);
            this.radGroupBox2.Controls.Add(this.label25);
            this.radGroupBox2.Controls.Add(this.cmbCash_Credit);
            this.radGroupBox2.Controls.Add(this.lblChqDate);
            this.radGroupBox2.Controls.Add(this.lblAc);
            this.radGroupBox2.Controls.Add(this.dtChqDate);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox2.HeaderText = "PayemtnSettlement Info";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 347);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(965, 98);
            this.radGroupBox2.TabIndex = 150;
            this.radGroupBox2.Text = "PayemtnSettlement Info";
            // 
            // cmb_Ledger
            // 
            this.cmb_Ledger.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Ledger.Location = new System.Drawing.Point(281, 28);
            this.cmb_Ledger.Name = "cmb_Ledger";
            this.cmb_Ledger.Size = new System.Drawing.Size(455, 23);
            this.cmb_Ledger.TabIndex = 153;
            this.cmb_Ledger.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmb_Ledger_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = false;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(281, 51);
            this.txtRemarks.MaxLength = 100;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(455, 42);
            this.txtRemarks.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(211, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 151;
            this.label1.Text = "Remarks";
            // 
            // rb_Complete
            // 
            this.rb_Complete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Complete.Location = new System.Drawing.Point(863, 22);
            this.rb_Complete.Name = "rb_Complete";
            this.rb_Complete.Size = new System.Drawing.Size(95, 71);
            this.rb_Complete.TabIndex = 149;
            this.rb_Complete.Text = "Complete";
            this.rb_Complete.Click += new System.EventHandler(this.rb_Complete_Click);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.label13);
            this.radGroupBox3.Controls.Add(this.cmbPurchBy);
            this.radGroupBox3.Controls.Add(this.cmbCheckBy);
            this.radGroupBox3.Controls.Add(this.label14);
            this.radGroupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox3.HeaderText = "Process Information";
            this.radGroupBox3.Location = new System.Drawing.Point(13, 255);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(964, 86);
            this.radGroupBox3.TabIndex = 152;
            this.radGroupBox3.Text = "Process Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(626, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 46;
            this.label13.Text = "Checked By";
            // 
            // cmbPurchBy
            // 
            this.cmbPurchBy.BackColor = System.Drawing.Color.White;
            this.cmbPurchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchBy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPurchBy.ForeColor = System.Drawing.Color.Blue;
            this.cmbPurchBy.FormattingEnabled = true;
            this.cmbPurchBy.Location = new System.Drawing.Point(13, 47);
            this.cmbPurchBy.Name = "cmbPurchBy";
            this.cmbPurchBy.Size = new System.Drawing.Size(323, 24);
            this.cmbPurchBy.TabIndex = 45;
            this.cmbPurchBy.Tag = "";
            // 
            // cmbCheckBy
            // 
            this.cmbCheckBy.BackColor = System.Drawing.Color.White;
            this.cmbCheckBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckBy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCheckBy.ForeColor = System.Drawing.Color.Blue;
            this.cmbCheckBy.FormattingEnabled = true;
            this.cmbCheckBy.Location = new System.Drawing.Point(630, 47);
            this.cmbCheckBy.Name = "cmbCheckBy";
            this.cmbCheckBy.Size = new System.Drawing.Size(323, 24);
            this.cmbCheckBy.TabIndex = 43;
            this.cmbCheckBy.Tag = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Purchase By";
            // 
            // rgv_TaxInfo
            // 
            this.rgv_TaxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_TaxInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_TaxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_TaxInfo.ForeColor = System.Drawing.Color.Black;
            this.rgv_TaxInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_TaxInfo.Location = new System.Drawing.Point(8, 70);
            // 
            // 
            // 
            this.rgv_TaxInfo.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "tax_rate";
            gridViewTextBoxColumn1.HeaderText = "Tax Rate";
            gridViewTextBoxColumn1.Name = "tax_rate";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "taxableValue";
            gridViewDecimalColumn1.FormatString = "{0:N2}";
            gridViewDecimalColumn1.HeaderText = "Taxable Value";
            gridViewDecimalColumn1.Name = "taxableValue";
            gridViewDecimalColumn1.Width = 98;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "taxValue";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Tax Value";
            gridViewDecimalColumn2.Name = "taxValue";
            gridViewDecimalColumn2.Width = 75;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "igst";
            gridViewDecimalColumn3.FormatString = "{0:N2}";
            gridViewDecimalColumn3.HeaderText = "IGST";
            gridViewDecimalColumn3.Name = "igst";
            gridViewDecimalColumn3.Width = 69;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "CGST";
            gridViewDecimalColumn4.FormatString = "{0:N2}";
            gridViewDecimalColumn4.HeaderText = "CGST";
            gridViewDecimalColumn4.Name = "CGST";
            gridViewDecimalColumn4.Width = 63;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "SGST";
            gridViewDecimalColumn5.FormatString = "{0:N2}";
            gridViewDecimalColumn5.HeaderText = "SGST";
            gridViewDecimalColumn5.Name = "SGST";
            gridViewDecimalColumn5.Width = 71;
            this.rgv_TaxInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5});
            this.rgv_TaxInfo.MasterTemplate.EnableGrouping = false;
            sortDescriptor1.PropertyName = "tax_rate";
            this.rgv_TaxInfo.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.rgv_TaxInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_TaxInfo.Name = "rgv_TaxInfo";
            this.rgv_TaxInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.rgv_TaxInfo.ReadOnly = true;
            this.rgv_TaxInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_TaxInfo.Size = new System.Drawing.Size(444, 141);
            this.rgv_TaxInfo.TabIndex = 175;
            this.rgv_TaxInfo.Text = "radGridView1";
            this.rgv_TaxInfo.ThemeName = "Office2010Blue";
            // 
            // purchasePostingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 454);
            this.ControlBox = false;
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "purchasePostingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Posting Id No. XXXXXXXXXXXX/XX-XX";
            this.ThemeName = "ControlDefault";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.purchasePostingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.purchasePostingForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_grAdjustment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Ledger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Complete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblChqDate;
        private System.Windows.Forms.DateTimePicker dtChqDate;
        internal System.Windows.Forms.Label lblAc;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.ComboBox cmbCash_Credit;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.TextBox txtPlusMinus;
        internal System.Windows.Forms.TextBox txtBillAmount;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.TextBox txtRoundOff;
        internal System.Windows.Forms.TextBox txtAdjusted;
        internal System.Windows.Forms.TextBox txtFinalTax;
        internal System.Windows.Forms.TextBox txtAccu_Discount;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtFinal_Total;
        internal System.Windows.Forms.TextBox txtFinal_Net;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label lblpayment;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private ucUploadScanedDoc ucUploadScanedDoc1;
        private Telerik.WinControls.UI.RadButton rb_Complete;
        private Telerik.WinControls.UI.RadTextBox txtRemarks;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtInvDate;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtInvNo;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblInvType;
        internal System.Windows.Forms.TextBox txtKeyNo;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtItemNo;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtFreeQty;
        internal System.Windows.Forms.Label label12;
        private Telerik.WinControls.UI.RadDropDownList cmb_Ledger;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.ComboBox cmbPurchBy;
        internal System.Windows.Forms.ComboBox cmbCheckBy;
        private System.Windows.Forms.Label label14;
        private Telerik.WinControls.UI.RadButton btn_grAdjustment;
        private Telerik.WinControls.UI.RadGridView rgv_TaxInfo;
    }
}
