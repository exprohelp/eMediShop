namespace eMediShop.token
{
    partial class DisplayToken
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
            this.tlp_token = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTokenNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Ready = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tlp_token.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_token
            // 
            this.tlp_token.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlp_token.ColumnCount = 2;
            this.tlp_token.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_token.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_token.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_token.Controls.Add(this.label1, 0, 0);
            this.tlp_token.Controls.Add(this.lblTokenNo, 0, 1);
            this.tlp_token.Controls.Add(this.label2, 1, 0);
            this.tlp_token.Controls.Add(this.rtb_Ready, 1, 1);
            this.tlp_token.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_token.Location = new System.Drawing.Point(0, 0);
            this.tlp_token.Name = "tlp_token";
            this.tlp_token.RowCount = 2;
            this.tlp_token.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_token.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_token.Size = new System.Drawing.Size(1153, 453);
            this.tlp_token.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token in Q";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTokenNo
            // 
            this.lblTokenNo.AutoSize = true;
            this.lblTokenNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTokenNo.Font = new System.Drawing.Font("Engravers MT", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNo.ForeColor = System.Drawing.Color.Red;
            this.lblTokenNo.Location = new System.Drawing.Point(6, 139);
            this.lblTokenNo.Name = "lblTokenNo";
            this.lblTokenNo.Size = new System.Drawing.Size(680, 311);
            this.lblTokenNo.TabIndex = 1;
            this.lblTokenNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(695, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 133);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ready";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtb_Ready
            // 
            this.rtb_Ready.BackColor = System.Drawing.Color.Black;
            this.rtb_Ready.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Ready.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Ready.ForeColor = System.Drawing.Color.Yellow;
            this.rtb_Ready.Location = new System.Drawing.Point(695, 142);
            this.rtb_Ready.Name = "rtb_Ready";
            this.rtb_Ready.Size = new System.Drawing.Size(452, 305);
            this.rtb_Ready.TabIndex = 3;
            this.rtb_Ready.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DisplayToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1153, 453);
            this.Controls.Add(this.tlp_token);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayToken";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DisplayToken_Load);
            this.tlp_token.ResumeLayout(false);
            this.tlp_token.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTokenNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Ready;
    }
}