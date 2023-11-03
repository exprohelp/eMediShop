using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.RCM
{
    public partial class ucTakeOrder : UserControl
    {
        private System.Windows.Forms.TextBox txtqty = new System.Windows.Forms.TextBox();
        DataSet _ds = new DataSet();
        string _item_id = "";
        int oldQty = 0;
        private int X = 0;
        private int Y = 0;
        int position = 0;
        string _result = string.Empty;
        string _ItemName = "";
        private ListViewItem item;
        string subItemText = "";
        int selectedSubItem = 0;
        public ucTakeOrder()
        {
            InitializeComponent();
            #region Initialize TextBox Order Quantity
            txtqty.Size = new System.Drawing.Size(0, 0);
            txtqty.Location = new System.Drawing.Point(0, 0);
            txtqty.TextAlign = HorizontalAlignment.Right;
            txtqty.BorderStyle = BorderStyle.FixedSingle;
            this.lvOrder.Controls.Add(this.txtqty);
            txtqty.LostFocus += new System.EventHandler(this.OrderQtyFocusExit);
            txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderQtyKeyPress);
            txtqty.Hide();
            #endregion
        }
        private void OrderQtyFocusExit(object sender, System.EventArgs e)
        {
            txtqty.Hide();
        }
        private void OrderQtyKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 27)
            {
                if (e.KeyChar == 13)
                {
                    if (oldQty != Convert.ToInt32(txtqty.Text))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        //on case of new mediceine
                        if (_item_id == "New")
                            _ItemName = txtItemName.Text;
                        else
                            _ItemName = "-";
                        //end on case of new mediceine
                        item.SubItems[selectedSubItem].Text = txtqty.Text;
                        try
                        {
                            txtOrderNo.Text = GlobalUsage.pharmacy_proxy.RCM_OnCallOrder(txtCardNumber.Text, lblCardHolder.Text, GlobalUsage.Unit_id, txtOrderNo.Text, _item_id, dtdeldate.Value.ToString("yyyy/MM/dd"), cmbdeltime.Text, Convert.ToInt32(txtqty.Text), txtOrderNo.Text, _ItemName, GlobalUsage.Login_id);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        Cursor.Current = Cursors.Default;

                    }
                }
                lvOrder.Focus();
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
        private void lv_Click(object sender, EventArgs e)
        {
            int x = getXaxisWidth(lvOrder);
            subItemText = item.SubItems[selectedSubItem].Text;
            string column = lvOrder.Columns[selectedSubItem].Text;
            if (column == "Qty")
            {
                int y = item.Bounds.Bottom - item.Bounds.Top;
                txtqty.Size = new System.Drawing.Size(x, y);
                txtqty.Location = new System.Drawing.Point(position, item.Bounds.Y);
                txtqty.Show();
                txtqty.Text = subItemText;
                oldQty = Convert.ToInt32(subItemText);
                txtqty.SelectAll();
                txtqty.Focus();
            }
        }
        private void lv_MouseDown(object sender, MouseEventArgs e)
        {
            item = lvOrder.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                _item_id = item.Text;
                X = e.X;
                Y = e.Y;
            }
        }
        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text.Length > 3)
            {
                try
                {
                    lvNewproduct.Visible = true;
                    //lvNewproduct.Location = new System.Drawing.Point(10, 327);
                    //lvNewproduct.Size = new System.Drawing.Size(745,150);
                    _result = DateTime.Now.Second.ToString();

                    Search p = new Search();
                    p.SearchKey = txtItemName.Text; p.Logic = "ALL-Product"; p.unit_id = GlobalUsage.Unit_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductHelp", p);
                    _ds = dwr.result;
                    lvNewproduct.Items.Clear();
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in _ds.Tables[0].Rows)
                        {
                            lvNewproduct.Items.Add(dr["item_id"].ToString());
                            lvNewproduct.Items[lvNewproduct.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                            lvNewproduct.Items[lvNewproduct.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                            lvNewproduct.Items[lvNewproduct.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                            lvNewproduct.Items[lvNewproduct.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        }
                        lvNewproduct.BringToFront();
                    }
                    else { _item_id = "New"; lvNewproduct.Visible = false; }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void txtnewqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtnewqty.Text != "" && txtItemName.Text != "")
                {
                    lvOrder.Items.Add(_item_id);
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(txtItemName.Text);
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(txtnewqty.Text);
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        //on case of new mediceine
                        if (_item_id == "New")
                        {
                            _ItemName = txtItemName.Text;
                            if (_ItemName.Trim().Length < 2)
                            {
                                MessageBox.Show("Please write new medicine name");
                                return;
                            }
                        }
                        else
                            _ItemName = "-";
                        //end on case of new mediceine
                        txtOrderNo.Text = GlobalUsage.pharmacy_proxy.RCM_OnCallOrder(txtCardNumber.Text, lblCardHolder.Text, GlobalUsage.Unit_id, txtOrderNo.Text.Trim(), _item_id, dtdeldate.Value.ToString("yyyy/MM/dd"), cmbdeltime.Text, Convert.ToInt32(txtnewqty.Text), txtOrderNo.Text, _ItemName, GlobalUsage.Login_id);
                        txtnewqty.Text = "";
                        txtItemName.Text = "";
                        txtItemName.Focus();
                        Cursor.Current = Cursors.Default;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            string msg = "";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string hd = "Y";
                if (!chkDeliveryMode.Checked)
                    hd = "N";
                if (txtRemark.Text.Trim().Length > 1)
                {
                    GlobalUsage.pharmacy_proxy.RCM_CompleteOrder(out msg, GlobalUsage.Unit_id, txtOrderNo.Text.Trim(), txtCardNumber.Text, dtdeldate.Value.ToString("yyyy/MM/dd"), cmbdeltime.Text, txtRemark.Text, txtPresBy.Text, hd, "-", "N", "N/A", "FIRSTCALL_COM");
                    MessageBox.Show(msg);
                }
                else
                { MessageBox.Show("Remark is mandatory"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string Msg = GlobalUsage.pharmacy_proxy.RCCreateData(txtCardNumber.Text, dtRmdDate.Value.ToString("yyyy/MM/dd"), cmbtime.SelectedItem.ToString(), GlobalUsage.Unit_id, "", "", GlobalUsage.Login_id, "NewEntry");
                MessageBox.Show(Msg, "Saving Next Call Date");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { lvNewproduct.Focus(); if (lvNewproduct.Items.Count > 0) { lvNewproduct.Items[0].Selected = true; } }
        }
        private void lvNewproduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _item_id = lvNewproduct.Items[lvNewproduct.FocusedItem.Index].Text;
                txtItemName.Text = lvNewproduct.Items[lvNewproduct.FocusedItem.Index].SubItems[1].Text;
                lvNewproduct.Visible = false;
                txtnewqty.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lvNewproduct.Visible = false;
                txtItemName.Focus();
            }
        }

        private void btnAddReg_Click(object sender, EventArgs e)
        {
            add_regularorder OBJ = new add_regularorder(txtCardNumber.Text);
            OBJ.Show();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text.Length > 5)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.healthcard_proxy.HealthCardQueries(out _result, GlobalUsage.Unit_id, "ExistingCardInfo", "1900/01/01", "1900/01/01", txtCardNumber.Text, "N/A", "System");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    btnAddReg.Enabled = true;
                    txtCardNumber.Enabled = false;
                    lblCardHolder.Text = ds.Tables[0].Rows[0]["r_cust_name"].ToString() + "," + ds.Tables[0].Rows[0]["r_Mobile_no"].ToString();
                    pnlOrder.Enabled = true;
                    fillRegularMed();
                }
                else
                { pnlOrder.Enabled = false; lblCardHolder.Text = ""; txtCardNumber.Enabled = true; btnAddReg.Enabled = false; }
                Cursor.Current = Cursors.Default;
            }
        }
        private void fillRegularMed()
        {
            _ds = GlobalUsage.pharmacy_proxy.RCM_ProductInfo(out _result, "CustomerMed_New", "N/A", txtCardNumber.Text, "N/A", GlobalUsage.Login_id);
            FillMediCineName(_ds);
        }
        private void FillMediCineName(DataSet ds)
        {

            lvOrder.Items.Clear();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lvOrder.Items.Add(dr["item_id"].ToString());
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add("0");
                    }
                }
                if (ds.Tables[1].Rows.Count > 0)
                    txtOrderNo.Text = ds.Tables[1].Rows[0]["order_no"].ToString();
                else
                    txtOrderNo.Text = "New";

            }

        }

        private void pnlOrder_Paint(object sender, PaintEventArgs e)
        {
            cmbdeltime.SelectedIndex = 0;
            cmbtime.SelectedIndex = 0;
        }

        private void txtPresBy_Enter(object sender, EventArgs e)
        {
            txtPresBy.SelectAll();
        }

        private void txtCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnGet.PerformClick();
                txtItemName.Focus();
            }
        }
    }
}
