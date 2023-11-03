using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using ExPro.Client;

namespace eMediShop.warehouse
{
    public partial class uc_ExpiryReceiving : UserControl
    {
        string search = string.Empty;
        string _result = string.Empty; string _selectedUnitID = string.Empty; string _selectedUnitLedgerID = string.Empty; string _masterkeyid = string.Empty;
        string flag; string _trfID = string.Empty; string _qry = string.Empty;
        int GlbrowCount;
        public uc_ExpiryReceiving()
        {
            InitializeComponent();
        }

        private void uc_ExpiryReceiving_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 64, 64);
            flag = "FirstTime";
            cmbUnitName.BeginUpdate();
            _result = DateTime.Now.Millisecond.ToString();


            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "EGR:UnitsInfo"; p.prm_3 = GlobalUsage.Comp_id; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);


            cm2 p2 = new cm2();
            p2.unit_id = GlobalUsage.Unit_id; p2.Logic = "EGR:VendorToReturnGoods";
            datasetWithResult dwr2 = ConfigWebAPI.CallAPI("api/purchase/grQueries", p2);

            DataSet dsVendor = dwr2.result;
            rddl_vendor.Items.AddRange(Config.FillTelrikCombo(dsVendor.Tables[0]));
            rddl_vendor.SelectedIndex = 0;
            this.cmbUnitName.SelectedIndexChanged -= new System.EventHandler(this.cmbUnitName_SelectedIndexChanged);

            IEnumerable<DataRow> shops =
            from c in dwr.result.Tables[0].AsEnumerable()
            select c;



            DataTable boundTable = shops.CopyToDataTable<DataRow>();
            cmbUnitName.Items.Clear();
            cmbUnitName.Items.AddRange(Config.FillCombo(boundTable));
            cmbUnitName.SelectedIndex = 0;
            cmbUnitName.EndUpdate();
            cmbTrfId.Focus();

            this.cmbUnitName.SelectedIndexChanged += new System.EventHandler(this.cmbUnitName_SelectedIndexChanged);
        }

        private void cmbUnitName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                Fill_TransferIds();
            }
        }
        private void Fill_TransferIds()
        {
            #region Check Transfer Ids
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (((AddValue)cmbUnitName.SelectedItem).Value != "Select")
                {
                    string[] code = ((AddValue)cmbUnitName.SelectedItem).Value.Split('$');//ld_code+sh_code
                    _selectedUnitLedgerID = code[0];
                    _selectedUnitID = code[1];
                    _result = DateTime.Now.Millisecond.ToString();
                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "OT-EXPIRY-IDS"; p.prm_1 = _selectedUnitID;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                    DataSet ds = dwr.result;
                    cmbTrfId.Items.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        btnGetData.Enabled = true;
                        this.cmbTrfId.SelectedIndexChanged -= new System.EventHandler(this.cmbTrfId_SelectedIndexChanged);
                        IEnumerable<DataRow> trfids =
                        from c in ds.Tables[0].AsEnumerable()
                        select c;



                        DataTable boundTable = trfids.CopyToDataTable<DataRow>();
                        cmbTrfId.Items.AddRange(Config.FillCombo(boundTable));
                        //cmbTrfId.Text = "Select";
                        cmbTrfId.SelectedIndex = 0;
                        this.cmbTrfId.SelectedIndexChanged += new System.EventHandler(this.cmbTrfId_SelectedIndexChanged);
                        cmbTrfId.Focus();
                        cmbTrfId.Enabled = true;
                        cmbUnitName.Enabled = false;
                    }
                    else
                    {
                        btnGetData.Enabled = false;
                        cmbTrfId.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            #endregion
        }
        private void cmbTrfId_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void FillListView()
        {
            string groupby = "No";
            if (chkSortOrder.Checked)
                groupby = "Yes";
            else
                groupby = "No";
            pm_Transfer p = new pm_Transfer();
            p.unit_id = _selectedUnitID; p.transfer_id = _trfID; p.prm_1 = groupby;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ExpiryWHImportids", p);
            DataSet ds = new DataSet(); ds = dwr.result;

            if (ds.Tables[0].Rows.Count > 0)
            {
                lv_info.Items.Clear();
                lv_info.BeginUpdate();
                #region lv_info Filling
                this.lv_info.ItemChecked -= new System.Windows.Forms.ItemCheckedEventHandler(this.lv_info_ItemChecked);
                string temp = string.Empty;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (temp != dr["ld_name"].ToString())
                    {
                        lv_info.Groups.Add(dr["ld_name"].ToString(), dr["ld_name"].ToString());
                        temp = dr["ld_name"].ToString();
                    }
                    ListViewItem lvi = new ListViewItem(dr["master_key_id"].ToString());
                    lvi.SubItems.Add(dr["item_name"].ToString());
                    lvi.SubItems.Add(dr["batch_no"].ToString());
                    lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["npr"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["quantity"]).ToString("###"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["rcpt_qty"]).ToString("###"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["gr_amount"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["gr_packs"]).ToString("###"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["damage_qty"]).ToString("###"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["damage_amount"]).ToString("##.00"));
                    lvi.SubItems.Add(dr["master_key_id"].ToString());
                    lvi.SubItems.Add(dr["trf_id"].ToString());
                    lvi.SubItems.Add(dr["unit_id"].ToString());
                    lvi.SubItems.Add(dr["pack_qty"].ToString());
                    lvi.SubItems.Add(dr["ld_name"].ToString());
                    lvi.SubItems.Add(dr["mfd_name"].ToString());

                    lvi.ForeColor = Color.Black;
                    if (Convert.ToDecimal(dr["quantity"]) != Convert.ToDecimal(dr["rcpt_qty"]))
                        lvi.ForeColor = Color.Red;
                    if (dr["chk_flag"].ToString().ToUpper() == "Y")
                        lvi.Checked = true;
                    if (chkSortOrder.Checked)
                        lvi.Group = lv_info.Groups[dr["ld_name"].ToString()];
                    lvi.Font = new System.Drawing.Font("Arial Narrow", 9, FontStyle.Italic);
                    lv_info.Items.Add(lvi);
                }

                lv_info.EndUpdate();
                this.lv_info.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_info_ItemChecked);
                #endregion
            }

        }

        private void lv_info_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                txtCorr.Text = e.Item.SubItems[6].Text;
                string chkFlag = string.Empty;
                if (e.Item.Checked)
                    chkFlag = "Y";
                else
                    chkFlag = "N";

                pm_Transfer p = new pm_Transfer();
                p.unit_id = e.Item.SubItems[14].Text;
                p.transfer_id = _trfID;
                p.master_key_id = e.Item.SubItems[12].Text.ToString();
                p.RcptQty = Convert.ToInt32(txtCorr.Text); p.CheckFlag = chkFlag; p.logic = "FlagGrStock";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/Expiry_WH_Flaging", p);

                txtCorr.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void lv_info_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblVendorName.Text = lv_info.FocusedItem.SubItems[16].Text;
        }

        private void lv_info_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyData < 65 || (int)e.KeyData > 90)
                search = "";
            if ((int)e.KeyData >= 65 && (int)e.KeyData <= 90)
                search += Convert.ToChar(e.KeyCode);
            else
                search = "";

            if (e.KeyCode == Keys.Enter)
            {
                lblVendorName.Text = lv_info.FocusedItem.SubItems[16].Text;
                lblModify.Text = lv_info.FocusedItem.SubItems[1].Text + "> Qty :";
                txtCorr.Text = lv_info.FocusedItem.SubItems[6].Text;
                txtCorr.Focus();
            }
            if (lv_info.Items.Count > 0 && ((int)e.KeyData >= 65 && (int)e.KeyData <= 117))
            {
                // ListViewItem foundItem= lv_info.FindItemWithText(search);
                //if (foundItem != null)
                //  lv_info.TopItem = foundItem;
                #region Searching
                lv_info.Items[lv_info.Items.Count - 1].EnsureVisible();
                lv_info.Items[lv_info.Items.Count - 1].Focused = true;
                for (int i = 0; i < lv_info.Items.Count; i++)
                {
                    lv_info.Items[i].Selected = false;
                    int l = search.Length;
                    if (l > lv_info.Items[i].SubItems[1].Text.Length)
                        l = lv_info.Items[i].SubItems[1].Text.Length;
                    if (lv_info.Items[i].SubItems[1].Text.Substring(0, l) == search)
                    {
                        lv_info.Items[i].Selected = true;
                        lv_info.Items[i].Focused = true;
                        lv_info.Items[i].EnsureVisible();
                        lv_info.TopItem = lv_info.Items[i];
                        break;
                    }
                }
                #endregion
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                #region Summary
                string result = "";
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "ExpiryIdSummary"; p.prm_1 = _trfID; p.prm_2 = _selectedUnitID;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                DataSet ds = dwr.result;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    result = ds.Tables[0].Rows[0]["damage"].ToString() + "#" + ds.Tables[0].Rows[0]["short"].ToString() + "#" + ds.Tables[0].Rows[0]["gr"].ToString();
                else
                    result = "0#0#0";
                string[] r = result.Split('#');
                lblTotalGR.Text = Convert.ToDecimal(Conversion.Val(r[0].ToString()) + Conversion.Val(r[1].ToString()) + Conversion.Val(r[2].ToString())).ToString("###.00");
                lblGr.Text = Convert.ToDecimal(r[2]).ToString("###.00");
                lblShort.Text = Convert.ToDecimal(r[1]).ToString("###.00");
                lblnr.Text = Convert.ToDecimal(r[0]).ToString("###.00");
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCorr_Enter(object sender, EventArgs e)
        {
            txtCorr.SelectAll();
        }

        private void txtCorr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                #region Process
                if (Convert.ToDecimal(lv_info.FocusedItem.SubItems[6].Text) >= Convert.ToDecimal(txtCorr.Text))
                {
                    lv_info.FocusedItem.SubItems[7].Text = txtCorr.Text;
                    if (Convert.ToDecimal(lv_info.FocusedItem.SubItems[6].Text) > Convert.ToDecimal(lv_info.FocusedItem.SubItems[7].Text))
                    {
                        try
                        {
                            pm_Transfer p = new pm_Transfer();
                            p.unit_id = lv_info.FocusedItem.SubItems[14].Text;
                            p.transfer_id = _trfID; p.master_key_id = lv_info.FocusedItem.SubItems[12].Text.ToString();
                            p.RcptQty = Convert.ToInt32(txtCorr.Text); p.CheckFlag = "Y"; p.logic = "FlagGrStock";
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/Expiry_WH_Flaging", p);
                            _result = dwr.message;

                            if (_result.Contains("Success"))
                            {
                                MessageBox.Show("Successfully Updated.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Fail To Update.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex) { MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                }
                else
                {
                    MessageBox.Show("Received Quantity Can Not Be More Then Send Quantity", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lv_info.Focus();
                #endregion
            }
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You Confirm To Close Id No. " + _trfID + " ? ", "Expro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    //Posting of Stock Transfer To Accounts
                    Cursor.Current = Cursors.WaitCursor;
                    _result = DateTime.Now.Millisecond.ToString();
                    pm_Transfer p = new pm_Transfer();
                    p.unit_id = GlobalUsage.Unit_id; p.transfer_id = _trfID; p.TrfUnit_AccountNo = _selectedUnitLedgerID;
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ExpiryWHCompleteUnitIDs", p);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cmbUnitName.Enabled = true;
        }

        private void cmbTrfId_SelectedIndexChanged(object sender, EventArgs e)
        {
            _trfID = ((AddValue)cmbTrfId.SelectedItem).Value;
        }

        private void cmbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_TransferIds();
        }

        private void rddl_vendor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lv_info_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            rgb_ChangeVendor.Text = "Change Vendor Against : " + e.Item.SubItems[1].Text + " [ " + e.Item.Text + " ]";
            _masterkeyid = e.Item.Text;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            lv_info.Items.Clear();
            try
            {
                #region Fill Information of Selected Id
                if (_trfID.Length > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _result = DateTime.Now.Millisecond.ToString();
                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "Expiry:CheckPosted"; p.prm_1 = _trfID; p.prm_2 = _selectedUnitID;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                    if (dwr.result.Tables[0].Rows.Count > 0)
                    {
                        if (dwr.result.Tables[0].Rows[0]["import_flag"].ToString() != "N")
                        { btn_Complete.Text = "Completed"; btn_Complete.Enabled = false; }
                        else
                        { btn_Complete.Text = "Complete"; btn_Complete.Enabled = true; }

                        FillListView();

                        lblTotalGR.Text = lv_info.Items.Count.ToString();
                        lv_info.Focus();
                        lv_info.FocusedItem.Selected = true;
                    }

                }
                else
                {
                    MessageBox.Show("Transfer Id Can Not Be Blank", "ExPro Help");
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Transfer Ids are Not Processed.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (rddl_vendor.SelectedItem.Text != "Select")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string[] x = rddl_vendor.SelectedValue.ToString().Split('|');
                    pm_Transfer p = new pm_Transfer(); p.unit_id = GlobalUsage.Unit_id;
                    p.transfer_id = _trfID;
                    p.vendor_id = x[0].ToString(); p.party_account_no = x[1].ToString();
                    p.master_key_id = lv_info.FocusedItem.Text;
                    p.logic = "UpdateVendor";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/Expiry_WH_Flaging", p);
                    _result = dwr.message;
                    if (!_result.Contains("Success"))
                    {
                        MessageBox.Show("Error! Please Retry....", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            { MessageBox.Show("Select Vendor", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
