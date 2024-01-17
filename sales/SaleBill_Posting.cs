using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.sales
{
    public partial class SaleBill_Posting : Telerik.WinControls.UI.RadForm
    {
        public event BillPostingEventHandler eventBillUpdated;
        string _saleInvNo = string.Empty;
        string _customername = string.Empty; string _card_no = string.Empty; string _mobileNo = string.Empty;
        string _panelType = string.Empty; string _prescribedBy = string.Empty; string _uhidNo = string.Empty;
        string _ipopNo = string.Empty; string _panelName = string.Empty; string _partyAccountNo = string.Empty;
        string _orderNo = string.Empty; string _machineAccountNo = string.Empty; string _homeDelivery = string.Empty;
        Int32 _amount = 0; string _msgToCustomer = string.Empty; string _callFrom = string.Empty;
        string _oldInvNo = string.Empty;
        public SaleBill_Posting(BillPosting billInfo)
        {
            _saleInvNo = billInfo.sale_inv_no; _customername = billInfo.customer_name; _card_no = billInfo.card_no;
            _panelType = billInfo.panelType; _prescribedBy = billInfo.prescribedBy; _ipopNo = billInfo.ipopNo;
            _uhidNo = billInfo.uhidNo; _panelName = billInfo.panelName; _panelType = billInfo.panelType;
            _amount = billInfo.amount; _partyAccountNo = billInfo.AccountID; _mobileNo = billInfo.mobileNo;
            _homeDelivery = "N"; _callFrom = billInfo.CallFrom; _oldInvNo = billInfo.Oldsale_inv_no;
            _orderNo = billInfo.orderNo;
            InitializeComponent();
        }

        private void SaleBill_Posting_Load(object sender, EventArgs e)
        {
            this.Text = "Sales Invoice Posting::" + _customername + " {" + _saleInvNo + "}";
            txtEstimateNo.Text = _saleInvNo; txtCustomerName.Text = _customername; txtPrescribedBy.Text = _prescribedBy;
            txtUHID.Text = _uhidNo; txtIPOPNo.Text = _ipopNo; txtPanelName.Text = _panelName; txtPanelType.Text = _panelType;
            txtnetPayable.Text = _amount.ToString();  txtMobileNo.Text = _mobileNo;
            
            #region Old Sales Information
            if(_oldInvNo!=null && _oldInvNo.Length>6 && _amount<0)
            { 
                try
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "OldSalesInfo"; p.prm_1 = _oldInvNo; p.prm_2 = "-"; p.prm_3 = "-";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                    DataTable dt = dwr.result.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        txtMobileNo.Text = dr["contactNo"].ToString();
                        if (Convert.ToInt32(dr["dlvChgs"])!=0 && Convert.ToInt32(dr["net"])==_amount)
                        {
                            chkHomeDelivery.Checked = true;
                            pnlPayments.Enabled = false;
                            txtCash.ReadOnly = true;
                            txtSwipeCard.ReadOnly = true;
                            txtNEFT_RTGS.ReadOnly = true;
                        }
                        else if (_amount<0 )
                        {
                            pnlPayments.Enabled = false;
                            txtCash.ReadOnly = true;
                            txtSwipeCard.ReadOnly = true;
                            txtNEFT_RTGS.ReadOnly = true;
                        }
                        if(dr["pay_mode"].ToString() == "Credit")
                        {
                            _panelType = dr["pay_mode"].ToString();
                            txtPanelType.Text = _panelType;
                            _partyAccountNo = dr["account_id"].ToString(); ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            #endregion




            if (_homeDelivery == "Y")
            {
                chkHomeDelivery.Checked = true;
                chkHomeDelivery.Enabled = false;
            }
            else
            {
                chkHomeDelivery.Checked = false;
                chkHomeDelivery.Enabled = true;

            }
            if (_amount < 0)
                chkHomeDelivery.Enabled = false;

            if (_callFrom == "IPD")
                pnlWallet.Enabled = false;
            else
                pnlWallet.Enabled = true;
            if (_panelType.ToUpper() == "CREDIT")
            { pnlWallet.Enabled = false; pnlPayments.Enabled = false; txtCash.Text = "0";}
            else
            { pnlWallet.Enabled = true; pnlPayments.Enabled = true; txtCash.Text = txtnetPayable.Text;}


                swipeMachines();
            txtWalletBalance.Text = "0";
            if(_amount<0)
                GetWalletUsedAmount(_oldInvNo);
            else
            GetWalletBalance(_mobileNo);
        }
        private void GetWalletUsedAmount(string OldSalesInvNo)
        {
            try
            {
                WalletMoney p = new WalletMoney();
                p.unitID = GlobalUsage.Unit_id; p.walletID = "-";p.prm_1 = OldSalesInvNo; p.Logic = "WB-Used"; p.loginId = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WalletQueries", p);
                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    Int32 WalletUsedAmt= Convert.ToInt32(dwr.result.Tables[0].Rows[0]["WalletUsedAmt"]);
                    if (System.Math.Abs(_amount) >= WalletUsedAmt)
                    { txtWalletRedeem.Text = (WalletUsedAmt).ToString(); }
                    else if (System.Math.Abs(_amount) < WalletUsedAmt)
                    {
                        txtWalletRedeem.Text = _amount.ToString();
                    }
                    txtCash.Text = (_amount - WalletUsedAmt).ToString();
                }
                if (Convert.ToInt32(txtWalletBalance.Text) > 0 && _amount > 0)
                    pnlWallet.Enabled = true;
                else
                    pnlWallet.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void GetWalletBalance(string WalletID)
        {
            try
            {
                WalletMoney p = new WalletMoney();
                p.unitID = GlobalUsage.Unit_id; p.walletID = WalletID; p.Logic = "WB"; p.loginId = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WalletQueries", p);
                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    txtWalletBalance.Text = dwr.result.Tables[0].Rows[0]["WalletBalance"].ToString();
                    if (_amount >= Convert.ToInt32(txtWalletBalance.Text))
                    { txtRedeemAmount.Text = txtWalletBalance.Text; }
                    else if (_amount < Convert.ToInt32(txtWalletBalance.Text))
                    {
                        txtRedeemAmount.Text = _amount.ToString();
                    }

                }
                if (Convert.ToInt32(txtWalletBalance.Text) > 0 && _amount>0 )
                    pnlWallet.Enabled = true;
                else
                    pnlWallet.Enabled = false;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
            btnBillPosting.Enabled = false;
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
                bpi.InvNo = txtEstimateNo.Text;
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
                bpi.InvNo = txtEstimateNo.Text;
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
                bpi.InvNo = txtEstimateNo.Text;
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
                bpi.InvNo = txtEstimateNo.Text;
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
                bpi.InvNo = txtEstimateNo.Text;
                bpi.PayMode = "NEFT-RTGS";
                bpi.AccountNo = "16070014";
                bpi.Amount = Convert.ToDecimal(txtNEFT_RTGS.Text);
                bpi.referenceNo = "-";
                bpi.PayDetail = txtNEFT_Remarks.Text;
                bpiList.Add(bpi);
            }



            if (GlobalUsage.Posting_Rights == "Y")
            {
                DialogResult dr = MessageBox.Show("Do You Confirm To Finalize The Bill No. " + txtEstimateNo.Text + " ? ", "ExPro Help", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        try
                        {
                            RetailSaleBillPosting p = new RetailSaleBillPosting();
                            p.unit_id = GlobalUsage.Unit_id; p.computerName = GlobalUsage.computerName;
                            p.counter_id = GlobalUsage.CounterID; p.Sale_Inv_No = txtEstimateNo.Text; p.pt_name = txtCustomerName.Text;
                            p.gstn_no = "-"; p.HealthCardNo = _card_no; p.Hosp_Cr_No = txtUHID.Text; p.Hosp_IPOP_No = txtIPOPNo.Text;
                            p.OrderNo = _orderNo;p.ContactNo = _mobileNo;
                            p.hd_flag = _homeDelivery;
                            p.refBy = "New";
                            p.ref_name = txtPrescribedBy.Text;
                            p.BillPaymentDetail = bpiList;
                            p.login_id = GlobalUsage.Login_id;
                            p.couponCode = GlobalUsage.couponCode;
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailSalesBillPosting", p);

                            if (!dwr.message.Contains("Success"))
                                MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                string[] s = dwr.message.Split(':');
                                _saleInvNo = s[1];
                                #region Upgrad Health Card
                                if (_card_no.Length > 5 && s[2] == "N")
                                {
                                    ipCardUpgrade pc = new ipCardUpgrade();
                                    pc.healthCardNo = _card_no; pc.unit_id = p.unit_id; pc.sale_inv_no = _saleInvNo;
                                    pc.billAmt = txtnetPayable.Text; pc.sale_Date = DateTime.Now.ToString("yyyy-MM-dd");
                                    pc.order_no = _orderNo; pc.division = "Pharmacy";
                                    string upgradeAPI = "HealthCard/HealthcardUpgradeProcess";
                                    resultSetMIS dwrCard = MISProxy.CallMISWebApiMethod(upgradeAPI, pc);

                                    if (dwrCard.Msg.Contains("Success"))
                                    {
                                        cm1 p1 = new cm1();
                                        p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                                        p1.Logic = "sale_master:cardUpgrd_Flag"; p1.prm_1 = "Y"; p1.tran_id = _saleInvNo;
                                        datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);

                                    }
                                }
                                #endregion
                                BillPostingUpdatedEventArgs ValuArgs = new BillPostingUpdatedEventArgs(_saleInvNo, "POSTED");
                                eventBillUpdated(this, ValuArgs);
                                Cursor.Current = Cursors.Default;
                                this.Close();
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
            else
            {
                RadMessageBox.Show("Posting of Bill Not Allowed.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
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

        }

        private void btnOTPVerify_Click(object sender, EventArgs e)
        {
            cm1 p1 = new cm1();
            p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id; p1.prm_3 = GlobalUsage.Login_id;
            p1.Logic = "VerifyOTP"; p1.prm_1 = txtWalletOTP.Text; p1.tran_id = txtEstimateNo.Text;
            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
            if(dwr1.message==null)
            {
                lblWalletVerifyresult.ForeColor = Color.Red;
                lblWalletVerifyresult.Text = "Fail to Verify";
            }
            else if (dwr1.message.Contains("Success"))
            {
                lblWalletVerifyresult.ForeColor = Color.Green; lblWalletVerifyresult.Text = "Verified";
                txtWalletRedeem.Text = txtRedeemAmount.Text;
                txtCash.Text = (_amount - Convert.ToInt32(txtWalletRedeem.Text)).ToString();
                isDistribution(txtWalletRedeem.Text);
                btnOTPVerify.Enabled = false;
            }
            else 
            {
                lblWalletVerifyresult.ForeColor = Color.Red;
                lblWalletVerifyresult.Text = "Fail to Verify";
            }
            
        }

        private void btnSendWalletOTP_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                txtWalletOTP.Enabled = true;
                Random rnd = new Random();
                string _otp = (rnd.Next(100000, 999999)).ToString();
                sms p = new sms();
                p.msg = "To encash Rs. " + txtRedeemAmount.Text + " from your Chandan Pharmacy wallet, OTP is " + _otp + ". Team Chandan.";// + DateTime.Now.ToString();
                _msgToCustomer = p.msg;
                p.MobileNo = txtMobileNo.Text;
                p.templateID = "1007387720749582210";
                p.smsProvider = GlobalUsage.smsProvider;
                p.smsAPI = GlobalUsage.SmsAPI;
                p.smsID = GlobalUsage.SmsID;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/sendsms", p);

                cm1 p1 = new cm1();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id; p1.prm_3 = GlobalUsage.Login_id;
                p1.Logic = "UpdateOTP"; p1.prm_1 = _otp; p1.tran_id = txtEstimateNo.Text;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void chkHomeDelivery_CheckedChanged(object sender, EventArgs e)
        {

            if (chkHomeDelivery.Checked)
                _homeDelivery = "Y";
            else
                _homeDelivery = "N";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
              
          
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "DeliveryCharges"; p.prm_1 = txtEstimateNo.Text; p.prm_2 = _homeDelivery; p.prm_3 = "-";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                DataTable dt = dwr.result.Tables[0];
              
                if(dt.Rows.Count>0)
                {
                    txtnetPayable.Text = dt.Rows[0]["payable"].ToString();
                    isDistribution(txtnetPayable.Text);
                    txtCash.Text= dt.Rows[0]["payable"].ToString();
                   
                }
                

            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
