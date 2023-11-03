using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;

namespace eMediShop.forms.TransferIds
{
    public partial class ucSearchInTransit : UserControl
    {
        string _result = string.Empty;
        public ucSearchInTransit()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.prm_1 = "N/A";p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.Logic = "InTransit"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
                rgv_info.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {

            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnxl_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            string fileName = f.SelectedPath + "\\Stock_In_Transit.xls";
            Cursor.Current = Cursors.WaitCursor;
            ExportToExcelML exporter = new ExportToExcelML(this.rgv_info);
            exporter.ExportVisualSettings = true;
            //exporter.SheetMaxRows = ExcelMaxRows._1048576;
            exporter.RunExport(fileName);
            Cursor.Current = Cursors.Default;
        }
    }
}
