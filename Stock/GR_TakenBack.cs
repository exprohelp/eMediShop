using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.forms.Stock
{
    public partial class GR_TakenBack : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; decimal _amount = 0;
        DataSet _ds = new DataSet(); int _oldQty = 0;
        public GR_TakenBack()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GR:TakenBack"; p.prm_1 = rtb_grno.Text; p.prm_2 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                _ds = dwr.result;
                _amount = 0;
                foreach (DataRow dr in _ds.Tables[0].Rows)
                {
                    GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.rgv_info.MasterView);
                    rowInfo.Cells["item_id"].Value = dr["item_id"].ToString();
                    rowInfo.Cells["master_key_id"].Value = dr["master_key_id"].ToString();
                    rowInfo.Cells["item_name"].Value = dr["item_name"].ToString();
                    rowInfo.Cells["pack_type"].Value = dr["pack_type"].ToString();
                    rowInfo.Cells["pack_qty"].Value = Convert.ToDecimal(dr["pack_qty"]).ToString("#####0");
                    rowInfo.Cells["batch_no"].Value = dr["batch_no"].ToString();
                    rowInfo.Cells["exp_date"].Value = Convert.ToDateTime(dr["exp_date"]);
                    rowInfo.Cells["qty"].Value = Convert.ToDecimal(dr["qty"]).ToString("#####0");
                    rowInfo.Cells["amt"].Value = Convert.ToDecimal(dr["amt"]).ToString("#####.00");
                    rowInfo.Cells["RetQty"].Value = Convert.ToDecimal(dr["qty"]).ToString("#####0");

                    rgv_info.Rows.Add(rowInfo);
                    _amount = _amount + Convert.ToDecimal(dr["amt"]);
                }
                rtbAmount.Text = _amount.ToString("#####.00");
                rgv_takenBack.DataSource = _ds.Tables[1];
                if (_ds.Tables[1].Rows.Count > 0)
                    rtb_trfid.Text = _ds.Tables[1].Rows[0]["trf_id"].ToString();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_RowFormatting(object sender, RowFormattingEventArgs e)
        {

        }

        private void MasterTemplate_CellClick(object sender, GridViewCellEventArgs e)
        {

        }

        private void MasterTemplate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnTransfer.Enabled = false;
                pm_PurchaseReturn p = new pm_PurchaseReturn();
                p.unit_id = GlobalUsage.Unit_id; p.gr_no = rtb_grno.Text; p.trf_id = rtb_trfid.Text; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/GR_TakenBackAsExtraComplete", p);
                _result = dwr.message;
                RadMessageBox.Show("Result : " + _result, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                if (_result.Length == 16)
                { rgv_info.DataSource = new string[] { }; rgv_takenBack.DataSource = new string[] { }; rtb_grno.Text = ""; rtb_trfid.Text = "New"; }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            _oldQty = Convert.ToInt32(e.Row.Cells["RetQty"].Value);
        }

        private void rgv_info_CellEndEdit(object sender, GridViewCellEventArgs e)
        {

        }

        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            string trfid = string.Empty;
            string itemid = string.Empty;
            string masterkeyid = string.Empty;
            int qty = 0;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                trfid = rtb_trfid.Text;
                itemid = e.Row.Cells["item_id"].Value.ToString();
                masterkeyid = e.Row.Cells["master_key_id"].Value.ToString();
                qty = Convert.ToInt16(e.Row.Cells["RetQty"].Value);

                pm_PurchaseReturn p = new pm_PurchaseReturn();
                p.unit_id = GlobalUsage.Unit_id;p.gr_no = rtb_grno.Text;p.trf_id = trfid;p.item_id = itemid;
                p.master_key_id = masterkeyid;p.qty = qty;p.logic = "Insert";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/GR_TakenBackAsExtra", p);

                _ds = dwr.result;
                rgv_takenBack.DataSource = _ds.Tables[0];
                if (_ds.Tables[0].Rows.Count > 0)
                    rtb_trfid.Text = _ds.Tables[0].Rows[0]["trf_id"].ToString();

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rgv_takenBack_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            string trfid = string.Empty;
            string itemid = string.Empty;
            string masterkeyid = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                trfid = rtb_trfid.Text;
                itemid = e.Row.Cells["item_id"].Value.ToString();
                masterkeyid = e.Row.Cells["master_key_id"].Value.ToString();
                pm_PurchaseReturn p = new pm_PurchaseReturn();
                p.unit_id = GlobalUsage.Unit_id; p.gr_no = rtb_grno.Text; p.trf_id = trfid; p.item_id = itemid;
                p.master_key_id = masterkeyid; p.qty = 0; p.logic = "Delete"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/GR_TakenBackAsExtra", p);

                _ds = dwr.result; 
                e.Row.Delete();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void GR_TakenBack_Load(object sender, EventArgs e)
        {

        }
    }
}
