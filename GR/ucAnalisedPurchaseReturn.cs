using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.GR
{
    public partial class ucAnalisedPurchaseReturn : UserControl
    {
        string _result = string.Empty; DataSet _ds = new DataSet(); string _oldRemark = string.Empty; string _old_GrNo = string.Empty;
        public ucAnalisedPurchaseReturn()
        {
            InitializeComponent();
        }

        private void btnLoadInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GR_Working_ByUnit"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rgv_info_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {

            if (e.RowIndex == -1)
                return;
            if (e.Column.Name == "gr_no")
            {
                _old_GrNo = e.Row.Cells["gr_no"].Value.ToString();
            }
            else if (e.Column.Name == "remarks")
            {
                _oldRemark = e.Row.Cells["remarks"].Value.ToString();
            }

        }

        private void rgv_info_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.Column.Name == "gr_no")
            {
                if (_old_GrNo != e.Row.Cells["gr_no"].Value.ToString())
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        pm_PurchaseReturn p = new pm_PurchaseReturn();
                        p.autoid = e.Row.Cells["auto_id"].Value.ToString();p.logic = "GR_No";
                        p.updateInfo = e.Row.Cells["gr_no"].Value.ToString();p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PoolPurchaseReturnUpdate", p);
                        RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }

                }
            }
            else if (e.Column.Name == "remarks")
            {
                if (_oldRemark != e.Row.Cells["remarks"].Value.ToString())
                {
                    try
                    {
                        pm_PurchaseReturn p = new pm_PurchaseReturn();
                        p.autoid = e.Row.Cells["auto_id"].Value.ToString(); p.logic = "Remark";
                        p.updateInfo = e.Row.Cells["remarks"].Value.ToString(); p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PoolPurchaseReturnUpdate", p);
                        RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }
                }
            }

        }

        private void btnXLExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();

                dialog.FileName = "PurchaseReturnByHO.xlsx";


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
