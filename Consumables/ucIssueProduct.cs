using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace eMediShop
{
    public partial class ucIssueProduct : UserControl
    {
        string _Action = "", _MasterKey = "", _Item_Id = "", _Mfd_Id = ""; int _qty; int _ValidQty;
        DataSet _ds = new DataSet();
        public ucIssueProduct()
        {
            InitializeComponent();
        }
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtProduct.Text.Length > 0)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    _Action = "fillProduct";
                    progressBar1.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_Action == "fillProduct")
            {
                try { _ds = GlobalUsage.pharmacy_proxy.ProductSearchToSale(txtProduct.Text, GlobalUsage.Unit_id); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            if (_Action == "ProductDetail")
            {
                try { _ds = GlobalUsage.pharmacy_proxy.getProductDetail(_Item_Id, GlobalUsage.Unit_id); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "fillProduct")
            {
                fillProduct();
            }
            if (_Action == "ProductDetail")
            {
                fillProductDetailInfo();
            }

            _ds.Clear();
            _ds.Dispose();
            progressBar1.Visible = false;
        }
        private void fillProduct()
        {
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    itemhelpgrid.Items.Clear();
                    itemhelpgrid.Visible = true;
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        itemhelpgrid.Items.Add(dr["item_id"].ToString());
                        itemhelpgrid.Items[itemhelpgrid.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        itemhelpgrid.Items[itemhelpgrid.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                    }
                }
            }
        }
        private void fillProductDetailInfo()
        {
            lv_batchno.Items.Clear();
            lv_batchno.Refresh();
            lv_batchno.Visible = false;
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    itemhelpgrid.Visible = false;
                    lv_batchno.Visible = true;
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        lv_batchno.Items.Add(dr["master_key_id"].ToString());
                        lv_batchno.Items[lv_batchno.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") != "01-01-1900")
                            lv_batchno.Items[lv_batchno.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                        else
                            lv_batchno.Items[lv_batchno.Items.Count - 1].SubItems.Add("");
                        lv_batchno.Items[lv_batchno.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        lv_batchno.Items[lv_batchno.Items.Count - 1].SubItems.Add(dr["mfd_name"].ToString());
                        lv_batchno.Items[lv_batchno.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        lv_batchno.Items[lv_batchno.Items.Count - 1].SubItems.Add(dr["mfd_id"].ToString());
                    }
                    lv_batchno.Focus();
                    lv_batchno.Items[lv_batchno.FocusedItem.Index].Selected = true;
                }
            }
        }
        private void fillIssuedProductList()
        {
            if (_ds.Tables[0].Rows.Count > 0)
            {

                lv_Issued.Items.Clear();
                lv_Issued.Refresh();
                foreach (DataRow dr in _ds.Tables[0].Rows)
                {
                    lv_Issued.Items.Add(dr["item_name"].ToString());
                    lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                    if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") != "01-01-1900")
                        lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                    else
                        lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add("");
                    lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                    lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(dr["issued_qty"].ToString());
                    lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(dr["auto_id"].ToString());
                }
                txtProduct.Focus();
            }

        }
        private void itemhelpgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Item_Id = itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].SubItems[0].Text;
                txtProduct.Text = itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].SubItems[2].Text;
                _Action = "ProductDetail";
            }
        }
        private void lv_batchno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _ValidQty = Convert.ToInt32(lv_batchno.Items[lv_batchno.FocusedItem.Index].SubItems[5].Text);
                _MasterKey = lv_batchno.Items[lv_batchno.FocusedItem.Index].SubItems[0].Text;
                _Mfd_Id = lv_batchno.Items[lv_batchno.FocusedItem.Index].SubItems[6].Text;
                txtbatch.Text = lv_batchno.Items[lv_batchno.FocusedItem.Index].SubItems[1].Text;
                txtExpiry.Text = lv_batchno.Items[lv_batchno.FocusedItem.Index].SubItems[2].Text;
                txtPack.Text = lv_batchno.Items[lv_batchno.FocusedItem.Index].SubItems[3].Text;
                lv_batchno.Visible = false;
                txtqty.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lv_batchno.Visible = false;
                txtProduct.Focus();
            }
        }
        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                itemhelpgrid.Focus();
                itemhelpgrid.Items[0].Selected = true;
            }
        }
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(txtqty.Text) <= _ValidQty)
                    {
                        #region Process Block

                        try
                        {
                            _ds = GlobalUsage.pharmacy_proxy.IssueProduct(_MasterKey, Convert.ToInt32(txtqty.Text), GlobalUsage.Unit_id, _Mfd_Id, GlobalUsage.Login_id);
                            txtbatch.Text = "";
                            txtExpiry.Text = "";
                            txtPack.Text = "";
                            txtqty.Text = "";
                            _qty = 0;
                            _ValidQty = 0;
                            fillIssuedProductList();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                        #endregion
                    }
                    else
                    { MessageBox.Show(_ValidQty.ToString() + " can be issued Only", "Product Issue"); txtqty.Focus(); }
                }
                catch (Exception)
                {
                    txtqty.Focus();
                }
            } Cursor.Current = Cursors.Default;
        }
        private void lv_Issued_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    int AutoId = Convert.ToInt32(lv_Issued.Items[lv_Issued.FocusedItem.Index].SubItems[5].Text);
                    GlobalUsage.pharmacy_proxy.DeleteIssuedItems(AutoId);
                    lv_Issued.Items[lv_Issued.FocusedItem.Index].Remove();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        private void txtqty_Enter(object sender, EventArgs e)
        {
            txtqty.SelectAll();
        }
    }
}