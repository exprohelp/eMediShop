using System;
using System.Collections;
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

namespace eMediShop.forms.CentralAccess.HealthCards
{
    public partial class ucCheckCardStatus : UserControl
    {
        bool StateLoaded = false; string _memberName = string.Empty; string _result = string.Empty;
        public ucCheckCardStatus()
        {
            InitializeComponent();
        }
        private void btn_activate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btn_activate.Enabled = false;
            string result = string.Empty; //GlobalUsage.pharmacyproxy.HealthCardActivationRequest(check_txtCardNo.Text);
            #region Process
            if (result.Substring(0, 6).ToString() == "Succes")
            {

                string[] temp = result.Split(':');
                //GlobalUsage.pharmacyproxy.SendSMS_ByTemplates("Dear Member, One Time Password (OTP) to activate your Chandan Health Card is " + temp[1] + ". Get your Card activated at Chandan Pharmacy by using this password.", temp[2], DateTime.Now.Millisecond);
                string qry = "select sms_no from message_log where left(result,10)='" + temp[2] + "' and msg_text like '%OTP%' and RESULT not like '%error%' ";
                //DataSet ds = GlobalUsage.pharmacyproxy.GetQueryResult2(qry, "eManagement");
                //if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                //{ txtActivationNo.Text = temp[1].Trim(); }
            }
            else
            {
                MessageBox.Show("Unable To Access Health Card Information", "Alert");
            }
            #endregion
        }

        private void btn_act_no_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btn_act_no.Enabled = false;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                ds = GlobalUsage.healthcard_proxy.GetACardInfo(check_txtCardNo.Text.Trim());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            btn_act_no.Text = "Activated";

            Cursor.Current = Cursors.Default;
        }

     
        private void txtActivationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_act_no.Enabled = true;
                btn_act_no.Text = "Activate Card";
                btn_act_no.Refresh();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_txtCardNo.Text.Length >= 8)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string[] r;
                    string result = "";
                    lblStatus.Text = "Loading Information..";
                    lblStatus.Refresh();
                    result = GlobalUsage.healthcard_proxy.GetACardStatus(check_txtCardNo.Text, GlobalUsage.Unit_id, "CheckCardStatus");
                    r = result.Split('|');
                    if (r[1].ToString() != "Not Found")
                    {
                        lblStatus.Text = "Status : " + r[1].ToString();
                        lblMember.Text = "Name : " + r[0].ToString();
                        _memberName = r[0].ToString();
                        lblAddress.Text = "Address : " + r[3].ToString();
                        if (r[4].ToString() == "Y")
                            lblResult.Text = "Result : Confirmed";//r[2].ToString();
                        else
                            lblResult.Text = "Result : Not Confirmed";//r[2].ToString();


                        btnSilver.FlatAppearance.BorderColor = Color.Black;
                        btnGold.FlatAppearance.BorderColor = Color.Black;
                        btnPlatinum.FlatAppearance.BorderColor = Color.Black;
                        btnPrivilege.FlatAppearance.BorderColor = Color.Black;
                        lblPurchaseAmt.Text = "Purchase Amt : XXXXXX";
                        lblPurchaseAmt.Text = "Purchase Amt : " + r[6].ToString();
                        lblMobileNo.Text = "Mobile No. : XXXXXXXXXX";
                        lblMobileNo.Text = "Mobile No. : " + r[7].ToString();
                        if (r[4].ToString() != "Y") { btn_act_no.Enabled = true; btn_activate.Enabled = true; }
                        else
                        { btn_act_no.Enabled = false; btn_activate.Enabled = false; }
                        if (r[5].ToString().ToUpper() == "SILVER")
                        { btnSilver.Enabled = true; btnSilver.FlatAppearance.BorderColor = Color.Red; btnGold.Enabled = false; btnPlatinum.Enabled = false; btnPrivilege.Enabled = false; }
                        else if (r[5].ToString().ToUpper() == "GOLD")
                        { btnSilver.Enabled = false; btnGold.Enabled = true; btnGold.FlatAppearance.BorderColor = Color.Red; btnPlatinum.Enabled = false; btnPrivilege.Enabled = false; }
                        else if (r[5].ToString().ToUpper() == "PLATINUM")
                        { btnSilver.Enabled = false; btnGold.Enabled = false; btnPlatinum.Enabled = true; btnPlatinum.FlatAppearance.BorderColor = Color.Red; btnPrivilege.Enabled = false; }
                        else if (r[5].ToString().ToUpper() == "PRIVILEGE")
                        { btnSilver.Enabled = false; btnGold.Enabled = false; btnPlatinum.Enabled = false; btnPrivilege.Enabled = true; btnPrivilege.FlatAppearance.BorderColor = Color.Red; }

                    }
                    else
                    {
                        MessageBox.Show("Card Information Not Found.", "Alert");
                    }
                }
                else
                {
                    MessageBox.Show("Crad No Less Than 8 Char.", "Alert");
                }
            }
            catch (Exception ex)
            { MessageBox.Show("either Card is not available or Wrong Card No.", "Alert"); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void ucCheckCardStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
