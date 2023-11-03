using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.Utility
{
    public partial class SwapProduct : Telerik.WinControls.UI.RadForm
    {
        string item_name = string.Empty;
        string Item_id = string.Empty;
        string Logic = string.Empty;
        int auto_id = 0;
        string _date = string.Empty;
        string _result = string.Empty;
        public event SearchCashMemoEventHandler SearchUpdated;
        public SwapProduct(string itemmname, int autoid, string item_id, string logic, string date)
        {
            auto_id = autoid;
            item_name = itemmname;
            Item_id = item_id;
            Logic = logic;
            _date = date;
            InitializeComponent();
        }
        protected void FillSearchedProduct(string searchKey)
        {
            lv_FindProducts.Items.Clear();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "Search:InProduct"; p.prm_1 = searchKey; p.prm_2 = "N/A"; p.prm_3 = "N/A";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
            #region Filling List View New Product
            foreach (DataRow dr in dwr.result.Tables[0].Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["item_id"].ToString());
                lvi.SubItems.Add(dr["item_name"].ToString());
                lv_FindProducts.Items.Add(lvi);
            }
            #endregion
        }
        private void txtSearchString_TextChanged(object sender, EventArgs e)
        {
            FillSearchedProduct(txtSearchString.Text);
        }
        private void CGHS_SwapProduct_Load(object sender, EventArgs e)
        {
            gb_FindProd.Text = item_name;
            txtSearchString.Text = item_name.Substring(0, 5);
            // FillSearchedProduct(txtSearchString.Text);
        }
        private void lv_FindProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (MessageBox.Show("do You confirm to Replace", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        if (Logic == "OnLineOrder")
                        {
                            string Ids = Item_id + "|" + lv_FindProducts.FocusedItem.Text + "|" + lv_FindProducts.Items[lv_FindProducts.FocusedItem.Index].SubItems[1].Text;
                            CashMemeoNoUpdatedEventArgs ValuArgs = new CashMemeoNoUpdatedEventArgs(Ids);
                            SearchUpdated(this, ValuArgs);
                            this.Close();
                        }
                        else if (Logic == "Indent")
                        {
                            string Ids = Item_id + "|" + lv_FindProducts.FocusedItem.Text + "|" + lv_FindProducts.Items[lv_FindProducts.FocusedItem.Index].SubItems[1].Text;
                            CashMemeoNoUpdatedEventArgs ValuArgs = new CashMemeoNoUpdatedEventArgs(Ids);
                            SearchUpdated(this, ValuArgs);
                            this.Close();
                        }

                        Cursor.Current = Cursors.Default;

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
    }
}
