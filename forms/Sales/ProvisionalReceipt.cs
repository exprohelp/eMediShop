using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.Sales
{
    public partial class ProvisionalReceipt : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty;
        public ProvisionalReceipt()
        {
            InitializeComponent();
        }

        private void rtxt_CardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string qry = "select wdbill_flag=isnull(wdbill_flag,'N') from card_info where (card_no='" + rtxt_CardNo.Text + "' or mobileno='" + rtxt_CardNo.Text + "')";
                    _ds = GlobalUsage.healthcard_proxy.GetQueryResult(qry, "eManagement");
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        if (_ds.Tables[0].Rows[0]["wdbill_flag"].ToString() == "Y")
                        {

                            cm1 p = new cm1();
                            p.unit_id = GlobalUsage.Unit_id; p.Logic = "InvoicesForProvisionl"; p.prm_1 = rtxt_CardNo.Text; p.login_id = GlobalUsage.Login_id;
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

                          
                            rgv_info.DataSource = dwr.result.Tables[0];
                        }
                    }
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }


            }
        }

        private void ProvisionalReceipt_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
        }
        protected void Fill_ItemSalesGrid(string Sale_Inv_No)
        {
            try
            {
                _ds.Tables.Clear();
                _ds.Dispose();
                pm_SalesAction1 p = new pm_SalesAction1();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/GetSalesInvoice_Info", p);
                p.unit_id = GlobalUsage.Unit_id; p.Sales_Inv_No = Sale_Inv_No; p.order_no = "N/A";
                p.logic = "Provisionl";
                _ds = dwr.result;
                ItemSaleGrid.Items.Clear();

                if (_ds.Tables[1].Rows.Count > 0)
                {
                    #region Fill Item Grid
                    foreach (DataRow dr in _ds.Tables[1].Rows)
                    {

                        ListViewItem lvi = new ListViewItem(dr["master_key_id"].ToString());              //0
                        lvi.SubItems.Add(dr["item_name"].ToString());                                   //1
                        lvi.SubItems.Add(dr["batch_no"].ToString());                                    //2
                        if (dr["exp_date"] != System.DBNull.Value)
                            lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));   //3
                        else
                            lvi.SubItems.Add("-");
                        lvi.SubItems.Add(dr["Pack_type"].ToString());                                   //4
                        lvi.SubItems.Add(dr["pack_qty"].ToString());                                    //5
                        lvi.SubItems.Add(Convert.ToDecimal(dr["Mrp"]).ToString("####.00"));             //6
                        lvi.SubItems.Add(Convert.ToDecimal(dr["unit_rate"]).ToString("####.00"));       //7
                        lvi.SubItems.Add(dr["tax_id"].ToString());                                      //8
                        lvi.SubItems.Add(dr["sale_qty"].ToString());                                    //9
                        lvi.SubItems.Add(Convert.ToDecimal(dr["sv"]).ToString("####.00"));              //10
                        lvi.SubItems.Add(dr["item_id"].ToString());                                     //11
                        ItemSaleGrid.Items.Add(lvi);

                    }
                    if (ItemSaleGrid.Items.Count > 0)
                        btn_print.Enabled = true;
                    else
                        btn_print.Enabled = false;
                    #endregion
                }

            }
            catch (Exception ex)
            { }
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Fill_ItemSalesGrid(e.Row.Cells[0].Value.ToString());
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pRetail_ProvisionalBill '" + GlobalUsage.Unit_id + "','" + rgv_info.CurrentRow.Cells[0].Value.ToString() + "'", "ChandanPharmacy_Live");
                Printing.Laser.CashMemoWithoutDiscount(rgv_info.CurrentRow.Cells[0].Value.ToString(), _ds);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

    }
}
