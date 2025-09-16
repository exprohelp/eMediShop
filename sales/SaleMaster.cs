using ExPro.Client;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.sales
{
    public partial class SaleMaster : Telerik.WinControls.UI.RadForm
    {
        private CashMemoSearch frmCashMemoSearch;
        private SaleBill_Posting frmsaleBillPosting;
        public event CashCounterEventHandler CashCounterUpdated;
        ucHealthCardNew HealthCardHelp;
        forms.HealthCards.ucHealthCardStockRegister HealthCardStockRegister;
        public SetParameterValueDeligate callBackSetParameterValue;
        DataSet _ds = new DataSet();
        DataTable dtSwipeMacInfo = new DataTable();
        string _result = string.Empty; string _holdFlag = "N"; int _retPermitQty = 0;
        string _MasterKeyId = string.Empty;
        string _SelectedItem_Id = string.Empty; string _ProductName = string.Empty; string _creditFlag = string.Empty;
        string _BatchNo = string.Empty; string _SaleType = string.Empty;
        decimal _Mrp = 0; string _cardNo = string.Empty;
        decimal _UnitSaleRate = 0; decimal _discountPercntage = 0;
        string _ExpDate = string.Empty; string _mobileNo = string.Empty;
        string _PayMode = "Cash"; string _CardType = "Health";
        DataTable _tempTable = new DataTable();
        DataTable _healthcard = new DataTable();
        string _refCode = string.Empty; string _orderNo = "N/A";
        string _CardChangeFlag = "N"; string _CallFrom = string.Empty;
        decimal _Qty = 0; string _Lock_Flag = "N"; string _estimateNo = string.Empty;
        public SaleMaster(string CallFrom, string refSaleInvNo)
        {
            _CallFrom = CallFrom;
            InitializeComponent();
            #region Add Table
            _tempTable.Columns.Add("sale_inv_no", typeof(string));
            _tempTable.Columns.Add("sale_trn_no", typeof(string));
            _tempTable.Columns.Add("item_id", typeof(string));
            _tempTable.Columns.Add("item_name", typeof(string));
            _tempTable.Columns.Add("master_key_id", typeof(string));
            _tempTable.Columns.Add("batch_no", typeof(string));
            _tempTable.Columns.Add("pack_type", typeof(string));
            _tempTable.Columns.Add("pack_qty", typeof(Int32));
            _tempTable.Columns.Add("exp_date", typeof(DateTime));
            _tempTable.Columns.Add("mrp", typeof(decimal));
            _tempTable.Columns.Add("sv", typeof(decimal));
            _tempTable.Columns.Add("tax_id", typeof(string));
            _tempTable.Columns.Add("sale_qty", typeof(decimal));
            _tempTable.Columns.Add("usr", typeof(decimal));
            _tempTable.Columns.Add("igst", typeof(decimal));
            _tempTable.Columns.Add("sgst", typeof(decimal));
            _tempTable.Columns.Add("cgst", typeof(decimal));
            #endregion
            if (refSaleInvNo.Contains("E"))
                _holdFlag = "Y";
            txtInvNo.Text = refSaleInvNo;
            _estimateNo = refSaleInvNo;
        }
        private void SaleMaster_Load(object sender, EventArgs e)
        {

            _SaleType = "N";
            lblCurDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            chkReturnMemo.Enabled = true;
            txtOldCashMemoNo.Enabled = true;
            this.Text = "{Sales Master " + DateTime.Now.ToString("dd-MM-yyyy") + "}  Key Control: F2:Search Bill, Ctrl+H or F3: Search Unposted Bill, Ctrl+N: New Bill";
            txtCardNo.Focus();

            GlobalUsage.Old_Sale_Inv_No = "N/A";
            HealthCardStockRegister = new forms.HealthCards.ucHealthCardStockRegister();
            rp_CardStock.Controls.Add(HealthCardStockRegister);

            if (_CallFrom == "Cash Counter")
                btnBillPosting.PerformClick();
        }


        private void txtMedName_TextChanged(object sender, EventArgs e)
        {
            if (txtMedName.Text.Length > 2)
            {
                GetProductHelp(txtMedName.Text, "Search");
            }
            else if (txtMedName.Text.Length == 0)
            {
                itemhelpgrid.Visible = false;
            }
        }

        private void GetProductHelp(string ProductSearch, string CallFrom)
        {
            string jsonString = string.Empty;
            itemhelpgrid.Items.Clear();
            itemhelpgrid.BeginUpdate();
            if (CallFrom == "Substitute")
                itemhelpgrid.Columns[2].Text = "Sub. of " + _ProductName;
            else
                itemhelpgrid.Columns[2].Text = "Name of Medicine/Item";
            ListViewItem lvi;
            //WebAPI
            Search p = new Search();
            p.unit_id = GlobalUsage.Unit_id; p.SearchKey = ProductSearch;
            if (chkSubstitute.Checked)
                p.Logic = "All-SUB";
            else if (chkBySalt.Checked)
                p.Logic = "BySaltname";
            else if (CallFrom == "Substitute")
                p.Logic = "WithGeneric";
            else
                p.Logic = "All-Product";
            p.LoginId = GlobalUsage.Login_id; p.Prm_1 = "-";

            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductHelp", p);
            if (dwr.result.Tables[0].Rows.Count > 0)
            {
                itemhelpgrid.Visible = true;
                #region Filling Item Help Grid
                //DataRow[] drary = JsonConvert.DeserializeObject< dwr.data.Tables[0]> (jsonString).Select();
                string temp = string.Empty;
                foreach (DataRow dr in dwr.result.Tables[0].Rows)
                {

                    lvi = new ListViewItem(dr["item_id"].ToString());
                    lvi.SubItems.Add(dr["qty"].ToString());
                    lvi.SubItems.Add(dr["item_name"].ToString());
                    lvi.SubItems.Add(dr["mfd_name"].ToString());
                    lvi.SubItems.Add(dr["shelf_no"].ToString());
                    lvi.SubItems.Add(dr["FrontDesk_Alert"].ToString());
                    if (CallFrom == "Search")
                    {
                        if (dr["FrontDesk_Alert"].ToString().Length > 2)
                            lvi.ForeColor = Color.Red;
                        else if (dr["SeqNo"].ToString() == "0")
                            lvi.ForeColor = Color.Green;
                        else if (dr["promo"].ToString() != "Promote")
                            lvi.ForeColor = Color.Black;

                        else
                            lvi.ForeColor = Color.FromArgb(0, 0, 192);

                    }
                    else if (CallFrom == "Substitute")
                        lvi.ForeColor = Color.Green;

                    itemhelpgrid.Items.Add(lvi);
                }
                #endregion
            }
            itemhelpgrid.EndUpdate();

        }


        private void txtMedName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down && txtMedName.Text.Length > 0)
            {
                if (itemhelpgrid.Visible == true)
                {
                    itemhelpgrid.Focus();
                    if ((object)itemhelpgrid.FocusedItem != null)
                        itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].Selected = true;
                }
                else
                {
                    itemhelpgrid.Visible = true;
                    itemhelpgrid.Focus();
                    if ((object)itemhelpgrid.FocusedItem != null)
                        itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].Selected = true;
                }

            }
            else if (e.KeyCode == Keys.Enter && txtMedName.Text.Length == 0)
            {
                itemhelpgrid.Visible = false;
                //this.txtCardNo.KeyUp -= new System.Windows.Forms.KeyEventHandler(this.txtCardNo_KeyUp);

                //this.txtCardNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCardNo_KeyUp);
            }
            #region New Medicine Entry Form (By F12)
            else if (e.KeyCode == Keys.F12)
            {
                NewMedicine frm = new NewMedicine(_SelectedItem_Id, txtMedName.Text, txtInvNo.Text);
                frm.Location = new System.Drawing.Point(50, 200);
                frm.Show();
            }
            #endregion
            else if (e.KeyCode == Keys.Escape)
            {
                if (itemhelpgrid.Visible)
                    itemhelpgrid.Visible = false;
                txtMedName.Text = "";
            }
        }
        private void GetBatch(string _item_id)
        {
            int trec = 0;
            string InAudit = string.Empty;
            InAudit = "N";

            productSearch p = new productSearch();
            p.unit_id = GlobalUsage.Unit_id; p.item_id = _item_id;

            if (!chkReturnMemo.Checked) p.logic = "Sales"; else p.logic = "SalesReturn";
            p.login_id = GlobalUsage.Login_id; p.prm_1 = txtOldCashMemoNo.Text;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", p);

            lv_batchno.Items.Clear();
            #region Batch Grid Filling if record is more than 1
            foreach (DataRow dr in dwr.result.Tables[0].Rows)
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
                lvi.SubItems.Add(dr["usr"].ToString());
                lvi.SubItems.Add(dr["AuditRemark"].ToString());
                lvi.SubItems.Add(dr["retPermit"].ToString());
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
                    InAudit = "Y";
                    lvi.Font = new System.Drawing.Font(lvi.Font, FontStyle.Bold);
                    lvi.BackColor = Color.Red;
                }

                lv_batchno.Items.Add(lvi);

            }
            #endregion

            #region Fill Variable if Record is 1
            if (trec == 1 && InAudit == "N")
            {
                _MasterKeyId = lv_batchno.Items[0].Text;
                _BatchNo = lv_batchno.Items[0].SubItems[1].Text;
                _ExpDate = lv_batchno.Items[0].SubItems[2].Text;
                txtPacksize.Text = lv_batchno.Items[0].SubItems[3].Text;
                txtpackqty.Text = lv_batchno.Items[0].SubItems[4].Text;
                _Qty = Convert.ToInt32(lv_batchno.Items[0].SubItems[5].Text);
                _Mrp = Convert.ToDecimal(lv_batchno.Items[0].SubItems[6].Text);
                _UnitSaleRate = Convert.ToDecimal(lv_batchno.Items[0].SubItems[7].Text);

                txtbatchno.Text = _BatchNo;
                txtExpDate.Text = _ExpDate;
                txtmrp.Text = _Mrp.ToString("##.00");
                txtUnitMrp.Text = _UnitSaleRate.ToString("##.00");
                txtQty.Focus();
                _retPermitQty = Convert.ToInt16(lv_batchno.Items[0].SubItems[9].Text);
                if (chkReturnMemo.Checked && txtOldCashMemoNo.Text.Length > 5)
                    txtQty.Text = lv_batchno.Items[0].SubItems[9].Text;

            }
            else { lv_batchno.Visible = true; }
            #endregion
            if (lv_batchno.Items.Count == 0)
                lv_batchno.Visible = false;
            else if (lv_batchno.Items.Count > 0)
                lv_batchno.Visible = true;

        }
        private void itemhelpgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _SelectedItem_Id = itemhelpgrid.FocusedItem.Text;

                if (itemhelpgrid.FocusedItem.SubItems[2].Text.Contains("~"))
                {
                    string[] sp = itemhelpgrid.FocusedItem.SubItems[2].Text.Split('~');
                    txtMedName.Text = sp[0];
                }
                else
                    txtMedName.Text = itemhelpgrid.FocusedItem.SubItems[2].Text;
                itemhelpgrid.Visible = false;
                txtbatchno.Text = "";
                txtQty.Text = "0";
                txtmrp.Text = "";
                txtUnitMrp.Text = "";
                txtExpDate.Text = "";
                txtAmount.Text = "";
                txtbatchno.Focus();
                //Check Batch No and Fill if there is more than 1 Batch No Show Batch Help Grid.

            }
            else if (e.KeyCode == Keys.Escape)
            {
                itemhelpgrid.Visible = false;
                txtMedName.Focus();
            }
            else if (e.KeyCode == Keys.F7)
            {
                _ProductName = itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].SubItems[2].Text;
                _SelectedItem_Id = itemhelpgrid.FocusedItem.Text;
                GetProductHelp("?" + _SelectedItem_Id, "Substitute");
            }
        }
        private void lv_batchno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int FocusedIndex = lv_batchno.FocusedItem.Index;
                _MasterKeyId = lv_batchno.FocusedItem.Text;
                txtbatchno.Text = lv_batchno.Items[FocusedIndex].SubItems[1].Text;
                txtExpDate.Text = lv_batchno.Items[FocusedIndex].SubItems[2].Text;
                txtPacksize.Text = lv_batchno.Items[FocusedIndex].SubItems[3].Text;
                txtpackqty.Text = lv_batchno.Items[FocusedIndex].SubItems[4].Text;
                _Qty = Convert.ToDecimal(lv_batchno.Items[FocusedIndex].SubItems[5].Text);
                txtmrp.Text = Convert.ToDecimal(lv_batchno.Items[FocusedIndex].SubItems[6].Text).ToString("####.00");
                txtUnitMrp.Text = Convert.ToDecimal(lv_batchno.Items[FocusedIndex].SubItems[7].Text).ToString("####.00");
                lv_batchno.Visible = false;
                txtQty.Focus();
                _retPermitQty = Convert.ToInt16(lv_batchno.Items[FocusedIndex].SubItems[9].Text);
                if (chkReturnMemo.Checked && txtOldCashMemoNo.Text.Length > 5)
                    txtQty.Text = lv_batchno.Items[FocusedIndex].SubItems[9].Text;
            }

            if (e.KeyCode == Keys.Escape)
            {
                itemhelpgrid.Visible = false;
                txtMedName.Focus();
            }

        }
        private void txtbatchno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) txtMedName.Focus();
            if (e.KeyCode == Keys.Return)
            {
                if (txtbatchno.Text.Length > 0)
                    txtQty.Focus();
                else { MessageBox.Show("Enter Batch No.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); txtbatchno.Focus(); }
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
            else if (e.KeyCode == Keys.F12)
            {
                #region New Medicine Entry Form (By F12)
                NewMedicine frm = new NewMedicine(_SelectedItem_Id, txtMedName.Text, txtInvNo.Text);
                frm.Location = new System.Drawing.Point(50, 200);
                frm.Show();
                #endregion
            }

        }
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (Config.isNumeric(txtQty.Text, System.Globalization.NumberStyles.Integer))
            {
                txtAmount.Text = Convert.ToDecimal(Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtUnitMrp.Text)).ToString("####.00");
            }
        }
        private void txtbatchno_Enter(object sender, EventArgs e)
        {
            if (txtbatchno.Text.Length == 0)
            {
                GetBatch(_SelectedItem_Id);
            }
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) txtbatchno.Focus();
            if (e.KeyCode == Keys.Return)
            {

                if (txtPatientName.TextLength == 0)
                {
                    MessageBox.Show("Type patient Name.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPatientName.Focus();
                    return;
                }
                if (txtPrescribedBy.TextLength == 0)
                {
                    MessageBox.Show("Type Referral Name.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrescribedBy.Focus();
                    return;
                }

                if (Convert.ToDecimal(txtmrp.Text) >= Convert.ToDecimal(txtUnitMrp.Text) && _SelectedItem_Id.Length > 0 && txtMedName.Text.Length > 0)
                {
                    string result = "Passed";
                    if (chkReturnMemo.Checked && txtOldCashMemoNo.Text.Length > 6)
                    {
                        if (Math.Abs(_retPermitQty) >= Math.Abs(Convert.ToInt16(txtQty.Text)))
                            result = "Passed";
                        else
                        {
                            result = "Failed";
                            MessageBox.Show("Permit Qty For Return is " + _retPermitQty, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtQty.TextChanged -= new EventHandler(txtQty_TextChanged);
                            txtQty.Text = _retPermitQty.ToString();
                            txtQty.Focus();
                            txtQty.SelectAll();
                            this.txtQty.TextChanged += new EventHandler(txtQty_TextChanged);
                        }

                    }
                    if (result == "Passed")
                    {
                        #region Saving Process

                        if (e.KeyCode == Keys.Return && (txtQty.Text != "0" && Config.isNumeric(txtQty.Text, System.Globalization.NumberStyles.Integer)))
                        {
                            DataSet dsr = new DataSet();
                            Cursor.Current = Cursors.WaitCursor;
                            #region Saving of Record
                            try
                            {
                                if (_Lock_Flag == "N")
                                {
                                    string Ret_SalesInvNo = string.Empty;
                                    pm_InsertRetailSales p = new pm_InsertRetailSales();
                                    p.unit_id = GlobalUsage.Unit_id;
                                    p.counter_id = GlobalUsage.CounterID; p.computer_id = GlobalUsage.computerName; p.Sale_Type = "Walk-In";
                                    p.cust_name = txtPatientName.Text; p.prescribedBy = txtPrescribedBy.Text; p.refCode = _refCode;
                                    p.item_id = _SelectedItem_Id; p.master_key_id = _MasterKeyId; p.panelName = "Cash"; p.accountID = "16040001";
                                    p.card_no = _cardNo; p.card_level = txtCardStatus.Text; p.sold_qty = Convert.ToDouble(txtQty.Text);
                                    p.old_sale_inv_no = GlobalUsage.Old_Sale_Inv_No; p.gstn_no = txtGSTN_No.Text; p.hosp_cr_no = "-"; p.hosp_ipop_no = "-";
                                    p.Cur_sale_inv_no = txtInvNo.Text; p.order_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                                    p.stateName = GlobalUsage.State; p.couponCode = GlobalUsage.couponCode; p.ContactNo = _mobileNo;
                                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailInsertWalkInSale", p);


                                    if (dwr.message.Contains("Success"))
                                    {
                                        #region Grid Filling Process
                                        this.txtInvNo.TextChanged -= new System.EventHandler(this.txtInvNo_TextChanged);
                                        this.txtMedName.TextChanged -= new System.EventHandler(this.txtMedName_TextChanged);
                                        this.txtQty.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
                                        string[] r = dwr.message.Split('|');
                                        txtInvNo.Text = r[1];
                                        txtEstimateNo.Text = r[1];
                                        Fill_ItemSalesGrid(txtInvNo.Text, dwr.result);

                                        if (Convert.ToInt32(txtNetValue.Text) < 0)
                                            btn_print.Enabled = false;
                                        else
                                            btn_print.Enabled = true;

                                        resetInputBar();
                                        this.txtInvNo.TextChanged += new System.EventHandler(this.txtInvNo_TextChanged);
                                        this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
                                        this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);

                                    }
                                    txtMedName.Focus();
                                    #endregion

                                }
                                else
                                {
                                    MessageBox.Show("You can not sale against this invoice no .It is Locked ", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            #endregion
                        }
                        else
                        {
                            if (e.KeyCode == Keys.Return)
                            {
                                MessageBox.Show("Check Sales Quantity?", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtQty.Focus();
                            }
                        }

                        #endregion
                    }
                }
                else if (Convert.ToDecimal(txtmrp.Text) != 0)
                {
                    MessageBox.Show("Purchase rate is higher than sale rate (Check Purchase rate)", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Cursor.Current = Cursors.Default;

        }
        protected void Fill_Fin_Info(DataTable dt)
        {
            DataRow dr = dt.Rows[0];
            if (_CardChangeFlag == "N")
            {
                txtCardNo.Text = dr["contactNo"].ToString();
                _mobileNo = dr["contactNo"].ToString();
                _cardNo = dr["card_no"].ToString();
                txtPatientName.Text = dr["pt_name"].ToString();
            }
            txtTotal.Text = Convert.ToDecimal(dr["total"]).ToString("####.00");
            txtWallet.Text = Convert.ToDecimal(dr["TrfInWallet"]).ToString("####.00");
            txtDiscount.Text = Convert.ToDecimal(dr["discount"]).ToString("####.00");
            txtNetValue.Text = Convert.ToDecimal(dr["payable"]).ToString("####0");
            //txtRoundoff.Text = Convert.ToDecimal(dsr.Tables[0].Rows[0]["roundoff"]).ToString("##.00");
            txtIGST.Text = Convert.ToDecimal(dr["igst"]).ToString("##.00");
            txtcgst.Text = Convert.ToDecimal(dr["cgst"]).ToString("##.00");
            txtSGST.Text = Convert.ToDecimal(dr["sgst"]).ToString("##.00");
            txtTotalGST.Text = (Convert.ToDecimal(dr["sgst"]) + Convert.ToDecimal(dr["igst"]) + Convert.ToDecimal(dr["cgst"])).ToString("##.00");
            if (dr["sale_inv_no"].ToString().Contains("E"))
                _Lock_Flag = "N";
            else
                _Lock_Flag = "Y";


        }
        protected void Fill_ItemSalesGrid(string Sale_Inv_No, DataSet ds)
        {
            try
            {
                if (ds.Tables.Count == 0)
                {
                    _tempTable.Clear();
                    pm_SalesAction1 p = new pm_SalesAction1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.Sales_Inv_No = Sale_Inv_No; p.order_no = "N/A"; p.logic = "SalesInvoice";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/GetSalesInvoice_Info", p);
                    ds = dwr.result;
                }

                foreach (DataRow dr in ds.Tables[1].Rows)
                {
                    _tempTable.Rows.Add(dr["sale_inv_no"], dr["sale_trn_no"], dr["item_id"], dr["item_name"], dr["master_key_id"], dr["batch_no"],
                        dr["pack_type"], Convert.ToInt32(dr["pack_qty"]), Convert.ToDateTime(dr["exp_date"]), Convert.ToDecimal(dr["mrp"]),
                        Convert.ToDecimal(dr["sv"]), dr["tax_id"], Convert.ToDecimal(dr["sale_qty"]), Convert.ToDecimal(dr["usr"]),
                        Convert.ToDecimal(dr["igst"]), Convert.ToDecimal(dr["sgst"]), Convert.ToDecimal(dr["cgst"])
                        );
                }
                _tempTable.DefaultView.Sort = "sale_trn_no DESC";

                ItemSaleGrid.Items.Clear();

                if (ds.Tables.Count > 0)
                {
                    #region Fill Item Grid
                    foreach (DataRow dr in _tempTable.Rows)
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
                        lvi.SubItems.Add(Convert.ToDecimal(dr["usr"]).ToString("####.00"));             //7
                        lvi.SubItems.Add(dr["sale_qty"].ToString());                                    //8
                        lvi.SubItems.Add(Convert.ToDecimal(dr["sv"]).ToString("####.00"));              //9
                        lvi.SubItems.Add(dr["item_id"].ToString());                                     //10
                        lvi.SubItems.Add(dr["Sale_Inv_No"].ToString());                                 //11
                        lvi.SubItems.Add(dr["Sale_Trn_No"].ToString());                                 //12
                        ItemSaleGrid.Items.Add(lvi);

                    }
                    if (ItemSaleGrid.Items.Count > 0 && txtInvNo.Text.Substring(0, 1) == "E")
                        btnBillPosting.Enabled = true;
                    else
                        btnBillPosting.Enabled = false;


                    #endregion
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    #region Filling Summary of Bill
                    Fill_Fin_Info(ds.Tables[0]);
                    if (ds.Tables[0].Rows[0]["old_sale_inv_no"].ToString().Length > 6)
                    {
                        txtOldCashMemoNo.Text = ds.Tables[0].Rows[0]["old_sale_inv_no"].ToString();
                        txtCardNo.ReadOnly = true;
                        txtOldCashMemoNo.ReadOnly = true;
                    }
                    else
                    {
                        txtCardNo.ReadOnly = false;
                        txtOldCashMemoNo.ReadOnly = false;
                    }

                    this.txtPrescribedBy.TextChanged -= new EventHandler(this.txtPrescribedBy_TextChanged);


                    if (chkReturnMemo.Checked && txtPatientName.Text.Length == 0)
                    {
                        txtCardNo.Text = ds.Tables[0].Rows[0]["card_no"].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0]["pt_name"].ToString();

                    }
                    else if (txtPatientName.Text.Contains("TEMPORARY") || txtPatientName.Text.Length == 0)
                    {
                        txtCardNo.Text = ds.Tables[0].Rows[0]["card_no"].ToString();
                        txtPatientName.Text = ds.Tables[0].Rows[0]["pt_name"].ToString();
                    }
                    if (_holdFlag == "Y")
                    {
                        _refCode = ds.Tables[0].Rows[0]["refBy"].ToString();
                        txtPrescribedBy.Text = ds.Tables[0].Rows[0]["ref_name"].ToString();
                        //Get Discount from Card Info For Hold Bill.
                        _discountPercntage = Convert.ToDecimal(ds.Tables[0].Rows[0]["disPer"]);
                        _holdFlag = "N";
                        txtCardStatus.Text = ds.Tables[0].Rows[0]["CARD_STATUS"].ToString();
                    }
                    _PayMode = ds.Tables[0].Rows[0]["pay_mode"].ToString();

                    if (ds.Tables[0].Rows[0]["CARD_NO"].ToString() == "Credit-Allowed")
                    { groupBox2.Enabled = false; txtMedName.Enabled = false; }
                    else
                    { groupBox2.Enabled = true; txtMedName.Enabled = true; }

                    if (ItemSaleGrid.Items.Count > 0)
                        btn_print.Enabled = true;
                    else
                        btn_print.Enabled = false;

                    if (Convert.ToInt32(txtNetValue.Text) < 0 && ds.Tables[0].Rows[0]["isOTPVerified"].ToString() == "N")
                        btn_print.Enabled = false;
                    else
                        btn_print.Enabled = true;


                    this.txtPrescribedBy.TextChanged += new EventHandler(this.txtPrescribedBy_TextChanged);
                    if (_Lock_Flag == "Y")
                    {
                        txtPatientName.ReadOnly = true;
                        txtPrescribedBy.ReadOnly = true;
                        txtCardNo.ReadOnly = true;
                        txtMedName.Enabled = false;
                        txtbatchno.Enabled = false;
                        txtQty.Enabled = false;
                    }
                    else
                    {
                        txtPatientName.ReadOnly = false;
                        txtPrescribedBy.ReadOnly = false;
                        txtMedName.Enabled = true;
                        txtbatchno.Enabled = true;
                        txtQty.Enabled = true;
                    }

                    #endregion
                }
            }
            catch (Exception ex)
            { }
        }

        private void txtQty_Enter(object sender, EventArgs e)
        {
            txtQty.SelectAll();
        }

        private void txtPatientName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrescribedBy.Focus();
            }
        }
        private void lstCustDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtPrescribedBy.Text = "SELF";
                    txtPrescribedBy.Focus();
                }
                catch (Exception ex) { MessageBox.Show("Select Patient Name.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        private void txtPrescribedBy_TextChanged(object sender, EventArgs e)
        {
            lv_referralList.Items.Clear();
            try
            {
                if (txtPrescribedBy.Text.Length > 1)
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "SearchReferral"; p.prm_1 = txtPrescribedBy.Text; p.prm_2 = "-"; p.prm_3 = "-";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

                    lv_referralList.Visible = true;
                    if (dwr.result.Tables[0].Rows.Count > 0)
                    {
                        lv_referralList.Visible = true;
                        foreach (DataRow dr in dwr.result.Tables[0].Rows)
                        {
                            ListViewItem li = new ListViewItem(dr["ref_name"].ToString());
                            //li.SubItems.Add(_ds.Tables[0].Rows[0]["ref_code"].ToString());
                            lv_referralList.Items.Add(li);
                        }
                        _ds.Tables.Clear();
                    }
                    else
                    {
                        lv_referralList.Visible = false;

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); txtPatientName.Text = ""; }
        }



        private void CalculateDiscount(string Sale_Inv_No)
        {
            Cursor.Current = Cursors.WaitCursor;
            int u = ItemSaleGrid.Items.Count;
            if (((Conversion.Val(txtTotal.Text) > 10 || _CardType == "CORP" || Conversion.Val(txtDiscount.Text) > 0) || Conversion.Val(txtTotal.Text) < 0) && _Lock_Flag == "N")
            {
                foreach (ListViewItem lvi in ItemSaleGrid.Items)
                {
                    ProcessDiscount(lvi.SubItems[10].Text, lvi.SubItems[0].Text, txtCardNo.Text, Convert.ToInt32(lvi.SubItems[8].Text), Sale_Inv_No);
                }
                if (u > 0)
                    Fill_ItemSalesGrid(Sale_Inv_No, _ds);
            }
            Cursor.Current = Cursors.Default;
        }
        protected void ProcessDiscount(string item_id, string master_key_id, string HealthCardNo, Int32 SoldQty, string inv_no)
        {

            if (txtInvNo.Text != "New Invoice")
            {
                pm_InsertRetailSales p = new pm_InsertRetailSales();
                p.unit_id = GlobalUsage.Unit_id;
                p.card_no = _cardNo; p.card_level = txtCardStatus.Text;
                p.Cur_sale_inv_no = txtInvNo.Text;  p.old_sale_inv_no = txtOldCashMemoNo.Text;
                p.old_sale_inv_no = GlobalUsage.Old_Sale_Inv_No; p.gstn_no = txtGSTN_No.Text;
                p.hosp_cr_no = "-"; p.hosp_ipop_no = "-";p.ContactNo = _mobileNo;
                p.login_id = GlobalUsage.Login_id;
                p.stateName = GlobalUsage.State;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailSalesRecalculate", p);
                Fill_ItemSalesGrid(txtInvNo.Text, dwr.result);
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            int itemCont = ItemSaleGrid.Items.Count;

            if (txtInvNo.Text.Substring(0, 1) == "P")
            {
                if (txtCardNo.Text.Contains("CORP"))
                    printCashMemo(txtInvNo.Text);
                else if (Convert.ToInt32(txtNetValue.Text) < 20)
                    printCashMemo(txtInvNo.Text);
                else
                    Printing.Laser.CashMemo(txtInvNo.Text, "Y");
            }


            Cursor.Current = Cursors.Default;
        }

        protected void printCashMemo(string inv_no)
        {
            string msg = string.Empty;
            if (inv_no.Substring(0, 1).ToUpper() == "E")
                msg = "Do You Want To Print Estimate No ";
            else
                msg = "Do You Want To Print Bill No ";

            if (MessageBox.Show(msg + inv_no, "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (GlobalUsage.Unit_id.Substring(0, 2) == "MS")
                    Printing.Laser.CashMemo(inv_no, "Y");
                else
                    Printing.Laser.CashMemo(inv_no, "Y");
            }
        }


        private void SaleMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.H) || e.KeyCode == Keys.F3)
            {
                Cursor.Current = Cursors.WaitCursor;
                GlobalUsage.BillType = "UnPosted";
                this.frmCashMemoSearch = new CashMemoSearch("Walk-In:Search Hold Invoices.");
                this.frmCashMemoSearch.SearchUpdated += new SearchCashMemoEventHandler(Search_SearchUpdated);
                frmCashMemoSearch.Owner = this;
                frmCashMemoSearch.Show();
                Cursor.Current = Cursors.Default;
            }
            else if (e.KeyCode == Keys.F2)
            {
                Cursor.Current = Cursors.WaitCursor;
                GlobalUsage.BillType = "Posted";
                this.frmCashMemoSearch = new CashMemoSearch("Walk-In:Search Posted Invoices.");
                this.frmCashMemoSearch.SearchUpdated += new SearchCashMemoEventHandler(Search_SearchUpdated);
                frmCashMemoSearch.Owner = this;
                frmCashMemoSearch.Show();
                Cursor.Current = Cursors.Default;
            }
            else if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                ResetForNewBill();
            }
            //healthcard (This Is Global declare In this Form)

        }


        private void Search_SearchUpdated(object sender, CashMemeoNoUpdatedEventArgs e)
        {
            this.txtInvNo.Text = e.CASHMEMONO;
            _holdFlag = "Y";
            Fill_ItemSalesGrid(txtInvNo.Text, _ds);
        }

        private void ItemSaleGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dlgresult = MessageBox.Show("Do You confirm to delete Selected Recored ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgresult.ToString() == "Yes")
                {
                    int indx = ItemSaleGrid.FocusedItem.Index;
                    try
                    {
                        decimal qty = Convert.ToDecimal(ItemSaleGrid.Items[ItemSaleGrid.FocusedItem.Index].SubItems[8].Text);
                        _MasterKeyId = ItemSaleGrid.FocusedItem.Text;

                        DataSet ds = new DataSet();
                        pm_SalesAction1 p = new pm_SalesAction1();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.Sales_Inv_No = txtInvNo.Text;
                        p.master_key_id = _MasterKeyId; p.Sale_Trn_No = ItemSaleGrid.Items[ItemSaleGrid.FocusedItem.Index].SubItems[12].Text;
                        p.order_no = "N/A"; p.logic = "SalesInvoice";
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/DeleteSalesEntry", p);
                        ds = dwr.result;
                        string exp = string.Empty; exp = "sale_trn_no='" + p.Sale_Trn_No + "'";
                        DataRow[] dr = _tempTable.Select(exp);
                        if (_tempTable.Rows.Count > 0)
                        {
                            _tempTable.Rows.Remove(dr[0]);
                            _tempTable.AcceptChanges();
                        }
                        if (dwr.message.Contains("Success"))
                        {
                            ItemSaleGrid.Items[indx].Remove();
                            Fill_Fin_Info(ds.Tables[0]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void txtPrescribedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtPrescribedBy.Text.Length > 0)
            {
                try
                {
                    lv_referralList.Focus();
                    lv_referralList.Items[lv_referralList.FocusedItem.Index].Selected = true;
                }
                catch (Exception ex) { }
            }

            if (e.KeyCode == Keys.Return)
            {
                txtMedName.Focus();
            }
        }
        private void txtOldCashMemoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CheckOldCashMemoInfo(txtOldCashMemoNo.Text);
                txtMedName.Focus();
            }
        }
        protected void CheckOldCashMemoInfo(string CashMemoNo)
        {
            //Check Cash Memo Existence
            if (txtOldCashMemoNo.Text.Length > 5)
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "CashMemoHeadInfo"; p.prm_1 = CashMemoNo; p.prm_2 = "-"; p.prm_3 = "-"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    _refCode = dwr.result.Tables[0].Rows[0]["refby"].ToString();
                    if (_CardChangeFlag == "N")
                    {
                        txtPatientName.Text = dwr.result.Tables[0].Rows[0]["pt_name"].ToString();
                        txtCardNo.Text = dwr.result.Tables[0].Rows[0]["card_no"].ToString().ToUpper();
                        _cardNo = txtCardNo.Text;
                        _mobileNo = dwr.result.Tables[0].Rows[0]["contactNo"].ToString().ToUpper();
                    }
                    this.txtPrescribedBy.TextChanged -= new System.EventHandler(this.txtPrescribedBy_TextChanged);
                    txtPrescribedBy.Text = dwr.result.Tables[0].Rows[0]["ref_name"].ToString().ToUpper();
                    this.txtPrescribedBy.TextChanged += new System.EventHandler(this.txtPrescribedBy_TextChanged);
                    txtPatientName.ReadOnly = true;
                    txtPrescribedBy.ReadOnly = true;
                    txtCardNo.ReadOnly = true;
                    txtOldCashMemoNo.ReadOnly = true;
                    GlobalUsage.Old_Sale_Inv_No = txtOldCashMemoNo.Text;
                }
                else
                {
                    MessageBox.Show("Cash Memo No Not Exist.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPatientName.ReadOnly = false;
                    txtPrescribedBy.ReadOnly = false;
                    txtCardNo.ReadOnly = false;
                    GlobalUsage.Old_Sale_Inv_No = "N/A";
                }
            }
        }
        private void txtOldCashMemoNo_Leave(object sender, EventArgs e)
        {
            CheckOldCashMemoInfo(txtOldCashMemoNo.Text);
        }


        private void txtPrescribedBy_Leave(object sender, EventArgs e)
        {

            if (txtPrescribedBy.Text.ToUpper() == "SELF")
            { _refCode = "0001"; txtPrescribedBy.Text = "Distt. Hospital"; }
            else if (txtPrescribedBy.TextLength == 0)
                txtPrescribedBy.Focus();
        }
        private void txtMedName_Enter(object sender, EventArgs e)
        {
            if (lv_batchno.Visible)
                lv_batchno.Visible = false;
        }
        protected void resetInputBar()
        {

            txtMedName.Text = "";
            txtbatchno.Text = "";
            this.txtQty.TextChanged -= new EventHandler(txtQty_TextChanged);
            txtQty.Text = "0";
            this.txtQty.TextChanged += new EventHandler(txtQty_TextChanged);
            txtbatchno.Text = "";
            txtUnitMrp.Text = "0";
            txtQty.Text = "0";
            txtmrp.Text = "0";
            txtExpDate.Text = "";
            txtAmount.Text = "0";
            _MasterKeyId = "";
            _BatchNo = "";
            _ExpDate = "";
            _Qty = 0;
            _Mrp = 0;
            _UnitSaleRate = 0;
            _SelectedItem_Id = "";
        }
        private void ResetForNewBill()
        {

            //lstDoctDetails.Items.Clear();
            _CardChangeFlag = "N";
            _tempTable.Clear();
            _tempTable.AcceptChanges();
            _mobileNo = "-";
            lv_batchno.Items.Clear();
            itemhelpgrid.Items.Clear();
            ItemSaleGrid.Items.Clear();
            txtPrescribedBy.Text = "";
            txtmrp.Text = "";
            txtMedName.Text = "";

            txtAmount.Text = "";
            txtPatientName.Text = "";
            txtbatchno.Text = "";
            txtUnitMrp.Text = "0";
            this.txtQty.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);

            txtQty.Text = "0";

            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            txtmrp.Text = "0";
            txtExpDate.Text = "";
            _MasterKeyId = "";
            _BatchNo = "";
            _ExpDate = "";
            chkReturnMemo.Checked = false;
            txtOldCashMemoNo.ReadOnly = false;
            txtOldCashMemoNo.Text = "N/A";
            _Qty = 0;
            _PayMode = "Cash";
            _Mrp = 0;
            _UnitSaleRate = 0;

            _SelectedItem_Id = "";
            _SaleType = "N";
            //lstDoctDetails.Visible = false;

            txtOldCashMemoNo.Text = "";
            txtInvNo.Text = "New Invoice";
            txtCardNo.Text = "-";
            _retPermitQty = 0;
            txtTotal.Text = "0";
            txtDiscount.Text = "0";
            //txtRoundoff.Text = "";
            txtNetValue.Text = "0";
            txtWallet.Text = "0";
            txtTotalGST.Text = "0";
            txtMedName.Enabled = true;
            txtIGST.Text = "0"; txtSGST.Text = "0"; txtcgst.Text = "0";
            txtPatientName.ReadOnly = false;
            txtPrescribedBy.ReadOnly = false;
            txtCardNo.Enabled = false;
            txtCardStatus.Text = "XXXXXXXXXX";
            txtCardNo.ReadOnly = false;
            _Lock_Flag = "N";
            txtMedName.Enabled = true;
            txtbatchno.Enabled = true;
            txtQty.Enabled = true;
            rb_byCard.Checked = true;
            rb_ByMobile.Checked = true;
            GlobalUsage.couponCode = "-";
            txtMedName.Focus();
        }

        private void chkReturnMemo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReturnMemo.Checked)
            {
                txtOldCashMemoNo.Enabled = true;
            }
            else
            {
                txtOldCashMemoNo.Text = "N/A";
                txtOldCashMemoNo.Enabled = false;
            }
        }

        private void txtInvNo_TextChanged(object sender, EventArgs e)
        {
            if (txtInvNo.Text != "New Invoice")
                Fill_ItemSalesGrid(txtInvNo.Text, _ds);
            if (txtInvNo.Text.Substring(0, 1) == "P")
                btnBillPosting.Enabled = false;
            else
                btnBillPosting.Enabled = true;


        }

        private void txtCardNo_Enter(object sender, EventArgs e)
        {
            txtCardNo.SelectAll();
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtQty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Config.isNumeric(txtQty.Text, System.Globalization.NumberStyles.Integer))
            {
                txtQty.Focus();
                txtQty.SelectAll();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_MouseClick(object sender, MouseEventArgs e)
        {
            txtQty.SelectAll();
        }


        private void txtCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rb_ByMobile.Checked)
                        txtWalletId.Text = txtCardNo.Text;

                    string logic = string.Empty;
                    DataSet ds = new DataSet();
                    Cursor.Current = Cursors.WaitCursor;
                    View_Healthcard.Controls.Clear();
                    string SearchOption = string.Empty;
                    if (rb_byCard.Checked)
                    {
                        SearchOption = "SearchByCard";
                        logic = "P:SearchByCard";
                        if (!txtCardNo.Text.ToUpper().Contains("CORP"))
                        {
                            RadMessageBox.Show("By Card Searching Only For Corporate Cards.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                            rb_ByMobile.Checked = true;
                            txtCardNo.SelectAll();
                            txtCardNo.Focus();
                            return;
                        }
                    }
                    else if (rb_ByMobile.Checked)
                    {
                        SearchOption = "SearchByMobile";
                        logic = "P:SearchByMobile";

                    }


                    ipHealthCard p = new ipHealthCard();
                    p.card_no = txtCardNo.Text; p.unit_id = GlobalUsage.Unit_id; p.old_cardno = "-"; p.mobile = txtCardNo.Text;
                    p.from = "1900/01/01"; p.to = "1900/01/01"; p.login_id = GlobalUsage.Login_id; p.prm_1 = "-"; p.prm_2 = "-";
                    p.Logic = logic;

                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/GetCard_Queries", p);
                    ds = dwr.result;
                    if (ds.Tables[1].Rows.Count == 0)
                    {
                        RadMessageBox.Show("Information Not Found.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        txtCardNo.SelectAll();
                        txtCardNo.Focus();
                        return;
                    }
                    else if (txtCardNo.Text.ToUpper().Contains("CORP"))
                    {
                        _discountPercntage = Convert.ToDecimal(ds.Tables[0].Rows[0]["discperc"]);
                        txtPatientName.Text = ds.Tables[0].Rows[0]["member_name"].ToString();
                        txtPatientName.Enabled = false;
                    }
                    else
                    {
                        if(rb_ByMobile.Checked)
                        _mobileNo = txtCardNo.Text;
                        HealthCardHelp = new ucHealthCardNew(txtCardNo.Text, ds, SearchOption);
                        HealthCardHelp.SearchUpdated += new HealthCardUpdatedEventHandler(FillCardDetail);
                        HealthCardHelp.Dock = System.Windows.Forms.DockStyle.Fill;
                        HealthCardHelp.Location = new System.Drawing.Point(0, 0);
                        HealthCardHelp.Name = "ucHealthCard1";
                        HealthCardHelp.Size = new System.Drawing.Size(650, 617);
                        HealthCardHelp.TabIndex = 0;
                        View_Healthcard.Controls.Add(HealthCardHelp);
                        rpv_master.SelectedPage = rpv_master.Pages[1];
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void FillCardDetail(object sender, HealthCardUpdatedEventArgs e)
        {
            _CardChangeFlag = "Y";
            txtPatientName.Text = e.NewCardName;
            txtPatientName.Enabled = false;
            if (rb_ByMobile.Checked)
            {
                txtCardNo.Text = e.MobileNo;//e.NewCardNo;
                _cardNo = e.NewCardNo;
            }
            else
                txtCardNo.Text = e.NewCardNo;

            txtCardStatus.Text = e.CardType;
            _discountPercntage = e.Discountpercentage;
            _PayMode = e.PayMode;
            _mobileNo = e.MobileNo;
            txtCardNo.Enabled = false;
            rpv_master.SelectedPage = rpv_master.Pages[0];

            CalculateDiscount(txtInvNo.Text);
            _CardChangeFlag = "N";
        }


        private void rb_ByMobile_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNo.Text = "";
            _CardType = "N/A";
            txtCardStatus.Text = "N/A";
            if (_holdFlag != "Y")
                _discountPercntage = 0;
            _PayMode = "Cash";
            txtCardNo.Enabled = true;
            if (txtCardNo.TextLength > 0)
                CalculateDiscount(txtInvNo.Text);
        }

        private void rb_byCard_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNo.Text = "";
            _CardType = "N/A";
            txtCardStatus.Text = "N/A";
            if (_holdFlag != "Y")
                _discountPercntage = 0;

            _PayMode = "Cash";
            txtCardNo.Enabled = true;
            if (txtCardNo.TextLength > 0)
                CalculateDiscount(txtInvNo.Text);
            else if (Convert.ToDecimal(txtDiscount.Text) > 1)
                CalculateDiscount(txtInvNo.Text);
        }

        private void chkGSTN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGSTN.Checked)
            { txtGSTN_No.Enabled = true; }
            else
            { txtGSTN_No.Text = ""; txtGSTN_No.Enabled = false; }
        }

        private void chkSubstitute_CheckedChanged(object sender, EventArgs e)
        {
            string old = string.Empty;
            old = txtMedName.Text;
            txtMedName.Text = "";
            txtMedName.Text = old;
            if (chkSubstitute.Checked)
                chkBySalt.Checked = false;

        }

        private void chkBySalt_CheckedChanged(object sender, EventArgs e)
        {
            string old = string.Empty;
            old = txtMedName.Text;
            txtMedName.Text = "";
            txtMedName.Text = old;

            if (chkBySalt.Checked)
                chkSubstitute.Checked = false;
        }



        private void btnEstiMate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You want to Print Inernal Paper (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    printCashMemo(txtInvNo.Text);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }


        private void lv_referralList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lv_referralList.Items.Count > 0)
                {
                    this.txtPrescribedBy.TextChanged -= new System.EventHandler(this.txtPrescribedBy_TextChanged);
                    txtPrescribedBy.Text = lv_referralList.FocusedItem.Text;
                    this.txtPrescribedBy.TextChanged += new System.EventHandler(this.txtPrescribedBy_TextChanged);
                    lv_referralList.Visible = false;
                    txtMedName.SelectAll(); txtMedName.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtPrescribedBy.SelectAll(); txtPrescribedBy.Focus(); lv_referralList.Visible = false;
            }
        }



        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            lblVerify.Text = "Verification Status :";
            pm_IPOPQueries pm = new pm_IPOPQueries();
            pm.unit_id = GlobalUsage.Unit_id; pm.card_no = "-"; pm.uhid = "-"; pm.IPOPNo = "-"; pm.from = "1900/01/01"; pm.to = "1900/01/01";
            pm.prm_1 = txtEstimateNo.Text; pm.logic = "getInfo"; pm.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", pm);
            DataSet dsVerify = dwr.result;
            if (dsVerify.Tables[0].Rows.Count > 0)
            {
                txtVCustName.Text = dsVerify.Tables[0].Rows[0]["pt_name"].ToString();
                txtVUhid.Text = dsVerify.Tables[0].Rows[0]["hosp_cr_no"].ToString();
                btnGenerateCode.Enabled = true;
                if (txtVUhid.Text.Length > 8)
                {
                    _result = GlobalUsage.his_proxy.getPatientDetails(txtVUhid.Text);
                    var table = JsonConvert.DeserializeObject<DataTable>(_result);
                    txtVMobile.Text = table.Rows[0]["mobile"].ToString();
                }
                else
                    txtVMobile.Text = dsVerify.Tables[0].Rows[0]["ContactNo"].ToString();

                txtVold.Text = dsVerify.Tables[0].Rows[0]["old_sale_inv_no"].ToString();

            }
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                txtOTPNo.Enabled = true;
                Random rnd = new Random();
                string _otp = (rnd.Next(100000, 999999)).ToString();
                sms p = new sms();
                p.msg = _otp + " is Your Chandan Member Verification Code.";// + DateTime.Now.ToString();
                p.MobileNo = txtVMobile.Text;
                p.templateID = "1007368458238551885";
                p.smsProvider = GlobalUsage.smsProvider;
                p.smsAPI = GlobalUsage.SmsAPI;
                p.smsID = GlobalUsage.SmsID;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/sendsms", p);

                cm1 p1 = new cm1();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id; p1.prm_3 = GlobalUsage.Login_id;
                p1.Logic = "UpdateOTP"; p1.prm_1 = _otp; p1.tran_id = txtEstimateNo.Text;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);

                btnGenerateCode.Enabled = false;
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            cm1 p1 = new cm1();
            lblVerify.Text = "Verification Status : Verified"; p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id; p1.prm_3 = GlobalUsage.Login_id;
            p1.Logic = "VerifyOTP"; p1.prm_1 = txtOTPNo.Text; p1.tran_id = txtEstimateNo.Text;
            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
            if (dwr1.message == "Fail To Update")
            {
                lblVerify.ForeColor = Color.Red;
                lblVerify.Text = "Verification Status : Failed";

            }
            else
            { lblVerify.ForeColor = Color.Green; lblVerify.Text = "Verification Status : Verified"; txtInvNo.Text = "New"; txtInvNo.Text = txtEstimateNo.Text; }

        }

        private void btnSendWalletOTP_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                txtOTPNo.Enabled = true;
                Random rnd = new Random();
                string _otp = (rnd.Next(100000, 999999)).ToString();
                sms p = new sms();
                p.msg = "To encash Rs. " + txtRedeemAmt.Text + " from your Chandan Pharmacy wallet, OTP is " + _otp + ". Team Chandan.";// + DateTime.Now.ToString();
                p.MobileNo = txtWalletId.Text;
                p.templateID = "1007387720749582210";
                p.smsProvider = GlobalUsage.smsProvider;
                p.smsAPI = GlobalUsage.SmsAPI;
                p.smsID = GlobalUsage.SmsID;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/sendsms", p);

                cm1 p1 = new cm1();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id; p1.prm_3 = GlobalUsage.Login_id;
                p1.Logic = "UpdateOTP"; p1.prm_1 = _otp; p1.tran_id = txtInvNo.Text;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);

                btnGenerateCode.Enabled = false;
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }



        private void btnOTPVerify_Click(object sender, EventArgs e)
        {
            cm1 p1 = new cm1();
            p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id; p1.prm_3 = GlobalUsage.Login_id;
            p1.Logic = "VerifyOTP"; p1.prm_1 = txtWalletOTP.Text; p1.tran_id = txtInvNo.Text;
            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
            if (dwr1.message == "Fail To Update")
            {
                lblWalletVerifyresult.ForeColor = Color.Red;
                lblWalletVerifyresult.Text = "Verification Status : Failed";
                btnWalletApply.Enabled = false;

            }
            else
            {
                lblWalletVerifyresult.ForeColor = Color.Green; lblWalletVerifyresult.Text = "Verification Status : Verified";
                btnWalletApply.Enabled = true; btnOTPVerify.Enabled = false;
            }

        }

        private void btnWalletApply_Click(object sender, EventArgs e)
        {
            try
            {
                WalletMoney p = new WalletMoney();
                p.unitID = GlobalUsage.Unit_id; p.estimateNo = txtInvNo.Text; p.loginId = GlobalUsage.Login_id;
                p.walletMoney = Convert.ToInt32(txtRedeemAmt.Text);
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/ApplyWalletMoneyDiscount", p);

                if (!dwr.message.Contains("Successfully"))
                {
                    MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnWalletApply.Enabled = false; btnVerifyOTP.Enabled = false; btnSendWalletOTP.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnBillPosting_Click(object sender, EventArgs e)
        {
            BillPosting b = new BillPosting();
            b.sale_inv_no = txtInvNo.Text;
            b.card_no = _cardNo; b.customer_name = txtPatientName.Text; b.ipopNo = "-"; b.panelName = "Retail Sales";
            b.panelType = "Cash"; b.prescribedBy = txtPrescribedBy.Text; b.uhidNo = "-";
            b.amount = Convert.ToInt32(txtNetValue.Text); b.mobileNo = _mobileNo;
            b.Oldsale_inv_no = txtOldCashMemoNo.Text;

            if (rb_ByMobile.Checked && txtCardNo.Text.Length == 20)
                b.mobileNo = txtCardNo.Text;
            else if (_mobileNo.Length == 10)
                b.mobileNo = _mobileNo;
            else
                b.mobileNo = "-";


            this.frmsaleBillPosting = new SaleBill_Posting(b);
            this.frmsaleBillPosting.eventBillUpdated += new BillPostingEventHandler(BillPostingUpdated);
            frmsaleBillPosting.Owner = this;
            frmsaleBillPosting.Show();
        }

        private void BillPostingUpdated(object sender, BillPostingUpdatedEventArgs e)
        {
            this.txtInvNo.Text = e.SaleInvNo;
            if (e.result.ToUpper() == "POSTED")
            {
                printCashMemo(txtInvNo.Text);
                ResetForNewBill();
                btnBillPosting.Enabled = false;
                if (_CallFrom == "Cash Counter")
                {
                    CashCounterUpdatedEventArgs ValueArgs = new CashCounterUpdatedEventArgs(_estimateNo, "Success");
                    CashCounterUpdated(this, ValueArgs);
                    this.Close();
                }

            }
        }

        private void btnWalletInfo_Click(object sender, EventArgs e)
        {
            try
            {
                WalletMoney p = new WalletMoney();
                p.unitID = GlobalUsage.Unit_id; p.walletID = txtWalletId.Text; p.Logic = "WB"; p.loginId = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WalletQueries", p);
                _ds = dwr.result;
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    txtWalletBalance.Text = _ds.Tables[0].Rows[0]["WalletBalance"].ToString();
                    txtWalletId.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            try
            {
                cm2 p = new cm2();
             
                p.unit_id = GlobalUsage.Unit_id;
                if (rbRedemtion.Checked)
                    p.tranType = "Redemption";
                if (rbSalesReturn.Checked)
                    p.tranType = "SalesReturn";
                p.Logic = "Insert";p.tran_id = txtInvNo.Text;p.prm_2 = "-";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/InsertModifyLogApprovals", p);
                _ds = dwr.result;
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Successfully Sent", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnApproval.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void rbRedemtion_CheckedChanged(object sender, EventArgs e)
        {
            btnApproval.Enabled = true;
        }

        private void rbSalesReturn_CheckedChanged(object sender, EventArgs e)
        {
            btnApproval.Enabled = true;
        }
    }
}  // Last Brace