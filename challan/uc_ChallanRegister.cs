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

namespace eMediShop.challan
{
    public partial class uc_ChallanRegister : UserControl
    {
        public uc_ChallanRegister()
        {
            InitializeComponent();
        }

        private void uc_ChallanRegister_Load(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void rbtn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "ALL";
                p.prm_1 = rdp_from.Value.ToString("yyyyMMdd"); p.prm_2 = rdp_to.Value.ToString("yyyyMMdd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ChallanQueries", p);
                rgv_info.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show("Check Internet Connection.", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["color"].Value.ToString() == "Red")
                e.RowElement.ForeColor = Color.Red;
            else
                e.RowElement.ForeColor = Color.Green;

        }
    }
}
