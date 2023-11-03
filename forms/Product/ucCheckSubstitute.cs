using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.Product
{
    public partial class ucCheckSubstitute : UserControl
    {
        string _result = string.Empty;
        public ucCheckSubstitute()
        {
            InitializeComponent();
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            lv_Search.Items.Clear();
            if (txtProduct.Text.Length > 3)
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "Search:InProduct"; p.prm_1 =  txtProduct.Text;
                p.prm_2 = DateTime.Today.ToString("yyyyMMdd"); p.prm_3 = DateTime.Today.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                if (dwr.result.Tables[0].Rows.Count > 0 && dwr.result.Tables.Count > 0)
                {
                    #region Filling Item Help Grid
                    foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["item_id"].ToString());
                        lvi.SubItems.Add(dr["item_name"].ToString());
                        lv_Search.Items.Add(lvi);
                    }
                    #endregion
                }
            }
            ds.Dispose();
            Cursor.Current = Cursors.Default;
        }

        private void lv_Search_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Salt_Info(lvs_Info,e.Item.Text);
            Cursor.Current = Cursors.Default;

        }

        private void Salt_Info(ListView lv,string item_id)
        {
            DataSet ds = new DataSet();
            lv.Items.Clear();
            ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pGetSubstitute '" + item_id + "','SaltInfo'", "eMediCentral");
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables.Count > 0)
            {
                #region Filling Item Help Grid
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem(dr["Salt_Name"].ToString());
                    lvi.SubItems.Add(dr["strength"].ToString());
                    lvi.SubItems.Add(dr["str_type"].ToString());
                    lv.Items.Add(lvi);
                }
                #endregion
            }
            ds.Dispose();

        }

        private void lv_Search_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            lv_Found.Items.Clear();
            lvf_info.Items.Clear();
            ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pGetSubstitute '" + lv_Search.Items[lv_Search.FocusedItem.Index].SubItems[0].Text+ "','Substitute'", "eMediCentral");
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables.Count > 0)
            {
                #region Filling Item Help Grid
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListViewItem lvi = new ListViewItem(dr["item_id"].ToString());
                    lvi.SubItems.Add(dr["item_name"].ToString());
                    lv_Found.Items.Add(lvi);
                }
                #endregion
            }
            ds.Dispose();
            Cursor.Current = Cursors.Default;
        }

        private void lv_Found_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Salt_Info(lvf_info, e.Item.Text);
            Cursor.Current = Cursors.Default;
        }

        
    }
}
