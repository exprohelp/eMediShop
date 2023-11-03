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
    public partial class ucTransferAsset : UserControl
    {
        string _MainUnitId = string.Empty;
        public ucTransferAsset()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataSet ds = GlobalUsage.pharmacy_proxy.getAssetDetByEqpNo(txtEqpNo.Text, _MainUnitId);
            dgAsset.DataSource = ds.Tables[0];
            tab6ddlTrfType.SelectedIndex = 0;
            DataSet _ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("exec pGetUnitList 'All'", "Assets_data");
            foreach (DataRow dr in _ds.Tables[0].Rows)
            {
                tab6DdlUnit.Items.Add(new AddValue(dr["unit_code"].ToString(), dr["unit_info"].ToString()));
            }
            tab6DdlUnit.SelectedIndex = 0;

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

        private void tab6BtnTrf_Click(object sender, EventArgs e)
        {
            tab6BtnTrf.Enabled = false;
            string result = "";
            string trfType = "T";
            if (tab6ddlTrfType.SelectedItem.ToString() == "Permanent")
                trfType = "P";
            else
                trfType = "T";
            //GlobalUsage.pharmacy_proxy.TransferAsset(out result, _MainUnitId, ((AddValue)tab6DdlUnit.SelectedItem).Value, GlobalUsage.Login_id,txtEqpNo.Text, trfType, System.DateTime.Today.ToString("yyyy/MM/dd"));
            //MessageBox.Show(result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      
    }
}
