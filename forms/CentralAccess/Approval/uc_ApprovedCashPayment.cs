using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eMediShop;
using accounts_library;
using Telerik.WinControls;

namespace eDiagnostic.Approvals
{
    public partial class uc_ApprovedCashPayment : UserControl
    {
        int _lvIndex = 0;
        eMediShop.rmAccounts.Accounts_WebServiceSoapClient objAC = new eMediShop.rmAccounts.Accounts_WebServiceSoapClient();
        string _CrLedgerCode = string.Empty, _DrLedgerCode = string.Empty, _result = string.Empty, _unit_id = string.Empty, _appId = string.Empty, _LdName = string.Empty;
        DataSet _ds;
        public uc_ApprovedCashPayment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor.Current = Cursors.Default;
                //Checking of Ledger Existence
                objAC.CheckLedgerExistance(out _result, GlobalUsage.Unit_id, lbEmp.Text, "eAccounts");
                if (_result.ToUpper() == "NOT FOUND")
                {
                    //Call INformation From Central Server
                }
                _CrLedgerCode = "16040001"; //Cash A/C 
                #region Saving Process
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _ds = objAC.AC_VoucherPosting(out _result, GlobalUsage.Unit_id, "Pymt", null, _DrLedgerCode, _CrLedgerCode, Convert.ToInt32(lbAmt.Text), txtPurpose.Text, GlobalUsage.Login_id, "N/A", "eDiagnostic", "NoReturn", "Approval");
                    if (!_result.Contains("Failed"))
                    {
                        accounts_library.printing.Voucher(_result, "eAccounts", GlobalUsage.Unit_id);
                        lvEmpList.Items[_lvIndex].Remove();
                    }
                    else
                    {
                        MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Cursor.Current = Cursors.Default;

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                btnSubmit.Enabled = false;
                #endregion
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
        private void uc_ApprovedCashPayment_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                #region Payment Employee List
                DataSet ds = objAC.App_CashPayment_Queries(out _result, GlobalUsage.Unit_id, "-", "AccountList", GlobalUsage.Login_id, "-");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lvEmpList.Items.Add(dr["app_id"].ToString());
                        lvEmpList.Items[lvEmpList.Items.Count - 1].SubItems.Add(dr["ld_code"].ToString());
                        lvEmpList.Items[lvEmpList.Items.Count - 1].SubItems.Add(dr["ld_name"].ToString());
                        lvEmpList.Items[lvEmpList.Items.Count - 1].SubItems.Add(dr["purpose"].ToString());
                        lvEmpList.Items[lvEmpList.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("###"));
                        lvEmpList.Items[lvEmpList.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["app_date"]).ToString("dd-MM-yyyy"));
                        lvEmpList.Items[lvEmpList.Items.Count - 1].SubItems.Add(dr["app_by"].ToString());
                    }
                }
                #endregion
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void lvEmpList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _lvIndex = e.ItemIndex;
            _CrLedgerCode = "16040001"; //Cash A/C 
            _appId = lvEmpList.Items[e.ItemIndex].SubItems[0].Text;
            _DrLedgerCode = lvEmpList.Items[e.ItemIndex].SubItems[1].Text;
            lbEmp.Text = lvEmpList.Items[e.ItemIndex].SubItems[2].Text;
            txtPurpose.Text = lvEmpList.Items[e.ItemIndex].SubItems[3].Text;
            lbAmt.Text = lvEmpList.Items[e.ItemIndex].SubItems[4].Text;
            lbAppDate.Text = lvEmpList.Items[e.ItemIndex].SubItems[5].Text;
            lbAppBy.Text = lvEmpList.Items[e.ItemIndex].SubItems[6].Text;
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "ValidateStaffWithLogin";
                p.prm_1 = txtEmpCode.Text;p.prm_2 = txtPsw.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hr/HRQueries", p);
                DataSet ds = dwr.result;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    btnSubmit.Enabled = true;
                else
                    btnSubmit.Enabled = false;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
