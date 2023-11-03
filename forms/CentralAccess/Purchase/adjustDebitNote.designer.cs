namespace eMediShop
{
    partial class adjustDebitNote
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adjustDebitNote));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
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
            this.npr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adjType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdjusted = new System.Windows.Forms.TextBox();
            this.txtCalculated = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgv_debitNotes = new Telerik.WinControls.UI.RadGridView();
            this.lblresult = new System.Windows.Forms.Label();
            this.auto_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            GB = new System.Windows.Forms.GroupBox();
            GB.SuspendLayout();
            this.GVMAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes.MasterTemplate)).BeginInit();
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
            GB.Location = new System.Drawing.Point(217, 5);
            GB.Name = "GB";
            GB.Size = new System.Drawing.Size(872, 76);
            GB.TabIndex = 1;
            GB.TabStop = false;
            // 
            // txtPurchId
            // 
            this.txtPurchId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPurchId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPurchId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchId.ForeColor = System.Drawing.Color.Yellow;
            this.txtPurchId.Location = new System.Drawing.Point(688, 13);
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
            this.label6.Location = new System.Drawing.Point(585, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "PURCHASE ID :";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(349, 13);
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
            this.txtGRNO.Location = new System.Drawing.Point(120, 14);
            this.txtGRNO.MaxLength = 16;
            this.txtGRNO.Name = "txtGRNO";
            this.txtGRNO.ReadOnly = true;
            this.txtGRNO.Size = new System.Drawing.Size(193, 26);
            this.txtGRNO.TabIndex = 3;
            // 
            // grAllottedTo
            // 
            this.grAllottedTo.AutoSize = true;
            this.grAllottedTo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grAllottedTo.Location = new System.Drawing.Point(32, 43);
            this.grAllottedTo.Name = "grAllottedTo";
            this.grAllottedTo.Size = new System.Drawing.Size(83, 18);
            this.grAllottedTo.TabIndex = 2;
            this.grAllottedTo.Text = "Allotted To :";
            // 
            // lbltrfid
            // 
            this.lbltrfid.AutoSize = true;
            this.lbltrfid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrfid.Location = new System.Drawing.Point(11, 17);
            this.lbltrfid.Name = "lbltrfid";
            this.lbltrfid.Size = new System.Drawing.Size(104, 18);
            this.lbltrfid.TabIndex = 0;
            this.lbltrfid.Text = "Debit Note No :";
            // 
            // GVMAIN
            // 
            this.GVMAIN.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GVMAIN.Controls.Add(this.lvProductInfo);
            this.GVMAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVMAIN.ForeColor = System.Drawing.Color.Transparent;
            this.GVMAIN.Location = new System.Drawing.Point(217, 82);
            this.GVMAIN.Name = "GVMAIN";
            this.GVMAIN.Size = new System.Drawing.Size(872, 372);
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
            this.npr,
            this.Amount,
            this.adjType,
            this.status,
            this.qty,
            this.auto_id});
            this.lvProductInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProductInfo.ForeColor = System.Drawing.Color.White;
            this.lvProductInfo.FullRowSelect = true;
            this.lvProductInfo.GridLines = true;
            this.lvProductInfo.HideSelection = false;
            this.lvProductInfo.Location = new System.Drawing.Point(6, 18);
            this.lvProductInfo.Name = "lvProductInfo";
            this.lvProductInfo.Size = new System.Drawing.Size(849, 349);
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
            this.Product.Width = 305;
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
            // npr
            // 
            this.npr.Text = "NPR";
            this.npr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 70;
            // 
            // adjType
            // 
            this.adjType.Text = "Adj. Type";
            this.adjType.Width = 100;
            // 
            // status
            // 
            this.status.Text = "status";
            this.status.Width = 0;
            // 
            // qty
            // 
            this.qty.Text = "qty";
            this.qty.Width = 0;
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
            this.button1.Location = new System.Drawing.Point(665, 459);
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
            this.txtAdjusted.Location = new System.Drawing.Point(304, 459);
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
            this.txtCalculated.Location = new System.Drawing.Point(498, 459);
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
            this.label1.Location = new System.Drawing.Point(217, 462);
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
            this.label2.Location = new System.Drawing.Point(419, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Calculated";
            // 
            // rgv_debitNotes
            // 
            this.rgv_debitNotes.BackColor = System.Drawing.Color.LightSlateGray;
            this.rgv_debitNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgv_debitNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgv_debitNotes.ForeColor = System.Drawing.Color.Black;
            this.rgv_debitNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgv_debitNotes.Location = new System.Drawing.Point(-1, 13);
            // 
            // 
            // 
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "debitnote_no";
            gridViewTextBoxColumn1.HeaderText = "Debit Note No.";
            gridViewTextBoxColumn1.Name = "debitnoteno";
            gridViewTextBoxColumn1.Width = 168;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.HeaderImage")));
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.Name = "column1";
            gridViewCommandColumn1.Width = 25;
            this.rgv_debitNotes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1});
            this.rgv_debitNotes.MasterTemplate.EnableFiltering = true;
            this.rgv_debitNotes.MasterTemplate.EnableGrouping = false;
            this.rgv_debitNotes.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_debitNotes.Name = "rgv_debitNotes";
            this.rgv_debitNotes.ReadOnly = true;
            this.rgv_debitNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgv_debitNotes.Size = new System.Drawing.Size(218, 473);
            this.rgv_debitNotes.TabIndex = 16;
            this.rgv_debitNotes.Text = "radGridView1";
            this.rgv_debitNotes.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.rgv_debitNotes_CommandCellClick);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.ForeColor = System.Drawing.Color.White;
            this.lblresult.Location = new System.Drawing.Point(765, 464);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(104, 18);
            this.lblresult.TabIndex = 17;
            this.lblresult.Text = "XXXXXXXXXXXX";
            // 
            // auto_id
            // 
            this.auto_id.Text = "auto_id";
            this.auto_id.Width = 0;
            // 
            // adjustDebitNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1091, 488);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.rgv_debitNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalculated);
            this.Controls.Add(this.txtAdjusted);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GVMAIN);
            this.Controls.Add(GB);
            this.MaximizeBox = false;
            this.Name = "adjustDebitNote";
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
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_debitNotes)).EndInit();
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
        private System.Windows.Forms.ColumnHeader adjType;
        private Telerik.WinControls.UI.RadGridView rgv_debitNotes;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.ColumnHeader auto_id;
    }
}