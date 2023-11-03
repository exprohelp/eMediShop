using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.Sales
{
    public partial class uc_SoldProductsInfo : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty;
        public uc_SoldProductsInfo()
        {
            InitializeComponent();
        }

        private void uc_SoldProductsInfo_Load(object sender, EventArgs e)
        {
            rdtp_from.Value = DateTime.Today;
            rdtp_to.Value = DateTime.Today;
        }

        private void rbtn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                p.dtFrom = rdtp_from.Value.ToString("yyyy/MM/dd");
                p.dtTo = rdtp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditSoldProducts", p);
                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rgb_info_Click(object sender, EventArgs e)
        {

        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "SoldProductsInfo.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgv_info);
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
