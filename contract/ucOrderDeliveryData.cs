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
using Telerik.WinControls.UI;

namespace eMediShop.contract
{
    public partial class ucOrderDeliveryData : UserControl
    {
        string _orderNo = string.Empty;
        public ucOrderDeliveryData()
        {
            InitializeComponent();
        }

        private void ucOrderDeliveryData_Load(object sender, EventArgs e)
        {
            rdtpFrom.Value = DateTime.Today;
           

        }

        private void rdtpFrom_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.prm_2 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.Logic = "Get_DeliveryNoteInfo";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                rgvOrderNo.DataSource = new { };
                rgvOrderNo.DataSource = dwr.result.Tables[0];

                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.prm_2 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.Logic = "Get_DeliveryNoteData";
                dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
               
                rgvrawdata.DataSource = new { };
                rgvrawdata.DataSource = dwr.result.Tables[0];

                for (int i = 1; i < this.rgvrawdata.Columns.Count; i++)
                {
                    this.rgvrawdata.Columns[i].BestFit();
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
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

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgvInfo);
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

        private void rgvOrderNo_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            _orderNo= e.Row.Cells["orderNo"].Value.ToString();
            FillOrderItemsInfo(_orderNo);
        }

        private void FillOrderItemsInfo(string orderNo)
        {
            try
            {
               
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = orderNo;
                p.prm_2 = "";
                p.Logic = "Get_DeliveryItemsInfo";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                rgvInfo.DataSource = new { };
                rgvInfo.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvInfo_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = e.Row.Cells["del_note_no"].Value.ToString();
                p.prm_2 = e.Row.Cells["sale_trn_no"].Value.ToString(); ;
                p.Logic = "Delete_DeliveryItems";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                
                FillOrderItemsInfo(_orderNo);
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm to deliver (Y/N) ", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.prm_1 = _orderNo;
                    p.prm_2 = "";
                    p.Logic = "UpdateDelivery";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);

                    FillOrderItemsInfo(_orderNo);
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvInfo_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["isDelivered"].Value.ToString() == "Y")
                e.RowElement.ForeColor = Color.Green;
            else
                e.RowElement.ForeColor = Color.Black;

        }

        private void rgvInfo_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "column1")
                {
                    // ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    if (e.CellElement.RowInfo.Cells["isDelivered"].Value.ToString() == "Y")
                    {
                        //((GridCommandCellElement)e.CellElement).CommandButton.Image = Resources.attachment;
                        //((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                        ((GridCommandCellElement)e.CellElement).CommandButton.Enabled = false;
                    }
                    else
                    {
                        ((GridCommandCellElement)e.CellElement).CommandButton.Enabled = true;
                    }

                }
            }
        }
    }
}
