using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eMediShop;
public partial class ucStockReceiving : UserControl
    {
        int RowIndex = 0;
        string message = "";
        Int32 pIndex = new Int32();
        string _MasterKeyId = "";
        int tempqty = 0;
        int _Qty = 0;
        int _RecQty = 0;
        DataSet pDs = new DataSet();
        public ucStockReceiving()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                RowIndex = 0;
                Cursor.Current = Cursors.WaitCursor;
                pDs = GlobalUsage.pharmacy_proxy.getListofTransferedItem(GlobalUsage.Unit_id, txtTrfId.Text, Convert.ToInt32(txtReicptCode.Text));
                fillTrfItems();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void fillTrfItems()
        {
            lvtrfGrid.Items.Clear();
            if (pDs.Tables.Count > 0)
            {
                if (pDs.Tables[0].Rows.Count > 0)
                {
                    this.lvtrfGrid.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.lvtrfGrid_KeyDown);
                    foreach (DataRow dr in pDs.Tables[0].Rows)
                    {
                        if (dr["BalRec"].ToString() != "0" && btnUpdate.Enabled == false)
                        {
                            lvtrfGrid.CheckBoxes = true; btnUpdate.Enabled = true;
                            this.lvtrfGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvtrfGrid_KeyDown);
                        }
                        lvtrfGrid.Items.Add(dr["master_key_id"].ToString());
                        lvtrfGrid.Items[lvtrfGrid.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        lvtrfGrid.Items[lvtrfGrid.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") != "01-01-1900")
                            lvtrfGrid.Items[lvtrfGrid.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                        else
                            lvtrfGrid.Items[lvtrfGrid.Items.Count - 1].SubItems.Add("");
                        lvtrfGrid.Items[lvtrfGrid.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        lvtrfGrid.Items[lvtrfGrid.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        lvtrfGrid.Items[lvtrfGrid.Items.Count - 1].SubItems.Add(dr["rcpt_flag"].ToString());
                    }
                    message = "";
                    pDs.Clear();
                    pDs.Dispose();

                }
            }

        }
        private void lvtrfGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pIndex = lvtrfGrid.FocusedItem.Index;
                txtQty.Text = lvtrfGrid.Items[lvtrfGrid.FocusedItem.Index].SubItems[4].Text;
                tempqty = Convert.ToInt32(txtQty.Text);
                txtQty.Focus();
                txtQty.SelectAll();
            }
        }
        private void TrfAll()
        {
            foreach (ListViewItem lvi in lvtrfGrid.SelectedItems)
            {
                string text = lvi.Text;
            }
        }
        private void txtTrfId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtReicptCode.Focus();
            txtReicptCode.SelectAll();
        }
        private void txtReicptCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGo.PerformClick();
        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtQty.Text) < tempqty)
                {
                    lvtrfGrid.Items[pIndex].SubItems[5].Text = txtQty.Text;
                    lvtrfGrid.Items[pIndex].BackColor = Color.Red;
                    lvtrfGrid.Items[pIndex].ForeColor = Color.White;
                    lvtrfGrid.Focus();
                    lvtrfGrid.Items[pIndex].Focused = true;
                }
                else
                {
                    lvtrfGrid.Items[pIndex].SubItems[5].Text = tempqty.ToString();
                    lvtrfGrid.Items[pIndex].BackColor = Color.LightBlue;
                    lvtrfGrid.Items[pIndex].ForeColor = Color.Black;
                    lvtrfGrid.Focus();
                    lvtrfGrid.Items[pIndex].Focused = true;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
        Cursor.Current = Cursors.WaitCursor;
        try
        {
            btnUpdate.Enabled = false;
            DataTable dt = new DataTable();
            dt.Columns.Add("trf_id", typeof(string));
            dt.Columns.Add("master_key_id", typeof(string));
            dt.Columns.Add("trf_qty", typeof(int));
            dt.Columns.Add("rec_qty", typeof(int));
            foreach (ListViewItem lv in lvtrfGrid.Items)
            {
                DataRow dr = dt.NewRow();
                dr["trf_id"] = txtTrfId.Text;
                dr["master_key_id"] = lv.SubItems[0].Text;
                dr["trf_qty"] = Convert.ToInt32(lv.SubItems[4].Text);
                dr["rec_qty"] = Convert.ToInt32(lv.SubItems[5].Text);
                dt.Rows.Add(dr);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            string result = GlobalUsage.pharmacy_proxy.Unit_StockReceiving(ds, GlobalUsage.Login_id);
            lvtrfGrid.Items.Clear();

            MessageBox.Show(result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        Cursor.Current = Cursors.Default;
    }
    }
