using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.Data;
namespace eMediShop.Substitute
{
   
    public partial class PrintSaltExistensce : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        string _order_no = string.Empty;
        public PrintSaltExistensce()
        {
            InitializeComponent();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
          
        }

        private void Gen_UnitOrder_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 185);
            try
            {
                //lv_Reports.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Login_id;p.Logic = "AllUnit";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries",p);
                gridUnitList.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { }
            Cursor.Current = Cursors.Default;
        }
     
        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            string fileName = f.SelectedPath + "\\Salt.xls";
            Cursor.Current = Cursors.WaitCursor;
            ExportToExcelML exporter = new ExportToExcelML(this.MasterTemplate);
            exporter.ExportVisualSettings = true;
            //exporter.SheetMaxRows = ExcelMaxRows._1048576;
            exporter.RunExport(fileName);
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            string fileName = f.SelectedPath + "\\Salt.xls";
            Cursor.Current = Cursors.WaitCursor;
            ExportToExcelML exporter = new ExportToExcelML(this.MasterTemplate);
            exporter.ExportVisualSettings = true;
            //exporter.SheetMaxRows = ExcelMaxRows._1048576;
            exporter.RunExport(fileName);
            Cursor.Current = Cursors.Default;
        }

        private void gridUnitList_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string order_no = string.Empty;
                Telerik.WinControls.UI.GridViewRowInfo r = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).RowInfo;
                string command = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).CommandButton.Text;
                if (command.ToUpper() == "PRINT")
                {
                    try

                    {
                        DataSet ds = new DataSet();
                        pm_SaltInfo p = new pm_SaltInfo();
                        p.item_id = "All"; p.logic = "ForHospital"; p.prm_1 = r.Cells[0].Value.ToString();
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
                        ds = dwr.result;
                        CrystalReportsPharmacy.Reports.CrSaltInfo rpt = new CrystalReportsPharmacy.Reports.CrSaltInfo();
                        rpt.Database.Tables["salt_info"].SetDataSource(ds.Tables[0]);
                        rpt.SetParameterValue("Unit_Name", "Unit Name : " + r.Cells[1].Value.ToString());
                        //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "d:\\MedicineHelpList.pdf");
                        rpt.PrintToPrinter(1, false, 1, 0);
                        rpt.Dispose();
                    }
                    catch (Exception ex) { _result = ex.Message; }
                }
                else if (command.ToUpper() == "VIEW")
                {
                    try
                    {
                        pm_SaltInfo p = new pm_SaltInfo();
                        p.item_id = "All"; p.logic = "ForHospital"; p.prm_1 = r.Cells[0].Value.ToString();
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
                        MasterTemplate.DataSource = dwr.result.Tables[0];
                    }
                    catch (Exception ex) { _result = ex.Message; }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
