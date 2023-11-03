using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;

namespace eMediShop.Hospital
{
    public partial class ucSearchInHospitalCart : UserControl
    {
        public ucSearchInHospitalCart()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("execute pHospitalCart_Queries '" + GlobalUsage.Unit_id + "' ,'storeid','CartName','SearchInCart','" + rtb_Search.Text + "','N/A'", "ChandanPharmacy_Live");
                rgvInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
