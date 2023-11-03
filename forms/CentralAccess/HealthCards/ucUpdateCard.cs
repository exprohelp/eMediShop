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
namespace eMediShop.forms.CentralAccess.HealthCards
{
    public partial class ucUpdateCard : UserControl
    {
        Pharmacy_Services objSer = new Pharmacy_Services();
        bool StateLoaded = false;
        public ucUpdateCard()
        {
            InitializeComponent();
        }

        private void u_txtCard_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void ucmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void u_txtCard_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && u_txtCard.Text.Length >= 8)
            {
                Cursor.Current = Cursors.WaitCursor;
                ulblMessage.Text = "Message : Connecting Central Server  ........";
                ulblMessage.Refresh();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.tran_id = u_txtCard.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/GetACardInfo", p);
                DataSet ds = dwr.result;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    upd_box_2.Visible = true;

                    ucmbCardType.Text = ds.Tables[0].Rows[0]["cardtype"].ToString();
                    utxtname.Text = ds.Tables[0].Rows[0]["cust_name"].ToString();
                    udob.Text = ds.Tables[0].Rows[0]["D_O_B"].ToString();
                    udob.Text = ds.Tables[0].Rows[0]["D_O_B"].ToString();
                    utxtSName.Text = ds.Tables[0].Rows[0]["spouse_name"].ToString();
                    usDOB.Text = ds.Tables[0].Rows[0]["spouse_dob"].ToString();
                    uTxtcName1.Text = ds.Tables[0].Rows[0]["child_name_1"].ToString();
                    ucDOB1.Text = ds.Tables[0].Rows[0]["child_dob_1"].ToString();
                    utxtcName2.Text = ds.Tables[0].Rows[0]["child_name_2"].ToString();
                    ucDOB2.Text = ds.Tables[0].Rows[0]["child_dob_2"].ToString();
                    utxtcName3.Text = ds.Tables[0].Rows[0]["child_name_3"].ToString();
                    ucDOB3.Text = ds.Tables[0].Rows[0]["child_dob_3"].ToString();
                    utxtcName4.Text = ds.Tables[0].Rows[0]["child_name_4"].ToString();
                    ucDOB4.Text = ds.Tables[0].Rows[0]["child_dob_4"].ToString();
                    utxtcName5.Text = ds.Tables[0].Rows[0]["child_name_5"].ToString();
                    ucDOB5.Text = ds.Tables[0].Rows[0]["child_dob_5"].ToString();
                    utxtPhone.Text = ds.Tables[0].Rows[0]["phoneno"].ToString();
                    utxtMobile.Text = ds.Tables[0].Rows[0]["mobileno"].ToString();
                    utxtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    utxtArea.Text = ds.Tables[0].Rows[0]["area"].ToString();
                    utxtLocality.Text = ds.Tables[0].Rows[0]["locality"].ToString();
                    utxtPin.Text = ds.Tables[0].Rows[0]["pin"].ToString();

                    if (StateLoaded == false)
                    {
                        ulblMessage.Text = "Message : Loading State Information...";
                        ulblMessage.Refresh();
                        FillStateByWebService("Modify");
                        StateLoaded = true;
                        ulblMessage.Text = "Message : State Information Loaded.";
                        ulblMessage.Refresh();
                    }
                    ucmbState.Text = ds.Tables[0].Rows[0]["state"].ToString();
                    ucmbDistrict.Text = ds.Tables[0].Rows[0]["district"].ToString();

                    ucmbCardType.Focus();
                }
                else
                {
                    MessageBox.Show("Information Not Available", "Alert");
                }
                Cursor.Current = Cursors.Default;
                ulblMessage.Text = "Information Accessed.";
                ulblMessage.Refresh();
            }
        }
        private void FillStateByWebService(string action)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "StatesList"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/CountryInfo", p);

            ds = dwr.result;
            ArrayList state = new ArrayList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                state.Add(new AddValue(dr["state_code"].ToString(), dr["statename"].ToString()));
            }
            ds.Dispose();
            if (action == "Modify")
            {
                ucmbState.DataSource = state;
                ucmbState.DisplayMember = "NewDescription";
                ucmbState.ValueMember = "Value";
            }
            StateLoaded = true;
            Cursor.Current = Cursors.Default;
        }
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            CustomerInfo obj = new CustomerInfo();
            obj.logic = "Update";
            obj.login_id = "User";
            obj.CardType = ucmbCardType.Text.ToUpper();
            obj.Cust_Name = utxtname.Text.ToUpperInvariant();
            obj.DOB = udob.Text == "01-01-1900" ? "01-01-1900" : DateTime.Parse(udob.Text).ToString("dd-MM-yyyy");
            obj.Area = utxtArea.Text.ToUpperInvariant();
            obj.Locality = utxtLocality.Text.ToUpperInvariant();
            obj.District = ucmbDistrict.Text;
            obj.State = ucmbState.Text;
            obj.Country = "India";
            obj.PIN = utxtPin.Text;
            obj.PhoneNo = utxtPhone.Text;
            obj.MobileNo = utxtMobile.Text;
            obj.email = utxtEmail.Text.ToLower();
            obj.Spouse_Name = utxtSName.Text.ToUpperInvariant();
            obj.Spouse_DOB = usDOB.Text == "01-01-1900" ? "01-01-1900" : DateTime.Parse(usDOB.Text).ToString("dd-MM-yyyy");
            obj.Child_Name_1 = uTxtcName1.Text;
            obj.Child_DOB_1 = ucDOB1.Text == "01-01-1900" ? "01-01-1900" : DateTime.Parse(ucDOB1.Text).ToString("dd-MM-yyyy");
            obj.Child_Name_2 = utxtcName2.Text;
            obj.Child_DOB_2 = ucDOB2.Text == "01-01-1900" ? "01-01-1900" : DateTime.Parse(ucDOB2.Text).ToString("dd-MM-yyyy");
            obj.Child_Name_3 = utxtcName3.Text;
            obj.Child_DOB_3 = ucDOB3.Text == "01-01-1900" ? "01-01-1900" : DateTime.Parse(ucDOB3.Text).ToString("dd-MM-yyyy");
            obj.Child_Name_4 = utxtcName4.Text;
            obj.Child_DOB_4 = ucDOB4.Text == "01-01-1900" ? "01-01-1900" : DateTime.Parse(ucDOB4.Text).ToString("dd-MM-yyyy");
            obj.Child_Name_5 = utxtcName5.Text;
            obj.Child_DOB_5 = ucDOB5.Text == "01-01-1900" ? "01-01-1900" : DateTime.Parse(ucDOB5.Text).ToString("dd-MM-yyyy");
            obj.Card_No = u_txtCard.Text;
            obj.Inst_Code = "Unit";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/CardInfoInsert", obj);
            string result = dwr.message;
            ulblMessage.Text = result;
            if (result != "Failed")
            {
                u_txtCard.Text = "";
                utxtname.Text = "";
                utxtSName.Text = "";
                uTxtcName1.Text = "";
                utxtcName2.Text = "";
                utxtcName3.Text = "";
                utxtMobile.Text = "";
                utxtPhone.Text = "";
                utxtEmail.Text = "";
            }
            u_txtCard.Focus();
        }
    }
}
