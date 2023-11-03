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
using Telerik.WinControls.UI.Export;

namespace eMediShop.Stock
{
    public partial class ucCheckWholeStockAudit : UserControl
    {
        private eMediShop.forms.Reconcilation.KeyTracing frmKeyTracing;
   
        public ucCheckWholeStockAudit()
        {
            InitializeComponent();
        }

        private void btnReconcile_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Stocks p = new pm_Stocks();
                p.unit_id = GlobalUsage.Unit_id;
                p.master_key_id = "N/A"; p.searchKey = "N/A"; p.logic = "FullTracingByKey"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductMovementInfo", p);
                rgv_info.DataSource = dwr.result.Tables[0];
              }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.frmKeyTracing = new eMediShop.forms.Reconcilation.KeyTracing(rgv_info.CurrentRow.Cells["master_key_id"].Value.ToString());
            this.frmKeyTracing.SearchUpdated += new SearchCashMemoEventHandler(KeyTraceResult);
            frmKeyTracing.Show();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void KeyTraceResult(object sender, CashMemeoNoUpdatedEventArgs e)
        {
            if (e.CASHMEMONO.Contains("Success")){
                rgv_info.CurrentRow.Delete();
            }
        }

        private void rgv_info_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.O)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_Stocks p = new pm_Stocks();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.master_key_id = rgv_info.CurrentRow.Cells["master_key_id"].Value.ToString() ;
                    p.qty =Convert.ToInt16(rgv_info.CurrentRow.Cells["balQty"].Value);
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/UpdateInsertOpeningStock", p);
                    if (dwr.message.Contains("Success"))
                        rgv_info.CurrentRow.Delete();
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            ExportToExcelML exporter = new ExportToExcelML(this.rgv_info);
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            exporter.ExportVisualSettings = true;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                exporter.RunExport(fd.SelectedPath  +"\\WholeStockAudit.xls");
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

            
        }
    }
}
