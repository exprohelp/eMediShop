using System;
using System.Data;
using System.Windows.Forms;

namespace eMediShop.contract
{
    public partial class ucNERBill : UserControl
    {
        public ucNERBill()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                selectQry p = new selectQry();
                p.unitID = GlobalUsage.Unit_id; p.Logic = "NER:Invoices";
                p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.prm_2 = rdtpTo.Value.ToString("yyyy-MM-dd");
                p.prm_3 = "-"; p.loginId = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/ContractQueries", p);
                DataSet ds = dwr.result;
                rgv_info.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            { }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                selectQry p = new selectQry();
                p.unitID = GlobalUsage.Unit_id; p.Logic = "NER:BillInfo";
                p.tranId = e.Row.Cells["sale_inv_no"].Value.ToString();
                p.prm_1 = e.Row.Cells["category"].Value.ToString();
                p.prm_2 = "-";

                p.prm_3 = "-"; p.loginId = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/ContractQueries", p);
                DataSet ds = dwr.result;

                Printing.Laser.NER_Bill(ds, e.Row.Cells["sale_inv_no"].Value.ToString());

            }
            catch (Exception ex)
            { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void ucNERBill_Load(object sender, EventArgs e)
        {
            rdtpFrom.Value = DateTime.Today;
            rdtpTo.Value = DateTime.Today;

        }

        private void rdtpFrom_Leave(object sender, EventArgs e)
        {
            rdtpTo.MinDate = rdtpFrom.Value;
        }
    }
}
