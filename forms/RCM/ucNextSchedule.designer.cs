namespace eMediShop.forms.RCM
{
    partial class ucNextSchedule
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
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cmbNextCalltime = new System.Windows.Forms.ComboBox();
            this.dtNextCalldate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnOnCallSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtNextCalldate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOnCallSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(224, 15);
            this.label20.TabIndex = 18;
            this.label20.Text = "Remark/New Medicine Information";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(273, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Next Call Date/Time";
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(7, 23);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(252, 24);
            this.txtRemark.TabIndex = 15;
            // 
            // cmbNextCalltime
            // 
            this.cmbNextCalltime.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNextCalltime.FormattingEnabled = true;
            this.cmbNextCalltime.Items.AddRange(new object[] {
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 AM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM",
            "12:00 PM"});
            this.cmbNextCalltime.Location = new System.Drawing.Point(359, 23);
            this.cmbNextCalltime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNextCalltime.Name = "cmbNextCalltime";
            this.cmbNextCalltime.Size = new System.Drawing.Size(74, 24);
            this.cmbNextCalltime.TabIndex = 17;
            this.cmbNextCalltime.Text = "11:00 AM";
            // 
            // dtNextCalldate
            // 
            this.dtNextCalldate.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.dtNextCalldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNextCalldate.Location = new System.Drawing.Point(263, 23);
            this.dtNextCalldate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNextCalldate.Name = "dtNextCalldate";
            this.dtNextCalldate.Size = new System.Drawing.Size(91, 23);
            this.dtNextCalldate.TabIndex = 21;
            this.dtNextCalldate.TabStop = false;
            this.dtNextCalldate.Text = "28/10/2015";
            this.dtNextCalldate.Value = new System.DateTime(2015, 10, 28, 16, 46, 31, 165);
            // 
            // btnOnCallSave
            // 
            this.btnOnCallSave.Image = global::eMediShop.Properties.Resources.Save_32;
            this.btnOnCallSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOnCallSave.Location = new System.Drawing.Point(439, 22);
            this.btnOnCallSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOnCallSave.Name = "btnOnCallSave";
            this.btnOnCallSave.Size = new System.Drawing.Size(28, 25);
            this.btnOnCallSave.TabIndex = 22;
            this.btnOnCallSave.Click += new System.EventHandler(this.btnOnCallSave_Click);
            // 
            // ucNextSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOnCallSave);
            this.Controls.Add(this.dtNextCalldate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.cmbNextCalltime);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.818182F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucNextSchedule";
            this.Size = new System.Drawing.Size(476, 47);
            this.Load += new System.EventHandler(this.ucNextSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNextCalldate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOnCallSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cmbNextCalltime;
        private Telerik.WinControls.UI.RadDateTimePicker dtNextCalldate;
        private Telerik.WinControls.UI.RadButton btnOnCallSave;
    }
}
