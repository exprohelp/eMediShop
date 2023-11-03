using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.RCM
{
    public partial class add_regularorder : Form
    {
        string _item_id = string.Empty;
        string _result = string.Empty;
        string _item_name = string.Empty;
        string _CardNo = string.Empty;
        DataSet dsOnload = new DataSet();
        public add_regularorder(string cardno)
        {
            _CardNo = cardno;
            InitializeComponent();
        }
        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != "")
            {
                try
                {
                    lvNewproduct.Visible = true;
                    lvNewproduct.BringToFront();
                    lvNewproduct.Location = new System.Drawing.Point(90,48);
                    lvNewproduct.Size = new System.Drawing.Size(373,150);
                    DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("execute [dbo].[pSearchProduct] '" + txtItemName.Text + "' ", "customer_data");
                    lvNewproduct.Items.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            lvNewproduct.Items.Add(dr["item_id"].ToString());
                            lvNewproduct.Items[lvNewproduct.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        private void chkOld_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOld.Checked)
            { txtItemName.Enabled = false; btnAdd.Enabled = false; LastBillInfo(); btnSubmit.Enabled = true; }
            else
            { txtItemName.Enabled = true; btnAdd.Enabled = true;  btnSubmit.Enabled = false; }
        }
        private void LastBillInfo()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataSet ds = GlobalUsage.pharmacy_proxy.RCM_ProductInfo(out _result, "Get_PurchasedMed","N/A","N/A","N/A",GlobalUsage.Login_id);
                FillProduct(ds);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }
        private void FillProduct(DataSet ds)
        {

            lvItems.Items.Clear();
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (chkOld.Checked)
                        {
                            var item = dsOnload.Tables[0].AsEnumerable().Where(x => x.Field<string>("item_id")==dr["item_id"].ToString());
                            if (item.ToList().Count>0)
                                lvItems.Items.Add(dr["item_id"].ToString()).ForeColor = Color.Green;
                            else
                                lvItems.Items.Add(dr["item_id"].ToString());
                            lvItems.Items[lvItems.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        }
                        else
                        {
                            lvItems.Items.Add(dr["item_id"].ToString()).ForeColor = Color.Green;
                            lvItems.Items[lvItems.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        }
                    }
                }
            }
        }
        private void add_regularorder_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                dsOnload = GlobalUsage.pharmacy_proxy.RCM_ProductInfo(out _result, "Already_Exists", _CardNo,"N/A","N/A", GlobalUsage.Login_id);
                FillProduct(dsOnload);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
    
        }
        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                if (txtItemName.Text.Length > 2)
                {
                    lvNewproduct.Visible = false;
                    InsertRecord("-",txtItemName.Text, "R");
                    if (_result.Contains("Success"))
                    {
                        lvItems.Items.Add("-").ForeColor = Color.Green;
                        lvItems.Items[lvItems.Items.Count - 1].SubItems.Add(txtItemName.Text);
                        txtItemName.Focus();
                        txtItemName.SelectAll();
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            { lvNewproduct.Focus(); if (lvNewproduct.Items.Count > 0) { lvNewproduct.Items[0].Selected = true; } }
        }
        private void lvNewproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               _item_id = lvNewproduct.Items[lvNewproduct.FocusedItem.Index].Text;
                txtItemName.Text= lvNewproduct.Items[lvNewproduct.FocusedItem.Index].SubItems[1].Text;
                btnAdd.Focus(); 
                lvNewproduct.Visible = false;
            }
            if (e.KeyCode == Keys.Escape)
            { lvNewproduct.Visible = false; }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string flag = "R";
            foreach (ListViewItem lv in lvItems.Items)
            {
                if (lv.Checked)
                {
                    InsertRecord(lv.Text,"-", flag);
                    if (_result.Contains("Success"))
                    { lv.ForeColor = Color.Green; }
                }
            }
            Cursor.Current = Cursors.WaitCursor;
        }
        private void InsertRecord(string item_id,string new_medname,string flag)
        {
            try
            {
                GlobalUsage.pharmacy_proxy.InsertRegularOrder(out _result, _CardNo, item_id,new_medname, flag, GlobalUsage.Login_id, "Insert");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
      
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertRecord(_item_id,_item_name, "R");
            if(_result.Contains("Success"))
            {
                lvItems.Items.Add(_item_id).ForeColor = Color.Green; 
                lvItems.Items[lvItems.Items.Count - 1].SubItems.Add(txtItemName.Text);
                txtItemName.Focus();
                txtItemName.SelectAll();
            }
        }

        private void lvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                try
                {
                    string qry = "delete from RegularOrder where card_no='" + _CardNo + "' and item_id='" + lvItems.Items[lvItems.FocusedItem.Index].Text + "' ";
                    GlobalUsage.pharmacy_proxy.QueryExecute(qry, "customer_data");
                    lvItems.Items[lvItems.FocusedItem.Index].Remove();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
    }
}
