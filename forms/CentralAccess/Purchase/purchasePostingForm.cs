using ExPro.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class purchasePostingForm : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        DataTable dt = new DataTable();
        DataSet _ds = new DataSet();
        string _PurchaseID = string.Empty; string _vendorName = string.Empty; string _vendorCode = string.Empty; string _CrLedgerName = string.Empty; string _CrLedgerCode = string.Empty;
        public event PurchaseBillPostingEventHandler PurchaseBillPosted;
        public purchasePostingForm(string purchaseid, string VendorName)
        {
            _PurchaseID = purchaseid;
            _vendorName = VendorName;
            InitializeComponent();
        }

        private void purchasePostingForm_Load(object sender, EventArgs e)
        {


            cmbCash_Credit.Text = "Select";
            //ucUploadScanedDoc1.DocId = _PurchaseID;
            //ucUploadScanedDoc1.DocType = "PurchaseBill";
            this.Text = "Purchase Id : " + _PurchaseID + " Vendor : " + _vendorName;
            Load_Info();
        }
        protected void Load_Info()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.pwcf.Purchase_Queries(out _result, GlobalUsage.Unit_id, _PurchaseID, "PurchBillInfo", "N/A", "N/A");
                rgv_TaxInfo.DataSource = ds.Tables[3];
                DataRow row = ds.Tables[1].Rows[0];
                txtInvNo.Text = row["inv_no"].ToString();
                txtInvDate.Text = Convert.ToDateTime(row["bill_date"]).ToString("dd-MM-yyyy");
                txtFinalTax.Text = Conversion.Val(row["inv_tax"].ToString()).ToString();
                txtAccu_Discount.Text = Conversion.Val(row["inv_discount"].ToString()).ToString();
                txtFinal_Total.Text = Conversion.Val(row["inv_total"].ToString()).ToString();
                txtFinal_Net.Text = Conversion.Val(row["netamount"].ToString()).ToString();
                txtRoundOff.Text = (Conversion.Val(row["netamount"].ToString()) - Conversion.Val(row["roundoff"].ToString())).ToString();
                txtAdjusted.Text = Convert.ToDecimal(row["adj_amount"]).ToString("##0");
                //txtPlusMinus.Text = Convert.ToDecimal(row["plus_minus_amount"]).ToString("##");
                txtBillAmount.Text = Conversion.Val(row["roundoff"].ToString()).ToString();
                txtItemNo.Text = Conversion.Val(row["itemNo"].ToString()).ToString();
                txtKeyNo.Text = Conversion.Val(row["KeyNo"].ToString()).ToString();
                txtFreeQty.Text = Conversion.Val(row["FreeQty"].ToString()).ToString("#0.00");

                if (row["inv_type"].ToString() == "T")
                    lblInvType.Text = "Inv. Type :: Tax Invoice";
                else if (row["inv_type"].ToString() == "E")
                    lblInvType.Text = "Inv. Type :: Estimate";
                else
                    lblInvType.Text = "Inv. Type :: Sales Invoice";


                #region Checking of XML File Purchase Related Person and Filling
                _ds = GlobalUsage.pwcf.Purchase_Queries(out _result, GlobalUsage.Unit_id, "", "EmpInPurchase", "ALL", "-");
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
                DataSet dsCashCredit = GlobalUsage.pwcf.Purchase_Queries(out _result, GlobalUsage.Unit_id, "-", "CashCreditBy", "-", "-");
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
            catch (Exception ex)
            { }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void txtPlusMinus_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPlusMinus.Text != "-" && txtPlusMinus.Text.Length != 0)
            {
                txtBillAmount.Text = (Conversion.Val(txtBillAmount.Text) + Convert.ToInt16(txtPlusMinus.Text)).ToString();
            }
        }

        private void rb_Complete_Click(object sender, EventArgs e)
        {

            if (cmbCash_Credit.Text.ToUpper() == "SELECT")
            {
                MessageBox.Show("Select Mode of Payment", "Bill Posting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCash_Credit.Focus();
                return;
            }
            if (((ExproComboBox)cmbPurchBy.SelectedItem).Value == "Select")
            {
                MessageBox.Show("Select Purchase By ", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPurchBy.Focus();
                return;
            }
            if (((ExproComboBox)cmbCheckBy.SelectedItem).Value == "Select")
            {
                MessageBox.Show("Select Checked By ", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCheckBy.Focus();
                return;
            }
            string caption;
            if (cmbCash_Credit.Text.ToUpper() == "CASH") { caption = "Do You Confirm To Post into " + _CrLedgerName + " A/C"; } else { caption = "Do You Confirm To Post The Bill in " + cmbCash_Credit.Text + " Mode"; }
            if (MessageBox.Show(caption, "Bill Posting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                string narration = string.Empty;
                if (lblChqDate.Visible)
                    narration = txtRemarks.Text;
                else
                    narration = _CrLedgerName;


                GlobalUsage.pwcf.Purchase_BillPosting(out _result, GlobalUsage.Unit_id, _PurchaseID, cmbCash_Credit.Text.ToUpper(), dtChqDate.Value.ToString("yyyy/MM/dd"), narration, GlobalUsage.Login_id, Convert.ToDecimal(Conversion.Val(txtAdjusted.Text).ToString()),
                  Convert.ToDecimal(Conversion.Val(txtPlusMinus.Text).ToString()), _CrLedgerCode, ((ExproComboBox)cmbPurchBy.SelectedItem).Value, ((ExproComboBox)cmbCheckBy.SelectedItem).Value);
                if (!_result.Contains("Successfully Posted."))
                    MessageBox.Show(_result, "Purchase Bill Posting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    PurchaseBillPostingEventArgs valueArgs = new PurchaseBillPostingEventArgs(_PurchaseID, _result);
                    PurchaseBillPosted(this, valueArgs);
                    this.Close();
                }
            }
            rb_Complete.Enabled = false;

        }

        private void txtAdjusted_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtPlusMinus.Focus();
        }

        private void cmbCash_Credit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCash_Credit.Text.ToUpper() == "CASH")
            {
                lblChqDate.Visible = false; dtChqDate.Visible = false;
                lblAc.Visible = true;
                cmb_Ledger.Enabled = true;
                cmb_Ledger.Visible = true;
                lblAc.Text = "Cr. A/C ";

                //string caption;
                //if (string.IsNullOrEmpty(_CrLedgerName)) { caption = "Do You Want To Select ?"; } else { caption = _CrLedgerName + " Selected. Do You Want To Change ?"; }
                //DialogResult result = MessageBox.Show(caption, "Advance Ledger Help", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                //{
                //    cmb_ledger.Visible = true;
                //}
            }
            else if (cmbCash_Credit.Text.ToUpper() == "CHEQUE")
            {
                lblAc.Visible = true;
                lblAc.Text = "Narration";
                cmb_Ledger.Visible = false;
                cmb_Ledger.Enabled = false;
                rb_Complete.Enabled = true;
                lblChqDate.Visible = true; dtChqDate.Visible = true;
            }
            else
            {
                _CrLedgerName = "";
                cmb_Ledger.Text = "Select Advance A/C";
                _CrLedgerCode = "";
                lblAc.Visible = false;
                cmb_Ledger.Visible = false;
                cmb_Ledger.Enabled = false;
                rb_Complete.Enabled = true;
                lblChqDate.Visible = false; dtChqDate.Visible = false;
            }
        }

        private void txtAdjusted_Leave(object sender, EventArgs e)
        {

        }


        private void purchasePostingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                PurchaseBillPostingEventArgs valueArgs = new PurchaseBillPostingEventArgs(_PurchaseID, "Cancelled By User");
                PurchaseBillPosted(this, valueArgs);
                this.Close();
            }
        }


        private void cmb_Ledger_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            _CrLedgerCode = cmb_Ledger.SelectedValue.ToString();

            _CrLedgerName = cmb_Ledger.SelectedItem.ToString();
        }

        private void btn_grAdjustment_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtAdjusted.Text) >= 0 && _PurchaseID != "AUTO GENERATE")
            {
                adjustGR useForm = new adjustGR(_PurchaseID, _vendorCode, Convert.ToDecimal(txtAdjusted.Text));
                useForm.Owner = this;
                useForm.Show();
            }

        }
    }
}
