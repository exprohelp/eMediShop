using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using Telerik.WinControls.UI;
using Telerik.WinControls;
namespace eMediShop
{
    public partial class SaleRegister : Telerik.WinControls.UI.RadForm
    {
        string _SalesType = string.Empty; string _result = string.Empty; string _HealthCardNo = string.Empty; string _sale_inv_no = string.Empty;
        string _oldValue = string.Empty; string _newValue = string.Empty;
        public SaleRegister()
        {
            InitializeComponent();
        }
        private void SaleRegister_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);

            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }
        private void rbtn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_SaleRegister p = new pm_SaleRegister();
                p.unit_id = GlobalUsage.Unit_id; p.counter_id = GlobalUsage.CounterID;
                p.f_date = rdp_from.Value.ToString("yyyy/MM/dd"); p.l_date = rdp_to.Value.ToString("yyyy/MM/dd");
                p.sType = "ALL"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/saleregister", p);

                rgv_info.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (Convert.ToDecimal(e.RowElement.RowInfo.Cells["Net"].Value) < 0)
                e.RowElement.ForeColor = Color.Red;
            else
                e.RowElement.ForeColor = Color.Blue;
        }

        private void MasterTemplate_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement.RowInfo.Group == null && e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.ForeColor = Color.Blue;
                e.CellElement.TextAlignment = ContentAlignment.BottomRight;
                e.CellElement.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
            }
        }

        private void rgv_info_Click(object sender, EventArgs e)
        {

        }

        private void rgv_info_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.H)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    HomeDeliverySlip(rgv_info.CurrentRow.Cells["Inv No"].Value.ToString());
                }
                catch (Exception ex) { }
                finally { Cursor.Current = Cursors.Default; }
            }
        }
        private void CardHelp_CardUpdated(object sender, HealthCardUpdatedEventArgs e)
        {
            if (_sale_inv_no.Length > 10)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Stock:UpdateByAudit"; p.prm_1 = e.NewCardName;
                    p.tran_id = _sale_inv_no;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    rgv_info.CurrentRow.Cells["Name of Patient"].Value = e.NewCardName;
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }

            }
        }

        private void rgv_info_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            else if (Convert.ToDecimal(e.Row.Cells["Net"].Value) < 0)
                return;
            if (e.Column.Name == "Prescribed By")
            {
                _oldValue = e.Row.Cells["Prescribed By"].Value.ToString();
            }
            else if (e.Column.Name == "Name of Patient")
            {
                _oldValue = e.Row.Cells["Name of Patient"].Value.ToString();
            }
        }

        private void rgv_info_CellEndEdit(object sender, GridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
                return;
            else if (Convert.ToDecimal(e.Row.Cells["Net"].Value) < 0)
                return;
            if (e.Column.Name == "Prescribed By")
            {
                _newValue = e.Row.Cells["Prescribed By"].Value.ToString();
            }
            else if (e.Column.Name == "Name of Patient")
            {
                _newValue = e.Row.Cells["Name of Patient"].Value.ToString();
            }
            if (_oldValue != _newValue)
            {
                string ref_name = rgv_info.CurrentRow.Cells["Prescribed By"].Value.ToString();
                string pt_name = rgv_info.CurrentRow.Cells["Name of Patient"].Value.ToString();
                _sale_inv_no = rgv_info.CurrentRow.Cells["Inv No"].Value.ToString();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "sale_master:RefName_Ptname"; p.prm_1 = pt_name; p.prm_2 = ref_name;
                p.tran_id = _sale_inv_no;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
            }
        }

        private void HomeDeliverySlip(string SalesInvNo)
        {
            try
            {
                string _result = string.Empty;
                pm_BillInfo p = new pm_BillInfo();
                p.unit_id = GlobalUsage.Unit_id; p.Bill_No = SalesInvNo; p.login_id = GlobalUsage.Login_id; p.login_name = GlobalUsage.Login_Name;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/billInformation", p);
                CrystalReportsPharmacy.eMediShop.HomeDeliverySlip rpt = new CrystalReportsPharmacy.eMediShop.HomeDeliverySlip();
                rpt.SetParameterValue("unitName", GlobalUsage.UnitName);
                rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                rpt.SetParameterValue("HealthCardNo", dwr.result.Tables[0].Rows[0]["card_no"]);
                rpt.SetParameterValue("CustomerName", dwr.result.Tables[0].Rows[0]["pt_name"]);
                rpt.SetParameterValue("ContactNo", dwr.result.Tables[0].Rows[0]["mobile_no"]);
                rpt.SetParameterValue("Area", "Area     : " + dwr.result.Tables[0].Rows[0]["area"]);
                rpt.SetParameterValue("locality", "Locality : " + dwr.result.Tables[0].Rows[0]["locality"]);
                rpt.SetParameterValue("district", "District : " + dwr.result.Tables[0].Rows[0]["district"]);
                rpt.SetParameterValue("state", "State    : " + dwr.result.Tables[0].Rows[0]["state"]);
                rpt.SetParameterValue("salesInvNo", ": " + dwr.result.Tables[0].Rows[0]["sale_inv_no"]);
                rpt.SetParameterValue("LoginID", GlobalUsage.Login_id);
                rpt.SetParameterValue("amt", Convert.ToDecimal(dwr.result.Tables[0].Rows[0]["Net"]).ToString(""));
                rpt.PrintToPrinter(1, false, 1, 0);
                if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                {
                    string path = GlobalUsage.BillDrive + "\\DeliverySlip\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    string filename = SalesInvNo.Substring(0, SalesInvNo.Length - 6);
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + filename + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + filename + ".pdf"); }
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path + "\\" + filename + ".pdf");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xl_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "SaleRegister.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgv_info);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;
                    //spreadExporter.SheetName = "OrderStatus";
                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
