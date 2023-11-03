using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;
using CsvHelper;
using System.Reflection;

namespace eMediShop.Imports
{
    public partial class ucImportCompanyOrderXL : UserControl
    {
        public ucImportCompanyOrderXL()
        {
            InitializeComponent();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                lblfilename.Text = openFileDialog1.SafeFileName;
                string filePath = openFileDialog1.FileName;
                string extension = Path.GetExtension(filePath);
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Read csv file to datagridview
                        var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                        var csv = new CsvReader(sr);
                        List<CompOrders> objList = csv.GetRecords<CompOrders>().ToList();
                        rgv_info.DataSource = objList;
                        DataTable dt = Config.GenericToDataTable(objList);
                        DataSet ds = new DataSet();
                        ds.Tables.Add(dt);
                        pm_PurchaseOrders p = new pm_PurchaseOrders();
                        p.unit_id = GlobalUsage.Unit_id;
                        p.ds = ds;p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderForCompany2", p);
                        RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                }


            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
  
    public class CompOrders
    {
        public string item_id { get; set; }
        public string itemname { get; set; }
        public decimal ordqty { get; set; }
    }
}
