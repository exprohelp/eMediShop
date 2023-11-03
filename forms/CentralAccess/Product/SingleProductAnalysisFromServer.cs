using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class SingleProductAnalysisFromServer : UserControl
    {
        string _result = string.Empty; string _itemid = string.Empty;
        public SingleProductAnalysisFromServer(string item_id)
        {
            _itemid = item_id;
            InitializeComponent();
        }

        private void SingleProductAnalysisFromServer_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = "SingleProduct";p.prm_1 = _itemid;p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/analysisqueries", p);
                DataSet ds = dwr.result;
                if(dwr.message.Contains("Success"))
                { 
                lblProduct.Text = "Product : " + ds.Tables[0].Rows[0]["item_name"].ToString();
                lblCompany.Text = "Company : " + ds.Tables[0].Rows[0]["mfd_name"].ToString();
                lblVendor.Text = "Vendor : " + ds.Tables[0].Rows[0]["vendor_name"].ToString().TrimEnd() + ", " + ds.Tables[0].Rows[0]["city"].ToString().TrimEnd();
                lblMRP.Text = "MRP : " + Convert.ToDecimal(ds.Tables[0].Rows[0]["mrp"]).ToString("#####.00");
                lblNPR.Text = "NPR : " + Convert.ToDecimal(ds.Tables[0].Rows[0]["npr"]).ToString("#####.00");
                lbl_DOP.Text = "Info : " + ds.Tables[0].Rows[0]["inv_no"].ToString();

                rgv_info.DataSource = ds.Tables[1];
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
