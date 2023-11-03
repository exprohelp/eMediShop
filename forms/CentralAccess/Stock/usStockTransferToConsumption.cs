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

namespace eMediShop.forms.CentralAccess.Stock
{
    public partial class usStockTransferToConsumption : UserControl
    {
        DataSet _ds = new DataSet();string _saleInvoiceNo = string.Empty;
        public usStockTransferToConsumption()
        {
            InitializeComponent();
        }

        private void rgvInvoices_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _saleInvoiceNo = e.Row.Cells["saleinvno"].Value.ToString();
                btnProcess.Enabled = true;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "Sale:ProcessForCons2";
                p.prm_1 = e.Row.Cells["saleinvno"].Value.ToString(); p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                rgv_info.DataSource = dwr.result.Tables[0];
                _ds = dwr.result;


            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

       

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "Sale:ProcessForCons1"; p.prm_1 = "-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                rgvInvoices.DataSource = dwr.result.Tables[0];
                _ds = dwr.result;


            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Transfer p = new pm_Transfer();
                p.unit_id = GlobalUsage.Unit_id;p.transaction_id = _saleInvoiceNo; p.TransferToUnit = "MS-H0049";
                p.prm_1 = "-"; p.prm_2 = "-";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/AutoEntryForHospitalConsumption", p);
                if (dwr.message.Contains("Success"))
                {
                    rgvInvoices.CurrentRow.Delete();
                    btnProcess.Enabled = false;
                }


            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
