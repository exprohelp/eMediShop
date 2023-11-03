using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eMediShop.Pharmacy;
namespace eMediShop
{
    public partial class IsCorrectPurchase : Telerik.WinControls.UI.RadForm
    {

        string _ItemId = "";
        bool _chkOpt = false;
        DataSet _ds = new DataSet();
        DateTime _dtfrom = new DateTime();
        DateTime _dtTo = new DateTime();
        public IsCorrectPurchase()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            _chkOpt = cb_option.Checked;
            _dtfrom = dtpfrom.Value;
            _dtTo = dtpTo.Value;
            if (!backgroundWorker1.IsBusy)
            {
                progressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
            else
                MessageBox.Show("Wait It's Processing..");
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id; p.dtfrom = _dtfrom.ToString("yyyyMMdd");
                p.dtTo = _dtTo.ToString("yyyyMMdd"); p.orderFormonth = Convert.ToDecimal(txtmth.Text);
                if (_chkOpt)
                    p.logic = "Wrong-Purchase";
                else
                    p.logic = "All";

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseProductChecking", p);
                _ds = dwr.result;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (_ds.Tables.Count > 0)
                {
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        rgv_info.DataSource = _ds.Tables[0];
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            progressBar1.Visible = false;
        }
        private void OpenReconsile_Click(object sender, EventArgs e)
        {
            string Item_Id = ((Control)sender).Name;

        }
        private void dgCheckList_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void IsCorrectPurchase_Load(object sender, EventArgs e)
        {
            dtpfrom.Value = DateTime.Today; dtpTo.Value = DateTime.Today;
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void rgv_info_KeyDown(object sender, KeyEventArgs e)
        {
            _ItemId = rgv_info.CurrentRow.Cells["Item Id"].Value.ToString();
            string _ItemName = rgv_info.CurrentRow.Cells["Name of Product"].Value.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                PurchCheckListReconsile obj = new PurchCheckListReconsile(_ItemId, _ItemName);
                obj.Owner = this;
                obj.Show();
            }

        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            e.RowElement.ForeColor = Color.Green;

            if (Convert.ToDecimal(e.RowElement.RowInfo.Cells["Purch[Q]"].Value) > 1 && Convert.ToDecimal(e.RowElement.RowInfo.Cells["lp_stk_qty"].Value) == Convert.ToDecimal(e.RowElement.RowInfo.Cells["Purch[Q]"].Value) && Convert.ToDecimal(e.RowElement.RowInfo.Cells["Sales Avg [C]"].Value) == 0)
                e.RowElement.ForeColor = Color.Red;
            //    else if (Convert.ToDecimal(e.RowElement.RowInfo.Cells[""].Value) > Convert.ToDecimal(e.RowElement.RowInfo.Cells["adq_qty"].Value))
            //        e.RowElement.ForeColor = Color.Red;
        }

        private void btnXL_Click(object sender, EventArgs e)
        {

            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();

                string fileName = string.Empty;
                fileName = f.SelectedPath + "\\WrongPurchase.xls";
                Cursor.Current = Cursors.WaitCursor;
                Telerik.WinControls.UI.Export.ExportToExcelML exporter = new Telerik.WinControls.UI.Export.ExportToExcelML(rgv_info);
                exporter.ExportVisualSettings = true;
                //exporter.SheetMaxRows = ExcelMaxRows._1048576;
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

    }
}
