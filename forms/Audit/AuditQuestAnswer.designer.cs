partial class AuditQuestAnswer
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
            this.lblQuestion = new System.Windows.Forms.RichTextBox();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.rbNotOk = new System.Windows.Forms.RadioButton();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtMaxRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion.Location = new System.Drawing.Point(2, 1);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(707, 30);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "";
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Location = new System.Drawing.Point(7, 40);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(42, 17);
            this.rbOk.TabIndex = 1;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "OK";
            this.rbOk.UseVisualStyleBackColor = true;
            // 
            // rbNotOk
            // 
            this.rbNotOk.AutoSize = true;
            this.rbNotOk.Location = new System.Drawing.Point(7, 60);
            this.rbNotOk.Name = "rbNotOk";
            this.rbNotOk.Size = new System.Drawing.Size(72, 17);
            this.rbNotOk.TabIndex = 2;
            this.rbNotOk.TabStop = true;
            this.rbNotOk.Text = "NOT OK";
            this.rbNotOk.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRemark.Location = new System.Drawing.Point(78, 32);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(485, 49);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(659, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(661, 62);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "/";
            // 
            // txtrate
            // 
            this.txtrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrate.Location = new System.Drawing.Point(616, 57);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(29, 20);
            this.txtrate.TabIndex = 13;
            this.txtrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxRate
            // 
            this.txtMaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxRate.Location = new System.Drawing.Point(569, 57);
            this.txtMaxRate.Name = "txtMaxRate";
            this.txtMaxRate.ReadOnly = true;
            this.txtMaxRate.Size = new System.Drawing.Size(31, 20);
            this.txtMaxRate.TabIndex = 12;
            this.txtMaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rating";
            // 
            // AuditQuestAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtMaxRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.rbNotOk);
            this.Controls.Add(this.rbOk);
            this.Controls.Add(this.lblQuestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AuditQuestAnswer";
            this.Size = new System.Drawing.Size(710, 84);
            this.Load += new System.EventHandler(this.QuestionAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox lblQuestion;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.RadioButton rbNotOk;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMsg;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtrate;
    private System.Windows.Forms.TextBox txtMaxRate;
    private System.Windows.Forms.Label label1;
}
