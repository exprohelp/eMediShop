using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMediShop.Inventory
{
    public partial class ucStockRecRegister : UserControl
    {
        public ucStockRecRegister()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "IDReceving-Register"; p.dtFrom = rdp_from.Value.ToString("yyyy/MM/dd");
                p.dtTo = rdp_to.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                if (dwr.message.Contains("Success"))
                    rgv_info.DataSource = dwr.result.Tables[0];
                else
                    rgv_info.DataSource = new string[] { };
            }
            catch (Exception ex)
            {

            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void ucStockRecRegister_Load(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (MessageBox.Show("Is Printer Ready (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Printing.Laser.LocationSheet(e.Row.Cells["trf_id"].Value.ToString(), "Print");
            }
        }
    }
}
