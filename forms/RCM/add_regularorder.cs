using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.RCM
{
    public partial class add_regularorder : Telerik.WinControls.UI.RadForm
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
                    cm1 p = new cm1();
                    p.Logic = "Search:ForTeleCaller"; p.prm_1 = txtItemName.Text.TrimEnd();
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    DataSet ds = dwr.result;
                    lvNewproduct.Items.Clear();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            lvNewproduct.Items.Add(dr["item_id"].ToString());
                            lvNewproduct.Items[lvNewproduct.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        }
                    }
                    else { _item_id = "New"; lvNewproduct.Visible = false; }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
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

                customerOrders p = new customerOrders();
                p.logic = "Get_PurchasedMed"; p.prm_1 = "N/A"; p.card_no = _CardNo; p.order_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RcmProductInfo", p);
                FillProduct(dwr.result);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

                customerOrders p = new customerOrders();
                p.logic = "Already_Exists"; p.prm_1 = "N/A"; p.card_no = _CardNo; p.order_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RcmProductInfo", p);
                FillProduct(dwr.result);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                customerOrders p = new customerOrders();
                p.card_no = _CardNo;p.item_id = item_id;p.newProductName = new_medname;p.rec_flag = flag;p.login_id = GlobalUsage.Login_id;p.logic = "Insert";
                datasetWithResult dwr=ConfigWebAPI.CallAPI("api/customerdata/InsertRegularOrder", p);
             
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
      
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(_item_id == "New")
             _item_name = txtItemName.Text;
            else
             _item_name = "-";
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
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Delete:RegOrder"; p.tran_id = _CardNo; p.prm_1 = lvItems.Items[lvItems.FocusedItem.Index].Text; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/UpdateTablesInfo", p);
                    if(dwr.message.Contains("Success"))
                    lvItems.Items[lvItems.FocusedItem.Index].Remove();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
