using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace eMediShop.forms.CentralAccess.Stock
{
    public partial class uc_TransferRegister : UserControl
    {
        string _result = string.Empty; DataSet _ds = new DataSet(); string _trfid = string.Empty;
        public uc_TransferRegister()
        {
            InitializeComponent();
        }

        private void uc_TransferRegister_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;

        }

        private void dtpFrom_Leave(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; ; p.Logic = "TrfRegister";p.dtFrom = dtpFrom.Value.ToString("yyyy/MM/dd");
                p.dtTo = dtpTo.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                if (dwr.message.Contains("Success"))
                    rgv_master.DataSource = dwr.result.Tables[0];
                else
                    rgv_master.DataSource = new string[] { };

              

                GridViewTemplate childTemplate = rgv_master.Templates[0];
                childTemplate.HierarchyDataProvider = new GridViewEventDataProvider(childTemplate);
                rgv_master.Templates[0].AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {

            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_RowSourceNeeded(object sender, Telerik.WinControls.UI.GridViewRowSourceNeededEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                _result = DateTime.Now.Second.ToString();
                _trfid = e.ParentRow.Cells["Transfer Id"].Value.ToString();
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.tran_id = _trfid; p.Logic = "Trfid_info";
                p.dtFrom = dtpFrom.Value.ToString("yyyy/MM/dd"); p.dtTo = dtpTo.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);

                _ds = dwr.result;
                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        GridViewRowInfo row = e.Template.Rows.NewRow();
                        row.Cells["Item Id"].Value = dr["item_id"].ToString();
                        row.Cells["Master Key Id"].Value = dr["master_key_id"].ToString();
                        row.Cells["Name of Product"].Value = dr["item_name"].ToString();
                        row.Cells["Batch No"].Value = dr["batch_no"].ToString();
                        row.Cells["Pack [T]"].Value = dr["pack_type"].ToString();
                        row.Cells["Pack [Q]"].Value = Convert.ToDecimal(dr["pack_qty"].ToString());
                        row.Cells["Expiry"].Value = Convert.ToDateTime(dr["exp_date"]);
                        row.Cells["MRP"].Value = Convert.ToDecimal(dr["mrp"]);
                        row.Cells["upr"].Value = Convert.ToDecimal(dr["upr"]);
                        row.Cells["Qty"].Value = Convert.ToDecimal(dr["Qty"]);
                        e.SourceCollection.Add(row);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Is Printer Ready (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ds.Tables.Clear();
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.trf_tounit = rgv_master.CurrentRow.Cells["Transfer To"].Value.ToString();
                p.tran_id = _trfid; p.Logic = "TransferId:TransferPaper";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
                _ds = dwr.result;

                Printing.Laser.StockTransfer_Form(_ds, _trfid, "Print");
            }
        }

        private void btn_sheet_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Is Printer Ready (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ds.Tables.Clear();
                Printing.Laser.InternalSheet(_trfid, "Print");
            }
        }

        private void rgv_master_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Flag"] != null)
            {
                if (e.RowElement.RowInfo.Cells["Flag"].Value.ToString() == "Y")
                    e.RowElement.ForeColor = Color.Green;
                else
                    e.RowElement.ForeColor = Color.Red;
            }
        }

        private void rgv_master_Click(object sender, EventArgs e)
        {
            _trfid = rgv_master.CurrentRow.Cells["Transfer Id"].Value.ToString();
        }
    }
}
