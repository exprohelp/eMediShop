using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;
using System.IO;
using Telerik.WinControls.UI;

namespace eMediShop.Stock
{
    public partial class ucStockTransfer : UserControl
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty;
        string _purch_id = string.Empty;
        string _trf_to = string.Empty;
        public ucStockTransfer()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;



            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void ucStockTransfer_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = "ListWithShortName";
                p.prm_1 = "N/A";p.prm_2 = "N/A";p.prm_3 = "N/A";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);
                List<RadListDataItem> list = new List<RadListDataItem>();
                foreach (DataRow dr in dwr.result.Tables[0].Rows)
                {
                    list.Add(new Telerik.WinControls.UI.RadListDataItem(dr["sh_name"].ToString(), dr["unit_id"].ToString()));
                }
                rddl_units.Items.AddRange(list);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rddl_units_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "N/A"; p.logic = "Purchase_ForUnit"; p.prm_1 = rddl_units.SelectedValue.ToString(); p.prm_2 = "N/A";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                rgv_ids.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_ids_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _purch_id = e.Row.Cells["purch_id"].Value.ToString();
                _trf_to = rddl_units.SelectedValue.ToString();
                rgv_ids.DataSource = _ds.Tables[0];
                pm_Transfer p = new pm_Transfer();
                p.unit_id = GlobalUsage.Unit_id; p.transfer_id = _purch_id; p.TransferToUnit = _trf_to; p.tran_type = _purch_id;
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockTransferByPurchaseID", p);
                rgv_info.DataSource = dwr.result.Tables[0];
                if (rgv_info.Rows.Count > 0) { btnPost.Enabled = true; }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPost_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (RadMessageBox.Show("Do You Confirm to Post Purchasse Id No. " + _purch_id + " (Y/N)", "ExPro Help.", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                {

                    #region Process Body
                    Cursor.Current = Cursors.WaitCursor;
                    btnPost.Enabled = false;
                    string trf_id = string.Empty;
                    if (rgv_info.Rows.Count > 0)
                    {
                        trf_id = rgv_info.Rows[0].Cells["trf_id"].Value.ToString();
                    }
                    pm_Transfer p = new pm_Transfer();
                    p.unit_id = GlobalUsage.Unit_id; p.transaction_id = trf_id; p.tran_type = "Stock";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranPosting", p);

                    if (dwr.message.Contains("/"))
                    {
                        Cursor.Current = Cursors.Default;
                        RadMessageBox.Show("Successfully Completed with Voucher No. " + dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        rgv_info.DataSource = new string[] { };
                        rgv_ids.CurrentRow.Delete();
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    #endregion
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
