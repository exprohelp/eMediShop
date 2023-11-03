using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
    public partial class ReplaceProductPopUp : Form
    {
        string _item_name = string.Empty;
        string _result = string.Empty;
        public event SearchUpdateEventHandler SearchUpdated;
        public ReplaceProductPopUp(string item_name)
        {
            _item_name = item_name;
            InitializeComponent();
        }
        protected void FillSearchedProduct(string searchKey)
        {
            lv_FindProducts.Items.Clear();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "Search:InProduct"; p.prm_1 = searchKey;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
            DataSet ds = dwr.result;
            
            #region Filling List View New Product
            btnUpdate.Enabled = false;
            chkConfirm.Checked = false;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["item_id"].ToString());
                lvi.SubItems.Add(dr["item_name"].ToString());
                lv_FindProducts.Items.Add(lvi);
            }
            #endregion
        }
        private void txtSearchString_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchString.Text.Length > 0)
            {
                FillSearchedProduct(txtSearchString.Text);
            }
        }
        private void CGHS_SwapProduct_Load(object sender, EventArgs e)
        {
            gb_FindProd.Text = _item_name;
            txtSearchString.Text = _item_name.Substring(0, 5);
            FillSearchedProduct(txtSearchString.Text);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SearchUpdatedEventArgs ValuArgs = new SearchUpdatedEventArgs(lblItemId.Text);
            SearchUpdated(this, ValuArgs);
            this.Close();
        }
        private void lv_FindProducts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lblItemId.Text = e.Item.Text;
            lblItem.Text = e.Item.SubItems[1].Text;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirm.Checked)
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }
    }
}
