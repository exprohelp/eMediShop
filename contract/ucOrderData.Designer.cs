namespace eMediShop.contract
{
    partial class ucOrderData
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgCriteria = new Telerik.WinControls.UI.RadGroupBox();
            this.rdtpFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdtpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            this.btnXL = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCriteria)).BeginInit();
            this.rgCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvInfo
            // 
            this.rgvInfo.Location = new System.Drawing.Point(4, 73);
            // 
            // 
            // 
            this.rgvInfo.MasterTemplate.AutoExpandGroups = true;
            this.rgvInfo.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.Size = new System.Drawing.Size(1004, 446);
            this.rgvInfo.TabIndex = 0;
            this.rgvInfo.Text = "radGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // rgCriteria
            // 
            this.rgCriteria.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgCriteria.Controls.Add(this.btnXL);
            this.rgCriteria.Controls.Add(this.btnGo);
            this.rgCriteria.Controls.Add(this.rdtpTo);
            this.rgCriteria.Controls.Add(this.rdtpFrom);
            this.rgCriteria.Controls.Add(this.label1);
            this.rgCriteria.Controls.Add(this.label2);
            this.rgCriteria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgCriteria.HeaderText = "";
            this.rgCriteria.Location = new System.Drawing.Point(7, 12);
            this.rgCriteria.Name = "rgCriteria";
            this.rgCriteria.Size = new System.Drawing.Size(998, 55);
            this.rgCriteria.TabIndex = 3;
            // 
            // rdtpFrom
            // 
            this.rdtpFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtpFrom.Location = new System.Drawing.Point(55, 13);
            this.rdtpFrom.Name = "rdtpFrom";
            this.rdtpFrom.Size = new System.Drawing.Size(107, 25);
            this.rdtpFrom.TabIndex = 3;
            this.rdtpFrom.TabStop = false;
            this.rdtpFrom.Text = "16-01-2024";
            this.rdtpFrom.Value = new System.DateTime(2024, 1, 16, 14, 10, 12, 459);
            this.rdtpFrom.Leave += new System.EventHandler(this.rdtpFrom_Leave);
            // 
            // rdtpTo
            // 
            this.rdtpTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtpTo.Location = new System.Drawing.Point(225, 13);
            this.rdtpTo.Name = "rdtpTo";
            this.rdtpTo.Size = new System.Drawing.Size(107, 25);
            this.rdtpTo.TabIndex = 4;
            this.rdtpTo.TabStop = false;
            this.rdtpTo.Text = "16-01-2024";
            this.rdtpTo.Value = new System.DateTime(2024, 1, 16, 14, 10, 12, 459);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(350, 14);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(41, 24);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = ">>";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnXL
            // 
            this.btnXL.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnXL.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXL.Location = new System.Drawing.Point(942, 8);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(48, 42);
            this.btnXL.TabIndex = 6;
            this.btnXL.Click += new System.EventHandler(this.btnXL_Click);
            // 
            // ucOrderData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgCriteria);
            this.Controls.Add(this.rgvInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucOrderData";
            this.Size = new System.Drawing.Size(1011, 522);
            this.Load += new System.EventHandler(this.ucOrderData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCriteria)).EndInit();
            this.rgCriteria.ResumeLayout(false);
            this.rgCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGroupBox rgCriteria;
        private Telerik.WinControls.UI.RadButton btnGo;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpTo;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpFrom;
        private Telerik.WinControls.UI.RadButton btnXL;
    }
}
