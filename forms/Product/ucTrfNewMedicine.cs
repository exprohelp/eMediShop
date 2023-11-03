using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using eMediShop.Pharmacy;
namespace eMediShop.forms.Product
{
    public partial class ucTrfNewMedicine : UserControl
    {
        string _autoId = ""; string _result = string.Empty;
        public ucTrfNewMedicine()
        {
            InitializeComponent();
        }
        private void fillLocalMedDetail()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "New Product List"; p.prm_1 = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                p.prm_2 = dateTimePicker1.Value.ToString("yyyy/MM/dd"); p.prm_3 = "New";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                DataTable dt =dwr.result.Tables[0];
                int i = 0;
                if (dt.Rows.Count > 0)
                {
                    lv_medicineDet.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        i++;
                        ListViewItem ls = new ListViewItem(dr["auto_id"].ToString());
                        ls.SubItems.Add(i.ToString());
                        ls.SubItems.Add(dr["item_name"].ToString());
                        ls.SubItems.Add(dr["qty"].ToString());
                        lv_medicineDet.Items.Add(ls);
                    }
                }
                else { }//MessageBox.Show("No Item Found", "ExPro Help"); return; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillSearchedProduct();
            }
        }
        protected void FillSearchedProduct()
        {
            if (txtSearch.Text.Trim().Length == 0)
            {
                lv_medicineDet.Focus();
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "N/A"; p.logic = "ProductSearch"; p.prm_1 = txtSearch.Text; p.prm_2 = "N/A";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);


                    lv_CentralmedDet.Items.Clear();
                    if (dwr.result.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in dwr.result.Tables[0].Rows)
                        {
                            ListViewItem ls = new ListViewItem(dr["item_id"].ToString());
                            ls.SubItems.Add(dr["item_name"].ToString());
                            lv_CentralmedDet.Items.Add(ls);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Item Found");
                        lv_medicineDet.Items.RemoveAt(lv_medicineDet.FocusedItem.Index);
                        return;
                    }
                    lv_CentralmedDet.Select();
                    lv_CentralmedDet.Items[0].Selected = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                finally { }
                Cursor.Current = Cursors.Default;
            }
        }
        private void lv_medicineDet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtSearch.Text = lv_medicineDet.FocusedItem.SubItems[2].Text;
                    _autoId = lv_medicineDet.FocusedItem.SubItems[0].Text;
                    txtSearch.Focus();
                    txtSearch.SelectAll();
                }
                catch
                {
                    MessageBox.Show("Put the Product Name");
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void lv_CentralmedDet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateItemCode();
            }
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillGrid();
            }
        }
        protected void FillGrid()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                fillLocalMedDetail();
                if (lv_medicineDet.Items.Count > 0)
                { txtSearch.Enabled = true; }
                else { txtSearch.Enabled = false; }
                Cursor.Current = Cursors.Default;
                lv_medicineDet.Select();
                lv_medicineDet.Items[0].Selected = true;
            }
            catch (Exception ex) { }
        }


        private void ucTrfNewMedicine_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void lv_medicineDet_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
                return;
            txtSearch.Text = lv_medicineDet.FocusedItem.SubItems[2].Text;
            _autoId = lv_medicineDet.FocusedItem.SubItems[0].Text;
            txtSearch.Focus();
            txtSearch.SelectAll();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 2)
                FillSearchedProduct();
        }

        private void lv_CentralmedDet_DoubleClick(object sender, EventArgs e)
        {
            UpdateItemCode();
        }

        protected void UpdateItemCode()
        {


            try
            {
                Cursor.Current = Cursors.WaitCursor;
                prm_newProduct p = new prm_newProduct();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                p.item_id = lv_CentralmedDet.FocusedItem.SubItems[0].Text;
                p.item_name = lv_CentralmedDet.FocusedItem.SubItems[1].Text;p.qty = 0;
                p.action_flag = "N";p.sale_inv_no = _autoId;p.order_no = "N/A";p.logic = "UpdateCode";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/newproduct", p);
                if (dwr.message.Contains("Success"))
                {
                    _autoId = "";
                    lv_CentralmedDet.Items.Clear();
                    txtSearch.Text = "";
                    if (lv_medicineDet.Items.Count > 0)
                    {
                        lv_medicineDet.Select();
                        lv_medicineDet.Items[0].Selected = true;
                    }
                    else { dateTimePicker1.Focus(); dateTimePicker1.Select(); }
                }
                else
                {
                    MessageBox.Show("Error To Update The Code", "ExPro Help");

                }
            }
            catch (Exception ex) { }

            Cursor.Current = Cursors.Default;
        }


    }
}
