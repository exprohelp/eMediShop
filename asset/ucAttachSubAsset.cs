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
    public partial class ucAttachSubAsset : UserControl
    {
        string _MainUnitId = string.Empty;
        DataSet _ds = new DataSet();
        public ucAttachSubAsset()
        {
            InitializeComponent();
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
        private void tab4BtnFillAssetNo_Click(object sender, EventArgs e)
        {
            try
            {
                tab4ddlMainAssetNo.Text = "";
                tab4ddlMainAssetNo.Items.Clear();
                DataSet ds = GlobalUsage.pharmacy_proxy.fillMainAssetNoAtUnitAssetCatWise(((AddValue)ddlMainAsset.SelectedItem).Value + '$' + _MainUnitId);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    tab4ddlMainAssetNo.Items.Add(new AddValue(ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][0].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ddlMainAsset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tab4btnShow_Click(object sender, EventArgs e)
        {
   
            StringBuilder s = new StringBuilder();
            DataSet ds = GlobalUsage.pharmacy_proxy.getAssetAndSubAsset(((AddValue)tab4ddlMainAssetNo.SelectedItem).Value);
            dgAsset.DataSource = ds.Tables[0];
            DataSet subAsset = GlobalUsage.pharmacy_proxy.fillSubAsset(((AddValue)ddlMainAsset.SelectedItem).Value);
            try
            {
                for (int i = 0; i < subAsset.Tables[0].Rows.Count; i++)
                {
                    tab4ddlSubAsset.Items.Add(new AddValue(subAsset.Tables[0].Rows[i][0].ToString(), subAsset.Tables[0].Rows[i][1].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab4btnGo_Click(object sender, EventArgs e)
        {
            DataSet subAsset = GlobalUsage.pharmacy_proxy.getAssetNoToAttach(((AddValue)ddlMainAsset.SelectedItem).Value, ((AddValue)tab4ddlSubAsset.SelectedItem).Value, _MainUnitId);
            try
            {
                for (int i = 0; i < subAsset.Tables[0].Rows.Count; i++)
                {
                    tab4ddlAssetNoToAttach.Items.Add(new AddValue(subAsset.Tables[0].Rows[i][0].ToString(), subAsset.Tables[0].Rows[i][1].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tab4BtnAttach_Click(object sender, EventArgs e)
        {
            try
            {
                string result = GlobalUsage.pharmacy_proxy.attachAssetToMainAsset(Convert.ToInt32(((AddValue)tab4ddlAssetNoToAttach.SelectedItem).Value), tab4ddlMainAssetNo.Text, ((AddValue)tab4ddlAssetNoToAttach.SelectedItem).NewDescription);
                MessageBox.Show(result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
