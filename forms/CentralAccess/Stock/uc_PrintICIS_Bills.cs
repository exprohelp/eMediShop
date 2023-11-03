using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.Stock
{
    public partial class uc_PrintICIS_Bills : UserControl
    {
        DataSet _ds = new DataSet();
        string trf_date = string.Empty; string _result = string.Empty; string _saleInvNo = string.Empty;

        public uc_PrintICIS_Bills()
        {
            InitializeComponent();
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void rb_go_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _result = DateTime.Now.Second.ToString();
                _ds = GlobalUsage.pharmacy_proxy.WholeSale_Queries(out _result, GlobalUsage.Unit_id, "SalesInvoices", rdp_from.Value.ToString("yyyyMMdd"), rdp_to.Value.ToString("yyyyMMdd"));
                rgv_ids.DataSource = _ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rb_print_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Printing.Laser.WholeSalesInvoice(_ds, _saleInvNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void rgv_ids_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _saleInvNo = e.Row.Cells[0].Value.ToString();
                _ds = GlobalUsage.pharmacy_proxy.WholeSale_Queries(out _result, GlobalUsage.Unit_id, "Invoice_Info", _saleInvNo, "N/A");
                rgv_info.DataSource = _ds.Tables[2];
                if (rgv_info.Rows.Count > 0)
                    rb_print.Enabled = true;
                else
                    rb_print.Enabled = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
