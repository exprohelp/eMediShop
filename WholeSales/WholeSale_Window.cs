﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.WholeSales
{
    public partial class WholeSale_Window : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _itemid = string.Empty;
        string _masterkeyid = string.Empty; decimal _UnitSaleRate = 0; string _partyid = string.Empty;
        string _accountid = string.Empty; string _gstn_no = string.Empty;string _saleProcess = string.Empty;
        Int32 _qty = 0;
        public WholeSale_Window()
        {
            InitializeComponent();
        }

        private void WholeSale_Window_Load(object sender, EventArgs e)
        {
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "IC-Pending";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WholeSaleQueries", p);
            _ds = dwr.result;
            rgv_pending.DataSource = _ds.Tables[0];
        }

        private void rtb_productname_TextChanged(object sender, EventArgs e)
        {
            if (rtb_productname.TextLength > 2)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Search p = new Search();
                    p.SearchKey = rtb_productname.Text; p.Logic = "ALL-Product"; p.unit_id = GlobalUsage.Unit_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductHelp", p);
                    _ds = dwr.result;
                    rgv_productHelp.DataSource = _ds.Tables[0];

                    if (_ds.Tables[0].Rows.Count > 0) rgv_productHelp.Visible = true; else rgv_productHelp.Visible = false;

                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }

        }

        private void rtb_productname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                rgv_productHelp.Focus();
            }
        }

        protected void fill_batchInfo(string item_id)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                productSearch p = new productSearch();
                p.unit_id = GlobalUsage.Unit_id; p.item_id = item_id; p.logic = "Sales"; p.prm_1 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", p);
                DataSet ds = dwr.result;
                int trec = 0;
                lv_batchno.Items.Clear();
                #region Batch Grid Filling if record is more than 1
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    trec = trec + 1;
                    ListViewItem lvi = new ListViewItem(dr["master_key_id"].ToString());
                    lvi.SubItems.Add(dr["batch_no"].ToString());
                    if (Convert.ToDateTime(dr["exp_date"]).ToString("yyyy-MM-dd") != "1900-01-01")
                        lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                    else
                        lvi.SubItems.Add("-");
                    lvi.SubItems.Add(dr["pack_type"].ToString());
                    lvi.SubItems.Add(dr["pack_qty"].ToString());
                    lvi.SubItems.Add(dr["qty"].ToString());
                    lvi.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("####.00"));
                    lvi.SubItems.Add(dr["upr"].ToString());
                    lvi.SubItems.Add(dr["AuditRemark"].ToString());
                    if (dr["AuditMark"].ToString() == "Black")
                    {
                        if (dr["Promo_key"].ToString() == "Y")
                        {
                            lvi.Font = new System.Drawing.Font(lvi.Font, FontStyle.Bold);
                            lvi.ForeColor = Color.FromArgb(0, 0, 192);
                        }
                        else
                        {
                            lvi.Font = new System.Drawing.Font(lvi.Font, FontStyle.Regular);
                        }
                        lvi.BackColor = Color.Gray;
                    }
                    else if (dr["AuditMark"].ToString() == "Red")
                    {
                        lvi.Font = new System.Drawing.Font(lvi.Font, FontStyle.Bold);
                        lvi.BackColor = Color.Red;
                    }

                    lv_batchno.Items.Add(lvi);

                }
                #endregion

                #region Fill Variable if Record is 1
                if (trec == 1)
                {
                    _masterkeyid = lv_batchno.Items[0].Text;
                    rtb_BatchNo.Text = lv_batchno.Items[0].SubItems[1].Text;
                    rtb_packtype.Text = lv_batchno.Items[0].SubItems[3].Text;
                    rtb_packqty.Text = lv_batchno.Items[0].SubItems[4].Text;
                    rtb_instock.Text = Convert.ToInt32(lv_batchno.Items[0].SubItems[5].Text).ToString();
                    _UnitSaleRate = Convert.ToDecimal(lv_batchno.Items[0].SubItems[7].Text);
                    _qty = Convert.ToInt32(lv_batchno.Items[0].SubItems[5].Text);

                    rtbSoldQty.Focus();
                }
                else { lv_batchno.Visible = true; }
                #endregion
                if (lv_batchno.Items.Count == 0)
                    lv_batchno.Visible = false;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                rgv_productHelp.Visible = false;
                this.rtb_productname.TextChanged -= new System.EventHandler(this.rtb_productname_TextChanged);
                rtb_productname.Text = rgv_productHelp.CurrentRow.Cells["item_name"].Value.ToString();
                _itemid = rgv_productHelp.CurrentRow.Cells["item_id"].Value.ToString();
                this.rtb_productname.TextChanged += new System.EventHandler(this.rtb_productname_TextChanged);
                fill_batchInfo(rgv_productHelp.CurrentRow.Cells["item_id"].Value.ToString());
            }
        }

        private void rtb_BatchNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) rtb_productname.Focus();
            if (e.KeyCode == Keys.Return)
            {
                if (rtb_BatchNo.Text.Length > 0)
                    rtbSoldQty.Focus();
                else { MessageBox.Show("Enter Batch No.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); rtb_BatchNo.Focus(); }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lv_batchno.Items.Count > 1)
                {
                    lv_batchno.Visible = true;
                    lv_batchno.Focus();
                    lv_batchno.Items[lv_batchno.FocusedItem.Index].Selected = true;
                }
            }

        }

        private void lv_batchno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int FocusedIndex = lv_batchno.FocusedItem.Index;
                _masterkeyid = lv_batchno.FocusedItem.Text;

                rtb_BatchNo.Text = lv_batchno.Items[FocusedIndex].SubItems[1].Text;
                rtb_packtype.Text = lv_batchno.Items[FocusedIndex].SubItems[3].Text;
                rtb_packqty.Text = lv_batchno.Items[FocusedIndex].SubItems[4].Text;
                rtb_instock.Text = Convert.ToInt32(lv_batchno.Items[FocusedIndex].SubItems[5].Text).ToString();
                _UnitSaleRate = Convert.ToDecimal(lv_batchno.Items[FocusedIndex].SubItems[7].Text);
                _qty = Convert.ToInt32(lv_batchno.Items[FocusedIndex].SubItems[5].Text);
                lv_batchno.Visible = false;
                rtbSoldQty.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                rtb_productname.Focus();
            }
        }

        private void rtbSoldQty_TextChanged(object sender, EventArgs e)
        {


            if (Config.isNumeric(rtbSoldQty.Text, System.Globalization.NumberStyles.Integer))
            {
                rtb_amount.Text = (Convert.ToDecimal(rtbSoldQty.Text) * _UnitSaleRate).ToString("#####.00");
            }
            //else
            //    rtb_amount.Text = "0";
        }

        private void rtbSoldQty_Leave(object sender, EventArgs e)
        {
            if (rtbSoldQty.Text.Length > 0)
            {
                if ((Convert.ToDecimal(rtbSoldQty.Text) % Convert.ToDecimal(rtb_packqty.Text) > 0) && _saleProcess== "In-Packs")
                {
                    MessageBox.Show("Quanty Should be in multiple of pack qty", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtbSoldQty.Focus();
                    rtbSoldQty.SelectAll();
                    return;
                }


                if (_qty < Convert.ToInt32(rtbSoldQty.Text))
                {
                    MessageBox.Show("Maximum Sold Quantity Should be " + _qty.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtbSoldQty.Focus();
                    rtbSoldQty.SelectAll();
                    return;
                }
            }

        }

        private void rtbSoldQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;p.sale_type = "Bulk";p.order_no = "-";
                p.sale_inv_no = rtbSaleInvNo.Text; p.party_id = _partyid; p.account_id = rtb_accountid.Text;p.logic = "Key In";
                p.item_id = _itemid; p.master_key_id = _masterkeyid; p.sale_qty = Convert.ToInt16(rtbSoldQty.Text);
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/ICTVInetrCompanyToVendor", p);

                DataSet ds = dwr.result;

                rgv_sold.DataSource = ds.Tables[0];
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.rtb_productname.TextChanged -= new System.EventHandler(this.rtb_productname_TextChanged);
                    rtb_productname.Text = ""; rtbSoldQty.Text = "";
                    this.rtb_productname.TextChanged += new System.EventHandler(this.rtb_productname_TextChanged);
                    rtbSaleInvNo.Text = ds.Tables[0].Rows[0]["sale_inv_no"].ToString();
                    btnPost.Enabled = true;
                    rtb_productname.Focus();
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rtb_PartyName_TextChanged(object sender, EventArgs e)
        {
            if (rtb_PartyName.TextLength > 2)
            {
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "Sales:CustomerSearch"; p.prm_1 = rtb_PartyName.Text; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                rgv_parties.DataSource = dwr.result.Tables[0];
                _ds = dwr.result;
                if (_ds.Tables[0].Rows.Count > 0)
                    rgv_parties.Visible = true;
                else
                    rgv_parties.Visible = false;

            }
        }

        private void MasterTemplate_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rgv_parties.Visible = false;
                this.rgv_parties.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.MasterTemplate_KeyDown_1);
                rtb_PartyName.TextChanged -= new EventHandler(rtb_PartyName_TextChanged);
                rtb_PartyName.Text = rgv_parties.CurrentRow.Cells["party_name"].Value.ToString();
                rtb_PartyName.TextChanged += new EventHandler(rtb_PartyName_TextChanged);
                _partyid = rgv_parties.CurrentRow.Cells["party_id"].Value.ToString();
                _accountid = rgv_parties.CurrentRow.Cells["account_id"].Value.ToString();
                _gstn_no = rgv_parties.CurrentRow.Cells["gstn_no"].Value.ToString();
                _saleProcess = rgv_parties.CurrentRow.Cells["saleProcess"].Value.ToString();

                rtb_accountid.Text = _accountid;
                this.rgv_parties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasterTemplate_KeyDown_1);
                rgv_parties.Visible = false;
                rtb_productname.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
                rgv_parties.Visible = false;
        }

        private void rtb_PartyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rgv_parties.Focus();
        }

        private void rgv_pending_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "IC-InvoiceInfo"; p.prm_1 = e.Row.Cells[0].Value.ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WholeSaleQueries", p);

                DataSet ds = dwr.result;
                rgv_sold.DataSource = ds.Tables[0];
                this.rgv_parties.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.MasterTemplate_KeyDown_1);
                rtb_PartyName.Text = e.Row.Cells["party_name"].Value.ToString();
                _partyid = e.Row.Cells["party_id"].Value.ToString();
                _accountid = e.Row.Cells["account_id"].Value.ToString();
                rtb_accountid.Text = _accountid;
                rtbSaleInvNo.Text = e.Row.Cells[0].Value.ToString();
                this.rgv_parties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasterTemplate_KeyDown_1);
                rgv_parties.Visible = false;
                if (ds.Tables[0].Rows.Count > 0)
                    btnPost.Enabled = true;
                rtb_productname.Focus();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm To Process ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_sales p = new pm_sales();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.sale_inv_no = rtbSaleInvNo.Text; p.party_id = _partyid;
                    p.cust_name = rtb_PartyName.Text; p.account_id = rtb_accountid.Text;
                    p.gstn_no = _gstn_no; p.sale_type = "IC-TV";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/ICTVBillFinalization", p);
                    DataSet ds = dwr.result;

                    if (dwr.message.Contains("Successfully"))
                    {
                        rtb_FinalInvoice.Text = ds.Tables[0].Rows[0]["sale_inv_no"].ToString();
                        rtbSaleInvNo.Text = "New Invoice";
                        rtb_productname.Text = "";
                        rtb_PartyName.Text = "";
                        rgv_pending.CurrentRow.Delete();
                        rgv_sold.DataSource = new string[] { };
                        btnPrint.Enabled = true;
                    }
                    else
                    {
                        RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm  to Print ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "PRN:Invoice_Info"; p.prm_1 = rtb_FinalInvoice.Text;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WholeSaleQueries", p);
                    DataSet ds = dwr.result;
                    Printing.Laser.ICTV_Invoice(ds, rtb_FinalInvoice.Text);
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm  to Delete ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "ICTV:delete"; p.prm_1 = e.Row.Cells["tran_id"].Value.ToString();
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WholeSaleQueries", p);
                    DataSet ds = dwr.result;
                    rgv_sold.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPrintInternal_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm  to Print Internal Sheet?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (GlobalUsage.PrinterType == "LASER")
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        try
                        {
                            Printing.Laser.InternalSheet_Sales(rgv_pending.CurrentRow.Cells["sale_inv_no"].Value.ToString(), "Print");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        Cursor.Current = Cursors.Default;
                    }

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
