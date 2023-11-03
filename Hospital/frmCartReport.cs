using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;

namespace eMediShop.Hospital
{
    public partial class frmCartReport : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();string _cartname = string.Empty;
        public frmCartReport()
        {
            InitializeComponent();
        }

        private void btnFillCartName_Click(object sender, EventArgs e)
        {
            try
            {
               _ds= GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pHospitalCart_Queries '"+GlobalUsage.Unit_id+"' ,'storeid','CartName','CartList','N/A','N/A'", "ChandanPharmacy_Live");
                rgvCartName.DataSource = _ds.Tables[0];
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnxl_Click(object sender, EventArgs e)
        {

           
            ExportToExcelML exporter = new ExportToExcelML(this.rgvCartInfo);
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            exporter.ExportVisualSettings = true;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                exporter.RunExport(fd.SelectedPath + "\\"+_cartname.Replace('/','_')+".xls");
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvCartName_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                _ds=GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pHospitalcart_Queries '" + GlobalUsage.Unit_id + "' ,'"+e.Row.Cells["hosp_store_id"].Value.ToString()+"','"+ e.Row.Cells["cart_name"].Value.ToString() + "','StockSummary','N/A','N/A'", "ChandanPharmacy_Live");
                rgvCartInfo.DataSource = _ds.Tables[0];
                _cartname = e.Row.Cells["cart_name"].Value.ToString();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
