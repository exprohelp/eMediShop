using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.forms.Reconcilation
{
    public partial class HoldIdManagement : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; DataSet _ds = new DataSet(); string _trf_to = string.Empty;
        Font newFont = new Font("Arial", 9f, FontStyle.Bold);
        public HoldIdManagement()
        {
            InitializeComponent();
        }

        private void HoldIdManagement_Load(object sender, EventArgs e)
        {
            try
            {
                Rectangle rec = Screen.PrimaryScreen.WorkingArea;
                int size = (rec.Size.Width - this.Width) / 2;
                this.Location = new System.Drawing.Point(size, 165);
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "Pending_Sales"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/RetailReconciliation", p);
                _ds = dwr.result;
                dgSales.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void dgSales_CommandCellClick(object sender, EventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show("Do You confirm to delete Selected Recored ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgresult.ToString() == "Yes")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    decimal qty = Convert.ToDecimal(dgSales.CurrentRow.Cells[7].Value);
                    DataSet ds = new DataSet();
                    pm_SalesAction1 p = new pm_SalesAction1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Sales_Inv_No = dgSales.CurrentRow.Cells[0].Value.ToString();
                    p.master_key_id = dgSales.CurrentRow.Cells["master_key_id"].Value.ToString();
                    p.Sale_Trn_No = dgSales.CurrentRow.Cells["Sale_trn_No"].Value.ToString();
                    p.order_no = "N/A"; p.logic = "SalesInvoice";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/DeleteSalesEntry", p);
                    ds = dwr.result;
                   
                    DataRow dr = ds.Tables[0].Rows[0];
                    if (_result.Contains("Success"))
                    {
                        dgSales.Rows[dgSales.CurrentRow.Index].Delete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void radPageView1_Click(object sender, EventArgs e)
        {

        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                if (radPageView1.SelectedPage.Text == "Transfer")
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.prm_1 = "N/A"; p.prm_2 = "N/A";
                    p.prm_3 = "N/A"; p.Logic = "Transfer:UnResolved"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
                    _ds = dwr.result;
                    rgv_Transfer.DataSource = _ds.Tables[0];
                }
                else if (radPageView1.SelectedPage.Text == "Sales")
                {
                    pm_Audit_Queries p = new pm_Audit_Queries();
                    p.unit_id = GlobalUsage.Unit_id;p.logic = "Pending_Sales"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/RetailReconciliation", p);
                    _ds = dwr.result;
                    dgSales.DataSource = _ds.Tables[0];
                }
                else if (radPageView1.SelectedPage.Text == "Purchase")
                {
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "N/A"; p.logic = "Pending_Bills"; p.prm_1 = "-"; p.prm_2 = "N/A";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                    _ds = dwr.result;
                    rgv_PurchaseId.DataSource = _ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void MasterTemplate_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }

        private void RadGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "Transfer:TrfItemsInfo"; p.prm_1 = rgv_Transfer.CurrentRow.Cells["Transfer Id"].Value.ToString();
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

                _ds = dwr.result;
       
                rgv_trf_Info.DataSource = _ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        private void RadGridView_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string transfer_id = string.Empty; string qry = string.Empty;
                transfer_id = rgv_Transfer.CurrentRow.Cells["Transfer Id"].Value.ToString();
                if (Convert.ToInt16(rgv_Transfer.CurrentRow.Cells["nOs"].Value) == 0)
                {
                    qry = "delete from trf_items where trf_id='" + transfer_id + "';delete from trf_master where trf_id='" + transfer_id + "'";
                    //Config.QueryExecute(qry, "eMediShop");
                    //GlobalUsage.pharmacy_proxy.QueryExecute(qry, "eMediCentral");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.WaitCursor;
            }

        }

        private void RadGridView_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            //if(e.RowElement.RowInfo.Cells["NoS"].Value.ToString()=="0")
            //    e.RowElement.RowInfo.Cells["Delete"].ColumnInfo.e

        }

        private void RadGridView_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridHeaderCellElement || e.CellElement is GridGroupContentCellElement)
            {
                e.CellElement.Font = newFont;
                e.CellElement.ForeColor = Color.Blue;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
            }
        }

        private void RadGridView_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You Confirm To Delete (Y/N)", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        cm1 p = new cm1();
                        p.unit_id = GlobalUsage.Unit_id; p.prm_1 = e.Row.Cells[0].Value.ToString();
                        p.prm_2 = "N/A";
                        p.prm_3 = "N/A"; p.Logic = "DeleteHoldIds"; p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
                        DataSet ds = dwr.result;
                        if (ds.Tables[0].Rows.Count == 0)
                            e.Row.Delete();
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rgv_trf_Info_KeyUp(object sender, KeyEventArgs e)
        {
            string result = string.Empty; string msg = string.Empty; string trf_id = string.Empty; string trf_to = string.Empty;

        }

        private void rgv_PurchaseId_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Do You Confirm To Delete (Y/N)", "ExPro Help", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        pm_PurchaseQueries p = new pm_PurchaseQueries();
                        p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = e.Row.Cells[0].Value.ToString(); p.logic = "Delete_Hold_Bills"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
                        p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                        if (dwr.result.Tables[0].Rows.Count == 0)
                            e.Row.Delete();
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }

              
            }

        }

        private void dgSales_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show("Do You confirm to delete Selected Recored ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgresult.ToString() == "Yes")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    decimal qty = Convert.ToDecimal(dgSales.CurrentRow.Cells[7].Value);
                    DataSet ds = new DataSet();
                    pm_SalesAction1 p = new pm_SalesAction1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Sales_Inv_No = dgSales.CurrentRow.Cells[0].Value.ToString();
                    p.master_key_id = dgSales.CurrentRow.Cells["master_key_id"].Value.ToString();
                    p.Sale_Trn_No = dgSales.CurrentRow.Cells["Sale_trn_No"].Value.ToString();
                    p.order_no = "N/A"; p.logic = "SalesInvoice";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/DeleteSalesEntry", p);
                    ds = dwr.result;

                    DataRow dr = ds.Tables[0].Rows[0];
                    if (_result.Contains("Success") || _result.Contains(""))
                    {
                        dgSales.Rows[e.RowIndex].Delete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
