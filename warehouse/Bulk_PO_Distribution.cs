using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;
namespace eMediShop.warehouse
{
    public partial class Bulk_PO_Distribution : Telerik.WinControls.UI.RadForm
    {
        string _JSONsting = string.Empty; string _result = string.Empty; string _tranType = string.Empty;
        string _soldTo = string.Empty; string _partyid = string.Empty; string _accountid = string.Empty;
        public Bulk_PO_Distribution()
        {
            InitializeComponent();

        }

        private void Bulk_PO_Distribution_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_BulkTrfSales p = new pm_BulkTrfSales();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "Open Order"; p.prm_1 = GlobalUsage.Comp_id; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/BulkDistributionQueries", p);

                rddl_order_no.DataSource = dwr.result.Tables[0];
                rddl_order_no.ValueMember = "order_no";
                rddl_order_no.DisplayMember = "order_no";
                ddlNames.DataSource= dwr.result.Tables[1];
                ddlNames.ValueMember = "unit_id";
                ddlNames.DisplayMember = "sh_name";
                ddlNames.SelectedValue = GlobalUsage.Unit_id;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_BulkTrfSales p = new pm_BulkTrfSales();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "DistributionList";
                p.order_no = rddl_order_no.SelectedItem.Value.ToString();
                p.prm_1 = GlobalUsage.Comp_id; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/BulkDistributionQueries", p);

                rgv_dist_info.DataSource = dwr.result.Tables[0];
                rddl_order_no.Enabled = false;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_dist_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _tranType = rgv_dist_info.CurrentRow.Cells["tran_type"].Value.ToString();
                _soldTo = rgv_dist_info.CurrentRow.Cells["unit_id"].Value.ToString();
                _partyid = rgv_dist_info.CurrentRow.Cells["vendor_id"].Value.ToString();
                _accountid = rgv_dist_info.CurrentRow.Cells["ac_code"].Value.ToString();
                rgb_info.Text = rgv_dist_info.CurrentRow.Cells["unit_name"].Value.ToString();
                pm_BulkTrfSales p = new pm_BulkTrfSales();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "unitRecordForDistribution";
                p.prm_1 = e.Row.Cells["unit_id"].Value.ToString(); p.login_id = GlobalUsage.Login_id;
                p.order_no = rddl_order_no.SelectedItem.Value.ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/BulkDistributionQueries", p);
                if (!dwr.message.Contains("No Records Found"))
                {
                    rgv_detail.DataSource = dwr.result.Tables[0];
                    btn_process.Enabled = true;
                }
                else
                { rgv_detail.DataSource = new string[] { }; btn_process.Enabled = false; }


            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm To Process", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    btn_process.Enabled = false;
                    pm_BulkTrfSales p = new pm_BulkTrfSales();
                    datasetWithResult dwr = new datasetWithResult();
                    if (_tranType == "By Sales")
                    {
                        p.unit_id = GlobalUsage.Unit_id; p.sold_to = _soldTo;p.party_id = _partyid;
                        p.account_id = _accountid;p.order_no = rddl_order_no.SelectedItem.Value.ToString();
                        p.login_id = GlobalUsage.Login_id;
                        dwr = ConfigWebAPI.CallAPI("api/stocks/BulkDispatchBySales", p);
                        
                    }
                    else if (_tranType == "By Transfer")
                    {
                        p.unit_id = GlobalUsage.Unit_id; p.TransferToUnit = _soldTo; p.party_id = "N/A";
                        p.account_id = "N/A"; p.order_no = rddl_order_no.SelectedItem.Value.ToString();
                        p.login_id = GlobalUsage.Login_id;
                        dwr = ConfigWebAPI.CallAPI("api/stocks/BulkDispatchByTransfer", p);
                    }
                    _result = dwr.message;
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
