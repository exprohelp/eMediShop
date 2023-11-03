using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;

namespace eMediShop.forms.Product
{
    public partial class ucProductByCompany : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty;
        public ucProductByCompany()
        {
            InitializeComponent();
        }

        private void ucChangeLocation_Load(object sender, EventArgs e)
        {

        }

        private void txtMfdName_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (txtMfdName.Text.Length > 0)
                {

                    Fill_mfdList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void Fill_mfdList()
        {
            lvMfdInfo.Items.Clear();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id;p.Logic = "Search_Mfd";
            p.prm_1 = txtMfdName.Text;p.prm_2 = "N/A";p.prm_3 = "N/A";p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/MfdQueries", p);
            _ds = dwr.result;
                var mfdQry = from o in _ds.Tables[0].AsEnumerable()
                         select new
                         {
                             mfd_id = o.Field<string>("mfd_id"),
                             mfd_name = o.Field<string>("mfd_name")
                         };
            foreach (var m in mfdQry)
            {
                ListViewItem lvi = new ListViewItem(m.mfd_id);
                lvi.SubItems.Add(m.mfd_name);
                lvMfdInfo.Items.Add(lvi);
            }
        }

        private void lvMfdInfo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblCompany.Text = "Company : " + e.Item.SubItems[1].Text;
            try
            {
                Fill_ProductInfo(e.Item.Text);
            }
            catch (Exception)
            {

                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void Fill_ProductInfo(string mfd_id)
        {

            lv_ProductInfo.Items.Clear();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "Mfd_Prod_List";
            p.prm_1 = mfd_id; p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/MfdQueries", p);

            _ds = dwr.result;
            var prodQry = from o in _ds.Tables[0].AsEnumerable()
                          select new
                          {
                              item_name = o.Field<string>("item_name"),
                              pack_type = o.Field<string>("pack_type"),
                              MedType = o.Field<string>("Category"),
                              StkQty = o.Field<decimal>("stkQty")
                          };
            foreach (var m in prodQry)
            {
                ListViewItem lvi = new ListViewItem(m.item_name);
                lvi.SubItems.Add(m.pack_type);
                lvi.SubItems.Add(m.MedType);
                lvi.SubItems.Add(m.StkQty.ToString("##0"));
                lv_ProductInfo.Items.Add(lvi);
            }
        }
    }
}
