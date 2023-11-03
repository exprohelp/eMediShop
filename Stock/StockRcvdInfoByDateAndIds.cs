using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.Stock
{
    public partial class StockRcvdInfoByDateAndIds : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        public StockRcvdInfoByDateAndIds()
        {
            InitializeComponent();
        }

        private void StockRcvdInfoByDateAndIds_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            dtp_date.Value = DateTime.Today;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.trf_tounit = "-"; p.tran_id = "-"; p.Logic = "StockRecIn_A_Day";p.prm_1 = dtp_date.Value.ToString("yyyyMMdd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);

                rgv_info.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
            }
            Cursor.Current = Cursors.Default;
        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            //if (e.RowElement.RowInfo.Cells["Flag(T)"].Value.ToString() == "Y")
            //{
            //e.RowElement.ForeColor=Color.Green;
            //}
        }
    }
}
