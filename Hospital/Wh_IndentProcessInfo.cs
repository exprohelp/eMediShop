using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using ExPro.Client;
using Telerik.WinControls;
using Newtonsoft.Json;

namespace eMediShop.Hospital
{
    public partial class Wh_IndentProcessInfo : Telerik.WinControls.UI.RadForm
    {
        eMediShop.Utility.SwapProduct objSwap;
        private CashMemoSearch frmCashMemoSearch;
        string _ipopno = string.Empty;
        string _UHID = string.Empty;string _old_sale_inv_no = string.Empty;
        string _result = string.Empty; string _card_Level = string.Empty;
        string _cardNo = string.Empty;string _CreditFlag = "N";string _HISPUSH_Flag = "N";
        string _order_no = string.Empty; string _orderDate = string.Empty;
        string _neworder_no = string.Empty;
        string _items_id = string.Empty;string _itemName = string.Empty;
        string _deliveryDate = string.Empty; string _deliveryTime = string.Empty;
        decimal TOrdqty = 0; string _promoTag = string.Empty;
        int _index = 0;string _panelName = string.Empty;
        string _doctor_id = string.Empty;
        int _itemindex = 0;
        string prescription_from = string.Empty;
      
        string _PayMode ="Cash";
        ListViewItem item;
        private System.Windows.Forms.TextBox _sale_qty = new System.Windows.Forms.TextBox();
        int selectedSubItem = 0; string column = string.Empty;
        int X = 0; int Y = 0; int position = 0;
        string subItemText = "";
        string _CallFrom = string.Empty; string _cardStatus = string.Empty; decimal _discountPercentage = 0;
        DataSet dsOrder = new DataSet();
        public Wh_IndentProcessInfo(string uhid,string CallFrom)
        {
            InitializeComponent();
            _UHID = uhid;
            _CallFrom = CallFrom;
            #region Initialize TextBox ChangeRate
            _sale_qty.Size = new System.Drawing.Size(0, 0);
            _sale_qty.Location = new System.Drawing.Point(0, 0);
            _sale_qty.TextAlign = HorizontalAlignment.Right;
            lv_batchno.Controls.Add(this._sale_qty);
            _sale_qty.LostFocus += new System.EventHandler(this.StockQtyFocusExit);
            _sale_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockQtyKeyPress);
            _sale_qty.Hide();

            #endregion
        }
        private void StockQtyKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 27)
            {
                if (e.KeyChar == 13)
                {
                    try
                    {
                        int index = lv_batchno.FocusedItem.Index;
                        item.SubItems[selectedSubItem].Text = _sale_qty.Text;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                lv_batchno.Focus();
            }
        }
        private void StockQtyFocusExit(object sender, System.EventArgs e)
        {
            _sale_qty.Hide();
        }
        protected int getXaxisWidth(ListView lv)
        {
            int start = X;
            int w = 0;
            int i = 0;
            for (i = 0; i < lv.Columns.Count; i++)
            {
                w = w + lv.Columns[i].Width;
                if (w > X)
                {
                    selectedSubItem = i;
                    position = w - lv.Columns[i].Width;
                    break;
                }
            }
            return position;
        }
        private void lv_batchno_Click(object sender, EventArgs e)
        {
            // Check whether the subitem was clicked
            int x = getXaxisWidth(lv_batchno);
            subItemText = item.SubItems[selectedSubItem].Text;
            column = lv_batchno.Columns[selectedSubItem].Text;
            if (column == "Qty")
            {
                int y = item.Bounds.Bottom - item.Bounds.Top;
                _sale_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                _sale_qty.Size = new System.Drawing.Size(lv_batchno.Columns[selectedSubItem].Width, 22);
                _sale_qty.Location = new System.Drawing.Point(position, item.Bounds.Y);
                _sale_qty.Show();
                _sale_qty.Text = subItemText;
                _sale_qty.SelectAll();
                _sale_qty.Focus();
            }
        }
        private void lv_batchno_MouseDown(object sender, MouseEventArgs e)
        {
            ListView lv = (ListView)sender;
            item = lv.GetItemAt(e.X, e.Y);
            X = e.X;
            Y = e.Y;
        }
        private void ucProcessOrder_Load(object sender, EventArgs e)
        {

            LoadPendingIndent();
            if (GlobalUsage.Posting_Rights == "Y")
                btnCompleteSale.Enabled = true;
            else
                btnCompleteSale.Enabled = false;

        }
        private void LoadPendingIndent()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                p.from = "1900/01/01";p.to = "1900/01/01";p.card_no = "-";p.uhid = _UHID;
                p.IPOPNo = "-";
                if (_CallFrom != "Billing")
                {
                    p.IPOPNo = _CallFrom;
                    p.prm_1 = _CallFrom;p.logic = "PendingIndent?";
                }
                else
                {
                    this.dgIndentInfo.SelectionChanged -= new System.EventHandler(this.dgIndentInfo_SelectionChanged);
                    p.prm_1 = ""; p.logic = "PendingIndentWH";
                }
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                dgIndentInfo.DataSource = dwr.result.Tables[0];
                if (_CallFrom != "Billing")
                {
                    dgIndentInfo.Select();
                    dgIndentInfo.Rows[0].IsSelected = true; 
                    
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }

        }

        private void btnpendinglist_Click(object sender, EventArgs e)
        {
           LoadPendingIndent();

        }
      
        private void FillOrderDetail(string uhid,string order_no)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                lvOrder.Items.Clear();
               
                pm_IPOPQueries pm = new pm_IPOPQueries();
                pm.unit_id = GlobalUsage.Unit_id;pm.card_no = "-";pm.uhid = uhid; pm.IPOPNo = "-";pm.from = "1900/01/01";pm.to = "1900/01/01";
                pm.prm_1 = dgIndentInfo.CurrentRow.Cells["indent_no"].Value.ToString(); pm.logic = "IndentDetailWH"; pm.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", pm);
                dsOrder = dwr.result;


                _UHID = dsOrder.Tables[1].Rows[0]["UHID"].ToString();
                txtRefBy.Text = dsOrder.Tables[1].Rows[0]["doctor_name"].ToString();
                if (!chkCorporate.Checked)
                    _cardNo = dsOrder.Tables[1].Rows[0]["card_no"].ToString();
                else
                    _cardNo = "CORP-PANEL";
                _doctor_id = dsOrder.Tables[1].Rows[0]["doctor_id"].ToString();
                txtdoctorName.Text = dsOrder.Tables[1].Rows[0]["doctor_name"].ToString();
                txtRoom.Text = dsOrder.Tables[1].Rows[0]["room_no"].ToString();
                txtBed.Text = dsOrder.Tables[1].Rows[0]["bed_no"].ToString();
                txtdept.Text = dsOrder.Tables[1].Rows[0]["dept_name"].ToString();
                txtipop.Text = dsOrder.Tables[1].Rows[0]["ipop_no"].ToString();
                lblCartName.Text = "Cart Name : "+dsOrder.Tables[1].Rows[0]["cartName"].ToString();
                
                _order_no = dgIndentInfo.CurrentRow.Cells["indent_no"].Value.ToString();
                cbxPtName.Text = dgIndentInfo.CurrentRow.Cells["pt_name"].Value.ToString();
                string strItemId = string.Empty;
                if (dsOrder.Tables.Count > 0 && dsOrder.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsOrder.Tables[0].Rows)
                    {
                        strItemId += "'" + dr["item_id"].ToString() + "'" + ",";
                    }
                    strItemId = strItemId.Substring(0, strItemId.Length - 1);
                 
                    productSearch ps = new productSearch();
                    ps.unit_id = GlobalUsage.Unit_id; ps.item_id = strItemId;
                    ps.logic = "OrderProcess";ps.login_id = GlobalUsage.Login_id; ps.prm_1 = strItemId;
                    datasetWithResult dset = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", ps);
                    DataSet dsStock = dset.result;
                    var Order = dsOrder.Tables[0].AsEnumerable().Select(s => new { OItemId = s.Field<string>("item_id"),
                        Item_name = s.Field<string>("item_name"),
                        FrontDeskAlert = s.Field<string>("FrontDeskAlert"),
                        O_Qty = s.Field<Int64>("qty"), issue_qty = s.Field<Int64>("issue_qty") });
                    var Stock = dsStock.Tables[0].AsEnumerable().Select(l => new { SItemId = l.Field<string>("Item_id"), stk_qty = l.Field<decimal>("qty"), category = l.Field<string>("category") });
                    var itemList = (from p in Order
                                    join c in Stock on p.OItemId equals c.SItemId into g
                                    from c in g.DefaultIfEmpty()
                                    select new
                                    {
                                        ItemId = p.OItemId,
                                        ItemName = p.Item_name,
                                        FrontDeskAlert=p.FrontDeskAlert,
                                        Category = c != null ? c.category : "-",
                                        O_Qty = p.O_Qty,
                                        pend_qty = p.O_Qty - p.issue_qty,
                                        stk_qty = c != null ? c.stk_qty : 0,
                                    }).OrderBy(z => z.ItemName);
                    this.lvOrder.ItemSelectionChanged -= new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrder_ItemSelectionChanged);
                    foreach (var dr in itemList)
                    {
                        ListViewItem lv = new ListViewItem(dr.ItemId);
                        lv.SubItems.Add(dr.ItemName);
                        lv.SubItems.Add(dr.stk_qty.ToString("##"));
                        lv.SubItems.Add(dr.O_Qty.ToString());
                        lv.SubItems.Add(dr.pend_qty.ToString());
                        lv.SubItems.Add(dr.FrontDeskAlert.ToString());
                        if (!dr.Category.Contains("GENE") && txtCorpName.Text.ToUpper().Contains("AYUSMAN"))
                            lvOrder.Items.Add(lv).ForeColor = Color.Navy;
                        else if (dr.pend_qty > dr.stk_qty)
                            lvOrder.Items.Add(lv).ForeColor = Color.Red;
                        else
                            lvOrder.Items.Add(lv).ForeColor = Color.Green;

                    }
                    this.lvOrder.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrder_ItemSelectionChanged);
                }
                txtInvNo.Text = "New Invoice";

            
                pm.unit_id = GlobalUsage.Unit_id; pm.card_no = "-"; pm.IPOPNo = "-"; pm.from = "1900/01/01"; pm.to = "1900/01/01";
                pm.prm_1 = _order_no; pm.logic = "SaleNoOnIndent"; pm.login_id = GlobalUsage.Login_id;
                datasetWithResult ds1= ConfigWebAPI.CallAPI("api/hospital/ipopqueries", pm);
                DataSet ds = new DataSet();
                ds=ds1.result;

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txtInvNo.Text = ds.Tables[0].Rows[0]["sale_inv_no"].ToString();
                }
                Fill_ItemSalesGrid(txtInvNo.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
            DisableButtons();

        }

        private DataSet  IPOPQueries(string dtFrom,string dtTo,string Card_no,string ipop_no,string logic,string prm_1)
        {
            pm_IPOPQueries pm = new pm_IPOPQueries();
            pm.unit_id = GlobalUsage.Unit_id; pm.login_id = GlobalUsage.Login_id;pm.uhid = _UHID;
            pm.from = dtFrom; pm.to = dtTo; pm.card_no = Card_no; pm.IPOPNo = ipop_no;
            pm.prm_1 = prm_1; pm.logic = logic;

            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", pm);
            return dwr.result;
        }

        private void GetBatch(string _item_id)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            string ipd_info = _UHID + "|"+_ipopno+"|"+TOrdqty.ToString();
            lblItemName.Text = "Item Name :"+ _itemName+'['+_item_id+']';
            productSearch ps = new productSearch();
            ps.unit_id = GlobalUsage.Unit_id;ps.login_id = GlobalUsage.Login_id;
            ps.logic = "AutoSales";ps.prm_1 = ipd_info;ps.item_id = _item_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", ps);
            ds = dwr.result; 
            lv_batchno.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["master_key_id"].ToString());
                lvi.SubItems.Add(dr["batch_no"].ToString());
                if (Convert.ToDateTime(dr["exp_date"]).ToString("yyyy-MM-dd") != "1900-01-01")
                    lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                else
                    lvi.SubItems.Add("-");
                lvi.SubItems.Add(dr["pack_type"].ToString());
                lvi.SubItems.Add(dr["pack_qty"].ToString());
                lvi.SubItems.Add(Convert.ToDecimal(dr["mrp"]).ToString("####.00"));
                lvi.SubItems.Add(Convert.ToDecimal(dr["usr"]).ToString("####.00"));
                lvi.SubItems.Add(dr["qty"].ToString());
                lv_batchno.Items.Add(lvi);
            }
            Cursor.Current = Cursors.Default;
        }
        protected void Fill_ItemSalesGrid(string Sale_Inv_No)
        {
            if (Sale_Inv_No == "New Invoice") 
            return;
            Cursor.Current = Cursors.WaitCursor;
            pm_SalesAction1 p = new pm_SalesAction1();
            p.unit_id = GlobalUsage.Unit_id;p.Sale_Trn_No = "-";p.Sales_Inv_No = Sale_Inv_No;
            p.order_no = "-";p.master_key_id = "-";
            p.logic = "SalesInvoice";
            p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/GetSalesInvoice_Info", p);
            DataSet _ds = new DataSet();
            _ds = dwr.result;

            ItemSaleGrid.Items.Clear();
            txtTotal.Text = "0";
            txtDiscount.Text = "0";
            txtRoundoff.Text = "0";
            txtPayable.Text = "0"; 
            if (_ds.Tables.Count>0 && _ds.Tables[1].Rows.Count > 0)
            {
                #region Fill Item Grid
                string temp = string.Empty;
                foreach (DataRow dr in _ds.Tables[1].Rows)
                {
                    ListViewItem lvi = new ListViewItem(dr["item_id"].ToString());
                    lvi.SubItems.Add(dr["item_name"].ToString());   //0
                    lvi.SubItems.Add(dr["master_key_id"].ToString());
                    lvi.SubItems.Add(dr["batch_no"].ToString());                                    //2
                    if (dr["exp_date"] != System.DBNull.Value)
                        lvi.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));   //3
                    else
                        lvi.SubItems.Add("-");
                    lvi.SubItems.Add(dr["Pack_type"].ToString());                                   //4
                    lvi.SubItems.Add(dr["pack_qty"].ToString());                                    //5
                    lvi.SubItems.Add(Convert.ToDecimal(dr["Mrp"]).ToString("####.00"));             //6
                    lvi.SubItems.Add(Convert.ToDecimal(dr["usr"]).ToString("####.00"));       //7
                    lvi.SubItems.Add(Convert.ToInt32(dr["sale_qty"]).ToString());                                    //9
                    lvi.SubItems.Add(Convert.ToDecimal(dr["sv"]).ToString("####.00"));
                    lvi.SubItems.Add(dr["sale_trn_no"].ToString());
                    ItemSaleGrid.Items.Add(lvi);
                }
                DisableButtons();
                #endregion

            }
            if(_ds.Tables.Count>0 && _ds.Tables[0].Rows.Count > 0)
            {
                #region Filling Summary of Bill
                txtTotal.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["total"]).ToString("####.00");
                txtDiscount.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["discount"]).ToString("####.00");
                txtRoundoff.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["roundoff"]).ToString("####.00");
                txtPayable.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["net"]).ToString("####");
   
                #endregion
            }
            Cursor.Current = Cursors.Default;
        }

        private void DisableButtons()
        {
            if (ItemSaleGrid.Items.Count > 0 )
            {
                btnPrintIS.Enabled = true;
                if (GlobalUsage.Posting_Rights == "Y")
                    btnCompleteSale.Enabled = true;
                else
                    btnCompleteSale.Enabled = false;
            }
            else
            {
                btnCompleteSale.Enabled = false;
                btnPrintIS.Enabled = false;
            }
           
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            //btnCompleteSale.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (GlobalUsage.Posting_Rights == "Y")
                {
                    if (((Conversion.Val(txtPayable.Text) > 0) || Conversion.Val(txtPayable.Text) < 0))
                    {
                        #region Proess Body
                        DialogResult dr = MessageBox.Show("Do You Confirm To Finalize The Bill No. " + txtInvNo.Text + " ? ", "ExPro Help", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                try
                                {
                                    _PayMode = "Credit";
                                   
                                    //SaleInvoiceFinalization p = new SaleInvoiceFinalization();
                                    //p.unit_id = GlobalUsage.Unit_id; p.computerName = GlobalUsage.computerName;
                                    //p.counter_id = GlobalUsage.CounterID; p.Sale_Inv_No = txtInvNo.Text; p.pt_name = cbxPtName.Text;
                                    //p.gstn_no = "-"; p.HealthCardNo = _cardNo; p.Hosp_Cr_No = _UHID; p.Hosp_IPOP_No = _ipopno;
                                    //p.rcmOrderNo = _order_no; p.hd_flag = "N"; p.refBy = _doctor_id; p.ref_name = txtRefBy.Text;
                                    //p.payMode = _PayMode; p.payDetail = "-"; p.login_id = GlobalUsage.Login_id;
                                    //datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/SaleInvoiceFinalization", p);

                                    pm_sales p = new pm_sales();
                                    p.unit_id = GlobalUsage.Unit_id;
                                    p.sale_inv_no = txtInvNo.Text; p.party_id = "VC50668";p.HealthCardNo = _cardNo;p.rcmOrderNo = _order_no;
                                    p.cust_name = cbxPtName.Text; p.account_id = "13061722";p.sale_type = "Indent";
                                    p.gstn_no = "09AABCC9314K1ZH"; ;
                                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/ICTVBillFinalization", p);
                                    DataSet ds = dwr.result;

                                    if (!dwr.message.Contains("Successfully"))
                                    {

                                        MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        string[] r = dwr.message.Split(':');
                                        txtInvNo.Text = r[1];
                                        _neworder_no = "New";
                                        //try
                                        //{
                                        //    DialogResult res = RadMessageBox.Show("Do You Confirm  to Print ?", "ExPro Help", MessageBoxButtons.YesNo);
                                        //    if (res == DialogResult.Yes)
                                        //    {
                                        //        Cursor.Current = Cursors.WaitCursor;
                                        //        cm1 p1 = new cm1();
                                        //        p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                                        //        p1.Logic = "PRN:Invoice_Info"; p1.prm_1 = txtInvNo.Text;
                                        //        dwr = ConfigWebAPI.CallAPI("api/sales/WholeSaleQueries", p1);
                                        //        ds = dwr.result;
                                        //        Printing.Laser.ICTV_Invoice(ds, txtInvNo.Text);
                                        //    }
                                        //}
                                        //catch (Exception ex)
                                        //{
                                        //    RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
                                        //}
                                        //finally { Cursor.Current = Cursors.Default; }

                                        reset();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "ExPro Help");
                                }
                                break;
                            case DialogResult.No: break;
                        }
                        #endregion
                    }
                }
                else {
                    RadMessageBox.Show("Posting of Bill Not Allowed.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { 
            Cursor.Current = Cursors.Default; }
        }
        protected void printCashMemo(string inv_no)
        {
            if (MessageBox.Show("Do You Want To Print Bill No " + inv_no, "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(GlobalUsage.PrinterType.ToUpper().ToUpper() == "LASER")
                Printing.Laser.CashMemoHospitalIndent(inv_no, "Y","Y");
            }
        }
        private void makeSale(string item_id, string masterkey, int qty)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            datasetWithResult dwr = new datasetWithResult(); ;
            string Ret_SalesInvNo = string.Empty;
            #region Saving of Record
            try
            {
                if (chkCorporate.Checked)
                    _cardNo = "CORP-PANEL";

                
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;p.sale_type = "Indent";
                p.sale_inv_no = txtInvNo.Text; p.party_id = "VC50668"; p.account_id = "13061722";p.logic = "Indent";
                p.order_no = _order_no;
                p.item_id = item_id; p.master_key_id = masterkey; p.sale_qty = Convert.ToInt16(qty);
                dwr = ConfigWebAPI.CallAPI("api/sales/ICTVInetrCompanyToVendor", p);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Refresh Sales Item Grid
            if (dwr.message.Contains("E"))
            {
                chkCorporate.Checked = false;
                string strItemId = "'" + item_id + "'";
                DataSet dsStock = dwr.result;
                if (dsStock.Tables.Count > 0 && dsStock.Tables[2].Rows.Count > 0)
                {
                    int pending = Convert.ToInt32(dsStock.Tables[2].Rows[0]["pendQty"]);
                    var lvorder = lvOrder.Items.Cast<ListViewItem>().Where(x => x.Text == item_id).First();
                    lvorder.SubItems[2].Text = Convert.ToInt32(dsStock.Tables[2].Rows[0]["StockQty"]).ToString("##0");
                    lvorder.SubItems[4].Text = pending.ToString();
                   if(pending==0)
                        lv_batchno.Items.Clear();
                   else
                        GetBatch(_items_id);
                }
                #region Grid Filling Process
                //string[] r = dwr.message.Split('|');
                txtInvNo.Text = dwr.result.Tables[0].Rows[0]["sale_inv_no"].ToString();
                Fill_ItemSalesGrid(txtInvNo.Text);
                txtTotal.Text = Convert.ToDecimal(dwr.result.Tables[0].Rows[0]["total"]).ToString("####.00");
                txtDiscount.Text = Convert.ToDecimal(dwr.result.Tables[0].Rows[0]["discount"]).ToString("####.00");
                txtPayable.Text = Convert.ToDecimal(dwr.result.Tables[0].Rows[0]["payable"]).ToString("####");
                txtRoundoff.Text = Convert.ToDecimal(dwr.result.Tables[0].Rows[0]["roundoff"]).ToString("##.00");
                #endregion
               
            }
            #endregion

        }
        private void lvOrder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            TOrdqty = Convert.ToDecimal(e.Item.SubItems[4].Text);
            _items_id = e.Item.Text;
            _itemindex = e.Item.Index;
            lv_batchno.Enabled = true;
            _itemName = e.Item.SubItems[1].Text;

            if(e.Item.SubItems[5].Text!="-")
                lblAlert.Text = "Alert : " + e.Item.SubItems[5].Text;
            else
                lblAlert.Text = "";
            lv_batchno.Items.Clear();
            if (TOrdqty!=0 )
            GetBatch(_items_id);
            else
                lblItemName.Text = _itemName + '{' + _items_id + '}';
        }
        private void ItemSaleGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dlgresult = MessageBox.Show("Do You confirm to delete Selected Record ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgresult.ToString() == "Yes")
                {
                    try
                    {
                        int indx = ItemSaleGrid.FocusedItem.Index;
                        decimal qty = Convert.ToDecimal(ItemSaleGrid.Items[ItemSaleGrid.FocusedItem.Index].SubItems[9].Text);
 

                        DataSet ds = new DataSet();
                        pm_SalesAction1 p = new pm_SalesAction1();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.Sales_Inv_No = txtInvNo.Text;
                        p.master_key_id = ItemSaleGrid.FocusedItem.SubItems[2].Text; p.Sale_Trn_No = ItemSaleGrid.FocusedItem.SubItems[11].Text;
                        p.order_no = _order_no; p.logic = "IndentProcessByWH";
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/DeleteSalesEntry", p);
                        ds = dwr.result;

                        DataRow dr = ds.Tables[0].Rows[0];
                        if(dwr.message.Contains("Success"))
                        {
                            txtTotal.Text = Convert.ToDecimal(dr["total"]).ToString("####.00");
                            txtDiscount.Text = Convert.ToDecimal(dr["discount"]).ToString("####.00");
                            txtRoundoff.Text = Convert.ToDecimal(dr["roundoff"]).ToString("####.00");
                            txtPayable.Text = Convert.ToDecimal(dr["payable"]).ToString("####");
                            if (ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
                            {

                                //pm_UpdateIndent p1 = new pm_UpdateIndent();
                                //p1.unit_id = GlobalUsage.Unit_id; p1.ipopno = _ipopno;p1.indent_no = _order_no; p1.item_id = ItemSaleGrid.FocusedItem.Text;
                                //p1.qty = Convert.ToInt32(qty);
                                //p1.prm_1 = "-";p1.logic = "Delete"; p1.login_id = GlobalUsage.Login_id;
                                //datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/hospital/updateIndent", p1);
                                //string[] r = dwr1.message.Split('|');
                                //int pending = Convert.ToInt16(r[1]);
                                int pending = Convert.ToInt16(ds.Tables[1].Rows[0]["pendQty"]);
                                var lvorder = lvOrder.Items.Cast<ListViewItem>().Where(x => x.Text == ItemSaleGrid.FocusedItem.Text).First();
                                lvorder.SubItems[2].Text =ds.Tables[1].Rows[0]["qty"].ToString();
                                lvorder.SubItems[4].Text = pending.ToString();
                            }
                            ItemSaleGrid.Items[ItemSaleGrid.FocusedItem.Index].Remove();
                            GetBatch(_items_id);

                        }
                        else
                        {
                            Fill_ItemSalesGrid(txtInvNo.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    DisableButtons();
                }
            }
        }
        private void lv_batchno_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                var sale_qty = ItemSaleGrid.Items.Cast<ListViewItem>()
               .Where(x => x.Text == _items_id).Sum(y => Convert.ToDecimal(y.SubItems[9].Text));
                if(TOrdqty >= sale_qty + Convert.ToDecimal(e.Item.SubItems[7].Text))
                {
                    makeSale(_items_id, e.Item.Text, Convert.ToInt32(e.Item.SubItems[7].Text));
                }
                else
                {
                    if (Convert.ToInt32(TOrdqty - sale_qty) > 0)
                    {
                        makeSale(_items_id, e.Item.Text, Convert.ToInt32(TOrdqty - sale_qty));
                    }
                    else if (TOrdqty < 0)
                    {
                        makeSale(_items_id, e.Item.Text, Convert.ToInt32(TOrdqty - sale_qty));
                    }
                    lv_batchno.Enabled = false;
                }
            }
        }
        private void lvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _index = lvOrder.FocusedItem.Index;
                string item_name = lvOrder.Items[lvOrder.FocusedItem.Index].SubItems[1].Text;
                objSwap = new eMediShop.Utility.SwapProduct(item_name, 0, lvOrder.Items[lvOrder.FocusedItem.Index].Text, "Indent", _order_no);
                objSwap.SearchUpdated += new SearchCashMemoEventHandler(UpdateItemByNewMed);
                objSwap.Show();
            }
        }
        private void UpdateItemByNewMed(object sender, CashMemeoNoUpdatedEventArgs e)
        {
            string old_itemid = e.CASHMEMONO.Split('|')[0];
            string new_itemid = e.CASHMEMONO.Split('|')[1];
            string new_itemname = e.CASHMEMONO.Split('|')[2];
            customerOrders o = new customerOrders();
            o.order_no = _order_no; o.item_id = new_itemid; o.old_item_id = old_itemid;
            o.new_med = "N/A"; o.qty = 0; o.cancel_flag = "N"; o.logic = "Replace"; o.login_id = GlobalUsage.Login_id;
            
            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/hospital/IPOPReplaceProduct", o);

            string result = dwr1.message;
            
            if (result.Contains("Successfully"))
            {
                DataSet dsStock = new DataSet();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.prm_1 = "N/A";p.prm_2 = "N/A";p.prm_3 = new_itemid + ","; p.Logic = "StockofItems"; p.login_id =GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
                dsStock = dwr.result;
                if (dsStock.Tables.Count > 0 && dsStock.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dsOrder.Tables[0].Select("item_id = '" + old_itemid + "'"))
                    {
                        row[0] = new_itemid;
                        row[1] = new_itemname;
                    }
                    dsOrder.Tables[0].AcceptChanges();
                    lvOrder.Items[_index].SubItems[0].Text = new_itemid;
                    lvOrder.Items[_index].SubItems[1].Text = new_itemname;
                    lvOrder.Items[_index].SubItems[2].Text = dsStock.Tables[0].Rows[0]["qty"].ToString();
                    if (Convert.ToDecimal(dsStock.Tables[0].Rows[0]["qty"]) < Convert.ToDecimal(lvOrder.Items[_index].SubItems[4].Text))
                        lvOrder.Items[_index].ForeColor = Color.Red;
                    else
                        lvOrder.Items[_index].ForeColor = Color.Black;
                }
                else
                {
                    lvOrder.Items[_index].SubItems[0].Text = new_itemid;
                    lvOrder.Items[_index].SubItems[1].Text = new_itemname;
                    lvOrder.Items[_index].SubItems[2].Text = "0";
                    lvOrder.Items[_index].ForeColor = Color.Red;
                }
            }
        }
        private void Search_SearchUpdated(object sender, CashMemeoNoUpdatedEventArgs e)
        {
            this.txtInvNo.Text = e.CASHMEMONO;
            HoldOrderInfo(this.txtInvNo.Text, "HOLD");
        }

        private void HoldOrderInfo(string salesInvNo, string CallFrom)
        {
            Fill_ItemSalesGrid(salesInvNo);
            DataSet ds = new DataSet();
            ds = GlobalUsage.pharmacy_proxy.RCM_Queries(out _result, GlobalUsage.Unit_id, _order_no, "-", "Info", "1900/01/01", "GET_ORDER");
            _orderDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["orderDate"].ToString()).ToString("yyyy/MM/dd");
            _promoTag = ds.Tables[0].Rows[0]["pd_flag"].ToString();
           //if(CallFrom == "HOLD")
            FillOrderDetail(_UHID,_order_no);
            DisableButtons();
        }
        private void rbtn_prescription_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                System.IO.FileInfo fi = new System.IO.FileInfo(((Telerik.WinControls.UI.RadButton)sender).Tag.ToString());
                byte[] data = GlobalUsage.accounts_proxy.DownloadFile(((Telerik.WinControls.UI.RadButton)sender).Tag.ToString(), out _result);
                System.IO.File.WriteAllBytes(Application.StartupPath + "\\" + Environment.MachineName + "Temp" + fi.Extension, data);
                System.Diagnostics.Process.Start(Application.StartupPath + "\\" + Environment.MachineName + "Temp" + fi.Extension);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPrintIS_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You want to Print (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    printCashMemo(txtInvNo.Text);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        //private void rgv_orders_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        //{
        //    if (e.RowElement.RowInfo.Cells["flag"].Value.ToString() == "Y")
        //        e.RowElement.ForeColor = Color.Red;
        //    else
        //        e.RowElement.ForeColor = Color.Blue;
        //}
        private void reset()
        {
            _HISPUSH_Flag = "N";_CreditFlag = "N";
            txtInvNo.Text = "New Invoice";
            ItemSaleGrid.Items.Clear();
            lv_batchno.Items.Clear();
            txtTotal.Text = "0"; txtDiscount.Text = "0"; txtRoundoff.Text = "0";txtPayable.Text = "0";
            btnCompleteSale.Enabled = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportOPD(txtInvNo.Text);
        }

        private void ImportOPD(string indentNo)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = IPOPQueries("1900/01/01", "1900/01/01", "-", "-", "PendingIndentbyNO", indentNo);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    _panelName = ds.Tables[0].Rows[0]["panel_name"].ToString().ToUpper();
                    if (_panelName == "CASH")
                    {
                        chkCorporate.Checked = false;
                        chkCorporate.Enabled = true;
                    }
                    else
                    {
                        chkCorporate.Checked = true;
                        chkCorporate.Enabled = false;
                    }
                    
                    dgIndentInfo.DataSource = ds.Tables[0];
                }
                else
                {
                    string response = GlobalUsage.his_proxy.getDcotorIndentByUHID(indentNo);
                    if (response.Length > 10)
                    {
                        pm_PullHISIndent p = new pm_PullHISIndent();
                        p.inputstring = response;p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/PullHISIndent", p);
                        string[] r = dwr.message.Split('|');
                        string indent = r[1]; 
                        
                        if (r[0].Contains("Success"))
                        {
                            GlobalUsage.his_proxy.closeOPDIndent(indent);
                            LoadPendingIndent();
                        }
                    }
                 
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtIPOPNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ImportOPD(txtInvNo.Text);
            }
        }
        private void dgIndentInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            FillDetails();
        }

        private void FillDetails()
        {
            try
            {
                _CreditFlag = "N";
                _panelName = dgIndentInfo.CurrentRow.Cells["panel_name"].Value.ToString().ToUpper();
                if (_panelName.ToUpper() == "CASH")
                {
                    _CreditFlag = "N";
                    chkCorporate.Checked = false;
                    chkCorporate.Enabled = false;
                }
                else
                {
                    _CreditFlag= dgIndentInfo.CurrentRow.Cells["credit_flag"].Value.ToString();
                    chkCorporate.Checked = true;
                    chkCorporate.Enabled = false;
                }
                if (_CreditFlag == "N")
                {
                    pnlPaymode.Visible = true;
                    txtChqueNo.Visible = true;
                    chkByCredit.Visible = false;
                    chkByCredit.Checked = false;
                }
                else if(_CreditFlag=="Y")
                {
                    pnlPaymode.Visible = false;
                    txtChqueNo.Visible = false;
                    chkByCredit.Visible = true;
                    chkByCredit.Checked = true;
                }
                string indent_type = dgIndentInfo.CurrentRow.Cells["indent_type"].Value.ToString();
                _order_no = dgIndentInfo.CurrentRow.Cells["indent_no"].Value.ToString();
                _HISPUSH_Flag= dgIndentInfo.CurrentRow.Cells["hispush_flag"].Value.ToString();
                _UHID = dgIndentInfo.CurrentRow.Cells["UHID"].Value.ToString();
                cbxPtName.Text = dgIndentInfo.CurrentRow.Cells["pt_name"].Value.ToString();
                _ipopno = dgIndentInfo.CurrentRow.Cells["ipop_no"].Value.ToString();
                _old_sale_inv_no = "-";// dgIndentInfo.CurrentRow.Cells["old_sale_inv_no"].Value.ToString();
                prescription_from = dgIndentInfo.CurrentRow.Cells["prescribed_from"].Value.ToString();
                txtCorpName.Text = dgIndentInfo.CurrentRow.Cells["panel_name"].Value.ToString();
                string cartId= dgIndentInfo.CurrentRow.Cells["CartId"].Value.ToString();
                _result = GlobalUsage.his_proxy.getPatientStatusByIpdNo(_ipopno);
                if (_result == "IN" || cartId.ToUpper()=="WC0155")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    radPanel2.Visible = true;
                    radPanel3.Visible = true;
                    if (chkCorporate.Checked)
                    {
                        _discountPercentage = 0;
                        _cardNo = "CORP-PANEL";
                    }
                    else
                        _discountPercentage = 10;

                    FillOrderDetail(_UHID,_order_no);
                }
                else
                {
                    RadMessageBox.Show("Patient has been discharged. You can not process bill.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    if (chkCorporate.Checked)
                    {
                        _discountPercentage = 0;
                        _cardNo = "CORP-PANEL";
                    }
                    else
                        _discountPercentage = 10;

                    FillOrderDetail(_UHID, _order_no);
                    radPanel3.Visible = false;
                    radPanel2.Visible = false;
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }
        }

        private void lvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCash.Checked)
            {
                _PayMode = "Cash";
                txtChqueNo.Enabled = false;
                chkChq.Checked = false;
                chkSwipeCard.Checked = false;
            }
        }

        private void chkSwipeCard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSwipeCard.Checked)
            {
                _PayMode = "Credit Card";
                txtChqueNo.Enabled = true;
                chkChq.Checked = false;
                chkCash.Checked = false;
            }
        }

        private void chkChq_CheckedChanged(object sender, EventArgs e)
        {
            if(chkChq.Checked)
            {
                _PayMode = "Cheque";
                txtChqueNo.Enabled = true;
                chkSwipeCard.Checked = false;
                chkCash.Checked = false;
            }
        }
    
        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            try { 
            if (e.RowElement.RowInfo.Cells["cur_flag"].Value.ToString() == "C")
            {
                e.RowElement.ForeColor = Color.Green;
            }
            else
            {
                e.RowElement.ForeColor = Color.Red;
            }
            } catch{ };
        }

        private void dgIndentInfo_SelectionChanged(object sender, EventArgs e)
        {
            FillDetails();
        }

        private void btnSoldToInterCompany_Click(object sender, EventArgs e)
        {

        }
    }
}
