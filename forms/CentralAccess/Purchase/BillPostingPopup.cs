using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ExPro.Client;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class BillPostingPopup : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty; decimal _tcsPer = 0; string _tcsFlag = "N";
        string _purch_id = string.Empty; Int32 _adjAmount = 0; decimal _ohCharges = 0;
        string _vendorName = string.Empty; string _vendorCode = string.Empty;
        decimal _BillAmount = 0;
        public event SearchUpdateEventHandler SearchUpdated;
        public BillPostingPopup(string PurchaseId, Int32 adjAmount, string vendorName, string vendorCode)
        {
            _purch_id = PurchaseId; _adjAmount = adjAmount; _vendorName = vendorName; _vendorCode = vendorCode;

            InitializeComponent();
        }
        private void BillPostingPopup_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "PURCHASE BILL POSTING OF [ " + _purch_id + " ] Vendor :" + _vendorName;
            this.Text = lblHeader.Text;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                #region Filling Purchase Posting Information
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = _purch_id; p.logic = "PurchBillInfo"; p.prm_1 = "-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                DataSet ds = dwr.result;

                rgv_TaxInfo.DataSource = ds.Tables[3];
                #region Summary Of Purchase BIll
                if (ds.Tables[1].Rows.Count > 0)
                {
                    DataRow dr1 = ds.Tables[1].Rows[0];
                    _tcsPer = Convert.ToDecimal(ds.Tables[0].Rows[0]["tcsPer"]);
                    txtFinalTax.Text = Convert.ToDecimal(dr1["inv_tax"]).ToString("##.00");
                    txtAccu_Discount.Text = Convert.ToDecimal(dr1["inv_discount"]).ToString("##.00");
                    txtFinal_Total.Text = Convert.ToDecimal(dr1["inv_total"]).ToString("##.00");
                    txtFinal_Net.Text = Convert.ToDecimal(dr1["netamount"]).ToString("##.00");
                    txtAdjusted.Text = _adjAmount.ToString();//Convert.ToDecimal(dr1["adj_amount"]).ToString("0");
                    txtRoundOff.Text = Convert.ToDecimal(dr1["decpart"]).ToString("##.00");
                    txtBillAmount.Text = Convert.ToDecimal(dr1["roundoff"]).ToString("#####");
                    _BillAmount = Convert.ToDecimal(dr1["roundoff"]);
                    txtItemNo.Text = Conversion.Val(dr1["itemNo"].ToString()).ToString();
                    txtKeyNo.Text = Conversion.Val(dr1["KeyNo"].ToString()).ToString();
                    txtFreeQty.Text = Conversion.Val(dr1["FreeQty"].ToString()).ToString("#0.00");
                    if (dr1["inv_type"].ToString() == "T")
                        lblInvType.Text = "Inv. Type :: Tax Invoice";
                    else if (dr1["inv_type"].ToString() == "E")
                        lblInvType.Text = "Inv. Type :: Estimate";
                    else
                        lblInvType.Text = "Inv. Type :: Sales Invoice";
                    if (dr1["purch_vch_id"].ToString().Length > 10)
                        btnComplete.Enabled = false;
                    else
                        btnComplete.Enabled = true;
                }
                #endregion
                #endregion
                #region Checking of XML File Purchase Related Person and Filling
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "EmpInPurchase"; p.prm_1 = "ALL"; p.prm_2 = "-";
                dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                var Purch_Emp = from x in _ds.Tables[0].AsEnumerable()
                                    // where x.Field<string>("ForUse") == "PurchBy"
                                select new { emp_code = x.Field<string>("emp_code"), emp_name = x.Field<string>("emp_name") };
                var Check_Emp = from x in _ds.Tables[1].AsEnumerable()
                                    //where x.Field<string>("ForUse") == "CheckBy"
                                select new { emp_code = x.Field<string>("emp_code"), emp_name = x.Field<string>("emp_name") };
                cmbCheckBy.Items.Add(new AddValue("Select", "Select"));
                cmbPurchBy.Items.Add(new AddValue("Select", "Select"));
                foreach (var e1 in Purch_Emp)
                {
                    cmbPurchBy.Items.Add(new AddValue(e1.emp_code, e1.emp_name));
                }
                if (cmbPurchBy.Items.Count == 2)
                    cmbPurchBy.SelectedIndex = 1;
                else
                    cmbPurchBy.SelectedIndex = 0;
                foreach (var e1 in Check_Emp)
                {
                    cmbCheckBy.Items.Add(new AddValue(e1.emp_code, e1.emp_name));
                }

                if (cmbCheckBy.Items.Count == 2)
                    cmbCheckBy.SelectedIndex = 1;
                else
                    cmbCheckBy.SelectedIndex = 0;
                #endregion
                #region Filling of Purchase Posting Ledger
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "CashCreditBy"; p.prm_1 = "-"; p.prm_2 = "-";
                dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                DataSet dsCashCredit = dwr.result;
                cmbCash_Credit.Items.Clear();
                cmbCash_Credit.Items.Add(new AddValue("Select", "Select"));
                cmbCash_Credit.Items.Add(new AddValue("Cheque", "Cheque"));
                foreach (DataRow dr in dsCashCredit.Tables[0].Rows)
                {
                    cmbCash_Credit.Items.Add(new AddValue(dr["ld_code"].ToString(), dr["ld_name"].ToString()));
                }
                #endregion
                cmbCash_Credit.SelectedIndex = 0;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (txtOhCharges.Text.Length == 0)
                txtOhCharges.Text = "0";

            string CrLedgerCode = ((AddValue)cmbCash_Credit.SelectedItem).Value;
            string PayMode = string.Empty;
            if (CrLedgerCode.ToUpper() == "CREDIT")
                PayMode = "Credit";
            else if (((AddValue)cmbCash_Credit.SelectedItem).NewDescription.ToUpper().Contains("ADV"))
                PayMode = "Cash";
            else if (CrLedgerCode.ToUpper() == "CHEQUE") PayMode = "Cheque";
            btnComplete.Enabled = false;
            if (((AddValue)cmbPurchBy.SelectedItem).Value == "Select")
            {
                RadMessageBox.Show("Select Purchase By ", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                cmbPurchBy.Focus();
                return;
            }
            if (((AddValue)cmbCheckBy.SelectedItem).Value == "Select")
            {
                RadMessageBox.Show("Select Checked By ", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                cmbCheckBy.Focus();
                return;
            }
            if (cmbCash_Credit.Text.ToUpper() == "SELECT")
            {
                RadMessageBox.Show("Select Mode of Payment", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                cmbCash_Credit.Focus();
                return;
            }
            else if (_purch_id == "Auto Generate")
            {
                RadMessageBox.Show("purchase Id Can Not be Auto Generate", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                btnComplete.Focus();
                return;
            }
            if (RadMessageBox.Show("Do You Confirm To Post The Bill in " + cmbCash_Credit.Text, "Purchase Bill Posting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DialogResult res = RadMessageBox.Show("Do You Confirm To Post The Purchase ID : " + _purch_id, "Purchase Posting Confirmation", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        pm_PurchasePosting p = new pm_PurchasePosting();
                        p.unit_id = GlobalUsage.Unit_id; p.tcs_flag = _tcsFlag;
                        p.purch_id = _purch_id; p.credit_cash = PayMode; p.Chq_date = dtChqDate.Value.ToString("yyyy/MM/dd");
                        p.Narration = txtNarration.Text; p.login_id = GlobalUsage.Login_id;
                        p.adj_amt = Convert.ToDecimal(ExPro.Client.Conversion.Val(txtAdjusted.Text).ToString());
                        p.plusminus = Convert.ToDecimal(ExPro.Client.Conversion.Val(txtPlusMinus.Text).ToString());
                        p.CrAdvLedger = CrLedgerCode; p.ohCharges = txtOhCharges.Text; p.ohNature = "Freight Charges";
                        p.purch_By = ((AddValue)cmbPurchBy.SelectedItem).Value.ToString();
                        p.chkd_by = ((AddValue)cmbCheckBy.SelectedItem).Value.ToString();

                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseBillPosting", p);

                        if (dwr.message.Contains("Fail"))
                            RadMessageBox.Show(_result, "Purchase Bill(" + _purch_id + ") Posting", MessageBoxButtons.OK, RadMessageIcon.Info);
                        else
                        {
                            SearchUpdatedEventArgs valueArgs = new SearchUpdatedEventArgs("Successfully Posted.");
                            SearchUpdated(this, valueArgs);
                            this.Close();
                        }
                        Cursor.Current = Cursors.Default;
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                }

            }
        }


        private void Reset_FeedingForm(object sender, SearchUpdatedEventArgs e)
        {
            #region Checking of XML File Purchase Related Person and Filling
            string xmlFile = Application.StartupPath + "\\EmpInPurchase.XML";
            pm_PurchaseQueries p = new pm_PurchaseQueries();
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "EmpInPurchase"; p.prm_1 = "ALL"; p.prm_2 = "-";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
            _ds = dwr.result;
            _ds.WriteXml(xmlFile);
            if (e.ProductID == "PurchBy")
            {
                var Purch_Emp = from x in _ds.Tables[0].AsEnumerable()
                                where x.Field<string>("ForUse") == "PurchBy"
                                select new { emp_code = x.Field<string>("emp_code"), emp_name = x.Field<string>("emp_name") };
                cmbPurchBy.Items.Clear();
                cmbPurchBy.Items.Add(new AddValue("Select", "Select"));
                foreach (var e1 in Purch_Emp)
                {
                    cmbPurchBy.Items.Add(new AddValue(e1.emp_code, e1.emp_name));
                }
                cmbPurchBy.SelectedIndex = 0;
            }
            if (e.ProductID == "CheckBy")
            {
                var Check_Emp = from x in _ds.Tables[0].AsEnumerable()
                                where x.Field<string>("ForUse") == "CheckBy"
                                select new { emp_code = x.Field<string>("emp_code"), emp_name = x.Field<string>("emp_name") };
                cmbCheckBy.Items.Clear();
                cmbCheckBy.Items.Add(new AddValue("Select", "Select"));
                foreach (var e1 in Check_Emp)
                {
                    cmbCheckBy.Items.Add(new AddValue(e1.emp_code, e1.emp_name));
                }
                cmbCheckBy.SelectedIndex = 0;
            }
            #endregion
        }

        private void cmbCash_Credit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((AddValue)cmbCash_Credit.SelectedItem).Value.ToUpper() == "CHEQUE")
            {
                dtChqDate.Enabled = true;
            }
            else
                dtChqDate.Enabled = false;
        }

        private void rc_tcs_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rc_tcs.Checked)
            {
                txttcsAmt.Text = (Convert.ToDecimal(txtFinal_Net.Text) * _tcsPer / 100).ToString("###0.00");
                _tcsFlag = "Y";
                txtBillAmount.Text = (Convert.ToDecimal(txtBillAmount.Text) + Convert.ToDecimal(txttcsAmt.Text)).ToString("####00");
            }
            else if (!rc_tcs.Checked)
            {
                txtBillAmount.Text = (Convert.ToDecimal(txtBillAmount.Text) - Convert.ToDecimal(txttcsAmt.Text)).ToString("####00");
                txttcsAmt.Text = "0"; _tcsFlag = "N";
            }

        }

        private void txtOhCharges_Leave(object sender, EventArgs e)
        {
            if (txtOhCharges.Text.Length > 0)
            {
                decimal ohCharges;
                var Result = decimal.TryParse(txtOhCharges.Text, out ohCharges);
                if (ohCharges > 0)
                    txtBillAmount.Text = (Convert.ToDecimal(txtBillAmount.Text) + ohCharges).ToString("##0");
                else
                    txtBillAmount.Text = _BillAmount.ToString("##0");
            }
            else
            {
                txtBillAmount.Text = _BillAmount.ToString("##0");
            }
        }
    }
}
