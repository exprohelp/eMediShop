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
    public partial class ucLodgeComplaint : UserControl
    {
        string _MainUnitId = string.Empty;
        public ucLodgeComplaint()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
               DataSet ds = GlobalUsage.pharmacy_proxy.getAssetDetByEqpNo(txtEqpNo.Text, _MainUnitId);
               dgAsset.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = GlobalUsage.pharmacy_proxy.insertIntoComplaints(_MainUnitId, GlobalUsage.Login_id, txtEqpNo.Text, txtComplaint.Text);
                MessageBox.Show(result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
