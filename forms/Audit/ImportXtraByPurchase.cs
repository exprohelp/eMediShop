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
    public partial class ImportXtraByPurchase : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        DataSet _ds = new DataSet();
        public ImportXtraByPurchase()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = txtPurchId.Text; p.logic = "PurchBillInfo";
                p.prm_1 ="-"; p.prm_2 = "-";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                if (Convert.ToInt32(_ds.Tables[3].Rows[0]["NoS"].ToString()) > 0)
                {
                    rgv_info.DataSource = _ds.Tables[0];
                }
                else
                {
                    RadMessageBox.Show("This purchase id not contains Audit Account as Party.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
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

        private void btnProcess_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Do You Confirm To Process? ", "ExPro Help", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) { 
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                    purchSearch ps = new purchSearch();
                    ps.unit_id = GlobalUsage.Unit_id;
                    ps.purch_id = txtPurchId.Text;
                    ps.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/ExtraInByPurchase", ps);
                    RadMessageBox.Show(dwr.message, "ExPro Help",MessageBoxButtons.OK, RadMessageIcon.Info);
                    rgv_info.DataSource = new string[]{ };
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }
    }
    }
