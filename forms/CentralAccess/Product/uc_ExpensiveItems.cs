using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
    public partial class uc_ExpensiveItems : UserControl
    {
        string _result = string.Empty;
        public uc_ExpensiveItems()
        {
            InitializeComponent();
        }

        private void rbtn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.prm_1 = "-";p.Logic = "Expensive";
                p.prm_2 = comboBox1.Text; p.prm_3 = rtxt_value.Text; p.login_id = GlobalUsage.Login_id;

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/ProductExpensiveItems", p);
                ds = dwr.result;
                rgv_info.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rbtn_XL_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Telerik.WinControls.UI.Export.ExportToExcelML exporter = new Telerik.WinControls.UI.Export.ExportToExcelML(this.rgv_info);
                exporter.SheetName = "ExpensiveItems";
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MIS";
                if (!System.IO.Directory.Exists(mydocpath))
                {
                    System.IO.Directory.CreateDirectory(mydocpath);
                }
                string fileName = mydocpath + "\\ExpensiveItems.xls";
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            SingleProductAnalysisFromServer obj = new SingleProductAnalysisFromServer(e.Row.Cells["Item Id"].Value.ToString());
            obj.Show();
        }
    }
}
