using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class ucZeroStockProduct : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty;
        public ucZeroStockProduct()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.prm_1 = "N/A"; p.prm_2 = dtFrom.Value.ToString("yyyyMMdd");
                p.prm_3 = dtTo.Value.ToString("yyyyMMdd"); p.Logic = "ZeroStockList"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
                _ds = dwr.result;
                Fill_Information();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }
        private void Fill_Information()
        {
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    Int32 no = 1;
                    var data = _ds.Tables[0].AsEnumerable().Select(o => new
                    {
                        sno = no++,
                        item_name = o.Field<string>("item_name"),
                        pack_type = o.Field<string>("pack_type"),
                        pack_qty = o.Field<decimal>("pack_qty"),
                        po_packs = o.Field<decimal>("po_packs"),
                        sale_avg = o.Field<decimal>("sale_avg"),
                        npr = o.Field<decimal>("npr"),
                        lastSaleDate = o.Field<DateTime>("sale_date"),
                        Purch_logic = o.Field<string>("Purch_logic"),
                        vendor_name = o.Field<string>("vendor_name"),
                        mfd_name = o.Field<string>("mfd_name")

                    }).OrderBy(ord => ord.item_name);
                    rgv_info.DataSource = data.ToList();
                }
            }
        }

        private void rbtnXL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            string fileName = f.SelectedPath + "\\ZeroStocks.xls";
            Cursor.Current = Cursors.WaitCursor;
            Telerik.WinControls.UI.Export.ExportToExcelML exporter = new Telerik.WinControls.UI.Export.ExportToExcelML(this.rgv_info);
            exporter.ExportVisualSettings = true;
            //exporter.SheetMaxRows = ExcelMaxRows._1048576;
            exporter.RunExport(fileName);
            Cursor.Current = Cursors.Default;
        }

        private void ucZeroStockProduct_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today;
        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }

    }
}
