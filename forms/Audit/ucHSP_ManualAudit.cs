using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.Audit
{
    public partial class ucHSP_ManualAudit : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty;
        string filePath = string.Empty;
        public ucHSP_ManualAudit()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            btnProcess.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;
                p.dtFrom =rdp_from.Value.ToString("yyyyMMdd"); p.dtTo = rdp_to.Value.ToString("yyyyMMdd");
                p.Logic = "High_Sales";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/ProductHighSelling", p);
                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
            btnProcess.Enabled = true;
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            if (_ds.Tables[0].Rows.Count > 0)
            {
                try
                {

                    filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    filePath += "\\ManualAudit_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf";
                    CrystalReportsPharmacy.eMediShop.HighSellingProducts rpt = new CrystalReportsPharmacy.eMediShop.HighSellingProducts();
                    rpt.Database.Tables["HighSelling"].SetDataSource(_ds.Tables[0]);
                    rpt.SetParameterValue("Unit_name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("unit_Address", GlobalUsage.UnitAddress);
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, filePath);
                    //rpt.PrintToPrinter(1, false, 1, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else { MessageBox.Show("Record Not Found"); }
        }

        private void ucHSP_ManualAudit_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }
    }
}
