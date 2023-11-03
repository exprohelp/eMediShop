using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class ucBulkOrderChecking : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; int _OldValue = 0;
        public ucBulkOrderChecking()
        {
            InitializeComponent();
        }

        private void ucDispatch5_4_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.rddl_order_no.SelectedIndexChanged -= new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_order_no_SelectedIndexChanged);
            pm_Transfer p = new pm_Transfer();
            p.unit_id = GlobalUsage.Unit_id;
            p.TransferFromUnit = "-";p.TransferToUnit = "-";p.logic = "GetOrderNo_Closed";
            p.prm_1 = "-";p.prm_2 = "-";p.prm_3 = "0";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/DispatchQueries", p);
            _ds = dwr.result;
            rddl_order_no.Items.AddRange(Config.FillTelrikCombo(_ds.Tables[0], true));
            rddl_order_no.SelectedIndex = 0;
            this.rddl_order_no.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rddl_order_no_SelectedIndexChanged);
            Cursor.Current = Cursors.Default;

        }

        private void rddl_order_no_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pm_Transfer p = new pm_Transfer();
            p.unit_id = GlobalUsage.Unit_id;
            p.TransferFromUnit = "-"; p.TransferToUnit = "-"; p.logic = "Dispatch_Extra_ToOthers";
            p.prm_1 = rddl_order_no.SelectedValue.ToString(); p.prm_2 = "-"; p.prm_3 = "0";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/DispatchQueries", p);
            _ds = dwr.result;
            rgv_unitInfo.DataSource = _ds.Tables[0];
            Cursor.Current = Cursors.Default;

            rt_OrderNo.Text = rddl_order_no.SelectedValue.ToString();

            //Enable Buttons
            rb_getIdInfo.Enabled = true;
            rb_Transfer.Enabled = true;
            rb_xl.Enabled = true;
            rb_CheckBalance.Enabled = true;
            rb_PurchaseReturn.Enabled = true;
        }

        private void rgv_unitInfo_CommandCellClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pm_Transfer p = new pm_Transfer();
            p.unit_id = GlobalUsage.Unit_id;
            p.TransferFromUnit = "-"; p.TransferToUnit = rgv_unitInfo.CurrentRow.Cells[0].Value.ToString();
            p.logic = "UnitsReqInfoForDispatch";
            p.prm_1 = rddl_order_no.SelectedValue.ToString(); p.prm_2 = "-"; p.prm_3 = Convert.ToDecimal(rt_OrderFor.Text).ToString();
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/DispatchQueries", p);
            _ds = dwr.result;
            var data = _ds.Tables[0].AsEnumerable().Select(o => new
            {
                item_id = o.Field<string>("item_id"),
                item_name = o.Field<string>("item_name"),
                pack_type = o.Field<string>("pack_type"),
                pack_qty = o.Field<int>("pack_qty"),
                master_key_id = o.Field<string>("master_key_id"),
                balstk = o.Field<decimal>("balstk"),
                pur_sale_avg = o.Field<decimal>("pur_sale_avg_packs"),
                trfstk = o.Field<decimal?>("trfStk")
            }).Where(o => o.trfstk > 0).ToList();
            rgv_info.DataSource = data;
            Cursor.Current = Cursors.Default;

        }

        private void rb_Transfer_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Transfer p = new pm_Transfer();
                p.unit_id = GlobalUsage.Unit_id; p.orderNo = rddl_order_no.SelectedValue.ToString();
                p.TransferToUnit = rgv_unitInfo.CurrentRow.Cells[0].Value.ToString();
                p.orderFor = Convert.ToDecimal(rt_OrderFor.Text).ToString();
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/Dispatch54", p);
                rgv_info.DataSource = dwr.result.Tables[0];
                lblResult.Text = "Trf. Id. : " + dwr.message;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rb_CheckBalance_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            pm_Transfer p = new pm_Transfer();
            p.unit_id = GlobalUsage.Unit_id;
            p.TransferFromUnit = "-"; p.TransferToUnit = rgv_unitInfo.CurrentRow.Cells[0].Value.ToString();
            p.logic = "BalStockInOrder";
            p.prm_1 = rddl_order_no.SelectedValue.ToString(); p.prm_2 = "-"; p.prm_3 = "0";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/DispatchQueries", p);
            _ds = dwr.result;

            rgv_info.DataSource = _ds.Tables[0];
            Cursor.Current = Cursors.Default;

        }

        private void rb_xl_Click(object sender, EventArgs e)
        {

            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();
                string fileName = f.SelectedPath + "\\po_" + rddl_order_no.SelectedValue.ToString().Replace('/', '_') + ".xls";
                Cursor.Current = Cursors.WaitCursor;
                ExportToExcelML exporter = new ExportToExcelML(this.rgv_info);
                exporter.ExportVisualSettings = true;
                //exporter.SheetMaxRows = ExcelMaxRows._1048576;
                Cursor.Current = Cursors.WaitCursor;
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help");
            }
            Cursor.Current = Cursors.Default;

        }

        private void rb_PurchaseReturn_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //    pm_PurchaseOrders p = new pm_PurchaseOrders();
            //    p.unit_id = GlobalUsage.Unit_id;p.order_no = rddl_order_no.SelectedValue.ToString();p.login_id = GlobalUsage.Login_id;
            //    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseExtraReturn", p);
            //    MessageBox.Show("Result : " + dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //Cursor.Current = Cursors.Default;

        }

        private void rb_getIdInfo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pm_Transfer p = new pm_Transfer();
            p.unit_id = GlobalUsage.Unit_id;
            p.TransferFromUnit = "-"; p.TransferToUnit = "-"; p.logic = "TransferInfoByOrderNo";
            p.prm_1 = rt_OrderNo.Text; p.prm_2 = "-"; p.prm_3 = "0";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/DispatchQueries", p);

            _ds = dwr.result;
            rgv_TransferInfo.DataSource = _ds.Tables[0];
            Cursor.Current = Cursors.Default;
        }

        private void rgv_TransferInfo_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void rgv_TransferInfo_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
                _OldValue = (int)e.Row.Cells[10].Value;

        }

        private void rgv_TransferInfo_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
            {
                string item_id = e.Row.Cells["ITEM ID"].Value.ToString();
                string trfid = e.Row.Cells[0].Value.ToString();
                string masterkeyid = e.Row.Cells[1].Value.ToString();

                if (Convert.ToInt32(e.Row.Cells[10].Value) > 0 && Convert.ToInt32(e.Row.Cells[10].Value) < _OldValue)
                {
                    int FinalQty = ((_OldValue * Convert.ToInt32(e.Row.Cells[5].Value)) - (Convert.ToInt32(e.Row.Cells[10].Value) * Convert.ToInt32(e.Row.Cells[5].Value)));
                    pm_Transfer p = new pm_Transfer();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.logic = "TIT-Update";p.transfer_id = trfid;p.prm_1 = item_id;p.prm_2 = masterkeyid;p.prm_3 = "N/A";p.qty = FinalQty;
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("pi/stocks/DispatchUpdateQueries", p);
                }
            }
        }

        private void rgv_TransferInfo_UserDeletingRow(object sender, GridViewRowCancelEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (GridViewRowInfo r in e.Rows)
            {
                string item_id = r.Cells["ITEM ID"].Value.ToString();
                string trfid = r.Cells[0].Value.ToString();
                string masterkeyid = r.Cells[1].Value.ToString();
                string locked = r.Cells[11].Value.ToString();
                int stkqty = Convert.ToInt32(r.Cells[10].Value.ToString()) * Convert.ToInt32(r.Cells[5].Value.ToString());
                if (locked == "False")
                {
                    
                    pm_Transfer p = new pm_Transfer();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.logic = "TIT-Delete"; p.transfer_id = trfid; p.prm_1 = item_id; p.prm_2 = masterkeyid; p.prm_3 = "N/A"; p.qty = stkqty;
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("pi/stocks/DispatchUpdateQueries", p);
                    if (dwr.message.Contains("Success"))
                        e.Cancel = true;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }
    }
}
