using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using Telerik.WinControls.UI;

namespace eMediShop.forms.Product
{
    public partial class ucRefDataProcess : UserControl
    {
        string _result = string.Empty;
        string _refBy = string.Empty;
        public ucRefDataProcess()
        {
            InitializeComponent();
        }
        private void txtNewLocation_TextChanged(object sender, EventArgs e)
        {

        }
        private void ucChangeLocation_Load(object sender, EventArgs e)
        {
            fillRefName();
        }
        private void fillRefName()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                p.Logic = "ALL";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/PrescribedByQueries", p);
                rgv_info.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRefNAME.Text.Trim().Length > 0)
            {
                prescribedby p = new prescribedby();
                p.unit_id = GlobalUsage.Unit_id;
                p.refCode = "-"; p.ref_Name = txtRefNAME.Text; p.address = txtAddress.Text;
                p.mobile_no = mobileNoText.Text; p.logic = "Insert";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/PrescribedByProcess", p);
                MessageBox.Show(dwr.message, "ExPro Help");
                fillRefName();
            }
            else
            { MessageBox.Show("Referral name is mandatory"); }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtModRef.Text.Trim().Length > 0)
            {
                prescribedby p = new prescribedby();
                p.unit_id = GlobalUsage.Unit_id;
                p.refCode = _refBy;p.ref_Name = txtModRef.Text;p.address = txtModAddress.Text;
                p.mobile_no = m_mobileNoText.Text;p.logic = "Update";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/PrescribedByProcess", p);
                MessageBox.Show(dwr.message, "ExPro Help");
                fillRefName();
            }
            else
            { MessageBox.Show("Referral name is mandatory"); }
        }



        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            GridCommandCellElement gcel = ((sender) as GridCommandCellElement);
            if(_refBy.Length==0)
            { MessageBox.Show("First Edit Referral Then Delete.", "ExPro Help"); return; }
            if (gcel.ColumnInfo.Name.ToString() == "delete")
            {
                if (MessageBox.Show("Are you sure to delete ", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    prescribedby p = new prescribedby();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.refCode = _refBy; p.ref_Name = txtModRef.Text; p.address = txtModAddress.Text;
                    p.mobile_no = m_mobileNoText.Text; p.logic = "Delete";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/PrescribedByProcess", p);
                    MessageBox.Show(dwr.message, "ExPro Help");
                    fillRefName();
                }
            }
            else if (gcel.ColumnInfo.Name.ToString() == "edit")
            {
                _refBy = gcel.RowInfo.Cells["ref_code"].Value.ToString();
                txtModRef.Text = gcel.RowInfo.Cells["ref_name"].Value.ToString();
                txtModAddress.Text = gcel.RowInfo.Cells["address"].Value.ToString();
                m_mobileNoText.Text = gcel.RowInfo.Cells["mobile_no"].Value.ToString();
            }

        }
    }
}
