using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class DebitNote_Entries : Telerik.WinControls.UI.RadForm
    {
        int _pressedKeyCode = 0;
        private PurchaseSearch purchasesearch;
        DataTable _tempTable = new DataTable(); DataSet ds = new DataSet();
        string _CrLedgerCode, _CrLedgerName;
        string _ItemId, _vendorCode;
        Int32 _year = DateTime.Now.Year; decimal _mrp = 0; decimal _ptr = 0; int _acceptedQty = 0;
        string _ExpDate = string.Empty; string _result = string.Empty; string _invType = string.Empty;
        private packTypeSelection selectPackType;
        public DebitNote_Entries()
        {
            InitializeComponent();
        }
        public void clearall()
        {
            txtQty.Text = "0";
            btnPackHelp.Enabled = false;
            txtProdName.TextChanged -= new EventHandler(txtProdName_TextChanged);
            txtProdName.Text = "";
            txtProdName.TextChanged += new EventHandler(txtProdName_TextChanged);
            txtBatchNo.Text = "";
            txtExpDate.Text = "";
            txtFreeQty.Text = "0";
            txtMRP.Text = "";
            txtPackQty.Text = "";
            txtPackSize.Text = "";
            txtDis_Per.Text = "0";
            txtTrade.Text = "0";
            txtAmount.Text = "";
        }
        private void txtStockistName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.KeyChar == 13)
            {
                lv_Stockist.Location = new System.Drawing.Point(102, 66);
                lv_Stockist.Size = new System.Drawing.Size(533, 75);
                lv_Stockist.Visible = true;
                lv_Stockist.Items.Clear();
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "VendorSearch"; p.prm_1 = txtStockistName.Text; p.prm_2 = "-";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                    DataRow[] drary = dwr.result.Tables[0].Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["vendor_id"].ToString());
                        ls.SubItems.Add(dr["vendor_Name"].ToString());
                        ls.SubItems.Add(dr["City"].ToString());
                        ls.SubItems.Add(dr["Address"].ToString());
                        lv_Stockist.Items.Add(ls);
                    }

                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
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
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "TaxIds"; p.prm_1 =GlobalUsage.State; p.prm_2 = "-";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
            if (dwr.result.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dwr.result.Tables[0].Rows)
                {
                    ListViewItem ls = new ListViewItem(dr["tax_id"].ToString());
                    ls.SubItems.Add(dr["tax_rate"].ToString());
                    ls.SubItems.Add(dr["tax_detail"].ToString());
                    lv_taxDetail.Items.Add(ls);
                    if (dr["defa_flag"].ToString().ToUpper() == "D")
                        txttaxId.Text = dr["tax_id"].ToString();
                }
            }
        }
        private void Purchase_Entry_Load(object sender, EventArgs e)
        {
            //Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            //int size = (rec.Size.Width - this.Width) / 2;
            //this.Location = new System.Drawing.Point(size, 165);
            FillOrderInfo(); fillTax(); initializeTable();
            txtInvDate.Value = DateTime.Now;
            _invType = "C";
        }
        protected void initializeTable()
        {
            _tempTable.Columns.Add("auto_id", typeof(string));
            _tempTable.Columns.Add("Seq_no", typeof(string));
            _tempTable.Columns.Add("item_id", typeof(string));
            _tempTable.Columns.Add("hsn", typeof(string));
            _tempTable.Columns.Add("item_name", typeof(string));
            _tempTable.Columns.Add("batch_no", typeof(string));
            _tempTable.Columns.Add("exp_date", typeof(string));
            _tempTable.Columns.Add("trade", typeof(decimal));
            _tempTable.Columns.Add("mrp", typeof(decimal));
            _tempTable.Columns.Add("qty", typeof(decimal));
            _tempTable.Columns.Add("it_free", typeof(decimal));
            _tempTable.Columns.Add("tax_id", typeof(int));
            _tempTable.Columns.Add("tax_rate", typeof(decimal));
            _tempTable.Columns.Add("pack_type", typeof(string));
            _tempTable.Columns.Add("pack_qty", typeof(int));
            _tempTable.Columns.Add("disper", typeof(decimal));
            _tempTable.Columns.Add("amount", typeof(decimal));
            _tempTable.Columns.Add("status_flag", typeof(string));
            _tempTable.Columns.Add("barcode_no", typeof(string));
        }
        protected void FillOrderInfo()
        {

            txtStockistName.Select();
        }
        private void txtInvoiceNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtInvDate.Select();
                txtInvDate.Focus();
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
            if (txtProdName.TextLength > 2 && _pressedKeyCode != (int)Keys.Back)
            {
                if (lv_Product.Visible == false)
                {
                    lv_Product.Location = new System.Drawing.Point(3, 202);
                    lv_Product.Size = new System.Drawing.Size(500, 259);
                    lv_Product.Visible = true;
                }
                lv_Product.Items.Clear();

                try
                {
                    pm_debitCreditNotes p = new pm_debitCreditNotes();
                    p.unit_id = GlobalUsage.Unit_id; p.logic = "All-ProductofVendor";p.vendor_id = _vendorCode; p.searchkey=txtProdName.Text;

                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);

                    DataRow[] drary = dwr.result.Tables[0].Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
                        ls.SubItems.Add(dr["mfd_Name"].ToString());
                        ls.SubItems.Add(dr["qty"].ToString());

                        lv_Product.Items.Add(ls);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help");
                }
            }
            Cursor.Current = Cursors.Arrow;
        }
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {

                txtHSN.Text = lv_Product.FocusedItem.SubItems[3].Text;
                _ItemId = lv_Product.FocusedItem.SubItems[0].Text;
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                btnPackHelp.Enabled = true;

                lv_Product.Visible = false;
                txtHSN.Focus();
            }
        }

        private void txtBatchNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                txtBarCode.Focus();

            string[] r;
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    #region Process Body
                    Cursor.Current = Cursors.WaitCursor;
                    string inv_Date = Convert.ToDateTime(txtInvDate.Text).ToString("yyyy-MM-dd");
                    pm_CheckBatchInfo p = new pm_CheckBatchInfo();
                    p.unit_id = GlobalUsage.Unit_id; p.item_id = _ItemId; p.batch_no = txtBatchNo.Text;p.logic = "ForDebitNote";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CheckBatchInfo", p);
                    _result = dwr.message;
                   
                    txtExpDate.Select();
                    r = _result.Split('$'); _mrp = 0; _ptr = 0;
                    txtPackSize.Text = r[1].ToString();
                    txtPackQty.Text = r[2].ToString();
                    if (r[0].ToString() == "Not Found")
                    {
                        txtPackSize.Text = r[1].ToString();
                        txtPackQty.Text = r[2].ToString();
                        if (r.Length > 4)
                        {
                            _mrp = Convert.ToDecimal(r[3].ToString());
                            _ptr = Convert.ToDecimal(r[4].ToString());
                            string[] d = r[0].Split('.');
                            txtExpDate.Text = d[1] + "-" + d[0];
                            txtMRP.Text = Convert.ToDecimal(r[3]).ToString("###.00");
                            txtTrade.Text = Convert.ToDecimal(r[4]).ToString("###.00");
                            txtQty.Text = r[7].ToString();
                        }
                        txtExpDate.Focus();
                    }
                    else
                    {
                         string[] d = r[0].Split('.');
                         txtExpDate.Text = d[1] + "-" + d[0];
                        _mrp = Convert.ToDecimal(r[3].ToString());
                        _ptr = Convert.ToDecimal(r[4].ToString());
                        txtMRP.Text = r[3].ToString();
                        txtTrade.Text = r[4].ToString();
                        txtPackSize.Text = r[1].ToString();
                        txtPackQty.Text = r[2].ToString();
                        txttaxId.Text = r[6].ToString();
                        txtQty.Text = r[7].ToString();
                    }
                    if (r.Length > 4)
                    {
                        _acceptedQty = Convert.ToInt16(r[7].ToString());
                    }
                    if (_mrp == 0)
                    {
                        this.toolTip1.SetToolTip(this.txtTrade, "N/A");
                        this.toolTip1.SetToolTip(this.txtMRP, "N/A");
                    }
                    else
                    {
                        this.toolTip1.SetToolTip(this.txtTrade, "Trade : " + _ptr.ToString("###.00"));
                        this.toolTip1.SetToolTip(this.txtMRP, "MRP : " + _mrp.ToString("###.00"));
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help");
                }
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
                lv_taxDetail.Items.Clear();
                fillTax();
                lv_taxDetail.Location = new System.Drawing.Point(669, 191);
                lv_taxDetail.Size = new System.Drawing.Size(328, 248);
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

            string invType = string.Empty;
            decimal StkQty = 0;

            if (e.KeyCode == Keys.Return)
            {
                if (!IsCorrectHSN(txtHSN.Text))
                {
                    MessageBox.Show("HSN Code should be 4 digit or 8 Digit.", "ExPro Help", MessageBoxButtons.OK);
                    txtHSN.Focus();
                    return;
                }
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    //lv_lastpurinfo.Visible = false;
                    StkQty = (Conversion.Val(txtFreeQty.Text) + Conversion.Val(txtQty.Text)) * Conversion.Val(txtPackQty.Text);
                    bool mrpCheckOk = Convert.ToDecimal(txtMRP.Text) > (Convert.ToDecimal(txtTrade.Text) + (Convert.ToDecimal(txtTrade.Text) * (40 / 100))) ? true : false;
                    string mrpCaution = "";
                    DialogResult dRes = DialogResult.Yes;
                    if (!mrpCheckOk)
                    {
                        mrpCaution = "MRP is 40% Greater Than Trade.\nDo You Confirm (Y/N)";
                        dRes = MessageBox.Show(mrpCaution, "ExPro Help", MessageBoxButtons.RetryCancel);
                        return;
                    }
                    #region Saving Process
                    if (MessageBox.Show("Stock will be Update by " + StkQty.ToString() + " Quantity", "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes && dRes.ToString() == "Yes")
                    {
                        invType = "C"; // Credit Note,
                        Cursor.Current = Cursors.WaitCursor;
                        //CAlling Of Web Service To Insert Records
                        string token = "";
                       
                        pm_debitCreditNotes p = new pm_debitCreditNotes();
                        p.unit_id = GlobalUsage.Unit_id;p.Note_No = txtPurchaseId.Text;p.vendor_id = _vendorCode;
                        p.inv_no = txtInvoiceNo.Text;p.inv_date = Convert.ToDateTime(txtInvDate.Text).ToString("yyyy/MM/dd");
                        p.item_id = _ItemId;p.hsn = txtHSN.Text;p.batch_no = txtBatchNo.Text;p.qty = Convert.ToInt16(txtQty.Text);
                        p.discount = Convert.ToDecimal(txtDis_Per.Text);p.taxid = Convert.ToInt16(txttaxId.Text);
                        p.expdate = _ExpDate;p.mrp = Convert.ToDecimal(txtMRP.Text);p.ptr = Convert.ToDecimal(txtTrade.Text);
                        p.pack_type = txtPackSize.Text;p.pack_qty = Convert.ToInt16(txtPackQty.Text);p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteTranInsert", p);
                        ds = dwr.result;
                        if (ds.Tables.Count == 2)
                        {
                            // Add Row in Table
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow dr;
                                dr = ds.Tables[0].Rows[0];
                                _tempTable.Rows.Add(
                                    dr["auto_id"].ToString(), dr["auto_id"].ToString(), dr["item_id"].ToString(), dr["hsn"].ToString(),
                                    dr["item_name"].ToString(), dr["batch_no"].ToString(), Convert.ToDateTime(dr["exp_date"]).ToString("yyyy/MM/dd"),
                                    Convert.ToDecimal(dr["trade"]), Convert.ToDecimal(dr["mrp"]), Convert.ToDecimal(dr["qty"]),
                                    Convert.ToDecimal(dr["it_free"]), Convert.ToInt16(dr["tax_id"]), Convert.ToDecimal(dr["tax_rate"]), dr["pack_type"].ToString(),
                                    Convert.ToInt16(dr["pack_qty"]), Convert.ToDecimal(dr["disper"]), Convert.ToDecimal(dr["amount"]),
                                    dr["status_flag"].ToString(), dr["barcode_no"].ToString()
                                    );
                                if (!token.Contains("Allow"))
                                    MessageBox.Show(token, "Insert Result of " + dr["item_name"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            //token =ds.Tables[1].Rows[0]["result"].ToString();
                            if (txtPurchaseId.Text.ToLower() == ("New Debit Note").ToLower())
                            {
                                this.txtPurchaseId.TextChanged -= new System.EventHandler(this.txtPurchaseId_TextChanged);
                                txtPurchaseId.Text = ds.Tables[1].Rows[0]["debitNote_No"].ToString();
                                this.txtPurchaseId.TextChanged += new System.EventHandler(this.txtPurchaseId_TextChanged);
                            }
                            RefreshGrid(txtPurchaseId.Text, "Insert");
                            clearall();

                        } //End Of Ds Table Chaking

                        txtAmount.KeyUp -= new KeyEventHandler(txtAmount_KeyUp);
                        txtProdName.Focus();
                        txtProdName.Select();
                        txtAmount.KeyUp += new KeyEventHandler(txtAmount_KeyUp);

                    }
                    #endregion
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }

        }
        public static bool IsCorrectHSN(string input)
        {
            decimal test;
            bool r1;
            r1 = decimal.TryParse(input, out test);
            if ((input.Length == 4 || input.Length == 8) && r1 == true)
                return true;
            else
                return false;

        }
        protected void Fill_Bill_Info(DataSet _ds)
        {
            DataRow row;
            lv_PurchBillInfo.Items.Clear();
            _tempTable.DefaultView.Sort = "auto_id DESC";
            foreach (DataRow dr in _tempTable.Rows)
            {
                #region Grid Filling Process
                AddRowToBillInfo(dr);
                #endregion
            }
            lbl_ItemNo.Text = "No. of Item In Bill : " + lv_PurchBillInfo.Items.Count.ToString();
            //Summary Of Purchase BIll
            if (_ds.Tables[0].Rows.Count > 0)
            {
                row = ds.Tables[1].Rows[0];
                txtInvoiceNo.Text = row["inv_no"].ToString();
                txtPurchaseId.Text = row["debitNote_No"].ToString();


                txtInvDate.Text = Convert.ToDateTime(row["bill_date"]).ToString("dd-MM-yyyy");
                txtFinalTax.Text = Conversion.Val(row["inv_tax"].ToString()).ToString();
                txtAccu_Discount.Text = Conversion.Val(row["inv_discount"].ToString()).ToString();
                txtFinal_Total.Text = Conversion.Val(row["inv_total"].ToString()).ToString();
                txtFinal_Net.Text = Conversion.Val(row["netamount"].ToString()).ToString();
                txtRoundOff.Text = (Conversion.Val(row["netamount"].ToString()) - Conversion.Val(row["roundoff"].ToString())).ToString();
                txtigst.Text = Conversion.Val(row["igst"].ToString()).ToString("####.00");
                txtcgst.Text = Conversion.Val(row["cgst"].ToString()).ToString("####.00");
                txtsgst.Text = Conversion.Val(row["sgst"].ToString()).ToString("####.00");
                txtBillAmount.Text = Conversion.Val(row["roundoff"].ToString()).ToString();
                string voucher_no = row["voucher_no"].ToString();
                if (voucher_no != "N/A")
                    btnComplete.Enabled = false;

                if (row["inv_type"].ToString() == "C")
                    rbSI.Checked = true;
            }
            else
            {
                ResetFeeding();
            }
        }
        private void AddRowToBillInfo(DataRow dr)
        {
            ListViewItem ls = new ListViewItem(dr["barcode_no"].ToString());
            #region Lv Coloring
            ls.ForeColor = Color.Maroon;
            if (dr["status_flag"].ToString() == "R")
            {
                ls.ForeColor = Color.Red;
                ls.Font = new Font("Arial Narrow", 10, FontStyle.Bold);
            }
            else if (dr["status_flag"].ToString() == "H")
            {
                ls.ForeColor = Color.DarkGreen;
                ls.Font = new Font("Arial Narrow", 10, FontStyle.Bold);
            }
            #endregion
            ls.SubItems.Add(dr["item_id"].ToString());
            ls.SubItems.Add(dr["item_name"].ToString());
            ls.SubItems.Add(dr["barcode_no"].ToString());
            ls.SubItems.Add(dr["hsn"].ToString());
            ls.SubItems.Add(dr["batch_no"].ToString());
            if (dr["exp_date"].ToString() != "01-01-1900")
                ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
            else
                ls.SubItems.Add("-");
            ls.SubItems.Add(Convert.ToDecimal(dr["trade"]).ToString("##.00"));
            ls.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("##.00"));
            ls.SubItems.Add(dr["pack_type"].ToString());
            ls.SubItems.Add(Convert.ToDecimal(dr["pack_qty"]).ToString("##"));
            ls.SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("##.00"));
            ls.SubItems.Add(Convert.ToDecimal(dr["it_free"]).ToString("##.00"));
            ls.SubItems.Add(Convert.ToDecimal(dr["tax_id"]).ToString("##"));
            ls.SubItems.Add(Convert.ToDecimal(dr["tax_rate"]).ToString("##.00"));
            ls.SubItems.Add(Convert.ToDecimal(dr["disper"]).ToString("##.00"));
            ls.SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("##.00"));
            lv_PurchBillInfo.Items.Add(ls);
        }
        private void txtExpDate_Leave(object sender, EventArgs e)
        {
            string date = getExpDate(txtExpDate.Text);
            if (GlobalUsage.Rights != "Admin")
            {
                DateTime xpDate_Permit = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/01"));
                DateTime xpDate_input = Convert.ToDateTime(_ExpDate);
                TimeSpan ts = xpDate_input - xpDate_Permit;
                int mth = ts.Days / 30;

                if (_ExpDate != "1900-01-01" && mth < 2)
                {
                    MessageBox.Show("Bellow 6 Month Expiry Not Allowed", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExpDate.Focus();
                    return;
                }
            }
            if (date != "Fail")
            {
                txtTrade.Focus();
            }
            else { txtExpDate.Focus(); txtExpDate.Select(); MessageBox.Show("Invalid Date", "ExPro Help"); return; }
        }

        private void lv_taxDetail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Escape)
            {
                txttaxId.Text = lv_taxDetail.FocusedItem.SubItems[0].Text;
                txtGST.Text = lv_taxDetail.FocusedItem.SubItems[1].Text;
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
            _pressedKeyCode = e.KeyValue;
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




        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Search_SearchUpdated(object sender, SearchUpdatedEventArgs e)
        {
            // Update the text box on this form (the parent) with the new value
            this.txtPurchaseId.Text = e.ProductID;

        }

        private void txtPurchaseId_TextChanged(object sender, EventArgs e)
        {

            if (GlobalUsage.Purchase_Id.ToLower() != ("New Debit Note").ToLower())
            {
                Cursor.Current = Cursors.WaitCursor;
                ds.Tables.Clear(); _tempTable.Rows.Clear();
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id =txtPurchaseId.Text; p.logic = "DebitNoteInfo"; p.prm_1 = "-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                ds = dwr.result;
                if (ds.Tables[1].Rows.Count > 0)
                    btnComplete.Enabled = true;
                RefreshGrid(txtPurchaseId.Text, "Info");
                Cursor.Current = Cursors.Default;
            }

        }

        protected void RefreshGrid(string purchase_id, string CallFrom)
        {
            DataRow dr;
            //Get Purchase Information Regarding given Purchase Id and unit

            if (ds.Tables.Count >= 2)
            {
                #region Fill Virtual Data Table
                if (CallFrom == "Info")
                {
                    #region Fill Vendor Info
                    dr = ds.Tables[2].Rows[0];
                    _vendorCode = dr["vendor_code"].ToString();
                    txtStockistName.Text = dr["vendor_Name"].ToString();
                    txtStockistAddress.Text = dr["address"].ToString();

                    #endregion

                    foreach (DataRow dr1 in ds.Tables[0].Rows)
                    {
                        _tempTable.Rows.Add(
                            dr1["auto_id"].ToString(), dr1["Seq_no"].ToString(), dr1["item_id"].ToString(), dr1["hsn"].ToString(),
                            dr1["item_name"].ToString(), dr1["batch_no"].ToString(), Convert.ToDateTime(dr1["exp_date"]).ToString("yyyy/MM/dd"),
                            Convert.ToDecimal(dr1["trade"]), Convert.ToDecimal(dr1["mrp"]), Convert.ToDecimal(dr1["qty"]),
                            Convert.ToDecimal(dr1["it_free"]), Convert.ToInt16(dr1["tax_id"]), Convert.ToDecimal(dr1["tax_rate"]), dr1["pack_type"].ToString(),
                            Convert.ToInt16(dr1["pack_qty"]), Convert.ToDecimal(dr1["disper"]), Convert.ToDecimal(dr1["amount"]),
                            dr1["status_flag"].ToString(), dr1["barcode_no"].ToString()
                            );
                    }

                }
                #endregion
                Fill_Bill_Info(ds);
            }

        }
        private void lv_PurchBillInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dlgresult = MessageBox.Show("Do You Confirm to delete " + lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[2].Text + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgresult.ToString() == "Yes")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string item_id = lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[1].Text;
                    string master_key_id = lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[0].Text;
                    decimal qty = Convert.ToDecimal(lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[10].Text) + Convert.ToDecimal(lv_PurchBillInfo.Items[lv_PurchBillInfo.FocusedItem.Index].SubItems[11].Text);
                    string po_no = "";
                    int Qty = (int)qty;

                    pm_PurchaseDelete p1 = new pm_PurchaseDelete();
                    p1.unit_id = GlobalUsage.Unit_id;p1.item_id = item_id;p1.purch_id = txtPurchaseId.Text;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitCreditTranDelete", p1);
                    if (dwr.message.Contains("Success"))
                    {
                        string exp = string.Empty; exp = "barcode_no='" + master_key_id+"'";
                        DataRow[] dr = _tempTable.Select(exp);
                        _tempTable.Rows.Remove(dr[0]);
                        _tempTable.AcceptChanges();
                        pm_PurchaseQueries p = new pm_PurchaseQueries();
                        p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = txtPurchaseId.Text; p.logic = "PurchBillInfo"; p.prm_1 = "-"; p.prm_2 = "-";
                        dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                        ds = dwr.result;
                        if (ds.Tables.Count == 0)
                        {
                            ResetFeeding();
                        }
                        else
                            RefreshGrid(txtPurchaseId.Text, "Delete");
                    }
                    else
                        MessageBox.Show(dwr.message);
                }
                Cursor.Current = Cursors.Default;
            }
        }
        private void txtInvDate_Enter(object sender, EventArgs e)
        {
            //txtInvDate.Select(0, 2);
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
            txtTrade.Select();
        }
        private void txtMRP_Enter(object sender, EventArgs e)
        {
            txtMRP.Select();
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
            txttaxId.Select();
        }
        private void txtDis_Per_Enter(object sender, EventArgs e)
        {
            txtDis_Per.Select();
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtFreeQty.Focus();
        }
        private void txttaxId_Leave(object sender, EventArgs e)
        {
            txtAmount.Text = (Convert.ToDecimal(txtTrade.Text) * Convert.ToDecimal(txtQty.Text)).ToString("###.00");
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            btnComplete.Enabled = false;

            try
            {
                DialogResult res = MessageBox.Show("Do You Confirm To Complete (Y/N)", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_debitCreditNotes p = new pm_debitCreditNotes();
                    p.unit_id = GlobalUsage.Unit_id;p.entryDate = txtInvDate.Value.ToString("yyyy/MM/dd");
                    p.Note_No = txtPurchaseId.Text;p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteTranPosting", p);
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    ResetFeeding();
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        protected void ResetFeeding()
        {
            lv_PurchBillInfo.Items.Clear();
            lv_Stockist.Items.Clear();
            txtAccu_Discount.Text = "0";

            txtFinal_Net.Text = "0";
            txtFinal_Total.Text = "0";
            txtFinalTax.Text = "0";
            txtRoundOff.Text = "0";
            txtBillAmount.Text = "0";
            this.txtPurchaseId.TextChanged -= new System.EventHandler(this.txtPurchaseId_TextChanged);
            txtPurchaseId.Text = "New Debit Note";
            this.txtPurchaseId.TextChanged += new System.EventHandler(this.txtPurchaseId_TextChanged);
            txtStockistName.Text = "";
            txtInvoiceNo.Text = "";
            txtStockistAddress.Text = "";
            clearall();
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

        private void txtFreeQty_Leave(object sender, EventArgs e)
        {
            if (txtFreeQty.Text.Length == 0)
            {
                txtFreeQty.Text = "0";
            }
        }


        private void txtMRP_Leave(object sender, EventArgs e)
        {
            if (rbSI.Checked && txtTrade.Text == "0")
                txtTrade.Text = (Convert.ToDecimal(txtMRP.Text) / 2).ToString("###.00");
            if (Convert.ToDecimal(txtMRP.Text) < Convert.ToDecimal(txtTrade.Text))
            {
                MessageBox.Show("MRP < TRADE)", "MRP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMRP.Focus();
            }
            else if (Convert.ToDecimal(txtMRP.Text) != _mrp && !rbSI.Checked)
            {
                if (MessageBox.Show("Do You Not Confirm ?\nBecause Old MRP was " + _mrp.ToString("#####.00") + " and Current MRP is  " + txtMRP.Text + " ", "MRP Checking", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtMRP.Focus();
                }
            }
        }
        private void Purchase_Entry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.purchasesearch = new PurchaseSearch("DebitNote");
                this.purchasesearch.SearchUpdated += new SearchUpdateEventHandler(Search_SearchUpdated);
                purchasesearch.Owner = this;
                purchasesearch.Show();
            }
        }

        private void txtBarCode_Enter(object sender, EventArgs e)
        {
            txtBarCode.SelectAll();
        }

        private void txtBarCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtHSN.Focus();
        }

        private void txtBatchNo_Enter(object sender, EventArgs e)
        {
            txtBatchNo.SelectAll();
        }



        private void txtExpDate_Enter(object sender, EventArgs e)
        {
            txtExpDate.SelectAll();
        }



        private void lv_Stockist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            if (rbSI.Checked && Convert.ToInt16(txtQty.Text) > _acceptedQty)
            {
                MessageBox.Show(_acceptedQty.ToString() + " Permited Only", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtHSN_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txttaxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcgst_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnPackHelp_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.selectPackType = new packTypeSelection(_ItemId);
            this.selectPackType.SelectPackType += new SelectPackTypeEventHandler(selectedPacktype);
            selectPackType.Owner = this;
            selectPackType.Show();
            Cursor.Current = Cursors.Default;
        }

        private void chkVendorSupplied_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVendorSupplied.Checked)
                chkVendorSupplied.Text = "Only Vendor Supplied";
            else
            chkVendorSupplied.Text = "Any vendor's Product";

        }

        private void txtHSN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtBatchNo.Focus();
        }


        private void selectedPacktype(object sender, SelectPackTypeEventArgs e)
        {
            txtPackSize.Text = e.PackType; txtPackQty.Text = e.PackQty.ToString();
            txtQty.Focus();
        }


    } //Second Last Brace
} //Last Brace

