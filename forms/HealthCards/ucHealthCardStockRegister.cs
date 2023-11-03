using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.HealthCards
{
    public partial class ucHealthCardStockRegister : UserControl
    {
        string _result = string.Empty; DataSet _ds;
        public ucHealthCardStockRegister()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _ds = GlobalUsage.pharmacy_proxy.HealthCardQueries(out _result, GlobalUsage.Unit_id, "UnitCardStock", "1900/01/01", "1900/01/01", "N/A", "N/A", GlobalUsage.Login_id);
            rgv_cardInfo.DataSource=_ds.Tables[0];       
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btnxl_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "HealthCardStock.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgv_cardInfo);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;
                    //spreadExporter.SheetName = DateTime.Today.ToString("dd-MMM-yyyy");
                    spreadExporter.RunExport(dialog.FileName);
                }   
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
