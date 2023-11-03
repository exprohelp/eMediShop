namespace eMediShop.forms.CentralAccess.HealthCards
{
    partial class ucNewCardEntry
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCardNo = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rbFree = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.cDOB5 = new System.Windows.Forms.DateTimePicker();
            this.cDOB4 = new System.Windows.Forms.DateTimePicker();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtcName5 = new System.Windows.Forms.TextBox();
            this.txtcName4 = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.CDOB3 = new System.Windows.Forms.DateTimePicker();
            this.Label17 = new System.Windows.Forms.Label();
            this.txtCName3 = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.CDOB2 = new System.Windows.Forms.DateTimePicker();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtCName2 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.CDOB1 = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.TxtCName1 = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.SDOB = new System.Windows.Forms.DateTimePicker();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtMobile = new eMediShop.NumericTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtLocality = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNo)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCardNo);
            this.GroupBox1.Controls.Add(this.rbFree);
            this.GroupBox1.Controls.Add(this.rbCash);
            this.GroupBox1.Controls.Add(this.cmbCardType);
            this.GroupBox1.Controls.Add(this.label21);
            this.GroupBox1.Controls.Add(this.label20);
            this.GroupBox1.Location = new System.Drawing.Point(1, 6);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(740, 59);
            this.GroupBox1.TabIndex = 35;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = " Health Card Info.";
            // 
            // txtCardNo
            // 
            this.txtCardNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCardNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.Location = new System.Drawing.Point(79, 26);
            this.txtCardNo.MaxLength = 12;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(208, 25);
            this.txtCardNo.TabIndex = 0;
            this.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardNo_KeyDown);
            this.txtCardNo.Leave += new System.EventHandler(this.txtCardNo_Leave);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtCardNo.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtCardNo.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rbFree
            // 
            this.rbFree.AutoSize = true;
            this.rbFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFree.Location = new System.Drawing.Point(653, 26);
            this.rbFree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFree.Name = "rbFree";
            this.rbFree.Size = new System.Drawing.Size(50, 17);
            this.rbFree.TabIndex = 21;
            this.rbFree.Text = "Free";
            this.rbFree.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.Location = new System.Drawing.Point(581, 26);
            this.rbCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(50, 17);
            this.rbCash.TabIndex = 20;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Paid";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // cmbCardType
            // 
            this.cmbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Items.AddRange(new object[] {
            "Silver",
            "Privilage"});
            this.cmbCardType.Location = new System.Drawing.Point(400, 25);
            this.cmbCardType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(161, 25);
            this.cmbCardType.TabIndex = 19;
            this.cmbCardType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCardType_KeyDown);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(316, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Card Type";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(21, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Card No.";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(397, 398);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 13);
            this.lblMessage.TabIndex = 37;
            this.lblMessage.Text = "Message :";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label25);
            this.GroupBox2.Controls.Add(this.lblMessage);
            this.GroupBox2.Controls.Add(this.Label24);
            this.GroupBox2.Controls.Add(this.cDOB5);
            this.GroupBox2.Controls.Add(this.cDOB4);
            this.GroupBox2.Controls.Add(this.Label23);
            this.GroupBox2.Controls.Add(this.Label22);
            this.GroupBox2.Controls.Add(this.txtcName5);
            this.GroupBox2.Controls.Add(this.txtcName4);
            this.GroupBox2.Controls.Add(this.txtPin);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.cmdSubmit);
            this.GroupBox2.Controls.Add(this.CDOB3);
            this.GroupBox2.Controls.Add(this.Label17);
            this.GroupBox2.Controls.Add(this.txtCName3);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.CDOB2);
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Controls.Add(this.txtCName2);
            this.GroupBox2.Controls.Add(this.Label16);
            this.GroupBox2.Controls.Add(this.CDOB1);
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.TxtCName1);
            this.GroupBox2.Controls.Add(this.Label14);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.SDOB);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.txtSName);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.txtMobile);
            this.GroupBox2.Controls.Add(this.txtEmail);
            this.GroupBox2.Controls.Add(this.txtPhone);
            this.GroupBox2.Controls.Add(this.DOB);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.txtName);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.txtArea);
            this.GroupBox2.Controls.Add(this.txtLocality);
            this.GroupBox2.Controls.Add(this.cmbState);
            this.GroupBox2.Controls.Add(this.cmbDistrict);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(1, 70);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(740, 423);
            this.GroupBox2.TabIndex = 36;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mandatory Information";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(14, 206);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(21, 17);
            this.Label25.TabIndex = 42;
            this.Label25.Text = "5)";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(14, 180);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(21, 17);
            this.Label24.TabIndex = 41;
            this.Label24.Text = "4)";
            // 
            // cDOB5
            // 
            this.cDOB5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cDOB5.Location = new System.Drawing.Point(610, 200);
            this.cDOB5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cDOB5.Name = "cDOB5";
            this.cDOB5.Size = new System.Drawing.Size(112, 23);
            this.cDOB5.TabIndex = 40;
            this.cDOB5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cDOB5_KeyDown);
            // 
            // cDOB4
            // 
            this.cDOB4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cDOB4.Location = new System.Drawing.Point(610, 174);
            this.cDOB4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cDOB4.Name = "cDOB4";
            this.cDOB4.Size = new System.Drawing.Size(112, 23);
            this.cDOB4.TabIndex = 39;
            this.cDOB4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cDOB4_KeyDown);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(503, 206);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(87, 17);
            this.Label23.TabIndex = 38;
            this.Label23.Text = "Date of Birth";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(503, 180);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(87, 17);
            this.Label22.TabIndex = 37;
            this.Label22.Text = "Date of Birth";
            // 
            // txtcName5
            // 
            this.txtcName5.Location = new System.Drawing.Point(44, 200);
            this.txtcName5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcName5.MaxLength = 35;
            this.txtcName5.Name = "txtcName5";
            this.txtcName5.Size = new System.Drawing.Size(270, 23);
            this.txtcName5.TabIndex = 36;
            this.txtcName5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcName5_KeyDown);
            // 
            // txtcName4
            // 
            this.txtcName4.Location = new System.Drawing.Point(44, 174);
            this.txtcName4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcName4.MaxLength = 35;
            this.txtcName4.Name = "txtcName4";
            this.txtcName4.Size = new System.Drawing.Size(270, 23);
            this.txtcName4.TabIndex = 35;
            this.txtcName4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcName4_KeyDown);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(126, 339);
            this.txtPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPin.MaxLength = 7;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(161, 23);
            this.txtPin.TabIndex = 17;
            this.txtPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPin_KeyDown);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(89, 340);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(28, 17);
            this.Label19.TabIndex = 34;
            this.Label19.Text = "Pin";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(610, 331);
            this.cmdSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(99, 39);
            this.cmdSubmit.TabIndex = 20;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // CDOB3
            // 
            this.CDOB3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CDOB3.Location = new System.Drawing.Point(612, 147);
            this.CDOB3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CDOB3.Name = "CDOB3";
            this.CDOB3.Size = new System.Drawing.Size(112, 23);
            this.CDOB3.TabIndex = 11;
            this.CDOB3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CDOB3_KeyDown_1);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(503, 153);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(87, 17);
            this.Label17.TabIndex = 33;
            this.Label17.Text = "Date of Birth";
            // 
            // txtCName3
            // 
            this.txtCName3.Location = new System.Drawing.Point(44, 147);
            this.txtCName3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCName3.MaxLength = 35;
            this.txtCName3.Name = "txtCName3";
            this.txtCName3.Size = new System.Drawing.Size(270, 23);
            this.txtCName3.TabIndex = 10;
            this.txtCName3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCName3_KeyDown);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(14, 153);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(21, 17);
            this.Label18.TabIndex = 31;
            this.Label18.Text = "3)";
            // 
            // CDOB2
            // 
            this.CDOB2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CDOB2.Location = new System.Drawing.Point(612, 121);
            this.CDOB2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CDOB2.Name = "CDOB2";
            this.CDOB2.Size = new System.Drawing.Size(112, 23);
            this.CDOB2.TabIndex = 9;
            this.CDOB2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CDOB2_KeyDown_1);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(503, 127);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(87, 17);
            this.Label15.TabIndex = 29;
            this.Label15.Text = "Date of Birth";
            // 
            // txtCName2
            // 
            this.txtCName2.Location = new System.Drawing.Point(44, 121);
            this.txtCName2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCName2.MaxLength = 35;
            this.txtCName2.Name = "txtCName2";
            this.txtCName2.Size = new System.Drawing.Size(270, 23);
            this.txtCName2.TabIndex = 8;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(14, 127);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(21, 17);
            this.Label16.TabIndex = 27;
            this.Label16.Text = "2)";
            // 
            // CDOB1
            // 
            this.CDOB1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CDOB1.Location = new System.Drawing.Point(612, 94);
            this.CDOB1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CDOB1.Name = "CDOB1";
            this.CDOB1.Size = new System.Drawing.Size(112, 23);
            this.CDOB1.TabIndex = 7;
            this.CDOB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CDOB1_KeyDown);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(503, 100);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(87, 17);
            this.Label13.TabIndex = 25;
            this.Label13.Text = "Date of Birth";
            // 
            // TxtCName1
            // 
            this.TxtCName1.Location = new System.Drawing.Point(44, 94);
            this.TxtCName1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCName1.MaxLength = 35;
            this.TxtCName1.Name = "TxtCName1";
            this.TxtCName1.Size = new System.Drawing.Size(270, 23);
            this.TxtCName1.TabIndex = 6;
            this.TxtCName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCName1_KeyDown);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(14, 100);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(21, 17);
            this.Label14.TabIndex = 23;
            this.Label14.Text = "1)";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(14, 70);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(183, 17);
            this.Label12.TabIndex = 22;
            this.Label12.Text = "Dependent Information :";
            // 
            // SDOB
            // 
            this.SDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SDOB.Location = new System.Drawing.Point(612, 44);
            this.SDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SDOB.Name = "SDOB";
            this.SDOB.Size = new System.Drawing.Size(112, 23);
            this.SDOB.TabIndex = 5;
            this.SDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SDOB_KeyDown);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(503, 50);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(87, 17);
            this.Label11.TabIndex = 20;
            this.Label11.Text = "Date of Birth";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(136, 44);
            this.txtSName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSName.MaxLength = 50;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(270, 23);
            this.txtSName.TabIndex = 4;
            this.txtSName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSName_KeyDown);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(14, 50);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(121, 17);
            this.Label10.TabIndex = 18;
            this.Label10.Text = "Name of Spouse :";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(576, 233);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(146, 23);
            this.txtMobile.TabIndex = 13;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(128, 260);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 23);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(129, 233);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 23);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // DOB
            // 
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(612, 17);
            this.DOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(112, 23);
            this.DOB.TabIndex = 3;
            this.DOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DOB_KeyDown);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(76, 260);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(45, 18);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "Email";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(479, 235);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 18);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "Mobile No.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 23);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(6, 233);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(105, 18);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Telephone No.";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(127, 286);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArea.MaxLength = 50;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(312, 23);
            this.txtArea.TabIndex = 15;
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArea_KeyDown);
            // 
            // txtLocality
            // 
            this.txtLocality.Location = new System.Drawing.Point(127, 313);
            this.txtLocality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocality.MaxLength = 50;
            this.txtLocality.Name = "txtLocality";
            this.txtLocality.Size = new System.Drawing.Size(312, 23);
            this.txtLocality.TabIndex = 16;
            this.txtLocality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocality_KeyDown);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(127, 366);
            this.cmbState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(250, 24);
            this.cmbState.TabIndex = 18;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            this.cmbState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbState_KeyDown);
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(127, 393);
            this.cmbDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(250, 24);
            this.cmbDistrict.TabIndex = 19;
            this.cmbDistrict.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDistrict_KeyDown);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(76, 374);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 17);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "State";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(64, 401);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(51, 17);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "District";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(59, 317);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 17);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Locality";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(80, 288);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 17);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Area";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(503, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Date of Birth";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(124, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Name of Member :";
            // 
            // ucNewCardEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucNewCardEntry";
            this.Size = new System.Drawing.Size(748, 510);
            this.Load += new System.EventHandler(this.ucNewCardEntry_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNo)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cmbCardType;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label lblMessage;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.DateTimePicker cDOB5;
        internal System.Windows.Forms.DateTimePicker cDOB4;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtcName5;
        internal System.Windows.Forms.TextBox txtcName4;
        internal System.Windows.Forms.TextBox txtPin;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Button cmdSubmit;
        internal System.Windows.Forms.DateTimePicker CDOB3;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox txtCName3;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.DateTimePicker CDOB2;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtCName2;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.DateTimePicker CDOB1;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox TxtCName1;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DateTimePicker SDOB;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtSName;
        internal System.Windows.Forms.Label Label10;
        private NumericTextBox txtMobile;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.DateTimePicker DOB;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtArea;
        internal System.Windows.Forms.TextBox txtLocality;
        internal System.Windows.Forms.ComboBox cmbState;
        internal System.Windows.Forms.ComboBox cmbDistrict;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RadioButton rbFree;
        private System.Windows.Forms.RadioButton rbCash;
        private Telerik.WinControls.UI.RadTextBox txtCardNo;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
    }
}
