using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Tools
{
    public partial class toolsPharmacy : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        public toolsPharmacy()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string qry = string.Empty;
            try
            {
                ddSaleInvNo.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id;p.sale_inv_no = txtSearch.Text;p.item_id = "-";
                p.logic = "SearchSaleInv";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);
                ddSaleInvNo.Items.AddRange(GlobalUsage.FillTelrikCombo(dwr.result.Tables[0]));
                ddSaleInvNo.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string qry = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id; p.sale_inv_no = ddSaleInvNo.SelectedValue.ToString(); p.item_id = "-";
                p.logic = "SaleInvInfo"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);

                dgList.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            
            string qry = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id; p.sale_inv_no = ddSaleInvNo.SelectedValue.ToString(); p.item_id = "-";
                p.logic = "SaleInvBlock"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);
                RadMessageBox.Show("Request Successfully Processed.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void toolsPharmacy_Load(object sender, EventArgs e)
        {
            rdtp_from.Value = DateTime.Today;
            rdtp_to.Value = DateTime.Today;
        }

        private void rdtp_from_Leave(object sender, EventArgs e)
        {
            rdtp_to.MinDate = rdtp_from.Value;
        }

        private void btnReportData_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "SalesInvoice:BlockList"; p.prm_2 = rdtp_from.Value.ToString("yyyyMMdd");
                p.prm_1 = "N/A"; p.prm_3 = rdtp_to.Value.ToString("yyyyMMdd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                rgv_BlockReport.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "InvoiceBlockReport.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgv_BlockReport);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;
                    //spreadExporter.SheetName = "OrderStatus";
                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
