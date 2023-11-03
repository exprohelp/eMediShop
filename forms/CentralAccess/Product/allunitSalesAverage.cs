using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;

namespace eMediShop.forms.CentralAccess.Product
{
    public partial class allunitSalesAverage : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        public allunitSalesAverage()
        {
            InitializeComponent();
        }

        private void allunitSalesAverage_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
            FillProductList();
        }
        private void FillProductList()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                cm1 p = new cm1();
                p.Logic = "All-Product"; p.prm_1 = "/A"; p.item_id = "N/A";
                p.prm_2 = "N/A"; p.prm_3 = "N/A";
                p.login_id = GlobalUsage.Login_id; p.unit_id = GlobalUsage.Unit_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                rgvProdName.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvProdName_CommandCellClick(object sender, EventArgs e)
        {
            SingleProductAnalysisFromServer obj = new SingleProductAnalysisFromServer(rgvProdName.CurrentRow.Cells[0].Value.ToString());
            radPanel1.Controls.Clear();
            radPanel1.Controls.Add(obj);
        }
    }
}
