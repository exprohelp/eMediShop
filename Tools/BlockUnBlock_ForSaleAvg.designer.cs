namespace eMediShop.Tools
{
    partial class BlockUnBlock_ForSaleAvg
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.GroupDescriptor groupDescriptor1 = new Telerik.WinControls.Data.GroupDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.btnGo = new Telerik.WinControls.UI.RadButton();
            this.dgList = new Telerik.WinControls.UI.RadGridView();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.ddProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.btn_xl = new Telerik.WinControls.UI.RadButton();
            this.btnLoad = new Telerik.WinControls.UI.RadButton();
            this.dgBlocked = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_xl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBlocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBlocked.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Location = new System.Drawing.Point(1, 5);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(958, 488);
            this.radPageView1.TabIndex = 0;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.btnGo);
            this.radPageViewPage1.Controls.Add(this.dgList);
            this.radPageViewPage1.Controls.Add(this.txtSearch);
            this.radPageViewPage1.Controls.Add(this.ddProduct);
            this.radPageViewPage1.Controls.Add(this.btnSearch);
            this.radPageViewPage1.Controls.Add(this.label2);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(88F, 28F);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(937, 440);
            this.radPageViewPage1.Text = "Block/UnBlock ";
            // 
            // btnGo
            // 
            this.btnGo.Image = global::eMediShop.Properties.Resources.Next;
            this.btnGo.Location = new System.Drawing.Point(546, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(24, 22);
            this.btnGo.TabIndex = 98;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dgList
            // 
            this.dgList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.dgList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgList.ForeColor = System.Drawing.Color.Black;
            this.dgList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgList.Location = new System.Drawing.Point(4, 32);
            // 
            // 
            // 
            this.dgList.MasterTemplate.AllowAddNewRow = false;
            this.dgList.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "item_id";
            gridViewTextBoxColumn1.HeaderText = "column1";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "item_id";
            gridViewTextBoxColumn1.Width = 5;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "unit_id";
            gridViewTextBoxColumn2.HeaderText = "Unit Code";
            gridViewTextBoxColumn2.Name = "sh_code";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "sh_name";
            gridViewTextBoxColumn3.HeaderText = "Shop Name";
            gridViewTextBoxColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "sh_name";
            gridViewTextBoxColumn3.Width = 350;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.FieldName = "com_type";
            gridViewCommandColumn1.HeaderText = "Command";
            gridViewCommandColumn1.Name = "com_type";
            gridViewCommandColumn1.Width = 60;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "purch_flag";
            gridViewTextBoxColumn4.HeaderText = "column1";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "purch_flag";
            this.dgList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1,
            gridViewTextBoxColumn4});
            this.dgList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgList.ShowGroupPanel = false;
            this.dgList.Size = new System.Drawing.Size(566, 372);
            this.dgList.TabIndex = 97;
            this.dgList.Text = "radGridView1";
            this.dgList.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.dgList_RowFormatting);
            this.dgList.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.dgList_ViewCellFormatting);
            this.dgList.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgList_CommandCellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(98, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(83, 23);
            this.txtSearch.TabIndex = 96;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSearch.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txtSearch.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // ddProduct
            // 
            this.ddProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddProduct.Location = new System.Drawing.Point(215, 3);
            this.ddProduct.Name = "ddProduct";
            this.ddProduct.Size = new System.Drawing.Size(321, 23);
            this.ddProduct.TabIndex = 95;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::eMediShop.Properties.Resources.search_16;
            this.btnSearch.Location = new System.Drawing.Point(187, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 22);
            this.btnSearch.TabIndex = 94;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Search Product";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.btn_xl);
            this.radPageViewPage2.Controls.Add(this.btnLoad);
            this.radPageViewPage2.Controls.Add(this.dgBlocked);
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(75F, 28F);
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(937, 440);
            this.radPageViewPage2.Text = "Blocked List";
            // 
            // btn_xl
            // 
            this.btn_xl.Image = global::eMediShop.Properties.Resources.export_excel;
            this.btn_xl.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xl.Location = new System.Drawing.Point(526, 1);
            this.btn_xl.Name = "btn_xl";
            this.btn_xl.Size = new System.Drawing.Size(41, 37);
            this.btn_xl.TabIndex = 100;
            this.btn_xl.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xl.Click += new System.EventHandler(this.btn_xl_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::eMediShop.Properties.Resources.replace_16;
            this.btnLoad.Location = new System.Drawing.Point(7, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 28);
            this.btnLoad.TabIndex = 99;
            this.btnLoad.Text = "Load Blocked List";
            this.btnLoad.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgBlocked
            // 
            this.dgBlocked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.dgBlocked.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgBlocked.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgBlocked.ForeColor = System.Drawing.Color.Black;
            this.dgBlocked.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgBlocked.Location = new System.Drawing.Point(4, 39);
            // 
            // 
            // 
            this.dgBlocked.MasterTemplate.AllowAddNewRow = false;
            this.dgBlocked.MasterTemplate.AllowEditRow = false;
            this.dgBlocked.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "sh_name";
            gridViewTextBoxColumn5.HeaderText = "Shop Name";
            gridViewTextBoxColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "sh_name";
            gridViewTextBoxColumn5.Width = 340;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "item_name";
            gridViewTextBoxColumn6.HeaderText = "Product Name";
            gridViewTextBoxColumn6.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "item_name";
            gridViewTextBoxColumn6.Width = 250;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "act_date";
            gridViewTextBoxColumn7.HeaderText = "Block Date";
            gridViewTextBoxColumn7.Name = "act_date";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "login_name";
            gridViewTextBoxColumn8.HeaderText = "Block By";
            gridViewTextBoxColumn8.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn8.Name = "login_name";
            gridViewTextBoxColumn8.Width = 150;
            this.dgBlocked.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.dgBlocked.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "sh_name";
            groupDescriptor1.GroupNames.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgBlocked.MasterTemplate.GroupDescriptors.AddRange(new Telerik.WinControls.Data.GroupDescriptor[] {
            groupDescriptor1});
            this.dgBlocked.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgBlocked.Name = "dgBlocked";
            this.dgBlocked.ReadOnly = true;
            this.dgBlocked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgBlocked.ShowGroupPanel = false;
            this.dgBlocked.Size = new System.Drawing.Size(930, 371);
            this.dgBlocked.TabIndex = 98;
            this.dgBlocked.Text = "radGridView1";
            // 
            // BlockUnBlock_ForSaleAvg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 457);
            this.Controls.Add(this.radPageView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BlockUnBlock_ForSaleAvg";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Inclusion/exclusion form unit sales average (Products)";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.BlockUnBlock_ForSaleAvg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.radPageViewPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_xl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBlocked.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBlocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadGridView dgList;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadDropDownList ddProduct;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnGo;
        private Telerik.WinControls.UI.RadGridView dgBlocked;
        private Telerik.WinControls.UI.RadButton btnLoad;
        private Telerik.WinControls.UI.RadButton btn_xl;
    }
}
