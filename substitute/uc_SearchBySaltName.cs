using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.Substitute
{
    public partial class uc_SearchBySaltName : UserControl
    {
        string _Salt_Id = string.Empty; string _result = string.Empty;
        public uc_SearchBySaltName()
        {
            InitializeComponent();
        }
        protected void Fill_SaltName(string logic,string Search)
        {
            pm_SaltInfo p = new pm_SaltInfo();
            p.logic = logic;p.prm_1 = Search;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
            var data = dwr.result.Tables[0].AsEnumerable().
                    Select(o=>new {
                        salt_id = o.Field<string>("salt_code"),
                    salt_name=o.Field<string>("salt_name")
                    });
            
            lv_salt_name.Items.Clear();
            foreach (var r in data)
            {
                ListViewItem lvi = new ListViewItem(r.salt_id);
                lvi.SubItems.Add(r.salt_name);
                lv_salt_name.Items.Add(lvi);
            }

        }

        private void lv_salt_name_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _Salt_Id = e.Item.Text;
            gb_Products.Text = e.Item.SubItems[1].Text;
            Fill_Products(_Salt_Id);
        }
        protected void Fill_Products(string salt_id)
        {
            Cursor.Current = Cursors.WaitCursor;
            pm_SaltInfo p = new pm_SaltInfo();
            p.logic = "SaltInProducts"; p.prm_1 = salt_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
            var data = dwr.result.Tables[0].AsEnumerable().
                    Select(o => new
                    {
                        item_id = o.Field<string>("item_id"),
                        item_name = o.Field<string>("item_name"),
                        strength = o.Field<string>("strn_Info"),
                        mfd_name=o.Field<string>("mfd_name"),
                        npr=o.Field<decimal>("npr"),
                        mrp=o.Field<decimal>("mrp")
                    });

            lv_products.Items.Clear();
            foreach (var r in data)
            {
                ListViewItem lvi = new ListViewItem(r.item_id);
                lvi.SubItems.Add(r.item_name);
                lvi.SubItems.Add(r.strength);
                lvi.SubItems.Add(r.mfd_name);
                lvi.SubItems.Add(r.mrp.ToString("####.00"));
                lvi.SubItems.Add(r.npr.ToString("####.00"));
                //if (_result != "DarkGray")
                //{ lvi.BackColor = Color.DarkGray; _result = "DarkGray"; lvi.ForeColor = Color.White; }
                //else
                //{ lvi.BackColor = Color.LightYellow; _result = "LightYellow"; }

                lv_products.Items.Add(lvi);
            }
            Cursor.Current = Cursors.Default;
        }
        private void uc_SearchBySaltName_Load(object sender, EventArgs e)
        {
            Fill_SaltName("SaltList", "All");
        }

        private void txtSearchString_TextChanged(object sender, EventArgs e)
        {
            Fill_SaltName("SaltSearchList", txtSearchString.Text);
        }

        private void lv_products_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            gb_ProductInfo.Text=e.Item.SubItems[1].Text;
            Fill_ProductInfo(e.Item.Text);
        }
        protected void Fill_ProductInfo(string item_id)
        {
            pm_SaltInfo p = new pm_SaltInfo();
            p.logic = "SaltInProduct"; p.prm_1 = item_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);

            var data = dwr.result.Tables[0].AsEnumerable().
                    Select(o => new
                    {
                        salt_id = o.Field<string>("salt_code"),
                        salt_name = o.Field<string>("salt_name"),
                        strength = o.Field<string>("strn_Info"),

                    });

            lv_product_info.Items.Clear();
            foreach (var r in data)
            {
                ListViewItem lvi = new ListViewItem(r.salt_name);
                lvi.SubItems.Add(r.strength);
                if (_result != "DarkGray")
                { lvi.BackColor = Color.DarkGray; _result = "DarkGray"; lvi.ForeColor = Color.White; }
                else
                { lvi.BackColor = Color.LightYellow; _result = "LightYellow"; }

                lv_product_info.Items.Add(lvi);
            }

        }
    }
}
