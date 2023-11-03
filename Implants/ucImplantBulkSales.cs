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

namespace eMediShop.Implants
{
    public partial class ucImplantBulkSales : UserControl
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty;string _purchaseid = string.Empty;
        public ucImplantBulkSales()
        {
            InitializeComponent();
        }

        private void btnRefreshIds_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "GetImplantBills"; p.prm_1 = "-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                rgv_purchaseid.DataSource = _ds.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_purchaseid_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                radGroupBox1.Text = "[" + e.Row.Cells["purchase_id"].Value.ToString() + "]";
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = e.Row.Cells["purchase_id"].Value.ToString(); p.logic = "GetImplantBillsInfo"; p.prm_1 = "-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                rgv_purchase.DataSource = _ds.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void rgv_purchase_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (Convert.ToInt16(e.RowElement.RowInfo.Cells["StkQty"].Value) == 0)
            {
                e.RowElement.ForeColor = Color.Red;
                btnSalesProcess.Enabled = false;
            }
            else
            {
                e.RowElement.ForeColor = Color.DarkGreen;
            }
        }

        private void btnSalesProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                SaleInvoiceFinalization p = new SaleInvoiceFinalization();
                p.purchaseID = _purchaseid;p.unit_id = GlobalUsage.Unit_id;p.vendorID= "VC50668"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/AutoSalesofPurchaseID", p);
                _ds = dwr.result;
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void ucImplantBulkSales_Load(object sender, EventArgs e)
        {

        }
    }
}
