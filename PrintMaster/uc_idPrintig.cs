using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Microsoft.Reporting.WinForms;

namespace eMediShop.PrintMaster
{
    public partial class uc_idPrintig : UserControl
    {
        Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
        DataSet _ds = new DataSet(); string _result = string.Empty; string _trfid = string.Empty; string _trfTo = string.Empty;
        public uc_idPrintig()
        {
            InitializeComponent();
        }

        private void uc_idPrintig_Load(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string logic = string.Empty;
                if (!chkUnPostedIds.Checked)
                    logic = "distinct_TrfIds";
                else
                    logic = "distinct_TrfIdsNP";

                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.tran_id = "-"; p.Logic = logic;
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;
                rgv_ids.DataSource = _ds.Tables[0];

                //                Printing.Laser.InternalSheet(_Trf_Id);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_ids_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string logic = string.Empty;
                if (!chkUnPostedIds.Checked)
                    logic = "Trfid_info";
                else
                    logic = "Trfid_infoNP";
                _trfid = e.Row.Cells["trf_id"].Value.ToString();
                _trfTo = e.Row.Cells["trf_to"].Value.ToString();

                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;p.trf_tounit = _trfTo; p.tran_id = _trfid; p.Logic = logic;
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_internalPaper_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.trf_tounit = _trfTo; p.tran_id = _trfid; p.Logic = "Transfer_FormNew";
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;
                eMediShop.PrintMaster.rdlcViewer obj = new PrintMaster.rdlcViewer(_ds, "Estimate Feeding Sheet (" + _trfid + ")", @"rdlc\internalSheet_Trf.rdlc", "Trf_Internal_Sheet");
                obj.Show();
                //Printing.Laser.InternalSheet(_trfid, "Print");
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPDF_internal_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Printing.Laser.InternalSheet(_trfid, "Pdf");
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_print_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.trf_tounit = _trfTo; p.tran_id = _trfid; p.Logic = "Transfer_FormNew";
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;
                eMediShop.PrintMaster.rdlcViewer obj = new PrintMaster.rdlcViewer(_ds, "Form T-01 (" + _trfid + ")", @"rdlc\TransferSheetWithInState.rdlc", "TransferPaper");
                obj.Show();
                //Printing.Laser.StockTransfer_Form(_ds, _trfid, "Print");
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btn_xls_transfer_Click(object sender, EventArgs e)
        {

        }

        private void btn_pdf_transfer_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.trf_tounit = _trfTo; p.tran_id = _trfid; p.Logic = "TransferId:TransferPaper";
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;
                Printing.Laser.StockTransfer_Form(_ds, _trfid, "PDF");
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnestimate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.trf_tounit = _trfTo; p.tran_id = _trfid; p.Logic = "EstimateFeeding";
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;
             
                eMediShop.PrintMaster.rdlcViewer obj = new PrintMaster.rdlcViewer(_ds, "Estimate Feeding Sheet ("+_trfid+")", @"rdlc\estimateForFeeding.rdlc", "EstimateFeeding");
                obj.Show();

                //report.PrintToPrinter(11.69f, 8.27f, 0.1f, 0.1f, .5f, 0.1f); //parameter in Inches 

            }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
        }
        //private void PrintBill(string sale_inv_no)
        //{
        //    try
        //    {
        //        Cursor.Current = Cursors.WaitCursor;
        //        string qry = "execute pCanteen_ProductQueries '" + GlobalUsage.gUnit_Id + "','PrintBill','" + sale_inv_no + "','-','N/A'";
        //        DataSet ds = GlobalUsage.canteenProxy.GetQueryResult(qry, "ChandanCanteen");

        //        //rptbill.Database.Tables[0].SetDataSource(ds.Tables[0]);
        //        //rptbill.Database.Tables[1].SetDataSource(ds.Tables[1]);
        //        //rptbill.Database.Tables[2].SetDataSource(ds.Tables[2]);
        //        //rptbill.PrintToPrinter(1, false, 1, 0);
        //        //rptbill.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "d:\\canteen.pdf");

        //        if (Convert.ToDecimal(txtTotNet.Text) > 0)
        //        {
        //            report.Refresh();
        //            report.DataSources.Clear();
        //            report.ReportPath = @"msReport\receit.rdlc";
        //            report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
        //            report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
        //            report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
        //            report.PrintToPrinter(3.2f, 8.3f, 0.1f, 0.1f, 0.1f, 0.1f); //parameter in Inches 
        //        }
        //        //KOT Printing
        //        report_KOT.Refresh();
        //        report_KOT.DataSources.Clear();
        //        report_KOT.ReportPath = @"msReport\KOT.rdlc";
        //        report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[1]));
        //        report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", ds.Tables[0]));
        //        report_KOT.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", ds.Tables[2]));
        //        report_KOT.PrintToPrinter(3.2f, 8.3f, 0.1f, 0.1f, 0.1f, 0.1f);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    finally { Cursor.Current = Cursors.Default; }
        //}
    }
}
