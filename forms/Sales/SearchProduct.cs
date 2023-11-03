using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
namespace eMediShop
{
    public partial class SearchProduct : UserControl
    {
        Pharmacy_Services ps = new Pharmacy_Services();
        public SearchProduct()
        {
            InitializeComponent();
            lv_Searched.Columns.Add("Item_id", 0);
            lv_Searched.Columns.Add("Name of Product", 200, HorizontalAlignment.Left);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            string Qry = "execute pProductHelp '" + txtSearch.Text + "','" + GlobalUsage.Unit_id + "'";
            DataSet ds = new DataSet();
            ds = ps.GetQueryResult(Qry, "eMediShop");
            lv_Searched.Items.Clear();
            lv_Searched.Refresh();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lv_Searched.Size = new System.Drawing.Size(247, 100);
                lv_Searched.Visible = true;
            }
            else {
                lv_Searched.Size= new System.Drawing.Size(247,0);
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
    }
}
