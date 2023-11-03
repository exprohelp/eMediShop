namespace eMediShop
{
    partial class adjustGR
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
            System.Windows.Forms.GroupBox GB;
            this.txtPurchId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtGRNO = new System.Windows.Forms.TextBox();
            this.grAllottedTo = new System.Windows.Forms.Label();
            this.lbltrfid = new System.Windows.Forms.Label();
            this.GVMAIN = new System.Windows.Forms.GroupBox();
            this.lvProductInfo = new System.Windows.Forms.ListView();
            this.Mkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Batch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Exp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BalPack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.npr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdjusted = new System.Windows.Forms.TextBox();
            this.txtCalculated = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            GB = new System.Windows.Forms.GroupBox();
            GB.SuspendLayout();
            this.GVMAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GB
            // 
            GB.Controls.Add(this.txtPurchId);
            GB.Controls.Add(this.label6);
            GB.Controls.Add(this.btnGo);
            GB.Controls.Add(this.txtGRNO);
            GB.Controls.Add(this.grAllottedTo);
            GB.Controls.Add(this.lbltrfid);
            GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GB.ForeColor = System.Drawing.Color.White;
            GB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            GB.Location = new System.Drawing.Point(12, 3);
            GB.Name = "GB";
            GB.Size = new System.Drawing.Size(869, 76);
            GB.TabIndex = 1;
            GB.TabStop = false;
            // 
            // txtPurchId
            // 
            this.txtPurchId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPurchId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPurchId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchId.ForeColor = System.Drawing.Color.Yellow;
            this.txtPurchId.Location = new System.Drawing.Point(670, 14);
            this.txtPurchId.MaxLength = 16;
            this.txtPurchId.Name = "txtPurchId";
            this.txtPurchId.Size = new System.Drawing.Size(174, 26);
            this.txtPurchId.TabIndex = 12;
            this.txtPurchId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "PURCHASE ID :";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(328, 13);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(50, 29);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtGRNO
            // 
            this.txtGRNO.BackColor = System.Drawing.Color.Black;
            this.txtGRNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRNO.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNO.ForeColor = System.Drawing.Color.Yellow;
            this.txtGRNO.Location = new System.Drawing.Point(99, 14);
            this.txtGRNO.MaxLength = 16;
            this.txtGRNO.Name = "txtGRNO";
            this.txtGRNO.Size = new System.Drawing.Size(193, 26);
            this.txtGRNO.TabIndex = 3;
            // 
            // grAllottedTo
            // 
            this.grAllottedTo.AutoSize = true;
            this.grAllottedTo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grAllottedTo.Location = new System.Drawing.Point(11, 43);
            this.grAllottedTo.Name = "grAllottedTo";
            this.grAllottedTo.Size = new System.Drawing.Size(83, 18);
            this.grAllottedTo.TabIndex = 2;
            this.grAllottedTo.Text = "Allotted To :";
            // 
            // lbltrfid
            // 
            this.lbltrfid.AutoSize = true;
            this.lbltrfid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrfid.Location = new System.Drawing.Point(38, 18);
            this.lbltrfid.Name = "lbltrfid";
            this.lbltrfid.Size = new System.Drawing.Size(57, 18);
            this.lbltrfid.TabIndex = 0;
            this.lbltrfid.Text = "G R No :";
            // 
            // GVMAIN
            // 
            this.GVMAIN.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GVMAIN.Controls.Add(this.lvProductInfo);
            this.GVMAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVMAIN.ForeColor = System.Drawing.Color.Transparent;
            this.GVMAIN.Location = new System.Drawing.Point(12, 80);
            this.GVMAIN.Name = "GVMAIN";
            this.GVMAIN.Size = new System.Drawing.Size(869, 372);
            this.GVMAIN.TabIndex = 2;
            this.GVMAIN.TabStop = false;
            // 
            // lvProductInfo
            // 
            this.lvProductInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvProductInfo.CheckBoxes = true;
            this.lvProductInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mkey,
            this.Product,
            this.Batch,
            this.Exp,
            this.Pack,
            this.BalPack,
            this.Amount,
            this.npr});
            this.lvProductInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProductInfo.ForeColor = System.Drawing.Color.White;
            this.lvProductInfo.FullRowSelect = true;
            this.lvProductInfo.GridLines = true;
            this.lvProductInfo.Location = new System.Drawing.Point(6, 18);
            this.lvProductInfo.Name = "lvProductInfo";
            this.lvProductInfo.Size = new System.Drawing.Size(857, 349);
            this.lvProductInfo.TabIndex = 2;
            this.lvProductInfo.UseCompatibleStateImageBehavior = false;
            this.lvProductInfo.View = System.Windows.Forms.View.Details;
            this.lvProductInfo.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProductInfo_ItemChecked);
            this.lvProductInfo.Click += new System.EventHandler(this.lvProductInfo_Click);
            this.lvProductInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvProductInfo_MouseDown);
            // 
            // Mkey
            // 
            this.Mkey.Text = "";
            this.Mkey.Width = 25;
            // 
            // Product
            // 
            this.Product.Text = "NAME OF ITEM";
            this.Product.Width = 381;
            // 
            // Batch
            // 
            this.Batch.Text = "BATCH NO";
            this.Batch.Width = 101;
            // 
            // Exp
            // 
            this.Exp.Text = "EXP DATE";
            this.Exp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Exp.Width = 87;
            // 
            // Pack
            // 
            this.Pack.Text = "PACKING";
            this.Pack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pack.Width = 77;
            // 
            // BalPack
            // 
            this.BalPack.Text = "BAL. PACK";
            this.BalPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BalPack.Width = 88;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 70;
            // 
            // npr
            // 
            this.npr.Text = "NPR";
            this.npr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npr.Width = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(788, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdjusted
            // 
            this.txtAdjusted.BackColor = System.Drawing.Color.Black;
            this.txtAdjusted.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdjusted.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjusted.ForeColor = System.Drawing.Color.Yellow;
            this.txtAdjusted.Location = new System.Drawing.Point(99, 457);
            this.txtAdjusted.MaxLength = 16;
            this.txtAdjusted.Name = "txtAdjusted";
            this.txtAdjusted.Size = new System.Drawing.Size(109, 26);
            this.txtAdjusted.TabIndex = 12;
            this.txtAdjusted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCalculated
            // 
            this.txtCalculated.BackColor = System.Drawing.Color.Black;
            this.txtCalculated.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalculated.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculated.ForeColor = System.Drawing.Color.Yellow;
            this.txtCalculated.Location = new System.Drawing.Point(293, 457);
            this.txtCalculated.MaxLength = 16;
            this.txtCalculated.Name = "txtCalculated";
            this.txtCalculated.Size = new System.Drawing.Size(117, 26);
            this.txtCalculated.TabIndex = 13;
            this.txtCalculated.Text = "0";
            this.txtCalculated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adjustment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Calculated";
            // 
            // adjustGR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(894, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalculated);
            this.Controls.Add(this.txtAdjusted);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GVMAIN);
            this.Controls.Add(GB);
            this.MaximizeBox = false;
            this.Name = "adjustGR";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TransferStock_Load);
            GB.ResumeLayout(false);
            GB.PerformLayout();
            this.GVMAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltrfid;
        private System.Windows.Forms.TextBox txtGRNO;
        private System.Windows.Forms.GroupBox GVMAIN;
        private System.Windows.Forms.ListView lvProductInfo;
        private System.Windows.Forms.ColumnHeader Mkey;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Batch;
        private System.Windows.Forms.ColumnHeader Exp;
        private System.Windows.Forms.ColumnHeader Pack;
        private System.Windows.Forms.ColumnHeader BalPack;
        private System.Windows.Forms.Button btnGo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPurchId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdjusted;
        private System.Windows.Forms.TextBox txtCalculated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Label grAllottedTo;
        private System.Windows.Forms.ColumnHeader npr;
    }
}