using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class VendorApp : Telerik.WinControls.UI.RadForm
    {
        bool chk = false; string _result = string.Empty;
        string _StateId = string.Empty;
        string logic = "";
        public VendorApp()
        {
            InitializeComponent();
        }

        private void VendorApp_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            FillStateByWebService("f");
        }
        private void FillStateByWebService(string action)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "StatesList"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/CountryInfo", p);
            ArrayList state = new ArrayList();
            foreach (DataRow dr in dwr.result.Tables[0].Rows)
            {
                state.Add(new AddValue(dr["state_code"].ToString(), dr["statename"].ToString()));
            }
            ds.Dispose();
            ddlState.DataSource = state;
            ddlState.DisplayMember = "NewDescription";
            ddlState.ValueMember = "Value";
            ddlState.Text = GlobalUsage.State;
            _StateId = ddlState.SelectedValue.ToString();
            fillDistrct(_StateId);
            Cursor.Current = Cursors.Default;
        }

        public void fillDistrct(string stateId)
        {
            Cursor.Current = Cursors.WaitCursor;
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "DistrictsList"; p.login_id = GlobalUsage.Login_id; p.prm_1 = stateId;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/CountryInfo", p);
            ArrayList district = new ArrayList();
            foreach (DataRow dr in dwr.result.Tables[0].Rows)
            {
                district.Add(new AddValue(dr["distt_name"].ToString(), dr["distt_name"].ToString()));
            }
            ddlDistrict.DataSource = district;
            ddlDistrict.DisplayMember = "NewDescription";
            ddlDistrict.ValueMember = "Value";
            ddlDistrict.Text = GlobalUsage.District;
            Cursor.Current = Cursors.Default;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtVendorName.TextLength < 5)
            {
                MessageBox.Show("Vendor Name  should be more than 5 Character.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVendorName.Focus();
                return;
            }
            if (txtAddress.Text.Length < 5)
            {
                MessageBox.Show("Address Should be more than 5 Character.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            if (txtContactPerson.Text.Length < 5)
            {
                MessageBox.Show("Contract Person Name Should be more than 5 Character.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContactPerson.Focus();
                return;
            }
            if (txtPhoneNo.Text.Length < 5)
            {
                MessageBox.Show("Contact No. Should be more than 5 Character.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNo.Focus();
                return;
            }
            if (txtTinNo.Text.Length < 15)
            {
                MessageBox.Show("GSTN No. Should be 15 Character.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTinNo.Focus();
                return;
            }
            if (ddlDistrict.Text.Length < 5)
            {
                MessageBox.Show("District Name Should be more than 5 Character.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlDistrict.Focus();
                return;
            }
            if (ddlState.Text.Length < 5)
            {
                MessageBox.Show("State Name Should be more than 5 Character.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ddlDistrict.Focus();
                return;
            }
            try
            {
                DataTable table = new DataTable("Vendor");
                table.Columns.Add("vendor_id", typeof(string));
                table.Columns.Add("vendor_name", typeof(string));
                table.Columns.Add("contact_person", typeof(string));
                table.Columns.Add("address1", typeof(string));
                table.Columns.Add("address2", typeof(string));
                table.Columns.Add("address3", typeof(string));
                table.Columns.Add("city", typeof(string));
                table.Columns.Add("state", typeof(string));
                table.Columns.Add("pin", typeof(string));
                table.Columns.Add("contact_no", typeof(string));
                table.Columns.Add("email", typeof(string));
                table.Columns.Add("payment_mode", typeof(string));
                table.Columns.Add("payment_days", typeof(int));
                table.Columns.Add("gst_no", typeof(string));
                table.Columns.Add("account_id", typeof(string));
                table.Columns.Add("created_by", typeof(string));
                table.Rows.Add("New", txtVendorName.Text, txtContactPerson.Text, txtAddress.Text, "-", "-", ddlDistrict.Text,
                    ddlState.Text, "-", txtPhoneNo.Text, "-", "Cash", 30, txtTinNo.Text, "-", GlobalUsage.Login_id);
                cm3 p = new cm3();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "ForApp:Insert"; p.dt = table; p.prm_1 = "ForApp:Insert";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/vendor/Insert_Modify_Vendor_Master", p);
                string outResult = dwr.message;
                MessageBox.Show(outResult, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx) { MessageBox.Show(sqlEx.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTinNo.Focus();
        }

        private void txtPhoneNo_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue > 31 && (e.KeyValue < 48) || (e.KeyValue > 57))
            if (chk == true && e.KeyCode != Keys.Enter)
            {
                MessageBox.Show("Only Numeric Value.", "Acknowldgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNo.Text = "";
            }
        }

        private void txtVendorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtContactPerson.Focus();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlState.Focus();
        }

        private void txtContactPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtAddress.Focus();
        }

        private void ddlState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ddlDistrict.Focus();
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPhoneNo.Focus();
        }

        private void txtTinNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSubmit.Focus();
        }
        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            chk = false;
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
            {
                chk = true;

            }
        }

        public void fillVindorForAck()
        {
            #region Fill Vendor For Acknowledge Paper
            DataSet ds = new DataSet();

            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "Pending-Ack"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/vendor/VendorQueries", p);
            ds = dwr.result;
            if (ds.Tables[0].Rows.Count > 0)
            {
                rgv_vendorInfo.DataSource = ds.Tables[0];

            }
            #endregion
        }
        public void fillVindorForAccountApproval()
        {
            #region Fill Vendor which are approved by account section
            try
            {
                DataSet ds = new DataSet();
                lv_accountApp.Items.Clear();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "Approved"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/vendor/VendorQueries", p);
                ds = dwr.result;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lv_accountApp.BeginUpdate();
                    int i = 0;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        i++;
                        ListViewItem ls = new ListViewItem(i.ToString());
                        ls.SubItems.Add(dr["vendor_name"].ToString());
                        ls.SubItems.Add(dr["address1"].ToString());
                        ls.SubItems.Add(dr["gst_no"].ToString());
                        ls.SubItems.Add(dr["contact_no"].ToString());
                        ls.SubItems.Add(dr["vendor_id"].ToString());
                        lv_accountApp.Items.Add(ls);
                    }
                    lv_accountApp.EndUpdate();
                    lv_accountApp.Focus();
                    lv_accountApp.Items[0].Selected = true;
                    lv_accountApp.Items[0].Focused = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                fillVindorForAck();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                fillVindorForAccountApproval();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                fillAllVendor();
            }
        }
        private void fillAllVendor()
        {
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "Vendor-List"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/vendor/VendorQueries", p);
            rgv_info.DataSource = dwr.result.Tables[0];
        }


        private void lv_accountApp_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true)
            {
                try
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "update:ack"; p.login_id = GlobalUsage.Login_id;
                    p.prm_1 = lv_accountApp.Items[lv_accountApp.FocusedItem.Index].SubItems[5].Text.ToString();
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/vendor/VendorQueries", p);
                    MessageBox.Show("Successfully Acknowldged.", "Acknowldgement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (logic != "")
                fillDistrct(_StateId);
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (!rbCustomer.Checked && !rbVendor.Checked)
            {
                MessageBox.Show("Check Vendor or Customer", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                DataTable table = new DataTable("Vendor");
                table.Columns.Add("vendor_id", typeof(string));
                table.Columns.Add("vendor_name", typeof(string));
                table.Columns.Add("contact_person", typeof(string));
                table.Columns.Add("address1", typeof(string));
                table.Columns.Add("address2", typeof(string));
                table.Columns.Add("address3", typeof(string));
                table.Columns.Add("city", typeof(string));
                table.Columns.Add("state", typeof(string));
                table.Columns.Add("pin", typeof(string));
                table.Columns.Add("contact_no", typeof(string));
                table.Columns.Add("email", typeof(string));
                table.Columns.Add("payment_mode", typeof(string));
                table.Columns.Add("payment_days", typeof(int));
                table.Columns.Add("gst_no", typeof(string));
                table.Columns.Add("account_id", typeof(string));
                table.Columns.Add("created_by", typeof(string));
                table.Rows.Add(e.Row.Cells["vendor_id"].Value.ToString(),
                    e.Row.Cells["vendor_name"].Value.ToString(),
                    "-", e.Row.Cells["address1"].Value.ToString(), "-", "-", e.Row.Cells["city"].Value.ToString(),
                    e.Row.Cells["state"].Value.ToString(), "-", "-", "-", "Cash", 30,
                    "-", e.Row.Cells["ac_code"].Value.ToString(), GlobalUsage.Login_id);

                cm3 p = new cm3();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "Merge"; p.dt = table;
                if (rbVendor.Checked)
                    p.prm_1 = "Vendor";
                else if (rbCustomer.Checked)
                    p.prm_1 = "Customer";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/vendor/Insert_Modify_Vendor_Master", p);
                string outResult = dwr.message;
                MessageBox.Show(outResult, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["colorCode"].Value.ToString() == "Green")
                e.RowElement.ForeColor = Color.Green;
            else
                e.RowElement.ForeColor = Color.Black;

        }

        private void rgv_vendorInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                vendorAckRpt obj = new vendorAckRpt(e.Row.Cells["vendor_id"].Value.ToString());
                obj.Show();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}





