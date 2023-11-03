using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
namespace eMediShop.forms.Product
{
    public partial class ucChangeLocation : UserControl
    {
        DataSet _DS = new DataSet(); string _result = string.Empty;
        string _ItemId = "";
        string _ShelfNo = "";
        public ucChangeLocation()
        {
            InitializeComponent();
        }
        private void txtNewLocation_TextChanged(object sender, EventArgs e)
        {

        }
        private void ucChangeLocation_Load(object sender, EventArgs e)
        {

        }

        private void SwapShelfNumber(string newself_no)
        {
            try
            {
                try
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;

                    datasetWithResult dwr = new datasetWithResult();

                    if (chkRackSwap.Checked)
                    {
                        p.Logic = "itemLocation:RackSwap"; p.prm_1 = txtNewLocation.Text; p.prm_2 = txtOldLocation.Text;
                        p.tran_id = "-";
                        dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    }
                    else
                    {
                        p.Logic = "itemLocation:Change"; p.prm_1 = txtNewLocation.Text; p.prm_2 = "-";
                        p.tran_id = _ItemId; dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                        dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    }

                    MessageBox.Show("Swaped successfully  " + txtOldLocation.Text + " To " + txtNewLocation.Text + " ", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rgv_product.CurrentRow.Delete();
                }
                catch (Exception ex)
                { MessageBox.Show("Swaped successfully  " + txtOldLocation.Text + " To " + txtNewLocation.Text + " "); }
                Cursor.Current = Cursors.Default;
                chkRackSwap.Checked = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_search.Checked)
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "SearchProduct"; p.prm_1 = txtProduct.Text;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    _DS = dwr.result;
                }
                else
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "All-Product"; p.prm_1 = txtProduct.Text;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    _DS = dwr.result;
                }
                rgv_product.DataSource = _DS.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtNewLocation.Focus();
        }
        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void txtNewLocation_Enter(object sender, EventArgs e)
        {
            txtNewLocation.SelectAll();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SwapShelfNumber(txtNewLocation.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "itemLocation:ChangeNull"; p.prm_1 = "N/A";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rb_loadAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_loadAll.Checked)
                {
                    txtProduct.Enabled = false;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "All-Product"; p.prm_1 = "All-Product"; p.prm_2 = "Whole";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    _DS = dwr.result;
                    rgv_product.DataSource = _DS.Tables[0];
                }
                else
                    txtProduct.Enabled = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void rb_search_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_search.Checked)
            {
                txtProduct.Enabled = true;

            }
            else
                txtProduct.Enabled = false;
        }

        private void rgv_product_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _ItemId = e.Row.Cells["item_id"].Value.ToString();
            txtOldLocation.Text = e.Row.Cells["location"].Value.ToString();
            gbinfo.Text = e.Row.Cells["item_name"].Value.ToString() + "[" + e.Row.Cells["item_id"].Value.ToString() + "]";
            txtNewLocation.Focus();
        }
    }
}
