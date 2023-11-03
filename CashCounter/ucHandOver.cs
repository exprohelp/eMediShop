using eMediShop.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.CashCounter
{
    public partial class ucHandOver : UserControl
    {
        DataSet _ds = new DataSet(); string _empCode = string.Empty; string _result = string.Empty;
        string _shiftID = string.Empty; decimal _transferAmt = 0;
        public ucHandOver()
        {
            InitializeComponent();
        }

        private void ucHandOver_Load(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;

            OnLoadRefresh();
        }

        private void OnLoadRefresh()
        {
            _transferAmt = 0;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Hoto p = new Hoto();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "OnLoadInfo"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/HOTOQueries", p);
                _ds = dwr.result;
                string res = dwr.message;
                if (dwr.message.Contains("SID"))
                {
                    btnInitiate.Enabled = false;
                    gbMAin.Enabled = true;
                    _shiftID = dwr.message;
                }
                else
                {
                    btnInitiate.Enabled = true;
                    gbMAin.Enabled = false;
                }

                foreach (DataRow dr in _ds.Tables[1].Rows)
                {
                    _transferAmt += Convert.ToDecimal(dr["Amount"]);
                    txtAmount.Text = _transferAmt.ToString();
                }
                if (_transferAmt == 0)
                    btnCloseWorkID.Enabled = true;
                else
                    btnCloseWorkID.Enabled = false;

                rgvToBeRec.DataSource = _ds.Tables[0];
                rgvCollection.DataSource = _ds.Tables[1];
                rgvColl2.DataSource = _ds.Tables[1];
                rgvStaffList.DataSource = _ds.Tables[2];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                OnLoadRefresh();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvStaffList_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            radGroupBox3.Text = "Transfer To : " + e.Row.Cells["emp_name"].Value.ToString();
            _empCode = e.Row.Cells["emp_code"].Value.ToString();
            radGroupBox3.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rtbremarks.Text.Length < 10)
            {
                RadMessageBox.Show("Write More than 10 Character Remarks.", "ExPro Help", MessageBoxButtons.OK);
                return;
            }
            if (txtAmount.Text.Length == 0)
            {
                RadMessageBox.Show("Amount Should Not Be Zero.", "ExPro Help", MessageBoxButtons.OK);
                return;
            }

            DialogResult res = RadMessageBox.Show("Do You Confirm To Transfer ?", "ExPro Help", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Hoto p = new Hoto();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.autoId = "0"; p.tnxDate = DateTime.Now.ToString("yyyy-MM-dd");
                    p.tnxBy = GlobalUsage.Login_id; p.tnxTo = _empCode;
                    p.amount = Convert.ToDecimal(txtAmount.Text);
                    if (rbTransfer.Checked)
                        p.logic = "Transfer";
                    else if (rbShort.Checked)
                        p.logic = "Short";

                    p.prm_1 = rtbremarks.Text;
                    p.shiftID = _shiftID;

                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/InsertModifyACCollectionInfo", p);
                    _result = dwr.message;
                    OnLoadRefresh();
                    radGroupBox3.Enabled = false;
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void rgvToBeRec_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Do You Confirm To Receive ?", "ExPro Help", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Hoto p = new Hoto();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.autoId = e.Row.Cells["autoid"].Value.ToString(); p.tnxDate = DateTime.Now.ToString("yyyy-MM-dd");
                    p.tnxBy = GlobalUsage.Login_id; p.tnxTo = "-";
                    p.amount = Convert.ToDecimal(e.Row.Cells["Amount"].Value);
                    p.logic = "Received";
                    p.shiftID = _shiftID;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/InsertModifyACCollectionInfo", p);
                    _result = dwr.message;
                    rtbremarks.Text = "";
                    OnLoadRefresh();
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void rgvColl2_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {

        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtAmount.Text) > _transferAmt && rbTransfer.Checked)
            {
                RadMessageBox.Show("Transfer Amount is More than Balance.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                txtAmount.Focus();
                txtAmount.SelectAll();
            }
        }

        private void rgvColl2_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Do You Confirm To Close the Working ?", "ExPro Help", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Hoto p = new Hoto();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.autoId = e.Row.Cells["autoid"].Value.ToString(); p.tnxDate = DateTime.Now.ToString("yyyy-MM-dd");
                    p.tnxBy = GlobalUsage.Login_id; p.tnxTo = "-";
                    p.amount = 0;
                    p.logic = "DeleteRecord";
                    p.shiftID = _shiftID;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/InsertModifyACCollectionInfo", p);
                    _result = dwr.message;
                   
                    OnLoadRefresh();
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }

        }

        private void btnCloseWorkID_Click(object sender, EventArgs e)
        {
            DialogResult res = RadMessageBox.Show("Do You Confirm To Close the Working ?", "ExPro Help", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Hoto p = new Hoto();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.autoId = "-"; p.tnxDate = DateTime.Now.ToString("yyyy-MM-dd");
                    p.tnxBy = GlobalUsage.Login_id; p.tnxTo = "-";
                    p.amount = 0;
                    p.logic = "CloseWorking";
                    p.shiftID = _shiftID;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/InsertModifyACCollectionInfo", p);
                    _result = dwr.message;
                    rtbremarks.Text = "";
                    OnLoadRefresh();
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void rgvColl2_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "cmd")
                {
                    ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    if (e.CellElement.RowInfo.Cells["Rec_Flag"].Value.ToString() == "N")
                    {
                        ((GridCommandCellElement)e.CellElement).CommandButton.Image = Resources.delete_16;
                        ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    }
                }
                //if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "cmd")
                //{
                //    if (e.CellElement.RowInfo.Cells["Rec_Flag"].Value.ToString() == "Y")
                //    {
                //        ((GridCommandCellElement)e.CellElement).CommandButton.Enabled=false;
                //    }
                //    else
                //    {
                //        ((GridCommandCellElement)e.CellElement).CommandButton.Enabled=true;
                //    }
                //}
            }
        }

        private void btnInitiate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Hoto p = new Hoto();
                p.unit_id = GlobalUsage.Unit_id;
                p.autoId = "-"; p.tnxDate = DateTime.Now.ToString("yyyy-MM-dd");
                p.tnxBy = GlobalUsage.Login_id; p.tnxTo = "-";
                p.amount = 0;
                p.logic = "Initiate";p.login_id = GlobalUsage.Login_id;
                p.shiftID = _shiftID;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/InsertModifyACCollectionInfo", p);
                _result = dwr.message;
                rtbremarks.Text = "";
                OnLoadRefresh();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void btngetReport_Click(object sender, EventArgs e)
        {
            Hoto p = new Hoto();
            p.unit_id = GlobalUsage.Unit_id; p.logic = "DetailReport"; p.login_id = GlobalUsage.Login_id;
            p.prm_1 = rdp_from.Value.ToString("yyyy-MM-dd"); p.prm_2 = rdp_to.Value.ToString("yyyy-MM-dd");
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/HOTOQueries", p);
            _ds = dwr.result;
            rgvReports.DataSource = _ds.Tables[0];
        }

        private void btn_xl_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "HandOverTakeOver.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgvReports);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;
                    //spreadExporter.SheetName = "OrderStatus";
                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["colorFlag"].Value.ToString() == "Red")
                e.RowElement.ForeColor = Color.Red;
            else if (e.RowElement.RowInfo.Cells["colorFlag"].Value.ToString() == "Green")
                e.RowElement.ForeColor = Color.Green;

        }
    }
}
