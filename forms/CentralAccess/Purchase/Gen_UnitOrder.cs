using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace eMediShop.forms.CentralAccess.Purchase
{

    public partial class Gen_UnitOrder : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        string _order_no = string.Empty; string _jsonString = string.Empty;
        public Gen_UnitOrder()
        {
            InitializeComponent();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            try
            {
                //lv_Reports.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "Get_UnitwithOrderStatus"; p.prm_1 = "-"; p.prm_2 = GlobalUsage.Login_id; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                gridOrderUnit.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { }
            Cursor.Current = Cursors.Default;
        }

        private void Gen_UnitOrder_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
        }
        private void gridOrderUnit_CommandCellClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string order_no = string.Empty;
                Telerik.WinControls.UI.GridViewRowInfo r = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).RowInfo;
                string command = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).Value.ToString();
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                datasetWithResult dwr = new datasetWithResult();
                if (command.ToUpper() == "OPEN")
                {
                   
                    p.unit_id = GlobalUsage.Unit_id;p.forunit = gridOrderUnit.CurrentRow.Cells["unit_id"].Value.ToString();
                    p.processAverage = "N";p.orderFormonth = Convert.ToDecimal(txtOrdMth.Text);
                    p.nProduct = Convert.ToInt32(txtnProduct.Text);p.login_id = GlobalUsage.Login_id;
                    p.logic = "GEN_ORDER";p.order_no = order_no;
                    p.login_id = GlobalUsage.Login_id;
                    dwr = ConfigWebAPI.CallAPI("api/purchase/PurhaseOrderForIndividualUnits", p);

                    if (dwr.message.Contains("Success"))
                    {
                        fillOrderDetail(order_no);
                    }
                    else
                    { RadMessageBox.Show(_result, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                }
                else if (command.ToUpper() == "CLOSE")
                {
                    p.unit_id = GlobalUsage.Unit_id; p.forunit = "N/A";
                    p.processAverage = "N"; p.orderFormonth = 0;
                    p.nProduct = 0; p.login_id = GlobalUsage.Login_id;
                    p.logic = "CLOSE_ORDER"; p.order_no = r.Cells[2].Value.ToString();
                    p.login_id = GlobalUsage.Login_id;
                    dwr = ConfigWebAPI.CallAPI("api/purchase/PurhaseOrderForIndividualUnits", p);
                    RadMessageBox.Show(_result, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info);
                }
                else if (command.ToUpper() == "VIEW DETAIL")
                { fillOrderDetail(r.Cells[2].Value.ToString()); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }
        private void fillOrderDetail(string order_no)
        {
            try
            {
                _order_no = order_no;
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id;p.order_no = order_no;p.logic = "Order_distrInfo";p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderAnalysis", p);
                gridOrderDetail.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { }finally { Cursor.Current = Cursors.Default;}
        }
        private void gridOrderUnit_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {

            if (e.RowElement.RowInfo.Cells[2].Value.ToString().Length > 5)
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.Honeydew;
            }

         

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            string fileName = f.SelectedPath + "\\" + _order_no.Replace("/", "_") + ".xls";
            Cursor.Current = Cursors.WaitCursor;
            ExportToExcelML exporter = new ExportToExcelML(this.gridOrderDetail);
            exporter.ExportVisualSettings = true;
            //exporter.SheetMaxRows = ExcelMaxRows._1048576;
            exporter.RunExport(fileName);
            Cursor.Current = Cursors.Default;
        }

    }
}
