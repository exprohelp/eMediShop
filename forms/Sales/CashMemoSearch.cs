using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using eMediShop.Pharmacy;

namespace eMediShop
{
    public partial class CashMemoSearch : Telerik.WinControls.UI.RadForm
    {
       // SaleMaster frmSaleMaster = new SaleMaster();
        string _SearchId = "Auto Generate"; string _result = string.Empty;
        public event SearchCashMemoEventHandler SearchUpdated;
        string _CallFrom = string.Empty;
        public CashMemoSearch(string CallFrom)
        {
            InitializeComponent();
            _CallFrom = CallFrom;
            string[] r = CallFrom.Split(':');
            _CallFrom = r[0];
            this.Text = r[1];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 3)
                FillSearchResult(txtSearch.Text);
        }

        private void FillSearchResult(string searchString)
        {
            cm1 p = new cm1();
           p.unit_id = GlobalUsage.Unit_id;p.Logic = GlobalUsage.BillType;p.prm_1 = searchString;
            p.prm_2 = GlobalUsage.CounterID;p.prm_3 = _CallFrom;p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

            if (dwr.result.Tables[0].Rows.Count > 0)
            {
                rgv_info.DataSource = dwr.result.Tables[0];
            }

        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && (rgv_info.Rows.Count > 0))
            {
                rgv_info.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void CashMemoSearch_Load(object sender, EventArgs e)
        {
            FillSearchResult("N/A");
        }

        private void lv_CashMemoSearch_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void rgv_info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                Cursor.Current = Cursors.WaitCursor;
                _SearchId = rgv_info.CurrentRow.Cells["sale_inv_no"].Value.ToString();
                CashMemeoNoUpdatedEventArgs ValuArgs = new CashMemeoNoUpdatedEventArgs(_SearchId);
                SearchUpdated(this, ValuArgs);
                Cursor.Current = Cursors.Default;
                this.Close();

            }
        }
    }
}
