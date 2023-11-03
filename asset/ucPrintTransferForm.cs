using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.Asset
{
    public partial class ucPrintTransferForm : UserControl
    {
        string _MainUnitId = string.Empty;
        public ucPrintTransferForm()
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
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pGetAssetTransferReport 0,'" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','UnitList','" + GlobalUsage.Unit_id + "' ", "Assets_data");
                dgAsset.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
       private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
       {
           PrintTransferForm(dgAsset.CurrentRow.Cells[0].Value.ToString());
       }
       private void PrintTransferForm(string auto_id)
       {
           try
           {
               Cursor.Current = Cursors.WaitCursor;
               CrystalReportsPharmacy.eMediShop.AssetTrfReport crt = new CrystalReportsPharmacy.eMediShop.AssetTrfReport();
               DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pGetAssetTransferReport " + auto_id + ",'" + dtFrom.Value.ToString("yyyy/MM/dd") + "','" + dtTo.Value.ToString("yyyy/MM/dd") + "','DownloadInfo','" + GlobalUsage.Unit_id + "' ", "Assets_data");
               DataRow dr = ds.Tables[0].Rows[0];
               object[] objvalue = { dr["Trf_to"], dr["auto_id"], dr["trf_from"], dr["from_address"], dr["to_address"], dr["eq_Name"], dr["eq_no"], dr["trf_type"], dr["serial_no"], dr["trf_date"] };
               if (objvalue != null)
               {
                   for (int i = 0; i < objvalue.Length; i++)
                   {
                       crt.SetParameterValue(i, objvalue[i].ToString());
                   }
               }
               crt.PrintToPrinter(1, false, 1, 1);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
    }
}
