using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;
using Telerik.WinControls.UI;

namespace eMediShop.creditNote
{
    public partial class CreditNote_Entries : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();string _result = string.Empty;string _JSON_Result = string.Empty;
        string _accountid = string.Empty;string _customerid = string.Empty;string _saleInvNo = string.Empty;Int32 _maxQty = 0;
        string _creditNoteNo = string.Empty;string _itemID = string.Empty;string _itemName = string.Empty;string _masterkeyid = string.Empty;
        string _batchNo = string.Empty;decimal _usr = 0;decimal _mrp = 0; Int16 _retQty = 0;
        int _packQty = 0;
        DataTable _dtInfo = new DataTable();
        public CreditNote_Entries()
        {
            InitializeComponent();
            _dtInfo.Columns.Add("item_id", typeof(string));
            _dtInfo.Columns.Add("item_name", typeof(string));
            _dtInfo.Columns.Add("master_key_id", typeof(string));
            _dtInfo.Columns.Add("batch_no", typeof(string));
            _dtInfo.Columns.Add("usr", typeof(decimal));
            _dtInfo.Columns.Add("mrp", typeof(decimal));
            _dtInfo.Columns.Add("tax_rate", typeof(decimal));
            _dtInfo.Columns.Add("retqty", typeof(int));
        }

        private void CreditNote_Entries_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "BindCustomer";
                p.prm_1 = "-"; p.prm_2 = "-"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);
                
                rddl_Customer.Items.Clear();
                RadListDataItem dataItem = new RadListDataItem();
                dataItem.Text = "Select";
                dataItem.Value = "Select";
                this.rddl_Customer.Items.Add(dataItem);

                foreach (DataRow dr in dwr.result.Tables[0].Rows) {
                    dataItem = new RadListDataItem();
                    dataItem.Text = dr["customer_name"].ToString();
                    dataItem.Value= dr["customer_id"].ToString();
                    this.rddl_Customer.Items.Add(dataItem);
                }
                rddl_Customer.SelectedIndex = -1;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rtb_ProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rtb_ProductName.TextLength > 2) { 
                     Cursor.Current = Cursors.WaitCursor;
                    pm_debitCreditNotes p = new pm_debitCreditNotes();
                    p.unit_id = GlobalUsage.Unit_id;p.vendor_id = _customerid;p.logic = "GetSoldProdInfo";
                    p.prm_1 = txtDebitNote_No.Text;p.prm_2 = rtb_ProductName.Text;p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);
                    DataTable dt = dwr.result.Tables[0];
                    rgv_SoldProducts.DataSource = dt;
                    if (dt.Rows.Count > 0)
                    {
                        rgv_SoldProducts.Location = new Point(5, 147);
                        rgv_SoldProducts.Size = new Size(500, 335);
                        rgv_SoldProducts.Visible = true;
                    }
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rddl_Customer_SelectedValueChanged(object sender, EventArgs e)
        {
            string[] d = rddl_Customer.SelectedValue.ToString().Split('|');
            _accountid = d[1];_customerid = d[0];
            GetPendingRecords(_customerid);
        }
        private void GetPendingRecords(string customer_id) {
            Cursor.Current = Cursors.WaitCursor;
            pm_debitCreditNotes p = new pm_debitCreditNotes();
            p.unit_id = GlobalUsage.Unit_id; p.vendor_id = customer_id; p.logic = "GetPending";
            p.prm_1 = "-"; p.prm_2 = "-"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);
            DataTable dt = dwr.result.Tables[0];
   
            if (dt.Rows.Count > 0)
            {
                int cnt = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (cnt == 1)
                    {
                        rtb_CreditNoteNo.Text = dr["CreditNote_No"].ToString();
                        txtDebitNote_No.Text= dr["DebitNote_No"].ToString();
                        txtDebitNoteDate.Text = Convert.ToDateTime(dr["debitNote_Date"]).ToString("yyyy/MM/dd");
                        cnt = 0;
                    }
                    addRowInInfo(dr);
                }
                rgv_info.DataSource = _dtInfo;
                total();
                if (_dtInfo.Rows.Count > 0)
                    btnComplete.Enabled = true;
            }
        }

        private void addRowInInfo(DataRow dr)
        {
            DataRow dr1;
            dr1 = _dtInfo.NewRow();
            dr1["item_id"] = dr["item_id"];
            dr1["item_name"] = dr["item_name"];
            dr1["master_key_id"] = dr["master_key_id"];
            dr1["batch_no"] = dr["batch_no"];
            dr1["usr"] = dr["usr"];
            dr1["mrp"] = dr["mrp"];
            dr1["tax_rate"] = dr["tax_rate"];
            dr1["retqty"] = dr["retqty"];
            _dtInfo.Rows.Add(dr1);
        }

        private void rtb_ProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                rgv_SoldProducts.Focus();
                rgv_SoldProducts.Select();

            }
        }

        private void rgv_SoldProducts_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    rgv_SoldProducts.Visible = false;

                    Cursor.Current = Cursors.WaitCursor;
                    string itemid = string.Empty;
                    itemid = rgv_SoldProducts.CurrentRow.Cells[0].Value.ToString();
                    _itemID = itemid;
                    _itemName = rgv_SoldProducts.CurrentRow.Cells[1].Value.ToString();
                    this.rtb_ProductName.TextChanged -= new System.EventHandler(this.rtb_ProductName_TextChanged);
                    rtb_ProductName.Text = _itemName;
                    rgv_SoldProducts.Visible = false;
                    this.rtb_ProductName.TextChanged += new System.EventHandler(this.rtb_ProductName_TextChanged);
                    pm_debitCreditNotes p = new pm_debitCreditNotes();
                    p.unit_id = GlobalUsage.Unit_id; p.vendor_id = _customerid; p.logic = "GetSoldInfo";
                    p.prm_1 = txtDebitNote_No.Text; p.prm_2 = itemid; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);
                    DataTable dt = dwr.result.Tables[0];
                    rgv_keyInfo.Location = new Point(318, 147);
                    rgv_keyInfo.Size = new Size(681, 297);
                    rgv_keyInfo.Visible = true;
                    rgv_keyInfo.DataSource = dt;
                    rgv_keyInfo.Focus();

                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void rgv_keyInfo_KeyUp(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Return)
            {
                rgv_keyInfo.Visible = false;
                _saleInvNo = rgv_keyInfo.CurrentRow.Cells["sale_inv_no"].Value.ToString();
                _packQty = Convert.ToInt16(rgv_keyInfo.CurrentRow.Cells["pack_qty"].Value.ToString());
                rtb_masterkey.Text= rgv_keyInfo.CurrentRow.Cells["master_key_id"].Value.ToString();
                _masterkeyid = rtb_masterkey.Text;
                rtb_batchno.Text = rgv_keyInfo.CurrentRow.Cells["batch_no"].Value.ToString();
                _batchNo = rtb_batchno.Text;
                rtb_usr.Text = rgv_keyInfo.CurrentRow.Cells["usr"].Value.ToString();
                _usr = Convert.ToDecimal(rgv_keyInfo.CurrentRow.Cells["usr"].Value);
                rtb_mrp.Text = rgv_keyInfo.CurrentRow.Cells["mrp"].Value.ToString();
                _mrp = Convert.ToDecimal(rgv_keyInfo.CurrentRow.Cells["usr"].Value);
                rtb_tax_rate.Text = rgv_keyInfo.CurrentRow.Cells["tax_rate"].Value.ToString();
                rtb_qty.Text = Convert.ToInt16(rgv_keyInfo.CurrentRow.Cells["maxqty"].Value).ToString();
                _maxQty = Convert.ToInt32(rgv_keyInfo.CurrentRow.Cells["maxqty"].Value);
                rtb_qty.Focus();
                rtb_qty.SelectAll();
            }
            else if (e.KeyCode == Keys.Escape)
            { rgv_keyInfo.Visible = false; rtb_ProductName.Focus(); rtb_ProductName.SelectAll(); }
            
        }

        private void rtb_qty_Validating(object sender, CancelEventArgs e)
        {
         

        }
        private void SaveEntry()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _creditNoteNo = rtb_CreditNoteNo.Text;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id;p.Note_No = _creditNoteNo;p.qty = Convert.ToInt32(rtb_qty.Text);
                p.org_saleInvNo = _saleInvNo;p.master_key_id = rtb_masterkey.Text;
                p.debitNote_No = txtDebitNote_No.Text;p.debitNote_Date = Convert.ToDateTime(txtDebitNoteDate.Text).ToString("yyyy/MM/dd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteTranInsert", p);

                DataTable dt = dwr.result.Tables[0];
                string cnNo = dt.Rows[0]["result"].ToString();
                if (cnNo.Length > 5)
                    rtb_CreditNoteNo.Text = cnNo;
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = _dtInfo.NewRow();
                    dr["item_id"] = _itemID;
                    dr["item_name"] = _itemName;
                    dr["master_key_id"] = _masterkeyid;
                    dr["batch_no"] = _batchNo;
                    dr["usr"] = Convert.ToDecimal(_usr);
                    dr["mrp"] = Convert.ToDecimal(_mrp);
                    dr["tax_rate"] = Convert.ToDecimal(rtb_tax_rate.Text);
                    dr["retqty"] = Convert.ToInt32(rtb_qty.Text);
                    addRowInInfo(dr);
                    rgv_info.DataSource = _dtInfo;
                    if (_dtInfo.Rows.Count > 0)
                        btnComplete.Enabled = true;
                }
                total();
                reset();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
        private void reset()
        {
            _saleInvNo = string.Empty;
            _packQty = 0;
            rtb_masterkey.Text = "";
            _masterkeyid = string.Empty;
            rtb_batchno.Text = "";
            _batchNo = string.Empty;
            rtb_usr.Text = "0";
            _usr = 0;
            rtb_mrp.Text = "0";
            _mrp = 0;
            rtb_tax_rate.Text = "0";
            rtb_qty.Text = "";
            _maxQty = 0;
           
            rtb_ProductName.Focus();
        }
        public static bool IsNumeric(string str)
        {
            try
            {
                str = str.Trim();
                int foo = int.Parse(str);
                return (true);
            }
            catch (FormatException)
            {
                // Not a numeric value
                return (false);
            }
        }

        private void rtb_qty_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Return)
            { 
            if(IsNumeric(rtb_qty.Text)==true)
            {
                //if ((Convert.ToInt16(rtb_qty.Text) % _packQty) != 0 && Convert.ToInt16(rtb_qty.Text)>_packQty)
                //{
                //    MessageBox.Show("Quantity Should be in multiple of " + _packQty.ToString(), "ExPro Help", MessageBoxButtons.OK);
                //    rtb_qty.Focus(); rtb_qty.SelectAll();
                //    return;
                //}
                SaveEntry();
            }
           }
        }

        private void rgv_info_CommandCellClick(object sender, GridViewCellEventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = _customerid; p.logic = "DeleteFromTran";
                p.prm_1 = rtb_CreditNoteNo.Text; p.prm_2 = e.Row.Cells["master_key_id"].Value.ToString();
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);

                DataTable dt = dwr.result.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow orow in _dtInfo.Rows)
                    {
                        if (orow["master_key_id"].ToString().Equals(e.Row.Cells["master_key_id"].Value.ToString()))
                        {
                            _dtInfo.Rows.Remove(orow);
                        }
                    }
                    //dtInfo.AcceptChanges();
                    
                    rgv_info.DataSource = _dtInfo;
                    total();
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id;p.Note_No = rtb_CreditNoteNo.Text;p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteTranPosting", p);
                if (dwr.message.Contains("Success"))
                {
                    reset();
                    rgv_info.DataSource = new string[] { }; btnComplete.Enabled = false;
                    rtb_CreditNoteNo.Text = "New";
                }
                else
                {
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rtb_qty_Leave(object sender, EventArgs e)
        {
            if (rtb_qty.Text.Length > 0) { 
                if (!IsNumeric(rtb_qty.Text))
                {
                    MessageBox.Show("Quantity Should be number Only", "ExPro Help", MessageBoxButtons.OK);
                    rtb_qty.Focus(); rtb_qty.SelectAll();
                    return;
                }
            }

        }

        private void btnVerifyDebitNote_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "VerifydebitNote";
                p.prm_1 = txtDebitNote_No.Text; p.prm_2 = "-"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);

                DataTable dt = dwr.result.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    txtDebitNoteDate.Text = Convert.ToDateTime(dt.Rows[0]["gr_date"].ToString()).ToString("dd-MM-yyyy");
                    txtDebitNote_No.Enabled = false;
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rtb_ProductName_Enter(object sender, EventArgs e)
        {
            rtb_ProductName.SelectAll();
        }

        private void total() {
            decimal total = 0;
            foreach (DataRow orow in _dtInfo.Rows)
            {
                total += (Convert.ToDecimal(orow["retqty"].ToString()) * Convert.ToDecimal(orow["usr"].ToString()));
            }
            txtTotal.Text = total.ToString("######.00");
        }
    }
    }
