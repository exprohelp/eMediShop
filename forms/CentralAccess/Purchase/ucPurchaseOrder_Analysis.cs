using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;

namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class ucPurchaseOrder_Analysis : UserControl
    {
        List<ListView> objLV = new List<ListView>();
        string _result = string.Empty; string _orderNo = string.Empty; string _logic = string.Empty;
        string _fileName = string.Empty; decimal _purch_qty_agKey = 0; string _master_key_id = string.Empty;string _jsonString = string.Empty;
        DataSet _ds = new DataSet();
        public ucPurchaseOrder_Analysis()
        {
            InitializeComponent();
        }

        private void ucPurchaseOrder_Analysis_Load(object sender, EventArgs e)
        {
            try
            {
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id; p.order_no = "-"; p.logic = "PO-LIST"; p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderAnalysis", p);

                DataRow[] drary = dwr.result.Tables[0].Select();
                #region Fill Order Numbers
                cmbOrer_Nos.Items.Clear();
                cmbOrer_Nos.Items.Add(new ExproComboBox("Select", "Select"));
                cmbOrer_Nos.Enabled = true;
                foreach (DataRow dr in drary)
                {
                    cmbOrer_Nos.Items.Add(new ExproComboBox(dr["order_no"].ToString(), dr["order_info"].ToString()));
                }
                if(cmbOrer_Nos.Items.Count>1)
                    cmbOrer_Nos.SelectedIndex = 1;
                else
                    cmbOrer_Nos.SelectedIndex = 0;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            btnSummary.Enabled = false;
            btnShort.Enabled = true;
            btnExcess.Enabled = true;
            btnBest.Enabled = true;
            btnDiff.Enabled = true;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                _orderNo=((ExproComboBox)cmbOrer_Nos.SelectedItem).Value.ToString();
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id; p.order_no = _orderNo; p.logic = "Summary"; p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderAnalysis", p);

                DataTable table = dwr.result.Tables[0];
                #region Process Summary
                txtTotal.Text = table.Rows[0]["NoS"].ToString();
                btn_perfect.Text =Convert.ToDecimal(table.Rows[0]["pp_per"]).ToString("#0.00");
                btnExcess.Text = Convert.ToDecimal(table.Rows[0]["ext_per"]).ToString("#0.00");
                btnShort.Text = Convert.ToDecimal(table.Rows[0]["short_per"]).ToString("#0.00");
                btnBest.Text = Convert.ToDecimal(table.Rows[0]["bestNpr_No"]).ToString("#0");
                btnDiff.Text = Convert.ToDecimal(table.Rows[0]["highNpr_No"]).ToString("#0");

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }

        private void cmbOrer_Nos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrer_Nos.Text != "Select")
                btnSummary.Enabled = true;
            else
                btnSummary.Enabled = false;

        }

        

        private void btn_perfect_Click(object sender, EventArgs e)
        {
            gb_detail.Text = "Perfect Purchase";
            _logic = "Perfect"; _fileName = "Perfect";
            Fill_Header("PerfectPurchase");
            Perfect_Short_Purchase("PerfectPurchase");
        }

        private void Perfect_Short_Purchase(string Logic)
        {
            Cursor.Current = Cursors.WaitCursor;
            btn_perfect.Enabled = false;
            try
            {
                decimal excecBar = 0;
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id; p.order_no = _orderNo; p.logic = Logic; p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderAnalysis", p);

                DataTable table = dwr.result.Tables[0];
                DataRow[] drary = table.Select();


                #region Process
                foreach (DataRow dr in drary)
                {
                    ListViewItem lvi = new ListViewItem(dr["item_id"].ToString(), dr["item_id"].ToString());
                    lvi.SubItems.Add(dr["item_name"].ToString());
                    lvi.SubItems.Add(dr["order_pack"].ToString());
                    lvi.SubItems.Add(dr["purch_pack"].ToString());
                    lvi.SubItems.Add(dr["mkey_NoS"].ToString());
                    excecBar=(Convert.ToDecimal(dr["global_avg"])*15/100);
                    if( Convert.ToDecimal(dr["mkey_NoS"]) > 1)
                        lvi.ForeColor = Color.Red;
                    else if ((Convert.ToDecimal(dr["purch_pack"]) - Convert.ToDecimal(dr["order_pack"])) > excecBar && Logic=="Excess Purchase")
                        lvi.ForeColor = Color.Purple;
                    else if (_logic == "BestNpr" || _logic == "nprGreater")
                    {
                        if (((Convert.ToDecimal(dr["pm_mpr"]) - Convert.ToDecimal(dr["o_npr"]) ) * 100 / Convert.ToDecimal(dr["pm_mpr"])) > 1)
                            lvi.ForeColor = Color.Purple;
                    }
                    else
                        lvi.ForeColor = Color.Black;

                    if(Logic=="ShortPurchase")
                        lvi.SubItems.Add((Convert.ToDecimal(dr["order_pack"]) - Convert.ToDecimal(dr["purch_pack"])).ToString());
                    else if (Logic == "Excess Purchase")
                    {
                        lvi.SubItems.Add((Convert.ToDecimal(dr["purch_pack"]) - Convert.ToDecimal(dr["order_pack"])).ToString());
                        lvi.SubItems.Add((Convert.ToDecimal(dr["purch_pack"]) - Convert.ToDecimal(dr["order_pack"])).ToString());
                        lvi.SubItems.Add(Convert.ToDecimal(dr["global_avg"]).ToString("##.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["global_stk"]).ToString("##.00"));
                        
                    }
                    else if (_logic == "BestNpr" || _logic == "nprGreater")
                    {
                        lvi.SubItems.Add(Convert.ToDecimal(dr["o_npr"]).ToString("##.00"));
                        lvi.SubItems.Add(Convert.ToDecimal(dr["pm_npr"]).ToString("##.00"));
                        lvi.SubItems.Add(((Convert.ToDecimal(dr["pm_npr"]) - Convert.ToDecimal(dr["o_npr"])) * 100 / Convert.ToDecimal(dr["pm_npr"])).ToString("##.00"));
                    }
                    lv_detail.Items.Add(lvi);
                }
                #endregion
                if (lv_detail.Items.Count > 0)
                    btnXL.Enabled = true;
                else
                    btnXL.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btn_perfect.Enabled = true;
            Cursor.Current = Cursors.Default;

        }

        protected void Fill_Header(string logic)
        {
            lv_detail.Clear();
            if (logic == "PerfectPurchase")
            {
                lv_detail.Columns.Add("item_id", 0, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Name of Product", 200, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Packs[O]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("Packs[P]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("KeyNos", 0, HorizontalAlignment.Right);
            }
            else if (logic == "ShortPurchase")
            {
                lv_detail.Columns.Add("item_id", 0, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Name of Product", 200, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Packs[O]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("Packs[P]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("KeyNos", 0, HorizontalAlignment.Right);
                lv_detail.Columns.Add("Short", 70, HorizontalAlignment.Right);
            }
            else if (logic == "Excess Purchase")
            {
                lv_detail.Columns.Add("item_id", 0, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Name of Product", 200, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Packs[O]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("Packs[P]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("KeyNos", 0, HorizontalAlignment.Right);
                lv_detail.Columns.Add("Excess", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("PR(P)", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("G(SAvg)", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("G(Stk)", 70, HorizontalAlignment.Right);

            }
            else if (logic == "BestNpr" || logic == "nprGreater")
            {
                lv_detail.Columns.Add("item_id", 0, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Name of Product", 200, HorizontalAlignment.Left);
                lv_detail.Columns.Add("Packs[O]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("Packs[P]", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("KeyNos", 0, HorizontalAlignment.Right);
                lv_detail.Columns.Add("NPR(O)", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("NPR(P)", 70, HorizontalAlignment.Right);
                lv_detail.Columns.Add("Diff%", 70, HorizontalAlignment.Right);
            }

        }
  
        private void btnXL_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                #region Fill Order Numbers
                GlobalUsage.ListViewToCSV(lv_detail, _fileName);
                //Config.ExportToXL(_ds, _fileName);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            gb_detail.Text = "Short Purchase";
            _logic = "Short"; _fileName = "Short";
            Fill_Header("ShortPurchase");
            Perfect_Short_Purchase("ShortPurchase");
        }

        private void btnExcess_Click(object sender, EventArgs e)
        {
            gb_detail.Text = "Excess Purchase";
            _logic = "Excess Purchase"; _fileName = "ExcessPurchase";
            Fill_Header("Excess Purchase");
            Perfect_Short_Purchase(_logic);
        }

        private void btnBest_Click(object sender, EventArgs e)
        {
            gb_detail.Text = "Best NPR Purchase";
            _logic = "BestNpr"; _fileName = "BestNpr";
            Fill_Header("BestNpr");
            Perfect_Short_Purchase(_logic);
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            gb_detail.Text = "High NPR Purchase";
            _logic = "nprGreater"; _fileName = "nprGreater";
            Fill_Header("nprGreater");
            Perfect_Short_Purchase(_logic);
        }

        private void lv_detail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_detail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            { 
            
            }
        }

        private void lv_detail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lblName.Text = e.Item.SubItems[1].Text;
            lv_keyInfo.Items.Clear();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (_logic == "Excess Purchase")
                {
                    txtRetPacks.Text = Convert.ToInt16(e.Item.SubItems[6].Text).ToString("###");
                }
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id; p.order_no = _orderNo; p.logic = "purchInfoByKey"; p.prm_1 = e.Item.SubItems[0].Text; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderAnalysis", p);

                DataTable table = dwr.result.Tables[0];
                DataRow[] drary = table.Select();
                decimal bestNPR = 0;
                foreach (DataRow dr in drary)
                {
                    if (dr["logic"].ToString() == "B")
                        bestNPR =Convert.ToDecimal(dr["npr"]);
                    ListViewItem lvi = new ListViewItem(dr["master_key_id"].ToString(), dr["master_key_id"].ToString());
                    lvi.SubItems.Add(dr["pack_type"].ToString());
                    lvi.SubItems.Add(dr["pack_qty"].ToString());
                    lvi.SubItems.Add(dr["batch_no"].ToString());
                    lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM -yy"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["ptr"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["dis_per"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["purch_qty"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["free"]).ToString("##.00"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["tax_rate"]).ToString("##.0"));
                    lvi.SubItems.Add(Convert.ToDecimal(dr["npr"]).ToString("##.00"));
                    lvi.SubItems.Add(dr["vendor_name"].ToString());
                    if (dr["logic"].ToString() == "B")
                        lvi.ForeColor = Color.Blue;
                    else if (Convert.ToDecimal(dr["npr"]) <= bestNPR)
                        lvi.ForeColor = Color.DarkGreen;
                    else
                        lvi.ForeColor = Color.Red;

                    lv_keyInfo.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { 
            Cursor.Current = Cursors.Default;
            }
        }

        private void lv_keyInfo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtRetPacks.Focus();
            }
        }

        private void txtRetPacks_Enter(object sender, EventArgs e)
        {
            txtRetPacks.SelectAll();
        }

        private void txtRetPacks_Leave(object sender, EventArgs e)
        {
            if (_purch_qty_agKey < Convert.ToInt16(txtRetPacks.Text))
            {
                MessageBox.Show("Return Can Not be > " + _purch_qty_agKey.ToString() + " Against selected Key", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRetPacks.Text = _purch_qty_agKey.ToString("##0");
                btnReturnPack.Enabled = false;
            }
            else
            {
                btnReturnPack.Enabled = true;
                btnReturnPack.Focus();
            }
            
        }

        private void lv_keyInfo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _purch_qty_agKey = Convert.ToDecimal(lv_keyInfo.Items[lv_keyInfo.FocusedItem.Index].SubItems[8].Text) + Convert.ToDecimal(lv_keyInfo.Items[lv_keyInfo.FocusedItem.Index].SubItems[9].Text);
            _master_key_id = lv_keyInfo.FocusedItem.Text;
        }

        private void btnReturnPack_Click(object sender, EventArgs e)
        {
            btnReturnPack.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                pm_PurchaseReturn p = new pm_PurchaseReturn();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.order_no = _orderNo; p.master_key_id = _master_key_id; p.ret_packs = Convert.ToInt16(txtRetPacks.Text);
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertForPurchaseReturn", p);
                _result = dwr.message;
               
            }
            catch (Exception ex)
            { }
            finally { Cursor.Current = Cursors.Default; }
            lblResult.Text = _result;
            
        }

        private void txtRetPacks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnReturnPack.Focus();
        }

        private void btnReturnReport_Click(object sender, EventArgs e)
        {
            //origin, mki.master_key_id, mki.pack_type, mki.pack_qty, pmr.order_no, pmr.ret_packs, im.Item_id,
            //im.Item_Name, RTRIM(vm.Vendor_Name) + ', ' + RTRIM(vm.City) 
            //AS vend_info, mki.p_info, mki.mrp, mki.npr, mki.batch_no, mki.exp_date
            Cursor.Current = Cursors.WaitCursor;
            lv_RetReport.Items.Clear();
            btnReturnReport.Enabled = false;
            if (btnReturnReport.Text == "Return Report")
            {
                #region Return Report
                try
                {
                    _ds.Tables.Clear();
                    pm_PurchaseOrders p = new pm_PurchaseOrders();
                    p.unit_id = GlobalUsage.Unit_id; p.order_no = _orderNo; p.logic = "purchRetInfoPool"; p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderAnalysis", p);

                    DataTable table = dwr.result.Tables[0];
                    if (table.Rows.Count > 0)
                    {
                        var data = table.AsEnumerable().Select(o => new {
                        item_name=o.Field<string>("item_name"),
                        master_key_id=o.Field<string>("master_key_id"),
                        pack_type = o.Field<string>("pack_type"),
                        pack_qty = o.Field<int>("pack_qty"),
                        mrp=o.Field<decimal>("mrp"),
                        npr = o.Field<decimal>("npr"),
                        batch_no = o.Field<string>("batch_no"),
                        exp_date=o.Field<DateTime>("exp_date"),
                        qty=o.Field<int>("ret_packs"),
                        origin=o.Field<string>("origin"),
                        vend_info=o.Field<string>("vend_info")
                        }).OrderBy(ord=>ord.vend_info);

                        _ds.Dispose();
                        foreach (var a in data)
                        {
                            if (_result != a.vend_info)
                            {
                                lv_RetReport.Groups.Add(a.vend_info, a.vend_info);
                                _result = a.vend_info;
                            }
                            ListViewItem lvi = new ListViewItem(a.master_key_id, a.master_key_id);
                            lvi.SubItems.Add(a.item_name);
                            lvi.SubItems.Add(a.pack_type);
                            lvi.SubItems.Add(a.pack_qty.ToString());
                            lvi.SubItems.Add(a.mrp.ToString("##.00"));
                            lvi.SubItems.Add(a.batch_no);
                            lvi.SubItems.Add(a.exp_date.ToString("MM-yy"));
                            lvi.SubItems.Add(a.npr.ToString("##.00"));
                            lvi.SubItems.Add(a.qty.ToString());
                            lvi.SubItems.Add(a.origin);
                            lvi.Group = lv_RetReport.Groups[a.vend_info];
                            lv_RetReport.Items.Add(lvi);

                        }
                        btnReturnReport.Text = "Close Report";
                    
                    }
                    }
                catch (Exception ex)
                { }
                #endregion
                gbRetReport.Visible = true;
                gbRetReport.Location = new Point(4, 5);
                gbRetReport.Size = new Size(797, 497);
            }
            else if (btnReturnReport.Text == "Close Report")
            {
                gbRetReport.Visible = false;
                btnReturnReport.Text = "Return Report";
            }
            btnReturnReport.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void cmbOrer_Nos_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cmbOrer_Nos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    _orderNo = ((ExproComboBox)cmbOrer_Nos.SelectedItem).Value.ToString();
                 
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                Cursor.Current = Cursors.Default;
            }
        }

        private void cmbOrer_Nos_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gb_detail_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseOrders p = new pm_PurchaseOrders();
                p.unit_id = GlobalUsage.Unit_id; p.order_no = _orderNo; p.logic = "Refresh_Purch_Pack"; p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderAnalysis", p);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
