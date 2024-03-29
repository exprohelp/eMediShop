using ExPro.Client;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.contract
{
    public partial class ProcessOrderDelivery : Telerik.WinControls.UI.RadForm
    {
        eMediShop.Utility.SwapProduct objSwap;
        private CashMemoSearch frmCashMemoSearch;
        private sales.SaleBill_Posting frmsaleBillPosting;
        string _result = string.Empty; string _card_Level = string.Empty;
        string _cardNo = string.Empty; string _contactNo = string.Empty;
        string _order_no = string.Empty; string _orderDate = string.Empty;
        string _neworder_no = string.Empty;
        string _items_id = string.Empty; string _deliveryDate = string.Empty; string _deliveryTime = string.Empty;
        decimal TOrdqty = 0; string _promoTag = string.Empty;
        int _index = 0;
        int _itemindex = 0;
        int _ordindex = -1;
        ListViewItem item;
        private System.Windows.Forms.TextBox _sale_qty = new System.Windows.Forms.TextBox();
        int selectedSubItem = 0; string column = string.Empty;
        int X = 0; int Y = 0; int position = 0;
        string subItemText = "";
        string _orderdate = ""; string _cardStatus = string.Empty; decimal _discountPercentage = 0;
        DataSet dsOrder = new DataSet();
        public ProcessOrderDelivery()
        {
            InitializeComponent();
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

        }

        private void loadOrder()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Procedure In Customer_data
                DataSet ds = new DataSet();

                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "PendingOrderListNew";
                datasetWithResult dwr;
                dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                ds = dwr.result;

                p.Logic = "UnPostedNew";
                dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                DataSet hb_ds = dwr.result;

                var Order = ds.Tables[0].AsEnumerable().Select(s => new
                {
                    card_no = s.Field<string>("card_no"),
                    card_type = s.Field<string>("cardtype"),
                    disc_per = s.Field<decimal>("disc_per"),
                    order_no = s.Field<string>("order_no"),
                    cust_name = s.Field<string>("cust_name"),
                    info = s.Field<string>("cust_name") + " [" + s.Field<string>("ordInfo") + "]",
                    promo_flag = s.Field<string>("pd_flag"),
                    remarks = s.Field<string>("remarks"),
                    order_date = s.Field<string>("order_date"),
                    del_date = s.Field<DateTime>("del_date"),
                    del_time = s.Field<string>("del_time"),
                    prescribedBy = s.Field<string>("prescribe_by"),
                    contactNo = s.Field<string>("contactNo"),
                    ord_cr_date = s.Field<DateTime>("ord_cr_date"),
                    home_del = s.Field<string>("home_del"),
                });

                var holdBills = hb_ds.Tables[0].AsEnumerable().Select(h => new { sale_inv_no = h.Field<string>("sale_inv_no"), order_no = h.Field<string>("order_no") });

                var orderList = (from o in Order
                                 join b in holdBills on o.order_no equals b.order_no into g
                                 from b in g.DefaultIfEmpty()
                                 select new
                                 {
                                     card_no = o.card_no,
                                     order_no = o.order_no,
                                     card_type = o.card_type,
                                     disc_per = o.disc_per,
                                     info = o.info,
                                     order_date = o.order_date,
                                     cust_name = o.cust_name,
                                     promo_flag = o.promo_flag,
                                     remarks = o.remarks,
                                     prescribedBy = o.prescribedBy,
                                     sale_inv_no = b != null ? b.sale_inv_no : "New Invoice",
                                     flag = b != null ? "Y" : "N",
                                     del_date = o.del_date,
                                     del_time = o.del_time,
                                     ord_cr_date = o.ord_cr_date,
                                     contactNo = o.contactNo,
                                     home_del = o.home_del
                                 }).OrderBy(z => z.order_no);



                rgv_orders.DataSource = orderList;


            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            SelectedOrder();
        }

        private void SelectedOrder()
        {
            try
            {
                lvOrder.Enabled = true;
                lv_batchno.Items.Clear();
                ItemSaleGrid.Items.Clear();

                txtInvNo.Text = rgv_orders.CurrentRow.Cells["sale_inv_no"].Value.ToString();
                FillOrderDetail(_order_no);
                if (rgv_orders.CurrentRow.Cells["flag"].Value.ToString() == "Y")
                    Fill_ItemSalesGrid(txtInvNo.Text);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void FillOrderDetail(string order_no)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                lvOrder.Items.Clear();
                cm1 p2 = new cm1();
                p2.unit_id = GlobalUsage.Unit_id; p2.login_id = GlobalUsage.Login_id; p2.prm_1 = order_no;
                p2.Logic = "OrderDetail";
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/hal/halQueries", p2);
                dsOrder = dwr1.result;

                string strItemId = string.Empty;
                if (dsOrder.Tables.Count > 0 && dsOrder.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in dsOrder.Tables[0].Rows)
                    {
                        strItemId += "'" + dr["item_id"].ToString() + "'" + ",";
                    }
                    strItemId = strItemId.Substring(0, strItemId.Length - 1);

                    productSearch p1 = new productSearch();
                    p1.unit_id = GlobalUsage.Unit_id; p1.item_id = "N/A"; p1.logic = "OrderProcess"; p1.prm_1 = strItemId;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", p1);


                    DataSet dsStock = dwr.result;

                    var Order = dsOrder.Tables[0].AsEnumerable().Select(s => new { OItemId = s.Field<string>("item_id"), Item_name = s.Field<string>("item_name"), O_Qty = s.Field<decimal>("ordqty") });
                    var Stock = dsStock.Tables[0].AsEnumerable().Select(l => new { SItemId = l.Field<string>("Item_id"), stk_qty = l.Field<decimal>("qty") });
                    var itemList = (from p in Order
                                    join c in Stock on p.OItemId equals c.SItemId into g
                                    from c in g.DefaultIfEmpty()
                                    select new
                                    {
                                        ItemId = p.OItemId,
                                        ItemName = p.Item_name,
                                        OrdQty = p.O_Qty,
                                        stk_qty = c != null ? c.stk_qty : 0,
                                    }).OrderBy(z => z.ItemName);
                    this.lvOrder.ItemSelectionChanged -= new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrder_ItemSelectionChanged);
                    foreach (var dr in itemList)
                    {
                        ListViewItem lv = new ListViewItem(dr.ItemId);
                        lv.SubItems.Add(dr.ItemName);
                        lv.SubItems.Add(dr.stk_qty.ToString());
                        lv.SubItems.Add(Convert.ToInt16(dr.OrdQty).ToString());
                        if (dr.OrdQty > dr.stk_qty)
                            lvOrder.Items.Add(lv).ForeColor = Color.Red;
                        else
                            lvOrder.Items.Add(lv);

                    }
                    this.lvOrder.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrder_ItemSelectionChanged);
                }
                if (dsOrder.Tables.Count > 0)
                {
                    txtRefBy.Text = dsOrder.Tables[0].Rows[0]["ref_by"].ToString();
                    cbxPtName.Text = dsOrder.Tables[0].Rows[0]["cust_name"].ToString();
                }



            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            DisableButtons();
            Cursor.Current = Cursors.Default;
        }

        private void GetBatch(string _item_id)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            productSearch p = new productSearch();
            p.unit_id = GlobalUsage.Unit_id; p.item_id = _item_id; p.logic = "AutoSales"; p.prm_1 = "N/A";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockWithBatchNos", p);
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
            Cursor.Current = Cursors.WaitCursor;
            pm_SalesAction1 p = new pm_SalesAction1();
            p.unit_id = GlobalUsage.Unit_id; p.Sales_Inv_No = Sale_Inv_No; p.order_no = "N/A";
            p.logic = "SalesInvoice";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/GetSalesInvoice_Info", p);

            DataSet _ds = dwr.result;
            ItemSaleGrid.Items.Clear();
            if (_ds.Tables[1].Rows.Count > 0)
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
            if (_ds.Tables[0].Rows.Count > 0)
            {
                #region Filling Summary of Bill
                txtTotal.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["total"]).ToString("####.00");
                txtDiscount.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["discount"]).ToString("####.00");
                txtRoundoff.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["roundoff"]).ToString("####.00");
                txtPayable.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["net"]).ToString("####");
                _cardNo = _ds.Tables[0].Rows[0]["Card_no"].ToString();
                _order_no = _ds.Tables[0].Rows[0]["order_no"].ToString();

                #endregion
            }
            Cursor.Current = Cursors.Default;
        }

        private void DisableButtons()
        {
            if (ItemSaleGrid.Items.Count > 0 && _promoTag == "N")
            {
                btnPrintIS.Enabled = true;
                btnCompleteSale.Enabled = true;
            }
            else if (ItemSaleGrid.Items.Count > 0 && _promoTag == "Y" && Convert.ToDateTime(_orderDate) <= DateTime.Today)
            { btnPrintIS.Enabled = true; btnCompleteSale.Enabled = true; }
            else
            {
                btnCompleteSale.Enabled = false;
                btnPrintIS.Enabled = false;
            }
            if (ItemSaleGrid.Items.Count > 0)
            {
                btnPrintIS.Enabled = true;
            }

        }


        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            //btnCompleteSale.Enabled = false;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (((Conversion.Val(txtPayable.Text) > 0) || Conversion.Val(txtPayable.Text) < 0))
                {
                    if (GlobalUsage.Posting_Rights == "Y")
                    {
                        BillPosting b = new BillPosting();
                        b.sale_inv_no = txtInvNo.Text;
                        b.card_no = _cardNo; b.customer_name = cbxPtName.Text; b.ipopNo = "-"; b.panelName = "Retail Sales";
                        b.panelType = "Credit"; b.prescribedBy = txtRefBy.Text; b.uhidNo = "-";
                        b.AccountID = "13020298"; b.gstNo = "09AAACH3641R1Z5";
                        b.amount = Convert.ToInt32(txtPayable.Text);
                        if ((string)rtBtn.Tag == "HD")
                            b.HomeDelivery = "Y";
                        else
                            b.HomeDelivery = "N";

                        b.mobileNo = _contactNo;
                
                            try
                            {
                                DialogResult res = RadMessageBox.Show("Do You Confirm (Y/N) ", "ExPro Help", MessageBoxButtons.YesNo);
                                if (res == DialogResult.Yes)
                                {
                                    SaleInvoiceFinalization p = new SaleInvoiceFinalization();
                                    p.unit_id = GlobalUsage.Unit_id; p.Sale_Inv_No = txtInvNo.Text; p.rcmOrderNo = _order_no;
                                    p.login_id = GlobalUsage.Login_id;
                                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/HalDeliveryFinalization", p);
                                    if (!dwr.message.Contains("Success"))
                                        MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    else
                                    {
                                        string[] d = dwr.message.Split(':');
                                        txtInvNo.Text = d[1];
                                        printCashMemo(txtInvNo.Text);
                                        
                                        btnPrintIS.PerformClick();
                                    reset();

                                }


                                }
                            }
                            catch (Exception ex)
                            {
                                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
                            }
                            finally { Cursor.Current = Cursors.Default; }
                        

                    }
                    else
                    {
                        RadMessageBox.Show("Posting of Bill Not Allowed.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        protected void printCashMemo(string inv_no)
        {
            if (MessageBox.Show("Do You Want To Print Delivery Note ?  " + inv_no, "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (GlobalUsage.PrinterType.ToUpper().ToUpper() == "LASER")
                    Printing.Laser.HAL_DeliveryNote(inv_no, "Y");
            }
        }
        private void BillPostingUpdated(object sender, BillPostingUpdatedEventArgs e)
        {
            this.txtInvNo.Text = e.SaleInvNo;
            if (e.result.ToUpper() == "POSTED")
            {
                printDeliveryNote(txtInvNo.Text);
                //ReOrderPendingItems();//Auto Re-Order Pending List
                reset();
            }
        }
        protected void printDeliveryNote(string inv_no)
        {
            if (MessageBox.Show("Do You Want To Print Delivery Note ? " + inv_no, "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (GlobalUsage.PrinterType.ToUpper().ToUpper() == "LASER")
                    Printing.Laser.HAL_DeliveryNote(inv_no, "Y");
            }
        }
        private void makeSale(string item_id, string masterkey, int qty)
        {
            DataSet ds = new DataSet();
            datasetWithResult dwr = new datasetWithResult();
            Cursor.Current = Cursors.WaitCursor;
            #region Saving of Record
            try
            {

                pm_InsertRetailSales p = new pm_InsertRetailSales();
                p.unit_id = GlobalUsage.Unit_id;
                p.counter_id = GlobalUsage.CounterID; p.computer_id = GlobalUsage.computerName; p.Sale_Type = "RO-PROCESS";
                p.cust_name = cbxPtName.Text; p.prescribedBy = rgv_orders.CurrentRow.Cells["prescribedBy"].Value.ToString();
                p.refCode = "New";
                p.item_id = item_id; p.master_key_id = masterkey;
                p.card_no = _cardNo; p.card_level = _card_Level; p.discountPercent = _discountPercentage;
                p.sold_qty = Convert.ToDouble(qty); p.ContactNo = _contactNo;
                p.old_sale_inv_no = GlobalUsage.Old_Sale_Inv_No; p.gstn_no = "-"; p.hosp_cr_no = "-"; p.hosp_ipop_no = "-";
                p.Cur_sale_inv_no = txtInvNo.Text; p.DiscountLogic = "New"; p.order_no = _order_no; p.promo_flag = _promoTag;
                p.login_id = GlobalUsage.Login_id;
                p.stateName = GlobalUsage.State;
                dwr = ConfigWebAPI.CallAPI("api/sales/InsertRetailSales", p);
                ds = dwr.result; _result = dwr.message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Refresh Sales Item Grid
            if (_result.Contains("Success"))
            {
                #region Grid Filling Process
                string[] r = _result.Split('|');
                txtInvNo.Text = r[1];

                Fill_ItemSalesGrid(txtInvNo.Text);
                txtTotal.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["total"]).ToString("####.00");
                txtDiscount.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["discount"]).ToString("####.00");
                txtPayable.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["payable"]).ToString("####");
                txtRoundoff.Text = Convert.ToDecimal(ds.Tables[0].Rows[0]["roundoff"]).ToString("##.00");
                #endregion

                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.prm_1 = txtInvNo.Text; p.prm_2 = _order_no;
                p.prm_3 = item_id + ","; p.Logic = "StockofItems"; p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);

                DataSet dsStock = dwr.result;
                if (dsStock.Tables.Count > 0 && dsStock.Tables[0].Rows.Count > 0)
                {
                    var lvorder = lvOrder.Items.Cast<ListViewItem>().Where(x => x.Text == item_id).First();
                    lvorder.SubItems[2].Text = dsStock.Tables[0].Rows[0]["qty"].ToString();
                }
                try
                {
                    customerOrders o = new customerOrders();
                    o.order_no = _order_no; o.sale_inv_no = txtInvNo.Text; o.item_id = item_id;
                    o.master_key_id = masterkey; o.qty = qty; o.login_id = GlobalUsage.Login_id; o.logic = "Insert";
                    dwr = ConfigWebAPI.CallAPI("api/customerdata/InsertCustHoldSalesInfo", o);
                }
                catch (Exception ex) { }
            }

            #endregion
            Cursor.Current = Cursors.Default;
        }
        private void lvOrder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            TOrdqty = Convert.ToDecimal(e.Item.SubItems[3].Text);
            _items_id = e.Item.Text;
            _itemindex = e.Item.Index;
            lv_batchno.Enabled = true;
            lblItemName.Text = e.Item.SubItems[1].Text;
            lv_batchno.Items.Clear();
            GetBatch(_items_id);
        }
        private void ItemSaleGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dlgresult = MessageBox.Show("Do You confirm to delete Selected Recored ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgresult.ToString() == "Yes")
                {
                    try
                    {
                        int indx = ItemSaleGrid.FocusedItem.Index;
                        decimal qty = Convert.ToDecimal(ItemSaleGrid.Items[ItemSaleGrid.FocusedItem.Index].SubItems[9].Text);
                        DataSet ds = new DataSet();
                        pm_SalesAction1 p = new pm_SalesAction1();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.Sales_Inv_No = txtInvNo.Text;
                        p.master_key_id = ItemSaleGrid.FocusedItem.SubItems[2].Text;
                        p.Sale_Trn_No = ItemSaleGrid.FocusedItem.SubItems[11].Text;
                        p.order_no = "N/A"; p.logic = "SalesInvoice";
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/DeleteSalesEntry", p);
                        ds = dwr.result;
                        DataRow dr = ds.Tables[0].Rows[0];
                        if (_result.Contains("Success"))
                        {
                            customerOrders o = new customerOrders();
                            o.order_no = _order_no; o.sale_inv_no = txtInvNo.Text; o.item_id = "N/A";
                            o.master_key_id = ItemSaleGrid.FocusedItem.SubItems[2].Text;
                            o.qty = 0; o.login_id = GlobalUsage.Login_id; o.logic = "Delete";
                            dwr = ConfigWebAPI.CallAPI("api/customerdata/InsertCustHoldSalesInfo", o);

                            txtTotal.Text = Convert.ToDecimal(dr["total"]).ToString("####.00");
                            txtDiscount.Text = Convert.ToDecimal(dr["discount"]).ToString("####.00");
                            txtRoundoff.Text = Convert.ToDecimal(dr["roundoff"]).ToString("####.00");
                            txtPayable.Text = Convert.ToDecimal(dr["payable"]).ToString("####");
                            if (ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
                            {
                                var lvorder = lvOrder.Items.Cast<ListViewItem>().Where(x => x.Text == ItemSaleGrid.FocusedItem.Text).First();
                                lvorder.SubItems[2].Text = ds.Tables[1].Rows[0]["qty"].ToString();
                            }
                            ItemSaleGrid.Items[ItemSaleGrid.FocusedItem.Index].Remove();

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

                if (TOrdqty >= sale_qty + Convert.ToDecimal(e.Item.SubItems[7].Text))
                {
                    makeSale(_items_id, e.Item.Text, Convert.ToInt32(e.Item.SubItems[7].Text));
                }
                else
                {
                    if (Convert.ToInt32(TOrdqty - sale_qty) > 0)
                        makeSale(_items_id, e.Item.Text, Convert.ToInt32(TOrdqty - sale_qty));
                    lv_batchno.Enabled = false;
                }
            }
        }
        private void lvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    _index = lvOrder.FocusedItem.Index;
            //    string item_name = lvOrder.Items[lvOrder.FocusedItem.Index].SubItems[1].Text;
            //    objSwap = new eMediShop.Utility.SwapProduct(item_name, 0, lvOrder.Items[lvOrder.FocusedItem.Index].Text, "OnLineOrder", _order_no);
            //    objSwap.SearchUpdated += new SearchCashMemoEventHandler(UpdateItemByNewMed);
            //    objSwap.Show();
            //}
        }
        private void UpdateItemByNewMed(object sender, CashMemeoNoUpdatedEventArgs e)
        {
            string old_itemid = e.CASHMEMONO.Split('|')[0];
            string new_itemid = e.CASHMEMONO.Split('|')[1];
            string new_itemname = e.CASHMEMONO.Split('|')[2];
            customerOrders o = new customerOrders();
            o.order_no = _order_no; o.item_id = new_itemid; o.old_item_id = old_itemid;
            o.new_med = "N/A"; o.qty = 0; o.cancel_flag = "N"; o.logic = "Replace"; o.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/InsertModifycustOrderInfo", o);

            string result = dwr.message;

            if (result.Contains("Successfully"))
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.prm_1 = "N/A"; p.prm_2 = "N/A";
                p.prm_3 = new_itemid + ","; p.Logic = "StockofItems"; p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);
                DataSet dsStock = dwr.result;
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
                    if (Convert.ToDecimal(dsStock.Tables[0].Rows[0]["qty"]) < Convert.ToDecimal(lvOrder.Items[_index].SubItems[3].Text))
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
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.tran_id = _order_no; p.item_id = "-"; p.prm_1 = "Info";
            p.Logic = "GET_ORDER"; p.dtFrom = "1900/01/01";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/rcmqueries", p);
            ds = dwr.result;


            _orderDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["orderDate"].ToString()).ToString("yyyy/MM/dd");
            _promoTag = ds.Tables[0].Rows[0]["pd_flag"].ToString();
            if (CallFrom == "HOLD")
                FillOrderDetail(_order_no);

            DisableButtons();
        }

        private void btnHold_Click(object sender, EventArgs e)
        {

            //Cursor.Current = Cursors.WaitCursor;
            //GlobalUsage.BillType = "UnPosted_RCM";
            //this.frmCashMemoSearch = new CashMemoSearch();
            //this.frmCashMemoSearch.SearchUpdated += new SearchCashMemoEventHandler(Search_SearchUpdated);
            //frmCashMemoSearch.Show();
            //Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void rtBtn_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rtBtn.Tag.ToString() == "HD")
            {
                this.rtBtn.Image = global::eMediShop.Properties.Resources.Pedistrain_32;
                this.rtBtn.Tag = "Self";
                this.toolTip1.SetToolTip(this.rtBtn, "Collect By Customer.");
                updateDeliveryMode(_order_no, "N");
            }
            else
            {
                this.rtBtn.Image = global::eMediShop.Properties.Resources.home_delivery;
                this.rtBtn.Tag = "HD";
                this.toolTip1.SetToolTip(this.rtBtn, "To Be Deliver At Home.");
                updateDeliveryMode(_order_no, "Y");
            }
        }

        private void updateDeliveryMode(string order_no, string HomeDelivery)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = HomeDelivery; p.tran_id = order_no;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/UpdateTablesInfo", p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnRemarks_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            eMediShop.forms.CentralAccess.RCM.order_remarks UseForm = new eMediShop.forms.CentralAccess.RCM.order_remarks(_order_no);
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void chkPromo_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkPromo.Checked)
            //    loadOrder();
        }

        private void rgv_orders_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _ordindex = e.RowIndex;
            radGroupBox1.Text = e.Row.Cells["cust_name"].Value.ToString() + " Order Date: " + Convert.ToDateTime(e.Row.Cells["order_date"].Value).ToString("dd-MM-yyyy") + " Order No.:" + e.Row.Cells["order_no"].Value.ToString() + " (" + e.Row.Cells["promo_flag"].Value.ToString() + ")";
            rcp_panel.HeaderText = e.Row.Cells["info"].Value.ToString();
            _orderDate = Convert.ToDateTime(e.Row.Cells["order_date"].Value).ToString("yyyy/MM/dd");
            _cardNo = e.Row.Cells["card_no"].Value.ToString();//t[1];
            _cardStatus = e.Row.Cells["card_type"].Value.ToString();
            _card_Level = e.Row.Cells["card_type"].Value.ToString();
            _discountPercentage = Convert.ToDecimal(e.Row.Cells["disc_per"].Value);
            txtRemarks.Text = e.Row.Cells["remarks"].Value.ToString();
            _order_no = e.Row.Cells["order_no"].Value.ToString();
            cbxPtName.Text = e.Row.Cells["cust_name"].Value.ToString();
            _contactNo = e.Row.Cells["contactno"].Value.ToString();
            _promoTag = e.Row.Cells["promo_flag"].Value.ToString();
            rcp_panel.IsExpanded = false;
            _deliveryDate = Convert.ToDateTime(e.Row.Cells["del_date"].Value).ToString("dd-MM-yyyy");
            _deliveryTime = e.Row.Cells["del_time"].Value.ToString();
            lblHd.Text = "Home Delivery : " + e.Row.Cells["home_del"].Value.ToString();


            SelectedOrder();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            loadOrder();
        }

        private void btnPrintIS_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult res = MessageBox.Show("Do You want to Print (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_SalesAction1 p = new pm_SalesAction1();
                    p.unit_id = GlobalUsage.Unit_id; p.Sales_Inv_No = txtInvNo.Text; p.order_no = _order_no;
                    p.logic = "HAL:HoldInvInfo";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/GetSalesInvoice_Info", p);
                    DataSet ds = dwr.result;
                    CrystalReportsPharmacy.eMediShop.crHoldOrderPrint rptInternal = new CrystalReportsPharmacy.eMediShop.crHoldOrderPrint();
                    rptInternal.Database.Tables["order_info2"].SetDataSource(ds.Tables[0]);
                    rptInternal.SetParameterValue("sale_inv_no", txtInvNo.Text);
                    rptInternal.SetParameterValue("cust_name", cbxPtName.Text);
                    rptInternal.SetParameterValue("del_date", _deliveryDate);
                    rptInternal.SetParameterValue("del_time", _deliveryTime);
                    rptInternal.PrintToPrinter(1, false, 1, 0);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rcp_panel_Expanded(object sender, EventArgs e)
        {

        }

        private void rgv_orders_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["flag"].Value.ToString() == "Y")
                e.RowElement.ForeColor = Color.Red;
            else
                e.RowElement.ForeColor = Color.Blue;

        }
        private void reset()
        {
            txtInvNo.Text = "New Invoice";
            ItemSaleGrid.Items.Clear();
            lv_batchno.Items.Clear();
            txtTotal.Text = "0"; txtDiscount.Text = "0"; txtRoundoff.Text = "0"; txtPayable.Text = "0";
            btnCompleteSale.Enabled = false;
        }
    }
}
