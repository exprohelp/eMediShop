using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Indents
{
    public partial class ucIndentProcess : UserControl
    {
        string _indentno = string.Empty; string _processType = string.Empty; string _trasferToUnit = string.Empty;
        public ucIndentProcess()
        {
            InitializeComponent();
        }

        private void ucIndentProcess_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pmIndentToUnit p = new pmIndentToUnit();
                p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id; p.logic = "UnitList";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
                if (dwr.message.Contains("Success"))
                {
                    rgv_unit.DataSource = dwr.result.Tables[0];
                }
                else
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
            PopulateRemarks();
        }

        private void rgv_unit_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _processType = e.Row.Cells["process_type"].Value.ToString();
                btnProcess.Text = _processType;
                _trasferToUnit = e.Row.Cells["unit_id"].Value.ToString();
                _indentno = e.Row.Cells["indent_no"].Value.ToString();
                Fill_Detail(_indentno);

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void Fill_Detail(string indentNo)
        {
            pmIndentToUnit p = new pmIndentToUnit(); p.indent_no = indentNo;
            p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id; p.logic = "ForVerification";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
            if (dwr.message.Contains("Success"))
            {
                rgv_detail.DataSource = dwr.result.Tables[0];
            }
            else
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
        }

        private void rgv_detail_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {

        }

        private void rgv_detail_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }
        private void PopulateRemarks()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("flag", typeof(string));
                DataRow dr = dt.NewRow();
                dr["flag"] = "P";
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["flag"] = "X";
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["flag"] = "N";
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["flag"] = "Y";
                dt.Rows.Add(dr);


                Cursor.Current = Cursors.WaitCursor;
                Telerik.WinControls.UI.GridViewComboBoxColumn reportsColumn = ((Telerik.WinControls.UI.GridViewComboBoxColumn)rgv_detail.Columns["conf_flag"]);
                reportsColumn.Width = 75;
                reportsColumn.AllowFiltering = false;
                reportsColumn.ValueMember = "flag";
                reportsColumn.DisplayMember = "flag";
                reportsColumn.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("autoId", typeof(string));
                dt.Columns.Add("order_no", typeof(string));
                dt.Columns.Add("item_id", typeof(string));
                dt.Columns.Add("rcpt_qty", typeof(string));
                dt.Columns.Add("remarks", typeof(string));
                dt.Columns.Add("prm1", typeof(string));
                dt.Columns.Add("prm2", typeof(string));
                foreach (GridViewRowInfo rowInfo in rgv_detail.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["autoId"] = rowInfo.Cells["auto_id"].Value;
                    dr["order_no"] = _indentno;
                    dr["item_id"] = rowInfo.Cells["item_id"].Value;
                    dr["rcpt_qty"] = rowInfo.Cells["conf_qty"].Value;
                    dr["remarks"] = rowInfo.Cells["remarks"].Value;
                    dr["prm1"] = rowInfo.Cells["conf_flag"].Value;
                    dr["prm2"] = "-";
                    dt.Rows.Add(dr);
                }
                pmIndentToUnit p = new pmIndentToUnit(); p.indent_no = _indentno;
                p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id; p.logic = "Verified";
                p.dt = dt;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                Fill_Detail(_indentno);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_detail_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["verified"].Value != null)
            {
                if (e.RowElement.RowInfo.Cells["verified"].Value.ToString() == "Y")
                {
                    e.RowElement.ForeColor = Color.Green;
                    btnVerify.Enabled = false;
                    btnProcess.Enabled = true;
                    rgv_detail.ReadOnly = true;
                }
                else if (e.RowElement.RowInfo.Cells["verified"].Value.ToString() == "N")
                {
                    e.RowElement.ForeColor = Color.Red;
                    rgv_detail.ReadOnly = false;
                }
                }
            }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {

                pm_Transfer p = new pm_Transfer();
                p.unit_id = GlobalUsage.Unit_id;p.TransferToUnit = _trasferToUnit;p.tran_type = _processType;
                p.logic = "By Indent";p.login_id = GlobalUsage.Login_id;p.transaction_id = _indentno;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/BulkTransaction_Processing", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                if(dwr.message.Contains("Success"))
                { 
                rgv_unit.CurrentRow.Delete();
                Fill_Detail(_indentno);
                }
                btnProcess.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
