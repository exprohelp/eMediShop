using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.Stock
{
    public partial class ucGR_Report : UserControl
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty;
        string _TrfType = string.Empty;
        string _TrfId = string.Empty;
        public ucGR_Report(string TrfType)
        {
            _TrfType = TrfType;
            InitializeComponent();
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lv_info.Items.Clear();
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GR:LP-EXPIRY"; p.prm_2 = _TrfType;
                p.dtFrom = dtFrom.Value.ToString("yyyyMMdd"); p.dtTo = dtTo.Value.ToString("yyyyMMdd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);

                DataSet ds = dwr.result;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["trf_id"].ToString());
                        lvi.SubItems.Add(dr["no_of_item"].ToString());
                        lvi.SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("###.00"));
                        lv_info.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }
        private void FillGrInfo()
        {
            lvProductInfo.Items.Clear();
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "GR:ID-DETAIL";p.prm_1 = _TrfId; p.prm_2 = _TrfType;
            p.dtFrom = dtFrom.Value.ToString("yyyyMMdd"); p.dtTo = dtTo.Value.ToString("yyyyMMdd");
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);

            _ds = dwr.result;
            if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
            {
                string temp = "";
                foreach (DataRow dr in _ds.Tables[0].Rows)
                {
                    if (temp != dr["ld_name"].ToString())
                    {
                        temp = dr["ld_name"].ToString();
                        lvProductInfo.Groups.Add(temp, temp);
                    }
                    ListViewItem lvi = new ListViewItem(dr["item_name"].ToString());
                    lvi.SubItems.Add(dr["master_key_id"].ToString());
                    lvi.SubItems.Add(dr["batch_no"].ToString());
                    if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") != "1900-01-01")
                        lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MMM-yyyy"));
                    else
                        lvi.SubItems.Add("-");
                    lvi.SubItems.Add(dr["pack_type"].ToString());
                    lvi.SubItems.Add(dr["pack_qty"].ToString());
                    lvi.SubItems.Add(dr["quantity"].ToString());
                    lvi.Group = lvProductInfo.Groups[temp];
                    lvProductInfo.Items.Add(lvi);
                }
            }
        }
        private void ucExpiryReconcile_Load(object sender, EventArgs e)
        {

        }

        private void lv_info_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _TrfId = e.Item.Text;
            Cursor.Current = Cursors.WaitCursor;
            FillGrInfo();
            Cursor.Current = Cursors.Default;
        }

        private void btnInternalSheet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Is Your Printer Ready? ", "GR Info Sheet", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "EGR:LocalExpirySheet"; p.prm_1 = _TrfId; p.prm_2 = "N/A";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                    _ds = dwr.result;
                    Printing.Laser.LocalExpirySheet(_ds.Tables[0], _TrfId);
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
