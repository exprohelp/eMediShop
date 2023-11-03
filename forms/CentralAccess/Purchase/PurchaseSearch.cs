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
using Telerik.WinControls;

namespace eMediShop
{
    public partial class PurchaseSearch : Telerik.WinControls.UI.RadForm
    {
        Purchase_Entry frmPurch_Entry = new Purchase_Entry(); string _result = string.Empty;
        DataTable dt = new DataTable(); string _Logic = string.Empty;
        DataSet ds = new DataSet();
        string pSearchId = "Auto Generate"; string _CallFrom = string.Empty;
        public event SearchUpdateEventHandler SearchUpdated;
        public PurchaseSearch(string CallFrom)
        {
            InitializeComponent();
            _CallFrom = CallFrom;
        }



        private void PurchaseSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void PurchaseSearch_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (_CallFrom == "CreditNote")
                    _Logic = "CN_Pending";
                else if (_CallFrom == "DebitNote")
                    _Logic = "DN_Pending";
                else if (_CallFrom=="Challan")
                    _Logic = "PENDING_Challan";
                else
                    _Logic = "PENDING_BILLS";
             
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = _Logic; p.prm_1 = "ALL"; p.prm_2 = "-"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                ds = dwr.result;

                rgvInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape))
            {
                if (rgvInfo.Rows.Count > 0)
                    pSearchId = rgvInfo.CurrentRow.Cells[0].Value.ToString();
                if (Convert.ToInt32(rgvInfo.CurrentRow.Cells["NoS"].Value) > 0)
                {
                    SearchUpdatedEventArgs valueArgs = new SearchUpdatedEventArgs(pSearchId);
                    SearchUpdated(this, valueArgs);
                    this.Close();
                }
                //else
                //{
                //    RadMessageBox.Show("No Product In This Purchasse ID.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                //    return;
                //}
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
