using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.Stock
{
    public partial class ucPurchaseReturnSlip : UserControl
    {
        string _result = string.Empty; DataSet _ds = new DataSet(); DataSet _dsInfo = new DataSet();
        string _grNumber = string.Empty;
        public ucPurchaseReturnSlip()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnGo.Enabled = false;
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "PR:GR Numbers"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
            p.dtFrom = dtFrom.Value.ToString("yyyy/MM/dd");p.dtTo = dtTo.Value.ToString("yyyy/MM/dd");
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);


            _ds = dwr.result;
            Fill_GR_No(_ds.Tables[0]);
            btnGo.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        protected void Fill_GR_No(DataTable dt)
        {
            lv_GRno.Items.Clear();
            string grp = string.Empty;
            string temp = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                grp = dr["trf_id"].ToString() + " : " + dr["dt"].ToString();
                if (temp != grp)
                {
                    temp = dr["trf_id"].ToString();
                    lv_GRno.Groups.Add(grp, grp);
                }
                ListViewItem lvi = new ListViewItem(dr["gr_no"].ToString());
                lvi.SubItems.Add(dr["gr_no"].ToString());
                lvi.Group = lv_GRno.Groups[grp];

                lv_GRno.Items.Add(lvi);
            }
        }

        private void lv_GRno_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _grNumber = e.Item.Text;
            lv_Info.Items.Clear();
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "PR:GR slip"; p.prm_1 = e.Item.Text; p.prm_2 = "N/A";
            p.dtFrom = dtFrom.Value.ToString("yyyy/MM/dd"); p.dtTo = dtTo.Value.ToString("yyyy/MM/dd");
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);

            _dsInfo = dwr.result;

            if (_dsInfo.Tables.Count > 0)
            {
                lblTinNo.Text = "Tin No.:" + _dsInfo.Tables[0].Rows[0]["gst_no"].ToString();
                lblVendorName.Text = "Vendor :" + _dsInfo.Tables[0].Rows[0]["vendor_name"].ToString();
                lblAddress.Text = "Address:" + _dsInfo.Tables[0].Rows[0]["vend_Address"].ToString();

                Fill_GR_Info(_dsInfo.Tables[1]);
            }
            Cursor.Current = Cursors.Default;
        }

        protected void Fill_GR_Info(DataTable dt)
        {
            //    ti.gr_no,im.item_id,mki.master_key_id,im.item_name,mki.batch_no,mki.exp_date,mki.npr,mki.ptr,
            //mki.pack_type,mki.pack_qty,mki.mrp,pack, ti.purch_info
            lv_Info.Items.Clear();
            string temp = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["gr_no"].ToString());
                lvi.SubItems.Add(dr["item_id"].ToString());
                lvi.SubItems.Add(dr["item_name"].ToString());
                lvi.SubItems.Add(dr["batch_no"].ToString());
                if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") != "01-01-1900")
                    lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                else
                    lvi.SubItems.Add("-");
                lvi.SubItems.Add(dr["pack_type"].ToString());
                lvi.SubItems.Add(Convert.ToDecimal(dr["ptr"]).ToString("####.00"));
                lvi.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("####.00"));
                lvi.SubItems.Add(Convert.ToDecimal(dr["pack"]).ToString("####"));
                lvi.SubItems.Add(dr["purch_info"].ToString());
                lv_Info.Items.Add(lvi);
            }
        }

        private void btnSlipPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Is Your Printer Ready? ", "Purchase Return Slip", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnSlipPrint.Enabled = false;
                Printing.Laser.Gr_Slip(_dsInfo.Tables[1], _grNumber, _dsInfo.Tables[0].Rows[0]["gr_date"].ToString(), _dsInfo.Tables[0].Rows[0]["gst_no"].ToString(), _dsInfo.Tables[0].Rows[0]["vendor_name"].ToString(), _dsInfo.Tables[0].Rows[0]["vend_Address"].ToString(), _dsInfo.Tables[0].Rows[0]["compGSTNO"].ToString());
                btnSlipPrint.Enabled = true;
            }
        }
    }
}
