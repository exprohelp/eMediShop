using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls.UI;
namespace eMediShop
{
    public partial class UpdateHealthCard : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();
        string _card_no = string.Empty;
        string _SearchOption = string.Empty;
        string _newcard = "N";
        string _cardexists = "N";

        public event EventCarrierHandler SearchUpdated;
        public UpdateHealthCard( string cardNo)
        {
            InitializeComponent();
            if(cardNo!="-")
            { txtCardNo.Text = cardNo;_card_no = cardNo; }
        }
        private void ucHealthCard_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 80);
            if (Application.ProductName.Contains("eHealthCard"))
                btnEdit.Enabled = true;
            else
                btnEdit.Enabled = false;

            FillState();
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

                ds = dwr.result;
                ddlState.Items.AddRange(Config.FillTelrikCombo(ds.Tables[0]));
                ddlState.SelectedIndex = 0;
                ddlState.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(ddlState_SelectedIndexChanged);
                ddlState.Text = GlobalUsage.State;
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
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GetDistrictInfo";
                p.prm_1 = statecode; p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);
                ds = dwr.result;
                ddldistrict.Items.AddRange(Config.FillTelrikCombo(ds.Tables[0]));
                ddldistrict.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                
                GridViewRowInfo gr = dgMembers.Rows.AddNew();
                gr.Cells["member_id"].Value = "-";
                gr.Cells["m_type"].Value = "M";
                gr.Cells["member_name"].Value = txtname.Text;
                gr.Cells["d_o_b"].Value = dob;
            }
            catch (Exception ex) { }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
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
                Regex re = new Regex("[0-9]");

                if (re.IsMatch(txtMobileNo.Text.Trim()) == false || txtMobileNo.Text.Length != 10)
                {
                    MessageBox.Show("Invalid Mobile Number!!");
                    txtMobileNo.Focus();
                }
               
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();

                string result = GlobalUsage.pharmacy_proxy.Insert_UpdateCustCardMemebers(GlobalUsage.Unit_id, _card_no, "", "P", "", "", "", txtMobileNo.Text, utxtArea.Text, utxtLocality.Text, txtStateName.Text, txtDistName.Text, utxtEmail.Text, utxtPin.Text, "ProfileUpdate", ds, GlobalUsage.Login_id);
                MessageBox.Show(result);
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
        private void btnGet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string _result = string.Empty;
            _card_no = txtCardNo.Text;
            ipHealthCard p = new ipHealthCard();
            p.card_no = _card_no; p.unit_id = GlobalUsage.Unit_id; p.old_cardno = "-"; p.mobile = _card_no;
            p.from = "1900/01/01"; p.to = "1900/01/01"; p.login_id = GlobalUsage.Login_id; p.prm_1 = "-"; p.prm_2 = "-";
            p.Logic = "CardDetailtoEdit";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/GetCard_Queries", p);
            DataSet ds = dwr.result;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                utxtArea.Text = ds.Tables[0].Rows[0]["Area"].ToString();
                utxtLocality.Text = ds.Tables[0].Rows[0]["Locality"].ToString();
                
                txtStateName.Text = ds.Tables[0].Rows[0]["State"].ToString();
                ddlState.FindString(ds.Tables[0].Rows[0]["State"].ToString());
                txtDistName.Text = ds.Tables[0].Rows[0]["District"].ToString();
                ddldistrict.FindString(ds.Tables[0].Rows[0]["District"].ToString());
                utxtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                utxtPin.Text = ds.Tables[0].Rows[0]["PIN"].ToString();
                txtMobileNo.Text= ds.Tables[0].Rows[0]["mobileno"].ToString();
            }
            dgMembers.DataSource = ds.Tables[1];
        }
        string _member_id = string.Empty;
        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            _member_id = e.Row.Cells["member_id"].Value.ToString();
            txtname.Text = e.Row.Cells["member_name"].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string dob = string.Empty;
                
                if (txtname.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Please input member name ");
                    return;
                }

                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                string result = GlobalUsage.pharmacy_proxy.Insert_UpdateCustCardMemebers(GlobalUsage.Unit_id, _card_no, _member_id, "M", txtname.Text, "-", dob, "-", "", "", "", "", "", "", "MemberInsert", ds, GlobalUsage.Login_id);
                MessageBox.Show(result);
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string dob = string.Empty;
               
                if (txtname.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Please input member name ");
                    return;
                }
             
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                string result = GlobalUsage.pharmacy_proxy.Insert_UpdateCustCardMemebers(GlobalUsage.Unit_id, _card_no, _member_id, "M", txtname.Text, "-", dob, "-", "", "", "", "", "", "", "MemberUpdate", ds, GlobalUsage.Login_id);
                MessageBox.Show(result);
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }



    }
}