using ExPro.Client;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.ManualSales
{
    public partial class ucManualSalesProcess : Telerik.WinControls.UI.RadForm
    {
        private eMediShop.sales.SaleBill_Posting frmsaleBillPosting;
        string _result = string.Empty;string _remarks = string.Empty;
        string _cardNo = string.Empty; string _contactNo = string.Empty;
        string _ManualBillNo = string.Empty; string _saleDate = string.Empty;
        string _items_id = string.Empty;string _ipopType = string.Empty; string _payMode = string.Empty;
        string _uhid = string.Empty; string _ipdNo = string.Empty;
        decimal TOrdqty = 0;int _itemCount = 0; int _itemCountSales = 0;

        int _itemindex = 0;
        int _ordindex = -1;
        ListViewItem item;
        private System.Windows.Forms.TextBox _sale_qty = new System.Windows.Forms.TextBox();
        int selectedSubItem = 0; string column = string.Empty;
        int X = 0; int Y = 0; int position = 0;
        string subItemText = "";
        decimal _discountPercentage = 0;
        DataSet dsOrder = new DataSet();
        public ucManualSalesProcess()
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

        private void loadUnProcessedBills()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //Procedure In Customer_data
                DataSet ds = new DataSet();

                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "PendingBills"; p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailManualBillQueries", p);
                ds = dwr.result;
                var Order = ds.Tables[0].AsEnumerable().Select(s => new
                {
                    ipopType = s.Field<string>("ipopType"),
                    uhid = s.Field<string>("uhid"),
                    ipdNo = s.Field<string>("ipdNo"),
                    payMode = s.Field<string>("payMode"),
                    card_no = s.Field<string>("cardno"),
                    disc_per = s.Field<decimal>("disper"),
                    ManualInvNo = s.Field<string>("ManualInvNo"),
                    cust_name = s.Field<string>("custName"),
                    info = s.Field<string>("info"),
                    sale_date = s.Field<DateTime>("sale_date"),
                    prescribedBy = s.Field<string>("prescribe_by"),
                    contactNo = s.Field<string>("mobileNo"),
                    sale_inv_no = s.Field<string>("sale_inv_no"),
                    Amount = s.Field<decimal>("Amount"),
                    remarks = s.Field<string>("remarks"),
                    ItemCount=s.Field<Int64>("ItemCount")
                });
                rgv_orders.DataSource = Order.ToList();
               





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
                FillOrderDetail(_ManualBillNo);
                Fill_ItemSalesGrid(txtInvNo.Text);

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void FillOrderDetail(string manualInvNo)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                lvOrder.Items.Clear();
                cm1 p2 = new cm1();
                p2.unit_id = GlobalUsage.Unit_id; p2.login_id = GlobalUsage.Login_id;
                p2.Logic = "ManualBillItems"; p2.prm_1 = manualInvNo;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/sales/RetailManualBillQueries", p2);
                dsOrder = dwr1.result;
                rgvManualRecords.DataSource = new string[]{ };
                rgvManualRecords.DataSource = dsOrder.Tables[1];
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

                    var Order = dsOrder.Tables[0].AsEnumerable().Select(s => new { OItemId = s.Field<string>("item_id"), Item_name = s.Field<string>("item_name"), O_Qty = s.Field<decimal>("SoldQty") });
                    var Stock = dsStock.Tables[0].AsEnumerable().Select(l => new { SItemId = l.Field<string>("Item_id"), stk_qty = l.Field<decimal>("qty") });
                    var itemList = (from p in Order
                                    join c in Stock on p.OItemId equals c.SItemId into g
                                    from c in g.DefaultIfEmpty()
                                    select new
                                    {
                                        ItemId = p.OItemId,
                                        ItemName = p.Item_name,
                                        SoldQty = p.O_Qty,
                                        stk_qty = c != null ? c.stk_qty : 0,
                                    }).OrderBy(z => z.ItemName);
                    this.lvOrder.ItemSelectionChanged -= new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrder_ItemSelectionChanged);
                    foreach (var dr in itemList)
                    {
                        ListViewItem lv = new ListViewItem(dr.ItemId);
                        lv.SubItems.Add(dr.ItemName);
                        lv.SubItems.Add(dr.stk_qty.ToString());
                        lv.SubItems.Add(Convert.ToInt16(dr.SoldQty).ToString());
                        if (dr.SoldQty > dr.stk_qty)
                            lvOrder.Items.Add(lv).ForeColor = Color.Red;
                        else
                            lvOrder.Items.Add(lv);

                    }
                    this.lvOrder.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvOrder_ItemSelectionChanged);
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
            _itemCountSales = _ds.Tables[1].AsEnumerable().Select(x => x.Field<string>("item_id")).Distinct().Count();
            ItemSaleGrid.Items.Clear();
            if (_ds.Tables[1].Rows.Count > 0)
            {
                btnCompleteSale.Enabled = true;
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
            else
                btnCompleteSale.Enabled = false;

            if (_ds.Tables[0].Rows.Count > 0)
            {
                #region Filling Summary of Bill
                txtTotal.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["total"]).ToString("####.00");
                txtDiscount.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["discount"]).ToString("####.00");
                txtRoundoff.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["roundoff"]).ToString("####.00");
                txtPayable.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["net"]).ToString("####");
                _cardNo = _ds.Tables[0].Rows[0]["Card_no"].ToString();
                _ManualBillNo = _ds.Tables[0].Rows[0]["order_no"].ToString();

                #endregion
            }
            Cursor.Current = Cursors.Default;
        }

        private void DisableButtons()
        {

            btnCompleteSale.Enabled = false;
            btnPrintIS.Enabled = false;


            if (ItemSaleGrid.Items.Count > 0)
            {
                btnPrintIS.Enabled = true;
                btnCompleteSale.Enabled = true;
            }

        }

     
        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if(_itemCount!=_itemCountSales)
            {
                RadMessageBox.Show("All Manual Bill Items Not Processed.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            btnCompleteSale.Enabled = false;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (((Conversion.Val(txtPayable.Text) > 0) || Conversion.Val(txtPayable.Text) < 0))
                {
                    if (GlobalUsage.Posting_Rights == "Y")
                    {
                        #region Body
                        DialogResult dr = MessageBox.Show("Do You Confirm To Finalize The Bill No. " + txtInvNo.Text + " ? ", "ExPro Help", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                try
                                {
                                    BillPosting b = new BillPosting();
                                    b.sale_inv_no = txtInvNo.Text;b.orderNo = _ManualBillNo;
                                    b.card_no = _cardNo; b.customer_name = txtCustName.Text; b.ipopNo = _ipdNo;
                                    b.prescribedBy = txtRefBy.Text; b.uhidNo = _uhid;
                                    b.amount = Convert.ToInt32(txtPayable.Text);
                                    b.Oldsale_inv_no = "-"; b.mobileNo = "-";
                                    if (_payMode.ToUpper() == "CREDIT")
                                    { b.panelType = "Credit";b.saleType = "IPD"; b.panelName = _remarks; b.AccountID = "16070081"; }
                                    else
                                    { b.panelType = "Cash"; b.saleType = "Walk-In"; b.panelName = "Cash"; b.AccountID = "16040001"; }


                                    this.frmsaleBillPosting = new eMediShop.sales.SaleBill_Posting(b);
                                    this.frmsaleBillPosting.eventBillUpdated += new BillPostingEventHandler(BillPostingUpdated);
                                    frmsaleBillPosting.Owner = this;
                                    frmsaleBillPosting.Show();
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
        private void BillPostingUpdated(object sender, BillPostingUpdatedEventArgs e)
        {
            this.txtInvNo.Text = e.SaleInvNo;
            if (e.result.ToUpper() == "POSTED")
            {
                printCashMemo(txtInvNo.Text);
                reset();
                SubmitButton.PerformClick();
                //rgv_orders.Rows[_ordindex].Delete();
                //rgv_orders.Rows.AsEnumerable().Where(x => x.Cells["ManualInvNo"].Value.ToString() == _ManualBillNo).First().Delete();
            }
        }
        protected void printCashMemo(string inv_no)
        {
            if (MessageBox.Show("Do You Want To Print Bill No " + inv_no, "ExPro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (GlobalUsage.PrinterType.ToUpper().ToUpper() == "LASER")
                    Printing.Laser.CashMemo(inv_no, "Y");
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
                p.counter_id = GlobalUsage.CounterID; p.computer_id = GlobalUsage.computerName;
                if (_payMode.ToUpper() == "CREDIT")
                { p.Sale_Type = "IPD"; p.accountID = "16070081"; }
                else
                { p.Sale_Type = "Walk-In"; p.accountID = "16040001"; }
                p.cust_name = txtCustName.Text; p.prescribedBy = txtRefBy.Text; p.refCode = "New";
                p.item_id = item_id; p.master_key_id = masterkey; p.panelName = _payMode;
               
                p.card_no = _cardNo; p.card_level = "-"; p.sold_qty = Convert.ToDouble(qty);
                p.old_sale_inv_no = GlobalUsage.Old_Sale_Inv_No; p.gstn_no = "="; p.hosp_cr_no = _uhid; p.hosp_ipop_no = _ipdNo;
                p.Cur_sale_inv_no = txtInvNo.Text; p.order_no = _ManualBillNo; p.login_id = GlobalUsage.Login_id;
                p.stateName = GlobalUsage.State; p.couponCode = GlobalUsage.couponCode; p.ContactNo = _contactNo;
                dwr = ConfigWebAPI.CallAPI("api/sales/RetailInsertWalkInSale", p);

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
                p.unit_id = GlobalUsage.Unit_id; p.prm_1 = txtInvNo.Text; p.prm_2 = _ManualBillNo;
                p.prm_3 = item_id + ","; p.Logic = "StockofItems"; p.login_id = GlobalUsage.Login_id;
                dwr = ConfigWebAPI.CallAPI("api/stocks/StocksQueries", p);

                DataSet dsStock = dwr.result;
                if (dsStock.Tables.Count > 0 && dsStock.Tables[0].Rows.Count > 0)
                {
                    var lvorder = lvOrder.Items.Cast<ListViewItem>().Where(x => x.Text == item_id).First();
                    lvorder.SubItems[2].Text = dsStock.Tables[0].Rows[0]["qty"].ToString();
                }
                else
                {
                    var lvorder1 = lvOrder.Items.Cast<ListViewItem>().Where(x => x.Text == item_id).First();
                    lvorder1.SubItems[2].Text = "0";
                }
               
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
                            _itemCountSales = _itemCountSales - 1;
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
                            if (ItemSaleGrid.Items.Count == 0)
                            {
                                txtTotal.Text = "0";
                                txtDiscount.Text = "0";
                                txtRoundoff.Text = "0";
                                txtPayable.Text = "0";
                            }
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
               bool mt= checkMRP(_items_id, Convert.ToDecimal(e.Item.SubItems[5].Text));
                if (!mt)
                {
                    RadMessageBox.Show("MRP Mismatch from Manual Sales.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    return;
                }

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
        private bool checkMRP(string itemID,decimal mrp)
        {
            var t = rgvManualRecords.Rows.AsEnumerable().Where(x => x.Cells["item_id"].Value.ToString() == itemID && Convert.ToDecimal(x.Cells["mrp"].Value)==mrp);
            if (t.Count() > 0)
            return true;
            else
                return false;
        }
        private void lvOrder_KeyDown(object sender, KeyEventArgs e)
        {
           
        } 
     
        private void rgv_orders_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _ordindex = e.RowIndex;
            radGroupBox1.Text = e.Row.Cells["cust_name"].Value.ToString() + " Sale Date: " + Convert.ToDateTime(e.Row.Cells["sale_date"].Value).ToString("dd-MM-yyyy") + " M-Inv. No.:" + e.Row.Cells["ManualInvNo"].Value.ToString();
            rcp_panel.HeaderText = e.Row.Cells["info"].Value.ToString();
            _saleDate = Convert.ToDateTime(e.Row.Cells["sale_date"].Value).ToString("yyyy/MM/dd");
            _cardNo = e.Row.Cells["card_no"].Value.ToString();//t[1];
            _discountPercentage = Convert.ToDecimal(e.Row.Cells["disc_per"].Value);
            _ManualBillNo = e.Row.Cells["ManualInvNo"].Value.ToString();
            txtCustName.Text = e.Row.Cells["cust_name"].Value.ToString();
            txtRefBy.Text= e.Row.Cells["prescribedBy"].Value.ToString();
            _contactNo = e.Row.Cells["contactno"].Value.ToString();
            _ipopType= e.Row.Cells["ipopType"].Value.ToString();
            _payMode = e.Row.Cells["payMode"].Value.ToString();
            _uhid = e.Row.Cells["uhid"].Value.ToString();
            _ipdNo = e.Row.Cells["ipdNo"].Value.ToString();
            lblPayMode.Text = "Pay Mode : " + _payMode;
            _remarks= e.Row.Cells["remarks"].Value.ToString();
            _itemCount = Convert.ToInt16(e.Row.Cells["ItemCount"].Value);
            rcp_panel.IsExpanded = false;
            SelectedOrder();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            loadUnProcessedBills();
        }

       

        private void rcp_panel_Expanded(object sender, EventArgs e)
        {

        }

        private void rgv_orders_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            //if (e.RowElement.RowInfo.Cells["flag"].Value.ToString() == "Y")
            //    e.RowElement.ForeColor = Color.Red;
            //else
            //    e.RowElement.ForeColor = Color.Blue;

        }
        private void reset()
        {
            txtInvNo.Text = "New Invoice";
            ItemSaleGrid.Items.Clear();
            lv_batchno.Items.Clear();
            txtTotal.Text = "0"; txtDiscount.Text = "0"; txtRoundoff.Text = "0"; txtPayable.Text = "0";
            btnCompleteSale.Enabled = false;
            rcp_panel.HeaderText = "-";
            rcp_panel.IsExpanded = true;
            lv_batchno.Items.Clear();
            ItemSaleGrid.Items.Clear();
            lvOrder.Enabled = false;
        }
    }
}
