using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eMediShop;
 public partial class ucAuditStock : UserControl
    {
        string _item_id = ""; string _item_name = ""; string _Master_key_id = ""; string _result = string.Empty;
        public ucAuditStock()
        {
            InitializeComponent();
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            string result = "";
            DataSet ds = new DataSet();
            Cursor.Current = Cursors.WaitCursor;
        
            ds = GlobalUsage.pharmacy_proxy.SearchProductofUnit(out result,GlobalUsage.Unit_id, txtProdName.Text);
            Fill_ProductName(ds);
            Cursor.Current = Cursors.Default;
        }
        private void Fill_ProductName(DataSet _ds)
        {
            lvSearchItem.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                #region Process Block To Fill List View "lvSearchItem"
                try
                {
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        lvSearchItem.Items.Clear();
                        foreach (DataRow dr in _ds.Tables[0].Rows)
                        {
                            ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                            ls.SubItems.Add(dr["Item_Name"].ToString());
                            lvSearchItem.Items.Add(ls);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search Product", MessageBoxButtons.OK);
                }
                #endregion
            }
        }
        private void lvSearchItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _item_id = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Text;
            _item_name = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text + "  :" + _item_id;
            gb_info.Text = _item_name;
            lv_tracking.Items.Clear();
            #region Fill List View "Lv_Tracking"
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            string result = DateTime.Now.Second.ToString();
            ds = GlobalUsage.pharmacy_proxy.TrackUnitItem(out _result,_item_id, GlobalUsage.Unit_id);
            Fill_ListView(ds);
            Cursor.Current = Cursors.Default;
            #endregion
        }
        private void lvSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                #region Fill List View "Lv_Tracking"
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                string result = DateTime.Now.Second.ToString();
                ds = GlobalUsage.pharmacy_proxy.TrackUnitItem(out _result,_item_id, GlobalUsage.Unit_id);
                Fill_ListView(ds);
                Cursor.Current = Cursors.Default;
                #endregion
            }
        }
        protected void Fill_ListView(DataSet _ds)
        {
            #region Fill List View
            if (_ds.Tables[0].Rows.Count > 0)
            {
                gb_info.Visible = true;
                string temp = "N/A"; string groupname = "Temp";
                decimal bal = 0; decimal tstkQty = 0; decimal stkQty = 0; decimal trfqty = 0; decimal issueqty = 0; decimal retqty = 0;
                decimal gTrfqty = 0; decimal gIssueqty = 0; decimal gRetqty = 0;
                lv_tracking.Items.Clear();
                try
                {
                    ListViewItem ls;
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        if (temp != dr["Master_key_id"].ToString())
                        {
                            if (groupname != "Temp")
                            {
                                ls = new ListViewItem(temp);
                                ls.SubItems.Add("Final Status : In Stock " + stkQty.ToString("##0"));
                                ls.SubItems.Add("->");
                                ls.SubItems.Add("->");
                                ls.SubItems.Add("->");
                                ls.SubItems.Add(trfqty.ToString("##0"));
                                ls.SubItems.Add(issueqty.ToString("##0"));
                                ls.SubItems.Add(retqty.ToString("##0"));
                                ls.SubItems.Add(bal.ToString("##0"));
                                ls.Group = lv_tracking.Groups[groupname];
                                if (stkQty != bal)
                                    ls.ForeColor = Color.Red;
                                else
                                    ls.ForeColor = Color.Green;
                                ls.Font = new Font("Arial Narrow", 11, FontStyle.Bold);
                                lv_tracking.Items.Add(ls);
                            }
                            groupname = dr["Master_key_id"].ToString();
                            lv_tracking.Groups.Add(groupname, groupname);
                            temp = dr["Master_key_id"].ToString();
                            stkQty = Convert.ToDecimal(dr["stkqty"]);
                            tstkQty += stkQty;
                            bal = 0; trfqty = 0; issueqty = 0; retqty = 0;
                        }
                        bal = bal + Convert.ToDecimal(dr["trf_qty"]) - Convert.ToDecimal(dr["issue_qty"]) - Convert.ToDecimal(dr["ret_qty"]);
                        trfqty += Convert.ToDecimal(dr["trf_qty"]);
                        issueqty += Convert.ToDecimal(dr["issue_qty"]);
                        retqty += Convert.ToDecimal(dr["ret_qty"]);
                        gTrfqty += Convert.ToDecimal(dr["trf_qty"]);
                        gIssueqty += Convert.ToDecimal(dr["issue_qty"]);
                        gRetqty += Convert.ToDecimal(dr["ret_qty"]);
                        ls = new ListViewItem(dr["master_key_id"].ToString());
                        ls.SubItems.Add(dr["unit_name"].ToString());
                        ls.SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MM-yyyy"));
                        ls.SubItems.Add(dr["trf_id"].ToString());
                        ls.SubItems.Add(dr["pack_type"].ToString());
                        ls.SubItems.Add(Convert.ToInt32(dr["trf_qty"]).ToString("##0"));
                        ls.SubItems.Add(Convert.ToInt32(dr["issue_qty"]).ToString("##0"));
                        ls.SubItems.Add(Convert.ToInt32(dr["ret_qty"]).ToString("##0"));
                        ls.SubItems.Add(bal.ToString("##0"));
                        ls.Group = lv_tracking.Groups[groupname];
                        lv_tracking.Items.Add(ls);
                    }
                    ls = new ListViewItem("N/A");
                    ls.SubItems.Add("Final Status : In Stock " + stkQty.ToString("##0"));
                    ls.SubItems.Add("->");
                    ls.SubItems.Add("->");
                    ls.SubItems.Add("->");
                    ls.SubItems.Add(trfqty.ToString("##0"));
                    ls.SubItems.Add(issueqty.ToString("##0"));
                    ls.SubItems.Add(retqty.ToString("##0"));
                    ls.SubItems.Add(bal.ToString("##0"));
                    ls.Group = lv_tracking.Groups[groupname];
                    if (stkQty != bal)
                        ls.ForeColor = Color.Red;
                    else
                        ls.ForeColor = Color.Green;
                    ls.Font = new Font("Arial Narrow", 11, FontStyle.Bold);
                    lv_tracking.Items.Add(ls);
                    //tstkQty += stkQty;
                    decimal auditstk = gTrfqty - gIssueqty - gRetqty;
                    gb_info.Text = _item_name + " :: In Stock  " + tstkQty.ToString("#0") + ", By Audit Stock " + auditstk.ToString("##0");
                    if (auditstk != tstkQty)
                        gb_info.ForeColor = Color.Red;
                    else
                        gb_info.ForeColor = Color.Green;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            #endregion
        }
        private void lv_tracking_Enter(object sender, EventArgs e)
        {
            lblMkey.Enabled = false; txtFStkQty.Enabled = false;
        }

        private void lv_tracking_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMkey.Enabled = false; txtFStkQty.Enabled = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txtRemark.Text.Length > 0)
            {
                btn_Submit.Enabled = false;
                string result = DateTime.Now.Second.ToString();
                GlobalUsage.pharmacy_proxy.Audit_Info("Auditor", "Insert", GlobalUsage.Login_id, _item_id, txtRemark.Text.Replace("'", " "));
                txtRemark.Text = "";
            }
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btn_Submit.Enabled = true;
                btn_Submit.Focus();
            }
            else
            {
                btn_Submit.Enabled = false;
            }
        }

        private void ucAuditStock_Load(object sender, EventArgs e)
        {

        }
    }
