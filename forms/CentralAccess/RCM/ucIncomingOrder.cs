using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using eMediShop.Pharmacy;
using System.Data.SqlClient;
using Telerik.WinControls;
namespace eMediShop.forms.CentralAccess.RCM
{
    public partial class ucIncomingOrder : UserControl
    {

        private CashMemoSearch frmCashMemoSearch;
        string _orderNo = string.Empty; string _result = string.Empty;
        DataSet _ds = new DataSet();
        public ucIncomingOrder()
        {
            InitializeComponent();
        }

        private void btnChkOrder_Click(object sender, EventArgs e)
        {
            gb1.Enabled = true;
            lblMsg.Text = "Connectiing To Central Server And Retrieving Record";
            lblMsg.Refresh();
            //Thread.Sleep(2000);
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.tran_id = "N/A"; p.prm_1 = "Summary"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/OrderInfoForUnits", p);
                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            gb1.Show();
            btnChkOrder.Enabled = false;

            Cursor.Current = Cursors.Arrow;
            lblMsg.Text = "";
            lblMsg.Refresh();
        }

        private void lstOrder_KeyDown(object sender, KeyEventArgs e)
        {

        }
        protected void DisplayOrder()
        {
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.tran_id = _orderNo; p.prm_1 = "Detail"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/OrderInfoForUnits", p);
                _ds = dwr.result;
               
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = _ds.Tables[2];
                    lv_prodInfo.Items.Clear();
                    if (dt.Rows.Count > 0)
                    {

                        DataRow dr = dt.Rows[0];
                        lblCardNo.Text = dr["card_no"].ToString();
                        lblCustName.Text = dr["cust_name"].ToString();
                        lblAdd.Text = dr["area"].ToString() + ',' + dr["locality"].ToString() + ',' + dr["district"].ToString();
                        lblContactNo.Text = dr["mobileNo"].ToString();
                    }
                    else
                    {
                        lblCardNo.Text = _ds.Tables[0].Rows[0]["card_no"].ToString();
                        lblCustName.Text = "Card Information Not Available.";
                        lblAdd.Text = "";
                        lblContactNo.Text = "";
                    }
                    lblDate.Text = Convert.ToDateTime(_ds.Tables[0].Rows[0]["delivery_date"]).ToString("dd-MM-yyyy");
                    lblTime.Text = _ds.Tables[0].Rows[0]["delivery_time"].ToString();
                    string codes = string.Empty;
                    decimal totAmt = 0;
                    int s = 0;
                    for (int i = 0; i < _ds.Tables[0].Rows.Count; i++)
                    {
                        codes += _ds.Tables[0].Rows[i]["item_id"].ToString() + ",";
                    }
                    codes = codes.Substring(0, codes.Length - 1);
                    cm1 p1 = new cm1();
                    p1.unit_id = GlobalUsage.Unit_id; p1.prm_1 = "N/A"; p1.prm_2 = "N/A";
                    p1.prm_3 = codes; p1.Logic = "StockofItems"; p1.login_id = GlobalUsage.Login_id;
                    dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p1);
                    DataSet dsLocal = dwr.result;


                    for (int i = 0; i < _ds.Tables[0].Rows.Count; i++)
                    {
                        s++;
                        ListViewItem ls = new ListViewItem(s.ToString());
                        ls.SubItems.Add(_ds.Tables[0].Rows[i]["item_id"].ToString());
                        ls.SubItems.Add(_ds.Tables[0].Rows[i]["item_name"].ToString());
                        ls.SubItems.Add(_ds.Tables[0].Rows[i]["qty"].ToString());
                        ls.SubItems.Add(Convert.ToDecimal(_ds.Tables[0].Rows[i]["rate"]).ToString("##.00"));
                        ls.SubItems.Add(Convert.ToDecimal(_ds.Tables[0].Rows[i]["amount"]).ToString("##.00"));
                        var StkQty = dsLocal.Tables[0].AsEnumerable().Where(w =>
                        w.Field<string>("item_id") == _ds.Tables[0].Rows[i]["item_id"].ToString()).Select(x => x.Field<decimal>("qty"));
                        if (StkQty.Count() > 0)
                            ls.SubItems.Add(StkQty.First().ToString("##"));
                        else
                            ls.SubItems.Add("0");

                        totAmt = totAmt + Convert.ToDecimal(_ds.Tables[0].Rows[i]["amount"]);
                        if (_ds.Tables[0].Rows[i]["item_id"].ToString().Substring(0, 1) == "T")
                        {
                            ls.ForeColor = Color.Red;
                            ls.SubItems.Add("R");
                        }
                        else
                        {
                            ls.ForeColor = Color.Green;
                            ls.SubItems.Add("G");
                        }

                        lv_prodInfo.Items.Add(ls);
                    }
                    lblTot.Text = Convert.ToDecimal(totAmt).ToString("##.00");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GlobalUsage.pharmacy_proxy.GetOnLineOrderInfo(GlobalUsage.Login_id, _orderNo, "Close");
                btnClose.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExProhelp"); }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            btn_print.Enabled = false;
            _ds.Tables.Clear();
            try
            {
                DialogResult res = MessageBox.Show("Do you confirm to Print ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.tran_id = _orderNo; p.prm_1 = "Detail"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/OrderInfoForUnits", p);
                    _ds = dwr.result;
                    Printing.Laser.OnLineOrderSlip(lblCustName.Text, lblAdd.Text, lblContactNo.Text, _ds.Tables[0], _ds.Tables[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {

        }



        private void lv_order_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fill_OrderInfo();
            }
        }

        private void Fill_OrderInfo()
        {
            Cursor.Current = Cursors.WaitCursor;
            btn_print.Enabled = true;
            _ds.Tables.Clear();
            lv_prodInfo.Items.Clear();
            //Config.CheckDbConnect("eMediShop");
            DisplayOrder();
            Cursor.Current = Cursors.Default;
        }

        private void lv_order_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_print.Enabled = false;
            DisplayOrder();
        }

        private void rgv_info_CommandCellClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _orderNo = rgv_info.CurrentRow.Cells["Order Number"].Value.ToString();
            lv_prodInfo.Items.Clear();
            DisplayOrder();
            btn_print.Enabled = true;
            btnClose.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void btnDelay_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            eMediShop.forms.CentralAccess.RCM.order_remarks UseForm = new order_remarks(_orderNo);
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void lv_prodInfo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (e.KeyCode == Keys.F12)
                {
                    string itemid = lv_prodInfo.SelectedItems[lv_prodInfo.FocusedItem.Index].SubItems[1].Text;
                    string itemName = lv_prodInfo.SelectedItems[lv_prodInfo.FocusedItem.Index].SubItems[2].Text;
                    int qty = Convert.ToInt16(lv_prodInfo.SelectedItems[lv_prodInfo.FocusedItem.Index].SubItems[6].Text) - Convert.ToInt16(lv_prodInfo.SelectedItems[lv_prodInfo.FocusedItem.Index].SubItems[3].Text);
                    if (qty > 0)
                    {
                        string qry = "insert into newMedicine (item_id,unit_id,item_name,qty,trf_flag,sale_inv_no) values('" + itemid + "','" + GlobalUsage.Unit_id + "','" + itemName + "','" + qty.ToString() + "','N','" + _orderNo + "')";
                        // Config.GetQueryResult(qry, "eMediShop");
                    }
                }
                if (e.KeyCode == Keys.F11)
                {
                    string itemid = lv_prodInfo.Items[lv_prodInfo.FocusedItem.Index].SubItems[1].Text;
                    string itemName = lv_prodInfo.Items[lv_prodInfo.FocusedItem.Index].SubItems[2].Text;
                    int qty = Convert.ToInt16(lv_prodInfo.Items[lv_prodInfo.FocusedItem.Index].SubItems[3].Text);


                }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
        private void UpdateItemByNewMed(object sender, CashMemeoNoUpdatedEventArgs e)
        {
            string old_itemid = e.CASHMEMONO.Split('|')[0];
            string new_itemid = e.CASHMEMONO.Split('|')[1];
            string new_itemname = e.CASHMEMONO.Split('|')[2];
            string qry = "update custOrderInfo set item_id='" + new_itemid + "' where order_no='" + _orderNo + "' and item_id='" + old_itemid + "' ";
            string result = GlobalUsage.pharmacy_proxy.QueryExecute(qry, "customer_data");
        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            try
            {
                if (e.RowElement.RowInfo.Cells["viewUnit_flag"].Value.ToString() != null)
                {
                    if (e.RowElement.RowInfo.Cells["viewUnit_flag"].Value.ToString() == "N")
                    {
                        e.RowElement.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.RowElement.ForeColor = Color.Black;

                    }
                }
            }
            catch (Exception ex) { }
        }


    }
}
