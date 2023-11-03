using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Server;
using Telerik.WinControls;

namespace eMediShop.forms.Product
{
    public partial class ucBatchExpMrpCorrection : UserControl
    {
        string _ExpDate = "";
        DataSet _ds = new DataSet();
        string _result = string.Empty;
        string _ItemId = string.Empty;
        decimal _npr = 0;
        string _MasterKey = string.Empty;

        public ucBatchExpMrpCorrection()
        {
            InitializeComponent();
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtMedName.Text.Length > 2)
            {
                DataSet ds = new DataSet();

                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.prm_1 = txtMedName.Text; p.prm_2 = "N/A";
                    p.prm_3 = "N/A"; p.Logic = "ItemForCorrections"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
                   
                    rgv_items.DataSource = dwr.result.Tables[0];

                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }

        }
        private void FillMasterKey_Info()
        {
            Cursor.Current = Cursors.WaitCursor;
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.prm_1 = _ItemId; p.prm_2 = "N/A";
            p.prm_3 = "N/A"; p.Logic = "mekyCorData"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
            rgv_info.DataSource = dwr.result.Tables[0];
            Cursor.Current = Cursors.Default;
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Confirm To Modify (Y/N) ?", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    _ExpDate = getExpDate(txtExpDate.Text);
                    _ExpDate = _ExpDate.Replace('-', '/');
                    if (Convert.ToDecimal(txtMRP.Text) > (_npr + (_npr * (10 / 100))))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        //Central Correction
                        pm_sales p = new pm_sales();
                        p.master_key_id = _MasterKey; p.batch_no = txtBatch.Text; p.exp_date = _ExpDate;
                        p.pack_type = "-"; p.Pack_Qty = 0;
                        p.Mrp = Convert.ToDecimal(txtMRP.Text); p.npr = 0; p.item_id = "-"; p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ModifyMasterKeyInfo", p);
                        //Local   Correction
                        if (_result == "Modification done.")
                        {
                            Masterkey_Update(out _result, GlobalUsage.Unit_id, _MasterKey, txtBatch.Text, _ExpDate, Convert.ToDecimal(txtMRP.Text));
                        }
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(_result);
                    }
                    else
                        MessageBox.Show("This Mrp is not Allowed ");
                }
            }
            catch (SqlException ex) { MessageBox.Show(_result); }
        }
        public string Masterkey_Update(out string processInfo, string unit_id, string master_key_id, string batch_no, string exp_date, decimal mrp)
        {
            SqlConnection con = DBConnection.GetConnection(true, "eMediShop");
            SqlCommand cmd = new SqlCommand("pMasterkey_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 2500;
            cmd.Parameters.Add("@unit_id", SqlDbType.VarChar, 10).Value = unit_id;
            cmd.Parameters.Add("@master_key_id", SqlDbType.VarChar, 16).Value = master_key_id;
            cmd.Parameters.Add("@batch_no", SqlDbType.VarChar, 10).Value = batch_no;
            cmd.Parameters.Add("@exp_date", SqlDbType.VarChar, 10).Value = exp_date;
            cmd.Parameters.Add("@mrp", SqlDbType.Money).Value = mrp;
            cmd.Parameters.Add("@result", SqlDbType.VarChar, 10).Value = "";
            cmd.Parameters["@result"].Direction = ParameterDirection.InputOutput;
            try
            {
                cmd.ExecuteNonQuery();
                processInfo = (string)cmd.Parameters["@result"].Value.ToString();
            }
            catch (SqlException sqlEx)
            {
                processInfo = "Error Found   : " + sqlEx.Message;
            }
            finally { con.Close(); }
            return processInfo;
        }

        private void txtMedName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtMedName.Text.Length > 0)
            {
                rgv_items.Focus();
            }
        }
        private void txtExpDate_Leave(object sender, EventArgs e)
        {
            string date = getExpDate(txtExpDate.Text);
            DateTime xpDate_Permit = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01"));
            DateTime xpDate_input = Convert.ToDateTime(_ExpDate);
            TimeSpan ts = xpDate_input - xpDate_Permit;
            int mth = ts.Days / 30;
            if ((_ExpDate != "1900-01-01") && mth <= 3)
            {
                MessageBox.Show("Bellow 3 Month Expiry Not Allowed", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExpDate.Focus();
                return;
            }

            if (date != "Fail")
            {
                txtMRP.Focus();
            }
            else { txtExpDate.Focus(); txtExpDate.Select(); MessageBox.Show("Invalid Date", "ExPro Help"); return; }
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

        private void ucBatchExpMrpCorrection_Load(object sender, EventArgs e)
        {

        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {


                if (e.Row.Cells["sold_flag"].Value.ToString() == "Y")
                {
                    gbBlock.Enabled = false;
                    btnModify.Enabled = false;
                    btnSend.Enabled = true;
                }
                else
                {
                    gbBlock.Enabled = true;
                    btnModify.Enabled = false;
                    btnSend.Enabled = true;

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            if (e.Row.Cells[2].Value.ToString() != "01-00")
            {
                txtExpDate.Text = Convert.ToDateTime(e.Row.Cells[2].Value).ToString("MM-yy");
                string[] d = e.Row.Cells[2].Value.ToString().Replace('/', '-').Split('-');
                _ExpDate = d[2] + "-" + d[1] + "-01";
            }
            else
            { txtExpDate.Text = "-"; _ExpDate = "1900-01-01"; }


            txtBatch.Text = e.Row.Cells[1].Value.ToString();
            txtMRP.Text = Convert.ToDecimal(e.Row.Cells[5].Value).ToString("#####.00");
            _MasterKey = e.Row.Cells[0].Value.ToString();
            _npr = Convert.ToDecimal(e.Row.Cells[6].Value);
        }

        private void rgv_items_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            lblProduct.Text = e.Row.Cells[1].Value.ToString();
            _ItemId = e.Row.Cells[0].Value.ToString();
            FillMasterKey_Info();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string result = ""; string[] s;
            try
            {
                result = updateMasterKeyInfo(_MasterKey);
                #region After Transfer Do Process
                s = result.Split('|');
                switch (s[0].ToString())
                {
                    case "Passed":
                        MessageBox.Show("Successfully Inserted.", "ExPro Help");
                        txtInformation.Text = "";
                        btnSend.Enabled = false;
                        break;
                    case "Exist":
                        MessageBox.Show("Already Informed By Someone.", "ExPro Help");
                        btnSend.Enabled = false;
                        break;
                    case "Available":

                        break;
                    default:
                        MessageBox.Show(result.ToString(), "ExPro Result");
                        break;
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Result");
            }
            finally { Cursor.Current = Cursors.Default; }

        }
        private string updateMasterKeyInfo(string Master_key_id)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                p.master_key_id = Master_key_id;p.remarks = txtInformation.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/MkeyCorrection", p);
                _result = dwr.message;
                txtInformation.Text = "";
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

            return _result;
        }
    }
}
