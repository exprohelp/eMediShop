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

namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class BulkPOReceiving : UserControl
    {
        string _orderNO = string.Empty; int _oldValue = 0;
        public BulkPOReceiving()
        {
            InitializeComponent();
        }
        
        private void rgv_info_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
                _oldValue = Convert.ToInt32(e.Row.Cells["Rcpt_Qty"].Value);
        }

        private void rgv_info_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int _newValue = Convert.ToInt32(e.Row.Cells["Rcpt_Qty"].Value);
            e.Row.Cells["balance"].Value= Convert.ToInt32(e.Row.Cells["balance"].Value)- _newValue;
          
        }

       
        private void LoadInfo()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                eMediShop.poSearch pm = new poSearch();
                pm.unit_id = GlobalUsage.Unit_id; pm.po_number = "-"; pm.Logic = "Bulk:OpenOrderInfo"; pm.Prm_1 = "-"; pm.Prm_2 = "-"; pm.LoginId = pm.LoginId;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ManualOpenOrderList", pm);

                if (dwr.message.Contains("Success"))
                {
                    rgv_info.DataSource = new string[] { };
                    rgv_info.DataSource = dwr.result.Tables[0];
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default;}
        }

        private void btn_LoadOrders_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void btn_Complete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm to Complete(Y/N) ? ", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("autoId", typeof(string));
                    dt.Columns.Add("order_no", typeof(string));
                    dt.Columns.Add("item_id", typeof(string));
                    dt.Columns.Add("rcpt_qty", typeof(string));
                    dt.Columns.Add("remarks", typeof(string));
                    dt.Columns.Add("prm1", typeof(string));
                    dt.Columns.Add("prm2", typeof(string));
                    foreach (DataRow dr in ((DataTable)rgv_info.DataSource).Rows)
                    {
                        if(Convert.ToInt32(dr["rcpt_qty"])>0)
                        dt.Rows.Add(dr["auto_id"].ToString(), dr["order_no"], dr["item_id"], dr["rcpt_qty"].ToString(),"-","-","-");
                    }

                    eMediShop.opoVerifiy pm = new opoVerifiy();
                    pm.unit_id = GlobalUsage.Unit_id; pm.order_no = "-"; pm.tblInfo = dt; pm.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderReceiving", pm);

                    if (dwr.message.Contains("Success"))
                    {
                        RadMessageBox.Show("Successfully Updated.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        //rgv_info.DataSource = new string[] { };
                    }
                }

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
