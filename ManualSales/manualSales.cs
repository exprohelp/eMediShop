using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.ManualSales
{
    public partial class manualSales : Telerik.WinControls.UI.RadForm
    {
        ucHealthCardNew HealthCardHelp;
        string _CardChangeFlag = "N"; string _PayMode = string.Empty; string _mobileNo = string.Empty;
        string _panelName = string.Empty; string _remarks = string.Empty;
        string _SelectedItem_Id = string.Empty; string _ProductName = string.Empty; string _UHID = string.Empty;
        decimal _discountPercntage = 0; decimal _taxRate = 0; decimal _unitSaleRate = 0; decimal _unitMRPRate = 0;
        string _result = string.Empty; string _discountFlag = "N"; string _manualBillNo = "-";
        DataSet _ds = new DataSet();
        DataTable _dt = new DataTable();

        public manualSales()
        {
            InitializeComponent();
        }

        private void rbOPD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOPD.Checked)
            {
                txtIPOPNo.Enabled = true;
                txtIPOPNo.Focus();
                rb_byCard.Enabled = false;
                rb_ByMobile.Enabled = false;
                txtCardNo.Enabled = false;
            }

        }

        private void rbWalkIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWalkIn.Checked)
            {
                txtIPOPNo.Enabled = false;
                rb_byCard.Enabled = true;
                rb_ByMobile.Enabled = true;
                txtCardNo.Enabled = true;
                txtCardNo.Focus();
            }

        }

        private void txtCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
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
                    resultSetMIS rsm = MISProxy.CallMISWebApiMethod("HealthCard/GetCard_Queries", p);
                    ds = rsm.ResultSet;
                    if (ds.Tables[1].Rows.Count == 0)
                    {
                        RadMessageBox.Show("Information Not Found.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        txtCardNo.SelectAll();
                        txtCardNo.Focus();
                        return;
                    }
                    else
                    {
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
            txtCardNo.Text = e.NewCardNo;


            _discountPercntage = e.Discountpercentage;
            _discountFlag = "Y";
            _PayMode = e.PayMode;
            _mobileNo = e.MobileNo;
            txtCardNo.Enabled = false;
            rpv_master.SelectedPage = rpv_master.Pages[0];
            ManagePaymentMode();

            _CardChangeFlag = "N";
        }
        private void ManagePaymentMode()
        {

            if (_PayMode.ToUpper() != "CASH")
            {
                radioCredit.Checked = true;

                radioCash.Enabled = false;
            }
            else
            {
                radioCredit.Checked = false;
                radioCash.Enabled = true;
            }
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

            ListViewItem lvi;
            //WebAPI
            Search p = new Search();
            p.unit_id = GlobalUsage.Unit_id; p.SearchKey = ProductSearch;
            p.Logic = "ManualSale";
            p.LoginId = GlobalUsage.Login_id; p.Prm_1 = "-";

            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductHelp", p);
            if (dwr.result.Tables[0].Rows.Count > 0)
            {
                itemhelpgrid.Visible = true;
                #region Filling Item Help Grid

                string temp = string.Empty;
                foreach (DataRow dr in dwr.result.Tables[0].Rows)
                {

                    lvi = new ListViewItem(dr["item_id"].ToString());
                    lvi.SubItems.Add(dr["item_name"].ToString());
                    lvi.SubItems.Add(dr["pack_type"].ToString());
                    lvi.SubItems.Add(dr["pack_qty"].ToString());
                    lvi.SubItems.Add(dr["discount"].ToString());
                    lvi.SubItems.Add(dr["mTaxRate"].ToString());
                    itemhelpgrid.Items.Add(lvi);
                }
                #endregion
            }
            itemhelpgrid.EndUpdate();

        }

        private void itemhelpgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _SelectedItem_Id = itemhelpgrid.FocusedItem.Text;

                this.txtMedName.TextChanged -= new System.EventHandler(this.txtMedName_TextChanged);
                txtMedName.Text = itemhelpgrid.FocusedItem.SubItems[1].Text;
                this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);
                txtPacksize.Text = itemhelpgrid.FocusedItem.SubItems[2].Text;
                txtpackqty.Text = itemhelpgrid.FocusedItem.SubItems[3].Text;
                _taxRate = Convert.ToDecimal(itemhelpgrid.FocusedItem.SubItems[3].Text);
                if (_discountFlag == "Y")
                    _discountPercntage = Convert.ToDecimal(itemhelpgrid.FocusedItem.SubItems[4].Text);
                else
                    _discountPercntage = 0;
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

        }
        private void resetbar()
        {
            this.txtMedName.TextChanged -= new System.EventHandler(this.txtMedName_TextChanged);
            txtMedName.Text = "";
            this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);
            txtPacksize.Text = "";
            txtpackqty.Text = "";
            _taxRate = 0;
            _discountPercntage = 0;
            txtbatchno.Text = "";
            txtQty.Text = "0";
            txtmrp.Text = "";
            txtUnitMrp.Text = "";
            txtExpDate.Text = "";
            txtAmount.Text = "";
            rb_Extra.Checked = false;
            rb_pruchaseNotIn.Checked = false;
            txtMedName.Enabled = false;
        }
        private void resetPatientInfo()
        {
            txtCardNo.Text = "";
            txtPatientName.Text = "";
            txtIPOPNo.Text = "";
            rbWalkIn.Checked = true;
            rb_ByMobile.Checked = true;
            _panelName = "-";
            _UHID = "-";

            rb_Extra.Checked = false;
            rb_pruchaseNotIn.Checked = false;
            txtMedName.Enabled = false;
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

            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (itemhelpgrid.Visible)
                    itemhelpgrid.Visible = false;
                txtMedName.Text = "";
            }
        }

        private void txtbatchno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                productSearch p = new productSearch();
                p.unit_id = GlobalUsage.Unit_id; p.item_id = _SelectedItem_Id;
                p.logic = "ManualSaleBatch";
                p.login_id = GlobalUsage.Login_id; p.prm_1 = txtbatchno.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", p);
                _ds = dwr.result;
                if (_ds.Tables[0].Rows.Count > 0)
                {

                    txtmrp.Text = _ds.Tables[0].Rows[0]["mrp"].ToString();
                    txtExpDate.Text = _ds.Tables[0].Rows[0]["exp_date"].ToString();
                    _taxRate = Convert.ToDecimal(_ds.Tables[0].Rows[0]["tax_rate"]);
                    txtUnitMrp.Text = (Convert.ToDecimal(txtmrp.Text) / Convert.ToDecimal(txtpackqty.Text)).ToString();

                }
                txtExpDate.Focus();
                txtExpDate.SelectAll();
            }
        }

        private void txtbatchno_Leave(object sender, EventArgs e)
        {

        }

        private void manualSales_Load(object sender, EventArgs e)
        {
            //this.rgvSalesGrid.Controls.Add(this.itemhelpgrid);
            this.itemhelpgrid.Location = new System.Drawing.Point(-2, 0);
            this.itemhelpgrid.Size = new System.Drawing.Size(326, 407);
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;

        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbatchno.TextLength < 5)
                {
                    RadMessageBox.Show("Batch No Should be minimum 5 Character.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txtbatchno.Focus();
                    return;
                }
                if (txtExpDate.TextLength != 5)
                {
                    RadMessageBox.Show("Expiry Should be minimum 5 Character.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txtExpDate.Focus();
                    return;
                }
                if (_SelectedItem_Id.Length < 5)
                {
                    RadMessageBox.Show("Reselect The Item.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txtMedName.Focus();
                    txtMedName.SelectAll();
                    return;
                }
                DateTime d; DateTime curDate; string expdate = "01-" + txtExpDate.Text;
                d = Convert.ToDateTime(expdate);curDate = DateTime.Today;
                if (d <= curDate.AddMonths(1))
                {
                    txtExpDate.Focus(); txtExpDate.SelectAll();
                    RadMessageBox.Show("Expiry is not Correct.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txtExpDate.Focus();
                    txtExpDate.SelectAll();
                    return;
                }


                #region Add Records In Grid


                GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.rgvSalesGrid.MasterView);
                rowInfo.Cells["item_id"].Value = _SelectedItem_Id;
                rowInfo.Cells["item_name"].Value = txtMedName.Text;
                rowInfo.Cells["pack_type"].Value = txtPacksize.Text;
                rowInfo.Cells["pack_qty"].Value = Convert.ToInt16(txtpackqty.Text);
                rowInfo.Cells["batchNo"].Value = txtbatchno.Text;
                rowInfo.Cells["exp_date"].Value = txtExpDate.Text;
                rowInfo.Cells["disPer"].Value = _discountPercntage;
                rowInfo.Cells["mrp"].Value = Convert.ToDecimal(txtmrp.Text);
                rowInfo.Cells["discount"].Value = 0;
                rowInfo.Cells["usr"].Value = _unitSaleRate;
                rowInfo.Cells["SoldQty"].Value = Convert.ToInt16(txtQty.Text);
                rowInfo.Cells["Amount"].Value = Convert.ToDecimal(txtAmount.Text);
                if (rb_pruchaseNotIn.Checked)
                    rowInfo.Cells["mnlType"].Value = "Purchase";
                else if (rb_Extra.Checked)
                    rowInfo.Cells["mnlType"].Value = "Extra";
                else
                    return;
                rgvSalesGrid.Rows.Add(rowInfo);
                #endregion
                resetbar();
                BillSummary();

            }
        }

        private void rgvSalesGrid_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            e.Row.Delete();
        }

        private void txtExpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmrp.Focus();
                txtmrp.SelectAll();
            }
        }

        private void txtmrp_Leave(object sender, EventArgs e)
        {
            if (Config.isNumeric(txtmrp.Text, System.Globalization.NumberStyles.Float))
            {
                _unitMRPRate = Convert.ToDecimal(txtmrp.Text) / Convert.ToInt16(txtpackqty.Text);
                if (_discountFlag == "Y")
                {
                    //_discountPercntage = getDiscount(_SelectedItem_Id);
                    _unitSaleRate = Convert.ToDecimal(txtmrp.Text) * ((100 - _discountPercntage) / 100) / Convert.ToInt16(txtpackqty.Text);

                }
                else
                    _unitSaleRate = Convert.ToDecimal(txtmrp.Text) / Convert.ToInt16(txtpackqty.Text);

                txtUnitMrp.Text = _unitMRPRate.ToString("####.00");
            }
        }
        private decimal getDiscount(string itemId)
        {
            decimal DiscountPer = 0;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                GetProductDiscountByItemID p = new GetProductDiscountByItemID();
                p.unit_id = GlobalUsage.Unit_id; p.Itemid = _SelectedItem_Id; p.cardLevel = "Silver";
                p.ipdNo = txtIPOPNo.Text; p.orderNo = "-"; p.sold_qty = Convert.ToInt16(txtQty.Text);
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/GetProductDiscountByItemID", p);
                string[] dl = dwr.message.Split('|');
                DiscountPer = Convert.ToDecimal(dl[0]);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); DiscountPer = 0; }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            return DiscountPer;
        }
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (Config.isNumeric(txtQty.Text, System.Globalization.NumberStyles.Integer))
            {

                txtAmount.Text = Convert.ToDecimal(Convert.ToDecimal(txtQty.Text) * _unitSaleRate).ToString("####.00");
            }
        }

        private void txtmrp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
                txtQty.SelectAll();
            }
        }

        private void txtmrp_TextChanged(object sender, EventArgs e)
        {
            if (Config.isNumeric(txtmrp.Text, System.Globalization.NumberStyles.Float))
            {
                if (_discountFlag == "Y")
                    _unitSaleRate = Convert.ToDecimal(txtmrp.Text) * ((100 - _discountPercntage) / 100) / Convert.ToInt16(txtpackqty.Text);
                else
                    _unitSaleRate = Convert.ToDecimal(txtmrp.Text) / Convert.ToInt16(txtpackqty.Text);

                txtUnitMrp.Text = _unitSaleRate.ToString("####.00");
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {

                GridDataView dataView = this.rgvSalesGrid.MasterTemplate.DataView as GridDataView;
                List<manualBilling> mbList = new List<manualBilling>();

                foreach (GridViewRowInfo rowInfo in dataView.Indexer.Items)
                {
                    manualBilling mb = new manualBilling();
                    mb.mnlType = rowInfo.Cells["mnlType"].Value.ToString();
                    mb.item_id = rowInfo.Cells["item_id"].Value.ToString();
                    mb.item_name = rowInfo.Cells["item_name"].Value.ToString();
                    mb.pack_Type = rowInfo.Cells["pack_type"].Value.ToString();
                    mb.pack_Qty = Convert.ToInt16(rowInfo.Cells["pack_qty"].Value);
                    mb.batchNo = rowInfo.Cells["batchNo"].Value.ToString();
                    mb.exp_date = rowInfo.Cells["exp_date"].Value.ToString();
                    mb.disPer = Convert.ToDecimal(rowInfo.Cells["disPer"].Value);
                    mb.mrp = Convert.ToDecimal(rowInfo.Cells["mrp"].Value);
                    mb.discount = Convert.ToDecimal(rowInfo.Cells["discount"].Value);
                    mb.usr = Convert.ToDecimal(rowInfo.Cells["usr"].Value);
                    mb.SoldQty = Convert.ToInt16(rowInfo.Cells["SoldQty"].Value);
                    mb.Amount = Convert.ToDecimal(rowInfo.Cells["Amount"].Value);
                    mbList.Add(mb);
                }
                ip_manualBilling p = new ip_manualBilling();
                p.mbItemlist = mbList;
                p.custName = txtPatientName.Text;
                p.ipdNo = txtIPOPNo.Text;
                if (rbIPD.Checked)
                    p.ipopType = "IPD";
                else if (rbOPD.Checked)
                    p.ipopType = "OPD";
                else
                    p.ipopType = "Walk-In";


                p.loginId = GlobalUsage.Login_id;
                p.PayDetail = txtPaymentDetail.Text; p.uhid = _UHID; p.unit_id = GlobalUsage.Unit_id;
                p.Remarks = _panelName;

                p.payMode = _PayMode;
                p.CardNo = txtCardNo.Text;
                p.mobileNo = txtCardNo.Text;
                p.Logic = "Insert";
                p.refName = txtPrescribedBy.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/InsertSale_ManualBilling", p);
                if (!dwr.message.Contains("Success"))
                {
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
                else
                {
                    string[] h = dwr.message.Split(':');
                    Printing.Laser.PrintManualBill(h[1], "Y");
                    rgvSalesGrid.DataSource = new string[] { };
                    resetPatientInfo();
                    BillSummary();
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }
        private void BillSummary()
        {
            decimal total = 0; decimal discount = 0; decimal net = 0;
            foreach (GridViewRowInfo gvr in rgvSalesGrid.Rows)
            {
                _unitMRPRate = Convert.ToDecimal(gvr.Cells["mrp"].Value) / Convert.ToDecimal(gvr.Cells["pack_qty"].Value);
                total += (_unitMRPRate * Convert.ToDecimal(gvr.Cells["SoldQty"].Value));
                net += Convert.ToDecimal(gvr.Cells["Amount"].Value);
            }
            if (rgvSalesGrid.RowCount > 0)
            {
                net = Convert.ToInt32(net);
                discount = total - net;
                txtTotal.Text = total.ToString("######.00");
                txtDiscount.Text = discount.ToString("######.00");
                txtNetValue.Text = net.ToString("######.00");
            }
            else
            {
                txtTotal.Text = "0";
                txtDiscount.Text = "0";
                txtNetValue.Text = "0";
            }
        }

        private void txtIPOPNo_KeyDown(object sender, KeyEventArgs e)
        {
            string response = string.Empty; DataTable table = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                if (cbOldHIS.Checked)
                {
                    #region Old HIS Search
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        if (rbOPD.Checked)
                        {
                            response = GlobalUsage.his_proxy.getPatientLastAppointmentDetails(txtIPOPNo.Text);
                            table = JsonConvert.DeserializeObject<DataTable>(response);
                            if (table.Rows.Count > 0)
                            {
                                txtPatientName.Text = table.Rows[0]["pt_name"].ToString();
                                txtPrescribedBy.Text = table.Rows[0]["doctor_name"].ToString();
                            }
                            if (txtIPOPNo.Text.Length == 0)
                                _UHID = "-";
                            else
                                _UHID = txtIPOPNo.Text;
                        }
                        else if (rbIPD.Checked)
                        {
                            response = GlobalUsage.his_proxy.getPatientInfoByIPDNo(txtIPOPNo.Text);
                            table = JsonConvert.DeserializeObject<DataTable>(response);
                            if (table.Rows.Count > 0)
                            {
                                txtPatientName.Text = table.Rows[0]["PName"].ToString();
                                txtPrescribedBy.Text = table.Rows[0]["DName"].ToString();
                                _panelName = table.Rows[0]["Company_name"].ToString();
                                _UHID = table.Rows[0]["Patient_ID"].ToString();

                                if (table.Rows[0]["IsCash"].ToString() == "1")
                                {
                                    _PayMode = "Cash";
                                    radioCredit.Checked = false;
                                    radioCash.Enabled = true;
                                }
                                else
                                {
                                    _PayMode = "Credit";
                                    radioCredit.Checked = true;
                                    radioCash.Enabled = false;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        RadMessageBox.Show(ex.Message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                    #endregion
                }
                else
                {
                    #region New HIS Search
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        pm_HospitalQueries p = new pm_HospitalQueries();
                        if (rbOPD.Checked)
                        {
                            p.unit_id = GlobalUsage.Unit_id; p.logic = "ByUHIDNo"; p.prm_1 = txtIPOPNo.Text; p.prm_2 = "";
                            p.login_id = GlobalUsage.Login_id;
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/HospitalQueries", p);
                            table = dwr.result.Tables[0];
                            table = JsonConvert.DeserializeObject<DataTable>(response);
                            if (table.Rows.Count > 0)
                            {
                                txtPatientName.Text = table.Rows[0]["pt_name"].ToString();
                                txtPrescribedBy.Text = table.Rows[0]["doctor_name"].ToString();
                            }
                            _PayMode = "Cash";
                            if (txtIPOPNo.Text.Length == 0)
                                _UHID = "-";
                            else
                                _UHID = txtIPOPNo.Text;
                        }
                        else if (rbIPD.Checked)
                        {

                            p.unit_id = GlobalUsage.Unit_id; p.logic = "BYIPDNO"; p.prm_1 = txtIPOPNo.Text; p.prm_2 = "";
                            p.login_id = GlobalUsage.Login_id;
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/HospitalQueries", p);
                            table = dwr.result.Tables[0];
                            if (table.Rows.Count > 0)
                            {
                                txtPatientName.Text = table.Rows[0]["patient_name"].ToString();
                                txtPrescribedBy.Text = table.Rows[0]["DoctorName"].ToString();
                                _panelName = table.Rows[0]["Company_name"].ToString();
                                _UHID = table.Rows[0]["Patient_ID"].ToString();

                                if (table.Rows[0]["IsCash"].ToString() == "1")
                                {
                                    _PayMode = "Cash";
                                    radioCredit.Checked = false;
                                    radioCash.Enabled = true;
                                }
                                else
                                {
                                    _PayMode = "Credit";
                                    radioCredit.Checked = true;
                                    radioCash.Enabled = false;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        RadMessageBox.Show(ex.Message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                    #endregion
                }
            }
        }

        private void rdp_from_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void btnGetSales_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                pm_SaleRegister p = new pm_SaleRegister();
                p.unit_id = GlobalUsage.Unit_id; p.counter_id = GlobalUsage.CounterID;
                p.f_date = rdp_from.Value.ToString("yyyy/MM/dd"); p.l_date = rdp_to.Value.ToString("yyyy/MM/dd");
                p.sType = "ManualRegisterByID"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/saleregister", p);

                rgvRegister.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rgvRegister_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            _manualBillNo = e.Row.Cells["ManualInvNo"].Value.ToString();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_SaleRegister p = new pm_SaleRegister();
                p.unit_id = GlobalUsage.Unit_id; p.counter_id = GlobalUsage.CounterID;
                p.f_date = rdp_from.Value.ToString("yyyy/MM/dd"); p.l_date = rdp_to.Value.ToString("yyyy/MM/dd");
                p.prm_1 = _manualBillNo;
                p.sType = "ManualBillInfo"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/saleregister", p);

                rgvSoldItems.DataSource = dwr.result.Tables[0];
                if (rgvSoldItems.RowCount > 0)
                    btnPrint.Enabled = true;
                else
                    btnPrint.Enabled = false;
                if (e.Row.Cells["sale_inv_no"].Value.ToString() == "N/A")
                { rgChange.Enabled = true; btnChange.Enabled = true; }
                else
                    rgChange.Enabled = false;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Printing.Laser.PrintManualBill(rgvRegister.CurrentRow.Cells["ManualInvNo"].Value.ToString(), "Y");
                btnPrint.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rbIPD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIPD.Checked)
            {
                txtIPOPNo.Enabled = true;
                txtIPOPNo.Focus();
                rb_byCard.Enabled = false;
                rb_ByMobile.Enabled = false;
                txtCardNo.Enabled = false;
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


                    if (dwr.result.Tables[0].Rows.Count > 0)
                    {
                        lv_referralList.Visible = true;
                        foreach (DataRow dr in dwr.result.Tables[0].Rows)
                        {
                            ListViewItem li = new ListViewItem(dr["ref_name"].ToString());
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

        private void txtPrescribedBy_Leave(object sender, EventArgs e)
        {
            if (txtPrescribedBy.Text.ToUpper() == "SELF")
            { txtPrescribedBy.Text = "Distt. Hospital"; }
            else if (txtPrescribedBy.TextLength == 0)
                txtPrescribedBy.Focus();
        }

        private void txtExpDate_Leave(object sender, EventArgs e)
        {
            DateTime d; string expdate = "01-" + txtExpDate.Text;

            bool chValidity = DateTime.TryParseExact(expdate, "dd-MM-yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            if (!chValidity)
            { txtExpDate.Focus(); txtExpDate.SelectAll(); }

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

        private void rb_Extra_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Extra.Checked)
                txtMedName.Enabled = true;
            else
                txtMedName.Enabled = false;

        }

        private void rb_pruchaseNotIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pruchaseNotIn.Checked)
                txtMedName.Enabled = true;
            else
                txtMedName.Enabled = false;
        }

        private void MasterTemplate_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["sale_inv_no"].Value.ToString() == "N/A")
                e.RowElement.ForeColor = Color.Red;
            else if (e.RowElement.RowInfo.Cells["sale_inv_no"].Value.ToString() == "Cancel")
                e.RowElement.ForeColor = Color.Black;
            else
                e.RowElement.ForeColor = Color.Green;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                btnChange.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                cm1 p1 = new cm1();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                p1.prm_1 = GlobalUsage.Login_Name; p1.prm_2 = GlobalUsage.Login_Name;

                //if(rbCancel.Checked)
                //p1.Logic = "CancelManualBill";
                //else 
                if (rbchCash.Checked)
                {
                    p1.Logic = "ChangePayModeManualBill";
                    p1.prm_1 = "Cash";
                }
                else if (rbchSwipeCard.Checked)
                {
                    p1.Logic = "ChangePayModeManualBill";
                    p1.prm_1 = "Credit Card";
                }
                else if (rbchCredit.Checked)
                {
                    p1.Logic = "ChangePayModeManualBill";
                    p1.prm_1 = "Credit";
                }

                p1.prm_2 = _manualBillNo;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }// second
}
