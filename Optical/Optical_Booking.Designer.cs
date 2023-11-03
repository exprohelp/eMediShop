namespace eMediShop.Optical
{
    partial class Optical_Booking
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.dgItemList = new Telerik.WinControls.UI.RadGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.dgProduct = new Telerik.WinControls.UI.RadGridView();
            this.btnPrint = new Telerik.WinControls.UI.RadButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 535);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAdvance);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNet);
            this.panel3.Controls.Add(this.dgItemList);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtMobile);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtPatientName);
            this.panel3.Controls.Add(this.dgProduct);
            this.panel3.Location = new System.Drawing.Point(375, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 535);
            this.panel3.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(631, 475);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(71, 28);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(524, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Advance";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdvance.Location = new System.Drawing.Point(524, 477);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(75, 25);
            this.txtAdvance.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(428, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Net Amount";
            // 
            // txtNet
            // 
            this.txtNet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNet.Location = new System.Drawing.Point(428, 477);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(75, 25);
            this.txtNet.TabIndex = 10;
            // 
            // dgItemList
            // 
            this.dgItemList.BackColor = System.Drawing.SystemColors.Control;
            this.dgItemList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgItemList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgItemList.ForeColor = System.Drawing.Color.Black;
            this.dgItemList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgItemList.Location = new System.Drawing.Point(428, 143);
            // 
            // 
            // 
            this.dgItemList.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Item_id";
            gridViewTextBoxColumn1.HeaderText = "Item_id";
            gridViewTextBoxColumn1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Item_id";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Item_name";
            gridViewTextBoxColumn2.HeaderText = "Item Name";
            gridViewTextBoxColumn2.Name = "Item_name";
            gridViewTextBoxColumn2.Width = 354;
            this.dgItemList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dgItemList.MasterTemplate.EnableFiltering = true;
            this.dgItemList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgItemList.Name = "dgItemList";
            this.dgItemList.ReadOnly = true;
            this.dgItemList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgItemList.ShowGroupPanel = false;
            this.dgItemList.Size = new System.Drawing.Size(396, 309);
            this.dgItemList.TabIndex = 9;
            this.dgItemList.Text = "radGridView1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(425, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(428, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(396, 25);
            this.txtAddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(720, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mobile Number";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMobile.Location = new System.Drawing.Point(717, 46);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(104, 25);
            this.txtMobile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(425, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPatientName.Location = new System.Drawing.Point(428, 46);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(283, 25);
            this.txtPatientName.TabIndex = 3;
            // 
            // dgProduct
            // 
            this.dgProduct.BackColor = System.Drawing.SystemColors.Control;
            this.dgProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgProduct.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgProduct.ForeColor = System.Drawing.Color.Black;
            this.dgProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgProduct.Location = new System.Drawing.Point(8, 9);
            // 
            // 
            // 
            this.dgProduct.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Item_id";
            gridViewTextBoxColumn3.HeaderText = "Item_id";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "Item_id";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Item_name";
            gridViewTextBoxColumn4.HeaderText = "Item Name";
            gridViewTextBoxColumn4.Name = "Item_name";
            gridViewTextBoxColumn4.Width = 354;
            this.dgProduct.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgProduct.MasterTemplate.EnableFiltering = true;
            this.dgProduct.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            this.dgProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgProduct.ShowGroupPanel = false;
            this.dgProduct.Size = new System.Drawing.Size(396, 520);
            this.dgProduct.TabIndex = 2;
            this.dgProduct.Text = "radGridView1";
            this.dgProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgProduct_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(753, 475);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(71, 28);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Optical_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Optical_Booking";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Optical Booking";
            this.Load += new System.EventHandler(this.Optical_Booking_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadGridView dgProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNet;
        private Telerik.WinControls.UI.RadGridView dgItemList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadButton btnPrint;
    }
}