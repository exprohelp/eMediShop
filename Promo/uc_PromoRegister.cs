using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.Promo
{
    public partial class uc_PromoRegister : UserControl
    {
        string _result = string.Empty;
        public uc_PromoRegister()
        {
            InitializeComponent();
        }

        private void rbtn_Retrive_Click(object sender, EventArgs e)
        {
            Cursor.Current=Cursors.WaitCursor;
            try
            {
                pm_promoQueries p = new pm_promoQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "Register";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailPromoQueries", p);
                rgv_info.DataSource= dwr.result.Tables[0];
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();
            string fileName = f.SelectedPath + "\\promoProducts.xls";
            Cursor.Current = Cursors.WaitCursor;
            Telerik.WinControls.UI.Export.ExportToExcelML exporter = new Telerik.WinControls.UI.Export.ExportToExcelML(this.rgv_info);
            exporter.ExportVisualSettings = true;
            //exporter.SheetMaxRows = ExcelMaxRows._1048576;
            exporter.RunExport(fileName);
            Cursor.Current = Cursors.Default;
        }

        private void rgv_info_CommandCellClick(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.GridViewRowInfo r = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).RowInfo;
            try
            {
                string masterkeyid = r.Cells["Master Key"].Value.ToString();
                pm_promoQueries p = new pm_promoQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Disc_per = 0;
                p.master_key_id = masterkeyid; p.input_date = DateTime.Now.ToString("yyyy/MM/dd");
                p.Logic = "Cancel";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/InsertPromoData", p);
                if (!_result.Contains("Success"))
                    MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    r.Delete();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
