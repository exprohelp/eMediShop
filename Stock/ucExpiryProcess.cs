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
using Telerik.WinControls;

namespace eMediShop.forms.Stock
{
    public partial class ucExpiryProcess : UserControl
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty; string _trf_type = string.Empty;
        string _TrfId = string.Empty;
        string _CallFrom = "N/A";
        public ucExpiryProcess(string CallFrom)
        {
            _CallFrom = CallFrom;
            InitializeComponent();
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            DataSet dsCentral = new DataSet();
            _result = DateTime.Now.Second.ToString();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Transfer p = new pm_Transfer();
                p.transfer_id = _TrfId;
                p.unit_id = GlobalUsage.Unit_id;p.logic = "Check:" + _CallFrom; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockExpiryProcessMethods", p);
                dsCentral = dwr.result;
                rgv_info.DataSource = dsCentral.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void ucExpiryReconcile_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            if (_CallFrom == "LP-EXPIRY") // && GlobalUsage.District.ToUpper() != "LUCKNOW"
            {
                _trf_type = "LP-EXPIRY";
                this.BackColor = Color.FromArgb(192, 0, 0);
            }
            else if (_CallFrom == "OT-EXPIRY") // || GlobalUsage.District.ToUpper() == "LUCKNOW"
            {
                this.BackColor = Color.Maroon; _trf_type = "OT-EXPIRY";
            }
            else if (_CallFrom == "LooseExpiry")
            {
                this.BackColor = Color.Maroon; _trf_type = "LO-EXPIRY";
            }
            pm_Transfer p = new pm_Transfer();
            p.transfer_id = _TrfId;
            p.unit_id = GlobalUsage.Unit_id; p.logic = "PD:" + _CallFrom; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockExpiryProcessMethods", p);
            _ds = dwr.result;
            fill_ids(_ds.Tables[0]);
        }

        private void fill_ids(DataTable dt)
        {
            try
            {
                cmbPendingIds.Items.Clear();
                cmbPendingIds.Items.AddRange(Config.FillCombo(dt));
                cmbPendingIds.SelectedIndex = 1;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
        private void btn_Process_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Transfer p = new pm_Transfer();
                p.transfer_id = _TrfId;
                p.unit_id = GlobalUsage.Unit_id; p.logic = "Process:" + _CallFrom; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockExpiryProcessMethods", p);
                ds = dwr.result;
                if (ds.Tables[1].Rows.Count > 0)
                {
                    fill_ids(ds.Tables[1]);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do You Confirm (Y/N)", "ExPro Help.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    btn_Finish.Enabled = false;
                    pm_Transfer p = new pm_Transfer();
                    p.unit_id = GlobalUsage.Unit_id;p.transaction_id = _TrfId;p.tran_type = _trf_type;p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranPosting", p);
                    RadMessageBox.Show("Successfully Completed with Voucher No. " + dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    rgv_info.DataSource = new string[] { };
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }

        }





        private void cmbPendingIds_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buttonManagement();

        }

        private void cmbPendingIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonManagement();

        }

        private void buttonManagement()
        {
            _TrfId = ((AddValue)cmbPendingIds.SelectedItem).Value.ToString();
            if (_TrfId.ToUpper() == "SELECT")
            {
                btnStock.Enabled = false;
                btn_Process.Enabled = false;
                btnFillrecords.Visible = false;
                btn_Finish.Enabled = false;
            }
            else if (_TrfId.ToUpper() == "NEW")
            {
                btnStock.Enabled = true;
                btn_Process.Enabled = true;
                btn_Finish.Enabled = false;
                btnFillrecords.Visible = false;
            }
            else if (_TrfId.Length > 10)
            {
                btnStock.Enabled = false;
                btn_Process.Enabled = false;
                btn_Finish.Enabled = true;
                cmbPendingIds.Enabled = false;
                btnFillrecords.Visible = true;

            }
        }

        private void btnFillrecords_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Transfer p = new pm_Transfer();
                p.transfer_id = _TrfId;
                p.unit_id = GlobalUsage.Unit_id; p.logic = "getTranInfo"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockExpiryProcessMethods", p);
                ds = dwr.result;
                rgv_info.DataSource = ds.Tables[0];

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }
    }
}
