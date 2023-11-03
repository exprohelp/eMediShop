using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.purchase.orders
{
    public partial class MonthlyPurchaseOrderForUnits : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();
        Int32 i = new Int32();
        Int32 j = new Int32();
        string _ORDERNO = string.Empty;
        string _result = string.Empty; string filePath = string.Empty;

        public MonthlyPurchaseOrderForUnits()
        {
            InitializeComponent();

        }

        private void Zero_Stock_Order_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }
        private void btn_laserPrint_Click(object sender, EventArgs e)
        {
            if (_ds.Tables[0].Rows.Count > 0)
            {
                try
                {
                    saveFileDialog1.FileName = "PO_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";
                    saveFileDialog1.ShowDialog();
                    CrystalReportsPharmacy.eMediShop.MinimumPurchaseOrder rpt = new CrystalReportsPharmacy.eMediShop.MinimumPurchaseOrder();
                    rpt.Database.Tables["minpurchorder"].SetDataSource(_ds.Tables[0]);
                    rpt.SetParameterValue("Unit_name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("unit_Address", GlobalUsage.UnitAddress);
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, filePath);
                    //rpt.PrintToPrinter(1, false, 1, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else { MessageBox.Show("Record Not Found"); }
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath = saveFileDialog1.FileName;
        }
        private void btnPreserve_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id;p.logic = "VALIDATE_PRESERVE";
                p.nProduct = 0;p.order_no = "N/A";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/BulkMonthlyOrderForRetail", p);

                DataSet ds = dwr.result;
                btnView.Enabled = false;
                btnClose.Enabled = false;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    btnView.Text = "VIEW";
                    lblOrderNo.Text = "ALREADY GENERATED ORDER NO : " + ds.Tables[0].Rows[0]["order_no"].ToString();
                    _ORDERNO = ds.Tables[0].Rows[0]["order_no"].ToString();
                    btnView.Enabled = true;
                    btnClose.Enabled = true;
                    lblOrder.Visible = false;
                    txtOrder.Visible = false;
                }
                else
                {
                    btnView.Text = "GENERATE";
                    lblOrderNo.Text = "PROCEED TO GENERATE ORDER ";
                    _ORDERNO = "N/A";
                    lblOrder.Visible = true;
                    txtOrder.Visible = true;
                    btnView.Enabled = true;
                }
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (btnView.Text == "VIEW")
            {
                FillOrder();
            }
            else if (btnView.Text == "GENERATE")
            {
                Preserve();
                FillOrder();
            }
        }
        private void Preserve()
        {
            try
            {
                lstZeroStockOrder.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id;p.logic = "preserve";p.orderFormonth = Convert.ToDecimal(txtOrder.Text); p.prm_1 = "X";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/BulkMonthlyOrderForRetail", p);
                _ds = dwr.result;
                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    _ORDERNO = _ds.Tables[0].Rows[0]["order_no"].ToString();
                    lblOrderNo.Text = "GENERATED ORDER NO : " + _ds.Tables[0].Rows[0]["order_no"].ToString();
                    btnView.Text = "VIEW";
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void FillOrder()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                lstZeroStockOrder.Items.Clear();

                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "GET_ORDERINFO";
                p.nProduct = 0; p.order_no = _ORDERNO; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/BulkMonthlyOrderForRetail", p);
                _ds = dwr.result;
                btnClose.Enabled = false;
                btnExcel.Enabled = false;
                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    btnClose.Enabled = true;
                    btnExcel.Enabled = true;
                 foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        if (_result != dr["mfd_name"].ToString())
                        {
                            _result = dr["mfd_name"].ToString();
                            lstZeroStockOrder.Groups.Add(dr["mfd_name"].ToString(), dr["mfd_name"].ToString());
                        }
                        ListViewItem lvi = new ListViewItem(i.ToString());
                        lvi.SubItems.Add(dr["mfd_name"].ToString());
                        lvi.SubItems.Add(dr["item_name"].ToString());
                        lvi.SubItems.Add(dr["pack_type"].ToString());
                        lvi.SubItems.Add(dr["pack_qty"].ToString());
                        lvi.SubItems.Add(Convert.ToDecimal(dr["sale_avg"]).ToString("00.00"));
                        lvi.SubItems.Add(dr["order_pack"].ToString());
                        lvi.SubItems.Add(Convert.ToDecimal(dr["NPR"]).ToString("00.00"));
                        lvi.SubItems.Add((Convert.ToDecimal(dr["NPR"]) * Convert.ToDecimal(dr["order_pack"])).ToString("00.00"));
                        lvi.SubItems.Add(Convert.ToDateTime(dr["last_sale_date"]).ToString("dd -MM-yy"));
                        lvi.SubItems.Add(dr["alert_flag"].ToString());
                        lvi.SubItems.Add(dr["vendor_name"].ToString());
                        lvi.SubItems.Add(dr["wh_stock"].ToString());
                        lvi.Group = lstZeroStockOrder.Groups[dr["mfd_name"].ToString()];
                        lstZeroStockOrder.Items.Add(lvi);
                        i = i + 1;
                    }
                    if (lstZeroStockOrder.Items.Count > 0)
                        btn_laserPrint.Enabled = true;
                    else
                        btn_laserPrint.Enabled = false;
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if ((MessageBox.Show("Do You Confirm To Close The Order (Y/N) ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes"))
                {

                    pm_PurchaseOrders p = new pm_PurchaseOrders();
                    p.unit_id = GlobalUsage.Unit_id; p.logic = "CLOSE_ORDER";
                    p.nProduct = 0; p.order_no = _ORDERNO; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/BulkMonthlyOrderForRetail", p);

                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Order is closed ? ", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstZeroStockOrder.Items.Clear();
                    btnExcel.Enabled = false;
                    btnClose.Enabled = false;
                    btnView.Enabled = false;
                    btn_laserPrint.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            if (lstZeroStockOrder.Items.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                GlobalUsage.ListViewToCSV(lstZeroStockOrder, "PO_" + DateTime.Now.ToString("ddMMyyyy") + ".csv");
                Cursor.Current = Cursors.Default;
            }
        }


    }
}
