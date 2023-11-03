using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.Product
{
    public partial class ucMkeyCorrection : UserControl
    {
        string _result = string.Empty; decimal _stockQty = 0;
        string _MasterKey = string.Empty; string _ExpDate = string.Empty;
        string _ItemId = string.Empty;
        string _ItemName = string.Empty;
        ReplaceProductPopUp obj;
        public ucMkeyCorrection()
        {
            InitializeComponent();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "MasterKeyCorrList"; p.prm_1 = "N/A";p.prm_2 = "N/A";p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                rgv_editkey.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.WaitCursor;
        }

        private void GetMkeyDetail(string master_key_id)
        {
            Cursor.Current = Cursors.WaitCursor;
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "InfoToCorrect"; p.prm_1 = master_key_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
            DataSet ds = dwr.result;
            rgv_info.DataSource = ds.Tables[0];
            if (ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
            {
                _ItemId = ds.Tables[1].Rows[0]["Item_id"].ToString();
                _ItemName = ds.Tables[1].Rows[0]["item_name"].ToString();
                gbInfo.Text = "[" + ds.Tables[1].Rows[0]["item_name"].ToString().TrimEnd() + "]";
                txtBatch.Text = ds.Tables[1].Rows[0]["BATCH_NO"].ToString();
                txtMRP.Text = Convert.ToDecimal(ds.Tables[1].Rows[0]["mrp"]).ToString("##.00");
                txtPackQty.Text = ds.Tables[1].Rows[0]["pack_qty"].ToString();
                txtPackType.Text = ds.Tables[1].Rows[0]["pack_type"].ToString();
                if (Convert.ToDateTime(ds.Tables[0].Rows[0]["exp_date"]).Year != 1900)
                    txtExpDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["exp_date"]).ToString("MM-yy");
                else
                    txtExpDate.Text = "-";

            }
            Cursor.Current = Cursors.WaitCursor;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (MessageBox.Show("Do You Confirm to update (Y/N) ? ", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                try
                {
                    string _ExpDate = getExpDate(txtExpDate.Text);
                    pm_sales p = new pm_sales();
                    p.master_key_id = _MasterKey; p.batch_no = txtBatch.Text; p.exp_date = _ExpDate;
                    p.pack_type = txtPackType.Text; p.Pack_Qty = Convert.ToInt32(txtPackQty.Text);
                    p.Mrp = Convert.ToDecimal(txtMRP.Text); p.npr = 0; p.item_id = _ItemId; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ModifyMasterKeyInfo", p);
      
                    if (!dwr.message.Contains("Successfully"))
                        MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        rgv_info.DataSource = new string[] { };
                        GetMkeyDetail(_MasterKey);
                        rgv_editkey.CurrentRow.Delete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(_result + ", " + ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void txtExpDate_Leave(object sender, EventArgs e)
        {
            string _ExpDate = getExpDate(txtExpDate.Text);
            DateTime xpDate_Permit = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/01"));
            DateTime xpDate_input = Convert.ToDateTime(_ExpDate);
            TimeSpan ts = xpDate_input - xpDate_Permit;
            int mth = ts.Days / 30;
            //if (_ExpDate != "1900/01/01" && mth <= 6)
            //{ 
            //    MessageBox.Show("Bellow 6 Month Expiry Not Allowed", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtExpDate.Focus();
            //    return;
            //}

        }
        protected string getExpDate(string txtDate)
        {
            if (txtDate.Length == 0)
            { MessageBox.Show("Enter date", "ExPro Help"); return "Fail"; }
            if (txtDate.Length > 0)
            {
                if (txtDate == "-")
                { _ExpDate = "1900-01-01"; return _ExpDate; }

                int dasCaount = 0;
                char[] Char1 = txtDate.ToCharArray(0, txtDate.Length);
                foreach (char s in Char1)
                {
                    if (s == '-') { dasCaount = dasCaount + 1; }
                }
                if (dasCaount == 0 || dasCaount > 1)
                { return "Fail"; }

                if (txtDate.Length > 5 || txtDate.Length < 5)
                { return "Fail"; }
                string[] t = txtDate.Split('-');
                if (t[0].Length > 2 || t[0].Length < 2)
                { return "Fail"; }
                if (t[1].Length > 2 || t[1].Length < 2)
                { return "Fail"; }
                try { if (Convert.ToInt32(t[0]) > 12) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                try { if (Convert.ToInt32(t[1]) > 1000) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                string century = DateTime.Now.ToString("yyyy").Substring(0, 2);
                _ExpDate = century + t[1] + '-' + t[0] + '-' + "01";
            }
            return _ExpDate;
        }

        private void txtExpDate_Enter(object sender, EventArgs e)
        {
            txtExpDate.SelectAll();
        }
        private void txtBatch_Enter(object sender, EventArgs e)
        {
            txtBatch.SelectAll();
        }
        private void txtPackQty_Enter(object sender, EventArgs e)
        {
            txtPackQty.SelectAll();
        }
        private void txtMRP_Enter(object sender, EventArgs e)
        {
            txtMRP.SelectAll();
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            obj = new ReplaceProductPopUp(_ItemName);
            obj.SearchUpdated += new SearchUpdateEventHandler(ReplaceItemIdByMasterKey);
            obj.Show();
        }
        private void ReplaceItemIdByMasterKey(object sender, SearchUpdatedEventArgs e)
        {
            string _ExpDate = getExpDate(txtExpDate.Text);
            pm_sales p = new pm_sales();
            p.master_key_id = _MasterKey;p.batch_no = txtBatch.Text;p.exp_date = _ExpDate;
            p.pack_type = txtPackType.Text;p.Pack_Qty = Convert.ToInt32(txtPackQty.Text);
            p.Mrp = Convert.ToDecimal(txtMRP.Text);p.npr = 0;p.item_id = e.ProductID;p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ModifyMasterKeyInfo", p);
            if (!dwr.message.Contains("Successfully"))
                MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                GetMkeyDetail(_MasterKey);
                rgv_editkey.CurrentRow.Delete();
            }
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _MasterKey = e.Row.Cells["master_key_id"].Value.ToString();
                GetMkeyDetail(_MasterKey);


            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void MasterTemplate_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
