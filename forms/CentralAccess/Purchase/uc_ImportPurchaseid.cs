using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ExPro.Client;
using ExPro.Server;
using System.Threading;
using eMediShop.Pharmacy;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class uc_ImportPurchaseid : UserControl
    {

        string _purchase_id = string.Empty; DataSet _ds = new DataSet(); string _result = string.Empty; DataSet _csData = new DataSet();

        public uc_ImportPurchaseid()
        {
            InitializeComponent();
        }

        private void uc_ImportTransferId_Load(object sender, EventArgs e)
        {

        }

        protected void Preview(string id_number)
        {
            rgv_items.DataSource = null;
            try
            {
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = id_number; p.logic = "NotTakenInStock_Info"; p.prm_1 = "N/A"; p.prm_2 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _csData = dwr.result;
                if (_csData.Tables.Count == 4)
                {
                    rgv_items.DataSource = _csData.Tables[0];
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        protected string InsertIntoRcptItems(string id_number)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchasePosting p = new pm_PurchasePosting();
                p.unit_id = GlobalUsage.Unit_id;p.purch_id = id_number;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseTakeInStock", p);
                if (dwr.message.Contains("Success"))
                { rgv_items.DataSource = new string[] { }; rgv_info.CurrentRow.Delete(); }
            }
            catch (Exception ex)
            {
                _result = ex.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            return _result;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm To Import Purchase Id No. " + _purchase_id + "  In Stocks", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    btnConfirm.Visible = false;
                    InsertIntoRcptItems(_purchase_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_RefreshIds_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btn_RefreshIds.Enabled = false;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "N/A"; p.logic = "NotTakenInStock"; p.prm_1 = "N/A"; p.prm_2 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                rgv_info.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                btn_RefreshIds.Enabled = true;
                Cursor.Current = Cursors.Default;
            }

        }




        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Flag"].Value != null)
            {
                if (e.RowElement.RowInfo.Cells["Flag"].Value.ToString() == "N")
                {
                    e.RowElement.ForeColor = Color.Green;
                    if (btnConfirm.Visible == false)
                        btnConfirm.Visible = true;
                }
                else
                    e.RowElement.ForeColor = Color.Blue;
            }
        }


        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btn_RefreshIds.Enabled = false;
                _purchase_id = rgv_info.CurrentRow.Cells["purchase_id"].Value.ToString();
                lblTrfId.Text = "Transfer Id : " + _purchase_id;

                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = _purchase_id; p.logic = "NotTakenInStock_Info"; p.prm_1 = "N/A"; p.prm_2 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);


                rgv_items.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                btn_RefreshIds.Enabled = true;
                Cursor.Current = Cursors.Default;
            }

        }
    }//Second Last
}
