namespace eMediShop
{
    partial class NewProductProcess
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
            this.rb_Process = new Telerik.WinControls.UI.RadButton();
            this.rb_export = new Telerik.WinControls.UI.RadButton();
            this.rb_close = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNo = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rb_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_Process
            // 
            this.rb_Process.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb_Process.Location = new System.Drawing.Point(4, 10);
            this.rb_Process.Name = "rb_Process";
            this.rb_Process.Size = new System.Drawing.Size(99, 38);
            this.rb_Process.TabIndex = 2;
            this.rb_Process.Text = "Check/Process";
            this.rb_Process.Click += new System.EventHandler(this.rb_Process_Click);
            // 
            // rb_export
            // 
            this.rb_export.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb_export.Image = global::eMediShop.Properties.Resources.EXCEL;
            this.rb_export.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_export.Location = new System.Drawing.Point(489, 393);
            this.rb_export.Name = "rb_export";
            this.rb_export.Size = new System.Drawing.Size(33, 27);
            this.rb_export.TabIndex = 3;
            this.rb_export.Click += new System.EventHandler(this.rb_export_Click);
            // 
            // rb_close
            // 
            this.rb_close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb_close.Location = new System.Drawing.Point(3, 393);
            this.rb_close.Name = "rb_close";
            this.rb_close.Size = new System.Drawing.Size(82, 27);
            this.rb_close.TabIndex = 4;
            this.rb_close.Text = "Close Order";
            this.rb_close.Click += new System.EventHandler(this.rb_close_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(4, 54);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(528, 333);
            this.radGridView1.TabIndex = 5;
            this.radGridView1.Text = "radGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order No";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Location = new System.Drawing.Point(314, 16);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.ReadOnly = true;
            this.txtOrderNo.Size = new System.Drawing.Size(208, 25);
            this.txtOrderNo.TabIndex = 7;
            this.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewProductProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.rb_close);
            this.Controls.Add(this.rb_export);
            this.Controls.Add(this.rb_Process);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "NewProductProcess";
            this.Size = new System.Drawing.Size(535, 423);
            this.Load += new System.EventHandler(this.NewProductProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rb_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton rb_Process;
        private Telerik.WinControls.UI.RadButton rb_export;
        private Telerik.WinControls.UI.RadButton rb_close;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtOrderNo;
    }
}