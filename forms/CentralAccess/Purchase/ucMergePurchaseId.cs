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

namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class ucMergePurchaseId : UserControl
    {
        public ucMergePurchaseId()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = txtPreviousId.Text; p.logic = "PurchaseBillDetail"; p.prm_1 = "-"; p.prm_2 = "";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                rgv_Previous.DataSource=dwr.result.Tables[0];
                rgv_Previous.Text = "Purch Id:" + dwr.result.Tables[1].Rows[0]["purch_id"].ToString() + ", Vendor Name:" + dwr.result.Tables[1].Rows[0]["vendor_name"].ToString();

                if (rgv_current.Rows.Count > 0 && rgv_Previous.Rows.Count > 0)
                    btnMerge.Enabled = true;
                else
                    btnMerge.Enabled = false;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            try
            {
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = txtCurrentID.Text; p.logic = "PurchaseBillDetail"; p.prm_1 = "-"; p.prm_2 = "";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                rgv_current.DataSource = dwr.result.Tables[0];
                rgv_current.Text = "Purch Id:" + dwr.result.Tables[1].Rows[0]["purch_id"].ToString() + ", Vendor Name:" + dwr.result.Tables[1].Rows[0]["vendor_name"].ToString();

                if (rgv_current.Rows.Count > 0 && rgv_Previous.Rows.Count > 0)
                    btnMerge.Enabled = true;
                else
                    btnMerge.Enabled = false;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }

        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                pm_MergePurchaseIDs p = new pm_MergePurchaseIDs();
                p.unit_id = GlobalUsage.Unit_id; p.OldPurchId = txtPreviousId.Text;p.NewPurchId = txtCurrentID.Text;p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/MergePurchaseIDs", p);

                if(dwr.message.Contains("Successfully"))
                {
                    rgv_Previous.DataSource = new string[] { };
                    rgv_current.DataSource = new string[] { };
                }
                RadMessageBox.Show(dwr.message.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                if (rgv_current.Rows.Count > 0 && rgv_Previous.Rows.Count > 0)
                    btnMerge.Enabled = true;
                else
                    btnMerge.Enabled = false;

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }

        }
    }
}
