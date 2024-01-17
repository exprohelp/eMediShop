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
using Telerik.WinControls.UI;

namespace eMediShop.contract
{
    public partial class ucOrderData : UserControl
    {
        public ucOrderData()
        {
            InitializeComponent();
        }

        private void ucOrderData_Load(object sender, EventArgs e)
        {
            rdtpFrom.Value = DateTime.Today;
            rdtpTo.Value = DateTime.Today;

        }

        private void rdtpFrom_Leave(object sender, EventArgs e)
        {
            rdtpTo.MinDate = rdtpFrom.Value;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.prm_2 = rdtpTo.Value.ToString("yyyy-MM-dd"); ;
                p.Logic = "Get:OrderData";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                rgvInfo.DataSource = new { };
                rgvInfo.DataSource = dwr.result.Tables[0];
                for (int i = 1; i < this.rgvInfo.Columns.Count; i++)
                {
                    this.rgvInfo.Columns[i].BestFit();
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "AEP_" + GlobalUsage.Audit_No + ".xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgvInfo);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;

                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
