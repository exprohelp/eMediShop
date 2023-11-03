using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.HealthCards
{
    public partial class ucDistributionReport : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty;
        public ucDistributionReport()
        {
            InitializeComponent();
        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _ds = GlobalUsage.healthcard_proxy.HealthCardRegister(out _result, GlobalUsage.Unit_id, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), "Pharmacy", GlobalUsage.Login_id);
                fill_Info();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.WaitCursor; }
            btnGo.Enabled = true;
        }
        private void fill_Info()
        {
            var data = _ds.Tables[0].AsEnumerable().Select(r =>
                new
                {
                    date = r.Field<DateTime>("cr_date"),
                    card_no = r.Field<string>("card_no"),
                    cust_name = r.Field<string>("cust_info"),
                    mobileNo = r.Field<string>("MobileNo"),
                    phoneNo = r.Field<string>("PhoneNo"),
                    flag = r.Field<string>("Confirm_Flag")
                });
            _ds.Dispose();
            rgv_info.DataSource = data.ToList();
        }

        private void rbtnXL_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();
                string fileName = f.SelectedPath + "\\CardDistList.xls";
                Cursor.Current = Cursors.WaitCursor;
                Telerik.WinControls.UI.Export.ExportToExcelML exporter = new Telerik.WinControls.UI.Export.ExportToExcelML(this.rgv_info);
                exporter.ExportVisualSettings = true;
                //exporter.SheetMaxRows = ExcelMaxRows._1048576;
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Flag [C]"].Value.ToString() == "Y")
                e.RowElement.ForeColor = Color.Green;
            else
                e.RowElement.ForeColor = Color.Red;
        }
    }
}
