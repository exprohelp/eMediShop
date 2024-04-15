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

namespace eMediShop.contract
{
    public partial class ucGroupBilling : UserControl
    {
        DataSet _billds = new DataSet();
        string _masterOrderNo = string.Empty; string _orderdate = string.Empty;
        public ucGroupBilling()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.prm_2 = rdpTo.Value.ToString("yyyy-MM-dd");
                p.Logic = "OrderNos";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);

                rgvOrderHeaders.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvOrderHeaders_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _masterOrderNo = e.Row.Cells["MasterOrderNo"].Value.ToString();
            _orderdate = e.Row.Cells["orderdate"].Value.ToString();
            if (e.Row.Cells["isClosed"].Value.ToString() == "Y")
            {
               
                btnBillProcess.Enabled = false;
            }
            else if (e.Row.Cells["isDelivered"].Value.ToString() == "Y")
            {
                btnBillProcess.Enabled = true;
            }
            else
                btnBillProcess.Enabled = false;


            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = Convert.ToDateTime(e.Row.Cells["orderdate"].Value).ToString("yyyy-MM-dd"); 
                p.prm_2 = "-";
                p.Logic = "MasterOrder-Summary";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                _billds = dwr.result;
                rgvLineItems.DataSource = dwr.result.Tables[1];

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void ucGroupBilling_Load(object sender, EventArgs e)
        {
            rdtpFrom.Value = DateTime.Today;
            rdpTo.Value = DateTime.Today;
        }

        private void rdtpFrom_Leave(object sender, EventArgs e)
        {
            rdpTo.MinDate = rdtpFrom.Value;
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "AEP_" + GlobalUsage.Audit_No + ".xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgvLineItems);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;

                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You want to Print", "ExPro Help", MessageBoxButtons.YesNo);
                if(res==DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Printing.Laser.HAL_DeliverySummary(_billds, _masterOrderNo, _orderdate);
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

           
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            
        }

        private void btnBillProcess_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm to Generate the Bill ? ", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    btnBillProcess.Enabled = false;
                    pm_sales p = new pm_sales();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.order_no = _masterOrderNo;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/HALBulkSalesProcess", p);
                    if (dwr.message.Contains("Successfully Generated"))
                        btnGo.PerformClick();
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.P))
            {
                string DeliveryNo = rgvLineItems.CurrentRow.Cells["Del_Note_No"].Value.ToString();
                if (MessageBox.Show("Do You Want To Print Delivery Note ?  " + DeliveryNo, "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        Printing.Laser.HAL_DeliveryNote(DeliveryNo, "Y");
                }
            }
        }

        private void MasterTemplate_RowFormatting_1(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["isDelivered"].Value.ToString() == "Y")
            {
                e.RowElement.ForeColor = Color.Green;
            }
            else
            {
                e.RowElement.ForeColor = Color.Red;
            }

            
        }
    }
}
