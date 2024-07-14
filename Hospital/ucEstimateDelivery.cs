using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Hospital
{
    public partial class ucEstimateDelivery : UserControl
    {
        string _selectedEstimateNo = string.Empty; string _ipdVerified = string.Empty; string _patientName = string.Empty;
        decimal _billAmt = 0;
        public ucEstimateDelivery()
        {
            InitializeComponent();
        }

        private void btnGetEstimate_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                rgvEstimateInfo.DataSource = new string[] { };
                DataSet ds = new DataSet();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "UnPosted"; p.prm_1 = "EstimateDelivery"; p.prm_2 = "N/A"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                rgvEstimateInfo.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvEstimateInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                _patientName = e.Row.Cells["pt_name"].Value.ToString();
                rgEstimateInfo.Text = e.Row.Cells["pt_name"].Value.ToString() + "[" + e.Row.Cells["sale_inv_no"].Value.ToString() + "]";
                txtestUHID.Text = e.Row.Cells["uhidno"].Value.ToString();
                txtEstIpd.Text = e.Row.Cells["ipdno"].Value.ToString();
                txtEstRemarks.Text = e.Row.Cells["remarks"].Value.ToString();
                txtPanelName.Text = "-";
                txtPanelName.Text = e.Row.Cells["panelname"].Value.ToString();
                _selectedEstimateNo = e.Row.Cells["sale_inv_no"].Value.ToString();
                _billAmt = Convert.ToDecimal(e.Row.Cells["net"].Value);

                FillOPDPatientList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            if (_selectedEstimateNo.Length < 7)
            {
                MessageBox.Show("Select The Patient Row.");
                return;
            }
            if (txtEstRemarks.Text.Length < 10)
            {
                MessageBox.Show("Type Proper Reason of Minimum 10 Char.");
                return;
            }
            else if (txtEstIpd.Text.Length < 4 && chkOPD.Checked == false)
            {
                MessageBox.Show("Type IPD No");
                return;
            }
            else if (_ipdVerified == "N")
            {
                MessageBox.Show("verify IPD Number By Pressing Enter Key");
                return;
            }
            try
            {


                Cursor.Current = Cursors.WaitCursor;

                SaleInvoiceFinalization p = new SaleInvoiceFinalization();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.pt_name = _patientName;
                p.estimateNo = _selectedEstimateNo; p.Hosp_Cr_No = txtestUHID.Text; p.Hosp_IPOP_No = txtEstIpd.Text;
                p.panelName = txtPanelName.Text; p.remarks = txtEstRemarks.Text; p.loginName = GlobalUsage.Login_id;
                if (chkDischMed.Checked)
                    p.isDischargeMedicine = "Yes";
                else
                    p.isDischargeMedicine = "No";

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailMarkNotSettled", p);
                if (dwr.message.Contains("Success"))
                {
                    string[] r = dwr.message.Split(':');
                    if (MessageBox.Show("Do You Want To Print Bill No " + r[2], "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (GlobalUsage.PrinterType.ToUpper().ToUpper() == "LASER")
                            Printing.Laser.CashMemo(r[2], "Y");
                    }
                    btnGetEstimate.PerformClick();
                }
                else
                    MessageBox.Show(dwr.message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvEstimateInfo_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["holdby"].Value.ToString() == "-")
                e.RowElement.ForeColor = Color.Blue;
            else
                e.RowElement.ForeColor = Color.Red;
        }

        private void txtEstIpd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetPatientInfoByIPD();
            }
        }

        private void GetPatientInfoByIPD()
        {
            DataTable table = new DataTable();
            if (!chkOPD.Checked)
            {
                if (txtEstIpd.Text.Length > 4)
                {
                    try
                    {
                        if (rbItDose.Checked)
                        {
                            string response = GlobalUsage.his_proxy.getPatientInfoByIPDNo(txtEstIpd.Text);
                            table = JsonConvert.DeserializeObject<DataTable>(response);
                        }
                        else
                        {
                            pm_HospitalQueries p = new pm_HospitalQueries();
                            p.unit_id = GlobalUsage.Unit_id; p.logic = "BYIPDNO"; p.prm_1 = txtEstIpd.Text; p.prm_2 = "";
                            p.login_id = GlobalUsage.Login_id;
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/HospitalQueries", p);
                            table = dwr.result.Tables[0];
                        }




                        if (table.Rows.Count > 0)
                        {
                            txtPanelName.Text = table.Rows[0]["Company_Name"].ToString();
                            txtestUHID.Text = table.Rows[0]["patient_id"].ToString();
                            _ipdVerified = "Y";
                        }

                    }
                    catch (Exception ex) { }
                    finally { Cursor.Current = Cursors.Default; }
                }
                else
                {
                    MessageBox.Show("Only Numeric Entry Allowed");
                }
            }
        }

        private void chkHospitalAdvance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHospitalAdvance.Checked)
                txtPanelName.Text = "Hospital Advance";
            else
            {
                txtPanelName.Text = "";
                GetPatientInfoByIPD();
            }

        }

        private void txtEstIpd_TextChanged(object sender, EventArgs e)
        {
            _ipdVerified = "N";
        }

        private void chkOPD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOPD.Checked)
            {
                txtestUHID.Enabled = true;
                txtEstIpd.Enabled = false;
                cmbPanelName.Enabled = true;
            }
            else
            {
                txtestUHID.Enabled = false;
                txtEstIpd.Enabled = true;
                cmbPanelName.Enabled = false;
            }
        }
        private void FillOPDPatientList()
        {
            pm_HospitalQueries p = new pm_HospitalQueries();
            p.unit_id = GlobalUsage.Unit_id; p.logic = "BYUHIDNO"; p.prm_1 = txtestUHID.Text; p.prm_2 = "";
            p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/HospitalQueries", p);
            dgHISVisits.DataSource = dwr.result.Tables[0];
        }

        private void txtestUHID_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable table = new DataTable();
                    if (rbItDose.Checked)
                    {
                        string response = GlobalUsage.his_proxy.getPatientLastAppointmentDetails(txtestUHID.Text);
                        table = JsonConvert.DeserializeObject<DataTable>(response);

                    }
                    else
                    {
                        FillOPDPatientList();
                    }
                 

                }
                catch (Exception ex) { }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void ucEstimateDelivery_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                pm_HospitalQueries p = new pm_HospitalQueries();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "panelName"; p.prm_1 = ""; p.prm_2 = "";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/HospitalQueries", p);
                cmbPanelName.Items.Clear();
                cmbPanelName.Items.AddRange(Config.FillCombo(dwr.result.Tables[0]));

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void cmbPanelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPanelName.Text = ((AddValue)cmbPanelName.SelectedItem).Value;
        }

        private void txtPanelName_TextChanged(object sender, EventArgs e)
        {
            txtFund.Text = "0";
            pm_HospitalQueries p = new pm_HospitalQueries();
            p.unit_id = GlobalUsage.Unit_id; p.logic = "BYUHIDNO"; p.prm_1 = txtestUHID.Text; p.prm_2 = "";
            p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/HospitalQueries", p);
            DataTable table = dwr.result.Tables[0];

            if (table.Rows.Count > 0 && !chkHospitalAdvance.Checked)
            {
                if (table.Rows[0]["panelId"].ToString() == "107" && Convert.ToDecimal(table.Rows[0]["FundBal"]) < _billAmt)
                { btnDelivered.Enabled = false; txtFund.Text = Convert.ToDecimal(table.Rows[0]["FundBal"]).ToString("######"); }
                else
                    btnDelivered.Enabled = true;
            }
        }

        private void dgHISVisits_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(dgHISVisits.Rows.Count > 0)
            {
                txtPanelName.Text = dgHISVisits.CurrentRow.Cells["PanelName"].Value.ToString();
                txtEstIpd.Text = dgHISVisits.CurrentRow.Cells["ipop_no"].Value.ToString(); 
               _ipdVerified = "Y";
                if(dgHISVisits.CurrentRow.Cells["panelId"].Value.ToString() != "107")
                btnDelivered.Enabled = true;
                else if (dgHISVisits.CurrentRow.Cells["panelId"].Value.ToString()== "107" && Convert.ToDecimal(dgHISVisits.CurrentRow.Cells["FundBal"].Value) >= _billAmt)
                { btnDelivered.Enabled = true; txtFund.Text = Convert.ToDecimal(dgHISVisits.CurrentRow.Cells["FundBal"].Value).ToString("######"); }
                else
                    btnDelivered.Enabled = false;
            }
        }
    }
}
