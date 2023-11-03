using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.ITSystem
{

    public partial class ucUnitAllotment : UserControl
    {
        string _result = string.Empty;
        public ucUnitAllotment()
        {
            InitializeComponent();
        }

        private void ucUnitAllotment_Load(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                datasetWithResult dwr = new datasetWithResult();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;p.Logic = "ByLoginId";
                dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);
                ds = dwr.result;
                rgv_info.DataSource = ds.Tables[0];

                pm_Authentication pm = new pm_Authentication();
                pm.unit_id = GlobalUsage.Unit_id;pm.Login_id = GlobalUsage.Login_id;pm.logic = "userList";
                dwr = ConfigWebAPI.CallAPI("api/login/StaffManagement", pm);
                ds = dwr.result;
                cmbStaffList.Items.AddRange(Config.FillCombo(ds.Tables[0]));
                cmbStaffList.SelectedIndex = 0;

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }


        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                rgb_info.Text = e.Row.Cells["unit_name"].Value.ToString();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string emp_code = ((AddValue)cmbStaffList.SelectedItem).Value.ToString();
                pm_Authentication pm = new pm_Authentication();
                pm.unit_id = GlobalUsage.Unit_id; pm.Login_id = GlobalUsage.Login_id; pm.logic = "LinkDlink";
                pm.prm1 = rgv_info.CurrentRow.Cells["unit_id"].Value.ToString();
                pm.prm2 = emp_code;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/StaffManagement", pm);
                DataSet ds = dwr.result;
                if (ds.Tables[0].Rows[0]["result"].ToString() == "Success")
                    RadMessageBox.Show("Successfully Updated.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btnDlink_Click(object sender, EventArgs e)
        {
            btnLink.PerformClick();
        }

        private void rgb_info_Click(object sender, EventArgs e)
        {

        }
    }
}
