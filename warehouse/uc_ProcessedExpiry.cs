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
using Telerik.WinControls;

namespace eMediShop.warehouse
{
    public partial class uc_ProcessedExpiry : UserControl
    {
        string _msterGrNo = string.Empty;
        DataSet _dsInfo = new DataSet();
        string _gr_no = string.Empty;
        string _result = ""; string _trfID = string.Empty; DataSet _ds = new DataSet(); string _vendCode = string.Empty;
        public uc_ProcessedExpiry()
        {
            InitializeComponent();
            FillMasterGRNos();
        }

        private void uc_Un_ProcessedExpiry_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Teal;
        }

        #region Private Methods
        private void FillMasterGRNos()
        {
            try
            {
                _result = DateTime.Now.Millisecond.ToString();
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "EGR:MasterGrNos"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                _ds = dwr.result;
                rgv_ids.DataSource = _ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        #endregion
        private void lv_ids_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }


        private void FillListView(string mastergrnos)
        {
            gb_Unit_Info.Enabled = true;
            _result = DateTime.Now.Millisecond.ToString();
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id;p.Logic = "EGR:MasterGrNo-Detail";p.prm_1 = mastergrnos;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
            _ds = dwr.result;
            if (_ds.Tables[0].Rows.Count > 0)
            {
                if (_msterGrNo == "-")
                {
                    rgv_processed.Visible = false;
                    rgv_info.Visible = true;
                    rgv_info.Size = new System.Drawing.Size(772, 409);
                    rgv_info.DataSource = _ds.Tables[0];
                    Grbox.Visible = false;
                }
                else
                {
                    rgv_processed.Visible = true;
                    rgv_info.Visible = false;
                    rgv_processed.Size = new System.Drawing.Size(772, 449);
                    gb_FinishProcess.Visible = false;
                    rgv_processed.DataSource = _ds.Tables[0];
                    Grbox.Visible = true;
                }
            }
            #region Fill units
            cmbUnits.Items.Clear();
            cmbUnits.Items.Add(new ExproComboBox("Select", "Select"));
            cmbUnits.Enabled = true;
            foreach (DataRow dr in _ds.Tables[1].Rows)
            {
                cmbUnits.Items.Add(new ExproComboBox(dr["sh_name"].ToString(), dr["sh_name"].ToString()));
            }
            cmbUnits.SelectedIndex = 0;
            #endregion
        }

        private void btnCompleteExpiry_Click(object sender, EventArgs e)
        {
            btnCompleteExpiry.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;p.comp_id = GlobalUsage.Comp_id;
                p.dtFrom = DateTime.Now.ToString("yyyy/MM/dd");p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/Expiry_WS_CompleteProcess", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //string qry = "select emp_code,emp_name+' ['+emp_code+'] '+designation emp_name from EmpDetail where (emp_code='" + txtSearch.Text.Trim() + "' or emp_name like '" + txtSearch.Text.Trim() + "%') and res_date is null ";
            //DataSet ds = GlobalUsage.pwcf.GetQueryResult_JSON(qry);
            //cmbEmployee.Items.Clear();
            //cmbEmployee.Items.Add(new ExproComboBox("Select", "Select"));
            //cmbEmployee.Enabled = true;
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    cmbEmployee.Items.Add(new ExproComboBox(dr["emp_code"].ToString(), dr["emp_name"].ToString()));
            //}
            //cmbEmployee.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                btnSubmit.Enabled = false;
                cmbEmployee.Enabled = false;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "GoodsReturn:UpdAllottedTo"; p.prm_1 = ((ExproComboBox)cmbEmployee.SelectedItem).Value;
                p.tran_id = _msterGrNo;p.prm_2 = _vendCode;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);

             
                MessageBox.Show(dwr.message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Is Your Printer Ready? ", "Purchase Return Slip", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                btnPrint.Enabled = false;
                Printing.Laser.ExpiryReturn_Slip(_dsInfo.Tables[1], _dsInfo.Tables[1].Rows[0]["gr_no"].ToString(), _dsInfo.Tables[0].Rows[0]["gr_date"].ToString(), _dsInfo.Tables[0].Rows[0]["tin_no"].ToString(), _dsInfo.Tables[0].Rows[0]["vendor_name"].ToString(), _dsInfo.Tables[0].Rows[0]["vend_Address"].ToString());
                btnPrint.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            cmbEmployee.Enabled = true;

        }

        private void btnUnitInfoPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Is Your Printer Ready? ", "GR Info Sheet", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                string unitName = ((ExproComboBox)cmbUnits.SelectedItem).Value;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "EGR:UnitWiseInfo"; p.prm_1 = unitName; p.prm_2 = _msterGrNo;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);

                _ds = dwr.result;
                btnUnitInfoPrint.Enabled = false;
                Printing.Laser.gr_ReportForUnit(_ds.Tables[0], _msterGrNo,unitName);
                btnUnitInfoPrint.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (Convert.ToDecimal(e.RowElement.RowInfo.Cells["Qty[T]"].Value) != Convert.ToDecimal(e.RowElement.RowInfo.Cells["Qty[R]"].Value))
            {
                e.RowElement.RowInfo.Cells["Qty[T]"].Style.ForeColor = Color.Red;
                e.RowElement.RowInfo.Cells["Qty[R]"].Style.ForeColor = Color.Red;
            }
            else
            {
                e.RowElement.RowInfo.Cells["Qty[T]"].Style.ForeColor = Color.Green;
                e.RowElement.RowInfo.Cells["Qty[R]"].Style.ForeColor = Color.Green;
            }
        }

        private void rgv_info_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }

        private void rgv_processed_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (rgv_processed.CurrentRow.Cells["Name of Party"].Value != null)
            {
                btnPrint.Enabled = true;
                _gr_no = rgv_processed.CurrentRow.Cells["GR No"].Value.ToString();
                Grbox.Text = rgv_processed.CurrentRow.Cells["Name of Party"].Value.ToString();
                _vendCode = rgv_processed.CurrentRow.Cells["V.CODE"].Value.ToString();
                cm2 p = new cm2();
                p.unit_id = rgv_processed.CurrentRow.Cells["unit_id"].Value.ToString();
                p.Logic = "EGR:Printing"; p.prm_1 = _vendCode; p.prm_2 = _msterGrNo;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);

                _dsInfo = dwr.result;
                if (_dsInfo.Tables.Count > 0 && _dsInfo.Tables[0].Rows.Count > 0 && _dsInfo.Tables[1].Rows.Count > 0)
                { Grbox.Enabled = true; }
                else
                { Grbox.Enabled = false; }
            }
            Cursor.Current = Cursors.Default;
        }

        private void rgv_ids_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _msterGrNo = e.Row.Cells["master_gr_no"].Value.ToString();
                FillListView(_msterGrNo);
                if (_msterGrNo == "-")
                {
                    gb_FinishProcess.Visible = true;

                }
                else
                {
                    gb_FinishProcess.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
