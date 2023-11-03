using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using ExPro.Server;
using System.IO;
namespace eMediShop
{
    public partial class ucGoodsReturn : UserControl
    {
        string _Trf_ID = "New";
        DataSet ds = new DataSet();
        string pItem_Id, pMaster_key_Id, pMfd_Id, pQty;
        DataSet _ds = new DataSet();
        DataSet _dsItem = new DataSet();
        string _Action = "";
        public ucGoodsReturn()
        {
            InitializeComponent();
        }
        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            if (_dsItem.Tables.Count > 0)
            {
                if (_dsItem.Tables[0].Rows.Count > 0)
                {
                    lv_Product.Location = new System.Drawing.Point(2, 62);//5, 187);
                    lv_Product.Size = new System.Drawing.Size(382, 200);
                    lv_Product.Items.Clear();
                    lv_Product.Visible = true;
                    DataRow[] drarr = _dsItem.Tables[0].Select("item_name like '" + txtProdName.Text + "%' ");
                    foreach (DataRow dr in drarr)
                    {
                        lv_Product.Items.Add(dr["item_id"].ToString());
                        lv_Product.Items[lv_Product.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                    }
                }
            }
        }
        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return | e.KeyCode == Keys.Down) && (lv_Product.Items.Count > 0 && txtProdName.Text.Length > 0))
            {
                lv_Product.Focus();
                lv_Product.Items[0].Selected = true;
            }
        }
        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                pItem_Id = lv_Product.FocusedItem.SubItems[0].Text;
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                progressBar1.Visible = true;
                _Action = "ProductDetail";
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
        }
        private void lv_Details_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                    pMaster_key_Id = lv_Details.FocusedItem.SubItems[0].Text;
                    txtBatchNo.Text = lv_Details.FocusedItem.SubItems[1].Text;
                    txtPackSize.Text = lv_Details.FocusedItem.SubItems[2].Text;
                    txtPacQty.Text = lv_Details.FocusedItem.SubItems[3].Text;
                    txtExpDate.Text = lv_Details.FocusedItem.SubItems[4].Text;
                    pMfd_Id = lv_Details.FocusedItem.SubItems[7].Text;

                    lv_Details.Visible = false;
                    txtQty.Focus();
                    txtQty.SelectAll();
            }
        }
        private void txtTransferId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && cbxTrfid.Text == "NEW")
            {

                txtProdName.Focus();
            }

        }
        public void fillListView()
        {
            lv_TrfItem.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem ls = new ListViewItem(dr["Master_key_Id"].ToString());
                        ls.SubItems.Add(dr["rec_id"].ToString());
                        ls.SubItems.Add(dr["item_name"].ToString());
                        ls.SubItems.Add(dr["batch_no"].ToString());
                        ls.SubItems.Add(dr["pack_type"].ToString());
                        ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy"));
                        ls.SubItems.Add(dr["pack_qty"].ToString());
                        ls.SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("###"));
                        lv_TrfItem.Items.Add(ls);
                        lv_TrfItem.Focus();
                        lv_TrfItem.Items[0].Selected = true;
                    }
                    cbxTrfid.Text = _Trf_ID;
                    if (lv_TrfItem.Items.Count > 0)
                        btnComplete.Enabled = true;
                    else
                        btnComplete.Enabled = false;

                }
                if (_ds.Tables[1].Rows.Count > 0)
                {
                    if (_ds.Tables[1].Rows[0]["voucher_no"].ToString().Length > 10)
                        btnComplete.Enabled = false;
                    else
                        btnComplete.Enabled = true;
                }

            }
            txtProdName.Focus();
            txtProdName.SelectAll();
            progressBar1.Visible = false;
        }
        private void lv_TrfItem_KeyDown(object sender, KeyEventArgs e)
        {
            Int32 index = new Int32();
            string result;
            if (e.KeyCode == Keys.Delete)
            {
                index = lv_TrfItem.FocusedItem.Index;
                if (MessageBox.Show("Do You Sure Want To Delete", "Expro Help", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        result = GlobalUsage.pharmacy_proxy.Delete_TransferProduct(lv_TrfItem.Items[lv_TrfItem.FocusedItem.Index].SubItems[1].Text, "N");
                        if (result == "ItemDeleted")
                        {
                            lv_TrfItem.Items[lv_TrfItem.FocusedItem.Index].Remove();
                        }
                        else
                        {
                            MessageBox.Show("Can not delete item  because it's Locked");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            string token = "";
            token = GlobalUsage.pharmacy_proxy.CompleteTransfer(cbxTrfid.Text);
            MessageBox.Show(token);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string result = DateTime.Now.Second.ToString();
            if (_Action == "ProductDetail")
            {
                try
                {
                    _ds = GlobalUsage.pharmacy_proxy.getProductIdentity(pItem_Id, GlobalUsage.Unit_id, "-");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            if (_Action == "TransferProduct")
            {
                string[] Fill_Record_Info = new string[11];
                Fill_Record_Info[0] = "HOLKO";
                Fill_Record_Info[1] = pMaster_key_Id;
                Fill_Record_Info[2] = pQty;
                Fill_Record_Info[3] = _Trf_ID;
                Fill_Record_Info[4] = pMfd_Id;
                Fill_Record_Info[5] = GlobalUsage.Unit_id;
                Fill_Record_Info[6] = GlobalUsage.Login_id;
                Fill_Record_Info[7] = "N/A";
                Fill_Record_Info[8] = "-";
                Fill_Record_Info[9] = "N";
                try
                {
                    string[] ar = GlobalUsage.pharmacy_proxy.TransferStocksOfConsumable(Fill_Record_Info).Split('|');
                    _Trf_ID = ar[1];
                    _Action = "FillListView";
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (_Action == "FillListView")
            {
                try
                {
                    _ds = GlobalUsage.pharmacy_proxy.GoodsReturnRec(out result, _Trf_ID, GlobalUsage.Unit_id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "ProductDetail")
            {
                ProductDetail();
            }
            if (_Action == "TransferProduct")
            {
                cbxTrfid.Text = _Trf_ID;
            }
            if (_Action == "FillListView")
            {
                fillListView();
            }
            progressBar1.Visible = false;
        }
        public void ProductDetail()
        {
            lv_Product.Visible = false;
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    lv_Details.Location = new System.Drawing.Point(150, 62);//5, 187);
                    lv_Details.Size = new System.Drawing.Size(602, 170);
                    lv_Details.Visible = true;
                    lv_Details.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem ls = new ListViewItem(dr["master_key_id"].ToString());
                        ls.SubItems.Add(dr["batch_no"].ToString());
                        ls.SubItems.Add(dr["pack_type"].ToString());
                        ls.SubItems.Add(dr["pack_qty"].ToString());
                        ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd/MM/yyyy"));
                        ls.SubItems.Add(dr["mfd_name"].ToString());
                        ls.SubItems.Add(dr["mfd_id"].ToString());
                        ls.SubItems.Add(dr["qty"].ToString());
                        lv_Details.Items.Add(ls);
                    }
                    lv_Details.Focus();
                    lv_Details.Items[0].Selected = true;
                }
            }

        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pQty = txtQty.Text;
                progressBar1.Visible = true;
                _Action = "TransferProduct";
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }
        private void cbxTrfid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && cbxTrfid.Text == "NEW")
            {

                txtProdName.Focus();
            }
            else if (e.KeyCode == Keys.Return)
            {
                progressBar1.Visible = true;
                _Trf_ID = cbxTrfid.Text;
                _Action = "FillListView";
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }

        }
        private void ucGoodsReturn_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("select trf_id from trf_master where len(voucher_no)<10 and trf_from='" + GlobalUsage.Unit_id + "' ", "eIM_Data");
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    { foreach (DataRow dr in ds.Tables[0].Rows) { cbxTrfid.Items.Add(dr["trf_id"].ToString()); } }
                    else
                    {
                        cbxTrfid.Items.Add("New");
                        cbxTrfid.Text = "New";
                    }
                }
                cbxTrfid.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            if (!File.Exists(Application.StartupPath + "\\InventoryProduct.xml"))
            {
                string qry = "select Item_id,item_name from item_master order by item_name;";
                _dsItem = GlobalUsage.pharmacy_proxy.GetQueryResult2(qry, "eIM_Data");
                _dsItem.WriteXml(Application.StartupPath + "\\InventoryProduct.xml");
            }
            else
            {
                _dsItem.ReadXml(Application.StartupPath + "\\InventoryProduct.xml");
            }
        }

    }
}