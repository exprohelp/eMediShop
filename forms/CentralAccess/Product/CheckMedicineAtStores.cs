using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExPro.Server;
using ExPro.Client;
using eMediShop.Pharmacy;
using Telerik.WinControls;

namespace eMediShop
{

    public partial class CheckMedicineAtStores : Telerik.WinControls.UI.RadForm
    {
        string pItem_id = string.Empty;
        string _result = string.Empty;
        Pharmacy_Services ps = new Pharmacy_Services();
        private delegate void dlg_stock_update(ProgressBar pb);
        public CheckMedicineAtStores()
        {
            InitializeComponent();
            lv_Searched.Columns.Add("Item_id", 0);
            lv_Searched.Columns.Add("Name of Product", 240, HorizontalAlignment.Left);
            lv_Searched.Size = new System.Drawing.Size(264, 0);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 3)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    ListViewItem lvi;
                    ListViewItem.ListViewSubItem lvsi;
                    DataSet ds = new DataSet();
                    Search p = new Search();
                    p.SearchKey = txtSearch.Text;p.Logic = "SearchItems"; p.unit_id = GlobalUsage.Unit_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductHelp", p);

                    ds = dwr.result;
                    lv_Searched.Items.Clear();
                    lv_Searched.Refresh();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lv_Searched.Size = new System.Drawing.Size(264, 300);
                        lv_Searched.Visible = true;
                    }
                    else
                    {
                        lv_Searched.Size = new System.Drawing.Size(264, 0);
                        lv_Searched.Visible = false;
                    }
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lvi = lv_Searched.Items.Add(dr["item_id"].ToString(), 0);
                        lvsi = new ListViewItem.ListViewSubItem();
                        lvsi.Text = dr["Item_name"].ToString();
                        lvi.SubItems.Add(lvsi);
                    }
                    ds.Dispose();
                    ds.Clear();


                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    lv_Searched.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help");
            }

        }

        private void lv_Searched_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_Search.Focus();
                this.txtSearch.TextChanged -= new System.EventHandler(this.txtSearch_TextChanged);

                txtSearch.Text = lv_Searched.FocusedItem.SubItems[1].Text;
                pItem_id = lv_Searched.FocusedItem.SubItems[0].Text;
                lv_Searched.Visible = false;
                this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            }
        }

        private void lv_Searched_Enter(object sender, EventArgs e)
        {
            lv_Searched.Items[0].Selected = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                #region Process of Checking
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                string item_id = pItem_id;
                pm_Stocks p = new pm_Stocks();
                p.unit_id = GlobalUsage.Unit_id;p.item_id = item_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockAtOtherStores", p);
                ds = dwr.result;
                lv_AtStore.Items.Clear();
                lv_AtStore.Refresh();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ListViewItem listItem = new ListViewItem(dr["sh_name"].ToString());
                        // Add sub-items for Details view.
                        listItem.SubItems.Add(dr["stock"].ToString());
                        lv_AtStore.Items.Add(listItem);
                    }
                    ds.Dispose();
                    ds.Clear();
                }
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Try again ", "Product Search in Other Store");
            }
            finally { 
            Cursor.Current = Cursors.Default;
            }
        }

        private void CheckMedicineAtStores_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }
    }
}
