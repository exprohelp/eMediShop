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

namespace eMediShop.Hospital
{
    public partial class ucDailyDispatch_Sales : UserControl
    {
        public ucDailyDispatch_Sales()
        {
            InitializeComponent();
        }

       
        private void ucDailyDispatch_Sales_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

        }

        private void dtpFrom_Leave(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void btnGenerateOrder_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id;p.forunit = "MS-H0073";p.dtfrom = dtpFrom.Value.ToString("yyyy/MM/dd");
                p.dtTo = dtpTo.Value.ToString("yyyy/MM/dd");p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderBySalesDates", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
