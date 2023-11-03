namespace eMediShop
{
    partial class PurchaseHelp
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxItemName = new System.Windows.Forms.ComboBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMainLko = new System.Windows.Forms.GroupBox();
            this.txLkPurchFrom = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txLkMrp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txLk_Trade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txLk_Dis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txLk_bestNpr = new System.Windows.Forms.TextBox();
            this.txLk_free = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbMainUnit = new System.Windows.Forms.GroupBox();
            this.txun_PurchFrom = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txur_Mrp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txun_Trade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txun_disc = new System.Windows.Forms.TextBox();
            this.txun_npr = new System.Windows.Forms.TextBox();
            this.txun_free = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbLuck = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxUnit = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbMainLko.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbMainUnit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbLuck.SuspendLayout();
            this.gbxUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Look For ";
            // 
            // cbxItemName
            // 
            this.cbxItemName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItemName.FormattingEnabled = true;
            this.cbxItemName.Location = new System.Drawing.Point(323, 14);
            this.cbxItemName.Name = "cbxItemName";
            this.cbxItemName.Size = new System.Drawing.Size(339, 24);
            this.cbxItemName.TabIndex = 1;
            this.cbxItemName.SelectedIndexChanged += new System.EventHandler(this.cbxItemName_SelectedIndexChanged);
            this.cbxItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxItemName_KeyDown);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(107, 15);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(140, 22);
            this.txtKey.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.gbMainLko);
            this.groupBox1.Location = new System.Drawing.Point(5, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 364);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Central Best Deal";
            // 
            // gbMainLko
            // 
            this.gbMainLko.Controls.Add(this.txLkPurchFrom);
            this.gbMainLko.Controls.Add(this.label3);
            this.gbMainLko.Controls.Add(this.txLkMrp);
            this.gbMainLko.Controls.Add(this.label5);
            this.gbMainLko.Controls.Add(this.label6);
            this.gbMainLko.Controls.Add(this.txLk_Trade);
            this.gbMainLko.Controls.Add(this.label4);
            this.gbMainLko.Controls.Add(this.label7);
            this.gbMainLko.Controls.Add(this.txLk_Dis);
            this.gbMainLko.Controls.Add(this.label8);
            this.gbMainLko.Controls.Add(this.txLk_bestNpr);
            this.gbMainLko.Controls.Add(this.txLk_free);
            this.gbMainLko.Location = new System.Drawing.Point(12, 20);
            this.gbMainLko.Name = "gbMainLko";
            this.gbMainLko.Size = new System.Drawing.Size(383, 329);
            this.gbMainLko.TabIndex = 15;
            this.gbMainLko.TabStop = false;
            // 
            // txLkPurchFrom
            // 
            this.txLkPurchFrom.BackColor = System.Drawing.Color.LightBlue;
            this.txLkPurchFrom.Enabled = false;
            this.txLkPurchFrom.Location = new System.Drawing.Point(9, 26);
            this.txLkPurchFrom.Name = "txLkPurchFrom";
            this.txLkPurchFrom.Size = new System.Drawing.Size(368, 85);
            this.txLkPurchFrom.TabIndex = 14;
            this.txLkPurchFrom.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Purchase From :";
            // 
            // txLkMrp
            // 
            this.txLkMrp.AcceptsTab = true;
            this.txLkMrp.BackColor = System.Drawing.Color.LightBlue;
            this.txLkMrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txLkMrp.Enabled = false;
            this.txLkMrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLkMrp.Location = new System.Drawing.Point(130, 117);
            this.txLkMrp.Name = "txLkMrp";
            this.txLkMrp.Size = new System.Drawing.Size(91, 24);
            this.txLkMrp.TabIndex = 13;
            this.txLkMrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "TRADE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "DIS % :";
            // 
            // txLk_Trade
            // 
            this.txLk_Trade.BackColor = System.Drawing.Color.LightBlue;
            this.txLk_Trade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txLk_Trade.Enabled = false;
            this.txLk_Trade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLk_Trade.Location = new System.Drawing.Point(130, 147);
            this.txLk_Trade.Name = "txLk_Trade";
            this.txLk_Trade.Size = new System.Drawing.Size(91, 24);
            this.txLk_Trade.TabIndex = 12;
            this.txLk_Trade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MRP :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "FREE :";
            // 
            // txLk_Dis
            // 
            this.txLk_Dis.BackColor = System.Drawing.Color.LightBlue;
            this.txLk_Dis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txLk_Dis.Enabled = false;
            this.txLk_Dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLk_Dis.Location = new System.Drawing.Point(130, 177);
            this.txLk_Dis.Name = "txLk_Dis";
            this.txLk_Dis.Size = new System.Drawing.Size(91, 24);
            this.txLk_Dis.TabIndex = 11;
            this.txLk_Dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "NPR";
            // 
            // txLk_bestNpr
            // 
            this.txLk_bestNpr.BackColor = System.Drawing.Color.LightBlue;
            this.txLk_bestNpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txLk_bestNpr.Enabled = false;
            this.txLk_bestNpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLk_bestNpr.ForeColor = System.Drawing.Color.Red;
            this.txLk_bestNpr.Location = new System.Drawing.Point(130, 243);
            this.txLk_bestNpr.Name = "txLk_bestNpr";
            this.txLk_bestNpr.Size = new System.Drawing.Size(91, 29);
            this.txLk_bestNpr.TabIndex = 9;
            this.txLk_bestNpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txLk_free
            // 
            this.txLk_free.AcceptsTab = true;
            this.txLk_free.BackColor = System.Drawing.Color.LightBlue;
            this.txLk_free.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txLk_free.Enabled = false;
            this.txLk_free.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLk_free.Location = new System.Drawing.Point(130, 207);
            this.txLk_free.Name = "txLk_free";
            this.txLk_free.Size = new System.Drawing.Size(91, 24);
            this.txLk_free.TabIndex = 10;
            this.txLk_free.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.gbMainUnit);
            this.groupBox2.Location = new System.Drawing.Point(424, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 365);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "At-Unit (Last Purchase)";
            // 
            // gbMainUnit
            // 
            this.gbMainUnit.Controls.Add(this.txun_PurchFrom);
            this.gbMainUnit.Controls.Add(this.label14);
            this.gbMainUnit.Controls.Add(this.label11);
            this.gbMainUnit.Controls.Add(this.txur_Mrp);
            this.gbMainUnit.Controls.Add(this.label12);
            this.gbMainUnit.Controls.Add(this.label10);
            this.gbMainUnit.Controls.Add(this.txun_Trade);
            this.gbMainUnit.Controls.Add(this.label13);
            this.gbMainUnit.Controls.Add(this.label9);
            this.gbMainUnit.Controls.Add(this.txun_disc);
            this.gbMainUnit.Controls.Add(this.txun_npr);
            this.gbMainUnit.Controls.Add(this.txun_free);
            this.gbMainUnit.Location = new System.Drawing.Point(13, 19);
            this.gbMainUnit.Name = "gbMainUnit";
            this.gbMainUnit.Size = new System.Drawing.Size(412, 328);
            this.gbMainUnit.TabIndex = 0;
            this.gbMainUnit.TabStop = false;
            // 
            // txun_PurchFrom
            // 
            this.txun_PurchFrom.BackColor = System.Drawing.Color.LightBlue;
            this.txun_PurchFrom.Enabled = false;
            this.txun_PurchFrom.Location = new System.Drawing.Point(12, 27);
            this.txun_PurchFrom.Name = "txun_PurchFrom";
            this.txun_PurchFrom.Size = new System.Drawing.Size(389, 85);
            this.txun_PurchFrom.TabIndex = 28;
            this.txun_PurchFrom.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Purchase From :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "DIS % :";
            // 
            // txur_Mrp
            // 
            this.txur_Mrp.BackColor = System.Drawing.Color.LightBlue;
            this.txur_Mrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txur_Mrp.Enabled = false;
            this.txur_Mrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txur_Mrp.Location = new System.Drawing.Point(148, 118);
            this.txur_Mrp.Name = "txur_Mrp";
            this.txur_Mrp.Size = new System.Drawing.Size(91, 24);
            this.txur_Mrp.TabIndex = 27;
            this.txur_Mrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "TRADE :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "FREE :";
            // 
            // txun_Trade
            // 
            this.txun_Trade.BackColor = System.Drawing.Color.LightBlue;
            this.txun_Trade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txun_Trade.Enabled = false;
            this.txun_Trade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txun_Trade.Location = new System.Drawing.Point(148, 148);
            this.txun_Trade.Name = "txun_Trade";
            this.txun_Trade.Size = new System.Drawing.Size(91, 24);
            this.txun_Trade.TabIndex = 26;
            this.txun_Trade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "MRP :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "NPR";
            // 
            // txun_disc
            // 
            this.txun_disc.BackColor = System.Drawing.Color.LightBlue;
            this.txun_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txun_disc.Enabled = false;
            this.txun_disc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txun_disc.Location = new System.Drawing.Point(148, 178);
            this.txun_disc.Name = "txun_disc";
            this.txun_disc.Size = new System.Drawing.Size(91, 24);
            this.txun_disc.TabIndex = 25;
            this.txun_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txun_npr
            // 
            this.txun_npr.AcceptsReturn = true;
            this.txun_npr.BackColor = System.Drawing.Color.LightBlue;
            this.txun_npr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txun_npr.Enabled = false;
            this.txun_npr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txun_npr.ForeColor = System.Drawing.Color.Red;
            this.txun_npr.Location = new System.Drawing.Point(148, 244);
            this.txun_npr.Name = "txun_npr";
            this.txun_npr.Size = new System.Drawing.Size(93, 29);
            this.txun_npr.TabIndex = 23;
            this.txun_npr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txun_free
            // 
            this.txun_free.BackColor = System.Drawing.Color.LightBlue;
            this.txun_free.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txun_free.Enabled = false;
            this.txun_free.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txun_free.Location = new System.Drawing.Point(148, 208);
            this.txun_free.Name = "txun_free";
            this.txun_free.Size = new System.Drawing.Size(91, 24);
            this.txun_free.TabIndex = 24;
            this.txun_free.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(763, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(83, 34);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxItemName);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtKey);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(5, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 46);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // gbLuck
            // 
            this.gbLuck.Controls.Add(this.label15);
            this.gbLuck.Controls.Add(this.label2);
            this.gbLuck.Location = new System.Drawing.Point(77, 423);
            this.gbLuck.Name = "gbLuck";
            this.gbLuck.Size = new System.Drawing.Size(270, 18);
            this.gbLuck.TabIndex = 15;
            this.gbLuck.TabStop = false;
            this.gbLuck.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(59, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "Record Not Found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sorry !!";
            // 
            // gbxUnit
            // 
            this.gbxUnit.Controls.Add(this.label16);
            this.gbxUnit.Controls.Add(this.label17);
            this.gbxUnit.Location = new System.Drawing.Point(516, 423);
            this.gbxUnit.Name = "gbxUnit";
            this.gbxUnit.Size = new System.Drawing.Size(270, 18);
            this.gbxUnit.TabIndex = 29;
            this.gbxUnit.TabStop = false;
            this.gbxUnit.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(59, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Record Not Found";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(81, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 29);
            this.label17.TabIndex = 0;
            this.label17.Text = "Sorry !!";
            // 
            // PurchaseHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(863, 446);
            this.Controls.Add(this.gbxUnit);
            this.Controls.Add(this.gbLuck);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "PurchaseHelp";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Purhase Help";
            this.Load += new System.EventHandler(this.PurhaseHelp_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbMainLko.ResumeLayout(false);
            this.gbMainLko.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbMainUnit.ResumeLayout(false);
            this.gbMainUnit.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbLuck.ResumeLayout(false);
            this.gbLuck.PerformLayout();
            this.gbxUnit.ResumeLayout(false);
            this.gbxUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItemName;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txLkMrp;
        private System.Windows.Forms.TextBox txLk_Trade;
        private System.Windows.Forms.TextBox txLk_Dis;
        private System.Windows.Forms.TextBox txLk_free;
        private System.Windows.Forms.TextBox txLk_bestNpr;
        private System.Windows.Forms.TextBox txur_Mrp;
        private System.Windows.Forms.TextBox txun_Trade;
        private System.Windows.Forms.TextBox txun_disc;
        private System.Windows.Forms.TextBox txun_free;
        private System.Windows.Forms.TextBox txun_npr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox txLkPurchFrom;
        private System.Windows.Forms.RichTextBox txun_PurchFrom;
        private System.Windows.Forms.GroupBox gbLuck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbMainLko;
        private System.Windows.Forms.GroupBox gbMainUnit;
    }
}