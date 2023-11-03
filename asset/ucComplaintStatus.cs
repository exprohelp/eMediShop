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
    public partial class ucComplaintStatus : UserControl
    {
        string _MainUnitId = string.Empty;
        DataSet _ds = new DataSet();
        public ucComplaintStatus()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            try
            {
                _ds = GlobalUsage.pharmacy_proxy.getComplaintCommunication(txtEqpNo.Text);
                dgAsset.DataSource = _ds.Tables[0];
                if (_ds.Tables[0].Rows[0]["status_ok"].ToString().ToUpper() == "Y")
                    tab2LblStatus.Text = "Completed";
                else
                    tab2LblStatus.Text = "Pending";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BTNcLOSE_Click(object sender, EventArgs e)
        {
          
        }
        private void tab2BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string result=string.Empty;
                if(tab2BtnSubmit.Text=="Submit")    
                    result = GlobalUsage.pharmacy_proxy.insertComplaintCommunication(txtEqpNo.Text, GlobalUsage.Login_id,txtComplaint.Text);
                else
                    result = GlobalUsage.pharmacy_proxy.closeComplaint(_MainUnitId, txtEqpNo.Text);

                MessageBox.Show(result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tab2BtnSubmit.Text = "Close";
            else
                tab2BtnSubmit.Text = "Submit";
        }

    }
}
