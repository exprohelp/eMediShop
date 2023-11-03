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

namespace eMediShop.forms.TransferIds
{
    public partial class uc_ImportTransferId : UserControl
    {
        int _Match = 0;
        int _TotalRecord = 0;
        string _TransferId = string.Empty; DataSet _ds = new DataSet(); string _result = string.Empty; DataSet _csData = new DataSet();

        public uc_ImportTransferId()
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
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "Receive_ID_Info";p.tran_id= rgv_info.CurrentRow.Cells["Transfer Id"].Value.ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);

                _csData = dwr.result;
                if (_csData.Tables.Count == 1)
                {
                    rgv_items.DataSource = _csData.Tables[0];
                    if (rgv_items.RowCount == _TotalRecord)
                        btnConfirm.Enabled = true;
                    else
                        btnConfirm.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You Confirm To Import Transfer Id No. " + _TransferId + "  In Stocks", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    btnConfirm.Enabled = false;
                    pm_Transfer p = new pm_Transfer();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.transfer_id = rgv_info.CurrentRow.Cells["Transfer Id"].Value.ToString();
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ReceiveTrfIdInStock", p);
                    _result = dwr.message;
                    MessageBox.Show("Posted On Voucher No. : " + _result, "ExPro Help", MessageBoxButtons.OK);
                    rgv_items.DataSource = new string[] { }; ;
                    rgv_info.CurrentRow.Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK);
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
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "GetMyTrfIds";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                if(dwr.message.Contains("Success"))
                    rgv_info.DataSource = dwr.result.Tables[0];
                else
                    rgv_info.DataSource =new string[] { };

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

        private void MasterTemplate_SelectionChanged(object sender, EventArgs e)
        {
            if (rgv_info.CurrentRow.Cells["Transfer Id"].Value != null)
            {
                lblTrfId.Text = "Transfer Id : " + rgv_info.CurrentRow.Cells["Transfer Id"].Value.ToString();
                lblDate.Text = "Transfer Date : " + Convert.ToDateTime(rgv_info.CurrentRow.Cells["Trf Date"].Value).ToString("dd-MM-yyyy");
            }
        }

        private void rgv_info_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _TransferId = rgv_info.CurrentRow.Cells["Transfer Id"].Value.ToString();
                _TotalRecord = Convert.ToInt16(rgv_info.CurrentRow.Cells["NoS"].Value);
                Preview(_TransferId);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.WaitCursor; }
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Import_Flag"].Value != null)
            {
                //if (Convert.ToInt32(e.RowElement.RowInfo.Cells["Qty[R]"].Value) == Convert.ToInt32(e.RowElement.RowInfo.Cells["Qty"].Value))
                //    e.RowElement.ForeColor = Color.Green;
                //else
                e.RowElement.ForeColor = Color.Blue;
            }
        }

        private void rbtn_Verify_Click(object sender, EventArgs e)
        {
         
        }


    }//Second Last
}
