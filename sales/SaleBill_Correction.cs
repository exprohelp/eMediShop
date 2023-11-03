using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.sales
{
    public partial class SaleBill_Correction : Telerik.WinControls.UI.RadForm
    {
        public event BillPostingEventHandler eventBillUpdated;
        string _saleInvNo = string.Empty;
        string _customername = string.Empty; string _card_no = string.Empty; string _mobileNo = string.Empty;
        string _panelType = string.Empty; string _prescribedBy = string.Empty; string _uhidNo = string.Empty;
        string _ipopNo = string.Empty; string _panelName = string.Empty; string _partyAccountNo = string.Empty;
        string _orderNo = string.Empty; string _machineAccountNo = string.Empty; string _homeDelivery = string.Empty;
        Int32 _amount = 0; string _msgToCustomer = string.Empty; string _callFrom = string.Empty;
        string _oldInvNo = string.Empty;
        public SaleBill_Correction()
        {
            InitializeComponent();
        }

        private void SaleBill_Posting_Load(object sender, EventArgs e)
        {
            swipeMachines();
        }


        private void swipeMachines()
        {
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "SwipeMachines"; p.prm_1 = "-"; p.prm_2 = "-"; p.prm_3 = "-";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                DataTable dtSwipeMacInfo = dwr.result.Tables[0];
                ddlMachineType.Items.AddRange(Config.FillTelrikCombo(dtSwipeMacInfo, true));
                ddlMachineType.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                RadMessageBox.Show(e.Message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }
        private void txtCash_Enter(object sender, EventArgs e)
        {
            txtCash.SelectAll();
        }

        private void txtSwipeCard_Enter(object sender, EventArgs e)
        {
            txtSwipeCard.SelectAll();
        }

        private void txtNEFT_RTGS_Enter(object sender, EventArgs e)
        {
            txtNEFT_RTGS.SelectAll();
        }


        private void txtCash_Leave(object sender, EventArgs e)
        {
            //isDistribution();
        }

        private void txtSwipeCard_Leave(object sender, EventArgs e)
        {
            //isDistribution();
        }

        private void txtNEFT_RTGS_Leave(object sender, EventArgs e)
        {
            //isDistribution();
        }

        private void txtChq_Leave(object sender, EventArgs e)
        {
            //Distribution();
        }

        private void txtCash_Validating(object sender, CancelEventArgs e)
        {
            if (!Config.isNumeric(txtCash.Text, System.Globalization.NumberStyles.Integer))
            {
                txtCash.Focus();
                txtCash.SelectAll();
            }
        }

        private void txtSwipeCard_Validated(object sender, EventArgs e)
        {
            if (!Config.isNumeric(txtSwipeCard.Text, System.Globalization.NumberStyles.Integer))
            {
                txtSwipeCard.Focus();
                txtSwipeCard.SelectAll();
            }

        }

        private void txtNEFT_RTGS_Validating(object sender, CancelEventArgs e)
        {
            if (!Config.isNumeric(txtNEFT_RTGS.Text, System.Globalization.NumberStyles.Integer))
            {
                txtNEFT_RTGS.Focus();
                txtNEFT_RTGS.SelectAll();
            }

        }



        private void isDistribution(string value)
        {
            if (Config.isNumeric(value, System.Globalization.NumberStyles.Integer))
            {
                double totalDistribution = 0;
                totalDistribution = System.Math.Abs(Convert.ToDouble(txtCash.Text)) + System.Math.Abs(Convert.ToDouble(txtSwipeCard.Text)) +
                    System.Math.Abs(Convert.ToDouble(txtNEFT_RTGS.Text)) + System.Math.Abs(Convert.ToDouble(txtWalletRedeem.Text));
                txtBalAllo.Text = (System.Math.Abs(Convert.ToDouble(txtnetPayable.Text)) - totalDistribution).ToString();
                if (Convert.ToDouble(txtBalAllo.Text) == 0)
                    btnBillPosting.Enabled = true;
                else
                {
                    btnBillPosting.Enabled = false;
                    // RadMessageBox.Show("Amount Allocation Not Correct.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

                }
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            isDistribution(txtCash.Text);
        }

        private void txtSwipeCard_TextChanged(object sender, EventArgs e)
        {
            isDistribution(txtSwipeCard.Text);
            if (Convert.ToInt32(txtSwipeCard.Text) > 0)
            {
                ddlMachineType.Enabled = true;
                txtReferenceNo.Enabled = true;
            }
            else
            {
                ddlMachineType.Enabled = false;
                txtReferenceNo.Enabled = false;
            }
        }

        private void txtNEFT_RTGS_TextChanged(object sender, EventArgs e)
        {
            isDistribution(txtNEFT_RTGS.Text);
            if (Convert.ToInt32(txtNEFT_RTGS.Text) > 0)
            {

                txtNEFT_Remarks.Enabled = true;
            }
            else
            {
                txtNEFT_Remarks.Enabled = false;
            }
        }

        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Convert.ToDouble(txtBalAllo.Text) > 0)
            {
                txtSwipeCard.Focus();
                txtSwipeCard.SelectAll();
            }
        }

        private void btnBillPosting_Click(object sender, EventArgs e)
        {
            #region Validation
            if (Convert.ToDouble(txtSwipeCard.Text) > 0 && txtReferenceNo.Text.Length < 5)
            {
                txtReferenceNo.Focus();
                txtReferenceNo.SelectAll();
                return;
            }
            if (Convert.ToDouble(txtNEFT_RTGS.Text) > 0 && txtNEFT_Remarks.Text.Length < 5)
            {
                txtNEFT_Remarks.Focus();
                txtNEFT_Remarks.SelectAll();
                return;
            }
            #endregion

            List<BillPaymentInfo> bpiList = new List<BillPaymentInfo>();

            BillPaymentInfo bpi = new BillPaymentInfo();

            if (txtPanelType.Text.ToUpper() == "CREDIT")
            {
                bpi.unit_id = GlobalUsage.Unit_id;
                bpi.InvNo = txtInvoiceNo.Text;
                bpi.PayMode = "Credit";
                bpi.AccountNo = _partyAccountNo;
                bpi.Amount = Convert.ToDecimal(txtnetPayable.Text);
                bpi.referenceNo = "-";
                bpi.PayDetail = "-";
                bpiList.Add(bpi);
            }

            if (Convert.ToInt32(txtWalletRedeem.Text) != 0)
            {
                bpi = new BillPaymentInfo();
                bpi.unit_id = GlobalUsage.Unit_id;
                bpi.InvNo = txtInvoiceNo.Text;
                bpi.PayMode = "Wallet";
                bpi.AccountNo = "16031145";
                bpi.Amount = Convert.ToDecimal(txtWalletRedeem.Text);
                bpi.referenceNo = txtMobileNo.Text;
                bpi.PayDetail = _msgToCustomer;
                bpiList.Add(bpi);
            }
            if (Convert.ToInt32(txtCash.Text) != 0)
            {
                bpi = new BillPaymentInfo();
                bpi.unit_id = GlobalUsage.Unit_id;
                bpi.InvNo = txtInvoiceNo.Text;
                bpi.PayMode = "Cash";
                bpi.AccountNo = "16040001";
                bpi.Amount = Convert.ToDecimal(txtCash.Text);
                bpi.referenceNo = "-";
                bpi.PayDetail = "By Cash";
                bpiList.Add(bpi);
            }
            if (Convert.ToInt32(txtSwipeCard.Text) > 0)
            {
                _machineAccountNo = ddlMachineType.SelectedValue.ToString();
                if (_machineAccountNo.ToUpper() == "SELECT")
                {
                    RadMessageBox.Show("Payment Machine not Selected.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }

            if (Convert.ToInt32(txtSwipeCard.Text) > 0)
            {
                bpi = new BillPaymentInfo();
                bpi.unit_id = GlobalUsage.Unit_id;
                bpi.InvNo = txtInvoiceNo.Text;
                bpi.PayMode = "Swipe Card";
                bpi.AccountNo = _machineAccountNo;
                bpi.Amount = Convert.ToDecimal(txtSwipeCard.Text);
                bpi.referenceNo = txtReferenceNo.Text;
                bpi.PayDetail = "-";
                bpiList.Add(bpi);
            }
            if (Convert.ToInt32(txtNEFT_RTGS.Text) > 0)
            {
                bpi = new BillPaymentInfo();
                bpi.unit_id = GlobalUsage.Unit_id;
                bpi.InvNo = txtInvoiceNo.Text;
                bpi.PayMode = "NEFT-RTGS";
                bpi.AccountNo = "16070014";
                bpi.Amount = Convert.ToDecimal(txtNEFT_RTGS.Text);
                bpi.referenceNo = "-";
                bpi.PayDetail = txtNEFT_Remarks.Text;
                bpiList.Add(bpi);
            }




            DialogResult dr = MessageBox.Show("Do You Confirm To Update The Bill No. " + txtInvoiceNo.Text + " ? ", "ExPro Help", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        RetailSaleBillPosting p = new RetailSaleBillPosting();
                        p.unit_id = GlobalUsage.Unit_id;
                        p.Sale_Inv_No = txtInvoiceNo.Text;
                        p.BillPaymentDetail = bpiList;
                        p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailSalesReceiptCorrection", p);

                        if (!dwr.message.Contains("Success"))
                            MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btngetInfo.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case DialogResult.No: break;
            }



        }

        private void txtSwipeCard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReferenceNo.Focus();
                txtReferenceNo.SelectAll();
            }
        }

        private void txtNEFT_RTGS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNEFT_Remarks.Focus();
                txtNEFT_Remarks.SelectAll();
            }
        }

        private void txtChq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNEFT_Remarks.Focus();
                txtNEFT_Remarks.SelectAll();
            }
        }

        private void txtSwipeCard_Remarks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Convert.ToDouble(txtBalAllo.Text) > 0)
            {
                txtNEFT_RTGS.Focus();
                txtNEFT_RTGS.SelectAll();
            }
        }

        private void txtNEFT_Remarks_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ddlMachineType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            _machineAccountNo = ddlMachineType.SelectedValue.ToString();
        }







        private void btngetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "PayModeCorrection"; p.prm_1 = txtInvoiceNo.Text; p.prm_2 = "-"; p.prm_3 = "-";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

                if (dwr.result.Tables.Count > 1)
                {
                    DataRow dr;
                    dr = dwr.result.Tables[0].Rows[0];
                    txtCustomerName.Text = dr["pt_name"].ToString(); txtPrescribedBy.Text = dr["ref_name"].ToString();
                    txtUHID.Text = dr["ref_name"].ToString(); ; txtIPOPNo.Text = dr["ref_name"].ToString();
                    txtPanelName.Text = dr["panelName"].ToString(); txtPanelType.Text = dr["pay_mode"].ToString();
                    txtnetPayable.Text = Convert.ToInt32(dr["net"]).ToString("#####0");
                    txtMobileNo.Text = dr["contactNo"].ToString();

                    foreach (DataRow row in dwr.result.Tables[1].Rows)
                    {
                        _amount = Convert.ToInt32(row["Amount"]);
                        if (row["PayMode"].ToString().ToUpper() == "CASH" && _amount != 0)
                            txtCash.Text = _amount.ToString("#####0");
                        else if (row["PayMode"].ToString().ToUpper() == "Wallet" && _amount != 0)
                            txtWalletRedeem.Text = _amount.ToString("#####0");
                        else if (row["PayMode"].ToString().ToUpper() == "SWIPE CARD" && _amount != 0)
                        {
                            txtSwipeCard.Text = _amount.ToString("#####0");
                            txtReferenceNo.Text = row["RefNo"].ToString();
                            ddlMachineType.SelectedValue = row["AcLedgerID"].ToString();
                            _machineAccountNo = row["AcLedgerID"].ToString();
                        }
                        else if (row["PayMode"].ToString().ToUpper() == "NEFT-RTGS" && _amount != 0)
                        {
                            txtNEFT_RTGS.Text = _amount.ToString("#####0");
                            txtNEFT_Remarks.Text = row["RefNo"].ToString();
                        }
                    }

                }
                else
                    RadMessageBox.Show("Information Not Available/Credit Bill No.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }



            //if (_panelType.ToUpper() == "CREDIT")
            //{ pnlPayments.Enabled = false; txtCash.Text = "0"; }
            //else
            //{ pnlPayments.Enabled = true; txtCash.Text = txtnetPayable.Text; }

        }

        private void txtInvoiceNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btngetInfo.PerformClick();
        }
    }
}
