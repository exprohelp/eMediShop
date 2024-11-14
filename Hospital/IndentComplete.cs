using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Hospital
{
    public partial class IndentComplete : Telerik.WinControls.UI.RadForm
    {
        public IndentComplete()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void IndentComplete_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.from = "1900/01/01"; p.to = "1900/01/01"; p.card_no = "-"; p.uhid = "";
                p.IPOPNo = "-"; p.logic = "Indent:ToComplete";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                rgv_info.DataSource = dwr.result.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You want to Complete (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Indent-Out"; p.tran_id = e.Row.Cells["indentno"].Value.ToString();
                    datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    rgv_info.CurrentRow.Delete();
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You want to Revert (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Indent-Revert"; p.tran_id = rgv_info.CurrentRow.Cells["indentno"].Value.ToString();
                    datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    rgv_info.CurrentRow.Delete();
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
