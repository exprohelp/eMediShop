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

namespace eMediShop.Stock
{
    public partial class ucDailyDispatch : UserControl
    {
        public ucDailyDispatch()
        {
            InitializeComponent();
        }

        private void ucDailyDispatch_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "AllUnit";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);
                ddlUnits.DataSource = dwr.result.Tables[0];
                ddlUnits.ValueMember = "Unit_id"; ddlUnits.DisplayMember = "sh_name";
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
         
        }

        private void ddlUnits_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            rgvDailyDispatchStatus.DataSource = new string[] { };
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_DailyDispatch p = new pm_DailyDispatch();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "ListWithStock";p.tounitid = ddlUnits.SelectedValue.ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/InsertModifyDailyDispatch", p);
                rgvDailyDispatchStatus.DataSource = dwr.result.Tables[0];
                if(rgvDailyDispatchStatus.Rows.Count()>0)
                    btnProcess.Enabled = true;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {

                pm_Transfer p = new pm_Transfer();
                p.unit_id = GlobalUsage.Unit_id; p.TransferToUnit = ddlUnits.SelectedValue.ToString() ; p.tran_type = "-";
                p.logic = "DailyDispatch"; p.login_id = GlobalUsage.Login_id; p.transaction_id = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/BulkTransaction_Processing", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                if (dwr.message.Contains("Success"))
                {
                    btnProcess.Enabled = false;
                }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
