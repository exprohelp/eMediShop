namespace eMediShop.Stock
{
    partial class ExtraStockProcess
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnView = new Telerik.WinControls.UI.RadButton();
            this.btn_submit = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rddl_unitname = new Telerik.WinControls.UI.RadDropDownList();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rgvInfo = new Telerik.WinControls.UI.RadGridView();
            this.btnProcess = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_submit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_unitname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnView);
            this.radGroupBox1.Controls.Add(this.btn_submit);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.rddl_unitname);
            this.radGroupBox1.Controls.Add(this.rbSales);
            this.radGroupBox1.Controls.Add(this.rbTransfer);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(-1, 1);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1041, 45);
            this.radGroupBox1.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(845, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(74, 27);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(749, 8);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(74, 27);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Check";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name of Unit";
            // 
            // rddl_unitname
            // 
            this.rddl_unitname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddl_unitname.Location = new System.Drawing.Point(303, 6);
            this.rddl_unitname.Name = "rddl_unitname";
            this.rddl_unitname.Size = new System.Drawing.Size(431, 31);
            this.rddl_unitname.TabIndex = 2;
            this.rddl_unitname.Text = "Select";
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSales.Location = new System.Drawing.Point(99, 9);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(55, 24);
            this.rbSales.TabIndex = 1;
            this.rbSales.Text = "Sale";
            this.rbSales.UseVisualStyleBackColor = true;
            this.rbSales.Visible = false;
            this.rbSales.CheckedChanged += new System.EventHandler(this.rbSales_CheckedChanged);
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTransfer.Location = new System.Drawing.Point(14, 9);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(85, 24);
            this.rbTransfer.TabIndex = 0;
            this.rbTransfer.Text = "Transfer";
            this.rbTransfer.UseVisualStyleBackColor = true;
            this.rbTransfer.CheckedChanged += new System.EventHandler(this.rbTransfer_CheckedChanged);
            // 
            // rgvInfo
            // 
            this.rgvInfo.Location = new System.Drawing.Point(-1, 53);
            // 
            // 
            // 
            this.rgvInfo.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvInfo.Name = "rgvInfo";
            this.rgvInfo.Size = new System.Drawing.Size(675, 493);
            this.rgvInfo.TabIndex = 1;
            this.rgvInfo.Text = "radGridView1";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(795, 91);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(114, 94);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ExtraStockProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 544);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.rgvInfo);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExtraStockProcess";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra Stock Management";
            this.Load += new System.EventHandler(this.ExtraStockProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_submit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rddl_unitname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDropDownList rddl_unitname;
        private Telerik.WinControls.UI.RadButton btn_submit;
        private Telerik.WinControls.UI.RadGridView rgvInfo;
        private Telerik.WinControls.UI.RadButton btnView;
        private Telerik.WinControls.UI.RadButton btnProcess;
    }
}