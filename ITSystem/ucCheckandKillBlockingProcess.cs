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

namespace eMediShop.ITSystem
{
    public partial class ucCheckandKillBlockingProcess : UserControl
    {
        public ucCheckandKillBlockingProcess()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string trfto = string.Empty;

                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "BlockingInfo"; p.prm_1 = "-"; p.prm_2 = "-"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                rgv_info.DataSource = dwr.result.Tables[0];
                for (int i = 1; i < this.rgv_info.Columns.Count; i++)
                {
                    this.rgv_info.Columns[i].BestFit();
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string trfto = string.Empty;

                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "KillBlockingInfo"; p.prm_1 = "-"; p.prm_2 = "-"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                btnGet.PerformClick();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
