using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Telerik.WinControls;

namespace eMediShop.Imports
{
    public partial class ImportTrfIdsFromOldSystem : Telerik.WinControls.UI.RadForm
    {
        public ImportTrfIdsFromOldSystem()
        {
            InitializeComponent();
        }

        private void ImportTrfIdsFromOldSystem_Load(object sender, EventArgs e)
        {
            string qry = "select trf_id from eMediCentral.dbo.trf_master t where trf_to='" + GlobalUsage.Unit_id + "' and trf_from<>'" + GlobalUsage.Unit_id + "' and ImportFlag='N'";
            string _jsonString = GlobalUsage.pwcf.GetQueryResult_JSON(qry, "eMediCentral");
            var table = JsonConvert.DeserializeObject<DataTable>(_jsonString);
            rgv_trfids.DataSource = table;
        }

        private void rgv_trfids_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //GlobalUsage.pwc1f.QueryExecute("execute pImport_FromOldSoftware '"+e.Row.Cells[0].Value.ToString()+"','Stock Transfer'");
                rgv_trfids.CurrentRow.Delete();
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
