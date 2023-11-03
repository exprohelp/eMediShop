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
using Newtonsoft.Json;

namespace eMediShop.Stock
{
    public partial class ExtraStockProcess : Telerik.WinControls.UI.RadForm
    {
        string _jsonString = string.Empty;string _result = string.Empty;DataSet _ds = new DataSet();
        public ExtraStockProcess()
        {
            InitializeComponent();
        }

        private void rbTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTransfer.Checked)
            { 
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "UnitsForTransfer";
                    p.prm_1 = "Extra"; p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);

                    rddl_unitname.Items.Clear();
                    rddl_unitname.Items.AddRange(Config.FillTelrikCombo(dwr.result.Tables[0]));
                    rddl_unitname.SelectedIndex = 0;
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void rbSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSales.Checked)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "UnitsForSales";
                    p.prm_1 = "N/A"; p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);

                    rddl_unitname.Items.Clear();
                    if (dwr.result.Tables[0].Rows.Count>0) { 
                    rddl_unitname.Items.AddRange(Config.FillTelrikCombo(dwr.result.Tables[0]));
                    rddl_unitname.SelectedIndex = 0;
                    }
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string trfto = string.Empty;
                trfto = rddl_unitname.SelectedValue.ToString();
                if (rbSales.Checked)
                {
                    string[] t = trfto.Split('|');
                    trfto = t[0].ToString();
                }
                pm_Transfer p = new pm_Transfer();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "ExtraItems"; p.TransferToUnit = trfto; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ExtraStockChecking", p);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string trfto = string.Empty;
                if (rbSales.Checked)
                {
                    string[] t = rddl_unitname.SelectedValue.ToString().Split('|');
                    trfto = t[0];
                }
                else
                    trfto = rddl_unitname.SelectedValue.ToString();
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = "ExtraItems";p.login_id = GlobalUsage.Login_id;p.prm_1 = trfto;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ExtraStockQueries", p);
                rgvInfo.DataSource = dwr.result.Tables[0];
                for (int i = 1; i < this.rgvInfo.Columns.Count; i++)
                {
                    this.rgvInfo.Columns[i].BestFit();
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You want to Process ? ", "ExPro Help", MessageBoxButtons.YesNo);
                if(res==DialogResult.Yes)
                {
                    pm_Transfer p = new pm_Transfer();
                    datasetWithResult dwr = new datasetWithResult();
                    if (rbTransfer.Checked)
                    {
                        p.unit_id = GlobalUsage.Unit_id; p.TransferToUnit = rddl_unitname.SelectedValue.ToString(); p.login_id = GlobalUsage.Login_id;
                        dwr = ConfigWebAPI.CallAPI("api/stocks/ExtraStockTransferToUnit", p);
                    }
                    else if (rbSales.Checked)
                    {
                        string[] t = rddl_unitname.SelectedValue.ToString().Split('|');
                        p.unit_id = GlobalUsage.Unit_id;p.TransferToUnit = t[0]; p.party_id = t[1];p.party_account_no = t[2];
                        p.login_id = GlobalUsage.Login_id;
                        dwr = ConfigWebAPI.CallAPI("api/stocks/ExtraSoldToCustomer", p);
                    }
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void ExtraStockProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
