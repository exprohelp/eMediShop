using ExPro.Client;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace eMediShop
{
    public partial class Purchase_Entry : Telerik.WinControls.UI.RadForm
    {
        string _jsonString = string.Empty;
        private PurchaseSearch frmPurchSearch;
        BillPostingPopup frmBillPostingPopup;
        DataTable dt = new DataTable(); DataSet ds = new DataSet();
        string _item_id, _vendorCode;
        Int32 _dtpYear = DateTime.Now.Year; int _pressedKey = 0; int _acceptedQty = 0;
        string _ExpDate = ""; string _result = DateTime.Now.Second.ToString();
        decimal _TaxRate = 0;
        Point mLastPos = new Point(-1, -1);
        private packTypeSelection selectPackType;

        public Purchase_Entry()
        {
            InitializeComponent();
        }
        public void clearall()
        {
            txtQty.Text = "0";
            txtProdName.TextChanged -= new EventHandler(txtProdName_TextChanged);
            txtProdName.Text = "";
            txtProdName.TextChanged += new EventHandler(txtProdName_TextChanged);
            txtBatchNo.Text = "";
            txtFreeQty.Text = "0";
            txtExpDate.Text = "";
            txtMRP.Text = "";
            txtPackQty.Text = "";
            txtPackSize.Text = "";
            txtDis_Per.Text = "0";
            txtTrade.Text = "0";
            txtAmount.Text = "";
            txtHSN.Text = "-";
        }
        private void txtStockistName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.KeyChar == 13)
            {
                lv_Stockist.Location = new System.Drawing.Point(109, 83);
                lv_Stockist.Size = new System.Drawing.Size(418, 120);
                lv_Stockist.Visible = true;
                lv_Stockist.Items.Clear();
                try
                {
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "VendorSearch"; p.prm_1 = txtStockistName.Text; p.prm_2 = "";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                    var table = dwr.result.Tables[0];
                    DataRow[] drary = table.Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["vendor_id"].ToString());
                        ls.SubItems.Add(dr["vendor_Name"].ToString());
                        ls.SubItems.Add(dr["City"].ToString());
                        ls.SubItems.Add(dr["Address"].ToString());
                        lv_Stockist.Items.Add(ls);
                    }
                }
                catch (Exception ex) { RadMessageBox.Show("Check Internet Connection.", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }
        private void txtStockistName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Down && lv_Stockist.Items.Count > 0)
            {

                lv_Stockist.Focus();
                lv_Stockist.Items[0].Selected = true;
            }
            else
            {
                lv_Stockist.Visible = false;
            }
        }
        private void lv_Stockist_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                lv_Stockist.Visible = false;
                _vendorCode = lv_Stockist.FocusedItem.SubItems[0].Text;
                txtStockistName.Text = lv_Stockist.FocusedItem.SubItems[1].Text;
                txtStockistAddress.Text = lv_Stockist.FocusedItem.SubItems[3].Text;
                txtInvoiceNo.Select();
            }
        }
        public void fillTax()
        {
            pm_PurchaseQueries p = new pm_PurchaseQueries();
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "TaxIds"; p.prm_1 = GlobalUsage.State; p.prm_2 = "-";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

            if (dwr.message.Contains("Success"))
            {
                var table = dwr.result.Tables[0];
                DataRow[] drary = table.Select();
                foreach (DataRow dr in drary)
                {
                    ListViewItem ls = new ListViewItem(dr["tax_id"].ToString());
                    ls.SubItems.Add(dr["tax_rate"].ToString());
                    ls.SubItems.Add(dr["tax_detail"].ToString());
                    lv_taxDetail.Items.Add(ls);
                    if (dr["defa_flag"].ToString().ToUpper() == "D")
                        txttaxId.Text = dr["tax_id"].ToString();
                }
            }
            dt.Clear();
        }

        private void Purchase_Entry_Load(object sender, EventArgs e)
        {
            dtInv_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.Text = "[Purchase Feeding Form]  Ctrl+N: New Feeding,  F2: Purchase Id";

            fillTax();
            cmbIntCompNo.Items.Clear();
            pm_PurchaseQueries p = new pm_PurchaseQueries();
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "Purchase_IC"; p.prm_1 = "-"; p.prm_2 = "";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
            cmbIntCompNo.Items.AddRange(Config.FillCombo(dwr.result.Tables[0]));
            cmbIntCompNo.SelectedIndex = 0;
        }
        private void txtInvoiceNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtInv_date.Select();
                dtInv_date.Focus();
            }
        }
        private void txtInvDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtProdName.Select();
            }
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (txtProdName.TextLength > 2 && _pressedKey != (int)Keys.Back)
            {
                #region Process
                if (lv_Product.Visible == false)
                {
                    lv_Product.Location = new System.Drawing.Point(5, 183);
                    lv_Product.Size = new Size(409, 281);
                    lv_Product.Visible = true;
                }
                lv_Product.Items.Clear();


                try
                {
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "ProductSearch"; p.prm_1 = txtProdName.Text; p.prm_2 = "";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                    var table = dwr.result.Tables[0];
                    DataRow[] drary = table.Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
                        ls.SubItems.Add(dr["mfd_Name"].ToString());
                        ls.SubItems.Add(dr["hsn"].ToString());
                        ls.SubItems.Add(dr["hsn_verifyFlag"].ToString());
                        ls.SubItems.Add(dr["mTaxRate"].ToString());
                        lv_Product.Items.Add(ls);
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
                #endregion
            }
            Cursor.Current = Cursors.Default;
        }
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                btnPackHelp.Enabled = true;
                txtHSN.Text = lv_Product.FocusedItem.SubItems[3].Text;
                if (lv_Product.FocusedItem.SubItems[4].Text.ToUpper() == "Y")
                    txtHSN.Enabled = false;
                else
                    txtHSN.Enabled = true;

                _item_id = lv_Product.FocusedItem.SubItems[0].Text;
                _TaxRate = Convert.ToDecimal(lv_Product.FocusedItem.SubItems[5].Text);
                this.txtProdName.TextChanged -= new System.EventHandler(this.txtProdName_TextChanged);
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                if (chkLoadPurchase.Checked)
                {
                    FillLastXPurchases(_item_id);
                }
                this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
                lv_Product.Visible = false;
                //txtBarCodeNo.Focus();
                if (txtHSN.Enabled)
                    txtHSN.Focus();
                else
                    txtBatchNo.Focus();
            }
        }
        private void txtBatchNo_KeyUp(object sender, KeyEventArgs e)
        {

            string[] r;
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string inv_Date = dtInv_date.Value.ToString("yyyy-MM-dd");
                    string invType = string.Empty;

                    if (rbEstimate.Checked)
                        invType = "E";
                    if (rbTax.Checked)
                        invType = "T";

                    //Checking of Batch Information From Central Server
                    pm_CheckBatchInfo p = new pm_CheckBatchInfo();
                    p.unit_id = GlobalUsage.Unit_id; p.item_id = _item_id; p.batch_no = txtBatchNo.Text; p.logic = "ForPurchase";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CheckBatchInfo", p);
                    _result = dwr.message;
                    Cursor.Current = Cursors.Default;
                    txtExpDate.Select();
                    r = _result.Split('$');
                    if (r[0].ToString() == "Not Found" && r[1].ToString() == "Not Found")
                    {
                        MessageBox.Show("Please Update Product Master. [ " + txtProdName.Text + " ]", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtExpDate.Focus();
                    }
                    else
                    {
                        if (r[0].ToString() != "Not Found")
                        {
                            string[] d = r[0].Split('.');
                            txtExpDate.Text = d[1] + "-" + d[0];

                            txtMRP.Text = r[1].ToString();
                            txtTrade.Text = r[2].ToString();
                            txtPackSize.Text = r[3].ToString();
                            txtPackQty.Text = r[4].ToString();
                            txttaxId.Text = r[5].ToString();
                            txtQty.Text = r[6].ToString();
                        }
                        else
                        {
                            txtPackSize.Text = r[1].ToString();
                            txtPackQty.Text = r[2].ToString();
                            txtQty.Text = r[6].ToString();
                        }
                        _acceptedQty = Convert.ToInt32(r[6].ToString());
                    }
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }
        private void txtPackSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtPackQty.Focus();
                txtPackQty.Select();
            }
        }
        private void txtPackQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtQty.Focus();
                txtQty.Select();
            }
        }
        private void txttaxId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && lv_taxDetail.Items.Count > 0)
            {
                lv_taxDetail.Location = new System.Drawing.Point(756, 183);
                lv_taxDetail.Size = new System.Drawing.Size(320, 210);
                lv_taxDetail.Visible = true;
                lv_taxDetail.Focus();
                lv_taxDetail.Items[0].Selected = true;
            }
            else
            {
                lv_taxDetail.Visible = false;
            }

        }
        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            DataRow dr;
            string[] Purch_Record_Info = new string[20];
            decimal StkQty = 0;
            if (e.KeyCode == Keys.Return)
            {
                if (Convert.ToDecimal(txtGST.Text) != _TaxRate)
                {
                    RadMessageBox.Show("Tax Rate in Master is " + _TaxRate.ToString("##.00") + ".", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txttaxId.Focus();
                    return;
                }
                if (!IsCorrectHSN(txtHSN.Text))
                {
                    RadMessageBox.Show("HSN Code should be >=4 digit.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txtHSN.Focus();
                    return;
                }
                StkQty = (Conversion.Val(txtFreeQty.Text) + Conversion.Val(txtQty.Text)) * Conversion.Val(txtPackQty.Text);
                decimal nMrp = (Convert.ToDecimal(txtTrade.Text) + (Convert.ToDecimal(txtTrade.Text) * Convert.ToDecimal((40.00 / 100))));
                bool mrpCheckOk = Convert.ToDecimal(txtMRP.Text) > nMrp ? true : false;
                string mrpCaution = "";
                DialogResult dRes = DialogResult.Yes;
                if (mrpCheckOk)
                {
                    mrpCaution = "MRP is 40% Greater Than Trade.\nDo You Confirm (Y/N)";
                    dRes = RadMessageBox.Show(mrpCaution, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info);
                }
                #region Saving Process
                if (RadMessageBox.Show("Stock will be Update by " + StkQty.ToString() + " Quantity", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes && dRes.ToString() == "Yes")
                {
                    try
                    {
                        #region Process Body

                        Cursor.Current = Cursors.WaitCursor;
                        string invType = string.Empty;
                        if (rbEstimate.Checked)
                            invType = "E"; // Estimate Invoice

                        else if (rbTax.Checked)
                            invType = "T"; // Sales Invoice (With Tax),

                        //CAlling Of Web Service To Insert Records
                        string token = DateTime.Now.Second.ToString();
                        pm_PurchaseInsert p = new pm_PurchaseInsert();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                        p.order_no = cbxPurchOrder.Text; p.purch_id = txtPurchaseId.Text; p.vendor_id = _vendorCode; p.inv_no = txtInvoiceNo.Text;
                        p.inv_date = dtInv_date.Value.ToString("yyyy-MM-dd"); p.item_id = _item_id; p.hsn = txtHSN.Text; p.batch_no = txtBatchNo.Text;
                        p.qty = Convert.ToDecimal(txtQty.Text); p.free = Convert.ToDecimal(txtFreeQty.Text);
                        p.taxid = Convert.ToInt32(txttaxId.Text); p.dis = Convert.ToDecimal(txtDis_Per.Text);
                        p.expdate = _ExpDate; p.mrp = Convert.ToDecimal(txtMRP.Text); p.ptr = Convert.ToDecimal(txtTrade.Text);
                        p.pack_type = txtPackSize.Text; p.pack_qty = Convert.ToInt32(txtPackQty.Text);
                        p.barcode_no = txtBarCodeNo.Text; p.inv_type = invType; p.state = GlobalUsage.State;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseTranInsert", p);
                        DataSet ds = dwr.result;

                        //Checking of Result In Table 0
                        if (dwr.message.Substring(0, 5).ToString() != "Allow") { MessageBox.Show(token); }
                        #region  Purchase Master 
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            AddRowToBillInfo(ds.Tables[0].Rows[0]);
                            UpdateBillSummary(ds.Tables[1].Rows[0]);
                        }
                        #endregion



                        txtAmount.KeyUp -= new KeyEventHandler(txtAmount_KeyUp);
                        clearall();
                        txtProdName.Focus();
                        txtProdName.Select();
                        txtAmount.KeyUp += new KeyEventHandler(txtAmount_KeyUp);
                        #endregion
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }

                }
                else
                {
                    txtQty.Focus();
                }
                #endregion
            }
        }
        private void AddRowToBillInfo(DataRow dr)
        {

            GridViewRowInfo row = rgv_purchase.Rows.AddNew();
            row.Cells["auto_id"].Value = dr["auto_id"].ToString();
            row.Cells["Permit_Flag"].Value = dr["Permit_Flag"].ToString();
            row.Cells["item_id"].Value = dr["item_id"].ToString();
            row.Cells["item_name"].Value = dr["item_name"].ToString();
            row.Cells["barcode_no"].Value = dr["barcode_no"].ToString();
            row.Cells["hsn"].Value = dr["hsn"].ToString();
            row.Cells["batch_no"].Value = dr["batch_no"].ToString();
            if (dr["exp_date"].ToString() != "01-01-1900")
                row.Cells["exp_date"].Value = Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy");
            else
                row.Cells["exp_date"].Value = "-";
            row.Cells["trade"].Value = dr["trade"];
            row.Cells["mrp"].Value = dr["mrp"];
            row.Cells["pack_type"].Value = dr["pack_type"].ToString();
            row.Cells["pack_qty"].Value = dr["pack_qty"];
            row.Cells["qty"].Value = dr["qty"];
            row.Cells["it_free"].Value = dr["it_free"];
            row.Cells["tax_id"].Value = dr["tax_id"].ToString();
            row.Cells["tax_rate"].Value = dr["tax_rate"];
            row.Cells["disper"].Value = dr["disper"];
            row.Cells["amount"].Value = dr["amount"];
            row.Cells["chkFlag"].Value = dr["chkFlag"].ToString();
            //row.Cells["chkInfo"].Value = dr["chkInfo"].ToString();
            row.Cells["alertmsg"].Value = dr["alertmsg"].ToString();

            //Sorting
            Telerik.WinControls.Data.SortDescriptor descriptor = new Telerik.WinControls.Data.SortDescriptor();
            descriptor.PropertyName = "auto_id";
            descriptor.Direction = ListSortDirection.Descending;
            this.rgv_purchase.MasterTemplate.SortDescriptors.Add(descriptor);
        }
        private void txtExpDate_Leave(object sender, EventArgs e)
        {
            try
            {
                string date = getExpDate(txtExpDate.Text);
                DateTime xpDate_Permit = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01"));
                DateTime xpDate_input = Convert.ToDateTime(_ExpDate);
                TimeSpan ts = xpDate_input - xpDate_Permit;
                int mth = ts.Days / 30; int fixMth = 3;
                if (txtStockistName.Text.ToUpper().Contains("AUDIT"))
                    fixMth = 0;

                if (_ExpDate != "1900-01-01" && mth <= fixMth)
                {
                    MessageBox.Show("Bellow "+fixMth.ToString()+" Month Expiry Not Allowed", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExpDate.Focus();
                    txtExpDate.SelectAll();
                    return;
                }

                if (date != "Fail")
                {
                    txtTrade.Focus();
                }
                else { txtExpDate.Focus(); txtExpDate.Select(); MessageBox.Show("Invalid Date", "ExPro Help"); return; }
            }
            catch (Exception ex) { txtExpDate.Focus(); }
        }
        private void lv_taxDetail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Escape)
            {
                txttaxId.Text = lv_taxDetail.FocusedItem.SubItems[0].Text;
                txtGST.Text = Convert.ToDecimal(lv_taxDetail.FocusedItem.SubItems[1].Text).ToString("###.00");
                lv_taxDetail.Visible = false;
                txttaxId.Select();
            }
        }
        private void txtQty_Enter(object sender, EventArgs e)
        {
            txtQty.Select();
        }
        private void txtExpDate_MouseClick(object sender, MouseEventArgs e)
        {
            txtExpDate.SelectAll();
        }
        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            _pressedKey = e.KeyValue;
            if ((e.KeyCode == Keys.Return | e.KeyCode == Keys.Down) && (lv_Product.Items.Count > 0 && txtProdName.Text.Length > 0))
            {
                lv_Product.Focus();
                lv_Product.Items[0].Selected = true;
            }
        }
        private void txtTrade_MouseClick(object sender, MouseEventArgs e)
        {
            txtTrade.SelectAll();
        }
        private void Search_SearchUpdated(object sender, SearchUpdatedEventArgs e)
        {
            this.txtPurchaseId.Text = e.ProductID;
        }
        private void Reset_FeedingForm(object sender, SearchUpdatedEventArgs e)
        {
            ResetFeedingForm();
        }
        private void txtPurchaseId_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid(txtPurchaseId.Text, "Info");
        }
        protected void RefreshGrid(string purchase_id, string CallFrom)
        {
            //Get Purchase Information Regarding given Purchase Id and unit
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (CallFrom != "Insert")
                {
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = purchase_id; p.logic = "PurchBillInfo"; p.prm_1 = "-"; p.prm_2 = "";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                    ds = dwr.result;
                    #region Vendor Information
                    if (CallFrom != "Delete" || CallFrom != "Insert")
                    {
                        //Third Table Information Of vendor
                        DataRow dr2 = ds.Tables[2].Rows[0];
                        _vendorCode = dr2["vendor_id"].ToString();
                        txtStockistName.Text = dr2["vendor_Name"].ToString();
                        txtStockistAddress.Text = dr2["address"].ToString();//dr2["city"].ToString() +
                        dr2 = ds.Tables[1].Rows[0];
                        if (dr2["order_no"].ToString().Length > 4)
                        {
                            chkLoadOrders.Checked = true;
                            cbxPurchOrder.FindString(dr2["order_no"].ToString());
                            cbxPurchOrder.Text = dr2["order_no"].ToString();
                            cmbOrderType.Text = dr2["orderType"].ToString();
                        }
                    }
                    #endregion
                }
                //To Fill The Detail From Local Table
                rgv_purchase.Rows.Clear();
                #region Purchase Items Info
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    AddRowToBillInfo(dr);
                }
                UpdateBillSummary(ds.Tables[1].Rows[0]);
                lbl_ItemNo.Text = "Item Nos: " + rgv_purchase.Rows.Count.ToString();
                if (rgv_purchase.Rows.Count > 0)
                    btnComplete.Enabled = true;
                #endregion


            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void UpdateBillSummary(DataRow dr)
        {
            #region Summary Of Purchase BIll
            txtInvoiceNo.Text = dr["inv_no"].ToString();
            this.txtPurchaseId.TextChanged -= new System.EventHandler(this.txtPurchaseId_TextChanged);
            txtPurchaseId.Text = dr["purch_id"].ToString();
            this.txtPurchaseId.TextChanged += new System.EventHandler(this.txtPurchaseId_TextChanged);
            dtInv_date.Value = Convert.ToDateTime(dr["bill_date"]);
            txtFinalTax.Text = Convert.ToDecimal(dr["inv_tax"]).ToString("##.00");
            txtAccu_Discount.Text = Convert.ToDecimal(dr["inv_discount"]).ToString("##.00");
            txtFinal_Total.Text = Convert.ToDecimal(dr["inv_total"]).ToString("##.00");
            txtFinal_Net.Text = Convert.ToDecimal(dr["netamount"]).ToString("##.00");
            txtAdjusted.Text = Convert.ToDecimal(dr["adj_amount"]).ToString("##0");
            txtRoundOff.Text = Convert.ToDecimal(dr["decpart"]).ToString("##.00");
            txtBillAmount.Text = Convert.ToDecimal(dr["roundoff"]).ToString("#####0");

            txtigst.Text = Convert.ToDecimal(dr["igst"]).ToString("#####.00");
            txtcgst.Text = Convert.ToDecimal(dr["cgst"]).ToString("#####.00");
            txtsgst.Text = Convert.ToDecimal(dr["sgst"]).ToString("#####.00");
            #endregion
        }



        private void txtInvDate_Enter(object sender, EventArgs e)
        {
            // txtInvDate.Select(0, 2);
        }
        protected string getExpDate(string txtDate)
        {
            if (txtDate.Length == 0)
            { MessageBox.Show("Enter date", "ExPro Help"); return "Fail"; }
            if (txtDate.Length > 0)
            {
                if (txtDate == "-")
                { _ExpDate = "1900-01-01"; return _ExpDate; }

                int dasCaount = 0;
                char[] Char1 = txtDate.ToCharArray(0, txtDate.Length);
                foreach (char s in Char1)
                {
                    if (s == '-') { dasCaount = dasCaount + 1; }
                }
                if (dasCaount == 0 || dasCaount > 1)
                { return "Fail"; }

                if (txtDate.Length > 5 || txtDate.Length < 5)
                { return "Fail"; }
                string[] t = txtDate.Split('-');
                if (t[0].Length > 2 || t[0].Length < 2)
                { return "Fail"; }
                if (t[1].Length > 2 || t[1].Length < 2)
                { return "Fail"; }
                try { if (Convert.ToInt32(t[0]) > 12) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                try { if (Convert.ToInt32(t[1]) > 1000) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                string century = DateTime.Now.ToString("yyyy").Substring(0, 2);
                _ExpDate = century + t[1] + '-' + t[0] + '-' + "01";
            }
            return _ExpDate;
        }
        private void txtExpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtTrade.Focus();
        }
        private void txtTrade_Enter(object sender, EventArgs e)
        {
            txtTrade.SelectAll();
        }
        private void txtMRP_Enter(object sender, EventArgs e)
        {
            txtMRP.SelectAll();
        }
        private void txtTrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtMRP.Focus();
        }
        private void txtMRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtQty.Focus();
        }
        private void txtFreeQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txttaxId.Focus();
        }
        private void txttaxId_Enter(object sender, EventArgs e)
        {
            txttaxId.SelectAll();
        }
        private void txtDis_Per_Enter(object sender, EventArgs e)
        {
            txtDis_Per.SelectAll();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtFreeQty.Focus();
        }

        private void txttaxId_Leave(object sender, EventArgs e)
        {
            if (IsNumeric(txtQty.Text) == true && IsNumeric(txtFreeQty.Text) == true)
            {
                txtAmount.Text = (Conversion.Val(txtTrade.Text) * Conversion.Val(txtQty.Text)).ToString("###.00");
            }
            else
            {
                txtQty.Focus();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //this.purchaseposting = new purchasePostingForm(txtPurchaseId.Text, txtStockistName.Text);
            //this.purchaseposting.PurchaseBillPosted += new PurchaseBillPostingEventHandler(PurchaseBill_PostingCompleted);
            //purchaseposting.Owner = this;
            //purchaseposting.Show();

            frmBillPostingPopup = new BillPostingPopup(txtPurchaseId.Text, Convert.ToInt32(txtAdjusted.Text), txtStockistName.Text, _vendorCode);
            this.frmBillPostingPopup.SearchUpdated += new SearchUpdateEventHandler(Reset_FeedingForm);
            frmBillPostingPopup.Owner = this;
            frmBillPostingPopup.Show();
        }
        private void PurchaseBill_PostingCompleted(object sender, PurchaseBillPostingEventArgs e)
        {
            if (e.result.Contains("Success"))
                ResetFeedingForm();
            else
            {
                MessageBox.Show(e.result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnComplete.Enabled = true;
            }
        }
        protected void ResetFeedingForm()
        {
            btnPackHelp.Enabled = false;
            txtStockistAddress.Text = "";
            txtStockistName.Text = "";
            txtInvoiceNo.Text = "";
            rbTax.Enabled = true;
            rgv_purchase.Rows.Clear();
            lv_Stockist.Items.Clear();
            txtAccu_Discount.Text = "0";
            txtAdjusted.Text = "0";
            txtFinal_Net.Text = "0";
            txtFinal_Total.Text = "0";
            txtFinalTax.Text = "0";
            txtRoundOff.Text = "0";
            txtBillAmount.Text = "0";
            this.txtPurchaseId.TextChanged -= new System.EventHandler(this.txtPurchaseId_TextChanged);
            txtPurchaseId.Text = "New Invoice";
            this.txtPurchaseId.TextChanged += new System.EventHandler(this.txtPurchaseId_TextChanged);
            txtStockistName.Text = "";
            btnComplete.Enabled = false;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFeedingForm();
        }
        private void txttaxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtDis_Per.Focus();
        }
        private void txtDis_Per_Leave(object sender, EventArgs e)
        {
            if (txtDis_Per.Text.Length == 0)
            {
                txtDis_Per.Text = "0";
            }
        }
        private void txtDis_Per_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtAmount.Focus();
        }
        private void txtMRP_MouseClick(object sender, MouseEventArgs e)
        {
            txtMRP.SelectAll();
        }
        private void txtQty_MouseClick(object sender, MouseEventArgs e)
        {
            txtQty.SelectAll();
        }

        private void txtFreeQty_MouseClick(object sender, MouseEventArgs e)
        {
            txtFreeQty.SelectAll();
        }

        private void txttaxId_MouseClick(object sender, MouseEventArgs e)
        {
            txttaxId.SelectAll();
        }

        private void txtDis_Per_MouseClick(object sender, MouseEventArgs e)
        {
            txtDis_Per.SelectAll();
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtAmount, "Press Enter Key To Save.");
        }

        protected void FillOrderInfo()
        {
            pm_PurchaseQueries p = new pm_PurchaseQueries();
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "OrderList"; p.prm_1 = "-"; p.prm_2 = "-";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

            cbxPurchOrder.DisplayMember = "order_no"; cbxPurchOrder.ValueMember = "order_no";
            cbxPurchOrder.DataSource = dwr.result.Tables[0]; dtInv_date.Value = DateTime.Now;
            //txtInvDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //Call Tax Id's List
            cmbOrderType.DisplayMember = "order_type"; cmbOrderType.ValueMember = "order_type";
            cmbOrderType.DataSource = dwr.result.Tables[0];
            txtStockistName.Enabled = true; cbxPurchOrder.Enabled = true; cmbOrderType.Enabled = true;
            txtStockistName.Select();
        }
        private void Purchase_Entry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ImportProductInfo UseForm = new ImportProductInfo();
                UseForm.Owner = this;
                UseForm.Show();
            }
            else if (e.Modifiers == Keys.ControlKey && e.KeyCode == Keys.N)
            {
                rgv_purchase.Rows.Clear();
                lv_Stockist.Items.Clear();
                txtAccu_Discount.Text = "0";
                txtAdjusted.Text = "0";
                txtFinal_Net.Text = "0";
                txtFinal_Total.Text = "0";
                txtFinalTax.Text = "0";
                txtRoundOff.Text = "0";
                txtBillAmount.Text = "0";
                txtPurchaseId.Text = "New Invoice";
                txtStockistName.Text = "";
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.frmPurchSearch = new PurchaseSearch("Bill");
                this.frmPurchSearch.SearchUpdated += new SearchUpdateEventHandler(Search_SearchUpdated);
                frmPurchSearch.Owner = this;
                frmPurchSearch.Show();
                GlobalUsage.Purchase_Id = "";
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.frmPurchSearch = new PurchaseSearch("Bill");
                this.frmPurchSearch.SearchUpdated += new SearchUpdateEventHandler(Search_SearchUpdated);
                frmPurchSearch.Owner = this;
                frmPurchSearch.Show();
                GlobalUsage.Purchase_Id = "";
            }
        }

        private void txtPlusMinus_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPlusMinus.Text != "-" && txtPlusMinus.Text.Length != 0)
            {
                txtBillAmount.Text = (Conversion.Val(txtBillAmount.Text) + Convert.ToInt32(txtPlusMinus.Text)).ToString();
            }
        }

        private void txtMRP_Leave(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(txtTrade.Text) > Convert.ToDecimal(txtMRP.Text))
            {
                MessageBox.Show("Trade is greater than MRP not Permitted.", "ExPro Help");
                txtMRP.Focus();
            }
        }

        private void dtInv_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtProdName.Select();
            }
        }

        private void txtBarCodeNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtHSN.Focus();
                txtHSN.SelectAll();
            }
        }

        private void txtBarCodeNo_Enter(object sender, EventArgs e)
        {
            txtBarCodeNo.SelectAll();
        }

        private void txtBatchNo_Enter(object sender, EventArgs e)
        {
            txtBatchNo.Focus();
            txtBatchNo.SelectAll();
        }
        private void txtAdjusted_Leave(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            if (IsNumeric(txtQty.Text) == false && IsNumeric(txtFreeQty.Text) == false)
            {
                MessageBox.Show("In case of Product Adjustment Only 0 will be accepted in Free Qty.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsNumeric(string s)
        {
            decimal x = 0;
            bool res = Decimal.TryParse(s, out x);
            return res;
        }
        private void txtFreeQty_Leave(object sender, EventArgs e)
        {
            if (IsNumeric(txtQty.Text) == true && IsNumeric(txtFreeQty.Text) == true)
            {
                decimal finalQty = Convert.ToDecimal(txtFreeQty.Text) + Convert.ToDecimal(txtQty.Text);
                if (Convert.ToDecimal(txtQty.Text) > 0)
                {
                    if (Convert.ToDecimal(txtFreeQty.Text) > (Convert.ToDecimal(txtQty.Text) * 5))
                    {
                        MessageBox.Show("Free Quantity > 5 Times of Absolute Qty.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFreeQty.Text = "0";
                        txtFreeQty.Focus();
                    }
                    else if (finalQty != Convert.ToInt32(finalQty))
                    {
                        MessageBox.Show("Fractional Quantity is Not Acceptable.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtQty.Text = "0"; txtFreeQty.Text = "0";
                        txtQty.Focus();
                    }
                }
            }
        }





        private void btnPackHelp_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.selectPackType = new packTypeSelection(_item_id);
            this.selectPackType.SelectPackType += new SelectPackTypeEventHandler(selectedPacktype);
            selectPackType.Owner = this;
            selectPackType.Show();
            Cursor.Current = Cursors.Default;
        }

        private void txtHSN_Enter(object sender, EventArgs e)
        {
            txtHSN.SelectAll();
        }


        private void txtHSN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtBatchNo.Focus();
        }

        private void txtHSN_Validating(object sender, CancelEventArgs e)
        {

        }
        public static bool IsCorrectHSN(string input)
        {
            decimal test;
            bool r1;
            r1 = decimal.TryParse(input, out test);
            if ((input.Length >= 4) && r1 == true) //|| input.Length == 8
                return true;
            else
                return false;

        }

        private void rgv_purchase_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show("Do You Confirm To Delete Selected Record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgresult.ToString() == "Yes")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string item_id = e.Row.Cells["item_id"].Value.ToString();
                    string auto_id = e.Row.Cells["auto_id"].Value.ToString();
                    decimal qty = Convert.ToDecimal(e.Row.Cells["qty"].Value) + Convert.ToDecimal(e.Row.Cells["it_free"].Value);
                    string po_no = "";
                    int Qty = (int)qty;
                    if (cbxPurchOrder.Text.Length > 5) { po_no = cbxPurchOrder.Text; } else { po_no = "N/A"; }
                    pm_PurchaseDelete p = new pm_PurchaseDelete();
                    p.unit_id = GlobalUsage.Unit_id; p.order_no = po_no; p.item_id = item_id; p.purch_id = txtPurchaseId.Text;
                    p.auto_id = auto_id; p.qty = Qty;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseDelPurchTran", p);
                    ds = dwr.result;
                    if (dwr.message.Contains("Success") && ds.Tables[0].Rows.Count > 0)
                    {
                        e.Row.Delete();
                        UpdateBillSummary(ds.Tables[0].Rows[0]);
                    }
                    else
                    { ResetFeedingForm(); }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    ResetFeedingForm();
                }
                finally { Cursor.Current = Cursors.Default; }
            }



        }

        private void chkLoadOrders_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (chkLoadOrders.Checked)
                {
                    FillOrderInfo();
                    gb_OrderInfo.Visible = true;
                }
                else
                { gb_OrderInfo.Visible = false; }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_IC_Gen_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult res = MessageBox.Show("Do You Confirm To Import Inter Company Bill ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    string sale_inv_no = ((AddValue)cmbIntCompNo.SelectedItem).Value;
                    if (sale_inv_no.Length < 10)
                    {
                        MessageBox.Show("Select Bill No. ", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        pm_BillInfo p = new pm_BillInfo();
                        p.unit_id = GlobalUsage.Unit_id; p.Bill_No = sale_inv_no; p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InterCompanyPurchaseEntry", p);
                        if (dwr.message.Contains("Success"))
                        {
                            cm1 p1 = new cm1();
                            p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                            p1.prm_1 = GlobalUsage.Login_Name; p1.prm_2 = GlobalUsage.Login_Name;
                            p1.Logic = "sale_master:BillImport"; p1.tran_id = sale_inv_no;
                            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                            cmbIntCompNo.Items.RemoveAt(cmbIntCompNo.SelectedIndex);
                        }
                        else if (dwr.message.Contains("Failed"))
                            cmbIntCompNo.Items.RemoveAt(cmbIntCompNo.SelectedIndex);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void chkLoadPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoadPurchase.Checked)
            {
                rdpPurchInfo.Visible = true;

            }
            else
                rdpPurchInfo.Visible = false;

        }

        private void selectedPacktype(object sender, SelectPackTypeEventArgs e)
        {
            txtPackSize.Text = e.PackType; txtPackQty.Text = e.PackQty.ToString();
            txtQty.Focus();
        }

        private void txtAdjusted_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                adjustGR useForm = new adjustGR(txtPurchaseId.Text, _vendorCode, Convert.ToDecimal(txtAdjusted.Text));
                useForm.Owner = this;
                useForm.Show();
            }
        }

        private void btn_grAdjustment_Click(object sender, EventArgs e)
        {
            adjustDebitNote useForm = new adjustDebitNote(txtPurchaseId.Text, _vendorCode, Convert.ToDecimal(txtAdjusted.Text), dtInv_date.Value.ToString("yyyy/MM/dd"), txtInvoiceNo.Text);
            useForm.Owner = this;
            useForm.Show();
        }

        private void MasterTemplate_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Permit_Flag"].Value != null)
            {
                if (e.RowElement.RowInfo.Cells["Permit_Flag"].Value.ToString() == "Y")
                    e.RowElement.ForeColor = Color.Green;
                else if (e.RowElement.RowInfo.Cells["Permit_Flag"].Value.ToString() == "R")
                    e.RowElement.ForeColor = Color.Red;
            }
        }


        protected void FillLastXPurchases(string itemid)
        {

            lv_lastpurinfo.Items.Clear();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "LastPurchaseId"; p.prm_1 = itemid; p.prm_2 = "";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                var table = dwr.result.Tables[0];
                DataRow[] drary = table.Select();
                foreach (DataRow dr in drary)
                {
                    ListViewItem ls = new ListViewItem(itemid);
                    ls.SubItems.Add(dr["purch_id"].ToString());
                    ls.SubItems.Add(dr["batch_no"].ToString());
                    if (dr["exp_date"].ToString() != "01-01-1900")
                        ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                    else
                        ls.SubItems.Add("-");
                    ls.SubItems.Add(Convert.ToDecimal(dr["ptr"]).ToString("####.00"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("####.00"));
                    ls.SubItems.Add(dr["pack_type"].ToString());
                    ls.SubItems.Add(dr["pack_qty"].ToString());
                    ls.SubItems.Add(Convert.ToDecimal(dr["purch_qty"]).ToString("####"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["free"]).ToString("####.00"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["taxrate"]).ToString("####.00"));
                    ls.SubItems.Add(Convert.ToDecimal(dr["disper"]).ToString("####.00"));
                    ls.SubItems.Add(dr["vend_info"].ToString());
                    ls.SubItems.Add(dr["cr_date"].ToString());
                    lv_lastpurinfo.Items.Add(ls);
                }
                //if (lv_lastpurinfo.Items.Count > 0)
                //    lv_lastpurinfo.Visible = true;
                //else
                //    lv_lastpurinfo.Visible = false;
            }
            catch (Exception ex)
            { }
            finally { Cursor.Current = Cursors.Default; }
        }


    } //Second Last Brace
} //Last Brace

