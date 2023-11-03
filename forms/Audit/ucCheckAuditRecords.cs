using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace eMediShop.forms.Audit
{
    public partial class ucCheckAuditRecords : UserControl
    {
        string _auditNo=string.Empty;string _result = string.Empty; string _jsonResult = string.Empty;
        public ucCheckAuditRecords(string auditNo)
        {
            _auditNo = auditNo;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                //if (!rbShortage.IsChecked)
                    btnProcess.Enabled = true;
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.unit_id = GlobalUsage.Unit_id; p.keyString = "N/A"; p.audit_no = _auditNo; p.login_id = GlobalUsage.Login_id;

                if (rbShortage.IsChecked)
                    p.logic="Shortage";
                else
                    p.logic="Extra";

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);
                rgv_info.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex)
            {
            }
            finally { Cursor.Current = Cursors.Default; }
            btnSubmit.Enabled = true;
        }

        private void rlv_info_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            //if (e.Column.FieldName == "item_ID")
            //{
            //    e.Column.HeaderText = "Item Id";
            //    e.Column.Width = 0;
            //    e.Column.Visible = false;
            //}
            //else if (e.Column.FieldName == "item_name")
            //{
            //    e.Column.HeaderText = "Name of Product";
            //    e.Column.Width = 300;
            //}
            //else if (e.Column.FieldName == "master_key_id")
            //{
            //    e.Column.HeaderText = "Master Key";
            //    e.Column.Width = 100;
                
            //}
            //else if (e.Column.FieldName == "ShortQty")
            //{
            //    e.Column.Width = 70;
            //    e.Column.HeaderText = "Qty(A)";
            //}
            //else if (e.Column.FieldName == "Quantity")
            //{
            //    e.Column.Width = 70;
            //    e.Column.HeaderText = "Qty(S)";
            //}

        }

        private void ucCheckAuditRecords_Load(object sender, EventArgs e)
        {

        }

        private void rlv_info_CellFormatting(object sender, Telerik.WinControls.UI.ListViewCellFormattingEventArgs e)
        {
            
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "AuditRecords.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgv_info);
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

        private void rgv_info_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["diff_flag"].Value.ToString() == "N")
            {
                e.RowElement.ForeColor = Color.Green;
            }
            else
            {
                e.RowElement.ForeColor = Color.Red;
                if(rbShortage.IsChecked)
                btnProcess.Enabled = false;

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Audit_Queries p = new pm_Audit_Queries();
                p.unit_id = GlobalUsage.Unit_id;p.audit_no = _auditNo;p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = new datasetWithResult();
                if (rbShortage.IsChecked)
                    dwr = ConfigWebAPI.CallAPI("api/audit/AuditShortageProcess", p);
                else if (rbExtra.IsChecked)
                    dwr = ConfigWebAPI.CallAPI("api/audit/AuditExtraProcess", p);
                MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
