using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace eMediShop.forms.Product
{
    public partial class ucMarkLocal : UserControl
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty;string _OldValue = string.Empty;
        DataTable _dtAction = new DataTable();
        public ucMarkLocal()
        {
            InitializeComponent();

            _dtAction.Columns.Add("action_flag", typeof(string));
            _dtAction.Rows.Add("L");
            _dtAction.Rows.Add("N");
            _dtAction.Rows.Add("X");
            _dtAction.Rows.Add("W");
        }
        private void ucMarkLocal_Load(object sender, EventArgs e)
        {

        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            cm1 p = new cm1();
            p.Logic = "New Product List"; p.prm_1 = dtFrom.Value.ToString("yyyy/MM/dd"); p.item_id = "New";
            p.prm_2 = dtpTo.Value.ToString("yyyy/MM/dd"); p.prm_3 = "-";
            p.login_id = GlobalUsage.Login_id; p.unit_id = GlobalUsage.Unit_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);

            _ds = dwr.result ;
            try
            {

                if (_ds.Tables[0].Rows.Count > 0)
                {
                    rgv_info.DataSource = _ds.Tables[0];
                    Telerik.WinControls.UI.GridViewComboBoxColumn reportsColumn = ((Telerik.WinControls.UI.GridViewComboBoxColumn)this.rgv_info.Columns["action_flag"]);
                    reportsColumn.ValueMember = "action_flag";
                    reportsColumn.DisplayMember = "action_flag";
                    reportsColumn.DataSource = _dtAction;
                    reportsColumn.Width = 50;
                    reportsColumn.AllowFiltering = false;
                    btn_Print.Visible = true;
                    btnSummary.Visible = true;
                }
                else
                {
                    btn_Print.Visible = false;
                    btnSummary.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            cm1 p = new cm1();
            p.Logic = "New Product List"; p.prm_1 = dtFrom.Value.ToString("yyyy/MM/dd"); p.item_id = "N/A";
            p.prm_2 = dtpTo.Value.ToString("yyyy/MM/dd"); p.prm_3 = "-";
            p.login_id = GlobalUsage.Login_id; p.unit_id = GlobalUsage.Unit_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
            _ds = dwr.result;
            if (_ds.Tables[0].Rows.Count > 0)
            {
                string period = dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtpTo.Value.ToString("dd-MM-yyyy");
                CrystalReportsPharmacy.eMediShop.NewItemList rpt = new CrystalReportsPharmacy.eMediShop.NewItemList();
                rpt.Database.Tables["NewProducts"].SetDataSource(_ds.Tables[0]);
                rpt.SetParameterValue("Unit_name", GlobalUsage.UnitName);
                rpt.SetParameterValue("Address", GlobalUsage.UnitAddress);
                rpt.SetParameterValue("Period", period);
                Printing.Laser.exportTopdf(rpt, "Detail_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf");
                rpt.PrintToPrinter(1, false, 1, 0);
            }
            else { MessageBox.Show("Record Not Found"); }
            Cursor.Current = Cursors.Default;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            cm1 p = new cm1();
            p.Logic = "New Product To Transfer"; p.prm_1 = dtFrom.Value.ToString("yyyy/MM/dd"); p.item_id = "N/A";
            p.prm_2 = dtpTo.Value.ToString("yyyy/MM/dd"); p.prm_3 = "-";
            p.login_id = GlobalUsage.Login_id; p.unit_id = GlobalUsage.Unit_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
            _ds = dwr.result;
            if (_ds.Tables[0].Rows.Count > 0)
            {
                string period = dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtpTo.Value.ToString("dd-MM-yyyy");
                CrystalReportsPharmacy.eMediShop.NewItemList rpt = new CrystalReportsPharmacy.eMediShop.NewItemList();
                rpt.Database.Tables["NewProducts"].SetDataSource(_ds.Tables[0]);
                rpt.SetParameterValue("Unit_name", GlobalUsage.UnitName);
                rpt.SetParameterValue("Address", GlobalUsage.UnitAddress);
                rpt.SetParameterValue("Period", period);
                Printing.Laser.exportTopdf(rpt, "Summary_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf");
                rpt.PrintToPrinter(1, false, 1, 0);
            }
            else { MessageBox.Show("Record Not Found"); }
            Cursor.Current = Cursors.Default;
        }

       

        private void rgv_info_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            _OldValue = e.Row.Cells["action_flag"].Value.ToString();
        }

        private void rgv_info_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Row.Cells["action_flag"].Value != null && e.Row.Cells["action_flag"].Value.ToString() != _OldValue)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    
                    string _result = string.Empty;
                    prm_newProduct p = new prm_newProduct();
                    p.logic = "Update"; p.sale_inv_no = rgv_info.CurrentRow.Cells["auto_id"].Value.ToString();
                    p.item_id = "-"; p.item_name = "-"; p.qty = 0; p.order_no = "-"; p.login_id = GlobalUsage.Login_id;
                    p.action_flag = rgv_info.CurrentRow.Cells["action_flag"].Value.ToString();
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);

                    if (p.action_flag == "W" && btnConfirm.Visible == false)
                        btnConfirm.Visible = true;

                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Do You Confirm ?", "ExPro Help", MessageBoxButtons.YesNo);
            if(res==DialogResult.Yes)
            { 
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string _result = string.Empty;
                prm_newProduct p = new prm_newProduct();
                p.logic = "Confirm"; p.sale_inv_no ="-";p.unit_id= GlobalUsage.Unit_id;
                    p.item_id = "-"; p.item_name = "-"; p.qty = 0; p.order_no = "-"; p.login_id = GlobalUsage.Login_id;
                p.action_flag = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            }
        }

        private void rgv_info_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["action_flag"].Value.ToString() == "W")
                btnConfirm.Visible = true;
        }
    }
}
