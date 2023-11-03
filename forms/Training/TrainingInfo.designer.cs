namespace eMediShop.forms.Training
{
    partial class TrainingInfo
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
            this.txtNewVersion = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentVer = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtDATE = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_trPoint = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlTrainedBy = new Telerik.WinControls.UI.RadDropDownList();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlRate = new System.Windows.Forms.Panel();
            this.txtrate = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new Telerik.WinControls.UI.RadTextBox();
            this.starShape1 = new Telerik.WinControls.UI.StarShape();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_trPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTrainedBy)).BeginInit();
            this.PnlRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewVersion
            // 
            this.txtNewVersion.Enabled = false;
            this.txtNewVersion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewVersion.Location = new System.Drawing.Point(159, 41);
            this.txtNewVersion.Name = "txtNewVersion";
            this.txtNewVersion.Size = new System.Drawing.Size(161, 25);
            this.txtNewVersion.TabIndex = 0;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNewVersion.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtNewVersion.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Software Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Software Version";
            // 
            // txtCurrentVer
            // 
            this.txtCurrentVer.Enabled = false;
            this.txtCurrentVer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentVer.Location = new System.Drawing.Point(159, 14);
            this.txtCurrentVer.Name = "txtCurrentVer";
            this.txtCurrentVer.Size = new System.Drawing.Size(161, 25);
            this.txtCurrentVer.TabIndex = 2;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtCurrentVer.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtCurrentVer.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtDATE);
            this.radGroupBox1.Controls.Add(this.label5);
            this.radGroupBox1.Controls.Add(this.txt_trPoint);
            this.radGroupBox1.Controls.Add(this.txtCurrentVer);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.txtNewVersion);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.HeaderText = "Training Detail";
            this.radGroupBox1.Location = new System.Drawing.Point(5, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(461, 209);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Training Detail";
            // 
            // txtDATE
            // 
            this.txtDATE.Enabled = false;
            this.txtDATE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDATE.Location = new System.Drawing.Point(159, 68);
            this.txtDATE.Name = "txtDATE";
            this.txtDATE.Size = new System.Drawing.Size(161, 25);
            this.txtDATE.TabIndex = 6;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtDATE.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtDATE.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Time";
            // 
            // txt_trPoint
            // 
            this.txt_trPoint.AutoSize = false;
            this.txt_trPoint.Enabled = false;
            this.txt_trPoint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trPoint.Location = new System.Drawing.Point(18, 101);
            this.txt_trPoint.Multiline = true;
            this.txt_trPoint.Name = "txt_trPoint";
            this.txt_trPoint.Size = new System.Drawing.Size(434, 97);
            this.txt_trPoint.TabIndex = 4;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txt_trPoint.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txt_trPoint.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.ddlTrainedBy);
            this.radGroupBox2.Controls.Add(this.label6);
            this.radGroupBox2.Controls.Add(this.PnlRate);
            this.radGroupBox2.Controls.Add(this.label4);
            this.radGroupBox2.Controls.Add(this.btnSubmit);
            this.radGroupBox2.Controls.Add(this.label3);
            this.radGroupBox2.Controls.Add(this.txtRemark);
            this.radGroupBox2.HeaderText = "Taking Acceptance";
            this.radGroupBox2.Location = new System.Drawing.Point(5, 217);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(461, 209);
            this.radGroupBox2.TabIndex = 5;
            this.radGroupBox2.Text = "Taking Acceptance";
            // 
            // ddlTrainedBy
            // 
            this.ddlTrainedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTrainedBy.Location = new System.Drawing.Point(141, 22);
            this.ddlTrainedBy.Name = "ddlTrainedBy";
            this.ddlTrainedBy.Size = new System.Drawing.Size(312, 23);
            this.ddlTrainedBy.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Remark/Suggestion";
            // 
            // PnlRate
            // 
            this.PnlRate.Controls.Add(this.txtrate);
            this.PnlRate.Location = new System.Drawing.Point(141, 53);
            this.PnlRate.Name = "PnlRate";
            this.PnlRate.Size = new System.Drawing.Size(312, 39);
            this.PnlRate.TabIndex = 10;
            // 
            // txtrate
            // 
            this.txtrate.Enabled = false;
            this.txtrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(166, 3);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(37, 27);
            this.txtrate.TabIndex = 0;
            this.txtrate.Text = "0";
            this.txtrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtrate.GetChildAt(0))).Text = "0";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtrate.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rate The Training ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(379, 169);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(71, 28);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trained By";
            // 
            // txtRemark
            // 
            this.txtRemark.AutoSize = false;
            this.txtRemark.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(141, 97);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(312, 63);
            this.txtRemark.TabIndex = 5;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtRemark.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtRemark.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // TrainingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 436);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Training Acceptance";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.TrainingInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_trPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTrainedBy)).EndInit();
            this.PnlRate.ResumeLayout(false);
            this.PnlRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtNewVersion;
        private Telerik.WinControls.UI.RadTextBox txtCurrentVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txt_trPoint;
        private Telerik.WinControls.UI.RadTextBox txtDATE;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadTextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PnlRate;
        private Telerik.WinControls.UI.RadTextBox txtrate;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.StarShape starShape1;
        private Telerik.WinControls.UI.RadDropDownList ddlTrainedBy;
    }
}
