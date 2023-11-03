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

    public partial class ucNewCardEntry : UserControl
    {
        Pharmacy_Services objSer = new Pharmacy_Services();
        bool StateLoaded = false;
        string _result = string.Empty;
        public ucNewCardEntry()
        {
            InitializeComponent();
        }
        private void ucNewCardEntry_Load(object sender, EventArgs e)
        {
            cmbCardType.SelectedIndex = 0;
            FillStateByWebService("New");
        }
        private void FillStateByWebService(string action)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            ds = GlobalUsage.healthcard_proxy.GetStateList("India");
            ArrayList state = new ArrayList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                state.Add(new AddValue(dr["state_code"].ToString(), dr["statename"].ToString()));
            }
            ds.Dispose();
            cmbState.DataSource = state;
            cmbState.DisplayMember = "NewDescription";
            cmbState.ValueMember = "Value";
            StateLoaded = true;
            cmbState.Text = GlobalUsage.State;
            Cursor.Current = Cursors.Default;
        }
        private void txtCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!StateLoaded && txtCardNo.Text.Length >= 8)
                {
                    FillStateByWebService("New");
                }
                this.cmbCardType.Focus();
            }
        }

        private void txtCardNo_Leave(object sender, EventArgs e)
        {
            if (txtCardNo.Text.Length >= 8)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string[] r;
                    string result = GlobalUsage.healthcard_proxy.GetACardStatus(txtCardNo.Text, GlobalUsage.Unit_id, "CheckCardAtUnit");
                    r = result.Split('|');
                    if (r[0].ToString() != "AllowToAllot")
                    {
                        //lblStatus.Text = "Status : " + r[1].ToString();
                        //lblMember.Text = "Name : " + r[0].ToString();
                        //_memberName = r[0].ToString();
                        //lblAddress.Text = "Address : " + r[3].ToString();

                        RadMessageBox.Show("Status: " + r[1].ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        txtCardNo.Focus();
                        txtCardNo.SelectAll();
                    }


                }
                catch (Exception ex) { Telerik.WinControls.RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }

            }
        }

        private void cmbCardType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtName.Focus(); }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.DOB.Focus();
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                if (!IsValidEmail(txtEmail.Text.ToString()))
                {
                    RadMessageBox.Show("Invalid eMail Address.", "ExPro Help", MessageBoxButtons.OK);
                    txtEmail.Focus();
                    return;
                }
            }
            Cursor.Current = Cursors.WaitCursor;
            string dist_type = "";
            if (rbCash.Checked)
                dist_type = "Paid";
            else
                dist_type = "Free";
            decimal amt = 0;
            if (cmbCardType.Text == "Silver") { amt = 20; } else { amt = 250; }
            HealthCard.CustomerCard obj = new HealthCard.CustomerCard();
            obj.logic = "New";
            obj.login_id = GlobalUsage.Login_id;
            obj.CardType = cmbCardType.Text.ToUpper();
            obj.Cust_Name = txtName.Text.ToUpperInvariant();
            obj.DOB = DOB.Text == DateTime.Now.ToShortDateString() ? DateTime.Parse("01-01-1900") : DateTime.Parse(DOB.Text);
            obj.Area = txtArea.Text.ToUpperInvariant();
            obj.Locality = txtLocality.Text.ToUpperInvariant();
            obj.District = cmbDistrict.Text;
            obj.State = cmbState.Text;
            obj.Country = "India";
            obj.PIN = txtPin.Text;
            obj.PhoneNo = txtPhone.Text;
            obj.MobileNo = txtMobile.Text;
            obj.email = txtEmail.Text.ToLower();
            obj.Spouse_Name = txtSName.Text.ToUpperInvariant();
            obj.Spouse_DOB = SDOB.Text == DateTime.Now.ToShortDateString() ? DateTime.Parse("01-01-1900") : DateTime.Parse(SDOB.Text);
            obj.Child_Name_1 = TxtCName1.Text;
            obj.Child_DOB_1 = CDOB1.Text == DateTime.Now.ToShortDateString() ? DateTime.Parse("01-01-1900") : DateTime.Parse(CDOB1.Text);
            obj.Child_Name_2 = txtCName2.Text;
            obj.Child_DOB_2 = CDOB2.Text == DateTime.Now.ToShortDateString() ? DateTime.Parse("01-01-1900") : DateTime.Parse(CDOB2.Text);
            obj.Child_Name_3 = txtCName3.Text;
            obj.Child_DOB_3 = CDOB3.Text == DateTime.Now.ToShortDateString() ? DateTime.Parse("01-01-1900") : DateTime.Parse(CDOB3.Text);
            obj.Child_Name_4 = txtcName4.Text;
            obj.Child_DOB_4 = cDOB4.Text == DateTime.Now.ToShortDateString() ? DateTime.Parse("01-01-1900") : DateTime.Parse(cDOB4.Text);
            obj.Child_Name_5 = txtcName5.Text;
            obj.Child_DOB_5 = cDOB5.Text == DateTime.Now.ToShortDateString() ? DateTime.Parse("01-01-1900") : DateTime.Parse(cDOB5.Text);
            obj.Card_No = txtCardNo.Text;
            obj.Inst_Code = GlobalUsage.Unit_id;
            obj.DistType = dist_type;
            string result = GlobalUsage.healthcard_proxy.Card_Info_insert(obj, "eManagement");
            lblMessage.Text = result;

            Cursor.Current = Cursors.Default;
            this.txtCardNo.Focus();
        }
        private void txtSName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.SDOB.Focus();
            }
        }
        private void DOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtSName.Focus();
            }
        }
        private void SDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.TxtCName1.Focus();
            }
        }
        private void TxtCName1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.CDOB1.Focus();
            }
        }
        private void txtCName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.CDOB2.Focus(); }
        }

        private void CDOB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtCName3.Focus(); }
        }

        private void txtCName3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.CDOB3.Focus(); }
        }

        private void CDOB3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtcName4.Focus(); }
        }

        private void txtcName4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.cDOB4.Focus(); }
        }

        private void txtcName5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.cDOB5.Focus(); }
        }

        private void CDOB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.txtCName2.Focus();
            }
        }

        private void CDOB2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtCName3.Focus(); }
        }

        private void CDOB3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtcName4.Focus(); }
        }

        private void cDOB4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtcName5.Focus(); }
        }

        private void cDOB5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtPhone.Focus(); }
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtEmail.Focus(); }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtMobile.Focus(); }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtArea.Focus(); }
        }
        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtLocality.Focus(); }
        }

        private void txtLocality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.txtPin.Focus(); }
        }

        private void txtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.cmbState.Focus(); }
        }

        private void cmbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.cmbDistrict.Focus(); }
        }

        private void cmbDistrict_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { this.cmdSubmit.Focus(); }
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StateLoaded)
            {
                Cursor.Current = Cursors.WaitCursor;
                string stateCode = this.cmbState.SelectedValue.ToString();
                DataSet ds = new DataSet();
                ds = GlobalUsage.healthcard_proxy.GetDistrictList("India", stateCode);
                ArrayList district = new ArrayList();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    district.Add(new AddValue(dr["dist_code"].ToString(), dr["distt_name"].ToString()));
                }
                ds.Dispose();
                cmbDistrict.DataSource = district;
                cmbDistrict.DisplayMember = "NewDescription";
                cmbDistrict.ValueMember = "Value";
                cmbDistrict.Text = GlobalUsage.District;
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
