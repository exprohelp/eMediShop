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

namespace eMediShop.ManualSales
{
    public partial class ucCancelSales : UserControl
    {
        string _manualBillNo = "-";
        public ucCancelSales()
        {
            InitializeComponent();
        }

        private void ucCancelSales_Load(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void btnGetSales_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                pm_SaleRegister p = new pm_SaleRegister();
                p.unit_id = GlobalUsage.Unit_id; p.counter_id = GlobalUsage.CounterID;
                p.f_date = rdp_from.Value.ToString("yyyy/MM/dd"); p.l_date = rdp_to.Value.ToString("yyyy/MM/dd");
                p.sType = "ManualRegisterByID"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/saleregister", p);

                rgvRegister.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rgvRegister_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _manualBillNo = e.Row.Cells["ManualInvNo"].Value.ToString();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_SaleRegister p = new pm_SaleRegister();
                p.unit_id = GlobalUsage.Unit_id; p.counter_id = GlobalUsage.CounterID;
                p.f_date = rdp_from.Value.ToString("yyyy/MM/dd"); p.l_date = rdp_to.Value.ToString("yyyy/MM/dd");
                p.prm_1 = _manualBillNo;
                p.sType = "ManualBillInfo"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/saleregister", p);

                rgvSoldItems.DataSource = dwr.result.Tables[0];
                if (rgvSoldItems.RowCount > 0)
                    btnPrint.Enabled = true;
                else
                    btnPrint.Enabled = false;
                if (e.Row.Cells["sale_inv_no"].Value.ToString() == "N/A")
                { rgChange.Enabled = true; btnChange.Enabled = true; }
                else
                    rgChange.Enabled = false;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Printing.Laser.PrintManualBill(rgvRegister.CurrentRow.Cells["ManualInvNo"].Value.ToString(), "Y");
                btnPrint.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                btnChange.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                cm1 p1 = new cm1();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                p1.prm_1 = GlobalUsage.Login_Name; p1.prm_2 = GlobalUsage.Login_Name;

                if (rbCancel.Checked)
                    p1.Logic = "CancelManualBill";
                else if (rbchCash.Checked)
                {
                    p1.Logic = "ChangePayModeManualBill";
                    p1.prm_1 = "Cash";
                }
                else if (rbchSwipeCard.Checked)
                {
                    p1.Logic = "ChangePayModeManualBill";
                    p1.prm_1 = "Credit Card";
                }
                else if (rbchCredit.Checked)
                {
                    p1.Logic = "ChangePayModeManualBill";
                    p1.prm_1 = "Credit";
                }

                p1.prm_2 = _manualBillNo;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
