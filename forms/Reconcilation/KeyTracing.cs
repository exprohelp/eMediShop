using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.Reconcilation
{
    public partial class KeyTracing : Telerik.WinControls.UI.RadForm
    {
        public event SearchCashMemoEventHandler SearchUpdated;
        string _result = string.Empty; DataSet _ds = new DataSet(); string _masterKey = string.Empty;
        public KeyTracing(string master_key_id)
        {
            _masterKey = master_key_id;
            this.Text = "Key Tracing : " + _masterKey;
            InitializeComponent();
        }

        private void KeyTracing_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Stocks p = new pm_Stocks();
                p.unit_id = GlobalUsage.Unit_id;
                p.master_key_id = _masterKey; p.searchKey = "N/A"; p.logic = "MasterKeyTracing"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductMovementInfo", p);
                rgv_info.DataSource = dwr.result.Tables[0];

                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];

                decimal inStk = _ds.Tables[0].AsEnumerable()
                                    .Sum(x => x.Field<decimal>("InStk"));
                decimal outStk = _ds.Tables[0].AsEnumerable()
                                    .Sum(x => x.Field<decimal>("outStk"));
                decimal bal = inStk - outStk;
                txtInStk.Text = inStk.ToString("####0");
                txtOutStk.Text = outStk.ToString("####0");
                txtBalance.Text = bal.ToString("####0");

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "Stock:UpdateByAudit"; p.prm_1 = txtBalance.Text;
                p.tran_id = _masterKey;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                CashMemeoNoUpdatedEventArgs ValuArgs = new CashMemeoNoUpdatedEventArgs(dwr.message);
                //SearchUpdated(this, ValuArgs);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
            this.Close();
        }
    }
}
