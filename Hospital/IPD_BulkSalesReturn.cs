using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Hospital
{
    public partial class IPD_BulkSalesReturn : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; string _jsonString = string.Empty; decimal _MaxValue;string _ipdNo = string.Empty;
        public IPD_BulkSalesReturn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _ipdNo = txtIPDNO.Text;
                pm_HospitalQueries p = new pm_HospitalQueries();
                p.unit_id = GlobalUsage.Unit_id;p.logic = "ForBulkSalesReturn";p.prm_1 = _ipdNo;p.prm_2 = cmbPayMode.Text;
                p.login_id=GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/HospitalQueries", p);
                rgv_ReturnInfo.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
            {
                _MaxValue = Convert.ToDecimal(e.Row.Cells["sale_qty"].Value);
            }
        }

        private void MasterTemplate_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
            {
                _MaxValue = Convert.ToDecimal(e.Row.Cells["sale_qty"].Value);

                if (Convert.ToDecimal(e.Row.Cells["Ret_Qty"].Value) > _MaxValue)
                {
                    RadMessageBox.Show("Only " + _MaxValue.ToString() + " Permitted For Return against This Key.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    e.Row.Cells["Ret_Qty"].Value = 0;
                }
            }
        }

        private void MasterTemplate_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
            {
                if (Convert.ToDecimal(e.Row.Cells["Ret_Qty"].Value) < 0 || Convert.ToDecimal(e.Row.Cells["Ret_Qty"].Value) > _MaxValue)
                {
                    RadMessageBox.Show("Only 1 -" + _MaxValue.ToString() + " Permitted For Return against This Key.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    e.Row.Cells["Ret_Qty"].Value = 0;
                }
            }
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {

            _MaxValue = Convert.ToDecimal(e.RowElement.RowInfo.Cells["sale_qty"].Value);
        }

        private void txtIPDNO_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSubmit.PerformClick();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm To Return Process ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var rows = rgv_ReturnInfo.Rows.AsEnumerable().Where(x => Convert.ToInt16(x.Cells["Ret_Qty"].Value) > 0);
                    DataTable dt = new DataTable();
                    dt.Columns.Add("old_SaleInvno", typeof(string));
                    dt.Columns.Add("item_id", typeof(string));
                    dt.Columns.Add("master_key_id", typeof(string));
                    dt.Columns.Add("RetQty", typeof(int));
                    foreach (GridViewRowInfo grv in rows)
                    {
                        DataRow dr = dt.NewRow();
                        
                        dr["old_SaleInvno"] = grv.Cells["sale_inv_no"].Value.ToString();
                        dr["item_id"] = grv.Cells["item_id"].Value.ToString();
                        dr["master_key_id"] = grv.Cells["master_key_id"].Value.ToString();
                        dr["RetQty"] = Convert.ToInt16(grv.Cells["Ret_Qty"].Value);
                        dt.Rows.Add(dr);
                    }
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    pm_sales p = new pm_sales();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.computerName = GlobalUsage.computerName; p.searchkey = _ipdNo; p.logic = "ByIPDNo";
                    p.counter_id = GlobalUsage.CounterID; p.login_id = GlobalUsage.Login_id;
                    p.Pay_Mode = cmbPayMode.Text;
                    p.ds = ds;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailSalesReturn", p);
                    _result = dwr.message;
                   
                    RadMessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    txtIPDNO.Text = ""; btnSubmit.PerformClick();
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        public void IterateAllRows(IEnumerable<GridViewRowInfo> rowsCollection)
        {
            foreach (GridViewDataRowInfo row in rowsCollection)
            {
                if (row.HasChildRows())
                {
                    IterateAllRows(row.ChildRows);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rgv_ReturnInfo_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name.ToString() == "Ret_Qty")
            {
                ((GridViewDecimalColumn)e.Column).Maximum = _MaxValue;
            }
        }

        private void rgv_ReturnInfo_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            //GridSpinEditor spinEditor = this.rgv_ReturnInfo.ActiveEditor as GridSpinEditor;
            //if (spinEditor != null)
            //{
            //    if (spinEditor.Value == null)
            //    {
            //        spinEditor.Value = 0;
            //        spinEditor.MaxValue = (decimal)e.Row.Cells[8].Value;
            //    }
            //}
        }

        private void IPD_BulkSalesReturn_Load(object sender, EventArgs e)
        {
            cmbPayMode.SelectedIndex = 1;
        }
    }
}
