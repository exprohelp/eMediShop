using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;
using Newtonsoft.Json;

namespace eMediShop.forms.CentralAccess.RCM
{
    public partial class uc_GenOnlineOrderPO : UserControl
    {

        string unit_id = string.Empty;
        string _order_no = string.Empty;
        int _index = -1;
        string _result = string.Empty;
        public uc_GenOnlineOrderPO(string sh_code)
        {
            unit_id = sh_code;
            InitializeComponent();
        }
        private void btnExcelConvert_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "PO_OnlineOrder_" + System.DateTime.Now.ToString("ddMMyyyy") + ".xlsx";
                dialog.Filter = "xls files (.xls)|*.xls|All files (.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.UI.Export.ExportToExcelML exporter = new Telerik.WinControls.UI.Export.ExportToExcelML(this.dgPO);
                    exporter.ExportVisualSettings = true;
                    exporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void uc_GenOnlineOrderPO_Load(object sender, EventArgs e)
        {

        }

        private void UpdateItemByNewMed(object sender, CashMemeoNoUpdatedEventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string old_itemid = e.CASHMEMONO.Split('|')[0];
                string new_itemid = e.CASHMEMONO.Split('|')[1];
                string new_itemname = e.CASHMEMONO.Split('|')[2];
                string qry = "update custOrderInfo set item_id='" + new_itemid + "' where order_no='" + _order_no + "' and item_id='" + old_itemid + "' ";
                string result = GlobalUsage.pharmacy_proxy.QueryExecute(qry, "customer_data");
                //string result = "Success";
                if (result.Contains("Success"))
                {
                    DataSet dsStock = GlobalUsage.pharmacy_proxy.OnlineOrder_Queries(out _result, unit_id, "", new_itemid, "", 0, "PO_GET_STOCK");
                    if (dsStock.Tables.Count > 0 && dsStock.Tables[0].Rows.Count > 0)
                    {
                        int StkQty = Convert.ToInt32(dsStock.Tables[0].Rows[0]["InStock"]);

                        dgPO.Rows[_index].Cells[4].Value = StkQty;
                        dgPO.Rows[_index].Cells[5].Value = Math.Abs(StkQty - Convert.ToInt32(dgPO.Rows[_index].Cells[3].Value));
                    }
                    else
                    {
                        dgPO.Rows[_index].Cells[4].Value = 0;
                        dgPO.Rows[_index].Cells[5].Value = Convert.ToInt32(dgPO.Rows[_index].Cells[3].Value);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void dgPO_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;
                if(chkGenerate.Checked==true)
                    p.Logic = "GenerateUrgent";
                else
                    p.Logic = "csdOrderStatus";
                p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                if (p.Logic == "csdOrderStatus")
                    dgPO.DataSource = dwr.result.Tables[0];
                else
                {
                    chkGenerate.Text = "Generated";
                    chkGenerate.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
