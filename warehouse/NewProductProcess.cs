using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class NewProductProcess : UserControl
    {

        string _result = string.Empty; DataSet _ds;
        string _unit_id = ""; string _TrfId = "N/A";
        public NewProductProcess()
        {
            InitializeComponent();
        }

        private void NewProductProcess_Load(object sender, EventArgs e)
        {

        }

        private void rb_Process_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pmOpenOrder p = new pmOpenOrder();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                p.order_no = "-";p.logic = "GEN_ORDER";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderNewMedicine", p);
                if (dwr.message.Contains("has not been Closed"))
                {
                    string[] pp = dwr.message.Split('|');
                    txtOrderNo.Text = pp[1];
                    radGridView1.Columns.Clear();
                    foreach (DataColumn columns in dwr.result.Tables[0].Columns)
                    {
                        GridViewTextBoxColumn col = new GridViewTextBoxColumn(columns.ColumnName.ToString());
                        col.Name = columns.ColumnName.ToString();
                        col.FieldName = columns.ColumnName.ToString();
                        col.HeaderText = columns.ColumnName.ToString();
                        radGridView1.MasterTemplate.Columns.Add(col);
                    }
                    if (dwr.result.Tables[0].Rows.Count > 0)
                        txtOrderNo.Text = dwr.result.Tables[0].Rows[0]["order_no"].ToString();
                   
                    radGridView1.DataSource = dwr.result.Tables[0];

                }
                else
                {
                    txtOrderNo.Text = "Generate Order";
                    MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rb_export_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();
                string fileName = f.SelectedPath + "\\UrgentOrder_" + DateTime.Now.ToString("yyyy_MM_dd") + ".xls";
                Cursor.Current = Cursors.WaitCursor;
                ExportToExcelML exporter = new ExportToExcelML(this.radGridView1);
                exporter.ExportVisualSettings = true;
                //exporter.SheetMaxRows = ExcelMaxRows._1048576;
                Cursor.Current = Cursors.WaitCursor;
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }

        private void rb_close_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pmOpenOrder p = new pmOpenOrder();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.order_no = txtOrderNo.Text; p.logic = "CLOSE_ORDER";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderNewMedicine", p);
                RadMessageBox.Show(dwr.message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
