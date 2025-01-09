using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using eMediShop.Pharmacy;
namespace eMediShop.forms.Reconcilation
{
    public partial class ReconcileProduct : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();DataTable _dtTracing = new DataTable();
        int _ItemIndex = 0;
        string _ItemId = string.Empty;
        string _UnitID = string.Empty;
        string _Action = string.Empty;
        string _SearchKey = string.Empty;
        string _Shelf_No = string.Empty; string _result = string.Empty;

        public ReconcileProduct()
        {
            InitializeComponent();
        }
        private void ReconcileProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string[] t;
            if (txtSearch.TextLength > 3)
            {
                if (txtSearch.Text.Contains("L:"))
                {
                    t = txtSearch.Text.Split(':');
                    _Action = "SearchInShelf_No";
                    _Shelf_No = t[1];
                }
                else
                {
                    _Action = "SearchProduct";
                    _Shelf_No = "SearchProduct";
                }
                _SearchKey = txtSearch.Text;
                progressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
        }
        private void fillProduct()
        {
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    lvSearchItem.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        lvSearchItem.Items.Add(dr["item_id"].ToString());
                        lvSearchItem.Items[lvSearchItem.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                    }

                }
            }
            _ds.Clear();
            _ds.Dispose();
            progressBar1.Visible = false;

        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lvSearchItem.Focus();
                if ((lvSearchItem.FocusedItem) != null)
                    lvSearchItem.Items[lvSearchItem.FocusedItem.Index].Selected = true;
            }
        }

        private void ReconcileProduct_KeyDown(object sender, KeyEventArgs e)
        {
            //if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            //{
            //    txtSearch.Text = "";
            //    txtSearch.Focus();
            //    _ItemIndex = 0;
            //    SwapShelfNo obj;
            //     obj = new SwapShelfNo(_Shelf_No);
            //    obj.SearchUpdated += new SearchUpdateEventHandler(fillShelfNo);
            //    obj.Owner = this;
            //    obj.Show();

            //}
        }
        private void cmdPurchase_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            _Action = "PurchaseInfo";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void fillPurchaseInfo()
        {
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[4].Rows.Count > 0)
                {
                    lv_item.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[4].Rows)
                    {
                        lv_item.Items.Add(dr["inv_date"].ToString());
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(dr["purch_id"].ToString());
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(dr["inv_no"].ToString());
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (dr["exp_date"].ToString() == "")
                            lv_item.Items[lv_item.Items.Count - 1].SubItems.Add("-");
                        else if (Convert.ToDateTime(dr["exp_date"]).ToString("yyyy-MM-dd") == "1900-01-01")
                            lv_item.Items[lv_item.Items.Count - 1].SubItems.Add("-");
                        else
                            lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));

                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("###.00"));
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["ptr"]).ToString("###.00"));
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["taxRate"]).ToString("###.00"));
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["disper"]).ToString("###.00"));
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["disamount"]).ToString("###.00"));
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["npr"]).ToString("###.00"));
                        lv_item.Items[lv_item.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["quantity"]).ToString("###.00"));
                    }
                }
            }
            _ds.Clear();
            _ds.Dispose();
            progressBar1.Visible = false;
        }
        private void fillAnalysisInfo()
        {
            if (_ds.Tables.Count > 0)
            {
                _dtTracing = _ds.Tables[0].Copy();

                rgvTracing.DataSource = _dtTracing;
            }
            _ds.Clear();
            _ds.Dispose();
            progressBar1.Visible = false;
        }

        private void fillProductInfo()
        {
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    lv_Transfer.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        lv_Transfer.Items.Add(dr["c_action"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MM-yyyy"));
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["master_key_id"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (dr["exp_date"].ToString() != "")
                            lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                        else
                            lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add("");
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["trf_id"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["GenFrom"].ToString());
                    }
                }
                if (_ds.Tables[1].Rows.Count > 0)
                {
                    lv_sales.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[1].Rows)
                    {
                        lv_sales.Items.Add(dr["master_key_id"].ToString());
                        lv_sales.Items[lv_sales.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        lv_sales.Items[lv_sales.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (dr["exp_date"].ToString() != "")
                            lv_sales.Items[lv_sales.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                        else
                            lv_sales.Items[lv_sales.Items.Count - 1].SubItems.Add("-");
                        lv_sales.Items[lv_sales.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        lv_sales.Items[lv_sales.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());

                    }
                }
                if (_ds.Tables[2].Rows.Count > 0)
                {
                    lv_prodInfo.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[2].Rows)
                    {
                        lv_prodInfo.Items.Add(dr["master_key_id"].ToString());
                        lv_prodInfo.Items[lv_prodInfo.Items.Count - 1].SubItems.Add(dr["quantity"].ToString());
                        lv_prodInfo.Items[lv_prodInfo.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());

                        if (dr["exp_date"].ToString() != "")
                            lv_prodInfo.Items[lv_prodInfo.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                        else
                            lv_prodInfo.Items[lv_prodInfo.Items.Count - 1].SubItems.Add("");
                        lv_prodInfo.Items[lv_prodInfo.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        lv_prodInfo.Items[lv_prodInfo.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                        lv_prodInfo.Items[lv_prodInfo.Items.Count - 1].SubItems.Add(dr["status_flag"].ToString());
                    }
                }
                #region Product Movement Tracing
               

                //decimal runBal = 0;
                //lv_Run_Bal.Items.Clear();
                //foreach (DataRow dr in _ds.Tables[3].Rows)
                //{
                //    if (dr["seq"].ToString() == "1")
                //    {
                //        lv_Run_Bal.Items.Add("Opening");
                //        lv_Run_Bal.Items[lv_Run_Bal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["opening"]).ToString("##"));
                //        runBal = Convert.ToDecimal(dr["opening"]);
                //    }
                //    lv_Run_Bal.Items.Add(Convert.ToDateTime(dr["date"]).ToString("dd-MM-yyyy"));
                //    lv_Run_Bal.Items[lv_Run_Bal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["purchase"]).ToString("##"));
                //    lv_Run_Bal.Items[lv_Run_Bal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["received"]).ToString("##"));

                //    if (dr["seq"].ToString() != "1")
                //    {
                //        lv_Run_Bal.Items[lv_Run_Bal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["sale"]).ToString("##"));
                //        runBal = (runBal + (Convert.ToDecimal(dr["purchase"]) + (Convert.ToDecimal(dr["received"]))) - (Convert.ToDecimal(dr["sale"]) + Convert.ToDecimal(dr["transfer"])));
                //    }
                //    lv_Run_Bal.Items[lv_Run_Bal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["transfer"]).ToString("##"));
                //    lv_Run_Bal.Items[lv_Run_Bal.Items.Count - 1].SubItems.Add(runBal.ToString("##"));
                //}

                #endregion

                fillPurchaseInfo();
                progressBar1.Visible = false;
                //_ds.Clear();
                //_ds.Dispose();


            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            cm1 p = new cm1();
            if (_Action == "SearchInShelf_No")
            {
                try
                {
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "SearchInShelf_No"; p.prm_1 = _Shelf_No; p.prm_2 = _SearchKey; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                    _ds = dwr.result;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (_Action == "SearchProduct")
            {
                try
                {
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "SearchInShelf_No"; p.prm_1 = _Action; p.prm_2 = _SearchKey; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                    _ds = dwr.result;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (_Action == "FillProductDetail")
            {
                try
                {
                    _ds = fillTrfInformation(_UnitID, _ItemId);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (_Action == "PurchaseInfo")
            {
                try
                {
                    pm_Stocks p1 = new pm_Stocks();
                    p1.unit_id = GlobalUsage.Unit_id; p1.item_id = _ItemId;
                    p1.master_key_id = "N/A"; p1.searchKey = "N/A"; p1.logic = "PurchaseInfo"; p1.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductMovementInfo", p1);
                    _ds = dwr.result;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (_Action == "AnalysisInfo")
            {
                try
                {
                    pm_Stocks p1 = new pm_Stocks();
                    p1.unit_id = GlobalUsage.Unit_id; p1.item_id = _ItemId;
                    p1.master_key_id = "N/A"; p1.searchKey = "N/A"; p1.logic = "AnalysisInfo"; p1.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductMovementInfo", p1);
                    _ds = dwr.result;
                    
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        public DataSet fillTrfInformation(string unit_id, string item_id)
        {
            pm_Stocks p = new pm_Stocks();
            p.unit_id = GlobalUsage.Unit_id; p.item_id = item_id;
            p.master_key_id = "N/A"; p.searchKey = "N/A"; p.logic = "Product:MovementAnalysis"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductMovementInfo", p);
            return dwr.result;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "SearchProduct" || _Action == "SearchInShelf_No")
                fillProduct();
            else if (_Action == "FillProductDetail")
                fillProductInfo();
            else if (_Action == "PurchaseInfo")
                fillPurchaseInfo();
            else if (_Action == "AnalysisInfo")
                fillAnalysisInfo();

        }
        private void lvSearchItem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _ItemId = lvSearchItem.Items[e.ItemIndex].Text;
            lblProduct.Text = lvSearchItem.Items[lvSearchItem.FocusedItem.Index].SubItems[1].Text + "  :" + _ItemId;
            _ItemIndex = lvSearchItem.FocusedItem.Index;
        }
        private void lvSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lv_item.Items.Clear();
                lv_Transfer.Items.Clear();
                lv_sales.Items.Clear();
                lv_prodInfo.Items.Clear();

                _UnitID = GlobalUsage.Unit_id;
                _Action = "FillProductDetail";
                progressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
        }
        private void lv_item_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    string purchase_id=lv_item.Items[lv_item.FocusedItem.Index].Text;
            //    PurchaseInfo useFRM = new PurchaseInfo(purchase_id);
            //    useFRM.Owner = this;
            //    useFRM.Show();
            //}
        }
        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Shelf_No = "-";
            _Action = "SearchInShelf_No";
            _SearchKey = txtSearch.Text;
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void lvSearchItem_DoubleClick(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 2)
            {
                lv_item.Items.Clear();
                lv_Transfer.Items.Clear();
                lv_sales.Items.Clear();
                lv_prodInfo.Items.Clear();

                _UnitID = GlobalUsage.Unit_id;
                _Action = "FillProductDetail";
                progressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnTracing_Click(object sender, EventArgs e)
        {
            rgvTracing.DataSource = _ds.Tables[3];
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            _Action = "AnalysisInfo";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
    }
}
