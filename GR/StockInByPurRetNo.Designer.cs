namespace eMediShop.GR
{
    partial class StockInByPurRetNo
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGRNO = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.rgv_info = new Telerik.WinControls.UI.RadGridView();
            this.btn_Import = new Telerik.WinControls.UI.RadButton();
            this.btn_go = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGRNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Return ID";
            // 
            // txtGRNO
            // 
            this.txtGRNO.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRNO.Location = new System.Drawing.Point(6, 26);
            this.txtGRNO.MaxLength = 16;
            this.txtGRNO.Name = "txtGRNO";
            this.txtGRNO.NullText = "GR No";
            this.txtGRNO.Size = new System.Drawing.Size(225, 25);
            this.txtGRNO.TabIndex = 1;
            this.txtGRNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtGRNO.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtGRNO.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // rgv_info
            // 
            this.rgv_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgv_info.Location = new System.Drawing.Point(0, 57);
            // 
            // 
            // 
            this.rgv_info.MasterTemplate.AllowAddNewRow = false;
            this.rgv_info.MasterTemplate.EnableGrouping = false;
            this.rgv_info.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgv_info.Name = "rgv_info";
            this.rgv_info.ReadOnly = true;
            this.rgv_info.Size = new System.Drawing.Size(800, 421);
            this.rgv_info.TabIndex = 2;
            this.rgv_info.Text = "radGridView1";
            // 
            // btn_Import
            // 
            this.btn_Import.Enabled = false;
            this.btn_Import.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Location = new System.Drawing.Point(730, 12);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(70, 39);
            this.btn_Import.TabIndex = 3;
            this.btn_Import.Text = "Import";
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go.Location = new System.Drawing.Point(237, 12);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(37, 39);
            this.btn_go.TabIndex = 4;
            this.btn_go.Text = ">>";
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // StockInByPurRetNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.rgv_info);
            this.Controls.Add(this.txtGRNO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StockInByPurRetNo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Take Stock In of Intercompany Purchase Return";
            this.Load += new System.EventHandler(this.StockInByPurRetNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGRNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtGRNO;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadGridView rgv_info;
        private Telerik.WinControls.UI.RadButton btn_Import;
        private Telerik.WinControls.UI.RadButton btn_go;
    }
}