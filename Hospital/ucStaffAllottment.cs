using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Hospital
{
    public partial class ucStaffAllottment : Telerik.WinControls.UI.RadForm
    {
        string _indentNo = string.Empty;
        public event SetStaffEventHandler StaffUpdated;
        public ucStaffAllottment(string indentNo)
        {
            _indentNo = indentNo;
            InitializeComponent();
        }

        private void ucStaffAllottment_Load(object sender, EventArgs e)
        {
            txtIndentNo.Text = _indentNo;
            DataSet ds = new DataSet();
            pm_Authentication pm = new pm_Authentication();
            pm.unit_id = GlobalUsage.Unit_id; pm.Login_id = GlobalUsage.Login_id; pm.logic = "StaffForIndent";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/StaffManagement", pm);
            ds = dwr.result;
            rgv_info.DataSource = ds.Tables[0];
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            string result = "Fail To Allot";
            try
            {
                DialogResult res = MessageBox.Show("Do You want to set (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Indent-Allot"; p.prm_1 = e.Row.Cells["emp_code"].Value.ToString(); p.tran_id = _indentNo;
                    datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    if (dwr1.message.Contains("Update"))
                        result = "Updated";
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

            SetStaffUpdatedEventArgs ValueArgs = new SetStaffUpdatedEventArgs(result);
            StaffUpdated(this, ValueArgs);
            this.Close();

        }
    }
}
