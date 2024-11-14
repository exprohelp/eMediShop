using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace eMediShop
{
    public partial class ucHealthCardNew : UserControl
    {
        DataSet _ds = new DataSet();
        string _card_no = string.Empty;int stateCode = 0;
        decimal _DiscountPercentage = 0;
        string _SearchOption = string.Empty;
        string _newcard = "N"; string _otp = string.Empty;
        string _cardexists = "N"; string _oldCardNo = string.Empty;

        public event HealthCardUpdatedEventHandler SearchUpdated;
        public ucHealthCardNew(string card_no, DataSet ds, string SearchOption)
        {
            _ds = ds;
            _SearchOption = SearchOption;
            _card_no = card_no;
            InitializeComponent();
        }
        private void ucHealthCard_Load(object sender, EventArgs e)
        {
            ddlgender.SelectedIndex = 0;
            ddlPGender.SelectedIndex = 0;
            txtStateName.Text = GlobalUsage.State;
            txtDistName.Text = GlobalUsage.District;
            FillState();

            ddlState.Text = GlobalUsage.State;

            ddlState.SelectedIndex=ddlState.FindString(GlobalUsage.State);
            //FillDistrict(stateCode.ToString());
            if (_SearchOption == "SearchByCard")
            {
                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    View_ExistingCARD.Enabled = true;
                    View_NewCard.Enabled = false;
                    radPageView1.SelectedPage = radPageView1.Pages[1];
                    dgMembers.DataSource = _ds.Tables[0];
                    _oldCardNo = _ds.Tables[0].Rows[0]["card_no"].ToString();
                    rgb_replace.Text = _oldCardNo;
                    _newcard = "N";
                    _cardexists = "Y";

                }
                else if (_ds.Tables.Count > 0 && _ds.Tables[1].Rows.Count > 0)
                {
                    txtNewCardNo.Text = _card_no;
                    View_ExistingCARD.Enabled = false;
                    View_NewCard.Enabled = true;
                    _newcard = "Y";
                    _cardexists = "N";
                    txtPmobile.Text = _card_no;
                    radPageView1.SelectedPage = radPageView1.Pages[0];
                    //FillState();
                }
                else
                { MessageBox.Show("This new card is not in your stock."); }
            }
            else if (_SearchOption == "SearchByMobile")
            {
               
                View_ExistingCARD.Enabled = true;
                View_NewCard.Enabled = false;
                radPageView1.SelectedPage = radPageView1.Pages[1];
                dgMembers.DataSource = _ds.Tables[0];
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    _oldCardNo = _ds.Tables[0].Rows[0]["card_no"].ToString();
                    rgb_replace.Text = _oldCardNo;

                    if (_ds.Tables[0].Rows[0]["app_flag"].ToString() == "X")
                    {
                        txtMobileVerifyOTP.Visible = false;
                        rbMobileVerify.Checked = false;
                        rbApp.Checked = true;
                        btnAction.Visible = false;
                        btnVerify.Enabled = true;
                        rbMobileVerify.Enabled = false;
                        txtValidateMobile_Coupon.Enabled = true;
                        txtValidateMobile_Coupon.NullText = "Type Coupon No.";
                    }
                    else
                    {
                        btnAction.Enabled = true;
                        btnVerify.Enabled = true;
                        btnAction.Enabled = true;
                        rbMobileVerify.Checked = true;
                        rbApp.Checked = false;
                        rbMobileVerify.Enabled = true;
                        rbApp.Enabled = false;
                        txtMobileVerifyOTP.Enabled = false;
                        txtValidateMobile_Coupon.Text = _card_no;
                        txtValidateMobile_Coupon.Enabled = false;
                        txtValidateMobile_Coupon.NullText = "Type Mobile No.";
                        btnVerify.PerformClick();
                    }
                }
                else {
                    txtNewCardNo.Text = _card_no;
                    View_ExistingCARD.Enabled = false;
                    View_NewCard.Enabled = true;
                    _newcard = "Y";
                    _cardexists = "N";
                    txtPmobile.Text = _card_no;
                    radPageView1.SelectedPage = radPageView1.Pages[0];
                }
            }
        }

        private void FillState()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            try
            {
                ddlState.Items.Clear();
                ddlState.SelectedIndexChanged -= new Telerik.WinControls.UI.Data.PositionChangedEventHandler(ddlState_SelectedIndexChanged);
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GetStateInfo";
                p.prm_1 = "N/A"; p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);
               
                ddlState.Items.AddRange(Config.FillTelrikCombo(dwr.result.Tables[0]));
                ddlState.SelectedIndex = 0;
                ddlState.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(ddlState_SelectedIndexChanged);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void FillDistrict(string statecode)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            try
            {
                ddldistrict.Items.Clear();
                object o = new object();
           
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GetDistrictInfo";
                p.prm_1 = statecode; p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);

                ddldistrict.Items.AddRange(Config.FillTelrikCombo(dwr.result.Tables[0]));
                ddldistrict.SelectedIndex = 0;
                ddldistrict.Text = GlobalUsage.District;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
        }
        private void dgMembers_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            _newcard = "Old";
            _cardexists = "Y";
            string info = dgMembers.CurrentRow.Cells["member_name"].Value.ToString() + ":" + dgMembers.CurrentRow.Cells["d_o_b"].Value.ToString() + '|' + dgMembers.CurrentRow.Cells["card_no"].Value.ToString() + '|' + dgMembers.CurrentRow.Cells["mobile_no"].Value.ToString() + '|' + dgMembers.CurrentRow.Cells["address"].Value.ToString() + '|' + _newcard + '|' + _cardexists + '|' + dgMembers.CurrentRow.Cells["cardtype"].Value.ToString();
            string CardNo = dgMembers.CurrentRow.Cells["card_no"].Value.ToString();
            string cust_name = dgMembers.CurrentRow.Cells["member_name"].Value.ToString();
            string CardType = dgMembers.CurrentRow.Cells["cardtype"].Value.ToString();
            decimal DisPer = _DiscountPercentage; //Convert.ToDecimal(dgMembers.CurrentRow.Cells["disper"].Value);
            string PayMode = dgMembers.CurrentRow.Cells["paymode"].Value.ToString();
            string mobile_no = dgMembers.CurrentRow.Cells["mobile_no"].Value.ToString();


            HealthCardUpdatedEventArgs valueArgs = new HealthCardUpdatedEventArgs(CardNo, cust_name, CardType, DisPer, PayMode, mobile_no);
            SearchUpdated(this, valueArgs);
        }
        private void ddlState_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlState.SelectedItem.Value != null)
            {
                txtStateName.Text = ddlState.SelectedItem.ToString();
                FillDistrict(ddlState.SelectedItem.Value.ToString());
            }
        }
        private void ddldistrict_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtDistName.Text = ddldistrict.Text;
        }
        private void btnmobile_Click(object sender, EventArgs e)
        {
            try
            {
                string dob = string.Empty;
                if (txtdob.Text.Trim().Length > 0)
                {
                    if (!IsValidDateTime(txtdob.Text))
                    {
                        MessageBox.Show("input date should be in dd/MM/yyyy format");
                        return;
                    }
                    else
                    {
                        string[] t = txtdob.Text.Split('/');
                        dob = t[2] + "/" + t[1] + "/" + t[0];
                    }
                }
                GridViewRowInfo gr = dgNewMembers.Rows.AddNew();
                gr.Cells["member_id"].Value = "-";
                gr.Cells["m_type"].Value = "M";
                gr.Cells["member_name"].Value = txtname.Text;
                gr.Cells["member_gender"].Value = ddlgender.Text;
                gr.Cells["d_o_b"].Value = dob;
                gr.Cells["mobile_no"].Value = txtmobile.Text;
            }
            catch (Exception ex) { }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<ipCardDetail> memberList = new List<ipCardDetail>();
           
            foreach (GridViewRowInfo gr in dgNewMembers.Rows)
            {
                ipCardDetail m = new ipCardDetail();
                m.member_id = gr.Cells["member_id"].Value.ToString();
                m.m_type = gr.Cells["m_type"].Value.ToString();
                m.cust_name = gr.Cells["member_name"].Value.ToString();
                m.gender = gr.Cells["member_gender"].Value.ToString();
                m.dob = gr.Cells["d_o_b"].Value.ToString();
                m.mobileno = gr.Cells["mobile_no"].Value.ToString();
                memberList.Add(m);
             
            }
         
            try
            {
                if (txtPName.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Please input card holder name");
                    return;
                }
                if (txtPmobile.Text.Trim().Length != 10)
                {
                    MessageBox.Show("Please input 10 degit mobile number");
                    return;
                }
                if (txtStateName.Text.Length < 2)
                {
                    MessageBox.Show("Please select State ");
                    return;
                }
                if (txtDistName.Text.Length < 2)
                {
                    MessageBox.Show("Please select district");
                    return;
                }
                string dob = string.Empty;
                if (txtPdob.Text.Trim().Length > 0)
                {
                    if (!IsValidDateTime(txtPdob.Text))
                    {
                        MessageBox.Show("input date should be in dd/MM/yyyy format");
                        return;
                    }
                    else
                    {
                        string[] t = txtPdob.Text.Split('/');
                        dob = t[2] + "/" + t[1] + "/" + t[0];
                    }
                }
                Cursor.Current = Cursors.WaitCursor;

                //string result = GlobalUsage.pharmacy_proxy.Insert_CustCardInfowithMemberNew(GlobalUsage.Unit_id, txtNewCardNo.Text, "M", "P", txtPName.Text, 
                //    ddlPGender.Text, dob, txtPmobile.Text, utxtArea.Text, utxtLocality.Text, txtDistName.Text, txtStateName.Text, utxtEmail.Text, utxtPin.Text, "Insert", dsmembers, GlobalUsage.Login_id);

                ipCardDetail cd = new ipCardDetail();
                cd.unit_id = GlobalUsage.Unit_id; cd.card_no = txtNewCardNo.Text; cd.member_id = "M"; cd.m_type = "P";
                cd.cust_name = txtPName.Text; cd.gender = ddlgender.Text; cd.dob = dob; cd.mobileno = txtPmobile.Text; cd.area = utxtArea.Text;
                cd.Locality = utxtLocality.Text; cd.district = txtDistName.Text; cd.state = txtStateName.Text; cd.email = utxtEmail.Text;
                cd.pin = utxtPin.Text; cd.logic = "Insert"; cd.login_id = GlobalUsage.Login_id;

                List<object> obj = new List<object>();
                obj.Add(cd); obj.Add(memberList);

                resultSetMIS dwr = MISProxy.CallMISWebApiMethod("HealthCard/Insert_CustCardInfowithMember", obj);

                if (dwr.Msg.Contains("Success"))
                {
                    string CardNo = txtNewCardNo.Text;
                    string cust_name = txtPName.Text.ToUpperInvariant();
                    HealthCardUpdatedEventArgs valueArgs = new HealthCardUpdatedEventArgs(CardNo, cust_name, "Silver", 5, "Cash", txtPmobile.Text);
                    SearchUpdated(this, valueArgs);
                }
                else
                { RadMessageBox.Show(dwr.Msg, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }
        private bool IsValidDateTime(string date)
        {
            try
            {
                DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void dgNewMembers_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            e.Row.Delete();
        }
        private void txtPmobile_TextChanged(object sender, EventArgs e)
        {
            txtmobile.Text = txtPmobile.Text;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (_card_no.Length > 5 && txtNewCard.Text.Trim().Length > 5)
                {
                    //string result = GlobalUsage.pharmacy_proxy.ReplaceCard(_oldCardNo, txtNewCard.Text, GlobalUsage.Unit_id, "ReplaceCard", GlobalUsage.Login_id);
                    ipHealthCard p = new ipHealthCard();
                    p.old_cardno = _oldCardNo; p.card_no = txtNewCard.Text; p.unit_id = GlobalUsage.Unit_id; p.Logic = "ReplaceCard"; p.login_id = GlobalUsage.Login_id;

                    resultSetMIS dwr = MISProxy.CallMISWebApiMethod("HealthCard/ReplaceCard", p);

                    RadMessageBox.Show(dwr.Msg, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
                else
                {
                    RadMessageBox.Show("Please choose proper card ", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void dgMembers_RowFormatting(object sender, RowFormattingEventArgs e)
        {
          
        }

        private void btnGenOtp_Click(object sender, EventArgs e)
        {
            GenerateOTP(txtNewCardNo.Text);
        }

        private void GenerateOTP(string mobileno)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Random rnd = new Random();
                _otp = (rnd.Next(100000, 999999)).ToString();
                sms p = new sms();
                p.msg = _otp + " is Your Chandan Member Verification Code.";// + DateTime.Now.ToString();
                p.MobileNo = mobileno;
                p.smsAPI = GlobalUsage.SmsAPI;
                p.smsID = GlobalUsage.SmsID;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/sendsms", p);
                btnGenOtp.Enabled = false;
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnOTPVerify_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (txtOTP.Text == _otp)
                {
                    btnSave.Enabled = true;
                    RadMessageBox.Show("OTP Verified Successfully.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

                }
                else
                {
                    btnSave.Enabled = false;
                    RadMessageBox.Show("Check OTP Number.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txtOTP.SelectAll();
                    txtOTP.Focus();

                }
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }



        private void btnAction_Click(object sender, EventArgs e)
        {
            btnAction.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            if (rbMobileVerify.Checked)
            {
                customerOrders p = new customerOrders();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;p.mobileno = txtValidateMobile_Coupon.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/MobileGetCoupons", p);
                if (dwr.message.Contains("Success"))
                {
                    string[] r = dwr.message.Split('|');
                    ipSms p1 = new ipSms();
                    p1.Message = r[1] + " is your Chandan Member Verification Code."; p1.MobileNo = txtValidateMobile_Coupon.Text;
                    resultSetMIS dwr1 = MISProxy.CallMISWebApiMethod("Utility/SendSms", p1);
                }
                else
                { string[] r = dwr.message.Split('|');
                    RadMessageBox.Show(r[0], "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }

            }
            Cursor.Current = Cursors.Default;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            btnVerify.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            if (rbMobileVerify.Checked)
            {
                customerOrders p = new customerOrders();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.mobileno = txtValidateMobile_Coupon.Text;
                p.couponNo = txtMobileVerifyOTP.Text; p.division = "Pharmacy";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/MobileAuthenticateCoupon", p);
                if (dwr.message.Contains("Auth"))
                {
                    string[] r = dwr.message.Split('|');
                    _DiscountPercentage = Convert.ToDecimal(r[1]);
                    GlobalUsage.couponCode = txtMobileVerifyOTP.Text;
                    dgMembers.Visible = true;
                }
                else
                {
                    dgMembers.Visible = false;
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }

            }
            else
            {
                customerOrders p = new customerOrders();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.mobileno = _card_no;
                p.couponNo = txtValidateMobile_Coupon.Text;p.division = "Pharmacy";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/MobileAuthenticateCoupon", p);
                if (dwr.message.Contains("Auth"))
                {
                    dgMembers.Visible = true;
                    GlobalUsage.couponCode = txtValidateMobile_Coupon.Text;
                    string[] r = dwr.message.Split('|');
                    _DiscountPercentage = Convert.ToDecimal(r[1]);
                }
                else
                {
                    dgMembers.Visible = false;
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void txtValidateMobile_Coupon_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Return)
            btnVerify.PerformClick();
        }

        private void ddlState_TextChanged(object sender, EventArgs e)
        {
            if(ddlState.SelectedValue.ToString()!="Select")
            FillDistrict(ddlState.SelectedValue.ToString());
        }
    }
}