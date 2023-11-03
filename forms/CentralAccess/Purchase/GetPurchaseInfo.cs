using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using eMediShop.Pharmacy;
using Newtonsoft.Json;

namespace eMediShop
{
    public partial class GetPurchaseInfo : Telerik.WinControls.UI.RadForm
    {
        string _ItemId = string.Empty; string _result = string.Empty;string _jsonString = string.Empty;
        DataTable _dt = new DataTable();
        string _BatchNo = "N/A";
        int _Mth = -12;

        public GetPurchaseInfo()
        {
            InitializeComponent();
        }
        private void GetPurchaseInfo_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }
        private void txtMedName_TextChanged(object sender, EventArgs e)
        {
            _ItemId = "";
            if (txtMedName.Text.Length >2)
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "Search:InProduct"; p.prm_1 = txtMedName.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
              
                    lvProduct.Items.Clear();
                lvProduct.Visible = true;
                foreach (DataRow dr in dwr.result.Tables[0].Rows)
                {
                    lvProduct.Items.Add(dr["Item_id"].ToString());
                    lvProduct.Items[lvProduct.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                }
            }
        }
        private void txtMedName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lvProduct.Items.Count > 0)
                { lvProduct.Focus(); lvProduct.Items[0].Selected = true; }
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtBatch.Text = "N/A";
                txtBatch.Focus();
                txtBatch.SelectAll();
                lvProduct.Visible = false;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "Logic"; p.item_id = _ItemId;p.batch_no = _BatchNo;p.mth = _Mth;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseProductInfo", p);
                _dt = dwr.result.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillPurchaseSummery();
            progressBar1.Visible = false;
        }
        #region Purchase Information with Vendor
        private void FillPurchaseSummery()
        {
            if (_dt.Rows.Count > 0)
            {
                lv_Detail.Items.Clear();
                string temp = "XXX";
                if (_dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in _dt.Rows)
                    {
                        if (temp != dr["Vend_Info"].ToString())
                        {
                            lv_Detail.Groups.Add(dr["Vend_Info"].ToString(), dr["Vend_Info"].ToString());
                            temp = dr["Vend_Info"].ToString();
                        }
                        ListViewItem lvi = new ListViewItem(dr["inv_no"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MMM-yyyy"));
                        lvi.SubItems.Add(dr["batch_no"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd-MMM-yyyy"));
                        lvi.SubItems.Add(dr["pack_type"].ToString());
                        lvi.SubItems.Add(Convert.ToDecimal(dr["Mrp"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["ptr"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["npr"]).ToString("####.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["quantity"]).ToString("##.##"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["it_free"]).ToString("####.##"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["Tax"]).ToString("####.00"));
                        lvi.SubItems.Add(dr["order_no"].ToString());
                        lvi.SubItems.Add(dr["emp_name"].ToString());
                        lvi.Group = lv_Detail.Groups[dr["Vend_Info"].ToString()];
                        lv_Detail.Items.Add(lvi);
                    }
                }
            }
        }
        #endregion
        private void lvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lvProduct.Items.Count > 0)
                {
                    _ItemId = lvProduct.Items[lvProduct.FocusedItem.Index].Text;
                    txtMedName.TextChanged -= new EventHandler(this.txtMedName_TextChanged);
                    txtMedName.Text = lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[1].Text;
                    txtMedName.TextChanged += new EventHandler(this.txtMedName_TextChanged);
                    txtBatch.Text = "N/A";
                    txtBatch.Focus();
                    txtBatch.SelectAll();
                    lvProduct.Visible = false;
                }
            }

        }
        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMth.Focus();
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            { _BatchNo = txtBatch.Text; _Mth = Convert.ToInt32(txtMth.Text); progressBar1.Visible = true; backgroundWorker1.RunWorkerAsync(); }
            else
            { MessageBox.Show("Wait...."); }
        }
        private void txtMth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.Focus();
            }
        }
        private void txtMth_Leave(object sender, EventArgs e)
        {
            if (txtMth.Text.Length > 0)
            {
                if (Convert.ToInt32(txtMth.Text) > 0)
                { MessageBox.Show("Only negetive value is allowed"); txtMth.Text = "-12"; txtMth.Focus(); }
            }
        }

    }
}
