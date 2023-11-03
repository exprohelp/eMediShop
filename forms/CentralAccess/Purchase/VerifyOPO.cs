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
    public partial class VerifyOPO : UserControl
    {
        string _orderNO = string.Empty; int _oldValue = 0;
        public VerifyOPO()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                eMediShop.poSearch pm = new poSearch();
                pm.unit_id = GlobalUsage.Unit_id; pm.po_number = _orderNO; pm.Logic = "OOM:verfiyList";pm.Prm_1 = "-";pm.Prm_2 = "-";pm.SearchKey = "-";pm.LoginId = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ManualOpenOrderList", pm);

                if (dwr.message.Contains("Success"))
                {
                    rgv_orders.DataSource = dwr.result.Tables[0];
                }
                else
                {
                    rgv_orders.DataSource = new string[] { };
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm to Complete(Y/N) ? ", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    DataTable dt=new DataTable();
                    dt.Columns.Add("item_id", typeof(string));
                    dt.Columns.Add("item_name", typeof(string));
                    dt.Columns.Add("pack_type", typeof(string));
                    dt.Columns.Add("pack_qty", typeof(int));
                    dt.Columns.Add("master_key_id", typeof(string));
                    dt.Columns.Add("qty", typeof(int));

                    foreach (DataRow dr in ((DataTable)rgv_info.DataSource).Rows)
                    {
                        dt.Rows.Add("-",dr["item_name"],"-",0,"-", dr["rcpt_qty"]);
                    }

                    eMediShop.opoVerifiy pm = new opoVerifiy();
                    pm.unit_id = GlobalUsage.Unit_id; pm.order_no = _orderNO; pm.tblInfo = dt; pm.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/opoVerify", pm);
                    
                    if (dwr.message.Contains("Success"))
                    {
                        RadMessageBox.Show("Successfully Updated.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        rgv_info.DataSource = new string[] { };
                        rgv_orders.Rows[rgv_orders.CurrentRow.Index].Delete();
                    }
                }

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _orderNO = e.Row.Cells["order_no"].Value.ToString();
            rgb_info.Text = _orderNO + "{" + e.Row.Cells["order_info"].Value.ToString() + "}";
            LoadInfo(_orderNO);
        }

        private void LoadInfo(string orderNo)
        {
            try
            {
                eMediShop.poSearch pm = new poSearch();
                pm.unit_id = GlobalUsage.Unit_id;pm.po_number = _orderNO;pm.Logic = "OOM:verfiyInfo";pm.Prm_1 = "-";pm.Prm_2 = "-";pm.LoginId = pm.LoginId;
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
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
                _oldValue = (int)e.Row.Cells["Rcpt_Qty"].Value;
        }

        private void rgv_info_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }
    }
}
