using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;

namespace eMediShop.forms.Stock
{
    public partial class uc_StocksAsOn : UserControl
    {
        string _result = string.Empty;
        public uc_StocksAsOn()
        {
            InitializeComponent();
        }

        private void rbtn_GetStocks_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "CurrentStock";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);

                if (dwr.message.Contains("Success"))
                    rgv_info.DataSource = dwr.result.Tables[0];
                else
                    rgv_info.DataSource = new string[] { };

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rbtn_xl_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            string fileName = f.SelectedPath + "\\StocksValue.xls";
            Cursor.Current = Cursors.WaitCursor;
            ExportToExcelML exporter = new ExportToExcelML(this.rgv_info);
            exporter.ExportVisualSettings = true;
            //exporter.SheetMaxRows = ExcelMaxRows._1048576;
            exporter.RunExport(fileName);
            Cursor.Current = Cursors.Default;
        }
    }
}
