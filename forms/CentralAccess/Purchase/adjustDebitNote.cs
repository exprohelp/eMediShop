using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using ExPro.Server;
using System.Data.SqlClient;
using Telerik.WinControls;

namespace eMediShop
{

    public partial class adjustDebitNote : Telerik.WinControls.UI.RadForm
    {
        private System.Windows.Forms.TextBox ChangeBalPacks = new System.Windows.Forms.TextBox();
        ListViewItem item;
        string subItemText = "";
        int X = 0; int Y = 0; int position = 0;
        DataSet _ds = new DataSet();
        int selectedSubItem = 0;
        string _result = ""; string _purchaseID = string.Empty; string _VendorCode = string.Empty; string _PartyName = string.Empty;
        decimal _adjamount = 0; string _billDate = string.Empty; string _billNo = string.Empty;
        public adjustDebitNote(string PurchaseId, string VendorCode, decimal adjamount, string billDate, string billNo)
        {
            _purchaseID = PurchaseId;
            _VendorCode = VendorCode;
            _adjamount = adjamount;
            InitializeComponent();
            #region Initialize TextBox ChangeBalPacks
            ChangeBalPacks.Size = new System.Drawing.Size(0, 0);
            ChangeBalPacks.Location = new System.Drawing.Point(0, 0);
            ChangeBalPacks.TextAlign = HorizontalAlignment.Right;
            this.lvProductInfo.Controls.Add(this.ChangeBalPacks);
            ChangeBalPacks.LostFocus += new System.EventHandler(this.ChangeBalPacksFocusExit);
            ChangeBalPacks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChangeBalPacksKeyPress);
            ChangeBalPacks.Hide();
            #endregion
        }
        private void ChangeBalPacksKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 27)
            {
                if (e.KeyChar == 13)
                {
                    if (Convert.ToInt32(ChangeBalPacks.Text) <= Convert.ToInt32(item.SubItems[4].Text))
                    {
                        item.SubItems[selectedSubItem].Text = ChangeBalPacks.Text;
                        item.SubItems[6].Text = (Convert.ToInt32(item.SubItems[7].Text) * Convert.ToInt32(ChangeBalPacks.Text)).ToString("####.00");
                        item.Checked = true;
                    }
                    else
                    { MessageBox.Show("Not Valid Quantity"); ChangeBalPacks.Focus(); }
                }
                lvProductInfo.Focus();
            }
        }
        private void ChangeBalPacksFocusExit(object sender, System.EventArgs e)
        {
            ChangeBalPacks.Hide();
        }
        private void TransferStock_Load(object sender, EventArgs e)
        {
            txtAdjusted.Text = _adjamount.ToString();
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 110);
            txtPurchId.Text = _purchaseID;
            button1.Visible = true;
            this.Text = "Debit Note Adjusted In Bill";
            getPendingDebitNotes(_VendorCode, "-");

        }
        private void getPendingDebitNotes(string vendor_id, string debitnoteno)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.lvProductInfo.ItemChecked -= new System.Windows.Forms.ItemCheckedEventHandler(this.lvProductInfo_ItemChecked);
                lvProductInfo.Items.Clear();
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.Note_No = debitnoteno;
                p.logic = "PendingDebitNotes";
                p.prm_1 = "-";
                p.vendor_id = vendor_id; p.searchkey = "-";

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                rgv_debitNotes.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.lvProductInfo.ItemChecked -= new System.Windows.Forms.ItemCheckedEventHandler(this.lvProductInfo_ItemChecked);
                lvProductInfo.Items.Clear();
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.Note_No = txtGRNO.Text;
                p.logic = "DN:AdjustedInBill";
                p.prm_1 = "-";
                p.vendor_id = "-"; p.searchkey = "-";

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                _ds = dwr.result;


                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    grAllottedTo.Text = "Allotted To :" + _ds.Tables[0].Rows[0]["party_ledger"].ToString();
                    _PartyName = _ds.Tables[0].Rows[0]["party_ledger"].ToString();
                }
                if (_ds.Tables.Count > 0 && _ds.Tables[1].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[1].Rows)
                    {
                        ListViewItem lv = new ListViewItem(dr["master_key_id"].ToString());
                        lv.SubItems.Add(dr["item_name"].ToString());
                        lv.SubItems.Add(dr["batch_no"].ToString());
                        if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") == "01-01-1900")
                            lv.SubItems.Add("=");
                        else
                            lv.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yyyy"));
                        lv.SubItems.Add(dr["pack"].ToString());


                        lv.SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("##.00"));
                        if (dr["status_flag"].ToString() == "Y")
                            lv.ForeColor = Color.Yellow;
                        else
                            lv.ForeColor = Color.White;
                        lv.SubItems.Add(dr["npr"].ToString());
                        lv.SubItems.Add(dr["adjustmentType"].ToString());
                        lv.SubItems.Add(dr["status_flag"].ToString());
                        lv.SubItems.Add(dr["quantity"].ToString());
                        lv.SubItems.Add(dr["auto_id"].ToString());
                        if (dr["status_flag"].ToString() == "Y")
                            lv.Checked = true;
                        lvProductInfo.Items.Add(lv);
                    }
                }
                this.lvProductInfo.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProductInfo_ItemChecked);
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void lvProductInfo_MouseDown(object sender, MouseEventArgs e)
        {
            item = lvProductInfo.GetItemAt(e.X, e.Y);
            X = e.X;
            Y = e.Y;
        }
        private void lvProductInfo_Click(object sender, EventArgs e)
        {
            // Check whether the subitem was clicked
            int x = getXaxisWidth(lvProductInfo);
            subItemText = item.SubItems[selectedSubItem].Text;
            string column = lvProductInfo.Columns[selectedSubItem].Text;
            if (column == "BAL. PACK")
            {
                int y = item.Bounds.Bottom - item.Bounds.Top;
                ChangeBalPacks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                ChangeBalPacks.Size = new System.Drawing.Size(x, y);
                ChangeBalPacks.Location = new System.Drawing.Point(position - 25, item.Bounds.Y);
                ChangeBalPacks.Show();
                ChangeBalPacks.Text = subItemText;
                ChangeBalPacks.SelectAll();
                ChangeBalPacks.Focus();
            }
        }
        protected int getXaxisWidth(ListView lv)
        {
            int start = X;
            int end = lv.Columns[0].Width;
            int i = 0;
            for (i = 0; i < lv.Columns.Count; i++)
            {
                if (start > position && start < end)
                {
                    selectedSubItem = i;
                    break;
                }
                position = end;
                end += lv.Columns[i].Width;
                if (start > position && start < end)
                {
                    selectedSubItem = i;
                    break;
                }
            }
            return end - position;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if ((MessageBox.Show("Do You Confirm To Final The GR ? ", "Confirmation", MessageBoxButtons.YesNo).ToString() == "Yes"))
            {
                foreach (ListViewItem lvi in lvProductInfo.Items)
                {
                    if (lvi.SubItems[8].Text == "N" && lvi.Checked)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            pm_debitCreditNotes p = new pm_debitCreditNotes();
                            p.unit_id = GlobalUsage.Unit_id; p.prm_1 = "-"; p.Note_No = txtGRNO.Text;
                            p.master_key_id = lvi.SubItems[0].Text;
                            
                            p.qty = Convert.ToInt16(lvi.SubItems["qty"].Text);
                            p.logic = "Credit Note";p.autoId = lvi.SubItems["auto_id"].Text;
                            p.prm_1 = _billDate; p.prm_2 = _billNo;
                            p.vendor_id = "-"; p.searchkey = "-"; p.login_id = GlobalUsage.Login_id;

                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteMapping", p);
                            lblresult.Text = dwr.message;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ExPro Help");
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }

                MessageBox.Show("Process Result : " + _result, "Result", MessageBoxButtons.OK);
            }
            Cursor.Current = Cursors.Default;
        }

        private void lvProductInfo_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.SubItems[8].Text == "Y")
            {
                this.lvProductInfo.ItemChecked -= new System.Windows.Forms.ItemCheckedEventHandler(this.lvProductInfo_ItemChecked);
                e.Item.Checked = true;
                this.lvProductInfo.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProductInfo_ItemChecked);
                return;
            }
            pm_PurchaseReturn p = new pm_PurchaseReturn();
           
            if (e.Item.Checked)
            {
                txtCalculated.Text = (Convert.ToDecimal(txtCalculated.Text) + Convert.ToDecimal(e.Item.SubItems[6].Text)).ToString("##.00");
            }
            else
            {
                txtCalculated.Text = (Convert.ToDecimal(txtCalculated.Text) - Convert.ToDecimal(e.Item.SubItems[6].Text)).ToString("##.00");
            }

            if (lvProductInfo.CheckedItems.Count == 0)
                txtCalculated.Text = "0";

            if (Convert.ToDecimal(txtCalculated.Text) > Convert.ToDecimal(txtAdjusted.Text)) //&& txtPurchId.Text.ToUpper() != "BY CASH"
            {
                RadMessageBox.Show("Your Selected amount is greater than adjustment amount", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                e.Item.Checked = false;
            }
        }

        private void rgv_debitNotes_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            txtGRNO.Text = e.Row.Cells["debitnoteno"].Value.ToString();
            btnGo.PerformClick();
        }
    }
}


