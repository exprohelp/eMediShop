using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Utility
{
    public partial class ucBulkBillPrinting : UserControl
    {
        string _saleInvNo = string.Empty;
        DataSet _ds = new DataSet();
        public ucBulkBillPrinting()
        {
            InitializeComponent();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //foreach(DataRow dr in _ds.Tables[0].Rows) {
                //GridViewRowInfo lastRow1 = radGridView1.Rows[radGridView1.Rows.Count - 1];
                //  lastRow1.IsSelected = true;
                GridDataView dataView = this.rgvInfo.MasterTemplate.DataView as GridDataView;
                foreach (GridViewRowInfo rowInfo in dataView.Indexer.Items)
                {
                    _saleInvNo = rowInfo.Cells["sale_inv_no"].Value.ToString();
                    Printing.Laser.CashMemo(_saleInvNo, "Y");

                }
                btnPrintAll.Enabled = false;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _saleInvNo = e.Row.Cells["sale_inv_no"].Value.ToString();
            if (MessageBox.Show("Do You Want To Print Bill ? " + _saleInvNo, "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Printing.Laser.CashMemo(_saleInvNo, "Y");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
                return;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                radGroupBox1.Text = txtSearch.Text;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GetBulkInvInfo";
                if (rbByIPD.IsChecked)
                    p.prm_1 = "IPD";
                else if (rbByUHID.IsChecked)
                    p.prm_1 = "UHID";
                p.prm_2 = txtSearch.Text;
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                rgvInfo.DataSource = dwr.result.Tables[0];
                if (rgvInfo.RowCount > 0)
                    btnPrintAll.Enabled = true;

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
