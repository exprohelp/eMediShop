namespace eMediShop.forms.RCM
{
    partial class QuestionAnswer
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.PnlAnswer = new System.Windows.Forms.Panel();
            this.PnlMsg = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Navy;
            this.lblQuestion.Location = new System.Drawing.Point(2, 1);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(21, 14);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "lbl";
            // 
            // Pnl1
            // 
            this.Pnl1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl1.Location = new System.Drawing.Point(320, 4);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(49, 31);
            this.Pnl1.TabIndex = 2;
            // 
            // pnl2
            // 
            this.pnl2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl2.Location = new System.Drawing.Point(374, 4);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(51, 31);
            this.pnl2.TabIndex = 3;
            // 
            // PnlAnswer
            // 
            this.PnlAnswer.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlAnswer.Location = new System.Drawing.Point(3, 16);
            this.PnlAnswer.Name = "PnlAnswer";
            this.PnlAnswer.Size = new System.Drawing.Size(306, 20);
            this.PnlAnswer.TabIndex = 4;
            // 
            // PnlMsg
            // 
            this.PnlMsg.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlMsg.Location = new System.Drawing.Point(430, 8);
            this.PnlMsg.Name = "PnlMsg";
            this.PnlMsg.Size = new System.Drawing.Size(38, 24);
            this.PnlMsg.TabIndex = 5;
            // 
            // cbxPredefinedRemark
            // 
            // 
            // QuestionAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PnlMsg);
            this.Controls.Add(this.PnlAnswer);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.Pnl1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "QuestionAnswer";
            this.Size = new System.Drawing.Size(472, 69);
            this.Load += new System.EventHandler(this.QuestionAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel PnlAnswer;
        private System.Windows.Forms.Panel PnlMsg;

    }
}