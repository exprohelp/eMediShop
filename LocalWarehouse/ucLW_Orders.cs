using System;
using System.Windows.Forms;

namespace eMediShop.LocalWarehouse
{
    public partial class ucLW_Orders : UserControl
    {
        public ucLW_Orders()
        {
            InitializeComponent();
        }

        private void ucLW_Orders_Load(object sender, EventArgs e)
        {
            loadOrder();
        }
        private void loadOrder()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                datasetWithResult dwr = new datasetWithResult();
                Localwarehouse p = new Localwarehouse();
                p.unit_id = GlobalUsage.Unit_id; p.ForUnit = "N/A";
                p.processAverage = "N"; p.ordermth = "0";
                p.nProduct = "0"; p.login_id = GlobalUsage.Login_id;
                p.logic = "get_orderNos"; p.order_no = "-";
                p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/LocalWarehouses/PurhaseOrderForLocalWarehouse", p);
                rgvOrders.DataSource = dwr.result.Tables[0];
                if (dwr.result.Tables[0].Rows.Count == 0)
                { btnGenPo.Enabled = true; }
                else
                { btnGenPo.Enabled = false; }

            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void rgvOrders_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                datasetWithResult dwr = new datasetWithResult();
                Localwarehouse p = new Localwarehouse();
                p.unit_id = GlobalUsage.Unit_id; p.ForUnit = "N/A";
                p.processAverage = "N"; p.ordermth = "0";
                p.nProduct = "0"; p.login_id = GlobalUsage.Login_id;
                p.logic = "get_orderinfo"; p.order_no = e.Row.Cells["order_no"].Value.ToString();
                radGroupBox1.Text = p.order_no;
                p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/LocalWarehouses/PurhaseOrderForLocalWarehouse", p);
                rgvOrderInfo.DataSource = dwr.result.Tables[0];
                btnClose.Enabled = true;
                for (int i = 0; i < this.rgvOrderInfo.Columns.Count; i++)
                {
                    this.rgvOrderInfo.Columns[i].BestFit();
                }
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "AEP_" + GlobalUsage.Audit_No + ".xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgvOrderInfo);
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

        private void btnGenPo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                datasetWithResult dwr = new datasetWithResult();
                Localwarehouse p = new Localwarehouse();
                p.unit_id = GlobalUsage.Unit_id; p.ForUnit = GlobalUsage.Unit_id;
                p.processAverage = "N"; p.ordermth = txtOrderFor.Text;
                p.nProduct = txtOrderFor.Text; p.login_id = GlobalUsage.Login_id;
                p.logic = "GEN_ORDER"; p.order_no = "-";
                p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/LocalWarehouses/PurhaseOrderForLocalWarehouse", p);
                lblMessage.Text = "Message: " + dwr.message;
                loadOrder();
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvOrderInfo_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                datasetWithResult dwr = new datasetWithResult();
                Localwarehouse p = new Localwarehouse();
                p.unit_id = GlobalUsage.Unit_id; p.ForUnit = rgvOrderInfo.CurrentRow.Cells["Item Id"].Value.ToString();
                p.processAverage = "N"; p.ordermth = "0";
                p.nProduct = "0"; p.login_id = GlobalUsage.Login_id;
                p.logic = "get_distribution"; p.order_no = radGroupBox1.Text;
                p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/LocalWarehouses/PurhaseOrderForLocalWarehouse", p);
                rgv_ditributed.DataSource = dwr.result.Tables[0];
                for (int i = 0; i < this.rgv_ditributed.Columns.Count; i++)
                {
                    this.rgv_ditributed.Columns[i].BestFit();
                }
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                datasetWithResult dwr = new datasetWithResult();
                Localwarehouse p = new Localwarehouse();
                p.unit_id = GlobalUsage.Unit_id; p.ForUnit = GlobalUsage.Unit_id;
                p.processAverage = "N"; p.ordermth = txtOrderFor.Text;
                p.nProduct = txtOrderFor.Text; p.login_id = GlobalUsage.Login_id;
                p.logic = "CLOSE_ORDER"; p.order_no = radGroupBox1.Text;
                p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/LocalWarehouses/PurhaseOrderForLocalWarehouse", p);
                lblMessage.Text = "Message: " + dwr.message;
                loadOrder();
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
