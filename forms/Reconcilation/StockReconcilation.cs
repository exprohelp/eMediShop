using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;
using System.IO;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace eMediShop.forms.Reconcilation
{
    public partial class StockReconcilation : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty;string _auditNo = string.Empty;
        string _masterkeyid = string.Empty; string _itemid = string.Empty; string _itemName = string.Empty;
        string _qry = string.Empty;
        public StockReconcilation()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Stocks p = new pm_Stocks();
                p.unit_id = GlobalUsage.Unit_id; p.item_id = "-";
                p.master_key_id = "N/A"; p.searchKey = txtearchKey.Text; p.logic = cmbOption.Text; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductMovementInfo", p);
                rgv_products.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_products_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _itemid = e.Row.Cells["item_id"].Value.ToString();
                _itemName = e.Row.Cells["item_name"].Value.ToString();
                rgb_info.Text = e.Row.Cells["item_name"].Value.ToString() + " [" + e.Row.Cells["item_id"].Value.ToString() + "]";
                
                pm_Stocks p = new pm_Stocks();
                p.unit_id = GlobalUsage.Unit_id;p.item_id = _itemid;
                p.master_key_id = "N/A";p.searchKey = "N/A";p.logic = "KeyTracingByItemid";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductMovementInfo", p);
                rgv_detail.DataSource = dwr.result.Tables[0];
                txtExtra.Text = "0"; txtShort.Text = "0"; chkBatch.Checked = true; chkExpiry.Checked = true; chkPack.Checked = true; txtRemark.Text = "";

                if (_auditNo.Length > 5)
                    gb_mkwi.Enabled = true;
                else
                    gb_mkwi.Enabled = false;

                if (e.Row.Cells["status_flag"].Value.ToString() == "N")
                    gb_mkwi.Enabled = false;
                else if (_auditNo.Length > 5)
                    gb_mkwi.Enabled = true;

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_detail_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (Convert.ToDecimal(e.RowElement.RowInfo.Cells["balqty"].Value) == Convert.ToDecimal(e.RowElement.RowInfo.Cells["stkqty"].Value) && e.RowElement.RowInfo.Cells["InAudit"].Value.ToString()=="G")
                e.RowElement.ForeColor = Color.Green;
            else if (e.RowElement.RowInfo.Cells["InAudit"].Value.ToString() == "H")
                e.RowElement.ForeColor = Color.Brown;
            else
                e.RowElement.ForeColor = Color.Red;
        }

        private void StockReconcilation_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "GetLocation"; p.keyString = "N/A"; p.audit_no = _auditNo; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);
                _ds = dwr1.result;
                rgv_shelfno.DataSource = _ds.Tables[0];
                cmbRecordsOption.Items.AddRange(Config.FillCombo(_ds.Tables[1]));
                cmbRecordsOption.SelectedIndex = 0;
                txtearchKey.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
                txtearchKey.SelectedIndex = 0;

                p.unit_id = GlobalUsage.Unit_id; p.logic = "GetOpenAudit"; p.keyString = "N/A"; p.audit_no = _auditNo; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);

                _ds = dwr.result;

                if (_ds.Tables[0].Rows.Count == 1) { 
                    _auditNo = _ds.Tables[0].Rows[0]["audit_no"].ToString();
                    this.Text = "Stock Audit Options : " + _auditNo;
                }



            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }


        }

        private void rgv_shelfno_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "ShelfRecords"; p.prm_1 = e.Row.Cells["shelf_no"].Value.ToString(); p.prm_2 = "N/A"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                _ds = dwr.result;

                rgv_ShelfInfo.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                CrystalReportsPharmacy.Reports.CrShelfReport rpt = new CrystalReportsPharmacy.Reports.CrShelfReport();
                rpt.Database.Tables["products"].SetDataSource(_ds.Tables[0]);
                rpt.SetParameterValue("UnitName", GlobalUsage.UnitName);
                rpt.SetParameterValue("unitAddress", GlobalUsage.UnitAddress);
                rpt.PrintToPrinter(1, false, 1, 0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                string colName = ((GridCommandCellElement)sender).ColumnInfo.Name.ToString();
                if (colName == "U") {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Stock:UpdateByAudit"; p.prm_1 = e.Row.Cells["balqty"].Value.ToString();
                    p.tran_id = e.Row.Cells["master_key_id"].Value.ToString();
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                }
                else if(colName == "A")
                {
                    AuditDataInsert();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void txtShort_Enter(object sender, EventArgs e)
        {
            txtShort.SelectAll();
        }

        private void txtExtra_Leave(object sender, EventArgs e)
        {
            txtExtra.SelectAll();
        }

        private void rgv_detail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AuditDataInsert();

            }
            else if(e.KeyCode==Keys.F2)
            {
                Clipboard.Clear();
                Clipboard.SetText(_masterkeyid);
                eMediShop.forms.Reconcilation.KeyTracing UseForm = new Reconcilation.KeyTracing(_masterkeyid);
                UseForm.Owner = this;
                UseForm.Show();
            }
            else if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.O)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_Stocks p = new pm_Stocks();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.master_key_id = rgv_detail.CurrentRow.Cells["master_key_id"].Value.ToString();
                    p.qty = Convert.ToInt16(rgv_detail.CurrentRow.Cells["balQty"].Value);
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/UpdateInsertOpeningStock", p);
                    if (dwr.message.Contains("Success"))
                        rgv_detail.CurrentRow.Delete();
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void AuditDataInsert()
        {
            gb_mkwi.Text = rgv_detail.CurrentRow.Cells["master_key_id"].Value.ToString();
            _itemid = rgv_detail.CurrentRow.Cells["item_id"].Value.ToString();
            txtShort.Focus();
            _masterkeyid = gb_mkwi.Text;
            pm_Audit_Queries p = new pm_Audit_Queries();
            p.unit_id = GlobalUsage.Unit_id; p.logic = "ExistsKeyRecords"; p.keyString = _masterkeyid; p.audit_no = _auditNo; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);

            _ds = dwr.result;
            if(_ds.Tables[0].Rows.Count>0)
            {
                txtShort.Text = _ds.Tables[0].Rows[0]["shortqty"].ToString();
                txtExtra.Text = _ds.Tables[0].Rows[0]["extra_qty"].ToString();
                if (_ds.Tables[0].Rows[0]["m_batch"].ToString() == "Y") chkBatch.Checked = true; else chkBatch.Checked = false;
                if (_ds.Tables[0].Rows[0]["m_expiry"].ToString() == "Y") chkExpiry.Checked = true; else chkExpiry.Checked = false;
                if (_ds.Tables[0].Rows[0]["m_pack"].ToString() == "Y") chkPack.Checked = true; else chkPack.Checked = false;
                txtRemark.Text= _ds.Tables[0].Rows[0]["remarks"].ToString();
            }
            if (_ds.Tables[1].Rows.Count > 0)
            {
                lblKeyInformation.Text = _ds.Tables[1].Rows[0]["keyInfo"].ToString();
            }
            else
            {
                lblKeyInformation.Text = "Key Info : XXXXXXXXX";
            }


           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string chkBvalue = "";
            string chkEvalue = "";
            string chkPvalue = "";
            if (chkBatch.Checked)
            {
                chkBvalue = "Y";
            }
            else
            {
                chkBvalue = "N";
            }

            if (chkExpiry.Checked)
            {
                chkEvalue = "Y";
            }
            else
            {
                chkEvalue = "N";
            }
            if (chkPack.Checked)
            {
                chkPvalue = "Y";
            }
            else
            {
                chkPvalue = "N";
            }
            try
            {
                gb_mkwi.Enabled = false;
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.audit_no = _auditNo;p.unit_id = GlobalUsage.Unit_id;p.item_id = _itemid;p.item_name = _itemName;
                p.master_key_id = _masterkeyid;p.short_qty = Convert.ToInt32(txtShort.Text);
                p.extra_qty = Convert.ToInt32(txtExtra.Text);p.m_batch = chkBvalue;p.m_expiry = chkEvalue;
                p.m_pack = chkPvalue;p.remarks = txtRemark.Text;p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditInsertShortExtra", p);

                if (dwr.message.Contains("Successfully"))
                    btn_update.BackColor = Color.DarkGreen;
                else
                    btn_update.BackColor = Color.Red;
                txtExtra.Text = "0"; txtShort.Text = "0"; chkBatch.Checked = false; chkExpiry.Checked = false; chkPack.Checked = false; txtRemark.Text = "";
                if (_auditNo.Length > 5)
                    gb_mkwi.Enabled = true;
                else
                    gb_mkwi.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information of " + _itemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAuditData_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.unit_id = GlobalUsage.Unit_id; p.logic = cmbRecordsOption.Text; p.keyString = _masterkeyid; p.audit_no = _auditNo; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);

                _ds = dwr.result;
                rgv_AuditRecords.DataSource = _ds.Tables[0];

                for (int i = 1; i < this.rgv_AuditRecords.Columns.Count; i++)
                {
                    this.rgv_AuditRecords.Columns[i].BestFit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btnXL_Click(object sender, EventArgs e)
        {

            ExportToExcelML exporter = new ExportToExcelML(this.rgv_AuditRecords);
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            exporter.ExportVisualSettings = true;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                exporter.RunExport(fd.SelectedPath + "\\audit_" + _auditNo + ".xls");
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_detail_Click(object sender, EventArgs e)
        {
            _masterkeyid = rgv_detail.CurrentRow.Cells["master_key_id"].Value.ToString();
        }

        private void rgv_detail_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(_masterkeyid);
            eMediShop.forms.Reconcilation.KeyTracing UseForm = new Reconcilation.KeyTracing(_masterkeyid);
            UseForm.Owner = this;
            UseForm.Show();
        }

        private void MasterTemplate_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["status_flag"].Value.ToString() == "Y")
                e.RowElement.ForeColor = Color.Black;
            else
                e.RowElement.ForeColor = Color.Red;
        }
    }
}
