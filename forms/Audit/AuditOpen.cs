using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.Audit
{
    public partial class AuditOpen : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty;
        public AuditOpen()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "AuditMaster"; p.keyString = "N/A"; p.audit_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);

                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];
                if (_ds.Tables[0].Rows.Count == 0)
                    btn_Open.Enabled = true;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["open_flag"].Value.ToString() == "Y")
            { 
                e.RowElement.ForeColor = Color.Red;
                btn_Open.Enabled = false;
            }
            else
                e.RowElement.ForeColor = Color.Green;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "OpenAudit"; p.keyString = "N/A"; p.audit_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);
                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
