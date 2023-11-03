namespace eMediShop.Hospital
{
    partial class SalesRefByDoctor
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnReport = new Telerik.WinControls.UI.RadButton();
            this.dtFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnXl = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnXl);
            this.radGroupBox1.Controls.Add(this.btnReport);
            this.radGroupBox1.Controls.Add(this.dtFrom);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.dtTo);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1045, 48);
            this.radGroupBox1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(311, 7);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(73, 35);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Submit";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(61, 12);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(93, 23);
            this.dtFrom.TabIndex = 8;
            this.dtFrom.TabStop = false;
            this.dtFrom.Text = "09/10/2018";
            this.dtFrom.Value = new System.DateTime(2018, 10, 9, 13, 58, 51, 78);
            this.dtFrom.Leave += new System.EventHandler(this.dtFrom_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(200, 12);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(93, 23);
            this.dtTo.TabIndex = 9;
            this.dtTo.TabStop = false;
            this.dtTo.Text = "09/10/2018";
            this.dtTo.Value = new System.DateTime(2018, 10, 9, 13, 58, 51, 78);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "From";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1045, 483);
            this.webBrowser1.TabIndex = 13;
            // 
            // btnXl
            // 
            this.btnXl.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btnXl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXl.Location = new System.Drawing.Point(994, 7);
            this.btnXl.Name = "btnXl";
            this.btnXl.Size = new System.Drawing.Size(46, 35);
            this.btnXl.TabIndex = 13;
            this.btnXl.Click += new System.EventHandler(this.btnXl_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(787, 274);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(240, 150);
            this.radGridView1.TabIndex = 14;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.Visible = false;
            // 
            // SalesRefByDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 531);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SalesRefByDoctor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Sales By Doctor";
            this.Load += new System.EventHandler(this.SalesRefByDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnReport;
        private Telerik.WinControls.UI.RadDateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Telerik.WinControls.UI.RadButton btnXl;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}