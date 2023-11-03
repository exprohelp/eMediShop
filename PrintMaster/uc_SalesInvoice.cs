using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.PrintMaster
{
    public partial class uc_SalesInvoice : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _invoiceNo = string.Empty; string _trfTo = string.Empty;
        string _logic = string.Empty;
        public uc_SalesInvoice(string logic)
        {
            InitializeComponent();
            _logic = logic;
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
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;;p.Logic = _logic;
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                rgv_ids.DataSource = dwr.result.Tables[0];

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
                _invoiceNo = e.Row.Cells["sale_inv_no"].Value.ToString();
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;p.tran_id= _invoiceNo; p.Logic = _logic+"_Info";
                p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd"); p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;
                rgv_info.DataSource = dwr.result.Tables[2];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }





        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Printing.Laser.ICTV_Invoice(_ds, _invoiceNo);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
