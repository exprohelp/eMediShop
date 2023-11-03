using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Hospital
{
    public partial class ucIPD_Indent : UserControl
    {
        string _result = string.Empty; string _oldValue = string.Empty; string _newValue = string.Empty;
        string _indentNo = string.Empty; string _uhid = string.Empty; string _indentLogic = string.Empty;
        string _indentType = string.Empty; int _issuedQty = 0;
        public ucIPD_Indent()
        {
            InitializeComponent();
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void btnpendinglist_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.logic = "NotSupplied"; p.from = "1900/01/01"; p.to = "1900/01/01"; p.prm_1 = "";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                dgIndentInfo.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void dgIndentInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _issuedQty = 0;
                _uhid = e.Row.Cells["uhid"].Value.ToString();
                _indentNo = e.Row.Cells["indent_no"].Value.ToString();
                _indentType = e.Row.Cells["indent_type"].Value.ToString();
                rtb_remarks.Text = "";
                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.IPOPNo = _indentNo;
                p.logic = "NotSuppliedInfo"; p.from = "1900/01/01"; p.to = "1900/01/01"; p.prm_1 = ""; p.uhid = _uhid;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                rgv_detail.DataSource = dwr.result.Tables[0];

                if (_issuedQty != 0)
                    btn_reject.Enabled = false;
                else
                    btn_reject.Enabled = true;


            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_detail_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (Convert.ToInt32(e.RowElement.RowInfo.Cells["issue_qty"].Value) != 0)
            {
                e.RowElement.ForeColor = Color.Green;
            }
            else
            {
                e.RowElement.ForeColor = Color.Red;
            }
            _issuedQty += Convert.ToInt32(e.RowElement.RowInfo.Cells["issue_qty"].Value);
        }

        private void dgIndentInfo_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["status_flag"].Value.ToString() == "NS")
            {
                e.RowElement.ForeColor = Color.Red;
            }
            else
            {
                e.RowElement.ForeColor = Color.Violet;
            }
        }

        private void rgv_detail_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[e.ColumnIndex].Value != null)
            {
                _oldValue = (string)e.Row.Cells[e.ColumnIndex].Value;
            }
        }

        private void rgv_detail_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.Name == "reject_remarks")
            {
                #region reject Remarks
                if (e.Row.Cells["reject_remarks"].Value.ToString() != _oldValue)
                {
                    _newValue = e.Row.Cells["reject_remarks"].Value.ToString();
                    if (_oldValue != _newValue)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            pm_UpdateIndent p = new pm_UpdateIndent();
                            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                            p.indent_no = _indentNo; p.uhid = _uhid; p.item_id = e.Row.Cells["item_id"].Value.ToString();
                            p.remarks = _newValue;
                            p.logic = "updRejRemark";
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/updateIndent", p);

                            if (dwr.message.Contains("Success"))
                                RadMessageBox.Show("Successfully Marked.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                            else
                                RadMessageBox.Show("Error During Update.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        }
                        catch (Exception ex)
                        {
                            RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }

                }
                #endregion

            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_UpdateIndent p = new pm_UpdateIndent();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.indent_no = _indentNo; p.uhid = _uhid; p.item_id = "-";
                p.remarks = rtb_remarks.Text;
                p.logic = "updRejRemark";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/updateIndent", p);

                if (dwr.message.Contains("Success"))
                    RadMessageBox.Show("Successfully Updated.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                else
                    RadMessageBox.Show("Error During updation", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

                pm_IPOPQueries p1 = new pm_IPOPQueries();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id; p1.IPOPNo = _indentNo; p1.uhid = _uhid;
                p1.logic = "NotSuppliedInfo"; p1.from = "1900/01/01"; p1.to = "1900/01/01"; p1.prm_1 = "";
                dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p1);
                if (dwr.result.Tables[0].Rows.Count > 0)
                    rgv_detail.DataSource = dwr.result.Tables[0];
                else
                    rgv_detail.DataSource = new string[] { };


            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            if (rtb_remarks.Text.Length < 10)
            {
                RadMessageBox.Show("Type Reason of Indent Rejection.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm To Close It?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    pm_UpdateIndent p = new pm_UpdateIndent();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.indent_no = _indentNo; p.uhid = _uhid; p.item_id = "-";
                    p.remarks = rtb_remarks.Text;
                    p.logic = "IndentClosing";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/updateIndent", p);
                    if (dwr.message.Contains("Success"))
                    {
                        RadMessageBox.Show("Indent Closed Successfully.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        dgIndentInfo.CurrentRow.Delete();
                        rgv_detail.DataSource = new string[] { };
                    }
                    else
                        RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void rbtn_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "IndentRegister.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(radGridView1);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;
                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string logic = string.Empty;
                if (rbReject.Checked)
                    logic = "Reject-Report";
                else
                    logic = "Indent-Register";
                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.IPOPNo = _indentNo;
                p.logic = logic; p.from = rdp_from.Value.ToString("yyyy/MM/dd");
                p.to = rdp_to.Value.ToString("yyyy/MM/dd"); p.prm_1 = "";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);

                radGridView1.DataSource = dwr.result.Tables[0];
                foreach (GridViewColumn column in radGridView1.Columns)
                {
                    column.BestFit();
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
