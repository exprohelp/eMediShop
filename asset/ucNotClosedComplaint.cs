using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;

namespace eMediShop.Asset
{
    public partial class ucNotClosedComplaint : UserControl
    {
        string _MainUnitId = string.Empty;
        public ucNotClosedComplaint()
        {
            InitializeComponent();
        }
        private void ucLodgeComplaint_Load(object sender, EventArgs e)
        {
           try
           {
                string qry = "";
                if (GlobalUsage.Unit_id.Length > 5)
                    qry = "select master_unit_id from shop_info where sh_code='" + GlobalUsage.Unit_id + "' ";
                else
                    qry = "select master_unit_id from ExDiagnostic..unit_master where unit_code='" + GlobalUsage.Unit_id + "' ";
                DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2(qry,"eMediCentral");
                _MainUnitId = ds.Tables[0].Rows[0]["master_unit_id"].ToString();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
       private void btnGetNotClosed_Click(object sender, EventArgs e)
       {
           fillComplaint();
       }
       private void fillComplaint()
       {
           try
           {
               Cursor.Current = Cursors.WaitCursor;
               DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("exec pAssetsList '" + _MainUnitId + "','PEND_COMPL','N/A'", "assets_data");
               dgAsset.DataSource = ds.Tables[0];
               Cursor.Current = Cursors.Default;
           }
           catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
       }

       private void button3_Click(object sender, EventArgs e)
       {

           Cursor.Current = Cursors.WaitCursor;
           ExportToExcelML exporter = new ExportToExcelML(this.dgAsset);
           exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
           exporter.ExportVisualSettings = true;
           try
           {
               FolderBrowserDialog fd = new FolderBrowserDialog();
               fd.ShowDialog();
               exporter.RunExport(fd.SelectedPath + "ComplaintList.xls");
           }
           catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
           Cursor.Current = Cursors.Default;
       }
    }
}
