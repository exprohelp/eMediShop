namespace eMediShop
{
    partial class BillPostingPopup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOhCharges = new System.Windows.Forms.TextBox();
            this.rc_tcs = new Telerik.WinControls.UI.RadCheckBox();
            this.txttcsAmt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblInvType = new System.Windows.Forms.Label();
            this.rgv_TaxInfo = new Telerik.WinControls.UI.RadGridView();
            this.txtFreeQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKeyNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtPlusMinus = new System.Windows.Forms.TextBox();
            this.txtFinal_Total = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtFinal_Net = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAdjusted = new System.Windows.Forms.TextBox();
            this.txtRoundOff = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtFinalTax = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAccu_Discount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtChqDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPurchBy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCheckBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCash_Credit = new System.Windows.Forms.ComboBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rc_tcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo.MasterTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtOhCharges);
            this.panel1.Controls.Add(this.rc_tcs);
            this.panel1.Controls.Add(this.txttcsAmt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblInvType);
            this.panel1.Controls.Add(this.rgv_TaxInfo);
            this.panel1.Controls.Add(this.txtFreeQty);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtKeyNo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtItemNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.txtPlusMinus);
            this.panel1.Controls.Add(this.txtFinal_Total);
            this.panel1.Controls.Add(this.txtBillAmount);
            this.panel1.Controls.Add(this.txtFinal_Net);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtAdjusted);
            this.panel1.Controls.Add(this.txtRoundOff);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtFinalTax);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtAccu_Discount);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 382);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 188;
            this.label11.Text = "Overhead Charges";
            // 
            // txtOhCharges
            // 
            this.txtOhCharges.BackColor = System.Drawing.Color.White;
            this.txtOhCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOhCharges.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOhCharges.Location = new System.Drawing.Point(166, 95);
            this.txtOhCharges.MaxLength = 5;
            this.txtOhCharges.Name = "txtOhCharges";
            this.txtOhCharges.Size = new System.Drawing.Size(106, 23);
            this.txtOhCharges.TabIndex = 187;
            this.txtOhCharges.Text = "0";
            this.txtOhCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOhCharges.Leave += new System.EventHandler(this.txtOhCharges_Leave);
            // 
            // rc_tcs
            // 
            this.rc_tcs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rc_tcs.Location = new System.Drawing.Point(10, 7);
            this.rc_tcs.Name = "rc_tcs";
            this.rc_tcs.Size = new System.Drawing.Size(229, 25);
            this.rc_tcs.TabIndex = 186;
            this.rc_tcs.Text = "Tax Collected at Source(TCS)";
            this.rc_tcs.Visible = false;
            this.rc_tcs.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rc_tcs_ToggleStateChanged);
            // 
            // txttcsAmt
            // 
            this.txttcsAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txttcsAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttcsAmt.Enabled = false;
            this.txttcsAmt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttcsAmt.Location = new System.Drawing.Point(102, 96);
            this.txttcsAmt.MaxLength = 5;
            this.txttcsAmt.Name = "txttcsAmt";
            this.txttcsAmt.ReadOnly = true;
            this.txttcsAmt.Size = new System.Drawing.Size(56, 21);
            this.txttcsAmt.TabIndex = 185;
            this.txttcsAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(99, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 184;
            this.label10.Text = "TCS AMT :";
            // 
            // lblInvType
            // 
            this.lblInvType.AutoSize = true;
            this.lblInvType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvType.ForeColor = System.Drawing.Color.Black;
            this.lblInvType.Location = new System.Drawing.Point(212, 197);
            this.lblInvType.Name = "lblInvType";
            this.lblInvType.Size = new System.Drawing.Size(161, 16);
            this.lblInvType.TabIndex = 183;
            this.lblInvType.Text = "Inv. Type :: XXXXXXXXX";
            // 
            // rgv_TaxInfo
            // 
            this.rgv_TaxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.rgv_TaxInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_TaxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_TaxInfo.ForeColor = System.Drawing.Color.Black;
            this.rgv_TaxInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_TaxInfo.Location = new System.Drawing.Point(11, 226);
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
            this.rgv_TaxInfo.TabIndex = 182;
            this.rgv_TaxInfo.Text = "radGridView1";
            this.rgv_TaxInfo.ThemeName = "Office2010Blue";
            // 
            // txtFreeQty
            // 
            this.txtFreeQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFreeQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreeQty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreeQty.ForeColor = System.Drawing.Color.Red;
            this.txtFreeQty.Location = new System.Drawing.Point(143, 195);
            this.txtFreeQty.MaxLength = 5;
            this.txtFreeQty.Name = "txtFreeQty";
            this.txtFreeQty.ReadOnly = true;
            this.txtFreeQty.Size = new System.Drawing.Size(60, 23);
            this.txtFreeQty.TabIndex = 181;
            this.txtFreeQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(142, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 180;
            this.label12.Text = "Free Qty";
            // 
            // txtKeyNo
            // 
            this.txtKeyNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKeyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyNo.Location = new System.Drawing.Point(78, 195);
            this.txtKeyNo.MaxLength = 5;
            this.txtKeyNo.Name = "txtKeyNo";
            this.txtKeyNo.ReadOnly = true;
            this.txtKeyNo.Size = new System.Drawing.Size(60, 23);
            this.txtKeyNo.TabIndex = 179;
            this.txtKeyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(78, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 178;
            this.label9.Text = "Key No.";
            // 
            // txtItemNo
            // 
            this.txtItemNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(11, 195);
            this.txtItemNo.MaxLength = 5;
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.ReadOnly = true;
            this.txtItemNo.Size = new System.Drawing.Size(60, 23);
            this.txtItemNo.TabIndex = 177;
            this.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 176;
            this.label2.Text = "Item No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(260, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "DISCOUNT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(416, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 15);
            this.label27.TabIndex = 36;
            this.label27.Text = "PLUS(+)/MINUS(-)";
            // 
            // txtPlusMinus
            // 
            this.txtPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPlusMinus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlusMinus.Enabled = false;
            this.txtPlusMinus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlusMinus.Location = new System.Drawing.Point(419, 50);
            this.txtPlusMinus.MaxLength = 5;
            this.txtPlusMinus.Name = "txtPlusMinus";
            this.txtPlusMinus.Size = new System.Drawing.Size(65, 21);
            this.txtPlusMinus.TabIndex = 35;
            this.txtPlusMinus.Text = "0";
            this.txtPlusMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFinal_Total
            // 
            this.txtFinal_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFinal_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinal_Total.Enabled = false;
            this.txtFinal_Total.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal_Total.Location = new System.Drawing.Point(13, 51);
            this.txtFinal_Total.MaxLength = 5;
            this.txtFinal_Total.Name = "txtFinal_Total";
            this.txtFinal_Total.ReadOnly = true;
            this.txtFinal_Total.Size = new System.Drawing.Size(79, 21);
            this.txtFinal_Total.TabIndex = 1;
            this.txtFinal_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.Color.Black;
            this.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAmount.ForeColor = System.Drawing.Color.White;
            this.txtBillAmount.Location = new System.Drawing.Point(263, 134);
            this.txtBillAmount.MaxLength = 5;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(221, 33);
            this.txtBillAmount.TabIndex = 31;
            this.txtBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFinal_Net
            // 
            this.txtFinal_Net.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFinal_Net.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinal_Net.Enabled = false;
            this.txtFinal_Net.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal_Net.Location = new System.Drawing.Point(102, 51);
            this.txtFinal_Net.MaxLength = 5;
            this.txtFinal_Net.Name = "txtFinal_Net";
            this.txtFinal_Net.ReadOnly = true;
            this.txtFinal_Net.Size = new System.Drawing.Size(76, 21);
            this.txtFinal_Net.TabIndex = 2;
            this.txtFinal_Net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(165, 142);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 19);
            this.label26.TabIndex = 30;
            this.label26.Text = "BILL AMT :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(99, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 7;
            this.label20.Text = "NET AMT :";
            // 
            // txtAdjusted
            // 
            this.txtAdjusted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdjusted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdjusted.Enabled = false;
            this.txtAdjusted.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjusted.Location = new System.Drawing.Point(186, 52);
            this.txtAdjusted.MaxLength = 5;
            this.txtAdjusted.Name = "txtAdjusted";
            this.txtAdjusted.Size = new System.Drawing.Size(65, 21);
            this.txtAdjusted.TabIndex = 28;
            this.txtAdjusted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRoundOff
            // 
            this.txtRoundOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRoundOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoundOff.Enabled = false;
            this.txtRoundOff.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundOff.Location = new System.Drawing.Point(339, 50);
            this.txtRoundOff.MaxLength = 5;
            this.txtRoundOff.Name = "txtRoundOff";
            this.txtRoundOff.ReadOnly = true;
            this.txtRoundOff.Size = new System.Drawing.Size(63, 21);
            this.txtRoundOff.TabIndex = 27;
            this.txtRoundOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(184, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "ADJ AMT :";
            // 
            // txtFinalTax
            // 
            this.txtFinalTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFinalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalTax.Enabled = false;
            this.txtFinalTax.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalTax.Location = new System.Drawing.Point(11, 96);
            this.txtFinalTax.MaxLength = 5;
            this.txtFinalTax.Name = "txtFinalTax";
            this.txtFinalTax.ReadOnly = true;
            this.txtFinalTax.Size = new System.Drawing.Size(69, 21);
            this.txtFinalTax.TabIndex = 25;
            this.txtFinalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(10, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 15);
            this.label19.TabIndex = 5;
            this.label19.Text = "TAX AMT :";
            // 
            // txtAccu_Discount
            // 
            this.txtAccu_Discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAccu_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccu_Discount.Enabled = false;
            this.txtAccu_Discount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccu_Discount.Location = new System.Drawing.Point(263, 51);
            this.txtAccu_Discount.MaxLength = 5;
            this.txtAccu_Discount.Name = "txtAccu_Discount";
            this.txtAccu_Discount.ReadOnly = true;
            this.txtAccu_Discount.Size = new System.Drawing.Size(66, 21);
            this.txtAccu_Discount.TabIndex = 26;
            this.txtAccu_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(49, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 16);
            this.label18.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(337, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 15);
            this.label22.TabIndex = 23;
            this.label22.Text = "ROUND OFF";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(61, 17);
            this.lblHeader.TabIndex = 38;
            this.lblHeader.Text = "Post To:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtChqDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnComplete);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbPurchBy);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbCheckBy);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbCash_Credit);
            this.panel2.Controls.Add(this.txtNarration);
            this.panel2.Location = new System.Drawing.Point(521, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 382);
            this.panel2.TabIndex = 1;
            // 
            // dtChqDate
            // 
            this.dtChqDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtChqDate.Enabled = false;
            this.dtChqDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtChqDate.Location = new System.Drawing.Point(187, 106);
            this.dtChqDate.Name = "dtChqDate";
            this.dtChqDate.Size = new System.Drawing.Size(94, 23);
            this.dtChqDate.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cheque  Date :";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Gray;
            this.btnComplete.Enabled = false;
            this.btnComplete.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(353, 259);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(86, 111);
            this.btnComplete.TabIndex = 44;
            this.btnComplete.Text = "POST THIS BILL";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(8, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "NARRATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "PAYMENT BY";
            // 
            // cmbPurchBy
            // 
            this.cmbPurchBy.BackColor = System.Drawing.Color.White;
            this.cmbPurchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchBy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPurchBy.ForeColor = System.Drawing.Color.Blue;
            this.cmbPurchBy.FormattingEnabled = true;
            this.cmbPurchBy.Location = new System.Drawing.Point(89, 11);
            this.cmbPurchBy.Name = "cmbPurchBy";
            this.cmbPurchBy.Size = new System.Drawing.Size(323, 24);
            this.cmbPurchBy.TabIndex = 41;
            this.cmbPurchBy.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "CHECKED BY";
            // 
            // cmbCheckBy
            // 
            this.cmbCheckBy.BackColor = System.Drawing.Color.White;
            this.cmbCheckBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckBy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCheckBy.ForeColor = System.Drawing.Color.Blue;
            this.cmbCheckBy.FormattingEnabled = true;
            this.cmbCheckBy.Location = new System.Drawing.Point(89, 47);
            this.cmbCheckBy.Name = "cmbCheckBy";
            this.cmbCheckBy.Size = new System.Drawing.Size(323, 24);
            this.cmbCheckBy.TabIndex = 39;
            this.cmbCheckBy.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "PURCHASE BY";
            // 
            // cmbCash_Credit
            // 
            this.cmbCash_Credit.BackColor = System.Drawing.Color.White;
            this.cmbCash_Credit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCash_Credit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCash_Credit.ForeColor = System.Drawing.Color.Blue;
            this.cmbCash_Credit.FormattingEnabled = true;
            this.cmbCash_Credit.Location = new System.Drawing.Point(89, 82);
            this.cmbCash_Credit.Name = "cmbCash_Credit";
            this.cmbCash_Credit.Size = new System.Drawing.Size(323, 24);
            this.cmbCash_Credit.TabIndex = 4;
            this.cmbCash_Credit.Tag = "";
            this.cmbCash_Credit.SelectedIndexChanged += new System.EventHandler(this.cmbCash_Credit_SelectedIndexChanged);
            // 
            // txtNarration
            // 
            this.txtNarration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNarration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNarration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarration.Location = new System.Drawing.Point(89, 143);
            this.txtNarration.MaxLength = 50;
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(323, 43);
            this.txtNarration.TabIndex = 37;
            this.txtNarration.Text = "N/A";
            // 
            // BillPostingPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillPostingPopup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BillPostingPopup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rc_tcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_TaxInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox txtNarration;
        internal System.Windows.Forms.Label label27;
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
        internal System.Windows.Forms.ComboBox cmbCash_Credit;
        internal System.Windows.Forms.TextBox txtFinal_Net;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cmbPurchBy;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbCheckBy;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.DateTimePicker dtChqDate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView rgv_TaxInfo;
        internal System.Windows.Forms.TextBox txtFreeQty;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtKeyNo;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtItemNo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblInvType;
        internal System.Windows.Forms.TextBox txttcsAmt;
        internal System.Windows.Forms.Label label10;
        private Telerik.WinControls.UI.RadCheckBox rc_tcs;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtOhCharges;
    }
}