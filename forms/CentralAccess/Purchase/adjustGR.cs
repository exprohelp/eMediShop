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
namespace eMediShop
{

    public partial class adjustGR : Telerik.WinControls.UI.RadForm
    {
        private System.Windows.Forms.TextBox ChangeBalPacks = new System.Windows.Forms.TextBox();
        ListViewItem item;
        string subItemText = "";
        int X = 0; int Y = 0; int position = 0;
        DataSet _ds = new DataSet();
        int selectedSubItem = 0;
        string _result = ""; string _purchaseID = string.Empty; string _VendorCode = string.Empty; string _PartyName = string.Empty;
        decimal _adjamount = 0;
        public adjustGR(string PurchaseId, string VendorCode, decimal adjamount)
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
            //if (_purchaseID == "By Cash")
            button1.Visible = true;
            //else
            //    button1.Visible = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.lvProductInfo.ItemChecked -= new System.Windows.Forms.ItemCheckedEventHandler(this.lvProductInfo_ItemChecked);
                lvProductInfo.Items.Clear();
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "GoodReturnForAdjustment"; p.prm_1 = txtGRNO.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
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
                        lv.SubItems.Add(Convert.ToInt32(dr["BalPack"]).ToString());

                        lv.SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("##.00"));
                        if (Convert.ToInt32(dr["BalPack"]) == 0)
                            lv.ForeColor = Color.Red;
                        else
                            lv.ForeColor = Color.White;
                        lv.SubItems.Add(dr["npr"].ToString());
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
                {
                   
                    pm_PurchaseReturn p = new pm_PurchaseReturn();
                    p.unit_id = GlobalUsage.Unit_id;p.gr_no = txtGRNO.Text;
                    p.party_name = _PartyName;p.amount = Convert.ToDecimal(txtCalculated.Text);p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("pi/purchase/GR_AdjustByCash", p);
                }
                MessageBox.Show("Process Result : " + _result, "Result", MessageBoxButtons.OK);
            }
            Cursor.Current = Cursors.Default;
        }

        private void lvProductInfo_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            pm_PurchaseReturn p = new pm_PurchaseReturn();
            datasetWithResult dwr;
            if (e.Item.Checked)
            {
                txtCalculated.Text = (Convert.ToDecimal(txtCalculated.Text) + Convert.ToDecimal(e.Item.SubItems[6].Text)).ToString("##.00");
                _result = DateTime.Now.Millisecond.ToString();
                if (txtPurchId.Text.ToUpper() != "BY CASH")
                {
                    p.gr_no = txtGRNO.Text; p.purch_id = txtPurchId.Text; p.master_key_id = e.Item.Text;
                    p.adj_pack = Convert.ToInt32(e.Item.SubItems[5].Text); p.login_id = GlobalUsage.Login_id;
                    dwr = ConfigWebAPI.CallAPI("api/purchase/GR_AdjustPack", p);
                }
            }
            else
            {
                txtCalculated.Text = (Convert.ToDecimal(txtCalculated.Text) - Convert.ToDecimal(e.Item.SubItems[6].Text)).ToString("##.00");
                _result = DateTime.Now.Millisecond.ToString();
                if (txtPurchId.Text.ToUpper() != "BY CASH")
                {
                    p.gr_no = txtGRNO.Text; p.purch_id = txtPurchId.Text; p.master_key_id = e.Item.Text;
                    p.adj_pack = 0; p.login_id = GlobalUsage.Login_id;
                    dwr = ConfigWebAPI.CallAPI("api/purchase/GR_AdjustPack", p);
                }
            }

            if (lvProductInfo.CheckedItems.Count == 0)
                txtCalculated.Text = "0";

            if (Convert.ToDecimal(txtCalculated.Text) > Convert.ToDecimal(txtAdjusted.Text)) //&& txtPurchId.Text.ToUpper() != "BY CASH"
            { MessageBox.Show("Your Seleceted amount is greater than adjustment amount"); }
        }

    }
}


