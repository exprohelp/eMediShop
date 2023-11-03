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

namespace eMediShop.Hospital
{
    public partial class ucIPD_ExtraIn : UserControl
    {
        public ucIPD_ExtraIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_IPOPQueries pm = new pm_IPOPQueries();
            pm.unit_id = GlobalUsage.Unit_id; pm.card_no = "-"; pm.uhid = "-"; pm.IPOPNo = txtIpdNo.Text; pm.from = "1900/01/01"; pm.to = "1900/01/01";
            pm.prm_1 = "-"; pm.logic = "TPA-Extra"; pm.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", pm);
            DataSet dsVerify = dwr.result;
            rgv_processedIndent.DataSource = dsVerify.Tables[0];
                if (dsVerify.Tables[0].Rows.Count > 0)
                    btnGenExtra.Enabled = true;
                else
                    btnGenExtra.Enabled = false;

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }

        private void rgv_processedIndent_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int OldQty = Convert.ToInt16(rgv_processedIndent.CurrentRow.Cells["sale_qty"].Value);
            int InQty = Convert.ToInt16(rgv_processedIndent.CurrentRow.Cells["ExtraIn"].Value);
            string masterkeyid = rgv_processedIndent.CurrentRow.Cells["master_key_id"].Value.ToString();
            if ( InQty<0 || InQty>OldQty)
            {
                RadMessageBox.Show("Quantity Should be between  1 and "+OldQty.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                rgv_processedIndent.CurrentRow.Cells["ExtraIn"].Value = 0;
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p1 = new cm1();
                    p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                    p1.prm_1 = masterkeyid; p1.prm_2 = InQty.ToString();
                    p1.Logic = "TPA-Extra"; p1.tran_id = txtIpdNo.Text;
                    datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void btnGenExtra_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnGenExtra.Enabled = false;
                cm1 p1 = new cm1();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                p1.prm_1 = "-"; p1.prm_2 = "-";
                p1.Logic = "-"; p1.tran_id = txtIpdNo.Text;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/purchase/ExtraInTPA_Process", p1);
                RadMessageBox.Show(dwr1.message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_processedIndent_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["trf_flag"].Value.ToString() != "N")
            {
                e.RowElement.RowInfo.Cells["ExtraIn"].ReadOnly = true;
                
            }
        }
    }
}
