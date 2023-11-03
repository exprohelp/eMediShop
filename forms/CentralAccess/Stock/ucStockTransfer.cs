using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using ExPro.Server;
using System.Data.SqlClient;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsolationLevel = System.Transactions.IsolationLevel;
using System.Configuration;
using Telerik.WinControls;
using Newtonsoft.Json;
namespace eMediShop.forms.CentralAccess.Stock
{
    public partial class ucStockTransfer : UserControl
    {
        string _item_id = ""; string _result = string.Empty; bool _validQty;
        string _Master_Key_Id = ""; string _Trf_Id = ""; string inAudit = string.Empty;
        int _Qty = 0; string _CallFrom = string.Empty; string _TrfType = string.Empty;
        string _trf_to = string.Empty;string _cartName = string.Empty; string _jsonString = string.Empty;
        DataSet _ds = new DataSet();
        public ucStockTransfer(string CallFrom)
        {
            _CallFrom = CallFrom;
            InitializeComponent();
            _cartName = "-";
        }

        private void txtMedName_TextChanged(object sender, EventArgs e)
        {
            lvprobymfdinfo.Items.Clear();
            DataSet ds = new DataSet();
            if (txtMedName.Text.Length > 1)
            {
                cm2 p = new cm2();
                if (_TrfType == "WPR")
                { p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "StockListSearchByName_LP"; p.prm_1 = txtMedName.Text.Trim(); }
                else if (chkFromCart.Checked)
                { p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "StockListSearchInCart"; p.prm_1 = txtMedName.Text.Trim(); p.prm_2 = cmbCartName.Text; }
                else
                { p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "StockListSearchByName_ALL"; p.prm_1 = txtMedName.Text.Trim(); }
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);

                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    lvprobymfdinfo.Visible = true;

                    foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["item_id"].ToString());
                        lvi.SubItems.Add(dr["item_name"].ToString());
                        lvi.SubItems.Add(dr["mfd_name"].ToString());
                        lvi.SubItems.Add(dr["shelf_no"].ToString());
                        lvi.SubItems.Add(dr["qty"].ToString());
                        lvprobymfdinfo.Items.Add(lvi);
                    }
                }
                else
                {
                    lvprobymfdinfo.Visible = false;
                }
            }
        }
        private void txtMedName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lvprobymfdinfo.Focus();
                lvprobymfdinfo.Visible = true;
                lv_Batch.Visible = false;
                lvprobymfdinfo.Items[0].Selected = true;
            }
        }
        private void lvprobymfdinfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _item_id = lvprobymfdinfo.Items[lvprobymfdinfo.FocusedItem.Index].SubItems[0].Text;
                txtMedName.Text = lvprobymfdinfo.Items[lvprobymfdinfo.FocusedItem.Index].SubItems[1].Text;
                GetBatchInfo();
                lvprobymfdinfo.Visible = false;
            }
        }
        /// <summary>
        /// call of this function on key down of manufacturer list information
        /// </summary>
        private void GetBatchInfo()
        {
            _ds.Tables.Clear();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id;p.item_id = _item_id;p.Logic = "StkTrf";p.prm_1 = "-";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", p);
            _ds = dwr.result;
            int rows = _ds.Tables[0].Rows.Count;
            if (rows == 1)
            {
                lv_Batch.Visible = false;
                _Master_Key_Id = _ds.Tables[0].Rows[0]["master_key_id"].ToString();
                _Qty = Convert.ToInt32(_ds.Tables[0].Rows[0]["qty"]);
                txtbatchno.Text = _ds.Tables[0].Rows[0]["batch_no"].ToString();
                if (Convert.ToDateTime(_ds.Tables[0].Rows[0]["exp_date"]).ToString("dd-MM-yyyy") != "1900-01-01")
                    txtExpDate.Text = Convert.ToDateTime(_ds.Tables[0].Rows[0]["exp_date"]).ToString("MMM-yyyy");
                else
                    txtExpDate.Text = "";
                txtpacking.Text = _ds.Tables[0].Rows[0]["pack_type"].ToString();
                txtpackqty.Text = _ds.Tables[0].Rows[0]["pack_qty"].ToString();
                txtunitrate.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["upr"]).ToString("####.00");
                txtqty.Text = _ds.Tables[0].Rows[0]["qty"].ToString();
                inAudit = _ds.Tables[0].Rows[0]["remarks"].ToString();
                txtMedName.Select();
                decimal total = Convert.ToDecimal(txtunitrate.Text) * Convert.ToDecimal(txtqty.Text);
                txttotal.Text = total.ToString("######.00");
                txtqty.Focus();
                txtqty.Select();
            }
            else if (rows > 1)
            {
                lv_Batch.Focus();
                lv_Batch.Visible = true;
                lv_Batch.Items.Clear();
                foreach (DataRow dr in _ds.Tables[0].Rows)
                {
                    lv_Batch.Items.Add(dr["master_key_id"].ToString());
                    lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                    if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") != "1900-01-01")
                        lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MMM-yyyy"));
                    else
                        lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add("");
                    lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                    lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                    lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());

                    lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["upr"]).ToString("####.00"));
                    lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(dr["npr"].ToString());
                    lv_Batch.Items[lv_Batch.Items.Count - 1].SubItems.Add(dr["remarks"].ToString());
                    if (dr["remarks"].ToString() != "N/A")
                        lv_Batch.ForeColor = Color.Red;
                    else
                        lv_Batch.ForeColor = Color.Green;

                }
                lv_Batch.Items[0].Selected = true;
            }

        }
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateQty();
                if (_Qty >= Convert.ToInt32(txtqty.Text) && Convert.ToInt16(txtqty.Text) > 0 && _validQty) { InterUnitServerTransfer(); }
                else { RadMessageBox.Show("Stock is Less or Quantity Is Negative. Qty Should be in result of (Packs X Pack Qty) Format.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            }
        }
        private void InterUnitServerTransfer()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (_trf_to != "")
                {
                    pm_Transfer p = new pm_Transfer();
                    p.logic = "Record:" + _TrfType;p.unit_id = GlobalUsage.Unit_id;p.TransferToUnit = _trf_to;p.item_id = _item_id;
                    p.master_key_id = _Master_Key_Id;p.qty = Convert.ToInt32(txtqty.Text);p.cart_name = _cartName;p.GenFrom = "WUI";
                    p.transfer_id = _Trf_Id;p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranInterUnitsInsert", p);
                    DataSet dsTran = dwr.result;
                    string[] r = dwr.message.Split('|');
                    _Trf_Id = r[1];
                    if (dsTran.Tables[0].Rows.Count > 0)
                    {
                        if (_Trf_Id != "New")
                        {
                            cmb_TrfID.SelectedIndexChanged -= new EventHandler(cmb_TrfID_SelectedIndexChanged);
                            cmb_TrfID.Items.Add(new AddValue(_Trf_Id, _Trf_Id + " Current ID"));
                            cmb_TrfID.SelectedIndexChanged += new EventHandler(cmb_TrfID_SelectedIndexChanged);
                            int idx = cmb_TrfID.FindString(_Trf_Id);
                            if (idx != null)
                                cmb_TrfID.SelectedIndex = idx;
                        }
                        fillInsertedRecordList(dsTran.Tables[0]);
                    }
                    else
                    {
                        MessageBox.Show("Stock is not Synchronised", "ExPro Help", MessageBoxButtons.OK);
                        txtMedName.Select();
                    }
                }
                else
                { MessageBox.Show("Please Select Transfer To unit"); }
            }
            catch (Exception ex)
            {
            }
            finally { Cursor.Current = Cursors.Default; }
        }


        private void fillInsertedRecordList(DataTable dt)
        {

            int i = 1;
            if (_ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Telerik.WinControls.UI.GridViewRowInfo gr = dgProductInfo.Rows.NewRow();
                    gr.Cells["master_key_id"].Value = dr["master_key_id"].ToString();
                    gr.Cells["rno"].Value = i.ToString();
                    gr.Cells["item_name"].Value = dr["item_name"].ToString();
                    gr.Cells["batch_no"].Value = dr["batch_no"].ToString();
                    if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") != "1900-01-01")
                        gr.Cells["exp_date"].Value = Convert.ToDateTime(dr["exp_date"]).ToString("MMM-yyyy");
                    else
                        gr.Cells["exp_date"].Value = "-";
                    gr.Cells["pack_type"].Value = dr["pack_type"].ToString();
                    gr.Cells["pack_qty"].Value = dr["pack_qty"].ToString();
                    gr.Cells["qty"].Value = dr["qty"].ToString();
                    gr.Cells["upr"].Value = dr["upr"].ToString();
                    gr.Cells["total"].Value = dr["total"].ToString();
                    gr.Cells["item_id"].Value = dr["item_id"].ToString();
                    if (Convert.ToBoolean(dr["lock_flag"]) == false) btnAcPosting.Enabled = true; else btnAcPosting.Enabled = false;
                    _trf_to = dr["trf_to"].ToString();
                    i++;
                    dgProductInfo.Rows.Add(gr);

                }
                if (dgProductInfo.Rows.Count > 0)
                {
                  
                    btnInternalSheet.Visible = true;
                }
                else
                {
            
                    btnInternalSheet.Visible = false;
                }
            }

            txtMedName.Select();
            txtMedName.Focus();
            lvprobymfdinfo.Visible = false;
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            cm2 p = new cm2();
            if (cmb_TrfID.Text.ToUpper() != "SELECT")
            {
                try
                {
                    dgProductInfo.Rows.Clear();
                    Cursor.Current = Cursors.WaitCursor;
                    _ds.Tables.Clear(); _result = DateTime.Now.Second.ToString();
                    if (_Trf_Id.ToUpper() == "NEW")
                    {
                        p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "ST_TRF_Ledger";p.prm_1 = "New";p.prm_2 = GlobalUsage.Comp_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                        _ds = dwr.result;
                        //Cart Loading
                        cmbCartName.Items.Clear();
                        cmbCartName.Items.AddRange(Config.FillCombo(_ds.Tables[1]));
                        cmbCartName.SelectedIndex = 0;

                    }
                    else
                    {
                        p.unit_id = GlobalUsage.Unit_id; ;p.tran_id = _Trf_Id; p.Logic = "ST_TRF_Ledger"; 
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                        _ds = dwr.result;
                        cmbCartName.Items.Clear();
                        cmbCartName.Items.AddRange(Config.FillCombo(_ds.Tables[2]));
                        if (dwr.result.Tables[2].Rows.Count == 1) { 
                            cmbCartName.SelectedIndex = 1;
                            cmbCartName.Enabled = false;
                            _cartName = _ds.Tables[2].Rows[0]["cart_name"].ToString();
                        }
                        else
                        { }
                    }
                    cbxTrf_to.Items.Clear();
                    if (_ds.Tables[0].Rows.Count == 1)
                        cbxTrf_to.Enabled = false;
                    else
                        cbxTrf_to.Enabled = true;
                    this.cbxTrf_to.SelectedIndexChanged -= new System.EventHandler(this.cbxTrf_to_SelectedIndexChanged);
                    cbxTrf_to.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
                    this.cbxTrf_to.SelectedIndexChanged += new System.EventHandler(this.cbxTrf_to_SelectedIndexChanged);
                    if (_Trf_Id.ToUpper() == "NEW")
                        cbxTrf_to.SelectedIndex = 0;
                    else if (_TrfType == "Stock")
                    {
                        cbxTrf_to.SelectedIndex = 1;
                        _trf_to = ((AddValue)cbxTrf_to.SelectedItem).Value.ToString();
                    }

                    if (_ds.Tables[0].Rows.Count > 0)
                        btnAcPosting.Enabled = true;
                    if (_Trf_Id.ToUpper() != "NEW")
                        fillInsertedRecordList(_ds.Tables[1]);
                    GVMAIN.Enabled = true;
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }
        private void btnAcPosting_Click(object sender, EventArgs e)
        {
            btnAcPosting.Enabled = false;
            string VendorCode = "";
            if (cmbVendorLedger.SelectedItem != null)
                VendorCode = ((AddValue)cmbVendorLedger.SelectedItem).Value;
            else
                VendorCode = "N/A";

            try
            {
                if (RadMessageBox.Show("Do You Confirm (Y/N)", "ExPro Help.", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                {

                    #region Process Body
                    Cursor.Current = Cursors.WaitCursor;
                    pm_Transfer p = new pm_Transfer();
                    p.unit_id = GlobalUsage.Unit_id; p.transaction_id = _Trf_Id; p.tran_type = _TrfType;
                    p.vendor_id = VendorCode;p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranPosting", p);
                    if (dwr.message.Contains("/"))
                    {
                        Cursor.Current = Cursors.Default;
                        RadMessageBox.Show("Successfully Completed with Voucher No. " + dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        Refresh_Control();
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
        private void btnFormT01_Click(object sender, EventArgs e)
        {
            if (_Trf_Id.Length > 5)
            {
                if (MessageBox.Show("Is Printer Ready (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _ds.Tables.Clear();
                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.tran_id = _Trf_Id;p.trf_tounit = _trf_to; p.Logic = "TransferId:TransferPaper";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                    _ds = dwr.result;

                    Printing.Laser.StockTransfer_Form(_ds, _Trf_Id, "Print");
                }
            }
        }
        private void btnInternalSheet_Click(object sender, EventArgs e)
        {
            if (GlobalUsage.PrinterType == "LASER")
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Printing.Laser.InternalSheet(_Trf_Id, "Print");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                Cursor.Current = Cursors.Default;
            }

        }
        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            decimal amt = 0;
            if (Conversion.IsNumeric(txtqty.Text) == true)
            {
                amt = Conversion.Val(txtqty.Text.ToString()) * Conversion.Val(txtunitrate.Text.ToString());
                txttotal.Text = amt.ToString("#####");
            }
        }
        private void ucStockTransfer_Load(object sender, EventArgs e)
        {
            Refresh_Control();
        }

        private void Refresh_Control()
        {
            dgProductInfo.Rows.Clear();
            this.cbxTrf_to.SelectedIndexChanged -= new System.EventHandler(this.cbxTrf_to_SelectedIndexChanged);

            if (_CallFrom == "Purchase Return By Vendor")
            {
                gr_VendSearch.Visible = true;
                _TrfType = "APR"; // Wrong Purchase Return
                gb_Info.Text = "[Purchase Return By Vendor]";
                this.BackColor = Color.MintCream;
                _trf_to = GlobalUsage.Unit_id;
                cbxTrf_to.Visible = false;
                label3.Visible = false;
                btnAcPosting.Text = "Complete Purchase Return";
            }
            //Stock Transfer
            else if (_CallFrom == "InterUnitStockTransfer")
            {
                gr_VendSearch.Visible = false;
                _TrfType = "Stock"; // Inter Unit Stock Transfer
                this.BackColor = Color.DarkKhaki;
                gb_Info.Text = "[Inter Unit Stock Transfer]";
                btnAcPosting.Text = "Complete Stock Transfer";
                this.cbxTrf_to.SelectedIndexChanged += new System.EventHandler(this.cbxTrf_to_SelectedIndexChanged);
            }
            //Local Purchase Return
            else if (_CallFrom == "Purchase Return")
            {
                gr_VendSearch.Visible = false;
                _TrfType = "WPR"; // Wrong Purchase Return
                gb_Info.Text = "[Purchase Return]";
                this.BackColor = Color.DimGray;
                _trf_to = GlobalUsage.Unit_id;
                cbxTrf_to.Visible = false;
                label3.Visible = false;
                btnAcPosting.Text = "Complete Purchase Return";
            }
            else if (_CallFrom == "Damage Goods")
            {
                gr_VendSearch.Visible = false;
                _TrfType = "SDG"; // Settle Damage Goods;
                cbxTrf_to.Visible = false;
                label3.Visible = false;
                btnAcPosting.Text = "Complete Damage Goods";
            }
            else
            {
                gr_VendSearch.Visible = false;
            }

            btnAcPosting.Enabled = false;
            try
            {
                lvprobymfdinfo.Visible = false;
                lv_Batch.Visible = false;
                GVMAIN.Enabled = true;
                Fill_TransferIds();
            }
            catch (Exception ex)
            {
                GVMAIN.Enabled = true;
                RadMessageBox.Show("Central Server Connectivity Problem.", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info);
                lvprobymfdinfo.Visible = false;
                lv_Batch.Visible = false;

            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void Fill_TransferIds()
        {
            cmb_TrfID.SelectedIndexChanged -= new EventHandler(cmb_TrfID_SelectedIndexChanged);
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id;  p.Logic = "StocksTransferPend_Ids";p.prm_1 = _TrfType;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
            _ds = dwr.result;
            cmb_TrfID.Items.Clear();
            cmb_TrfID.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
            cmb_TrfID.SelectedIndexChanged += new EventHandler(cmb_TrfID_SelectedIndexChanged);
            int idx = cmb_TrfID.FindString("New");
            if (idx != null)
                cmb_TrfID.SelectedIndex = idx;
            //Cart Loading
            cmbCartName.Items.Clear();
            cmbCartName.Items.AddRange(Config.FillCombo(_ds.Tables[2]));
            cmbCartName.SelectedIndex = 0;
        }
        private void lv_Batch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Master_Key_Id = lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[0].Text;
                _Qty = Convert.ToInt32(lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[4].Text);
                txtbatchno.Text = lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[1].Text;
                txtExpDate.Text = lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[2].Text;
                txtpacking.Text = lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[3].Text;
                txtpackqty.Text = lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[5].Text;
                txtunitrate.Text = lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[7].Text;
                inAudit = lv_Batch.Items[lv_Batch.FocusedItem.Index].SubItems[8].Text;
                txtqty.Text = _Qty.ToString();
                txtqty.Focus();
                txtqty.Select();
                decimal total = Convert.ToDecimal(txtunitrate.Text) * Convert.ToDecimal(txtqty.Text);
                txttotal.Text = total.ToString("######.00");
                lv_Batch.Visible = false;
                txtqty.Focus();
                txtqty.Select();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            try
            {
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "VendorSearch"; p.prm_1 = txtSearch.Text; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                var table = dwr.result.Tables[0];
                cmbVendorLedger.Items.Clear();
                cmbVendorLedger.Items.AddRange(Config.FillCombo(table));
            }
            catch (Exception ex) { RadMessageBox.Show("Check Internet Connection.", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void cmbVendorLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            // _crLedger=((AddValue)
        }

        private void cmb_TrfID_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Trf_Id = ((AddValue)cmb_TrfID.SelectedItem).Value;
        }

        private void txtqty_Leave(object sender, EventArgs e)
        {
            ValidateQty();
        }

        private void ValidateQty()
        {
            try
            {
                _validQty = true;
                if (txtqty.Text.Trim().Length == 0)
                    txtqty.Text = "0";
                decimal res = Convert.ToDecimal(txtqty.Text) % Convert.ToDecimal(txtpackqty.Text);
                if (res > 0 || inAudit != "N/A")
                {
                    RadMessageBox.Show("Not Valid Quantity or Product is in Audit Checking.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    _validQty = false;
                    txtqty.Text = "0";
                    txtqty.Focus();
                    txtqty.SelectAll();

                }
            }
            catch (Exception ex) { }
        }

        private void cbxTrf_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTrf_to.Text.ToUpper() != "SELECT")
            {
                btnAcPosting.Enabled = true;
                _trf_to = ((AddValue)cbxTrf_to.SelectedItem).Value.ToString();
                GVMAIN.Enabled = true;
            }
            else
            { btnAcPosting.Enabled = false; GVMAIN.Enabled = false; }
        }

        private void cbxTrf_to_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxTrf_to.Text.ToUpper() != "SELECT")
            {
                btnAcPosting.Enabled = true;
                _trf_to = ((AddValue)cbxTrf_to.SelectedItem).Value.ToString();
                GVMAIN.Enabled = true;
            }
            else
            { btnAcPosting.Enabled = false; GVMAIN.Enabled = false; }
        }

        private void dgProductInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show("Do You Confirm  to delete Product ?" + dgProductInfo.CurrentRow.Cells["master_key_id"].Value.ToString(), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgresult.ToString() == "Yes")
            {
                try
                {
                    string itemid = dgProductInfo.CurrentRow.Cells["item_id"].Value.ToString();
                    string master_key = dgProductInfo.CurrentRow.Cells["master_key_id"].Value.ToString();
                    int qty = Convert.ToInt16(dgProductInfo.CurrentRow.Cells["qty"].Value);
                    Cursor.Current = Cursors.WaitCursor;
                    #region Scope Process
                    pm_Transfer p = new pm_Transfer();
                    p.transfer_id = _Trf_Id;p.unit_id = GlobalUsage.Unit_id; p.TransferToUnit = _trf_to;p.item_id = itemid;
                    p.master_key_id = master_key;p.qty = qty;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TransDeleteRecord", p);

                    if (dwr.message.Contains("Success"))
                    {
                        dgProductInfo.CurrentRow.Delete();
                    }
                    else
                    { MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    #endregion

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally { Cursor.Current = Cursors.Default; }

            }
        }

        private void cmbCartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cartName= ((AddValue)cmbCartName.SelectedItem).Value.ToString();
        }
    }
}
