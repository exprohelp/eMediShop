namespace eMediShop
{
    partial class RepeatingJob
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDevelopment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(514, 78);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblDevelopment
            // 
            this.lblDevelopment.AutoSize = true;
            this.lblDevelopment.Location = new System.Drawing.Point(4, 4);
            this.lblDevelopment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevelopment.Name = "lblDevelopment";
            this.lblDevelopment.Size = new System.Drawing.Size(43, 13);
            this.lblDevelopment.TabIndex = 2;
            this.lblDevelopment.Text = "FromTo";
            // 
            // RepeatingJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDevelopment);
            this.Controls.Add(this.richTextBox1);
            this.Name = "RepeatingJob";
            this.Size = new System.Drawing.Size(532, 103);
            this.Load += new System.EventHandler(this.RepeatingJob_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDevelopment;
    }
}
